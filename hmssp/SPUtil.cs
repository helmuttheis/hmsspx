/* **********************************************************************************************************
 * The MIT License (MIT)																					*
 * 																											*
 * Copyright (c) 2016 Hypermediasystems Ges. f. Software mbH										*
 * Web: http://www.hypermediasystems.de																		*
 * This file is part of hmssp																			*
 * 																											*
 * Permission is hereby granted, free of charge, to any person obtaining a copy								*
 * of this software and associated documentation files (the "Software"), to deal							*
 * in the Software without restriction, including without limitation the rights								*
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell								*
 * copies of the Software, and to permit persons to whom the Software is									*
 * furnished to do so, subject to the following conditions:													*
 * 																											*
 * The above copyright notice and this permission notice shall be included in								*
 * all copies or substantial portions of the Software.														*
 * 																											*
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR								*
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,									*
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE								*
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER									*
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,							*
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN								*
 * THE SOFTWARE.																							*
 ************************************************************************************************************ */ 
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HMS.SP
{
   
    public class SPUtil
    {
        /// <summary>
        /// maxCollectionCount limits the number of items loaded for collections
        /// 
        /// </summary>
        public static long maxCollectionCount = 50;

        

        public static string toString(object str)
        {
            if (str == null)
                return "null";
            return str.ToString();
        }
        public static string dyn_toString(Object obj)
        {
            if (obj == null)
                return "";
            return obj.ToString();
        }
        public static dynamic dyn_Value(dynamic obj)
        {
            if (obj == null)
                return "";
            return obj.Value;
        }
        public static string dyn_ValueSetBoolean(string propName, dynamic objOut, Boolean val)
        {
            objOut.GetType().GetProperty(propName).SetValue(objOut, val, null);
            return propName;
        }
        public static string dyn_ValueSet(string propName, dynamic objIn, dynamic objOut)
        {
            if (objIn == null)
                return propName;
            string UCpropName = propName.Substring(0, 1).ToUpper() + propName.Substring(1);

            var val = objIn[propName];
            if( val == null )
            {                
                val = objIn[UCpropName];
            }
            if (val != null)
            {
                Type destType = objOut.GetType();
                FieldInfo info = destType.GetRuntimeField(propName + "_");
                if (info == null)
                {
                    info = destType.GetRuntimeField(UCpropName + "_");
                }
                    // if the member is not defined as a field it may be a property
                if (info == null)
                {
                    PropertyInfo pInfo = destType.GetRuntimeProperty(propName + "_");
                    if (pInfo == null)
                    {
                        pInfo = destType.GetRuntimeProperty(UCpropName + "_");
                    }
                    if (pInfo != null)
                    {
                        Type srcType = Type.GetType("System.String");
                        if (val.Value == null)
                        {
                            if( pInfo.Name == "__HMSError_" )
                            {
                                pInfo.SetValue(objOut, new HMS.Util.__HMSError(val.ToString()));
                            }
                            else
                            { 
                                pInfo.SetValue(objOut, val.ToString());
                            }
                        }
                        else
                        {
                            srcType = val.Value.GetType();

                            if (srcType.Name == "String" && pInfo.PropertyType.Name == "String")
                            {
                                pInfo.SetValue(objOut, val.Value);
                            }
                            else if (srcType.Name == "String" && pInfo.PropertyType.Name == "Guid")
                            {
                                pInfo.SetValue(objOut, new Guid(val.Value));
                            }
                            else if (pInfo.PropertyType.Name == "String")
                            {
                                pInfo.SetValue(objOut, val.Value.ToString());
                            }
                            else
                            {
                                pInfo.SetValue(objOut, Convert.ChangeType(val.Value, pInfo.PropertyType));
                            }
                        }
                    }
                }
                if (info != null)
                {
                    Type srcType = val.Value.GetType();
                    if (srcType.Name == "String" && info.FieldType.Name == "String")
                    {
                        info.SetValue(objOut, val.Value);
                    }
                    else if (srcType.Name == "String")
                    {
                        if (info.FieldType.Name == "Guid")
                            info.SetValue(objOut, new Guid(val.Value));
                    }
                    else if (info.FieldType.Name == "String")
                    {
                        info.SetValue(objOut, val.Value.ToString());
                    }
                    else
                    {
                        info.SetValue(objOut, Convert.ChangeType(val.Value, info.FieldType));
                    }
                }
            }
            return propName;
        }
        public static void expando2obj(ExpandoObject expObj, Object obj, Type type)
        {
            var ti = type.GetTypeInfo();

            foreach (var fld in ti.DeclaredFields)
            {
                string str = fld.Name + " " + fld.FieldType.ToString();
                if (((IDictionary<String, object>)expObj).ContainsKey(fld.Name))
                {
                    var valStr = ((IDictionary<String, object>)expObj)[fld.Name];
                    var valObj = valStr; ;
                    if (fld.FieldType.Name == "String")
                    {

                    }
                    else if (fld.FieldType.Name == "Boolean")
                    {
                        Boolean val;
                        Boolean.TryParse(valStr.ToString(), out val);
                        valObj = val;
                    }
                    else if (fld.FieldType.Name == "Int32")
                    {
                        Int32 val;
                        Int32.TryParse(valStr.ToString(), out val);
                        valObj = val;
                    }
                    else if (fld.FieldType.Name == "DateTime")
                    {
                        DateTime val;
                        DateTime.TryParse(valStr.ToString(), out val);
                        valObj = val;
                    }
                    else if (fld.FieldType.Name == "Guid")
                    {
                        Guid val;
                        Guid.TryParse(valStr.ToString(), out val);
                        valObj = val;
                    }
                    else
                    {
                        ;
                    }
                    var field = type.GetRuntimeField(fld.Name);
                    if (field != null)
                        field.SetValue(obj, valObj);
                    else
                    {
                        var property = type.GetRuntimeProperty(fld.Name);
                        if (property != null)
                            property.SetValue(obj, valObj);
                        else
                        {
                            ;
                        }

                    }

                }
            }
            foreach (var prop in ti.DeclaredProperties)
            {
                string str = prop.Name + " " + prop.PropertyType.ToString();
                if (((IDictionary<String, object>)expObj).ContainsKey(prop.Name))
                {
                    var valStr = ((IDictionary<String, object>)expObj)[prop.Name];
                    var valObj = valStr;
                    if (prop.PropertyType.Name == "String")
                    {

                    }
                    else if (prop.PropertyType.Name == "Boolean")
                    {
                        Boolean val;
                        Boolean.TryParse(valStr.ToString(), out val);
                        valObj = val;
                    }
                    else if (prop.PropertyType.Name == "Int32")
                    {
                        Int32 val;
                        Int32.TryParse(valStr.ToString(), out val);
                        valObj = val;
                    }
                    else if (prop.PropertyType.Name == "DateTime")
                    {
                        DateTime val;
                        DateTime.TryParse(valStr.ToString(), out val);
                        valObj = val;
                    }
                    else if (prop.PropertyType.Name == "Guid")
                    {
                        Guid val;
                        Guid.TryParse(valStr.ToString(), out val);
                        valObj = val;
                    }
                    else
                    {
                        ;
                    }
                    var field = type.GetRuntimeField(prop.Name);
                    if (field != null)
                        field.SetValue(obj, valObj);
                    else
                    {
                        var property = type.GetRuntimeProperty(prop.Name);
                        if (property != null)
                            property.SetValue(obj, valObj);
                        else
                        {
                            ;
                        }

                    }

                }
            }
        }
    }
}

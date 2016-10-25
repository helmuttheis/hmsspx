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
using System.Reflection;
using Newtonsoft.Json;
namespace HMS.SP{
    /// <summary>
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj246414.aspx#properties</para>
    /// </summary>
    public class RoleDefinition : SPBase{
        [JsonProperty("__HMSError")]
        public HMS.Util.__HMSError __HMSError_ { set; get; }
        [JsonProperty("__status")]
        public SP.__status __status_ { set; get; }
        [JsonProperty("__deferred")]
        public SP.__deferred __deferred_ { set; get; }
        [JsonProperty("__metadata")]
        public SP.__metadata __metadata_ { set; get; }
        public Dictionary<string, string> __rest;
        /// <summary>
        /// <para>Gets or sets a value that specifies the base permissions for the role definition.(s. https://msdn.microsoft.com/en-us/library/office/jj244982.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("BasePermissions")]
        public SP.BasePermissions BasePermissions_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the description of the role definition.(s. https://msdn.microsoft.com/en-us/library/office/jj246343.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Description")]
        public String Description_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the description of the role definition.(s. https://msdn.microsoft.com/en-us/library/office/jj246343.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DescriptionResource")]
        public SP.__deferred DescriptionResource_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the role definition is displayed.(s. https://msdn.microsoft.com/en-us/library/office/jj246068.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Hidden")]
        public Boolean Hidden_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets a value that specifies the Id of the role definition.(s. https://msdn.microsoft.com/en-us/library/office/jj245809.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Id")]
        public Object Id_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the role definition name.(s. https://msdn.microsoft.com/en-us/library/office/jj247011.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Name")]
        public String Name_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the order position of the object in the site collection Permission Levels page.(s. https://msdn.microsoft.com/en-us/library/office/jj246236.aspx) [Number]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Order")]
        public Int32 Order_ { set; get; }
// undefined class SP.RoleType : Object { }
        /// <summary>
        /// <para>Gets a value that specifies the type of the role definition.(s. https://msdn.microsoft.com/en-us/library/office/jj245655.aspx)[SP.RoleType]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("RoleTypeKind")]
        public Object RoleTypeKind_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public RoleDefinition(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(RoleDefinition));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  RoleDefinition()
        {
        }
        public  RoleDefinition(string json)
        {
            if( json == String.Empty )
                return;
            dynamic jobject = Newtonsoft.Json.JsonConvert.DeserializeObject(json);            
            dynamic refObj = jobject;
            if (jobject.d != null)
                refObj = jobject.d;
            string errInfo = "";
            if (refObj.results != null)
            {
                if (refObj.results.Count > 1)
                    errInfo = "Result is Collection, only 1. entry displayed.";
                refObj = refObj.results[0];
            }
            List<string> usedFields = new List<string>();
                usedFields.Add("__HMSError");
            HMS.SP.SPUtil.dyn_ValueSet("__HMSError", refObj, this);
                usedFields.Add("__deferred");
            this.__deferred_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.__deferred));
                usedFields.Add("__metadata");
            this.__metadata_ = new SP.__metadata(HMS.SP.SPUtil.dyn_toString(refObj.__metadata));
                usedFields.Add("BasePermissions");
            this.BasePermissions_ = new SP.BasePermissions(HMS.SP.SPUtil.dyn_toString(refObj.BasePermissions));
                usedFields.Add("Description");
            HMS.SP.SPUtil.dyn_ValueSet("Description", refObj, this);
                usedFields.Add("DescriptionResource");
            this.DescriptionResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.DescriptionResource));
                usedFields.Add("Hidden");
            HMS.SP.SPUtil.dyn_ValueSet("Hidden", refObj, this);
                usedFields.Add("Id");
            HMS.SP.SPUtil.dyn_ValueSet("Id", refObj, this);
                usedFields.Add("Name");
            HMS.SP.SPUtil.dyn_ValueSet("Name", refObj, this);
                usedFields.Add("Order");
            HMS.SP.SPUtil.dyn_ValueSet("Order", refObj, this);
                usedFields.Add("RoleTypeKind");
            HMS.SP.SPUtil.dyn_ValueSet("RoleTypeKind", refObj, this);
            this.__rest = new Dictionary<string, string>();
            var dyn = ((Newtonsoft.Json.Linq.JContainer)refObj).First;
            while (dyn != null)
            {
                string Name = ((Newtonsoft.Json.Linq.JProperty)dyn).Name;
                string Value = ((Newtonsoft.Json.Linq.JProperty)dyn).Value.ToString();
                if ( !usedFields.Contains( Name ))
                    this.__rest.Add( Name, Value);
                dyn = dyn.Next;
            }
            if( errInfo != "")
                this.__HMSError_.info = errInfo;
        }
    }
}

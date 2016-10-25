/* **********************************************************************************************************
 * The MIT License (MIT)																					*
 * 																											*
 * Copyright (c) 2016 Hypermediasystems Ges. f. Software mbH										*
 * Web: http://www.hypermediasystems.de																		*
 * This file is part of hmsspx																			*
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
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hmsspx
{
    // http://www.itdevspace.com/2012/07/parse-xml-to-dynamic-object-in-c.html
    class xml2dyn
    {
        public static void Parse(Boolean ignoreNamespace,dynamic parent, string xml)
        {
            var xDoc = XDocument.Parse(xml);
            xml2dyn.Parse(ignoreNamespace,parent, xDoc.Elements().First());

        }
        public static void Parse(Boolean ignoreNamespace, dynamic parent, XElement node)
        {
            if (node.HasElements)
            {
                if (node.Elements(node.Elements().First().Name.LocalName).Count() > 1)
                {
                    //list
                    var item = new ExpandoObject();
                    var list = new List<dynamic>();
                    foreach (var element in node.Elements())
                    {
                        Parse(ignoreNamespace,list, element);
                    }
                    AddProperty(item, node.Elements().First().Name.LocalName, list);
                    AddProperty(parent, node.Name.ToString(), item);
                }
                else
                {
                    var item = new ExpandoObject();
                    foreach (var attribute in node.Attributes())
                    {
                        if (ignoreNamespace == true)
                            AddProperty(item, attribute.Name.LocalName, attribute.Value.Trim());
                        else
                            AddProperty(item, attribute.Name.ToString(), attribute.Value.Trim());
                    }
                    //element
                    foreach (var element in node.Elements())
                    {
                        Parse(ignoreNamespace,item, element);
                    }
                    if(ignoreNamespace == true )
                        AddProperty(parent, node.Name.LocalName, item);
                    else
                        AddProperty(parent, node.Name.ToString(), item);
                }
            }
            else
            {
                if (ignoreNamespace == true)
                    AddProperty(parent, node.Name.LocalName, node.Value.Trim());
                else
                    AddProperty(parent, node.Name.ToString(), node.Value.Trim());
            }
        }
        private static void AddProperty(dynamic parent, string name, object value)
        {
            if (parent is List<dynamic>)
            {
                (parent as List<dynamic>).Add(value);
            }
            else
            {
                (parent as IDictionary<String, object>)[name] = value;
            }
        }
    }
}

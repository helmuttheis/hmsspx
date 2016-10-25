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
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj246290.aspx#properties</para>
    /// </summary>
    public class ListCreationInformation : SPBase{
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
        /// <para>Gets or sets a value that specifies the list schema of the new list.(s. https://msdn.microsoft.com/en-us/library/office/jj245068.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("CustomSchemaXml")]
        public String CustomSchemaXml_ { set; get; }
// undefined class Dictionary : Object { }
        /// <summary>
        /// <para>Gets or sets a value that specifies the properties of the data source of the new list.(s. https://msdn.microsoft.com/en-us/library/office/jj246626.aspx)[Dictionary]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DataSourceProperties")]
        public Object DataSourceProperties_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the description of the new list.(s. https://msdn.microsoft.com/en-us/library/office/jj246343.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Description")]
        public String Description_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the description of the new list.(s. https://msdn.microsoft.com/en-us/library/office/jj246343.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DescriptionResource")]
        public SP.__deferred DescriptionResource_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the identifier of the document template for the new list.(s. https://msdn.microsoft.com/en-us/library/office/jj246376.aspx) [Number]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DocumentTemplateType")]
        public Int32 DocumentTemplateType_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the new list is displayed on the Quick Launch of the site.(s. https://msdn.microsoft.com/en-us/library/office/jj245448.aspx) [Number]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("QuickLaunchOption")]
        public Int32 QuickLaunchOption_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the feature identifier of the feature that contains the list schema for the new list.(s. https://msdn.microsoft.com/en-us/library/office/jj246691.aspx) [SP.Guid]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("TemplateFeatureId")]
        public Guid TemplateFeatureId_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the list server template of the new list.(s. https://msdn.microsoft.com/en-us/library/office/jj245537.aspx) [Number]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("TemplateType")]
        public Int32 TemplateType_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the display name of the new list.(s. https://msdn.microsoft.com/en-us/library/office/jj245739.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Title")]
        public String Title_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the display name of the new list.(s. https://msdn.microsoft.com/en-us/library/office/jj245739.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("TitleResource")]
        public SP.__deferred TitleResource_ { set; get; }
        /// <summary>
        /// <para>This member is reserved for internal use and is not intended to be used directly from your code.(s. https://msdn.microsoft.com/en-us/library/office/jj246938.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("TypeId")]
        public String TypeId_ { set; get; }
        /// <summary>
        /// <para>Gets or sets value that specifies the site-relative URL of the location for the new list.(s. https://msdn.microsoft.com/en-us/library/office/jj247021.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Url")]
        public String Url_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public ListCreationInformation(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(ListCreationInformation));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  ListCreationInformation()
        {
        }
        public  ListCreationInformation(string json)
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
                usedFields.Add("CustomSchemaXml");
            HMS.SP.SPUtil.dyn_ValueSet("CustomSchemaXml", refObj, this);
                usedFields.Add("DataSourceProperties");
            HMS.SP.SPUtil.dyn_ValueSet("DataSourceProperties", refObj, this);
                usedFields.Add("Description");
            HMS.SP.SPUtil.dyn_ValueSet("Description", refObj, this);
                usedFields.Add("DescriptionResource");
            this.DescriptionResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.DescriptionResource));
                usedFields.Add("DocumentTemplateType");
            HMS.SP.SPUtil.dyn_ValueSet("DocumentTemplateType", refObj, this);
                usedFields.Add("QuickLaunchOption");
            HMS.SP.SPUtil.dyn_ValueSet("QuickLaunchOption", refObj, this);
                usedFields.Add("TemplateFeatureId");
            HMS.SP.SPUtil.dyn_ValueSet("TemplateFeatureId", refObj, this);
                usedFields.Add("TemplateType");
            HMS.SP.SPUtil.dyn_ValueSet("TemplateType", refObj, this);
                usedFields.Add("Title");
            HMS.SP.SPUtil.dyn_ValueSet("Title", refObj, this);
                usedFields.Add("TitleResource");
            this.TitleResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.TitleResource));
                usedFields.Add("TypeId");
            HMS.SP.SPUtil.dyn_ValueSet("TypeId", refObj, this);
                usedFields.Add("Url");
            HMS.SP.SPUtil.dyn_ValueSet("Url", refObj, this);
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

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
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj244790.aspx#properties</para>
    /// </summary>
    public class WebInformation : SPBase{
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
        /// <para>Configuration identifier of the SharePoint Web site.(s. https://msdn.microsoft.com/en-us/library/office/jj838495.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Configuration")]
        public Int16 Configuration_ { set; get; }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj245711.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Created")]
        public Object Created_ { set; get; }
        /// <summary>
        /// <para>Description of the SharePoint Web site.(s. https://msdn.microsoft.com/en-us/library/office/jj246343.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Description")]
        public String Description_ { set; get; }
        /// <summary>
        /// <para>Description of the SharePoint Web site.(s. https://msdn.microsoft.com/en-us/library/office/jj246343.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DescriptionResource")]
        public SP.__deferred DescriptionResource_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>A unique identifier of the SharePoint Web site.(s. https://msdn.microsoft.com/en-us/library/office/jj245809.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Id")]
        public Object Id_ { set; get; }
        /// <summary>
        /// <para>A 32-bit unsigned integer that indicates the locale identifier for the language.(s. https://msdn.microsoft.com/en-us/library/office/jj246110.aspx) [Number]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Language")]
        public Int32 Language_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Date when the last item of the Web site was changed.(s. https://msdn.microsoft.com/en-us/library/office/jj244877.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("LastItemModifiedDate")]
        public Object LastItemModifiedDate_ { set; get; }
        /// <summary>
        /// <para>A DateTime representing the last time a Web site item was changed.(s. https://msdn.microsoft.com/en-us/library/office/jj838569.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ServerRelativeUrl")]
        public String ServerRelativeUrl_ { set; get; }
        /// <summary>
        /// <para>Title of the Web site.(s. https://msdn.microsoft.com/en-us/library/office/jj245739.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Title")]
        public String Title_ { set; get; }
        /// <summary>
        /// <para>Title of the Web site.(s. https://msdn.microsoft.com/en-us/library/office/jj245739.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("TitleResource")]
        public SP.__deferred TitleResource_ { set; get; }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj850931.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("WebTemplate")]
        public Object WebTemplate_ { set; get; }
        /// <summary>
        /// <para>An identifier indicating the Web site template.(s. https://msdn.microsoft.com/en-us/library/office/jj246216.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("WebTemplateId")]
        public Int32 WebTemplateId_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public WebInformation(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(WebInformation));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  WebInformation()
        {
        }
        public  WebInformation(string json)
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
                usedFields.Add("Configuration");
            HMS.SP.SPUtil.dyn_ValueSet("Configuration", refObj, this);
                usedFields.Add("Created");
            HMS.SP.SPUtil.dyn_ValueSet("Created", refObj, this);
                usedFields.Add("Description");
            HMS.SP.SPUtil.dyn_ValueSet("Description", refObj, this);
                usedFields.Add("DescriptionResource");
            this.DescriptionResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.DescriptionResource));
                usedFields.Add("Id");
            HMS.SP.SPUtil.dyn_ValueSet("Id", refObj, this);
                usedFields.Add("Language");
            HMS.SP.SPUtil.dyn_ValueSet("Language", refObj, this);
                usedFields.Add("LastItemModifiedDate");
            HMS.SP.SPUtil.dyn_ValueSet("LastItemModifiedDate", refObj, this);
                usedFields.Add("ServerRelativeUrl");
            HMS.SP.SPUtil.dyn_ValueSet("ServerRelativeUrl", refObj, this);
                usedFields.Add("Title");
            HMS.SP.SPUtil.dyn_ValueSet("Title", refObj, this);
                usedFields.Add("TitleResource");
            this.TitleResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.TitleResource));
                usedFields.Add("WebTemplate");
            HMS.SP.SPUtil.dyn_ValueSet("WebTemplate", refObj, this);
                usedFields.Add("WebTemplateId");
            HMS.SP.SPUtil.dyn_ValueSet("WebTemplateId", refObj, this);
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

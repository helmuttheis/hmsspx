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
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj245645.aspx#properties</para>
    /// </summary>
    public class AppInstance : SPBase{
        [JsonProperty("__HMSError")]
        public HMS.Util.__HMSError __HMSError_ { set; get; }
        [JsonProperty("__status")]
        public SP.__status __status_ { set; get; }
        [JsonProperty("__deferred")]
        public SP.__deferred __deferred_ { set; get; }
        [JsonProperty("__metadata")]
        public SP.__metadata __metadata_ { set; get; }
        public Dictionary<string, string> __rest;
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the encoded claim value for the app principal identifier associated with the app instance.(s. https://msdn.microsoft.com/en-us/library/office/jj245954.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AppPrincipalId")]
        public Object AppPrincipalId_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the absolute URL of the site created during the installation of the app instance that is used to host SharePoint components.(s. https://msdn.microsoft.com/en-us/library/office/jj246051.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AppWebFullUrl")]
        public Object AppWebFullUrl_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the unique identifier of the SP.AppInstance object (sp.js) object.(s. https://msdn.microsoft.com/en-us/library/office/jj245809.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Id")]
        public Object Id_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets whether the app instance is in an error state.(s. https://msdn.microsoft.com/en-us/library/office/jj244838.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("InError")]
        public Object InError_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the base URL of the remote system deployed during the installation of this app instance.(s. https://msdn.microsoft.com/en-us/library/office/jj245525.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("RemoteAppUrl")]
        public Object RemoteAppUrl_ { set; get; }
        /// <summary>
        /// <para>Gets the settings page URL of the current app instance.(s. https://msdn.microsoft.com/en-us/library/office/jj838522.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("SettingsPageUrl")]
        public String SettingsPageUrl_ { set; get; }
        /// <summary>
        /// <para>Gets he SharePoint site containing the Web where this app instance is installed.(s. https://msdn.microsoft.com/en-us/library/office/jj246981.aspx) [SP.Guid]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("SiteId")]
        public Guid SiteId_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the start page of the app instance.(s. https://msdn.microsoft.com/en-us/library/office/jj246128.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("StartPage")]
        public Object StartPage_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the lifecycle of an app instance based on the constants defined by the SP.AppInstanceStatus enumeration (sp.js) enumeration.(s. https://msdn.microsoft.com/en-us/library/office/jj244929.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Status")]
        public Object Status_ { set; get; }
        /// <summary>
        /// <para>Gets the title of the SharePoint app.(s. https://msdn.microsoft.com/en-us/library/office/jj245739.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Title")]
        public String Title_ { set; get; }
        /// <summary>
        /// <para>Gets the title of the SharePoint app.(s. https://msdn.microsoft.com/en-us/library/office/jj245739.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("TitleResource")]
        public SP.__deferred TitleResource_ { set; get; }
        /// <summary>
        /// <para>Gets the identifier of the web where this app is installed.(s. https://msdn.microsoft.com/en-us/library/office/jj246029.aspx) [SP.Guid]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("WebId")]
        public Guid WebId_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public AppInstance(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(AppInstance));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  AppInstance()
        {
        }
        public  AppInstance(string json)
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
                usedFields.Add("AppPrincipalId");
            HMS.SP.SPUtil.dyn_ValueSet("AppPrincipalId", refObj, this);
                usedFields.Add("AppWebFullUrl");
            HMS.SP.SPUtil.dyn_ValueSet("AppWebFullUrl", refObj, this);
                usedFields.Add("Id");
            HMS.SP.SPUtil.dyn_ValueSet("Id", refObj, this);
                usedFields.Add("InError");
            HMS.SP.SPUtil.dyn_ValueSet("InError", refObj, this);
                usedFields.Add("RemoteAppUrl");
            HMS.SP.SPUtil.dyn_ValueSet("RemoteAppUrl", refObj, this);
                usedFields.Add("SettingsPageUrl");
            HMS.SP.SPUtil.dyn_ValueSet("SettingsPageUrl", refObj, this);
                usedFields.Add("SiteId");
            HMS.SP.SPUtil.dyn_ValueSet("SiteId", refObj, this);
                usedFields.Add("StartPage");
            HMS.SP.SPUtil.dyn_ValueSet("StartPage", refObj, this);
                usedFields.Add("Status");
            HMS.SP.SPUtil.dyn_ValueSet("Status", refObj, this);
                usedFields.Add("Title");
            HMS.SP.SPUtil.dyn_ValueSet("Title", refObj, this);
                usedFields.Add("TitleResource");
            this.TitleResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.TitleResource));
                usedFields.Add("WebId");
            HMS.SP.SPUtil.dyn_ValueSet("WebId", refObj, this);
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

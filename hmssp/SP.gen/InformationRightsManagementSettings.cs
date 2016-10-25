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
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj247077.aspx#properties</para>
    /// </summary>
    public class InformationRightsManagementSettings : SPBase{
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
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj247181.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AllowPrint")]
        public Object AllowPrint_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj245870.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AllowScript")]
        public Object AllowScript_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj244828.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AllowWriteCopy")]
        public Object AllowWriteCopy_ { set; get; }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj850822.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DisableDocumentBrowserView")]
        public Object DisableDocumentBrowserView_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj245847.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DocumentAccessExpireDays")]
        public Object DocumentAccessExpireDays_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj246261.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DocumentLibraryProtectionExpireDate")]
        public Object DocumentLibraryProtectionExpireDate_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj246257.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("EnableDocumentAccessExpire")]
        public Object EnableDocumentAccessExpire_ { set; get; }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj850884.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("EnableDocumentBrowserPublishingView")]
        public Object EnableDocumentBrowserPublishingView_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj245688.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("EnableGroupProtection")]
        public Object EnableGroupProtection_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj245582.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("EnableLicenseCacheExpire")]
        public Object EnableLicenseCacheExpire_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj246185.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("GroupName")]
        public Object GroupName_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj247036.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("LicenseCacheExpireDays")]
        public Object LicenseCacheExpireDays_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj247136.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("PolicyDescription")]
        public Object PolicyDescription_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj246908.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("PolicyTitle")]
        public Object PolicyTitle_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public InformationRightsManagementSettings(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(InformationRightsManagementSettings));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  InformationRightsManagementSettings()
        {
        }
        public  InformationRightsManagementSettings(string json)
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
                usedFields.Add("AllowPrint");
            HMS.SP.SPUtil.dyn_ValueSet("AllowPrint", refObj, this);
                usedFields.Add("AllowScript");
            HMS.SP.SPUtil.dyn_ValueSet("AllowScript", refObj, this);
                usedFields.Add("AllowWriteCopy");
            HMS.SP.SPUtil.dyn_ValueSet("AllowWriteCopy", refObj, this);
                usedFields.Add("DisableDocumentBrowserView");
            HMS.SP.SPUtil.dyn_ValueSet("DisableDocumentBrowserView", refObj, this);
                usedFields.Add("DocumentAccessExpireDays");
            HMS.SP.SPUtil.dyn_ValueSet("DocumentAccessExpireDays", refObj, this);
                usedFields.Add("DocumentLibraryProtectionExpireDate");
            HMS.SP.SPUtil.dyn_ValueSet("DocumentLibraryProtectionExpireDate", refObj, this);
                usedFields.Add("EnableDocumentAccessExpire");
            HMS.SP.SPUtil.dyn_ValueSet("EnableDocumentAccessExpire", refObj, this);
                usedFields.Add("EnableDocumentBrowserPublishingView");
            HMS.SP.SPUtil.dyn_ValueSet("EnableDocumentBrowserPublishingView", refObj, this);
                usedFields.Add("EnableGroupProtection");
            HMS.SP.SPUtil.dyn_ValueSet("EnableGroupProtection", refObj, this);
                usedFields.Add("EnableLicenseCacheExpire");
            HMS.SP.SPUtil.dyn_ValueSet("EnableLicenseCacheExpire", refObj, this);
                usedFields.Add("GroupName");
            HMS.SP.SPUtil.dyn_ValueSet("GroupName", refObj, this);
                usedFields.Add("LicenseCacheExpireDays");
            HMS.SP.SPUtil.dyn_ValueSet("LicenseCacheExpireDays", refObj, this);
                usedFields.Add("PolicyDescription");
            HMS.SP.SPUtil.dyn_ValueSet("PolicyDescription", refObj, this);
                usedFields.Add("PolicyTitle");
            HMS.SP.SPUtil.dyn_ValueSet("PolicyTitle", refObj, this);
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

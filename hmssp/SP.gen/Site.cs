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
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj246828.aspx#properties</para>
    /// </summary>
    public class Site : SPBase{
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
        /// <para>Gets or sets a value that specifies whether a designer can be used on this site collection.(s. https://msdn.microsoft.com/en-us/library/office/jj245795.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AllowDesigner")]
        public Boolean AllowDesigner_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether master page editing is allowed on this site collection.(s. https://msdn.microsoft.com/en-us/library/office/jj246572.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AllowMasterPageEditing")]
        public Boolean AllowMasterPageEditing_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether this site collection can be reverted to its base template.(s. https://msdn.microsoft.com/en-us/library/office/jj245168.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AllowRevertFromTemplate")]
        public Boolean AllowRevertFromTemplate_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Whether version to version upgrade is allowed on this site.(s. https://msdn.microsoft.com/en-us/library/office/jj247032.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AllowSelfServiceUpgrade")]
        public Object AllowSelfServiceUpgrade_ { set; get; }
        /// <summary>
        /// <para>Whether upgrade evaluation site collection is allowed.(s. https://msdn.microsoft.com/en-us/library/office/jj245710.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AllowSelfServiceUpgradeEvaluation")]
        public Object AllowSelfServiceUpgradeEvaluation_ { set; get; }
        /// <summary>
        /// <para>Property indicating whether or not this object can be upgraded.(s. https://msdn.microsoft.com/en-us/library/office/jj246530.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("CanUpgrade")]
        public Boolean CanUpgrade_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the major version of this site collection for purposes of major version-level compatibility checks.(s. https://msdn.microsoft.com/en-us/library/office/jj246281.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("CompatibilityLevel")]
        public Object CompatibilityLevel_ { set; get; }
// undefined class EventReceiverDefinitionCollection object. : Object { }
        /// <summary>
        /// <para>Provides event receivers for events that occur at the scope of the site collection.(s. https://msdn.microsoft.com/en-us/library/office/jj244825.aspx)[EventReceiverDefinitionCollection object.]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("EventReceivers")]
        public Object EventReceivers_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the collection of the site collection features for the site collection that contains the site.(s. https://msdn.microsoft.com/en-us/library/office/jj246811.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Features")]
        public SP.FeatureCollection Features_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the GUID that identifies the site collection.(s. https://msdn.microsoft.com/en-us/library/office/jj245809.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Id")]
        public Object Id_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the comment that is used in locking a site collection.(s. https://msdn.microsoft.com/en-us/library/office/jj246735.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("LockIssue")]
        public String LockIssue_ { set; get; }
// undefined class Long : Object { }
        /// <summary>
        /// <para>Gets a value that specifies the maximum number of list items allowed per operation before throttling will occur.(s. https://msdn.microsoft.com/en-us/library/office/jj245050.aspx)[Long]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("MaxItemsPerThrottledOperation")]
        public Object MaxItemsPerThrottledOperation_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the owner of the site collection. (Read-only in sandboxed solutions.)(s. https://msdn.microsoft.com/en-us/library/office/jj246231.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Owner")]
        public SP.User Owner_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Specifies the primary URI of this site collection, including the host name, port number, and path.(s. https://msdn.microsoft.com/en-us/library/office/jj246178.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("PrimaryUri")]
        public Object PrimaryUri_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a Boolean value that specifies whether the site collection is read-only, locked, and unavailable for write access.(s. https://msdn.microsoft.com/en-us/library/office/jj247098.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ReadOnly")]
        public Boolean ReadOnly_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the collection of recycle bin items for the site collection.(s. https://msdn.microsoft.com/en-us/library/office/jj245316.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("RecycleBin")]
        public SP.RecycleBinItemCollection RecycleBin_ { set; get; }
        /// <summary>
        /// <para>Gets a value that returns the top-level site of the site collection.(s. https://msdn.microsoft.com/en-us/library/office/jj245543.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("RootWeb")]
        public SP.Web RootWeb_ { set; get; }
        /// <summary>
        /// <para>Gets the server-relative URL of the root Web site in the site collection.(s. https://msdn.microsoft.com/en-us/library/office/jj838569.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ServerRelativeUrl")]
        public String ServerRelativeUrl_ { set; get; }
        /// <summary>
        /// <para>Property that indicates whether users will be able to share links to              documents that can be accessed without logging in.(s. https://msdn.microsoft.com/en-us/library/office/jj838412.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ShareByLinkEnabled")]
        public Boolean ShareByLinkEnabled_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the URL structure of this site collection is viewable.(s. https://msdn.microsoft.com/en-us/library/office/jj246705.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ShowUrlStructure")]
        public Boolean ShowUrlStructure_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the Visual Upgrade UI of this site collection is displayed.(s. https://msdn.microsoft.com/en-us/library/office/jj245463.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("UiVersionConfigurationEnabled")]
        public Boolean UiVersionConfigurationEnabled_ { set; get; }
        /// <summary>
        /// <para>Specifies the upgrade information of this site collection.(s. https://msdn.microsoft.com/en-us/library/office/jj838574.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("UpgradeInfo")]
        public Object UpgradeInfo_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Specifies a date, after which site collection administrators will be reminded to upgrade the site collection.(s. https://msdn.microsoft.com/en-us/library/office/jj246397.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("UpgradeReminderDate")]
        public Object UpgradeReminderDate_ { set; get; }
        /// <summary>
        /// <para>Specifies whether the site is currently upgrading.(s. https://msdn.microsoft.com/en-us/library/office/jj850783.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Upgrading")]
        public Boolean Upgrading_ { set; get; }
        /// <summary>
        /// <para>Gets the full URL to the root Web site of the site collection, including host name, port number, and path.(s. https://msdn.microsoft.com/en-us/library/office/jj247021.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Url")]
        public String Url_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies usage information about the site, including bandwidth, storage, and the number of visits to the site collection.(s. https://msdn.microsoft.com/en-us/library/office/jj244968.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Usage")]
        public SP.UsageInfo Usage_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the collection of user custom actions for the site collection.(s. https://msdn.microsoft.com/en-us/library/office/jj245601.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("UserCustomActions")]
        public SP.UserCustomActionCollection UserCustomActions_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public Site(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(Site));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  Site()
        {
        }
        public  Site(string json)
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
                usedFields.Add("AllowDesigner");
            HMS.SP.SPUtil.dyn_ValueSet("AllowDesigner", refObj, this);
                usedFields.Add("AllowMasterPageEditing");
            HMS.SP.SPUtil.dyn_ValueSet("AllowMasterPageEditing", refObj, this);
                usedFields.Add("AllowRevertFromTemplate");
            HMS.SP.SPUtil.dyn_ValueSet("AllowRevertFromTemplate", refObj, this);
                usedFields.Add("AllowSelfServiceUpgrade");
            HMS.SP.SPUtil.dyn_ValueSet("AllowSelfServiceUpgrade", refObj, this);
                usedFields.Add("AllowSelfServiceUpgradeEvaluation");
            HMS.SP.SPUtil.dyn_ValueSet("AllowSelfServiceUpgradeEvaluation", refObj, this);
                usedFields.Add("CanUpgrade");
            HMS.SP.SPUtil.dyn_ValueSet("CanUpgrade", refObj, this);
                usedFields.Add("CompatibilityLevel");
            HMS.SP.SPUtil.dyn_ValueSet("CompatibilityLevel", refObj, this);
                usedFields.Add("EventReceivers");
            HMS.SP.SPUtil.dyn_ValueSet("EventReceivers", refObj, this);
                usedFields.Add("Features");
            this.Features_ = new SP.FeatureCollection(HMS.SP.SPUtil.dyn_toString(refObj.Features));
                usedFields.Add("Id");
            HMS.SP.SPUtil.dyn_ValueSet("Id", refObj, this);
                usedFields.Add("LockIssue");
            HMS.SP.SPUtil.dyn_ValueSet("LockIssue", refObj, this);
                usedFields.Add("MaxItemsPerThrottledOperation");
            HMS.SP.SPUtil.dyn_ValueSet("MaxItemsPerThrottledOperation", refObj, this);
                usedFields.Add("Owner");
            this.Owner_ = new SP.User(HMS.SP.SPUtil.dyn_toString(refObj.Owner));
                usedFields.Add("PrimaryUri");
            HMS.SP.SPUtil.dyn_ValueSet("PrimaryUri", refObj, this);
                usedFields.Add("ReadOnly");
            HMS.SP.SPUtil.dyn_ValueSet("ReadOnly", refObj, this);
                usedFields.Add("RecycleBin");
            this.RecycleBin_ = new SP.RecycleBinItemCollection(HMS.SP.SPUtil.dyn_toString(refObj.RecycleBin));
                usedFields.Add("RootWeb");
            this.RootWeb_ = new SP.Web(HMS.SP.SPUtil.dyn_toString(refObj.RootWeb));
                usedFields.Add("ServerRelativeUrl");
            HMS.SP.SPUtil.dyn_ValueSet("ServerRelativeUrl", refObj, this);
                usedFields.Add("ShareByLinkEnabled");
            HMS.SP.SPUtil.dyn_ValueSet("ShareByLinkEnabled", refObj, this);
                usedFields.Add("ShowUrlStructure");
            HMS.SP.SPUtil.dyn_ValueSet("ShowUrlStructure", refObj, this);
                usedFields.Add("UiVersionConfigurationEnabled");
            HMS.SP.SPUtil.dyn_ValueSet("UiVersionConfigurationEnabled", refObj, this);
                usedFields.Add("UpgradeInfo");
            HMS.SP.SPUtil.dyn_ValueSet("UpgradeInfo", refObj, this);
                usedFields.Add("UpgradeReminderDate");
            HMS.SP.SPUtil.dyn_ValueSet("UpgradeReminderDate", refObj, this);
                usedFields.Add("Upgrading");
            HMS.SP.SPUtil.dyn_ValueSet("Upgrading", refObj, this);
                usedFields.Add("Url");
            HMS.SP.SPUtil.dyn_ValueSet("Url", refObj, this);
                usedFields.Add("Usage");
            this.Usage_ = new SP.UsageInfo(HMS.SP.SPUtil.dyn_toString(refObj.Usage));
                usedFields.Add("UserCustomActions");
            this.UserCustomActions_ = new SP.UserCustomActionCollection(HMS.SP.SPUtil.dyn_toString(refObj.UserCustomActions));
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

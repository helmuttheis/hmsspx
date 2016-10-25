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
    /// <para>https://msdn.microsoft.com/en-us/library/office/dn600183.aspx#bk_UpgradeInfo</para>
    /// </summary>
    public class UpgradeInfo : SPBase{
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
        /// <para>The location of the file that contains upgrade errors.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ErrorFile")]
        public String ErrorFile_ { set; get; }
        /// <summary>
        /// <para>The number of errors encountered during the site collection upgrade.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Errors")]
        public Int32 Errors_ { set; get; }
        /// <summary>
        /// <para>The DateTime of the latest upgrade progress update.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("LastUpdated")]
        public DateTime LastUpdated_ { set; get; }
        /// <summary>
        /// <para>The location of the file that contains upgrade log.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("LogFile")]
        public String LogFile_ { set; get; }
        /// <summary>
        /// <para>The DateTime when the site collection upgrade was requested.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("RequestDate")]
        public DateTime RequestDate_ { set; get; }
        /// <summary>
        /// <para>The number of times the site collection upgrade was attempted.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("RetryCount")]
        public Int32 RetryCount_ { set; get; }
        /// <summary>
        /// <para>The DateTime when the site collection upgrade was started.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("StartTime")]
        public DateTime StartTime_ { set; get; }
        /// <summary>
        /// <para>The current status of the site collection upgrade.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Status")]
        public Int32 Status_ { set; get; }
        /// <summary>
        /// <para>The type of upgrade for the site collection. The type can be either a build to build upgrade (value = 0), or a version to version upgrade (value = 1).</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("UpgradeType")]
        public Int32 UpgradeType_ { set; get; }
        /// <summary>
        /// <para>The number of warnings encountered during the site collection upgrade.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Warnings")]
        public Int32 Warnings_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public UpgradeInfo(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(UpgradeInfo));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  UpgradeInfo()
        {
        }
        public  UpgradeInfo(string json)
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
                usedFields.Add("ErrorFile");
            HMS.SP.SPUtil.dyn_ValueSet("ErrorFile", refObj, this);
                usedFields.Add("Errors");
            HMS.SP.SPUtil.dyn_ValueSet("Errors", refObj, this);
                usedFields.Add("LastUpdated");
            HMS.SP.SPUtil.dyn_ValueSet("LastUpdated", refObj, this);
                usedFields.Add("LogFile");
            HMS.SP.SPUtil.dyn_ValueSet("LogFile", refObj, this);
                usedFields.Add("RequestDate");
            HMS.SP.SPUtil.dyn_ValueSet("RequestDate", refObj, this);
                usedFields.Add("RetryCount");
            HMS.SP.SPUtil.dyn_ValueSet("RetryCount", refObj, this);
                usedFields.Add("StartTime");
            HMS.SP.SPUtil.dyn_ValueSet("StartTime", refObj, this);
                usedFields.Add("Status");
            HMS.SP.SPUtil.dyn_ValueSet("Status", refObj, this);
                usedFields.Add("UpgradeType");
            HMS.SP.SPUtil.dyn_ValueSet("UpgradeType", refObj, this);
                usedFields.Add("Warnings");
            HMS.SP.SPUtil.dyn_ValueSet("Warnings", refObj, this);
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

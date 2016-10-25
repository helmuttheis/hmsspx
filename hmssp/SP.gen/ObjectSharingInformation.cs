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
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj246189.aspx#properties</para>
    /// </summary>
    public class ObjectSharingInformation : SPBase{
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
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj246468.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AnonymousEditLink")]
        public Object AnonymousEditLink_ { set; get; }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj246826.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AnonymousViewLink")]
        public Object AnonymousViewLink_ { set; get; }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj246060.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("CanManagePermissions")]
        public Object CanManagePermissions_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj244815.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("HasPendingAccessRequests")]
        public Object HasPendingAccessRequests_ { set; get; }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj850938.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("HasPermissionLevels")]
        public Object HasPermissionLevels_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj246685.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("IsSharedWithCurrentUser")]
        public Object IsSharedWithCurrentUser_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj247205.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("IsSharedWithGuest")]
        public Object IsSharedWithGuest_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj247186.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("IsSharedWithMany")]
        public Object IsSharedWithMany_ { set; get; }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj245569.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("IsSharedWithSecurityGroup")]
        public Object IsSharedWithSecurityGroup_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj247082.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("PendingAccessRequestsLink")]
        public Object PendingAccessRequestsLink_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public ObjectSharingInformation(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(ObjectSharingInformation));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  ObjectSharingInformation()
        {
        }
        public  ObjectSharingInformation(string json)
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
                usedFields.Add("AnonymousEditLink");
            HMS.SP.SPUtil.dyn_ValueSet("AnonymousEditLink", refObj, this);
                usedFields.Add("AnonymousViewLink");
            HMS.SP.SPUtil.dyn_ValueSet("AnonymousViewLink", refObj, this);
                usedFields.Add("CanManagePermissions");
            HMS.SP.SPUtil.dyn_ValueSet("CanManagePermissions", refObj, this);
                usedFields.Add("HasPendingAccessRequests");
            HMS.SP.SPUtil.dyn_ValueSet("HasPendingAccessRequests", refObj, this);
                usedFields.Add("HasPermissionLevels");
            HMS.SP.SPUtil.dyn_ValueSet("HasPermissionLevels", refObj, this);
                usedFields.Add("IsSharedWithCurrentUser");
            HMS.SP.SPUtil.dyn_ValueSet("IsSharedWithCurrentUser", refObj, this);
                usedFields.Add("IsSharedWithGuest");
            HMS.SP.SPUtil.dyn_ValueSet("IsSharedWithGuest", refObj, this);
                usedFields.Add("IsSharedWithMany");
            HMS.SP.SPUtil.dyn_ValueSet("IsSharedWithMany", refObj, this);
                usedFields.Add("IsSharedWithSecurityGroup");
            HMS.SP.SPUtil.dyn_ValueSet("IsSharedWithSecurityGroup", refObj, this);
                usedFields.Add("PendingAccessRequestsLink");
            HMS.SP.SPUtil.dyn_ValueSet("PendingAccessRequestsLink", refObj, this);
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

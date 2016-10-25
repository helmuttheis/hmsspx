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
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj245759.aspx#properties</para>
    /// </summary>
    public class ClientContext : SPBase{
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
        /// <para>Gets or sets the name of the runtime where the current client application is located.(s. https://msdn.microsoft.com/en-us/library/office/dn155791.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ApplicationName")]
        public String ApplicationName_ { set; get; }
        /// <summary>
        /// <para>Gets the current client context of the client-side object model (CSOM) runtime.(s. https://msdn.microsoft.com/en-us/library/office/jj850993.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Current")]
        public SP.ClientContext Current_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that indicates whether form digest handling is enabled.(s. https://msdn.microsoft.com/en-us/library/office/dn155796.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("FormDigestHandlingEnabled")]
        public Boolean FormDigestHandlingEnabled_ { set; get; }
        /// <summary>
        /// <para>Gets a value that indicates whether the client context has a pending request.(s. https://msdn.microsoft.com/en-us/library/office/dn155792.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("HasPendingRequest")]
        public Boolean HasPendingRequest_ { set; get; }
// undefined class SP.ClientRequest : Object { }
        /// <summary>
        /// <para>Gets the client request that is sent to the server when the next executeQueryAsync method is executed.(s. https://msdn.microsoft.com/en-us/library/office/dn155793.aspx)[SP.ClientRequest]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("PendingRequest")]
        public Object PendingRequest_ { set; get; }
// undefined class int : Object { }
        /// <summary>
        /// <para>Gets or sets the request timeout in milliseconds(s. https://msdn.microsoft.com/en-us/library/office/dn155797.aspx)[int]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("RequestTimeout")]
        public Object RequestTimeout_ { set; get; }
        /// <summary>
        /// <para>Gets the build version of Microsoft.SharePoint.Client.ServerRuntime.dll on the server.(s. https://msdn.microsoft.com/en-us/library/office/dn155794.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ServerLibraryVersion")]
        public String ServerLibraryVersion_ { set; get; }
        /// <summary>
        /// <para>Gets the schema version of Microsoft.SharePoint.Client.ServerRuntime.dll on the server.(s. https://msdn.microsoft.com/en-us/library/office/dn155798.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ServerSchemaVersion")]
        public String ServerSchemaVersion_ { set; get; }
        /// <summary>
        /// <para>Gets the version of the current instance of SharePoint 2013.(s. https://msdn.microsoft.com/en-us/library/office/jj247006.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ServerVersion")]
        public String ServerVersion_ { set; get; }
        /// <summary>
        /// <para>Gets the site collection that is associated with the client context.(s. https://msdn.microsoft.com/en-us/library/office/jj246780.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Site")]
        public SP.Site Site_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the trace correlation ID used by the server.(s. https://msdn.microsoft.com/en-us/library/office/dn155795.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("TraceCorrelationId")]
        public String TraceCorrelationId_ { set; get; }
        /// <summary>
        /// <para>Gets the URL associated with the runtime context.(s. https://msdn.microsoft.com/en-us/library/office/jj247021.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Url")]
        public String Url_ { set; get; }
        /// <summary>
        /// <para>Gets the website that is associated with the client context.(s. https://msdn.microsoft.com/en-us/library/office/jj246877.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Web")]
        public SP.Web Web_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public ClientContext(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(ClientContext));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  ClientContext()
        {
        }
        public  ClientContext(string json)
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
                usedFields.Add("ApplicationName");
            HMS.SP.SPUtil.dyn_ValueSet("ApplicationName", refObj, this);
                usedFields.Add("Current");
            this.Current_ = new SP.ClientContext(HMS.SP.SPUtil.dyn_toString(refObj.Current));
                usedFields.Add("FormDigestHandlingEnabled");
            HMS.SP.SPUtil.dyn_ValueSet("FormDigestHandlingEnabled", refObj, this);
                usedFields.Add("HasPendingRequest");
            HMS.SP.SPUtil.dyn_ValueSet("HasPendingRequest", refObj, this);
                usedFields.Add("PendingRequest");
            HMS.SP.SPUtil.dyn_ValueSet("PendingRequest", refObj, this);
                usedFields.Add("RequestTimeout");
            HMS.SP.SPUtil.dyn_ValueSet("RequestTimeout", refObj, this);
                usedFields.Add("ServerLibraryVersion");
            HMS.SP.SPUtil.dyn_ValueSet("ServerLibraryVersion", refObj, this);
                usedFields.Add("ServerSchemaVersion");
            HMS.SP.SPUtil.dyn_ValueSet("ServerSchemaVersion", refObj, this);
                usedFields.Add("ServerVersion");
            HMS.SP.SPUtil.dyn_ValueSet("ServerVersion", refObj, this);
                usedFields.Add("Site");
            this.Site_ = new SP.Site(HMS.SP.SPUtil.dyn_toString(refObj.Site));
                usedFields.Add("TraceCorrelationId");
            HMS.SP.SPUtil.dyn_ValueSet("TraceCorrelationId", refObj, this);
                usedFields.Add("Url");
            HMS.SP.SPUtil.dyn_ValueSet("Url", refObj, this);
                usedFields.Add("Web");
            this.Web_ = new SP.Web(HMS.SP.SPUtil.dyn_toString(refObj.Web));
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

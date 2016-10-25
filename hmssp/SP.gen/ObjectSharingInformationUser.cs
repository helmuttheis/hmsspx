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
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj246430.aspx#properties</para>
    /// </summary>
    public class ObjectSharingInformationUser : SPBase{
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
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj838567.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("CustomRoleNames")]
        public Object CustomRoleNames_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj247058.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Department")]
        public Object Department_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj245397.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Email")]
        public Object Email_ { set; get; }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj838454.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("HasEditPermission")]
        public Object HasEditPermission_ { set; get; }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj838487.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("HasViewPermission")]
        public Object HasViewPermission_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj245809.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Id")]
        public Object Id_ { set; get; }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj851012.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("IsSiteAdmin")]
        public Object IsSiteAdmin_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj246434.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("JobTitle")]
        public Object JobTitle_ { set; get; }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj245589.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("LoginName")]
        public String LoginName_ { set; get; }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj247011.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Name")]
        public String Name_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj245674.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Picture")]
        public Object Picture_ { set; get; }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj838575.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Principal")]
        public SP.Principal Principal_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj245022.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("SipAddress")]
        public Object SipAddress_ { set; get; }
        /// <summary>
        /// <para>(s. https://msdn.microsoft.com/en-us/library/office/jj247106.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("User")]
        public SP.User User_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public ObjectSharingInformationUser(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(ObjectSharingInformationUser));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  ObjectSharingInformationUser()
        {
        }
        public  ObjectSharingInformationUser(string json)
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
                usedFields.Add("CustomRoleNames");
            HMS.SP.SPUtil.dyn_ValueSet("CustomRoleNames", refObj, this);
                usedFields.Add("Department");
            HMS.SP.SPUtil.dyn_ValueSet("Department", refObj, this);
                usedFields.Add("Email");
            HMS.SP.SPUtil.dyn_ValueSet("Email", refObj, this);
                usedFields.Add("HasEditPermission");
            HMS.SP.SPUtil.dyn_ValueSet("HasEditPermission", refObj, this);
                usedFields.Add("HasViewPermission");
            HMS.SP.SPUtil.dyn_ValueSet("HasViewPermission", refObj, this);
                usedFields.Add("Id");
            HMS.SP.SPUtil.dyn_ValueSet("Id", refObj, this);
                usedFields.Add("IsSiteAdmin");
            HMS.SP.SPUtil.dyn_ValueSet("IsSiteAdmin", refObj, this);
                usedFields.Add("JobTitle");
            HMS.SP.SPUtil.dyn_ValueSet("JobTitle", refObj, this);
                usedFields.Add("LoginName");
            HMS.SP.SPUtil.dyn_ValueSet("LoginName", refObj, this);
                usedFields.Add("Name");
            HMS.SP.SPUtil.dyn_ValueSet("Name", refObj, this);
                usedFields.Add("Picture");
            HMS.SP.SPUtil.dyn_ValueSet("Picture", refObj, this);
                usedFields.Add("Principal");
            this.Principal_ = new SP.Principal(HMS.SP.SPUtil.dyn_toString(refObj.Principal));
                usedFields.Add("SipAddress");
            HMS.SP.SPUtil.dyn_ValueSet("SipAddress", refObj, this);
                usedFields.Add("User");
            this.User_ = new SP.User(HMS.SP.SPUtil.dyn_toString(refObj.User));
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

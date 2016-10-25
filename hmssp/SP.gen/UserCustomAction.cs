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
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj245920.aspx#properties</para>
    /// </summary>
    public class UserCustomAction : SPBase{
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
        /// <para>Gets or sets a value that specifies an implementation specific XML fragment that determines user interface properties of the custom action.(s. https://msdn.microsoft.com/en-us/library/office/jj244922.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("CommandUIExtension")]
        public String CommandUIExtension_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the description of the custom action.(s. https://msdn.microsoft.com/en-us/library/office/jj246343.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Description")]
        public String Description_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the description of the custom action.(s. https://msdn.microsoft.com/en-us/library/office/jj246343.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DescriptionResource")]
        public SP.__deferred DescriptionResource_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies an implementation-specific value that determines the position of the custom action in the page.(s. https://msdn.microsoft.com/en-us/library/office/jj245924.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Group")]
        public String Group_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets a value that specifies the identifier of the custom action.(s. https://msdn.microsoft.com/en-us/library/office/jj245809.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Id")]
        public Object Id_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the URL of the image associated with the custom action.(s. https://msdn.microsoft.com/en-us/library/office/jj245413.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public String ImageUrl_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the location of the custom action.(s. https://msdn.microsoft.com/en-us/library/office/jj245731.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Location")]
        public String Location_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the name of the custom action.(s. https://msdn.microsoft.com/en-us/library/office/jj247011.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Name")]
        public String Name_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the value that specifies the identifier of the object associated with the custom action.(s. https://msdn.microsoft.com/en-us/library/office/jj246754.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("RegistrationId")]
        public String RegistrationId_ { set; get; }
// undefined class SP.UserCustomActionRegistrationType : Object { }
        /// <summary>
        /// <para>Gets or sets the value that specifies the type of object associated with the custom action.(s. https://msdn.microsoft.com/en-us/library/office/jj244938.aspx)[SP.UserCustomActionRegistrationType]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("RegistrationType")]
        public Object RegistrationType_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the value that specifies the permissions needed for the custom action.(s. https://msdn.microsoft.com/en-us/library/office/jj245623.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Rights")]
        public SP.BasePermissions Rights_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the scope of the custom action.(s. https://msdn.microsoft.com/en-us/library/office/jj247140.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Scope")]
        public String Scope_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the value that specifies the ECMAScript to be executed when the custom action is performed.(s. https://msdn.microsoft.com/en-us/library/office/jj246651.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ScriptBlock")]
        public String ScriptBlock_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the URI of a file which contains the ECMAScript to execute on the page.(s. https://msdn.microsoft.com/en-us/library/office/jj245179.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ScriptSrc")]
        public String ScriptSrc_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the value that specifies an implementation-specific value that determines the order of the custom action that appears on the page.(s. https://msdn.microsoft.com/en-us/library/office/jj246287.aspx) [Number]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Sequence")]
        public Int32 Sequence_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the display title of the custom action.(s. https://msdn.microsoft.com/en-us/library/office/jj245739.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Title")]
        public String Title_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the display title of the custom action.(s. https://msdn.microsoft.com/en-us/library/office/jj245739.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("TitleResource")]
        public SP.__deferred TitleResource_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the URL, URI, or ECMAScript (JScript, JavaScript) function associated with the action.(s. https://msdn.microsoft.com/en-us/library/office/jj247021.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Url")]
        public String Url_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies an implementation specific version identifier.(s. https://msdn.microsoft.com/en-us/library/office/jj245883.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("VersionOfUserCustomAction")]
        public String VersionOfUserCustomAction_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public UserCustomAction(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(UserCustomAction));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  UserCustomAction()
        {
        }
        public  UserCustomAction(string json)
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
                usedFields.Add("CommandUIExtension");
            HMS.SP.SPUtil.dyn_ValueSet("CommandUIExtension", refObj, this);
                usedFields.Add("Description");
            HMS.SP.SPUtil.dyn_ValueSet("Description", refObj, this);
                usedFields.Add("DescriptionResource");
            this.DescriptionResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.DescriptionResource));
                usedFields.Add("Group");
            HMS.SP.SPUtil.dyn_ValueSet("Group", refObj, this);
                usedFields.Add("Id");
            HMS.SP.SPUtil.dyn_ValueSet("Id", refObj, this);
                usedFields.Add("ImageUrl");
            HMS.SP.SPUtil.dyn_ValueSet("ImageUrl", refObj, this);
                usedFields.Add("Location");
            HMS.SP.SPUtil.dyn_ValueSet("Location", refObj, this);
                usedFields.Add("Name");
            HMS.SP.SPUtil.dyn_ValueSet("Name", refObj, this);
                usedFields.Add("RegistrationId");
            HMS.SP.SPUtil.dyn_ValueSet("RegistrationId", refObj, this);
                usedFields.Add("RegistrationType");
            HMS.SP.SPUtil.dyn_ValueSet("RegistrationType", refObj, this);
                usedFields.Add("Rights");
            this.Rights_ = new SP.BasePermissions(HMS.SP.SPUtil.dyn_toString(refObj.Rights));
                usedFields.Add("Scope");
            HMS.SP.SPUtil.dyn_ValueSet("Scope", refObj, this);
                usedFields.Add("ScriptBlock");
            HMS.SP.SPUtil.dyn_ValueSet("ScriptBlock", refObj, this);
                usedFields.Add("ScriptSrc");
            HMS.SP.SPUtil.dyn_ValueSet("ScriptSrc", refObj, this);
                usedFields.Add("Sequence");
            HMS.SP.SPUtil.dyn_ValueSet("Sequence", refObj, this);
                usedFields.Add("Title");
            HMS.SP.SPUtil.dyn_ValueSet("Title", refObj, this);
                usedFields.Add("TitleResource");
            this.TitleResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.TitleResource));
                usedFields.Add("Url");
            HMS.SP.SPUtil.dyn_ValueSet("Url", refObj, this);
                usedFields.Add("VersionOfUserCustomAction");
            HMS.SP.SPUtil.dyn_ValueSet("VersionOfUserCustomAction", refObj, this);
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

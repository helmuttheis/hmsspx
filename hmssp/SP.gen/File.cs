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
    /// <para>https://msdn.microsoft.com/en-us/library/office/dn450841.aspx#bk_File</para>
    /// </summary>
    public class File : SPBase,iSP{
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
        /// <para>Gets a value that specifies the user who added the file.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Author")]
        public SP.User Author_ { set; get; }
        /// <summary>
        /// <para>Gets a value that returns the user who has checked out the file.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("CheckedOutByUser")]
        public SP.User CheckedOutByUser_ { set; get; }
        /// <summary>
        /// <para>Gets a value that returns the comment used when a document is checked in to a document library.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("CheckInComment")]
        public String CheckInComment_ { set; get; }
        /// <summary>
        /// <para>Gets a value that indicates how the file is checked out of a document library. Represents an SP.CheckOutType value: Online = 0; Offline = 1; None = 2.The checkout state of a file is independent of its locked state.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("CheckOutType")]
        public Int32 CheckOutType_ { set; get; }
        /// <summary>
        /// <para>Returns internal version of content, used to validate document equality for read purposes.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ContentTag")]
        public String ContentTag_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the customization status of the file. Represents an SP.CustomizedPageStatus value: None = 0; Uncustomized = 1; Customized = 2.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("CustomizedPageStatus")]
        public Int32 CustomizedPageStatus_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the ETag value.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ETag")]
        public String ETag_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the file exists.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Exists")]
        public Boolean Exists_ { set; get; }
        /// <summary>
        /// <para>Gets the size of the file in bytes, excluding the size of any Web Parts that are used in the file.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Length")]
        public Int64 Length_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the publishing level of the file. Represents an SP.FileLevel value: Published = 1; Draft = 2; Checkout = 255.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Level")]
        public Byte Level_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the list item field values for the list item corresponding to the file.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("ListItemAllFields")]
        public SP.ListItem ListItemAllFields_ { set; get; }
        /// <summary>
        /// <para>Gets a value that returns the user that owns the current lock on the file.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("LockedByUser")]
        public SP.User LockedByUser_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the major version of the file.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("MajorVersion")]
        public Int32 MajorVersion_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the minor version of the file.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("MinorVersion")]
        public Int32 MinorVersion_ { set; get; }
        /// <summary>
        /// <para>Gets a value that returns the user who last modified the file.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("ModifiedBy")]
        public SP.User ModifiedBy_ { set; get; }
        /// <summary>
        /// <para>Gets the name of the file including the extension.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Name")]
        public String Name_ { set; get; }
        /// <summary>
        /// <para>Gets the relative URL of the file based on the URL for the server.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ServerRelativeUrl")]
        public String ServerRelativeUrl_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies when the file was created.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("TimeCreated")]
        public DateTime TimeCreated_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies when the file was last modified.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("TimeLastModified")]
        public DateTime TimeLastModified_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the display name of the file.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Title")]
        public String Title_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the display name of the file.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("TitleResource")]
        public SP.__deferred TitleResource_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the implementation-specific version identifier of the file.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("UiVersion")]
        public Int32 UiVersion_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the implementation-specific version identifier of the file.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("UiVersionLabel")]
        public String UiVersionLabel_ { set; get; }
        /// <summary>
        /// <para>Gets a value that returns a collection of file version objects that represent the versions of the file.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Versions")]
        public SP.FileVersionCollection Versions_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
            "http://<site url>/_api/web/getfilebyserverrelativeurl('/<folder name>/<file name>')",
        };

        public File(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(File));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  File()
        {
        }
        public  File(string json)
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
                usedFields.Add("Author");
            this.Author_ = new SP.User(HMS.SP.SPUtil.dyn_toString(refObj.Author));
                usedFields.Add("CheckedOutByUser");
            this.CheckedOutByUser_ = new SP.User(HMS.SP.SPUtil.dyn_toString(refObj.CheckedOutByUser));
                usedFields.Add("CheckInComment");
            HMS.SP.SPUtil.dyn_ValueSet("CheckInComment", refObj, this);
                usedFields.Add("CheckOutType");
            HMS.SP.SPUtil.dyn_ValueSet("CheckOutType", refObj, this);
                usedFields.Add("ContentTag");
            HMS.SP.SPUtil.dyn_ValueSet("ContentTag", refObj, this);
                usedFields.Add("CustomizedPageStatus");
            HMS.SP.SPUtil.dyn_ValueSet("CustomizedPageStatus", refObj, this);
                usedFields.Add("ETag");
            HMS.SP.SPUtil.dyn_ValueSet("ETag", refObj, this);
                usedFields.Add("Exists");
            HMS.SP.SPUtil.dyn_ValueSet("Exists", refObj, this);
                usedFields.Add("Length");
            HMS.SP.SPUtil.dyn_ValueSet("Length", refObj, this);
                usedFields.Add("Level");
            HMS.SP.SPUtil.dyn_ValueSet("Level", refObj, this);
                usedFields.Add("ListItemAllFields");
            this.ListItemAllFields_ = new SP.ListItem(HMS.SP.SPUtil.dyn_toString(refObj.ListItemAllFields));
                usedFields.Add("LockedByUser");
            this.LockedByUser_ = new SP.User(HMS.SP.SPUtil.dyn_toString(refObj.LockedByUser));
                usedFields.Add("MajorVersion");
            HMS.SP.SPUtil.dyn_ValueSet("MajorVersion", refObj, this);
                usedFields.Add("MinorVersion");
            HMS.SP.SPUtil.dyn_ValueSet("MinorVersion", refObj, this);
                usedFields.Add("ModifiedBy");
            this.ModifiedBy_ = new SP.User(HMS.SP.SPUtil.dyn_toString(refObj.ModifiedBy));
                usedFields.Add("Name");
            HMS.SP.SPUtil.dyn_ValueSet("Name", refObj, this);
                usedFields.Add("ServerRelativeUrl");
            HMS.SP.SPUtil.dyn_ValueSet("ServerRelativeUrl", refObj, this);
                usedFields.Add("TimeCreated");
            HMS.SP.SPUtil.dyn_ValueSet("TimeCreated", refObj, this);
                usedFields.Add("TimeLastModified");
            HMS.SP.SPUtil.dyn_ValueSet("TimeLastModified", refObj, this);
                usedFields.Add("Title");
            HMS.SP.SPUtil.dyn_ValueSet("Title", refObj, this);
                usedFields.Add("TitleResource");
            this.TitleResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.TitleResource));
                usedFields.Add("UiVersion");
            HMS.SP.SPUtil.dyn_ValueSet("UiVersion", refObj, this);
                usedFields.Add("UiVersionLabel");
            HMS.SP.SPUtil.dyn_ValueSet("UiVersionLabel", refObj, this);
                usedFields.Add("Versions");
            this.Versions_ = new SP.FileVersionCollection(HMS.SP.SPUtil.dyn_toString(refObj.Versions));
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

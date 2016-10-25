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
    /// <para>https://msdn.microsoft.com/en-us/library/office/dn450841.aspx#bk_Folder</para>
    /// </summary>
    public class Folder : SPBase{
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
        /// <para>Specifies the sequence in which content types are displayed.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ContentTypeOrder")]
        public SP.ContentTypeId[] ContentTypeOrder_ { set; get; }
        /// <summary>
        /// <para>Gets the collection of all files contained in the list folder. You can add a file to a folder by using the Add method on the folder’s FileCollection resource.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Files")]
        public SP.FileCollection Files_ { set; get; }
        /// <summary>
        /// <para>Gets the collection of list folders contained in the list folder.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Folders")]
        public SP.FolderCollection Folders_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the count of items in the list folder.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ItemCount")]
        public Int32 ItemCount_ { set; get; }
        /// <summary>
        /// <para>Specifies the list item field (2) values for the list item corresponding to the file.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("ListItemAllFields")]
        public SP.ListItem ListItemAllFields_ { set; get; }
        /// <summary>
        /// <para>Gets the name of the folder.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Name")]
        public String Name_ { set; get; }
        /// <summary>
        /// <para>Gets the parent list folder of the folder.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("ParentFolder")]
        public SP.Folder ParentFolder_ { set; get; }
        /// <summary>
        /// <para>Gets the collection of all files contained in the folder.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Properties")]
        public SP.PropertyValues Properties_ { set; get; }
        /// <summary>
        /// <para>Gets the server-relative URL of the list folder.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ServerRelativeUrl")]
        public String ServerRelativeUrl_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the content type order.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("UniqueContentTypeOrder")]
        public SP.ContentTypeId[] UniqueContentTypeOrder_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies folder-relative URL for the list folder welcome page.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("WelcomePage")]
        public String WelcomePage_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
            "http://<site url>/_api/web/getfolderbyserverrelativeurl('/<folder name>')",
        };

        public Folder(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(Folder));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  Folder()
        {
        }
        public  Folder(string json)
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
                usedFields.Add("ContentTypeOrder");
//            this.ContentTypeOrder_ = new SP.ContentTypeId[](HMS.SP.SPUtil.dyn_toString(refObj.ContentTypeOrder));
                usedFields.Add("Files");
            this.Files_ = new SP.FileCollection(HMS.SP.SPUtil.dyn_toString(refObj.Files));
                usedFields.Add("Folders");
            this.Folders_ = new SP.FolderCollection(HMS.SP.SPUtil.dyn_toString(refObj.Folders));
                usedFields.Add("ItemCount");
            HMS.SP.SPUtil.dyn_ValueSet("ItemCount", refObj, this);
                usedFields.Add("ListItemAllFields");
            this.ListItemAllFields_ = new SP.ListItem(HMS.SP.SPUtil.dyn_toString(refObj.ListItemAllFields));
                usedFields.Add("Name");
            HMS.SP.SPUtil.dyn_ValueSet("Name", refObj, this);
                usedFields.Add("ParentFolder");
            this.ParentFolder_ = new SP.Folder(HMS.SP.SPUtil.dyn_toString(refObj.ParentFolder));
                usedFields.Add("Properties");
            this.Properties_ = new SP.PropertyValues(HMS.SP.SPUtil.dyn_toString(refObj.Properties));
                usedFields.Add("ServerRelativeUrl");
            HMS.SP.SPUtil.dyn_ValueSet("ServerRelativeUrl", refObj, this);
                usedFields.Add("UniqueContentTypeOrder");
//            this.UniqueContentTypeOrder_ = new SP.ContentTypeId[](HMS.SP.SPUtil.dyn_toString(refObj.UniqueContentTypeOrder));
                usedFields.Add("WelcomePage");
            HMS.SP.SPUtil.dyn_ValueSet("WelcomePage", refObj, this);
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

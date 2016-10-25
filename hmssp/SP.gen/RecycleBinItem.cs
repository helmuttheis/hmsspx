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
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj245382.aspx#properties</para>
    /// </summary>
    public class RecycleBinItem : SPBase{
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
        /// <para>Gets a value that specifies the user who created the Recycle Bin item.(s. https://msdn.microsoft.com/en-us/library/office/jj245031.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Author")]
        public SP.User Author_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the user who deleted the Recycle Bin item.(s. https://msdn.microsoft.com/en-us/library/office/jj245964.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DeletedBy")]
        public SP.User DeletedBy_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies when the Recycle Bin item was moved to the Recycle Bin.(s. https://msdn.microsoft.com/en-us/library/office/jj245371.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DeletedDate")]
        public DateTime DeletedDate_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the site relative URL of the list or folder that originally contained the Recycle Bin item.(s. https://msdn.microsoft.com/en-us/library/office/jj247050.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DirName")]
        public String DirName_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets a value that specifies the identifier of the Recycle Bin item.(s. https://msdn.microsoft.com/en-us/library/office/jj245809.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Id")]
        public Object Id_ { set; get; }
// undefined class SP.RecycleBinItemState : Object { }
        /// <summary>
        /// <para>Gets a value that specifies the Recycle Bin stage of the Recycle Bin item.(s. https://msdn.microsoft.com/en-us/library/office/jj245421.aspx)[SP.RecycleBinItemState]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ItemState")]
        public Object ItemState_ { set; get; }
// undefined class SP.RecycleBinItemType : Object { }
        /// <summary>
        /// <para>Gets a value that specifies the type of the Recycle Bin item.(s. https://msdn.microsoft.com/en-us/library/office/jj245217.aspx)[SP.RecycleBinItemType]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ItemType")]
        public Object ItemType_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the leaf name of the Recycle Bin item.(s. https://msdn.microsoft.com/en-us/library/office/jj246469.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("LeafName")]
        public String LeafName_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the size of the Recycle Bin item in bytes.(s. https://msdn.microsoft.com/en-us/library/office/jj244928.aspx) [Number]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Size")]
        public Int32 Size_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the title of the Recycle Bin item.(s. https://msdn.microsoft.com/en-us/library/office/jj245739.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Title")]
        public String Title_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the title of the Recycle Bin item.(s. https://msdn.microsoft.com/en-us/library/office/jj245739.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("TitleResource")]
        public SP.__deferred TitleResource_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public RecycleBinItem(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(RecycleBinItem));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  RecycleBinItem()
        {
        }
        public  RecycleBinItem(string json)
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
                usedFields.Add("DeletedBy");
            this.DeletedBy_ = new SP.User(HMS.SP.SPUtil.dyn_toString(refObj.DeletedBy));
                usedFields.Add("DeletedDate");
            HMS.SP.SPUtil.dyn_ValueSet("DeletedDate", refObj, this);
                usedFields.Add("DirName");
            HMS.SP.SPUtil.dyn_ValueSet("DirName", refObj, this);
                usedFields.Add("Id");
            HMS.SP.SPUtil.dyn_ValueSet("Id", refObj, this);
                usedFields.Add("ItemState");
            HMS.SP.SPUtil.dyn_ValueSet("ItemState", refObj, this);
                usedFields.Add("ItemType");
            HMS.SP.SPUtil.dyn_ValueSet("ItemType", refObj, this);
                usedFields.Add("LeafName");
            HMS.SP.SPUtil.dyn_ValueSet("LeafName", refObj, this);
                usedFields.Add("Size");
            HMS.SP.SPUtil.dyn_ValueSet("Size", refObj, this);
                usedFields.Add("Title");
            HMS.SP.SPUtil.dyn_ValueSet("Title", refObj, this);
                usedFields.Add("TitleResource");
            this.TitleResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.TitleResource));
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

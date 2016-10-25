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
    /// <para>https://msdn.microsoft.com/en-us/library/office/dn600183.aspx#bk_MenuNode</para>
    /// </summary>
    public class MenuNode : SPBase,iSP{
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
        /// <para>Node properties.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("CustomProperties")]
        public SP.KeyValue[] CustomProperties_ { set; get; }
        /// <summary>
        /// <para>The URL of the navigation node relative to the URL of the parent navigation node.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("FriendlyUrlSegment")]
        public String FriendlyUrlSegment_ { set; get; }
        /// <summary>
        /// <para>Indicates whether the node is hidden in the navigation menu. During editing, all nodes temporarily become visible.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("IsHidden")]
        public Boolean IsHidden_ { set; get; }
        /// <summary>
        /// <para>The identifier for the navigation node in the menu tree.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Key")]
        public String Key_ { set; get; }
        /// <summary>
        /// <para>The child nodes.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Nodes")]
        public SP.MenuNode[] Nodes_ { set; get; }
        /// <summary>
        /// <para>The type of the navigation node.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("NodeType")]
        public Int32 NodeType_ { set; get; }
        /// <summary>
        /// <para>The relative or absolute URL of the navigation node. Site-relative URLs can start with the "~site" token and site collection-relative URLs can start with the "~sitecollection" token. Applies only to SimpleLink node types.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("SimpleUrl")]
        public String SimpleUrl_ { set; get; }
        /// <summary>
        /// <para>The title of the navigation node.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Title")]
        public String Title_ { set; get; }
        /// <summary>
        /// <para>The title of the navigation node.</para>
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

        public MenuNode(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(MenuNode));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  MenuNode()
        {
        }
        public  MenuNode(string json)
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
                usedFields.Add("CustomProperties");
//            this.CustomProperties_ = new SP.KeyValue[](HMS.SP.SPUtil.dyn_toString(refObj.CustomProperties));
                usedFields.Add("FriendlyUrlSegment");
            HMS.SP.SPUtil.dyn_ValueSet("FriendlyUrlSegment", refObj, this);
                usedFields.Add("IsHidden");
            HMS.SP.SPUtil.dyn_ValueSet("IsHidden", refObj, this);
                usedFields.Add("Key");
            HMS.SP.SPUtil.dyn_ValueSet("Key", refObj, this);
                usedFields.Add("Nodes");
//            this.Nodes_ = new SP.MenuNode[](HMS.SP.SPUtil.dyn_toString(refObj.Nodes));
                usedFields.Add("NodeType");
            HMS.SP.SPUtil.dyn_ValueSet("NodeType", refObj, this);
                usedFields.Add("SimpleUrl");
            HMS.SP.SPUtil.dyn_ValueSet("SimpleUrl", refObj, this);
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

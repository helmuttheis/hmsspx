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
    /// <para>https://msdn.microsoft.com/en-us/library/office/dn600183.aspx#bk_MenuState</para>
    /// </summary>
    public class MenuState : SPBase{
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
        /// <para>Specifies the site collection-relative URL for the root node of the menu tree.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("FriendlyUrlPrefix")]
        public String FriendlyUrlPrefix_ { set; get; }
        /// <summary>
        /// <para>The child nodes of the root node of the menu tree.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Nodes")]
        public SP.MenuNode[] Nodes_ { set; get; }
        /// <summary>
        /// <para>The relative or absolute URL of the navigation node. Site-relative URLs can begin with the "~site" URL token and site collection-relative URLs can begin with the "~sitecollection" URL token. Applies only to SimpleLink node types.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("SimpleUrl")]
        public String SimpleUrl_ { set; get; }
        /// <summary>
        /// <para>The string that replaces the "~sitecollection" token in site collection-relative links. For example, to get the Try Link command to work with the relative link ~sitecollection/Pages/MyPage.aspx, this value might be http://contoso.com/sites/site1/.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("SPSitePrefix")]
        public String SPSitePrefix_ { set; get; }
        /// <summary>
        /// <para>The string that replaces the "~site" token in site-relative links. For example, to get the Try Link command to work with the relative link ~site/Pages/MyPage.aspx, this value might be http://contoso.com/sites/site1/web1.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("SPWebPrefix")]
        public String SPWebPrefix_ { set; get; }
        /// <summary>
        /// <para>The identifier of the root node in the menu tree.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("StartingNodeKey")]
        public String StartingNodeKey_ { set; get; }
        /// <summary>
        /// <para>The title of the root node in the menu tree. (Example: "Document Center")</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("StartingNodeTitle")]
        public String StartingNodeTitle_ { set; get; }
        /// <summary>
        /// <para>An implementation-specific value that the server uses to detect external changes. For example, it could be a change timestamp for the database or a monotonically increasing version number such as "2009-06-15T20:45:30Z".</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Version")]
        public String Version_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public MenuState(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(MenuState));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  MenuState()
        {
        }
        public  MenuState(string json)
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
                usedFields.Add("FriendlyUrlPrefix");
            HMS.SP.SPUtil.dyn_ValueSet("FriendlyUrlPrefix", refObj, this);
                usedFields.Add("Nodes");
//            this.Nodes_ = new SP.MenuNode[](HMS.SP.SPUtil.dyn_toString(refObj.Nodes));
                usedFields.Add("SimpleUrl");
            HMS.SP.SPUtil.dyn_ValueSet("SimpleUrl", refObj, this);
                usedFields.Add("SPSitePrefix");
            HMS.SP.SPUtil.dyn_ValueSet("SPSitePrefix", refObj, this);
                usedFields.Add("SPWebPrefix");
            HMS.SP.SPUtil.dyn_ValueSet("SPWebPrefix", refObj, this);
                usedFields.Add("StartingNodeKey");
            HMS.SP.SPUtil.dyn_ValueSet("StartingNodeKey", refObj, this);
                usedFields.Add("StartingNodeTitle");
            HMS.SP.SPUtil.dyn_ValueSet("StartingNodeTitle", refObj, this);
                usedFields.Add("Version");
            HMS.SP.SPUtil.dyn_ValueSet("Version", refObj, this);
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

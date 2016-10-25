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
    /// <para>https://msdn.microsoft.com/en-us/library/office/dn600183.aspx#bk_ChangeQuery</para>
    /// </summary>
    public class ChangeQuery : SPBase{
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
        /// <para>Gets or sets a value that specifies whether add changes are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Add")]
        public Boolean Add_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether changes to alerts are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Alert")]
        public Boolean Alert_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the end date and end time for changes that are returned through the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ChangeTokenEnd")]
        public SP.ChangeToken ChangeTokenEnd_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the start date and start time for changes that are returned through the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ChangeTokenStart")]
        public SP.ChangeToken ChangeTokenStart_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether changes to content types are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ContentType")]
        public Boolean ContentType_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether changes to content types are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DeleteObject")]
        public Boolean DeleteObject_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether changes to content types are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Field")]
        public Boolean Field_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether changes to content types are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("File")]
        public Boolean File_ { set; get; }
        /// <summary>
        /// <para>Gets or sets value that specifies whether changes to folders are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Folder")]
        public Boolean Folder_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether changes to groups are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Group")]
        public Boolean Group_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether adding users to groups is included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("GroupMembershipAdd")]
        public Boolean GroupMembershipAdd_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether deleting users from the groups is included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("GroupMembershipDelete")]
        public Boolean GroupMembershipDelete_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether general changes to list items are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Item")]
        public Boolean Item_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether changes to lists are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("List")]
        public Boolean List_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether move changes are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Move")]
        public Boolean Move_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether changes to the navigation structure of a site collection are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Navigation")]
        public Boolean Navigation_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether renaming changes are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Rename")]
        public Boolean Rename_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether restoring items from the recycle bin or from backups is included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Restore")]
        public Boolean Restore_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether adding role assignments is included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("RoleAssignmentAdd")]
        public Boolean RoleAssignmentAdd_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether adding role assignments is included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("RoleAssignmentDelete")]
        public Boolean RoleAssignmentDelete_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether adding role assignments is included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("RoleDefinitionAdd")]
        public Boolean RoleDefinitionAdd_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether adding role assignments is included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("RoleDefinitionDelete")]
        public Boolean RoleDefinitionDelete_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether adding role assignments is included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("RoleDefinitionUpdate")]
        public Boolean RoleDefinitionUpdate_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether modifications to security policies are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("SecurityPolicy")]
        public Boolean SecurityPolicy_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether changes to site collections are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Site")]
        public Boolean Site_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether updates made using the item SystemUpdate method are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("SystemUpdate")]
        public Boolean SystemUpdate_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether update changes are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Update")]
        public Boolean Update_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether changes to users are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("User")]
        public Boolean User_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether changes to views are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("View")]
        public Boolean View_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether changes to Web sites are included in the query.</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Web")]
        public Boolean Web_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public ChangeQuery(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(ChangeQuery));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  ChangeQuery()
        {
        }
        public  ChangeQuery(string json)
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
                usedFields.Add("Add");
            HMS.SP.SPUtil.dyn_ValueSet("Add", refObj, this);
                usedFields.Add("Alert");
            HMS.SP.SPUtil.dyn_ValueSet("Alert", refObj, this);
                usedFields.Add("ChangeTokenEnd");
            this.ChangeTokenEnd_ = new SP.ChangeToken(HMS.SP.SPUtil.dyn_toString(refObj.ChangeTokenEnd));
                usedFields.Add("ChangeTokenStart");
            this.ChangeTokenStart_ = new SP.ChangeToken(HMS.SP.SPUtil.dyn_toString(refObj.ChangeTokenStart));
                usedFields.Add("ContentType");
            HMS.SP.SPUtil.dyn_ValueSet("ContentType", refObj, this);
                usedFields.Add("DeleteObject");
            HMS.SP.SPUtil.dyn_ValueSet("DeleteObject", refObj, this);
                usedFields.Add("Field");
            HMS.SP.SPUtil.dyn_ValueSet("Field", refObj, this);
                usedFields.Add("File");
            HMS.SP.SPUtil.dyn_ValueSet("File", refObj, this);
                usedFields.Add("Folder");
            HMS.SP.SPUtil.dyn_ValueSet("Folder", refObj, this);
                usedFields.Add("Group");
            HMS.SP.SPUtil.dyn_ValueSet("Group", refObj, this);
                usedFields.Add("GroupMembershipAdd");
            HMS.SP.SPUtil.dyn_ValueSet("GroupMembershipAdd", refObj, this);
                usedFields.Add("GroupMembershipDelete");
            HMS.SP.SPUtil.dyn_ValueSet("GroupMembershipDelete", refObj, this);
                usedFields.Add("Item");
            HMS.SP.SPUtil.dyn_ValueSet("Item", refObj, this);
                usedFields.Add("List");
            HMS.SP.SPUtil.dyn_ValueSet("List", refObj, this);
                usedFields.Add("Move");
            HMS.SP.SPUtil.dyn_ValueSet("Move", refObj, this);
                usedFields.Add("Navigation");
            HMS.SP.SPUtil.dyn_ValueSet("Navigation", refObj, this);
                usedFields.Add("Rename");
            HMS.SP.SPUtil.dyn_ValueSet("Rename", refObj, this);
                usedFields.Add("Restore");
            HMS.SP.SPUtil.dyn_ValueSet("Restore", refObj, this);
                usedFields.Add("RoleAssignmentAdd");
            HMS.SP.SPUtil.dyn_ValueSet("RoleAssignmentAdd", refObj, this);
                usedFields.Add("RoleAssignmentDelete");
            HMS.SP.SPUtil.dyn_ValueSet("RoleAssignmentDelete", refObj, this);
                usedFields.Add("RoleDefinitionAdd");
            HMS.SP.SPUtil.dyn_ValueSet("RoleDefinitionAdd", refObj, this);
                usedFields.Add("RoleDefinitionDelete");
            HMS.SP.SPUtil.dyn_ValueSet("RoleDefinitionDelete", refObj, this);
                usedFields.Add("RoleDefinitionUpdate");
            HMS.SP.SPUtil.dyn_ValueSet("RoleDefinitionUpdate", refObj, this);
                usedFields.Add("SecurityPolicy");
            HMS.SP.SPUtil.dyn_ValueSet("SecurityPolicy", refObj, this);
                usedFields.Add("Site");
            HMS.SP.SPUtil.dyn_ValueSet("Site", refObj, this);
                usedFields.Add("SystemUpdate");
            HMS.SP.SPUtil.dyn_ValueSet("SystemUpdate", refObj, this);
                usedFields.Add("Update");
            HMS.SP.SPUtil.dyn_ValueSet("Update", refObj, this);
                usedFields.Add("User");
            HMS.SP.SPUtil.dyn_ValueSet("User", refObj, this);
                usedFields.Add("View");
            HMS.SP.SPUtil.dyn_ValueSet("View", refObj, this);
                usedFields.Add("Web");
            HMS.SP.SPUtil.dyn_ValueSet("Web", refObj, this);
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

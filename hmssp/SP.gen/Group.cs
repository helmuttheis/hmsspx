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
    /// <para>https://msdn.microsoft.com/en-us/library/office/dn531432.aspx#bk_Group</para>
    /// </summary>
    public class Group : SPBase,iSP{
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
        /// <para>Gets or sets a value that indicates whether the group members can edit membership in the group.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("AllowMembersEditMembership")]
        public Boolean AllowMembersEditMembership_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that indicates whether to allow users to request membership in the group and request to leave the group.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("AllowRequestToJoinLeave")]
        public Boolean AllowRequestToJoinLeave_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that indicates whether the request to join or leave the group can be accepted automatically.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("AutoAcceptRequestToJoinLeave")]
        public Boolean AutoAcceptRequestToJoinLeave_ { set; get; }
        /// <summary>
        /// <para>Gets a value that indicates whether the current user can edit the membership of the group.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("CanCurrentUserEditMembership")]
        public Boolean CanCurrentUserEditMembership_ { set; get; }
        /// <summary>
        /// <para>Gets a value that indicates whether the current user can manage the group.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("CanCurrentUserManageGroup")]
        public Boolean CanCurrentUserManageGroup_ { set; get; }
        /// <summary>
        /// <para>Gets a value that indicates whether the current user can view the membership of the group.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("CanCurrentUserViewMembership")]
        public Boolean CanCurrentUserViewMembership_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the description of the group.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Description")]
        public String Description_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the description of the group.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("DescriptionResource")]
        public SP.__deferred DescriptionResource_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the member identifier for the user or group.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Id")]
        public Int32 Id_ { set; get; }
        /// <summary>
        /// <para>Gets a value that indicates whether this member should be hidden in the UI.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("IsHiddenInUI")]
        public Boolean IsHiddenInUI_ { set; get; }
        /// <summary>
        /// <para>Gets the name of the group.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("LoginName")]
        public String LoginName_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that indicates whether only group members are allowed to view the membership of the group.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("OnlyAllowMembersViewMembership")]
        public Boolean OnlyAllowMembersViewMembership_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the owner of the group which can be a user or another group assigned permissions to control security.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Owner")]
        public SP.Principal Owner_ { set; get; }
        /// <summary>
        /// <para>Gets the name for the owner of this group.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("OwnerTitle")]
        public String OwnerTitle_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the email address to which the requests of the membership are sent.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("RequestToJoinLeaveEmailSetting")]
        public String RequestToJoinLeaveEmailSetting_ { set; get; }
        /// <summary>
        /// <para>Gets a value containing the type of the principal. Represents a bitwise SP.PrincipalType value: None = 0; User = 1; DistributionList = 2; SecurityGroup = 4; SharePointGroup = 8; All = 15.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("PrincipalType")]
        public Int32 PrincipalType_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the name of the principal.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Title")]
        public String Title_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the name of the principal.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("TitleResource")]
        public SP.__deferred TitleResource_ { set; get; }
        /// <summary>
        /// <para>Gets a collection of user objects that represents all of the users in the group.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Users")]
        public SP.UserCollection Users_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
            "http://<site url>/_api/web/sitegroups(<group id>)",
        };

        public Group(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(Group));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  Group()
        {
        }
        public  Group(string json)
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
                usedFields.Add("AllowMembersEditMembership");
            HMS.SP.SPUtil.dyn_ValueSet("AllowMembersEditMembership", refObj, this);
                usedFields.Add("AllowRequestToJoinLeave");
            HMS.SP.SPUtil.dyn_ValueSet("AllowRequestToJoinLeave", refObj, this);
                usedFields.Add("AutoAcceptRequestToJoinLeave");
            HMS.SP.SPUtil.dyn_ValueSet("AutoAcceptRequestToJoinLeave", refObj, this);
                usedFields.Add("CanCurrentUserEditMembership");
            HMS.SP.SPUtil.dyn_ValueSet("CanCurrentUserEditMembership", refObj, this);
                usedFields.Add("CanCurrentUserManageGroup");
            HMS.SP.SPUtil.dyn_ValueSet("CanCurrentUserManageGroup", refObj, this);
                usedFields.Add("CanCurrentUserViewMembership");
            HMS.SP.SPUtil.dyn_ValueSet("CanCurrentUserViewMembership", refObj, this);
                usedFields.Add("Description");
            HMS.SP.SPUtil.dyn_ValueSet("Description", refObj, this);
                usedFields.Add("DescriptionResource");
            this.DescriptionResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.DescriptionResource));
                usedFields.Add("Id");
            HMS.SP.SPUtil.dyn_ValueSet("Id", refObj, this);
                usedFields.Add("IsHiddenInUI");
            HMS.SP.SPUtil.dyn_ValueSet("IsHiddenInUI", refObj, this);
                usedFields.Add("LoginName");
            HMS.SP.SPUtil.dyn_ValueSet("LoginName", refObj, this);
                usedFields.Add("OnlyAllowMembersViewMembership");
            HMS.SP.SPUtil.dyn_ValueSet("OnlyAllowMembersViewMembership", refObj, this);
                usedFields.Add("Owner");
            this.Owner_ = new SP.Principal(HMS.SP.SPUtil.dyn_toString(refObj.Owner));
                usedFields.Add("OwnerTitle");
            HMS.SP.SPUtil.dyn_ValueSet("OwnerTitle", refObj, this);
                usedFields.Add("RequestToJoinLeaveEmailSetting");
            HMS.SP.SPUtil.dyn_ValueSet("RequestToJoinLeaveEmailSetting", refObj, this);
                usedFields.Add("PrincipalType");
            HMS.SP.SPUtil.dyn_ValueSet("PrincipalType", refObj, this);
                usedFields.Add("Title");
            HMS.SP.SPUtil.dyn_ValueSet("Title", refObj, this);
                usedFields.Add("TitleResource");
            this.TitleResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.TitleResource));
                usedFields.Add("Users");
            this.Users_ = new SP.UserCollection(HMS.SP.SPUtil.dyn_toString(refObj.Users));
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

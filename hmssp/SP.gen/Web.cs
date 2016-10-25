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
    /// <para>https://msdn.microsoft.com/en-us/library/office/dn499819.aspx#bk_Web</para>
    /// </summary>
    public class Web : SPBase,iSP{
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
        /// <para>Specifies whether the current user can create declarative workflows. If not disabled on the Web application, the value is the same as the AllowCreateDeclarativeWorkflow property of the site collection. Default value: true.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("AllowCreateDeclarativeWorkflowForCurrentUser")]
        public Boolean AllowCreateDeclarativeWorkflowForCurrentUser_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the current user is allowed to use a designer application to customize this site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("AllowDesignerForCurrentUser")]
        public Boolean AllowDesignerForCurrentUser_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the current user is allowed to edit the master page.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("AllowMasterPageEditingForCurrentUser")]
        public Boolean AllowMasterPageEditingForCurrentUser_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the current user is allowed to revert the site to a default site template.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("AllowRevertFromTemplateForCurrentUser")]
        public Boolean AllowRevertFromTemplateForCurrentUser_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the site allows RSS feeds.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("AllowRssFeeds")]
        public Boolean AllowRssFeeds_ { set; get; }
        /// <summary>
        /// <para>Specifies whether the current user can save declarative workflows as a template. If not disabled on the Web application, the value is the same as the AllowSaveDeclarativeWorkflowAsTemplate property of the site collection. Default value: true.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("AllowSaveDeclarativeWorkflowAsTemplateForCurrentUser")]
        public Boolean AllowSaveDeclarativeWorkflowAsTemplateForCurrentUser_ { set; get; }
        /// <summary>
        /// <para>Specifies whether the current user can save or publish declarative workflows. If not disabled on the Web application, the value is the same as the AllowSavePublishDeclarativeWorkflowAsTemplate property of the site collection. When enabled, can only be set by a site collection administrator. Default value: true.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("AllowSavePublishDeclarativeWorkflowForCurrentUser")]
        public Boolean AllowSavePublishDeclarativeWorkflowForCurrentUser_ { set; get; }
        /// <summary>
        /// <para>Gets a collection of metadata for the Web site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("AllProperties")]
        public SP.PropertyValues AllProperties_ { set; get; }
        /// <summary>
        /// <para>The instance Id of the App Instance that this web represents. </para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("AppInstanceId")]
        public Guid AppInstanceId_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the group of users who have been given contribute permissions to the Web site.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("AssociatedMemberGroup")]
        public SP.Group AssociatedMemberGroup_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the associated owner group of the Web site.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("AssociatedOwnerGroup")]
        public SP.Group AssociatedOwnerGroup_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the associated visitor group of the Web site.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("AssociatedVisitorGroup")]
        public SP.Group AssociatedVisitorGroup_ { set; get; }
        /// <summary>
        /// <para>Gets the collection of all content types that apply to the current scope, including those of the current Web site, as well as any parent Web sites.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("AvailableContentTypes")]
        public SP.ContentTypeCollection AvailableContentTypes_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the collection of all fields available for the current scope, including those of the current site, as well as any parent sites.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("AvailableFields")]
        public SP.FieldCollection AvailableFields_ { set; get; }
        /// <summary>
        /// <para>Gets either the identifier (ID) of the site definition configuration that was used to create the site, or the ID of the site definition configuration from which the site template used to create the site was derived.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Configuration")]
        public Int16 Configuration_ { set; get; }
        /// <summary>
        /// <para>Gets the collection of content types for the Web site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("ContentTypes")]
        public SP.ContentTypeCollection ContentTypes_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies when the site was created.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Created")]
        public DateTime Created_ { set; get; }
        /// <summary>
        /// <para>Gets the current user of the site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("CurrentUser")]
        public SP.User CurrentUser_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the URL for a custom master page file to apply to the website.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("CustomMasterUrl")]
        public String CustomMasterUrl_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the description for the site.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Description")]
        public String Description_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the description for the site.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("DescriptionResource")]
        public SP.__deferred DescriptionResource_ { set; get; }
        /// <summary>
        /// <para>Gets the URL where the current user can download SharePoint Designer.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("DesignerDownloadUrlForCurrentUser")]
        public String DesignerDownloadUrlForCurrentUser_ { set; get; }
        /// <summary>
        /// <para>Determines if the Document Library Callout's WAC previewers are enabled or not.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("DocumentLibraryCalloutOfficeWebAppPreviewersDisabled")]
        public Boolean DocumentLibraryCalloutOfficeWebAppPreviewersDisabled_ { set; get; }
        /// <summary>
        /// <para>Represents the intersection of permissions of the app principal and the user principal. In the app-only case, this property returns only the permissions of the app principal.To check only user permissions (ignoring app permissions), use the GetUserEffectivePermissions method.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("EffectiveBasePermissions")]
        public SP.BasePermissions EffectiveBasePermissions_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a Boolean value that specifies whether the Web             site should use Minimal Download Strategy.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("EnableMinimalDownload")]
        public Boolean EnableMinimalDownload_ { set; get; }
        /// <summary>
        /// <para>Gets the collection of event receiver definitions that are currently available on the website.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("EventReceivers")]
        public SP.EventReceiverCollection EventReceivers_ { set; get; }
// undefined class SP.EventReceiverCollection : Object { }
        /// <summary>
        /// <para>Gets a value that specifies the collection of features that are currently activated in the site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Features")]
        public SP.FeatureCollection Features_ { set; get; }
        /// <summary>
        /// <para>Gets the collection of field objects that represents all the fields in the Web site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Fields")]
        public SP.FieldCollection Fields_ { set; get; }
        /// <summary>
        /// <para>Gets the collection of all first-level folders in the Web site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Folders")]
        public SP.FolderCollection Folders_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the site identifier for the site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Id")]
        public Guid Id_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the LCID for the language that is used on the site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Language")]
        public Int32 Language_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies when an item was last modified in the site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("LastItemModifiedDate")]
        public DateTime LastItemModifiedDate_ { set; get; }
        /// <summary>
        /// <para>Gets the collection of all lists that are contained in the Web site available to the current user based on the permissions of the current user.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Lists")]
        public SP.ListCollection Lists_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the collection of list definitions and list templates available for creating lists on the site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("ListTemplates")]
        public SP.ListTemplateCollection ListTemplates_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the URL of the master page that is used for the website.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("MasterUrl")]
        public String MasterUrl_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the navigation structure on the site, including the Quick Launch area and the top navigation bar.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Navigation")]
        public SP.Navigation Navigation_ { set; get; }
        /// <summary>
        /// <para>Gets the parent website of the specified website.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("ParentWeb")]
        public SP.Web ParentWeb_ { set; get; }
        /// <summary>
        /// <para>Gets the collection of push notification subscribers over the site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("PushNotificationSubscribers")]
        public SP.PushNotificationSubscriberCollection PushNotificationSubscribers_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the Quick Launch area is enabled on the site.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("QuickLaunchEnabled")]
        public Boolean QuickLaunchEnabled_ { set; get; }
        /// <summary>
        /// <para>Specifies the collection of recycle bin items of the recycle bin of the site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("RecycleBin")]
        public SP.RecycleBin RecycleBin_ { set; get; }
// undefined class SP.RecycleBin : Object { }
        /// <summary>
        /// <para>Gets or sets a value that determines whether the recycle bin is enabled for the website.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("RecycleBinEnabled")]
        public Boolean RecycleBinEnabled_ { set; get; }
        /// <summary>
        /// <para>Gets the regional settings that are currently implemented on the website.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("RegionalSettings")]
        public SP.RegionalSettings RegionalSettings_ { set; get; }
        /// <summary>
        /// <para>Gets the collection of role definitions for the Web site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("RoleDefinitions")]
        public SP.RoleDefinitionCollection RoleDefinitions_ { set; get; }
        /// <summary>
        /// <para>Gets the root folder for the Web site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("RootFolder")]
        public SP.Folder RootFolder_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a Boolean value that specifies whether the Web site can be saved as a site template.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("SaveSiteAsTemplateEnabled")]
        public Boolean SaveSiteAsTemplateEnabled_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the server-relative URL for the Web site.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ServerRelativeUrl")]
        public String ServerRelativeUrl_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the current user is able to view the file system structure of this site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("ShowUrlStructureForCurrentUser")]
        public Boolean ShowUrlStructureForCurrentUser_ { set; get; }
        /// <summary>
        /// <para>Gets the collection of groups for the site collection.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("SiteGroups")]
        public SP.GroupCollection SiteGroups_ { set; get; }
        /// <summary>
        /// <para>Gets the UserInfo list of the site collection that contains the Web site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("SiteUserInfoList")]
        public SP.List SiteUserInfoList_ { set; get; }
        /// <summary>
        /// <para>Gets the collection of all users that belong to the site collection.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("SiteUsers")]
        public SP.UserCollection SiteUsers_ { set; get; }
        /// <summary>
        /// <para>Specifies the language code identifiers (LCIDs) of the languages that are enabled for the site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("SupportedUILanguageIds")]
        public Int32[] SupportedUILanguageIds_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the RSS feeds are enabled on the site.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("SyndicationEnabled")]
        public Boolean SyndicationEnabled_ { set; get; }
        /// <summary>
        /// <para>The theming information for this site. This includes information like colors, fonts, border radii sizes etc.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("ThemeInfo")]
        public SP.ThemeInfo ThemeInfo_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the title for the Web site.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Title")]
        public String Title_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the title for the Web site.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("TitleResource")]
        public SP.__deferred TitleResource_ { set; get; }
        /// <summary>
        /// <para>Gets or sets value that specifies whether the tree view is enabled on the site.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("TreeViewEnabled")]
        public Boolean TreeViewEnabled_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the user interface (UI) version of the Web site.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("UIVersion")]
        public Int32 UIVersion_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the settings UI for visual upgrade is shown or hidden.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("UIVersionConfigurationEnabled")]
        public Boolean UIVersionConfigurationEnabled_ { set; get; }
        /// <summary>
        /// <para>Gets the absolute URL for the website.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Url")]
        public String Url_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the collection of user custom actions for the site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("UserCustomActions")]
        public SP.UserCustomActionCollection UserCustomActions_ { set; get; }
        /// <summary>
        /// <para>Represents key properties of the subsites of a site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("WebInfos")]
        public SP.WebInformation WebInfos_ { set; get; }
        /// <summary>
        /// <para>Gets a Web site collection object that represents all Web sites immediately beneath the Web site, excluding children of those Web sites.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Webs")]
        public SP.WebCollection Webs_ { set; get; }
        /// <summary>
        /// <para>Gets the name of the site definition or site template that was used to create the site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("WebTemplate")]
        public String WebTemplate_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the collection of all workflow associations for the site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("WorkflowAssociations")]
        public SP.WorkflowAssociationCollection WorkflowAssociations_ { set; get; }
// undefined class SP.WorkflowAssociationCollection : Object { }
        /// <summary>
        /// <para>Gets a value that specifies the collection of workflow templates associated with the site.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("WorkflowTemplates")]
        public SP.WorkflowTemplateCollection WorkflowTemplates_ { set; get; }
// undefined class SP.WorkflowTemplateCollection : Object { }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
            "http://<site url>/_api/web",
        };

        public Web(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(Web));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  Web()
        {
        }
        public  Web(string json)
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
                usedFields.Add("AllowCreateDeclarativeWorkflowForCurrentUser");
            HMS.SP.SPUtil.dyn_ValueSet("AllowCreateDeclarativeWorkflowForCurrentUser", refObj, this);
                usedFields.Add("AllowDesignerForCurrentUser");
            HMS.SP.SPUtil.dyn_ValueSet("AllowDesignerForCurrentUser", refObj, this);
                usedFields.Add("AllowMasterPageEditingForCurrentUser");
            HMS.SP.SPUtil.dyn_ValueSet("AllowMasterPageEditingForCurrentUser", refObj, this);
                usedFields.Add("AllowRevertFromTemplateForCurrentUser");
            HMS.SP.SPUtil.dyn_ValueSet("AllowRevertFromTemplateForCurrentUser", refObj, this);
                usedFields.Add("AllowRssFeeds");
            HMS.SP.SPUtil.dyn_ValueSet("AllowRssFeeds", refObj, this);
                usedFields.Add("AllowSaveDeclarativeWorkflowAsTemplateForCurrentUser");
            HMS.SP.SPUtil.dyn_ValueSet("AllowSaveDeclarativeWorkflowAsTemplateForCurrentUser", refObj, this);
                usedFields.Add("AllowSavePublishDeclarativeWorkflowForCurrentUser");
            HMS.SP.SPUtil.dyn_ValueSet("AllowSavePublishDeclarativeWorkflowForCurrentUser", refObj, this);
                usedFields.Add("AllProperties");
            this.AllProperties_ = new SP.PropertyValues(HMS.SP.SPUtil.dyn_toString(refObj.AllProperties));
                usedFields.Add("AppInstanceId");
            HMS.SP.SPUtil.dyn_ValueSet("AppInstanceId", refObj, this);
                usedFields.Add("AssociatedMemberGroup");
            this.AssociatedMemberGroup_ = new SP.Group(HMS.SP.SPUtil.dyn_toString(refObj.AssociatedMemberGroup));
                usedFields.Add("AssociatedOwnerGroup");
            this.AssociatedOwnerGroup_ = new SP.Group(HMS.SP.SPUtil.dyn_toString(refObj.AssociatedOwnerGroup));
                usedFields.Add("AssociatedVisitorGroup");
            this.AssociatedVisitorGroup_ = new SP.Group(HMS.SP.SPUtil.dyn_toString(refObj.AssociatedVisitorGroup));
                usedFields.Add("AvailableContentTypes");
            this.AvailableContentTypes_ = new SP.ContentTypeCollection(HMS.SP.SPUtil.dyn_toString(refObj.AvailableContentTypes));
                usedFields.Add("AvailableFields");
            this.AvailableFields_ = new SP.FieldCollection(HMS.SP.SPUtil.dyn_toString(refObj.AvailableFields));
                usedFields.Add("Configuration");
            HMS.SP.SPUtil.dyn_ValueSet("Configuration", refObj, this);
                usedFields.Add("ContentTypes");
            this.ContentTypes_ = new SP.ContentTypeCollection(HMS.SP.SPUtil.dyn_toString(refObj.ContentTypes));
                usedFields.Add("Created");
            HMS.SP.SPUtil.dyn_ValueSet("Created", refObj, this);
                usedFields.Add("CurrentUser");
            this.CurrentUser_ = new SP.User(HMS.SP.SPUtil.dyn_toString(refObj.CurrentUser));
                usedFields.Add("CustomMasterUrl");
            HMS.SP.SPUtil.dyn_ValueSet("CustomMasterUrl", refObj, this);
                usedFields.Add("Description");
            HMS.SP.SPUtil.dyn_ValueSet("Description", refObj, this);
                usedFields.Add("DescriptionResource");
            this.DescriptionResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.DescriptionResource));
                usedFields.Add("DesignerDownloadUrlForCurrentUser");
            HMS.SP.SPUtil.dyn_ValueSet("DesignerDownloadUrlForCurrentUser", refObj, this);
                usedFields.Add("DocumentLibraryCalloutOfficeWebAppPreviewersDisabled");
            HMS.SP.SPUtil.dyn_ValueSet("DocumentLibraryCalloutOfficeWebAppPreviewersDisabled", refObj, this);
                usedFields.Add("EffectiveBasePermissions");
            this.EffectiveBasePermissions_ = new SP.BasePermissions(HMS.SP.SPUtil.dyn_toString(refObj.EffectiveBasePermissions));
                usedFields.Add("EnableMinimalDownload");
            HMS.SP.SPUtil.dyn_ValueSet("EnableMinimalDownload", refObj, this);
                usedFields.Add("EventReceivers");
            this.EventReceivers_ = new SP.EventReceiverCollection(HMS.SP.SPUtil.dyn_toString(refObj.EventReceivers));
                usedFields.Add("Features");
            this.Features_ = new SP.FeatureCollection(HMS.SP.SPUtil.dyn_toString(refObj.Features));
                usedFields.Add("Fields");
            this.Fields_ = new SP.FieldCollection(HMS.SP.SPUtil.dyn_toString(refObj.Fields));
                usedFields.Add("Folders");
            this.Folders_ = new SP.FolderCollection(HMS.SP.SPUtil.dyn_toString(refObj.Folders));
                usedFields.Add("Id");
            HMS.SP.SPUtil.dyn_ValueSet("Id", refObj, this);
                usedFields.Add("Language");
            HMS.SP.SPUtil.dyn_ValueSet("Language", refObj, this);
                usedFields.Add("LastItemModifiedDate");
            HMS.SP.SPUtil.dyn_ValueSet("LastItemModifiedDate", refObj, this);
                usedFields.Add("Lists");
            this.Lists_ = new SP.ListCollection(HMS.SP.SPUtil.dyn_toString(refObj.Lists));
                usedFields.Add("ListTemplates");
            this.ListTemplates_ = new SP.ListTemplateCollection(HMS.SP.SPUtil.dyn_toString(refObj.ListTemplates));
                usedFields.Add("MasterUrl");
            HMS.SP.SPUtil.dyn_ValueSet("MasterUrl", refObj, this);
                usedFields.Add("Navigation");
            this.Navigation_ = new SP.Navigation(HMS.SP.SPUtil.dyn_toString(refObj.Navigation));
                usedFields.Add("ParentWeb");
            this.ParentWeb_ = new SP.Web(HMS.SP.SPUtil.dyn_toString(refObj.ParentWeb));
                usedFields.Add("PushNotificationSubscribers");
            this.PushNotificationSubscribers_ = new SP.PushNotificationSubscriberCollection(HMS.SP.SPUtil.dyn_toString(refObj.PushNotificationSubscribers));
                usedFields.Add("QuickLaunchEnabled");
            HMS.SP.SPUtil.dyn_ValueSet("QuickLaunchEnabled", refObj, this);
                usedFields.Add("RecycleBin");
            this.RecycleBin_ = new SP.RecycleBin(HMS.SP.SPUtil.dyn_toString(refObj.RecycleBin));
                usedFields.Add("RecycleBinEnabled");
            HMS.SP.SPUtil.dyn_ValueSet("RecycleBinEnabled", refObj, this);
                usedFields.Add("RegionalSettings");
            this.RegionalSettings_ = new SP.RegionalSettings(HMS.SP.SPUtil.dyn_toString(refObj.RegionalSettings));
                usedFields.Add("RoleDefinitions");
            this.RoleDefinitions_ = new SP.RoleDefinitionCollection(HMS.SP.SPUtil.dyn_toString(refObj.RoleDefinitions));
                usedFields.Add("RootFolder");
            this.RootFolder_ = new SP.Folder(HMS.SP.SPUtil.dyn_toString(refObj.RootFolder));
                usedFields.Add("SaveSiteAsTemplateEnabled");
            HMS.SP.SPUtil.dyn_ValueSet("SaveSiteAsTemplateEnabled", refObj, this);
                usedFields.Add("ServerRelativeUrl");
            HMS.SP.SPUtil.dyn_ValueSet("ServerRelativeUrl", refObj, this);
                usedFields.Add("ShowUrlStructureForCurrentUser");
            HMS.SP.SPUtil.dyn_ValueSet("ShowUrlStructureForCurrentUser", refObj, this);
                usedFields.Add("SiteGroups");
            this.SiteGroups_ = new SP.GroupCollection(HMS.SP.SPUtil.dyn_toString(refObj.SiteGroups));
                usedFields.Add("SiteUserInfoList");
            this.SiteUserInfoList_ = new SP.List(HMS.SP.SPUtil.dyn_toString(refObj.SiteUserInfoList));
                usedFields.Add("SiteUsers");
            this.SiteUsers_ = new SP.UserCollection(HMS.SP.SPUtil.dyn_toString(refObj.SiteUsers));
                usedFields.Add("SupportedUILanguageIds");
            HMS.SP.SPUtil.dyn_ValueSet("SupportedUILanguageIds", refObj, this);
                usedFields.Add("SyndicationEnabled");
            HMS.SP.SPUtil.dyn_ValueSet("SyndicationEnabled", refObj, this);
                usedFields.Add("ThemeInfo");
            this.ThemeInfo_ = new SP.ThemeInfo(HMS.SP.SPUtil.dyn_toString(refObj.ThemeInfo));
                usedFields.Add("Title");
            HMS.SP.SPUtil.dyn_ValueSet("Title", refObj, this);
                usedFields.Add("TitleResource");
            this.TitleResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.TitleResource));
                usedFields.Add("TreeViewEnabled");
            HMS.SP.SPUtil.dyn_ValueSet("TreeViewEnabled", refObj, this);
                usedFields.Add("UIVersion");
            HMS.SP.SPUtil.dyn_ValueSet("UIVersion", refObj, this);
                usedFields.Add("UIVersionConfigurationEnabled");
            HMS.SP.SPUtil.dyn_ValueSet("UIVersionConfigurationEnabled", refObj, this);
                usedFields.Add("Url");
            HMS.SP.SPUtil.dyn_ValueSet("Url", refObj, this);
                usedFields.Add("UserCustomActions");
            this.UserCustomActions_ = new SP.UserCustomActionCollection(HMS.SP.SPUtil.dyn_toString(refObj.UserCustomActions));
                usedFields.Add("WebInfos");
            this.WebInfos_ = new SP.WebInformation(HMS.SP.SPUtil.dyn_toString(refObj.WebInfos));
                usedFields.Add("Webs");
            this.Webs_ = new SP.WebCollection(HMS.SP.SPUtil.dyn_toString(refObj.Webs));
                usedFields.Add("WebTemplate");
            HMS.SP.SPUtil.dyn_ValueSet("WebTemplate", refObj, this);
                usedFields.Add("WorkflowAssociations");
            this.WorkflowAssociations_ = new SP.WorkflowAssociationCollection(HMS.SP.SPUtil.dyn_toString(refObj.WorkflowAssociations));
                usedFields.Add("WorkflowTemplates");
            this.WorkflowTemplates_ = new SP.WorkflowTemplateCollection(HMS.SP.SPUtil.dyn_toString(refObj.WorkflowTemplates));
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

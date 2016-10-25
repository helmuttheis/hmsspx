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
    /// <para>https://msdn.microsoft.com/en-us/library/office/dn531433.aspx#bk_List</para>
    /// </summary>
    public class List : SPBase,iSP{
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
        /// <para>Gets a value that specifies whether the list supports content types.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("AllowContentTypes")]
        public Boolean AllowContentTypes_ { set; get; }
        /// <summary>
        /// <para>Gets the list definition type on which the list is based. Represents a ListTemplateType value. See ListTemplateType in the .NET client object model reference for template type values.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("BaseTemplate")]
        public Int32 BaseTemplate_ { set; get; }
        /// <summary>
        /// <para>Gets the base type for the list. Represents an SP.BaseType value: Generic List = 0; Document Library = 1; Discussion Board = 3; Survey = 4; Issue = 5.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("BaseType")]
        public Int32 BaseType_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the override of the web application's BrowserFileHandling property at the list level. Represents an SP.BrowserFileHandling value: Permissive = 0; Strict = 1.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("BrowserFileHandling")]
        public Int32 BrowserFileHandling_ { set; get; }
        /// <summary>
        /// <para>Gets the content types that are associated with the list.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("ContentTypes")]
        public SP.ContentTypeCollection ContentTypes_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether content types are enabled for the list.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ContentTypesEnabled")]
        public Boolean ContentTypesEnabled_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies when the list was created.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Created")]
        public DateTime Created_ { set; get; }
        /// <summary>
        /// <para>Gets the data source associated with the list, or null if the list is not a virtual list. Returns null if the HasExternalDataSource property is false.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("DataSource")]
        public SP.ListDataSource DataSource_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the default workflow identifier for content approval on the list. Returns an empty GUID if there is no default content approval workflow.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("DefaultContentApprovalWorkflowId")]
        public Guid DefaultContentApprovalWorkflowId_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the location of the default display form for the list. Clients specify a server-relative URL, and the server returns a site-relative URL</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("DefaultDisplayFormUrl")]
        public String DefaultDisplayFormUrl_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the URL of the edit form to use for list items in the list. Clients specify a server-relative URL, and the server returns a site-relative URL.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("DefaultEditFormUrl")]
        public String DefaultEditFormUrl_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the location of the default new form for the list. Clients specify a server-relative URL, and the server returns a site-relative URL.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("DefaultNewFormUrl")]
        public String DefaultNewFormUrl_ { set; get; }
        /// <summary>
        /// <para></para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("DefaultView")]
        public SP.View DefaultView_ { set; get; }
        /// <summary>
        /// <para>Gets the URL of the default view for the list.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("DefaultViewUrl")]
        public String DefaultViewUrl_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the description of the list.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Description")]
        public String Description_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the description of the list.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("DescriptionResource")]
        public SP.__deferred DescriptionResource_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the reading order of the list. Returns "NONE", "LTR", or "RTL".</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Direction")]
        public String Direction_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the server-relative URL of the document template for the list. Returns a server-relative URL if the base type is DocumentLibrary, otherwise returns null.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("DocumentTemplateUrl")]
        public String DocumentTemplateUrl_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the minimum permission required to view minor versions and drafts within the list. Represents an SP.DraftVisibilityType value: Reader = 0; Author = 1; Approver = 2.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("DraftVersionVisibility")]
        public Int32 DraftVersionVisibility_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the effective permissions on the list that are assigned to the current user.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("EffectiveBasePermissions")]
        public SP.BasePermissions EffectiveBasePermissions_ { set; get; }
        /// <summary>
        /// <para></para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("EffectiveBasePermissionsForUI")]
        public SP.BasePermissions EffectiveBasePermissionsForUI_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether list item attachments are enabled for the list.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("EnableAttachments")]
        public Boolean EnableAttachments_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether new list folders can be added to the list.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("EnableFolderCreation")]
        public Boolean EnableFolderCreation_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether minor versions are enabled for the list.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("EnableMinorVersions")]
        public Boolean EnableMinorVersions_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether content approval is enabled for the list.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("EnableModeration")]
        public Boolean EnableModeration_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether historical versions of list items and documents can be created in the list.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("EnableVersioning")]
        public Boolean EnableVersioning_ { set; get; }
        /// <summary>
        /// <para></para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("EntityTypeName")]
        public String EntityTypeName_ { set; get; }
        /// <summary>
        /// <para></para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("EventReceivers")]
        public SP.EventReceiverDefinitionCollection EventReceivers_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the collection of all fields in the list.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Fields")]
        public SP.FieldCollection Fields_ { set; get; }
        /// <summary>
        /// <para>Gets the object where role assignments for this object are defined. If role assignments are defined directly on the current object, the current object is returned.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("FirstUniqueAncestorSecurableObject")]
        public SP.SecurableObject FirstUniqueAncestorSecurableObject_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that indicates whether forced checkout is enabled for the document library.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ForceCheckout")]
        public Boolean ForceCheckout_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the collection of all list forms in the list.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Forms")]
        public SP.FormCollection Forms_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the list is an external list.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("HasExternalDataSource")]
        public Boolean HasExternalDataSource_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the role assignments are uniquely defined for this securable object or inherited from a parent securable object.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("HasUniqueRoleAssignments")]
        public Boolean HasUniqueRoleAssignments_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a Boolean value that specifies whether the list is hidden. If true, the server sets the OnQuickLaunch property to false.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Hidden")]
        public Boolean Hidden_ { set; get; }
        /// <summary>
        /// <para>Gets the GUID that identifies the list in the database.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Id")]
        public Guid Id_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the URI for the icon of the list.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public String ImageUrl_ { set; get; }
        /// <summary>
        /// <para></para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("InformationRightsManagementSettings")]
        public SP.InformationRightsManagementSettings InformationRightsManagementSettings_ { set; get; }
        /// <summary>
        /// <para></para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("IrmEnabled")]
        public Boolean IrmEnabled_ { set; get; }
        /// <summary>
        /// <para></para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("IrmExpire")]
        public Boolean IrmExpire_ { set; get; }
        /// <summary>
        /// <para></para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("IrmReject")]
        public Boolean IrmReject_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies a flag that a client application can use to determine whether to display the list.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("IsApplicationList")]
        public Boolean IsApplicationList_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the list is a gallery.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("IsCatalog")]
        public Boolean IsCatalog_ { set; get; }
        /// <summary>
        /// <para></para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("IsPrivate")]
        public Boolean IsPrivate_ { set; get; }
        /// <summary>
        /// <para>Gets a value that indicates whether the list is designated as a default asset location for images or other files which the users upload to their wiki pages.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("IsSiteAssetsLibrary")]
        public Boolean IsSiteAssetsLibrary_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the number of list items in the list.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ItemCount")]
        public Int32 ItemCount_ { set; get; }
        /// <summary>
        /// <para>Gets all the items in the list.You can use OData query operations to filter items (example: …/lists(guid'51925dd7-2108-481a-b1ef-4bfa4e69d48b')/items?$filter=Status eq 'not started'&$select=Title&$top=5).</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Items")]
        public SP.ListItemCollection Items_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the last time a list item was deleted from the list.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("LastItemDeletedDate")]
        public DateTime LastItemDeletedDate_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the last time a list item, field, or property of the list was modified.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("LastItemModifiedDate")]
        public DateTime LastItemModifiedDate_ { set; get; }
        /// <summary>
        /// <para></para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ListItemEntityTypeFullName")]
        public String ListItemEntityTypeFullName_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that indicates whether the list in a Meeting Workspace site contains data for multiple meeting instances within the site.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("MultipleDataList")]
        public Boolean MultipleDataList_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies that the crawler must not crawl the list.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("NoCrawl")]
        public Boolean NoCrawl_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the list appears on the Quick Launch of the site. If true, the server sets the Hidden property to false.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("OnQuickLaunch")]
        public Boolean OnQuickLaunch_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the site that contains the list.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("ParentWeb")]
        public SP.Web ParentWeb_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the server-relative URL of the site that contains the list.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ParentWebUrl")]
        public String ParentWebUrl_ { set; get; }
        /// <summary>
        /// <para>Gets the role assignments for the securable object.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("RoleAssignments")]
        public SP.RoleAssignmentCollection RoleAssignments_ { set; get; }
        /// <summary>
        /// <para>Gets the root folder that contains the files in the list and any related files.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("RootFolder")]
        public SP.Folder RootFolder_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the list schema of the list.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("SchemaXml")]
        public String SchemaXml_ { set; get; }
        /// <summary>
        /// <para>Gets a value that indicates whether folders can be created within the list.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ServerTemplateCanCreateFolders")]
        public Boolean ServerTemplateCanCreateFolders_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the feature identifier of the feature that contains the list schema for the list. Returns an empty GUID if the list schema is not contained within a feature.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("TemplateFeatureId")]
        public Guid TemplateFeatureId_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the displayed title for the list. Its length must be <= 255 characters.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Title")]
        public String Title_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the displayed title for the list. Its length must be <= 255 characters.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("TitleResource")]
        public SP.__deferred TitleResource_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the collection of all user custom actions for the list.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("UserCustomActions")]
        public SP.UserCustomActionCollection UserCustomActions_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the data validation criteria for a list item. Its length must be <= 1023.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("ValidationFormula")]
        public String ValidationFormula_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the error message returned when data validation fails for a list item. Its length must be <= 1023.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("ValidationMessage")]
        public String ValidationMessage_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the collection of all public views on the list and personal views of the current user on the list.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("Views")]
        public SP.ViewCollection Views_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the collection of all workflow associations for the list.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("WorkflowAssociations")]
        public SP.Workflow.WorkflowAssociationCollection WorkflowAssociations_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
            "http://<site url>/web/lists(guid'<list id>')",
        };

        public List(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(List));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  List()
        {
        }
        public  List(string json)
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
                usedFields.Add("AllowContentTypes");
            HMS.SP.SPUtil.dyn_ValueSet("AllowContentTypes", refObj, this);
                usedFields.Add("BaseTemplate");
            HMS.SP.SPUtil.dyn_ValueSet("BaseTemplate", refObj, this);
                usedFields.Add("BaseType");
            HMS.SP.SPUtil.dyn_ValueSet("BaseType", refObj, this);
                usedFields.Add("BrowserFileHandling");
            HMS.SP.SPUtil.dyn_ValueSet("BrowserFileHandling", refObj, this);
                usedFields.Add("ContentTypes");
            this.ContentTypes_ = new SP.ContentTypeCollection(HMS.SP.SPUtil.dyn_toString(refObj.ContentTypes));
                usedFields.Add("ContentTypesEnabled");
            HMS.SP.SPUtil.dyn_ValueSet("ContentTypesEnabled", refObj, this);
                usedFields.Add("Created");
            HMS.SP.SPUtil.dyn_ValueSet("Created", refObj, this);
                usedFields.Add("DataSource");
            this.DataSource_ = new SP.ListDataSource(HMS.SP.SPUtil.dyn_toString(refObj.DataSource));
                usedFields.Add("DefaultContentApprovalWorkflowId");
            HMS.SP.SPUtil.dyn_ValueSet("DefaultContentApprovalWorkflowId", refObj, this);
                usedFields.Add("DefaultDisplayFormUrl");
            HMS.SP.SPUtil.dyn_ValueSet("DefaultDisplayFormUrl", refObj, this);
                usedFields.Add("DefaultEditFormUrl");
            HMS.SP.SPUtil.dyn_ValueSet("DefaultEditFormUrl", refObj, this);
                usedFields.Add("DefaultNewFormUrl");
            HMS.SP.SPUtil.dyn_ValueSet("DefaultNewFormUrl", refObj, this);
                usedFields.Add("DefaultView");
            this.DefaultView_ = new SP.View(HMS.SP.SPUtil.dyn_toString(refObj.DefaultView));
                usedFields.Add("DefaultViewUrl");
            HMS.SP.SPUtil.dyn_ValueSet("DefaultViewUrl", refObj, this);
                usedFields.Add("Description");
            HMS.SP.SPUtil.dyn_ValueSet("Description", refObj, this);
                usedFields.Add("DescriptionResource");
            this.DescriptionResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.DescriptionResource));
                usedFields.Add("Direction");
            HMS.SP.SPUtil.dyn_ValueSet("Direction", refObj, this);
                usedFields.Add("DocumentTemplateUrl");
            HMS.SP.SPUtil.dyn_ValueSet("DocumentTemplateUrl", refObj, this);
                usedFields.Add("DraftVersionVisibility");
            HMS.SP.SPUtil.dyn_ValueSet("DraftVersionVisibility", refObj, this);
                usedFields.Add("EffectiveBasePermissions");
            this.EffectiveBasePermissions_ = new SP.BasePermissions(HMS.SP.SPUtil.dyn_toString(refObj.EffectiveBasePermissions));
                usedFields.Add("EffectiveBasePermissionsForUI");
            this.EffectiveBasePermissionsForUI_ = new SP.BasePermissions(HMS.SP.SPUtil.dyn_toString(refObj.EffectiveBasePermissionsForUI));
                usedFields.Add("EnableAttachments");
            HMS.SP.SPUtil.dyn_ValueSet("EnableAttachments", refObj, this);
                usedFields.Add("EnableFolderCreation");
            HMS.SP.SPUtil.dyn_ValueSet("EnableFolderCreation", refObj, this);
                usedFields.Add("EnableMinorVersions");
            HMS.SP.SPUtil.dyn_ValueSet("EnableMinorVersions", refObj, this);
                usedFields.Add("EnableModeration");
            HMS.SP.SPUtil.dyn_ValueSet("EnableModeration", refObj, this);
                usedFields.Add("EnableVersioning");
            HMS.SP.SPUtil.dyn_ValueSet("EnableVersioning", refObj, this);
                usedFields.Add("EntityTypeName");
            HMS.SP.SPUtil.dyn_ValueSet("EntityTypeName", refObj, this);
                usedFields.Add("EventReceivers");
            this.EventReceivers_ = new SP.EventReceiverDefinitionCollection(HMS.SP.SPUtil.dyn_toString(refObj.EventReceivers));
                usedFields.Add("Fields");
            this.Fields_ = new SP.FieldCollection(HMS.SP.SPUtil.dyn_toString(refObj.Fields));
                usedFields.Add("FirstUniqueAncestorSecurableObject");
            this.FirstUniqueAncestorSecurableObject_ = new SP.SecurableObject(HMS.SP.SPUtil.dyn_toString(refObj.FirstUniqueAncestorSecurableObject));
                usedFields.Add("ForceCheckout");
            HMS.SP.SPUtil.dyn_ValueSet("ForceCheckout", refObj, this);
                usedFields.Add("Forms");
            this.Forms_ = new SP.FormCollection(HMS.SP.SPUtil.dyn_toString(refObj.Forms));
                usedFields.Add("HasExternalDataSource");
            HMS.SP.SPUtil.dyn_ValueSet("HasExternalDataSource", refObj, this);
                usedFields.Add("HasUniqueRoleAssignments");
            HMS.SP.SPUtil.dyn_ValueSet("HasUniqueRoleAssignments", refObj, this);
                usedFields.Add("Hidden");
            HMS.SP.SPUtil.dyn_ValueSet("Hidden", refObj, this);
                usedFields.Add("Id");
            HMS.SP.SPUtil.dyn_ValueSet("Id", refObj, this);
                usedFields.Add("ImageUrl");
            HMS.SP.SPUtil.dyn_ValueSet("ImageUrl", refObj, this);
                usedFields.Add("InformationRightsManagementSettings");
            this.InformationRightsManagementSettings_ = new SP.InformationRightsManagementSettings(HMS.SP.SPUtil.dyn_toString(refObj.InformationRightsManagementSettings));
                usedFields.Add("IrmEnabled");
            HMS.SP.SPUtil.dyn_ValueSet("IrmEnabled", refObj, this);
                usedFields.Add("IrmExpire");
            HMS.SP.SPUtil.dyn_ValueSet("IrmExpire", refObj, this);
                usedFields.Add("IrmReject");
            HMS.SP.SPUtil.dyn_ValueSet("IrmReject", refObj, this);
                usedFields.Add("IsApplicationList");
            HMS.SP.SPUtil.dyn_ValueSet("IsApplicationList", refObj, this);
                usedFields.Add("IsCatalog");
            HMS.SP.SPUtil.dyn_ValueSet("IsCatalog", refObj, this);
                usedFields.Add("IsPrivate");
            HMS.SP.SPUtil.dyn_ValueSet("IsPrivate", refObj, this);
                usedFields.Add("IsSiteAssetsLibrary");
            HMS.SP.SPUtil.dyn_ValueSet("IsSiteAssetsLibrary", refObj, this);
                usedFields.Add("ItemCount");
            HMS.SP.SPUtil.dyn_ValueSet("ItemCount", refObj, this);
                usedFields.Add("Items");
            this.Items_ = new SP.ListItemCollection(HMS.SP.SPUtil.dyn_toString(refObj.Items));
                usedFields.Add("LastItemDeletedDate");
            HMS.SP.SPUtil.dyn_ValueSet("LastItemDeletedDate", refObj, this);
                usedFields.Add("LastItemModifiedDate");
            HMS.SP.SPUtil.dyn_ValueSet("LastItemModifiedDate", refObj, this);
                usedFields.Add("ListItemEntityTypeFullName");
            HMS.SP.SPUtil.dyn_ValueSet("ListItemEntityTypeFullName", refObj, this);
                usedFields.Add("MultipleDataList");
            HMS.SP.SPUtil.dyn_ValueSet("MultipleDataList", refObj, this);
                usedFields.Add("NoCrawl");
            HMS.SP.SPUtil.dyn_ValueSet("NoCrawl", refObj, this);
                usedFields.Add("OnQuickLaunch");
            HMS.SP.SPUtil.dyn_ValueSet("OnQuickLaunch", refObj, this);
                usedFields.Add("ParentWeb");
            this.ParentWeb_ = new SP.Web(HMS.SP.SPUtil.dyn_toString(refObj.ParentWeb));
                usedFields.Add("ParentWebUrl");
            HMS.SP.SPUtil.dyn_ValueSet("ParentWebUrl", refObj, this);
                usedFields.Add("RoleAssignments");
            this.RoleAssignments_ = new SP.RoleAssignmentCollection(HMS.SP.SPUtil.dyn_toString(refObj.RoleAssignments));
                usedFields.Add("RootFolder");
            this.RootFolder_ = new SP.Folder(HMS.SP.SPUtil.dyn_toString(refObj.RootFolder));
                usedFields.Add("SchemaXml");
            HMS.SP.SPUtil.dyn_ValueSet("SchemaXml", refObj, this);
                usedFields.Add("ServerTemplateCanCreateFolders");
            HMS.SP.SPUtil.dyn_ValueSet("ServerTemplateCanCreateFolders", refObj, this);
                usedFields.Add("TemplateFeatureId");
            HMS.SP.SPUtil.dyn_ValueSet("TemplateFeatureId", refObj, this);
                usedFields.Add("Title");
            HMS.SP.SPUtil.dyn_ValueSet("Title", refObj, this);
                usedFields.Add("TitleResource");
            this.TitleResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.TitleResource));
                usedFields.Add("UserCustomActions");
            this.UserCustomActions_ = new SP.UserCustomActionCollection(HMS.SP.SPUtil.dyn_toString(refObj.UserCustomActions));
                usedFields.Add("ValidationFormula");
            HMS.SP.SPUtil.dyn_ValueSet("ValidationFormula", refObj, this);
                usedFields.Add("ValidationMessage");
            HMS.SP.SPUtil.dyn_ValueSet("ValidationMessage", refObj, this);
                usedFields.Add("Views");
            this.Views_ = new SP.ViewCollection(HMS.SP.SPUtil.dyn_toString(refObj.Views));
                usedFields.Add("WorkflowAssociations");
            this.WorkflowAssociations_ = new SP.Workflow.WorkflowAssociationCollection(HMS.SP.SPUtil.dyn_toString(refObj.WorkflowAssociations));
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

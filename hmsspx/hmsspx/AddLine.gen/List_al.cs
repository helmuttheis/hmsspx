/* **********************************************************************************************************
 * The MIT License (MIT)																					*
 * 																											*
 * Copyright (c) 2016 Hypermediasystems Ges. f. Software mbH										*
 * Web: http://www.hypermediasystems.de																		*
 * This file is part of hmsspx																			*
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
namespace hmsspx
{
    partial class pageBase
    {
        public int add_List(int level, HMS.SP.List spList)
        {
            return add_List(-1, level, spList);
        }
        public int  add_List(int pos, int level, HMS.SP.List spList)
        {
            if (spList.__HMSError_ != null && (spList.__HMSError_.errno != 0 || spList.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spList.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spList.__deferred_);
            pos = this.add__metadata(pos, level, spList.__metadata_);
            pos = this.add__rest(pos, level, spList.__rest);
            pos = this.add_lineAt(pos,level,  "AllowContentTypes", HMS.SP.SPUtil.toString(spList.AllowContentTypes_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "BaseTemplate", HMS.SP.SPUtil.toString(spList.BaseTemplate_)); //Int32;
            pos = this.add_lineAt(pos,level,  "BaseType", HMS.SP.SPUtil.toString(spList.BaseType_)); //Int32;
            pos = this.add_lineAt(pos,level,  "BrowserFileHandling", HMS.SP.SPUtil.toString(spList.BrowserFileHandling_)); //Int32;
            pos = this.add_deferredAt(pos,level, "ContentTypes", "...", myType.GetType("SP.ContentType"), spList.ContentTypes_.__deferred_); //ContentType;
            pos = this.add_lineAt(pos,level,  "ContentTypesEnabled", HMS.SP.SPUtil.toString(spList.ContentTypesEnabled_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Created", HMS.SP.SPUtil.toString(spList.Created_)); //DateTime;
            pos = this.add_deferredAt(pos,level, "DataSource", "...", knownPages.pageListDataSource , spList.DataSource_.__deferred_); //ListDataSource;
            pos = this.add_lineAt(pos,level,  "DefaultContentApprovalWorkflowId", HMS.SP.SPUtil.toString(spList.DefaultContentApprovalWorkflowId_)); //Guid;
            pos = this.add_lineAt(pos,level,  "DefaultDisplayFormUrl", HMS.SP.SPUtil.toString(spList.DefaultDisplayFormUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "DefaultEditFormUrl", HMS.SP.SPUtil.toString(spList.DefaultEditFormUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "DefaultNewFormUrl", HMS.SP.SPUtil.toString(spList.DefaultNewFormUrl_)); //String;
            pos = this.add_deferredAt(pos,level, "DefaultView", "...", knownPages.pageView , spList.DefaultView_.__deferred_); //View;
            pos = this.add_lineAt(pos,level,  "DefaultViewUrl", HMS.SP.SPUtil.toString(spList.DefaultViewUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "Description", HMS.SP.SPUtil.toString(spList.Description_)); //String;
            pos = this.add_lineAt(pos,level,  "Direction", HMS.SP.SPUtil.toString(spList.Direction_)); //String;
            pos = this.add_lineAt(pos,level,  "DocumentTemplateUrl", HMS.SP.SPUtil.toString(spList.DocumentTemplateUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "DraftVersionVisibility", HMS.SP.SPUtil.toString(spList.DraftVersionVisibility_)); //Int32;
            pos = this.add_deferredAt(pos,level, "EffectiveBasePermissions", "...", knownPages.pageBasePermissions , spList.EffectiveBasePermissions_.__deferred_); //BasePermissions;
            pos = this.add_deferredAt(pos,level, "EffectiveBasePermissionsForUI", "...", knownPages.pageBasePermissions , spList.EffectiveBasePermissionsForUI_.__deferred_); //BasePermissions;
            pos = this.add_lineAt(pos,level,  "EnableAttachments", HMS.SP.SPUtil.toString(spList.EnableAttachments_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "EnableFolderCreation", HMS.SP.SPUtil.toString(spList.EnableFolderCreation_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "EnableMinorVersions", HMS.SP.SPUtil.toString(spList.EnableMinorVersions_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "EnableModeration", HMS.SP.SPUtil.toString(spList.EnableModeration_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "EnableVersioning", HMS.SP.SPUtil.toString(spList.EnableVersioning_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "EntityTypeName", HMS.SP.SPUtil.toString(spList.EntityTypeName_)); //String;
            pos = this.add_deferredAt(pos,level, "EventReceivers", "...", myType.GetType("SP.EventReceiverDefinition"), spList.EventReceivers_.__deferred_); //EventReceiverDefinition;
            pos = this.add_deferredAt(pos,level, "Fields", "...", myType.GetType("SP.Field"), spList.Fields_.__deferred_); //Field;
            pos = this.add_deferredAt(pos,level, "FirstUniqueAncestorSecurableObject", "...", knownPages.pageSecurableObject , spList.FirstUniqueAncestorSecurableObject_.__deferred_); //SecurableObject;
            pos = this.add_lineAt(pos,level,  "ForceCheckout", HMS.SP.SPUtil.toString(spList.ForceCheckout_)); //Boolean;
            pos = this.add_deferredAt(pos,level, "Forms", "...", myType.GetType("SP.Form"), spList.Forms_.__deferred_); //Form;
            pos = this.add_lineAt(pos,level,  "HasExternalDataSource", HMS.SP.SPUtil.toString(spList.HasExternalDataSource_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "HasUniqueRoleAssignments", HMS.SP.SPUtil.toString(spList.HasUniqueRoleAssignments_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Hidden", HMS.SP.SPUtil.toString(spList.Hidden_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spList.Id_)); //Guid;
            pos = this.add_lineAt(pos,level,  "ImageUrl", HMS.SP.SPUtil.toString(spList.ImageUrl_)); //String;
            pos = this.add_deferredAt(pos,level, "InformationRightsManagementSettings", "...", knownPages.pageInformationRightsManagementSettings , spList.InformationRightsManagementSettings_.__deferred_); //InformationRightsManagementSettings;
            pos = this.add_lineAt(pos,level,  "IrmEnabled", HMS.SP.SPUtil.toString(spList.IrmEnabled_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "IrmExpire", HMS.SP.SPUtil.toString(spList.IrmExpire_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "IrmReject", HMS.SP.SPUtil.toString(spList.IrmReject_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "IsApplicationList", HMS.SP.SPUtil.toString(spList.IsApplicationList_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "IsCatalog", HMS.SP.SPUtil.toString(spList.IsCatalog_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "IsPrivate", HMS.SP.SPUtil.toString(spList.IsPrivate_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "IsSiteAssetsLibrary", HMS.SP.SPUtil.toString(spList.IsSiteAssetsLibrary_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "ItemCount", HMS.SP.SPUtil.toString(spList.ItemCount_)); //Int32;
            pos = this.add_deferredAt(pos,level, "Items", "...", myType.GetType("SP.ListItem"), spList.Items_.__deferred_); //ListItem;
            pos = this.add_lineAt(pos,level,  "LastItemDeletedDate", HMS.SP.SPUtil.toString(spList.LastItemDeletedDate_)); //DateTime;
            pos = this.add_lineAt(pos,level,  "LastItemModifiedDate", HMS.SP.SPUtil.toString(spList.LastItemModifiedDate_)); //DateTime;
            pos = this.add_lineAt(pos,level,  "ListItemEntityTypeFullName", HMS.SP.SPUtil.toString(spList.ListItemEntityTypeFullName_)); //String;
            pos = this.add_lineAt(pos,level,  "MultipleDataList", HMS.SP.SPUtil.toString(spList.MultipleDataList_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "NoCrawl", HMS.SP.SPUtil.toString(spList.NoCrawl_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "OnQuickLaunch", HMS.SP.SPUtil.toString(spList.OnQuickLaunch_)); //Boolean;
            pos = this.add_deferredAt(pos,level, "ParentWeb", "...", knownPages.pageWeb , spList.ParentWeb_.__deferred_); //Web;
            pos = this.add_lineAt(pos,level,  "ParentWebUrl", HMS.SP.SPUtil.toString(spList.ParentWebUrl_)); //String;
            pos = this.add_deferredAt(pos,level, "RoleAssignments", "...", myType.GetType("SP.RoleAssignment"), spList.RoleAssignments_.__deferred_); //RoleAssignment;
            pos = this.add_deferredAt(pos,level, "RootFolder", "...", knownPages.pageFolder , spList.RootFolder_.__deferred_); //Folder;
            pos = this.add_lineAt(pos,level,  "SchemaXml", HMS.SP.SPUtil.toString(spList.SchemaXml_)); //String;
            pos = this.add_lineAt(pos,level,  "ServerTemplateCanCreateFolders", HMS.SP.SPUtil.toString(spList.ServerTemplateCanCreateFolders_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "TemplateFeatureId", HMS.SP.SPUtil.toString(spList.TemplateFeatureId_)); //Guid;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spList.Title_)); //String;
            pos = this.add_deferredAt(pos,level, "UserCustomActions", "...", myType.GetType("SP.UserCustomAction"), spList.UserCustomActions_.__deferred_); //UserCustomAction;
            pos = this.add_lineAt(pos,level,  "ValidationFormula", HMS.SP.SPUtil.toString(spList.ValidationFormula_)); //String;
            pos = this.add_lineAt(pos,level,  "ValidationMessage", HMS.SP.SPUtil.toString(spList.ValidationMessage_)); //String;
            pos = this.add_deferredAt(pos,level, "Views", "...", myType.GetType("SP.View"), spList.Views_.__deferred_); //View;
            pos = this.add_lineAt(pos,level,  "WorkflowAssociations", HMS.SP.SPUtil.toString(spList.WorkflowAssociations_)); //Workflow.WorkflowAssociation;
            return pos;
        }
        public int add_List_deferred(int pos, int level, HMS.SP.List spList)
        {
            if (spList.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "List", HMS.SP.SPUtil.toString(spList.Title_), knownPages.NONE,""); //String;
                pos = add_List(pos, level + 1, spList);
            }
            else
            {
                string useUrl = spList.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spList.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spList.Title_, "", knownPages.pageList, useUrl);
            }
        return pos;
        }
    }
}

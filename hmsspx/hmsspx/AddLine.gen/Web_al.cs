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
        public int add_Web(int level, HMS.SP.Web spWeb)
        {
            return add_Web(-1, level, spWeb);
        }
        public int  add_Web(int pos, int level, HMS.SP.Web spWeb)
        {
            if (spWeb.__HMSError_ != null && (spWeb.__HMSError_.errno != 0 || spWeb.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spWeb.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spWeb.__deferred_);
            pos = this.add__metadata(pos, level, spWeb.__metadata_);
            pos = this.add__rest(pos, level, spWeb.__rest);
            pos = this.add_lineAt(pos,level,  "AllowCreateDeclarativeWorkflowForCurrentUser", HMS.SP.SPUtil.toString(spWeb.AllowCreateDeclarativeWorkflowForCurrentUser_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "AllowDesignerForCurrentUser", HMS.SP.SPUtil.toString(spWeb.AllowDesignerForCurrentUser_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "AllowMasterPageEditingForCurrentUser", HMS.SP.SPUtil.toString(spWeb.AllowMasterPageEditingForCurrentUser_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "AllowRevertFromTemplateForCurrentUser", HMS.SP.SPUtil.toString(spWeb.AllowRevertFromTemplateForCurrentUser_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "AllowRssFeeds", HMS.SP.SPUtil.toString(spWeb.AllowRssFeeds_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "AllowSaveDeclarativeWorkflowAsTemplateForCurrentUser", HMS.SP.SPUtil.toString(spWeb.AllowSaveDeclarativeWorkflowAsTemplateForCurrentUser_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "AllowSavePublishDeclarativeWorkflowForCurrentUser", HMS.SP.SPUtil.toString(spWeb.AllowSavePublishDeclarativeWorkflowForCurrentUser_)); //Boolean;
            pos = this.add_deferredAt(pos,level, "AllProperties", "...", knownPages.pagePropertyValues , spWeb.AllProperties_.__deferred_); //PropertyValues;
            pos = this.add_lineAt(pos,level,  "AppInstanceId", HMS.SP.SPUtil.toString(spWeb.AppInstanceId_)); //Guid;
            pos = this.add_deferredAt(pos,level, "AssociatedMemberGroup", "...", knownPages.pageGroup , spWeb.AssociatedMemberGroup_.__deferred_); //Group;
            pos = this.add_deferredAt(pos,level, "AssociatedOwnerGroup", "...", knownPages.pageGroup , spWeb.AssociatedOwnerGroup_.__deferred_); //Group;
            pos = this.add_deferredAt(pos,level, "AssociatedVisitorGroup", "...", knownPages.pageGroup , spWeb.AssociatedVisitorGroup_.__deferred_); //Group;
            pos = this.add_deferredAt(pos,level, "AvailableContentTypes", "...", myType.GetType("SP.ContentType"), spWeb.AvailableContentTypes_.__deferred_); //ContentType;
            pos = this.add_deferredAt(pos,level, "AvailableFields", "...", myType.GetType("SP.Field"), spWeb.AvailableFields_.__deferred_); //Field;
            pos = this.add_lineAt(pos,level,  "Configuration", HMS.SP.SPUtil.toString(spWeb.Configuration_)); //Int16;
            pos = this.add_deferredAt(pos,level, "ContentTypes", "...", myType.GetType("SP.ContentType"), spWeb.ContentTypes_.__deferred_); //ContentType;
            pos = this.add_lineAt(pos,level,  "Created", HMS.SP.SPUtil.toString(spWeb.Created_)); //DateTime;
            pos = this.add_deferredAt(pos,level, "CurrentUser", "...", knownPages.pageUser , spWeb.CurrentUser_.__deferred_); //User;
            pos = this.add_lineAt(pos,level,  "CustomMasterUrl", HMS.SP.SPUtil.toString(spWeb.CustomMasterUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "Description", HMS.SP.SPUtil.toString(spWeb.Description_)); //String;
            pos = this.add_lineAt(pos,level,  "DesignerDownloadUrlForCurrentUser", HMS.SP.SPUtil.toString(spWeb.DesignerDownloadUrlForCurrentUser_)); //String;
            pos = this.add_lineAt(pos,level,  "DocumentLibraryCalloutOfficeWebAppPreviewersDisabled", HMS.SP.SPUtil.toString(spWeb.DocumentLibraryCalloutOfficeWebAppPreviewersDisabled_)); //Boolean;
            pos = this.add_deferredAt(pos,level, "EffectiveBasePermissions", "...", knownPages.pageBasePermissions , spWeb.EffectiveBasePermissions_.__deferred_); //BasePermissions;
            pos = this.add_lineAt(pos,level,  "EnableMinimalDownload", HMS.SP.SPUtil.toString(spWeb.EnableMinimalDownload_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "EventReceivers", HMS.SP.SPUtil.toString(spWeb.EventReceivers_)); //EventReceiver;
            pos = this.add_deferredAt(pos,level, "Features", "...", myType.GetType("SP.Feature"), spWeb.Features_.__deferred_); //Feature;
            pos = this.add_deferredAt(pos,level, "Fields", "...", myType.GetType("SP.Field"), spWeb.Fields_.__deferred_); //Field;
            pos = this.add_deferredAt(pos,level, "Folders", "...", myType.GetType("SP.Folder"), spWeb.Folders_.__deferred_); //Folder;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spWeb.Id_)); //Guid;
            pos = this.add_lineAt(pos,level,  "Language", HMS.SP.SPUtil.toString(spWeb.Language_)); //Int32;
            pos = this.add_lineAt(pos,level,  "LastItemModifiedDate", HMS.SP.SPUtil.toString(spWeb.LastItemModifiedDate_)); //DateTime;
            pos = this.add_deferredAt(pos,level, "Lists", "...", myType.GetType("SP.List"), spWeb.Lists_.__deferred_); //List;
            pos = this.add_deferredAt(pos,level, "ListTemplates", "...", myType.GetType("SP.ListTemplate"), spWeb.ListTemplates_.__deferred_); //ListTemplate;
            pos = this.add_lineAt(pos,level,  "MasterUrl", HMS.SP.SPUtil.toString(spWeb.MasterUrl_)); //String;
            pos = this.add_deferredAt(pos,level, "Navigation", "...", knownPages.pageNavigation , spWeb.Navigation_.__deferred_); //Navigation;
            pos = this.add_deferredAt(pos,level, "ParentWeb", "...", knownPages.pageWeb , spWeb.ParentWeb_.__deferred_); //Web;
            pos = this.add_deferredAt(pos,level, "PushNotificationSubscribers", "...", myType.GetType("SP.PushNotificationSubscriber"), spWeb.PushNotificationSubscribers_.__deferred_); //PushNotificationSubscriber;
            pos = this.add_lineAt(pos,level,  "QuickLaunchEnabled", HMS.SP.SPUtil.toString(spWeb.QuickLaunchEnabled_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "RecycleBin", HMS.SP.SPUtil.toString(spWeb.RecycleBin_)); //RecycleBin;
            pos = this.add_lineAt(pos,level,  "RecycleBinEnabled", HMS.SP.SPUtil.toString(spWeb.RecycleBinEnabled_)); //Boolean;
            pos = this.add_deferredAt(pos,level, "RegionalSettings", "...", knownPages.pageRegionalSettings , spWeb.RegionalSettings_.__deferred_); //RegionalSettings;
            pos = this.add_deferredAt(pos,level, "RoleDefinitions", "...", myType.GetType("SP.RoleDefinition"), spWeb.RoleDefinitions_.__deferred_); //RoleDefinition;
            pos = this.add_deferredAt(pos,level, "RootFolder", "...", knownPages.pageFolder , spWeb.RootFolder_.__deferred_); //Folder;
            pos = this.add_lineAt(pos,level,  "SaveSiteAsTemplateEnabled", HMS.SP.SPUtil.toString(spWeb.SaveSiteAsTemplateEnabled_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "ServerRelativeUrl", HMS.SP.SPUtil.toString(spWeb.ServerRelativeUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "ShowUrlStructureForCurrentUser", HMS.SP.SPUtil.toString(spWeb.ShowUrlStructureForCurrentUser_)); //Boolean;
            pos = this.add_deferredAt(pos,level, "SiteGroups", "...", myType.GetType("SP.Group"), spWeb.SiteGroups_.__deferred_); //Group;
            pos = this.add_deferredAt(pos,level, "SiteUserInfoList", "...", knownPages.pageList , spWeb.SiteUserInfoList_.__deferred_); //List;
            pos = this.add_deferredAt(pos,level, "SiteUsers", "...", myType.GetType("SP.User"), spWeb.SiteUsers_.__deferred_); //User;
            pos = this.add_lineAt(pos,level,  "SupportedUILanguageIds", HMS.SP.SPUtil.toString(spWeb.SupportedUILanguageIds_)); //Int32;
            pos = this.add_lineAt(pos,level,  "SyndicationEnabled", HMS.SP.SPUtil.toString(spWeb.SyndicationEnabled_)); //Boolean;
            pos = this.add_deferredAt(pos,level, "ThemeInfo", "...", knownPages.pageThemeInfo , spWeb.ThemeInfo_.__deferred_); //ThemeInfo;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spWeb.Title_)); //String;
            pos = this.add_lineAt(pos,level,  "TreeViewEnabled", HMS.SP.SPUtil.toString(spWeb.TreeViewEnabled_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "UIVersion", HMS.SP.SPUtil.toString(spWeb.UIVersion_)); //Int32;
            pos = this.add_lineAt(pos,level,  "UIVersionConfigurationEnabled", HMS.SP.SPUtil.toString(spWeb.UIVersionConfigurationEnabled_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Url", HMS.SP.SPUtil.toString(spWeb.Url_)); //String;
            pos = this.add_deferredAt(pos,level, "UserCustomActions", "...", myType.GetType("SP.UserCustomAction"), spWeb.UserCustomActions_.__deferred_); //UserCustomAction;
            pos = this.add_deferredAt(pos,level, "WebInfos", "...", knownPages.pageWebInformation , spWeb.WebInfos_.__deferred_); //WebInformation;
            pos = this.add_deferredAt(pos,level, "Webs", "...", myType.GetType("SP.Web"), spWeb.Webs_.__deferred_); //Web;
            pos = this.add_lineAt(pos,level,  "WebTemplate", HMS.SP.SPUtil.toString(spWeb.WebTemplate_)); //String;
            pos = this.add_lineAt(pos,level,  "WorkflowAssociations", HMS.SP.SPUtil.toString(spWeb.WorkflowAssociations_)); //WorkflowAssociation;
            pos = this.add_lineAt(pos,level,  "WorkflowTemplates", HMS.SP.SPUtil.toString(spWeb.WorkflowTemplates_)); //WorkflowTemplate;
            return pos;
        }
        public int add_Web_deferred(int pos, int level, HMS.SP.Web spWeb)
        {
            if (spWeb.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "Web", HMS.SP.SPUtil.toString(spWeb.Title_), knownPages.NONE,""); //String;
                pos = add_Web(pos, level + 1, spWeb);
            }
            else
            {
                string useUrl = spWeb.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spWeb.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spWeb.Title_, "", knownPages.pageWeb, useUrl);
            }
        return pos;
        }
    }
}

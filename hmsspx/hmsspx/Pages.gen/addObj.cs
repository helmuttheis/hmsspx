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
        public async void add_ObjAt(int pos, int level,Type t, string url)
        {
            if( t == null )
            {
                int curPos = this.add_lineAt(pos, level, false, "__generic", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                int delPos = curPos;
                string ret = await spglb.myClient.getJSON(url);
                HMS.SP.__generic spGeneric = new HMS.SP.__generic(ret);
                curPos = this.add__generic(curPos, level, spGeneric);
                this.add_lineRemove(delPos);
                // add_lineAt(pos, level, false, "add_ObjAt", "undefined type", hmsspx.pageBase.knownPages.NONE, "");
            }
            else if( t.Name == "AppLicense")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.AppLicenseCollection spAppLicenseCol = await SPGet.getAppLicenseCollection(spglb.myClient,url);
                if( spAppLicenseCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spAppLicenseCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spAppLicenseCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spAppLicenseCol.items.Count-1;i>=0;i--)
                    {
                        this.add_AppLicense_deferred(curPos,level+1, spAppLicenseCol.items[i]);
                    }
                    if( spAppLicenseCol.Count != spAppLicenseCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spAppLicenseCol.Count - spAppLicenseCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "Attachment")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.AttachmentCollection spAttachmentCol = await SPGet.getAttachmentCollection(spglb.myClient,url);
                if( spAttachmentCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spAttachmentCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spAttachmentCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spAttachmentCol.items.Count-1;i>=0;i--)
                    {
                        this.add_Attachment_deferred(curPos,level+1, spAttachmentCol.items[i]);
                    }
                    if( spAttachmentCol.Count != spAttachmentCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spAttachmentCol.Count - spAttachmentCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "Change")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.ChangeCollection spChangeCol = await SPGet.getChangeCollection(spglb.myClient,url);
                if( spChangeCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spChangeCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spChangeCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spChangeCol.items.Count-1;i>=0;i--)
                    {
                        this.add_Change_deferred(curPos,level+1, spChangeCol.items[i]);
                    }
                    if( spChangeCol.Count != spChangeCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spChangeCol.Count - spChangeCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "ContentType")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.ContentTypeCollection spContentTypeCol = await SPGet.getContentTypeCollection(spglb.myClient,url);
                if( spContentTypeCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spContentTypeCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spContentTypeCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spContentTypeCol.items.Count-1;i>=0;i--)
                    {
                        this.add_ContentType_deferred(curPos,level+1, spContentTypeCol.items[i]);
                    }
                    if( spContentTypeCol.Count != spContentTypeCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spContentTypeCol.Count - spContentTypeCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "EventReceiverDefinition")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.EventReceiverDefinitionCollection spEventReceiverDefinitionCol = await SPGet.getEventReceiverDefinitionCollection(spglb.myClient,url);
                if( spEventReceiverDefinitionCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spEventReceiverDefinitionCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spEventReceiverDefinitionCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spEventReceiverDefinitionCol.items.Count-1;i>=0;i--)
                    {
                        this.add_EventReceiverDefinition_deferred(curPos,level+1, spEventReceiverDefinitionCol.items[i]);
                    }
                    if( spEventReceiverDefinitionCol.Count != spEventReceiverDefinitionCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spEventReceiverDefinitionCol.Count - spEventReceiverDefinitionCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "Feature")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.FeatureCollection spFeatureCol = await SPGet.getFeatureCollection(spglb.myClient,url);
                if( spFeatureCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spFeatureCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spFeatureCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spFeatureCol.items.Count-1;i>=0;i--)
                    {
                        this.add_Feature_deferred(curPos,level+1, spFeatureCol.items[i]);
                    }
                    if( spFeatureCol.Count != spFeatureCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spFeatureCol.Count - spFeatureCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "Field")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.FieldCollection spFieldCol = await SPGet.getFieldCollection(spglb.myClient,url);
                if( spFieldCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spFieldCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spFieldCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spFieldCol.items.Count-1;i>=0;i--)
                    {
                        this.add_Field_deferred(curPos,level+1, spFieldCol.items[i]);
                    }
                    if( spFieldCol.Count != spFieldCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spFieldCol.Count - spFieldCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "FieldLink")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.FieldLinkCollection spFieldLinkCol = await SPGet.getFieldLinkCollection(spglb.myClient,url);
                if( spFieldLinkCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spFieldLinkCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spFieldLinkCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spFieldLinkCol.items.Count-1;i>=0;i--)
                    {
                        this.add_FieldLink_deferred(curPos,level+1, spFieldLinkCol.items[i]);
                    }
                    if( spFieldLinkCol.Count != spFieldLinkCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spFieldLinkCol.Count - spFieldLinkCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "File")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.FileCollection spFileCol = await SPGet.getFileCollection(spglb.myClient,url);
                if( spFileCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spFileCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spFileCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spFileCol.items.Count-1;i>=0;i--)
                    {
                        this.add_File_deferred(curPos,level+1, spFileCol.items[i]);
                    }
                    if( spFileCol.Count != spFileCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spFileCol.Count - spFileCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "FileVersion")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.FileVersionCollection spFileVersionCol = await SPGet.getFileVersionCollection(spglb.myClient,url);
                if( spFileVersionCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spFileVersionCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spFileVersionCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spFileVersionCol.items.Count-1;i>=0;i--)
                    {
                        this.add_FileVersion_deferred(curPos,level+1, spFileVersionCol.items[i]);
                    }
                    if( spFileVersionCol.Count != spFileVersionCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spFileVersionCol.Count - spFileVersionCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "Folder")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.FolderCollection spFolderCol = await SPGet.getFolderCollection(spglb.myClient,url);
                if( spFolderCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spFolderCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spFolderCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spFolderCol.items.Count-1;i>=0;i--)
                    {
                        this.add_Folder_deferred(curPos,level+1, spFolderCol.items[i]);
                    }
                    if( spFolderCol.Count != spFolderCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spFolderCol.Count - spFolderCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "Form")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.FormCollection spFormCol = await SPGet.getFormCollection(spglb.myClient,url);
                if( spFormCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spFormCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spFormCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spFormCol.items.Count-1;i>=0;i--)
                    {
                        this.add_Form_deferred(curPos,level+1, spFormCol.items[i]);
                    }
                    if( spFormCol.Count != spFormCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spFormCol.Count - spFormCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "Group")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.GroupCollection spGroupCol = await SPGet.getGroupCollection(spglb.myClient,url);
                if( spGroupCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spGroupCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spGroupCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spGroupCol.items.Count-1;i>=0;i--)
                    {
                        this.add_Group_deferred(curPos,level+1, spGroupCol.items[i]);
                    }
                    if( spGroupCol.Count != spGroupCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spGroupCol.Count - spGroupCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "List")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.ListCollection spListCol = await SPGet.getListCollection(spglb.myClient,url);
                if( spListCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spListCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spListCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spListCol.items.Count-1;i>=0;i--)
                    {
                        this.add_List_deferred(curPos,level+1, spListCol.items[i]);
                    }
                    if( spListCol.Count != spListCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spListCol.Count - spListCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "ListItem")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.ListItemCollection spListItemCol = await SPGet.getListItemCollection(spglb.myClient,url);
                if( spListItemCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spListItemCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spListItemCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spListItemCol.items.Count-1;i>=0;i--)
                    {
                        this.add_ListItem_deferred(curPos,level+1, spListItemCol.items[i]);
                    }
                    if( spListItemCol.Count != spListItemCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spListItemCol.Count - spListItemCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "ListTemplate")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.ListTemplateCollection spListTemplateCol = await SPGet.getListTemplateCollection(spglb.myClient,url);
                if( spListTemplateCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spListTemplateCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spListTemplateCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spListTemplateCol.items.Count-1;i>=0;i--)
                    {
                        this.add_ListTemplate_deferred(curPos,level+1, spListTemplateCol.items[i]);
                    }
                    if( spListTemplateCol.Count != spListTemplateCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spListTemplateCol.Count - spListTemplateCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "NavigationNode")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.NavigationNodeCollection spNavigationNodeCol = await SPGet.getNavigationNodeCollection(spglb.myClient,url);
                if( spNavigationNodeCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spNavigationNodeCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spNavigationNodeCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spNavigationNodeCol.items.Count-1;i>=0;i--)
                    {
                        this.add_NavigationNode_deferred(curPos,level+1, spNavigationNodeCol.items[i]);
                    }
                    if( spNavigationNodeCol.Count != spNavigationNodeCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spNavigationNodeCol.Count - spNavigationNodeCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "PushNotificationSubscriber")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.PushNotificationSubscriberCollection spPushNotificationSubscriberCol = await SPGet.getPushNotificationSubscriberCollection(spglb.myClient,url);
                if( spPushNotificationSubscriberCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spPushNotificationSubscriberCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spPushNotificationSubscriberCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spPushNotificationSubscriberCol.items.Count-1;i>=0;i--)
                    {
                        this.add_PushNotificationSubscriber_deferred(curPos,level+1, spPushNotificationSubscriberCol.items[i]);
                    }
                    if( spPushNotificationSubscriberCol.Count != spPushNotificationSubscriberCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spPushNotificationSubscriberCol.Count - spPushNotificationSubscriberCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "RecycleBinItem")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.RecycleBinItemCollection spRecycleBinItemCol = await SPGet.getRecycleBinItemCollection(spglb.myClient,url);
                if( spRecycleBinItemCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spRecycleBinItemCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spRecycleBinItemCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spRecycleBinItemCol.items.Count-1;i>=0;i--)
                    {
                        this.add_RecycleBinItem_deferred(curPos,level+1, spRecycleBinItemCol.items[i]);
                    }
                    if( spRecycleBinItemCol.Count != spRecycleBinItemCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spRecycleBinItemCol.Count - spRecycleBinItemCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "RelatedField")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.RelatedFieldCollection spRelatedFieldCol = await SPGet.getRelatedFieldCollection(spglb.myClient,url);
                if( spRelatedFieldCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spRelatedFieldCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spRelatedFieldCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spRelatedFieldCol.items.Count-1;i>=0;i--)
                    {
                        this.add_RelatedField_deferred(curPos,level+1, spRelatedFieldCol.items[i]);
                    }
                    if( spRelatedFieldCol.Count != spRelatedFieldCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spRelatedFieldCol.Count - spRelatedFieldCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "RelatedFieldExtendedData")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.RelatedFieldExtendedDataCollection spRelatedFieldExtendedDataCol = await SPGet.getRelatedFieldExtendedDataCollection(spglb.myClient,url);
                if( spRelatedFieldExtendedDataCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spRelatedFieldExtendedDataCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spRelatedFieldExtendedDataCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spRelatedFieldExtendedDataCol.items.Count-1;i>=0;i--)
                    {
                        this.add_RelatedFieldExtendedData_deferred(curPos,level+1, spRelatedFieldExtendedDataCol.items[i]);
                    }
                    if( spRelatedFieldExtendedDataCol.Count != spRelatedFieldExtendedDataCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spRelatedFieldExtendedDataCol.Count - spRelatedFieldExtendedDataCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "RoleAssignment")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.RoleAssignmentCollection spRoleAssignmentCol = await SPGet.getRoleAssignmentCollection(spglb.myClient,url);
                if( spRoleAssignmentCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spRoleAssignmentCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spRoleAssignmentCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spRoleAssignmentCol.items.Count-1;i>=0;i--)
                    {
                        this.add_RoleAssignment_deferred(curPos,level+1, spRoleAssignmentCol.items[i]);
                    }
                    if( spRoleAssignmentCol.Count != spRoleAssignmentCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spRoleAssignmentCol.Count - spRoleAssignmentCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "RoleDefinition")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.RoleDefinitionCollection spRoleDefinitionCol = await SPGet.getRoleDefinitionCollection(spglb.myClient,url);
                if( spRoleDefinitionCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spRoleDefinitionCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spRoleDefinitionCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spRoleDefinitionCol.items.Count-1;i>=0;i--)
                    {
                        this.add_RoleDefinition_deferred(curPos,level+1, spRoleDefinitionCol.items[i]);
                    }
                    if( spRoleDefinitionCol.Count != spRoleDefinitionCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spRoleDefinitionCol.Count - spRoleDefinitionCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "TimeZone")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.TimeZoneCollection spTimeZoneCol = await SPGet.getTimeZoneCollection(spglb.myClient,url);
                if( spTimeZoneCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spTimeZoneCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spTimeZoneCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spTimeZoneCol.items.Count-1;i>=0;i--)
                    {
                        this.add_TimeZone_deferred(curPos,level+1, spTimeZoneCol.items[i]);
                    }
                    if( spTimeZoneCol.Count != spTimeZoneCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spTimeZoneCol.Count - spTimeZoneCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "User")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.UserCollection spUserCol = await SPGet.getUserCollection(spglb.myClient,url);
                if( spUserCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spUserCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spUserCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spUserCol.items.Count-1;i>=0;i--)
                    {
                        this.add_User_deferred(curPos,level+1, spUserCol.items[i]);
                    }
                    if( spUserCol.Count != spUserCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spUserCol.Count - spUserCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "UserCustomAction")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.UserCustomActionCollection spUserCustomActionCol = await SPGet.getUserCustomActionCollection(spglb.myClient,url);
                if( spUserCustomActionCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spUserCustomActionCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spUserCustomActionCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spUserCustomActionCol.items.Count-1;i>=0;i--)
                    {
                        this.add_UserCustomAction_deferred(curPos,level+1, spUserCustomActionCol.items[i]);
                    }
                    if( spUserCustomActionCol.Count != spUserCustomActionCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spUserCustomActionCol.Count - spUserCustomActionCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "View")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.ViewCollection spViewCol = await SPGet.getViewCollection(spglb.myClient,url);
                if( spViewCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spViewCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spViewCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spViewCol.items.Count-1;i>=0;i--)
                    {
                        this.add_View_deferred(curPos,level+1, spViewCol.items[i]);
                    }
                    if( spViewCol.Count != spViewCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spViewCol.Count - spViewCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "Web")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.WebCollection spWebCol = await SPGet.getWebCollection(spglb.myClient,url);
                if( spWebCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spWebCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spWebCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spWebCol.items.Count-1;i>=0;i--)
                    {
                        this.add_Web_deferred(curPos,level+1, spWebCol.items[i]);
                    }
                    if( spWebCol.Count != spWebCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spWebCol.Count - spWebCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else if( t.Name == "WebTemplate")
            {
                this.show_running();
                int curPos = this.add_lineAt(pos,level, false, "Count", "loading ...", hmsspx.pageBase.knownPages.NONE, "");
                HMS.SP.WebTemplateCollection spWebTemplateCol = await SPGet.getWebTemplateCollection(spglb.myClient,url);
                if( spWebTemplateCol.items == null )
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Error", HMS.Util.__HMSError.toString(spWebTemplateCol.__HMSError_), hmsspx.pageBase.knownPages.NONE, "");
                }
                else
                {
                    curPos = this.add_lineReplace(curPos,level, false, "Count", spWebTemplateCol.items.Count.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                    for (int i = spWebTemplateCol.items.Count-1;i>=0;i--)
                    {
                        this.add_WebTemplate_deferred(curPos,level+1, spWebTemplateCol.items[i]);
                    }
                    if( spWebTemplateCol.Count != spWebTemplateCol.items.Count)
                    {
                        this.add_lineAt(curPos, level + 1, "Collection truncated", (spWebTemplateCol.Count - spWebTemplateCol.items.Count).ToString() + " entries missing");
                    }
                }
                this.hide_running();
            }
            else
            {
                add_lineAt(pos, level, false, "add_ObjAt", t.Name, hmsspx.pageBase.knownPages.NONE,  "");
            }
        }
    }
}

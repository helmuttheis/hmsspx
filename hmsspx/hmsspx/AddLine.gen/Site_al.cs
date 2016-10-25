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
        public int add_Site(int level, HMS.SP.Site spSite)
        {
            return add_Site(-1, level, spSite);
        }
        public int  add_Site(int pos, int level, HMS.SP.Site spSite)
        {
            if (spSite.__HMSError_ != null && (spSite.__HMSError_.errno != 0 || spSite.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spSite.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spSite.__deferred_);
            pos = this.add__metadata(pos, level, spSite.__metadata_);
            pos = this.add__rest(pos, level, spSite.__rest);
            pos = this.add_lineAt(pos,level,  "AllowDesigner", HMS.SP.SPUtil.toString(spSite.AllowDesigner_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "AllowMasterPageEditing", HMS.SP.SPUtil.toString(spSite.AllowMasterPageEditing_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "AllowRevertFromTemplate", HMS.SP.SPUtil.toString(spSite.AllowRevertFromTemplate_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "AllowSelfServiceUpgrade", HMS.SP.SPUtil.toString(spSite.AllowSelfServiceUpgrade_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "AllowSelfServiceUpgradeEvaluation", HMS.SP.SPUtil.toString(spSite.AllowSelfServiceUpgradeEvaluation_)); //Object;
            pos = this.add_lineAt(pos,level,  "CanUpgrade", HMS.SP.SPUtil.toString(spSite.CanUpgrade_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "CompatibilityLevel", HMS.SP.SPUtil.toString(spSite.CompatibilityLevel_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "EventReceivers", HMS.SP.SPUtil.toString(spSite.EventReceivers_)); //EventReceiverDefinitionCollection object.;
            pos = this.add_deferredAt(pos,level, "Features", "...", myType.GetType("SP.Feature"), spSite.Features_.__deferred_); //Feature;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spSite.Id_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "LockIssue", HMS.SP.SPUtil.toString(spSite.LockIssue_)); //String;
            pos = this.add_lineAt(pos,level,  "MaxItemsPerThrottledOperation", HMS.SP.SPUtil.toString(spSite.MaxItemsPerThrottledOperation_)); //Long;
            pos = this.add_deferredAt(pos,level, "Owner", "...", knownPages.pageUser , spSite.Owner_.__deferred_); //User;
            pos = this.add_lineAt(pos,level,  "PrimaryUri", HMS.SP.SPUtil.toString(spSite.PrimaryUri_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "ReadOnly", HMS.SP.SPUtil.toString(spSite.ReadOnly_)); //Boolean;
            pos = this.add_deferredAt(pos,level, "RecycleBin", "...", myType.GetType("SP.RecycleBinItem"), spSite.RecycleBin_.__deferred_); //RecycleBinItem;
            pos = this.add_deferredAt(pos,level, "RootWeb", "...", knownPages.pageWeb , spSite.RootWeb_.__deferred_); //Web;
            pos = this.add_lineAt(pos,level,  "ServerRelativeUrl", HMS.SP.SPUtil.toString(spSite.ServerRelativeUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "ShareByLinkEnabled", HMS.SP.SPUtil.toString(spSite.ShareByLinkEnabled_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "ShowUrlStructure", HMS.SP.SPUtil.toString(spSite.ShowUrlStructure_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "UiVersionConfigurationEnabled", HMS.SP.SPUtil.toString(spSite.UiVersionConfigurationEnabled_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "UpgradeInfo", HMS.SP.SPUtil.toString(spSite.UpgradeInfo_)); //Object;
            pos = this.add_lineAt(pos,level,  "UpgradeReminderDate", HMS.SP.SPUtil.toString(spSite.UpgradeReminderDate_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "Upgrading", HMS.SP.SPUtil.toString(spSite.Upgrading_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Url", HMS.SP.SPUtil.toString(spSite.Url_)); //String;
            pos = this.add_deferredAt(pos,level, "Usage", "...", knownPages.pageUsageInfo , spSite.Usage_.__deferred_); //UsageInfo;
            pos = this.add_deferredAt(pos,level, "UserCustomActions", "...", myType.GetType("SP.UserCustomAction"), spSite.UserCustomActions_.__deferred_); //UserCustomAction;
            return pos;
        }
        public int add_Site_deferred(int pos, int level, HMS.SP.Site spSite)
        {
            {
                string useUrl = spSite.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "Site","", knownPages.pageSite, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "Site", "",knownPages.NONE, "");
                    pos = this.add_Site(pos, level+1, spSite);
                }
            }
        return pos;
        }
    }
}

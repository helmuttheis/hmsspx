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
        public int add_InformationRightsManagementSettings(int level, HMS.SP.InformationRightsManagementSettings spInformationRightsManagementSettings)
        {
            return add_InformationRightsManagementSettings(-1, level, spInformationRightsManagementSettings);
        }
        public int  add_InformationRightsManagementSettings(int pos, int level, HMS.SP.InformationRightsManagementSettings spInformationRightsManagementSettings)
        {
            if (spInformationRightsManagementSettings.__HMSError_ != null && (spInformationRightsManagementSettings.__HMSError_.errno != 0 || spInformationRightsManagementSettings.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spInformationRightsManagementSettings.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spInformationRightsManagementSettings.__deferred_);
            pos = this.add__metadata(pos, level, spInformationRightsManagementSettings.__metadata_);
            pos = this.add__rest(pos, level, spInformationRightsManagementSettings.__rest);
            pos = this.add_lineAt(pos,level,  "AllowPrint", HMS.SP.SPUtil.toString(spInformationRightsManagementSettings.AllowPrint_)); //Object;
            pos = this.add_lineAt(pos,level,  "AllowScript", HMS.SP.SPUtil.toString(spInformationRightsManagementSettings.AllowScript_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "AllowWriteCopy", HMS.SP.SPUtil.toString(spInformationRightsManagementSettings.AllowWriteCopy_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "DisableDocumentBrowserView", HMS.SP.SPUtil.toString(spInformationRightsManagementSettings.DisableDocumentBrowserView_)); //Object;
            pos = this.add_lineAt(pos,level,  "DocumentAccessExpireDays", HMS.SP.SPUtil.toString(spInformationRightsManagementSettings.DocumentAccessExpireDays_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "DocumentLibraryProtectionExpireDate", HMS.SP.SPUtil.toString(spInformationRightsManagementSettings.DocumentLibraryProtectionExpireDate_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "EnableDocumentAccessExpire", HMS.SP.SPUtil.toString(spInformationRightsManagementSettings.EnableDocumentAccessExpire_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "EnableDocumentBrowserPublishingView", HMS.SP.SPUtil.toString(spInformationRightsManagementSettings.EnableDocumentBrowserPublishingView_)); //Object;
            pos = this.add_lineAt(pos,level,  "EnableGroupProtection", HMS.SP.SPUtil.toString(spInformationRightsManagementSettings.EnableGroupProtection_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "EnableLicenseCacheExpire", HMS.SP.SPUtil.toString(spInformationRightsManagementSettings.EnableLicenseCacheExpire_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "GroupName", HMS.SP.SPUtil.toString(spInformationRightsManagementSettings.GroupName_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "LicenseCacheExpireDays", HMS.SP.SPUtil.toString(spInformationRightsManagementSettings.LicenseCacheExpireDays_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "PolicyDescription", HMS.SP.SPUtil.toString(spInformationRightsManagementSettings.PolicyDescription_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "PolicyTitle", HMS.SP.SPUtil.toString(spInformationRightsManagementSettings.PolicyTitle_)); //Undefined;
            return pos;
        }
        public int add_InformationRightsManagementSettings_deferred(int pos, int level, HMS.SP.InformationRightsManagementSettings spInformationRightsManagementSettings)
        {
            {
                string useUrl = spInformationRightsManagementSettings.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "InformationRightsManagementSettings","", knownPages.pageInformationRightsManagementSettings, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "InformationRightsManagementSettings", "",knownPages.NONE, "");
                    pos = this.add_InformationRightsManagementSettings(pos, level+1, spInformationRightsManagementSettings);
                }
            }
        return pos;
        }
    }
}

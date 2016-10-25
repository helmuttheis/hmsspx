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
        public int add_ObjectSharingInformation(int level, HMS.SP.ObjectSharingInformation spObjectSharingInformation)
        {
            return add_ObjectSharingInformation(-1, level, spObjectSharingInformation);
        }
        public int  add_ObjectSharingInformation(int pos, int level, HMS.SP.ObjectSharingInformation spObjectSharingInformation)
        {
            if (spObjectSharingInformation.__HMSError_ != null && (spObjectSharingInformation.__HMSError_.errno != 0 || spObjectSharingInformation.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spObjectSharingInformation.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spObjectSharingInformation.__deferred_);
            pos = this.add__metadata(pos, level, spObjectSharingInformation.__metadata_);
            pos = this.add__rest(pos, level, spObjectSharingInformation.__rest);
            pos = this.add_lineAt(pos,level,  "AnonymousEditLink", HMS.SP.SPUtil.toString(spObjectSharingInformation.AnonymousEditLink_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "AnonymousViewLink", HMS.SP.SPUtil.toString(spObjectSharingInformation.AnonymousViewLink_)); //Object;
            pos = this.add_lineAt(pos,level,  "CanManagePermissions", HMS.SP.SPUtil.toString(spObjectSharingInformation.CanManagePermissions_)); //Object;
            pos = this.add_lineAt(pos,level,  "HasPendingAccessRequests", HMS.SP.SPUtil.toString(spObjectSharingInformation.HasPendingAccessRequests_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "HasPermissionLevels", HMS.SP.SPUtil.toString(spObjectSharingInformation.HasPermissionLevels_)); //Object;
            pos = this.add_lineAt(pos,level,  "IsSharedWithCurrentUser", HMS.SP.SPUtil.toString(spObjectSharingInformation.IsSharedWithCurrentUser_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "IsSharedWithGuest", HMS.SP.SPUtil.toString(spObjectSharingInformation.IsSharedWithGuest_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "IsSharedWithMany", HMS.SP.SPUtil.toString(spObjectSharingInformation.IsSharedWithMany_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "IsSharedWithSecurityGroup", HMS.SP.SPUtil.toString(spObjectSharingInformation.IsSharedWithSecurityGroup_)); //Object;
            pos = this.add_lineAt(pos,level,  "PendingAccessRequestsLink", HMS.SP.SPUtil.toString(spObjectSharingInformation.PendingAccessRequestsLink_)); //Undefined;
            return pos;
        }
        public int add_ObjectSharingInformation_deferred(int pos, int level, HMS.SP.ObjectSharingInformation spObjectSharingInformation)
        {
            {
                string useUrl = spObjectSharingInformation.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "ObjectSharingInformation","", knownPages.pageObjectSharingInformation, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "ObjectSharingInformation", "",knownPages.NONE, "");
                    pos = this.add_ObjectSharingInformation(pos, level+1, spObjectSharingInformation);
                }
            }
        return pos;
        }
    }
}

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
        public int add_ObjectSharingInformationUser(int level, HMS.SP.ObjectSharingInformationUser spObjectSharingInformationUser)
        {
            return add_ObjectSharingInformationUser(-1, level, spObjectSharingInformationUser);
        }
        public int  add_ObjectSharingInformationUser(int pos, int level, HMS.SP.ObjectSharingInformationUser spObjectSharingInformationUser)
        {
            if (spObjectSharingInformationUser.__HMSError_ != null && (spObjectSharingInformationUser.__HMSError_.errno != 0 || spObjectSharingInformationUser.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spObjectSharingInformationUser.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spObjectSharingInformationUser.__deferred_);
            pos = this.add__metadata(pos, level, spObjectSharingInformationUser.__metadata_);
            pos = this.add__rest(pos, level, spObjectSharingInformationUser.__rest);
            pos = this.add_lineAt(pos,level,  "CustomRoleNames", HMS.SP.SPUtil.toString(spObjectSharingInformationUser.CustomRoleNames_)); //Object;
            pos = this.add_lineAt(pos,level,  "Department", HMS.SP.SPUtil.toString(spObjectSharingInformationUser.Department_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "Email", HMS.SP.SPUtil.toString(spObjectSharingInformationUser.Email_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "HasEditPermission", HMS.SP.SPUtil.toString(spObjectSharingInformationUser.HasEditPermission_)); //Object;
            pos = this.add_lineAt(pos,level,  "HasViewPermission", HMS.SP.SPUtil.toString(spObjectSharingInformationUser.HasViewPermission_)); //Object;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spObjectSharingInformationUser.Id_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "IsSiteAdmin", HMS.SP.SPUtil.toString(spObjectSharingInformationUser.IsSiteAdmin_)); //Object;
            pos = this.add_lineAt(pos,level,  "JobTitle", HMS.SP.SPUtil.toString(spObjectSharingInformationUser.JobTitle_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "LoginName", HMS.SP.SPUtil.toString(spObjectSharingInformationUser.LoginName_)); //String;
            pos = this.add_lineAt(pos,level,  "Name", HMS.SP.SPUtil.toString(spObjectSharingInformationUser.Name_)); //String;
            pos = this.add_lineAt(pos,level,  "Picture", HMS.SP.SPUtil.toString(spObjectSharingInformationUser.Picture_)); //Undefined;
            pos = this.add_deferredAt(pos,level, "Principal", "...", knownPages.pagePrincipal , spObjectSharingInformationUser.Principal_.__deferred_); //Principal;
            pos = this.add_lineAt(pos,level,  "SipAddress", HMS.SP.SPUtil.toString(spObjectSharingInformationUser.SipAddress_)); //Undefined;
            pos = this.add_deferredAt(pos,level, "User", "...", knownPages.pageUser , spObjectSharingInformationUser.User_.__deferred_); //User;
            return pos;
        }
        public int add_ObjectSharingInformationUser_deferred(int pos, int level, HMS.SP.ObjectSharingInformationUser spObjectSharingInformationUser)
        {
            {
                string useUrl = spObjectSharingInformationUser.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "ObjectSharingInformationUser","", knownPages.pageObjectSharingInformationUser, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "ObjectSharingInformationUser", "",knownPages.NONE, "");
                    pos = this.add_ObjectSharingInformationUser(pos, level+1, spObjectSharingInformationUser);
                }
            }
        return pos;
        }
    }
}

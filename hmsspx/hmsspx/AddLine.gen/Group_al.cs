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
        public int add_Group(int level, HMS.SP.Group spGroup)
        {
            return add_Group(-1, level, spGroup);
        }
        public int  add_Group(int pos, int level, HMS.SP.Group spGroup)
        {
            if (spGroup.__HMSError_ != null && (spGroup.__HMSError_.errno != 0 || spGroup.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spGroup.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spGroup.__deferred_);
            pos = this.add__metadata(pos, level, spGroup.__metadata_);
            pos = this.add__rest(pos, level, spGroup.__rest);
            pos = this.add_lineAt(pos,level,  "AllowMembersEditMembership", HMS.SP.SPUtil.toString(spGroup.AllowMembersEditMembership_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "AllowRequestToJoinLeave", HMS.SP.SPUtil.toString(spGroup.AllowRequestToJoinLeave_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "AutoAcceptRequestToJoinLeave", HMS.SP.SPUtil.toString(spGroup.AutoAcceptRequestToJoinLeave_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "CanCurrentUserEditMembership", HMS.SP.SPUtil.toString(spGroup.CanCurrentUserEditMembership_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "CanCurrentUserManageGroup", HMS.SP.SPUtil.toString(spGroup.CanCurrentUserManageGroup_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "CanCurrentUserViewMembership", HMS.SP.SPUtil.toString(spGroup.CanCurrentUserViewMembership_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Description", HMS.SP.SPUtil.toString(spGroup.Description_)); //String;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spGroup.Id_)); //Int32;
            pos = this.add_lineAt(pos,level,  "IsHiddenInUI", HMS.SP.SPUtil.toString(spGroup.IsHiddenInUI_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "LoginName", HMS.SP.SPUtil.toString(spGroup.LoginName_)); //String;
            pos = this.add_lineAt(pos,level,  "OnlyAllowMembersViewMembership", HMS.SP.SPUtil.toString(spGroup.OnlyAllowMembersViewMembership_)); //Boolean;
            pos = this.add_deferredAt(pos,level, "Owner", "...", knownPages.pagePrincipal , spGroup.Owner_.__deferred_); //Principal;
            pos = this.add_lineAt(pos,level,  "OwnerTitle", HMS.SP.SPUtil.toString(spGroup.OwnerTitle_)); //String;
            pos = this.add_lineAt(pos,level,  "RequestToJoinLeaveEmailSetting", HMS.SP.SPUtil.toString(spGroup.RequestToJoinLeaveEmailSetting_)); //String;
            pos = this.add_lineAt(pos,level,  "PrincipalType", HMS.SP.SPUtil.toString(spGroup.PrincipalType_)); //Int32;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spGroup.Title_)); //String;
            pos = this.add_deferredAt(pos,level, "Users", "...", myType.GetType("SP.User"), spGroup.Users_.__deferred_); //User;
            return pos;
        }
        public int add_Group_deferred(int pos, int level, HMS.SP.Group spGroup)
        {
            if (spGroup.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "Group", HMS.SP.SPUtil.toString(spGroup.Title_), knownPages.NONE,""); //String;
                pos = add_Group(pos, level + 1, spGroup);
            }
            else
            {
                string useUrl = spGroup.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spGroup.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spGroup.Title_, "", knownPages.pageGroup, useUrl);
            }
        return pos;
        }
    }
}

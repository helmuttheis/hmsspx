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
        public int add_ChangeQuery(int level, HMS.SP.ChangeQuery spChangeQuery)
        {
            return add_ChangeQuery(-1, level, spChangeQuery);
        }
        public int  add_ChangeQuery(int pos, int level, HMS.SP.ChangeQuery spChangeQuery)
        {
            if (spChangeQuery.__HMSError_ != null && (spChangeQuery.__HMSError_.errno != 0 || spChangeQuery.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spChangeQuery.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spChangeQuery.__deferred_);
            pos = this.add__metadata(pos, level, spChangeQuery.__metadata_);
            pos = this.add__rest(pos, level, spChangeQuery.__rest);
            pos = this.add_lineAt(pos,level,  "Add", HMS.SP.SPUtil.toString(spChangeQuery.Add_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Alert", HMS.SP.SPUtil.toString(spChangeQuery.Alert_)); //Boolean;
            pos = this.add_deferredAt(pos,level, "ChangeTokenEnd", "...", knownPages.pageChangeToken , spChangeQuery.ChangeTokenEnd_.__deferred_); //ChangeToken;
            pos = this.add_deferredAt(pos,level, "ChangeTokenStart", "...", knownPages.pageChangeToken , spChangeQuery.ChangeTokenStart_.__deferred_); //ChangeToken;
            pos = this.add_lineAt(pos,level,  "ContentType", HMS.SP.SPUtil.toString(spChangeQuery.ContentType_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "DeleteObject", HMS.SP.SPUtil.toString(spChangeQuery.DeleteObject_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Field", HMS.SP.SPUtil.toString(spChangeQuery.Field_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "File", HMS.SP.SPUtil.toString(spChangeQuery.File_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Folder", HMS.SP.SPUtil.toString(spChangeQuery.Folder_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Group", HMS.SP.SPUtil.toString(spChangeQuery.Group_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "GroupMembershipAdd", HMS.SP.SPUtil.toString(spChangeQuery.GroupMembershipAdd_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "GroupMembershipDelete", HMS.SP.SPUtil.toString(spChangeQuery.GroupMembershipDelete_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Item", HMS.SP.SPUtil.toString(spChangeQuery.Item_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "List", HMS.SP.SPUtil.toString(spChangeQuery.List_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Move", HMS.SP.SPUtil.toString(spChangeQuery.Move_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Navigation", HMS.SP.SPUtil.toString(spChangeQuery.Navigation_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Rename", HMS.SP.SPUtil.toString(spChangeQuery.Rename_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Restore", HMS.SP.SPUtil.toString(spChangeQuery.Restore_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "RoleAssignmentAdd", HMS.SP.SPUtil.toString(spChangeQuery.RoleAssignmentAdd_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "RoleAssignmentDelete", HMS.SP.SPUtil.toString(spChangeQuery.RoleAssignmentDelete_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "RoleDefinitionAdd", HMS.SP.SPUtil.toString(spChangeQuery.RoleDefinitionAdd_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "RoleDefinitionDelete", HMS.SP.SPUtil.toString(spChangeQuery.RoleDefinitionDelete_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "RoleDefinitionUpdate", HMS.SP.SPUtil.toString(spChangeQuery.RoleDefinitionUpdate_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "SecurityPolicy", HMS.SP.SPUtil.toString(spChangeQuery.SecurityPolicy_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Site", HMS.SP.SPUtil.toString(spChangeQuery.Site_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "SystemUpdate", HMS.SP.SPUtil.toString(spChangeQuery.SystemUpdate_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Update", HMS.SP.SPUtil.toString(spChangeQuery.Update_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "User", HMS.SP.SPUtil.toString(spChangeQuery.User_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "View", HMS.SP.SPUtil.toString(spChangeQuery.View_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Web", HMS.SP.SPUtil.toString(spChangeQuery.Web_)); //Boolean;
            return pos;
        }
        public int add_ChangeQuery_deferred(int pos, int level, HMS.SP.ChangeQuery spChangeQuery)
        {
            {
                string useUrl = spChangeQuery.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "ChangeQuery","", knownPages.pageChangeQuery, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "ChangeQuery", "",knownPages.NONE, "");
                    pos = this.add_ChangeQuery(pos, level+1, spChangeQuery);
                }
            }
        return pos;
        }
    }
}

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
        public int add_ListItem(int level, HMS.SP.ListItem spListItem)
        {
            return add_ListItem(-1, level, spListItem);
        }
        public int  add_ListItem(int pos, int level, HMS.SP.ListItem spListItem)
        {
            if (spListItem.__HMSError_ != null && (spListItem.__HMSError_.errno != 0 || spListItem.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spListItem.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spListItem.__deferred_);
            pos = this.add__metadata(pos, level, spListItem.__metadata_);
            pos = this.add__rest(pos, level, spListItem.__rest);
            pos = this.add_deferredAt(pos,level, "AttachmentFiles", "...", myType.GetType("SP.Attachment"), spListItem.AttachmentFiles_.__deferred_); //Attachment;
            pos = this.add_deferredAt(pos,level, "ContentType", "...", knownPages.pageContentType , spListItem.ContentType_.__deferred_); //ContentType;
            pos = this.add_lineAt(pos,level,  "DisplayName", HMS.SP.SPUtil.toString(spListItem.DisplayName_)); //String;
            pos = this.add_deferredAt(pos,level, "EffectiveBasePermissions", "...", knownPages.pageBasePermissions , spListItem.EffectiveBasePermissions_.__deferred_); //BasePermissions;
            pos = this.add_deferredAt(pos,level, "EffectiveBasePermissionsForUI", "...", knownPages.pageBasePermissions , spListItem.EffectiveBasePermissionsForUI_.__deferred_); //BasePermissions;
            pos = this.add_deferredAt(pos,level, "FieldValuesAsHtml", "...", knownPages.pageFieldStringValues , spListItem.FieldValuesAsHtml_.__deferred_); //FieldStringValues;
            pos = this.add_deferredAt(pos,level, "FieldValuesAsText", "...", knownPages.pageFieldStringValues , spListItem.FieldValuesAsText_.__deferred_); //FieldStringValues;
            pos = this.add_deferredAt(pos,level, "FieldValuesForEdit", "...", knownPages.pageFieldStringValues , spListItem.FieldValuesForEdit_.__deferred_); //FieldStringValues;
            pos = this.add_deferredAt(pos,level, "File", "...", knownPages.pageFile , spListItem.File_.__deferred_); //File;
            pos = this.add_lineAt(pos,level,  "FileSystemObjectType", HMS.SP.SPUtil.toString(spListItem.FileSystemObjectType_)); //Int32;
            pos = this.add_deferredAt(pos,level, "FirstUniqueAncestorSecurableObject", "...", knownPages.pageSecurableObject , spListItem.FirstUniqueAncestorSecurableObject_.__deferred_); //SecurableObject;
            pos = this.add_deferredAt(pos,level, "Folder", "...", knownPages.pageFolder , spListItem.Folder_.__deferred_); //Folder;
            pos = this.add_lineAt(pos,level,  "HasUniqueRoleAssignments", HMS.SP.SPUtil.toString(spListItem.HasUniqueRoleAssignments_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spListItem.Id_)); //Int32;
            pos = this.add_deferredAt(pos,level, "ParentList", "...", knownPages.pageList , spListItem.ParentList_.__deferred_); //List;
            pos = this.add_deferredAt(pos,level, "RoleAssignments", "...", myType.GetType("SP.RoleAssignment"), spListItem.RoleAssignments_.__deferred_); //RoleAssignment;
            return pos;
        }
        public int add_ListItem_deferred(int pos, int level, HMS.SP.ListItem spListItem)
        {
            {
                string useUrl = spListItem.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "ListItem","", knownPages.pageListItem, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "ListItem", "",knownPages.NONE, "");
                    pos = this.add_ListItem(pos, level+1, spListItem);
                }
            }
        return pos;
        }
    }
}

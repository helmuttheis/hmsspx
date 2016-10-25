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
        public int add_File(int level, HMS.SP.File spFile)
        {
            return add_File(-1, level, spFile);
        }
        public int  add_File(int pos, int level, HMS.SP.File spFile)
        {
            if (spFile.__HMSError_ != null && (spFile.__HMSError_.errno != 0 || spFile.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spFile.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spFile.__deferred_);
            pos = this.add__metadata(pos, level, spFile.__metadata_);
            pos = this.add__rest(pos, level, spFile.__rest);
            pos = this.add_deferredAt(pos,level, "Author", "...", knownPages.pageUser , spFile.Author_.__deferred_); //User;
            pos = this.add_deferredAt(pos,level, "CheckedOutByUser", "...", knownPages.pageUser , spFile.CheckedOutByUser_.__deferred_); //User;
            pos = this.add_lineAt(pos,level,  "CheckInComment", HMS.SP.SPUtil.toString(spFile.CheckInComment_)); //String;
            pos = this.add_lineAt(pos,level,  "CheckOutType", HMS.SP.SPUtil.toString(spFile.CheckOutType_)); //Int32;
            pos = this.add_lineAt(pos,level,  "ContentTag", HMS.SP.SPUtil.toString(spFile.ContentTag_)); //String;
            pos = this.add_lineAt(pos,level,  "CustomizedPageStatus", HMS.SP.SPUtil.toString(spFile.CustomizedPageStatus_)); //Int32;
            pos = this.add_lineAt(pos,level,  "ETag", HMS.SP.SPUtil.toString(spFile.ETag_)); //String;
            pos = this.add_lineAt(pos,level,  "Exists", HMS.SP.SPUtil.toString(spFile.Exists_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Length", HMS.SP.SPUtil.toString(spFile.Length_)); //Int64;
            pos = this.add_lineAt(pos,level,  "Level", HMS.SP.SPUtil.toString(spFile.Level_)); //Byte;
            pos = this.add_deferredAt(pos,level, "ListItemAllFields", "...", knownPages.pageListItem , spFile.ListItemAllFields_.__deferred_); //ListItem;
            pos = this.add_deferredAt(pos,level, "LockedByUser", "...", knownPages.pageUser , spFile.LockedByUser_.__deferred_); //User;
            pos = this.add_lineAt(pos,level,  "MajorVersion", HMS.SP.SPUtil.toString(spFile.MajorVersion_)); //Int32;
            pos = this.add_lineAt(pos,level,  "MinorVersion", HMS.SP.SPUtil.toString(spFile.MinorVersion_)); //Int32;
            pos = this.add_deferredAt(pos,level, "ModifiedBy", "...", knownPages.pageUser , spFile.ModifiedBy_.__deferred_); //User;
            pos = this.add_lineAt(pos,level,  "Name", HMS.SP.SPUtil.toString(spFile.Name_)); //String;
            pos = this.add_lineAt(pos,level,  "ServerRelativeUrl", HMS.SP.SPUtil.toString(spFile.ServerRelativeUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "TimeCreated", HMS.SP.SPUtil.toString(spFile.TimeCreated_)); //DateTime;
            pos = this.add_lineAt(pos,level,  "TimeLastModified", HMS.SP.SPUtil.toString(spFile.TimeLastModified_)); //DateTime;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spFile.Title_)); //String;
            pos = this.add_lineAt(pos,level,  "UiVersion", HMS.SP.SPUtil.toString(spFile.UiVersion_)); //Int32;
            pos = this.add_lineAt(pos,level,  "UiVersionLabel", HMS.SP.SPUtil.toString(spFile.UiVersionLabel_)); //String;
            pos = this.add_deferredAt(pos,level, "Versions", "...", myType.GetType("SP.FileVersion"), spFile.Versions_.__deferred_); //FileVersion;
            return pos;
        }
        public int add_File_deferred(int pos, int level, HMS.SP.File spFile)
        {
            if (spFile.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "File", HMS.SP.SPUtil.toString(spFile.Title_), knownPages.NONE,""); //String;
                pos = add_File(pos, level + 1, spFile);
            }
            else
            {
                string useUrl = spFile.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spFile.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spFile.Title_, "", knownPages.pageFile, useUrl);
            }
        return pos;
        }
    }
}

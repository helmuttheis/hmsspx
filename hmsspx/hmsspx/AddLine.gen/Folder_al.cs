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
        public int add_Folder(int level, HMS.SP.Folder spFolder)
        {
            return add_Folder(-1, level, spFolder);
        }
        public int  add_Folder(int pos, int level, HMS.SP.Folder spFolder)
        {
            if (spFolder.__HMSError_ != null && (spFolder.__HMSError_.errno != 0 || spFolder.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spFolder.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spFolder.__deferred_);
            pos = this.add__metadata(pos, level, spFolder.__metadata_);
            pos = this.add__rest(pos, level, spFolder.__rest);
            pos = this.add_linesAt(pos,level, "ContentTypeOrder", spFolder.ContentTypeOrder_, Type.GetType("SP.ContentTypeId")); //ContentTypeId;
            pos = this.add_deferredAt(pos,level, "Files", "...", myType.GetType("SP.File"), spFolder.Files_.__deferred_); //File;
            pos = this.add_deferredAt(pos,level, "Folders", "...", myType.GetType("SP.Folder"), spFolder.Folders_.__deferred_); //Folder;
            pos = this.add_lineAt(pos,level,  "ItemCount", HMS.SP.SPUtil.toString(spFolder.ItemCount_)); //Int32;
            pos = this.add_deferredAt(pos,level, "ListItemAllFields", "...", knownPages.pageListItem , spFolder.ListItemAllFields_.__deferred_); //ListItem;
            pos = this.add_lineAt(pos,level,  "Name", HMS.SP.SPUtil.toString(spFolder.Name_)); //String;
            pos = this.add_deferredAt(pos,level, "ParentFolder", "...", knownPages.pageFolder , spFolder.ParentFolder_.__deferred_); //Folder;
            pos = this.add_deferredAt(pos,level, "Properties", "...", knownPages.pagePropertyValues , spFolder.Properties_.__deferred_); //PropertyValues;
            pos = this.add_lineAt(pos,level,  "ServerRelativeUrl", HMS.SP.SPUtil.toString(spFolder.ServerRelativeUrl_)); //String;
            pos = this.add_linesAt(pos,level, "UniqueContentTypeOrder", spFolder.UniqueContentTypeOrder_, Type.GetType("SP.ContentTypeId")); //ContentTypeId;
            pos = this.add_lineAt(pos,level,  "WelcomePage", HMS.SP.SPUtil.toString(spFolder.WelcomePage_)); //String;
            return pos;
        }
        public int add_Folder_deferred(int pos, int level, HMS.SP.Folder spFolder)
        {
            {
                string useUrl = spFolder.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "Folder","", knownPages.pageFolder, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "Folder", "",knownPages.NONE, "");
                    pos = this.add_Folder(pos, level+1, spFolder);
                }
            }
        return pos;
        }
    }
}

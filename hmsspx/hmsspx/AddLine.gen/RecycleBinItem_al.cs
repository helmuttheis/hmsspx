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
        public int add_RecycleBinItem(int level, HMS.SP.RecycleBinItem spRecycleBinItem)
        {
            return add_RecycleBinItem(-1, level, spRecycleBinItem);
        }
        public int  add_RecycleBinItem(int pos, int level, HMS.SP.RecycleBinItem spRecycleBinItem)
        {
            if (spRecycleBinItem.__HMSError_ != null && (spRecycleBinItem.__HMSError_.errno != 0 || spRecycleBinItem.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spRecycleBinItem.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spRecycleBinItem.__deferred_);
            pos = this.add__metadata(pos, level, spRecycleBinItem.__metadata_);
            pos = this.add__rest(pos, level, spRecycleBinItem.__rest);
            pos = this.add_deferredAt(pos,level, "Author", "...", knownPages.pageUser , spRecycleBinItem.Author_.__deferred_); //User;
            pos = this.add_deferredAt(pos,level, "DeletedBy", "...", knownPages.pageUser , spRecycleBinItem.DeletedBy_.__deferred_); //User;
            pos = this.add_lineAt(pos,level,  "DeletedDate", HMS.SP.SPUtil.toString(spRecycleBinItem.DeletedDate_)); //DateTime;
            pos = this.add_lineAt(pos,level,  "DirName", HMS.SP.SPUtil.toString(spRecycleBinItem.DirName_)); //String;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spRecycleBinItem.Id_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "ItemState", HMS.SP.SPUtil.toString(spRecycleBinItem.ItemState_)); //RecycleBinItemState;
            pos = this.add_lineAt(pos,level,  "ItemType", HMS.SP.SPUtil.toString(spRecycleBinItem.ItemType_)); //RecycleBinItemType;
            pos = this.add_lineAt(pos,level,  "LeafName", HMS.SP.SPUtil.toString(spRecycleBinItem.LeafName_)); //String;
            pos = this.add_lineAt(pos,level,  "Size", HMS.SP.SPUtil.toString(spRecycleBinItem.Size_)); //Number;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spRecycleBinItem.Title_)); //String;
            return pos;
        }
        public int add_RecycleBinItem_deferred(int pos, int level, HMS.SP.RecycleBinItem spRecycleBinItem)
        {
            {
                string useUrl = spRecycleBinItem.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "RecycleBinItem","", knownPages.pageRecycleBinItem, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "RecycleBinItem", "",knownPages.NONE, "");
                    pos = this.add_RecycleBinItem(pos, level+1, spRecycleBinItem);
                }
            }
        return pos;
        }
    }
}

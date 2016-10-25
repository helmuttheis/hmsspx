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
        public int add_ListItemEntityCollection(int level, HMS.SP.ListItemEntityCollection spListItemEntityCollection)
        {
            return add_ListItemEntityCollection(-1, level, spListItemEntityCollection);
        }
        public int  add_ListItemEntityCollection(int pos, int level, HMS.SP.ListItemEntityCollection spListItemEntityCollection)
        {
            if (spListItemEntityCollection.__HMSError_ != null && (spListItemEntityCollection.__HMSError_.errno != 0 || spListItemEntityCollection.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spListItemEntityCollection.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spListItemEntityCollection.__deferred_);
            pos = this.add__metadata(pos, level, spListItemEntityCollection.__metadata_);
            pos = this.add__rest(pos, level, spListItemEntityCollection.__rest);
            pos = this.add_lineAt(pos,level,  "ChildItemType", HMS.SP.SPUtil.toString(spListItemEntityCollection.ChildItemType_)); //Function;
            pos = this.add_lineAt(pos,level,  "Item", HMS.SP.SPUtil.toString(spListItemEntityCollection.Item_)); //String;
            return pos;
        }
        public int add_ListItemEntityCollection_deferred(int pos, int level, HMS.SP.ListItemEntityCollection spListItemEntityCollection)
        {
            {
                string useUrl = spListItemEntityCollection.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "ListItemEntityCollection","", knownPages.pageListItemEntity, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "ListItemEntityCollection", "",knownPages.NONE, "");
                    pos = this.add_ListItemEntityCollection(pos, level+1, spListItemEntityCollection);
                }
            }
        return pos;
        }
    }
}

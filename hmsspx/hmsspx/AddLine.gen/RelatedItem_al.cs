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
        public int add_RelatedItem(int level, HMS.SP.RelatedItem spRelatedItem)
        {
            return add_RelatedItem(-1, level, spRelatedItem);
        }
        public int  add_RelatedItem(int pos, int level, HMS.SP.RelatedItem spRelatedItem)
        {
            if (spRelatedItem.__HMSError_ != null && (spRelatedItem.__HMSError_.errno != 0 || spRelatedItem.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spRelatedItem.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spRelatedItem.__deferred_);
            pos = this.add__metadata(pos, level, spRelatedItem.__metadata_);
            pos = this.add__rest(pos, level, spRelatedItem.__rest);
            pos = this.add_lineAt(pos,level,  "IconUrl", HMS.SP.SPUtil.toString(spRelatedItem.IconUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "ItemId", HMS.SP.SPUtil.toString(spRelatedItem.ItemId_)); //Int32;
            pos = this.add_lineAt(pos,level,  "ListId", HMS.SP.SPUtil.toString(spRelatedItem.ListId_)); //String;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spRelatedItem.Title_)); //String;
            pos = this.add_lineAt(pos,level,  "Url", HMS.SP.SPUtil.toString(spRelatedItem.Url_)); //String;
            pos = this.add_lineAt(pos,level,  "WebId", HMS.SP.SPUtil.toString(spRelatedItem.WebId_)); //String;
            return pos;
        }
        public int add_RelatedItem_deferred(int pos, int level, HMS.SP.RelatedItem spRelatedItem)
        {
            if (spRelatedItem.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "RelatedItem", HMS.SP.SPUtil.toString(spRelatedItem.Title_), knownPages.NONE,""); //String;
                pos = add_RelatedItem(pos, level + 1, spRelatedItem);
            }
            else
            {
                string useUrl = spRelatedItem.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spRelatedItem.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spRelatedItem.Title_, "", knownPages.pageRelatedItem, useUrl);
            }
        return pos;
        }
    }
}

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
        public int add_ListTemplateCollection(int level, HMS.SP.ListTemplateCollection spListTemplateCollection)
        {
            return add_ListTemplateCollection(-1, level, spListTemplateCollection);
        }
        public int  add_ListTemplateCollection(int pos, int level, HMS.SP.ListTemplateCollection spListTemplateCollection)
        {
            if (spListTemplateCollection.__HMSError_ != null && (spListTemplateCollection.__HMSError_.errno != 0 || spListTemplateCollection.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spListTemplateCollection.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spListTemplateCollection.__deferred_);
            pos = this.add__metadata(pos, level, spListTemplateCollection.__metadata_);
            pos = this.add__rest(pos, level, spListTemplateCollection.__rest);
            pos = this.add_lineAt(pos,level,  "ChildItemType", HMS.SP.SPUtil.toString(spListTemplateCollection.ChildItemType_)); //Function;
            pos = this.add_lineAt(pos,level,  "Item", HMS.SP.SPUtil.toString(spListTemplateCollection.Item_)); //String;
            return pos;
        }
        public int add_ListTemplateCollection_deferred(int pos, int level, HMS.SP.ListTemplateCollection spListTemplateCollection)
        {
            {
                string useUrl = spListTemplateCollection.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "ListTemplateCollection","", knownPages.pageListTemplate, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "ListTemplateCollection", "",knownPages.NONE, "");
                    pos = this.add_ListTemplateCollection(pos, level+1, spListTemplateCollection);
                }
            }
        return pos;
        }
    }
}

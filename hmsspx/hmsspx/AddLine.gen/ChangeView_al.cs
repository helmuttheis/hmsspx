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
        public int add_ChangeView(int level, HMS.SP.ChangeView spChangeView)
        {
            return add_ChangeView(-1, level, spChangeView);
        }
        public int  add_ChangeView(int pos, int level, HMS.SP.ChangeView spChangeView)
        {
            if (spChangeView.__HMSError_ != null && (spChangeView.__HMSError_.errno != 0 || spChangeView.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spChangeView.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spChangeView.__deferred_);
            pos = this.add__metadata(pos, level, spChangeView.__metadata_);
            pos = this.add__rest(pos, level, spChangeView.__rest);
            pos = this.add_lineAt(pos,level,  "ListId", HMS.SP.SPUtil.toString(spChangeView.ListId_)); //Guid;
            pos = this.add_lineAt(pos,level,  "ViewId", HMS.SP.SPUtil.toString(spChangeView.ViewId_)); //Guid;
            pos = this.add_lineAt(pos,level,  "WebId", HMS.SP.SPUtil.toString(spChangeView.WebId_)); //Guid;
            return pos;
        }
        public int add_ChangeView_deferred(int pos, int level, HMS.SP.ChangeView spChangeView)
        {
            {
                string useUrl = spChangeView.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "ChangeView","", knownPages.pageChangeView, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "ChangeView", "",knownPages.NONE, "");
                    pos = this.add_ChangeView(pos, level+1, spChangeView);
                }
            }
        return pos;
        }
    }
}

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
        public int add_Change(int level, HMS.SP.Change spChange)
        {
            return add_Change(-1, level, spChange);
        }
        public int  add_Change(int pos, int level, HMS.SP.Change spChange)
        {
            if (spChange.__HMSError_ != null && (spChange.__HMSError_.errno != 0 || spChange.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spChange.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spChange.__deferred_);
            pos = this.add__metadata(pos, level, spChange.__metadata_);
            pos = this.add__rest(pos, level, spChange.__rest);
            pos = this.add_deferredAt(pos,level, "ChangeToken", "...", knownPages.pageChangeToken , spChange.ChangeToken_.__deferred_); //ChangeToken;
            pos = this.add_lineAt(pos,level,  "ChangeType", HMS.SP.SPUtil.toString(spChange.ChangeType_)); //ChangeType;
            pos = this.add_lineAt(pos,level,  "SiteId", HMS.SP.SPUtil.toString(spChange.SiteId_)); //Guid;
            pos = this.add_lineAt(pos,level,  "Time", HMS.SP.SPUtil.toString(spChange.Time_)); //DateTime;
            return pos;
        }
        public int add_Change_deferred(int pos, int level, HMS.SP.Change spChange)
        {
            {
                string useUrl = spChange.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "Change","", knownPages.pageChange, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "Change", "",knownPages.NONE, "");
                    pos = this.add_Change(pos, level+1, spChange);
                }
            }
        return pos;
        }
    }
}

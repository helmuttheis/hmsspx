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
        public int add_UserCustomActionCollection(int level, HMS.SP.UserCustomActionCollection spUserCustomActionCollection)
        {
            return add_UserCustomActionCollection(-1, level, spUserCustomActionCollection);
        }
        public int  add_UserCustomActionCollection(int pos, int level, HMS.SP.UserCustomActionCollection spUserCustomActionCollection)
        {
            if (spUserCustomActionCollection.__HMSError_ != null && (spUserCustomActionCollection.__HMSError_.errno != 0 || spUserCustomActionCollection.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spUserCustomActionCollection.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spUserCustomActionCollection.__deferred_);
            pos = this.add__metadata(pos, level, spUserCustomActionCollection.__metadata_);
            pos = this.add__rest(pos, level, spUserCustomActionCollection.__rest);
            
            return pos;
        }
        public int add_UserCustomActionCollection_deferred(int pos, int level, HMS.SP.UserCustomActionCollection spUserCustomActionCollection)
        {
            {
                string useUrl = spUserCustomActionCollection.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "UserCustomActionCollection","", knownPages.pageUserCustomAction, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "UserCustomActionCollection", "",knownPages.NONE, "");
                    pos = this.add_UserCustomActionCollection(pos, level+1, spUserCustomActionCollection);
                }
            }
        return pos;
        }
    }
}

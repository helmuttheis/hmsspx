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
        public int add_BasePermissions(int level, HMS.SP.BasePermissions spBasePermissions)
        {
            return add_BasePermissions(-1, level, spBasePermissions);
        }
        public int  add_BasePermissions(int pos, int level, HMS.SP.BasePermissions spBasePermissions)
        {
            if (spBasePermissions.__HMSError_ != null && (spBasePermissions.__HMSError_.errno != 0 || spBasePermissions.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spBasePermissions.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spBasePermissions.__deferred_);
            pos = this.add__metadata(pos, level, spBasePermissions.__metadata_);
            pos = this.add__rest(pos, level, spBasePermissions.__rest);
            pos = this.add_lineAt(pos,level,  "High", HMS.SP.SPUtil.toString(spBasePermissions.High_)); //Int64;
            pos = this.add_lineAt(pos,level,  "Low", HMS.SP.SPUtil.toString(spBasePermissions.Low_)); //Int64;
            return pos;
        }
        public int add_BasePermissions_deferred(int pos, int level, HMS.SP.BasePermissions spBasePermissions)
        {
            {
                string useUrl = spBasePermissions.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "BasePermissions","", knownPages.pageBasePermissions, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "BasePermissions", "",knownPages.NONE, "");
                    pos = this.add_BasePermissions(pos, level+1, spBasePermissions);
                }
            }
        return pos;
        }
    }
}

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
        public int add_UserIdInfo(int level, HMS.SP.UserIdInfo spUserIdInfo)
        {
            return add_UserIdInfo(-1, level, spUserIdInfo);
        }
        public int  add_UserIdInfo(int pos, int level, HMS.SP.UserIdInfo spUserIdInfo)
        {
            if (spUserIdInfo.__HMSError_ != null && (spUserIdInfo.__HMSError_.errno != 0 || spUserIdInfo.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spUserIdInfo.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spUserIdInfo.__deferred_);
            pos = this.add__metadata(pos, level, spUserIdInfo.__metadata_);
            pos = this.add__rest(pos, level, spUserIdInfo.__rest);
            pos = this.add_lineAt(pos,level,  "NameId", HMS.SP.SPUtil.toString(spUserIdInfo.NameId_)); //String;
            pos = this.add_lineAt(pos,level,  "NameIdIssuer", HMS.SP.SPUtil.toString(spUserIdInfo.NameIdIssuer_)); //String;
            return pos;
        }
        public int add_UserIdInfo_deferred(int pos, int level, HMS.SP.UserIdInfo spUserIdInfo)
        {
            {
                string useUrl = spUserIdInfo.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "UserIdInfo","", knownPages.pageUserIdInfo, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "UserIdInfo", "",knownPages.NONE, "");
                    pos = this.add_UserIdInfo(pos, level+1, spUserIdInfo);
                }
            }
        return pos;
        }
    }
}

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
        public int add_UserCreationInformation(int level, HMS.SP.UserCreationInformation spUserCreationInformation)
        {
            return add_UserCreationInformation(-1, level, spUserCreationInformation);
        }
        public int  add_UserCreationInformation(int pos, int level, HMS.SP.UserCreationInformation spUserCreationInformation)
        {
            if (spUserCreationInformation.__HMSError_ != null && (spUserCreationInformation.__HMSError_.errno != 0 || spUserCreationInformation.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spUserCreationInformation.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spUserCreationInformation.__deferred_);
            pos = this.add__metadata(pos, level, spUserCreationInformation.__metadata_);
            pos = this.add__rest(pos, level, spUserCreationInformation.__rest);
            pos = this.add_lineAt(pos,level,  "Email", HMS.SP.SPUtil.toString(spUserCreationInformation.Email_)); //String;
            pos = this.add_lineAt(pos,level,  "LoginName", HMS.SP.SPUtil.toString(spUserCreationInformation.LoginName_)); //String;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spUserCreationInformation.Title_)); //String;
            return pos;
        }
        public int add_UserCreationInformation_deferred(int pos, int level, HMS.SP.UserCreationInformation spUserCreationInformation)
        {
            if (spUserCreationInformation.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "UserCreationInformation", HMS.SP.SPUtil.toString(spUserCreationInformation.Title_), knownPages.NONE,""); //String;
                pos = add_UserCreationInformation(pos, level + 1, spUserCreationInformation);
            }
            else
            {
                string useUrl = spUserCreationInformation.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spUserCreationInformation.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spUserCreationInformation.Title_, "", knownPages.pageUserCreationInformation, useUrl);
            }
        return pos;
        }
    }
}

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
        public int add_User(int level, HMS.SP.User spUser)
        {
            return add_User(-1, level, spUser);
        }
        public int  add_User(int pos, int level, HMS.SP.User spUser)
        {
            if (spUser.__HMSError_ != null && (spUser.__HMSError_.errno != 0 || spUser.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spUser.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spUser.__deferred_);
            pos = this.add__metadata(pos, level, spUser.__metadata_);
            pos = this.add__rest(pos, level, spUser.__rest);
            pos = this.add_lineAt(pos,level,  "Email", HMS.SP.SPUtil.toString(spUser.Email_)); //String;
            pos = this.add_deferredAt(pos,level, "Groups", "...", myType.GetType("SP.Group"), spUser.Groups_.__deferred_); //Group;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spUser.Id_)); //Int32;
            pos = this.add_lineAt(pos,level,  "IsHiddenInUI", HMS.SP.SPUtil.toString(spUser.IsHiddenInUI_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "IsSiteAdmin", HMS.SP.SPUtil.toString(spUser.IsSiteAdmin_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "LoginName", HMS.SP.SPUtil.toString(spUser.LoginName_)); //String;
            pos = this.add_lineAt(pos,level,  "PrincipalType", HMS.SP.SPUtil.toString(spUser.PrincipalType_)); //Int32;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spUser.Title_)); //String;
            pos = this.add_deferredAt(pos,level, "UserId", "...", knownPages.pageUserIdInfo , spUser.UserId_.__deferred_); //UserIdInfo;
            return pos;
        }
        public int add_User_deferred(int pos, int level, HMS.SP.User spUser)
        {
            if (spUser.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "User", HMS.SP.SPUtil.toString(spUser.Title_), knownPages.NONE,""); //String;
                pos = add_User(pos, level + 1, spUser);
            }
            else
            {
                string useUrl = spUser.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spUser.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spUser.Title_, "", knownPages.pageUser, useUrl);
            }
        return pos;
        }
    }
}

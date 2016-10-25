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
        public int add_Principal(int level, HMS.SP.Principal spPrincipal)
        {
            return add_Principal(-1, level, spPrincipal);
        }
        public int  add_Principal(int pos, int level, HMS.SP.Principal spPrincipal)
        {
            if (spPrincipal.__HMSError_ != null && (spPrincipal.__HMSError_.errno != 0 || spPrincipal.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spPrincipal.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spPrincipal.__deferred_);
            pos = this.add__metadata(pos, level, spPrincipal.__metadata_);
            pos = this.add__rest(pos, level, spPrincipal.__rest);
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spPrincipal.Id_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "IsHiddenInUI", HMS.SP.SPUtil.toString(spPrincipal.IsHiddenInUI_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "LoginName", HMS.SP.SPUtil.toString(spPrincipal.LoginName_)); //String;
            pos = this.add_lineAt(pos,level,  "PrincipalType", HMS.SP.SPUtil.toString(spPrincipal.PrincipalType_)); //Utilities.PrincipalType;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spPrincipal.Title_)); //String;
            return pos;
        }
        public int add_Principal_deferred(int pos, int level, HMS.SP.Principal spPrincipal)
        {
            {
                string useUrl = spPrincipal.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "Principal","", knownPages.pagePrincipal, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "Principal", "",knownPages.NONE, "");
                    pos = this.add_Principal(pos, level+1, spPrincipal);
                }
            }
        return pos;
        }
    }
}

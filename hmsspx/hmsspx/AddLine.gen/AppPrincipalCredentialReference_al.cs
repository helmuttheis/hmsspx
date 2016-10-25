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
        public int add_AppPrincipalCredentialReference(int level, HMS.SP.AppPrincipalCredentialReference spAppPrincipalCredentialReference)
        {
            return add_AppPrincipalCredentialReference(-1, level, spAppPrincipalCredentialReference);
        }
        public int  add_AppPrincipalCredentialReference(int pos, int level, HMS.SP.AppPrincipalCredentialReference spAppPrincipalCredentialReference)
        {
            if (spAppPrincipalCredentialReference.__HMSError_ != null && (spAppPrincipalCredentialReference.__HMSError_.errno != 0 || spAppPrincipalCredentialReference.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spAppPrincipalCredentialReference.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spAppPrincipalCredentialReference.__deferred_);
            pos = this.add__metadata(pos, level, spAppPrincipalCredentialReference.__metadata_);
            pos = this.add__rest(pos, level, spAppPrincipalCredentialReference.__rest);
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spAppPrincipalCredentialReference.Id_)); //Guid;
            pos = this.add_lineAt(pos,level,  "NameIdentifier", HMS.SP.SPUtil.toString(spAppPrincipalCredentialReference.NameIdentifier_)); //String;
            pos = this.add_lineAt(pos,level,  "NotAfter", HMS.SP.SPUtil.toString(spAppPrincipalCredentialReference.NotAfter_)); //DateTime;
            pos = this.add_lineAt(pos,level,  "NotBefore", HMS.SP.SPUtil.toString(spAppPrincipalCredentialReference.NotBefore_)); //DateTime;
            return pos;
        }
        public int add_AppPrincipalCredentialReference_deferred(int pos, int level, HMS.SP.AppPrincipalCredentialReference spAppPrincipalCredentialReference)
        {
            {
                string useUrl = spAppPrincipalCredentialReference.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "AppPrincipalCredentialReference","", knownPages.pageAppPrincipalCredentialReference, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "AppPrincipalCredentialReference", "",knownPages.NONE, "");
                    pos = this.add_AppPrincipalCredentialReference(pos, level+1, spAppPrincipalCredentialReference);
                }
            }
        return pos;
        }
    }
}

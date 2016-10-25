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
        public int add_ContextWebInformation(int level, HMS.SP.ContextWebInformation spContextWebInformation)
        {
            return add_ContextWebInformation(-1, level, spContextWebInformation);
        }
        public int  add_ContextWebInformation(int pos, int level, HMS.SP.ContextWebInformation spContextWebInformation)
        {
            if (spContextWebInformation.__HMSError_ != null && (spContextWebInformation.__HMSError_.errno != 0 || spContextWebInformation.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spContextWebInformation.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spContextWebInformation.__deferred_);
            pos = this.add__metadata(pos, level, spContextWebInformation.__metadata_);
            pos = this.add__rest(pos, level, spContextWebInformation.__rest);
            pos = this.add_lineAt(pos,level,  "FormDigestTimeoutSeconds", HMS.SP.SPUtil.toString(spContextWebInformation.FormDigestTimeoutSeconds_)); //Int32;
            pos = this.add_lineAt(pos,level,  "FormDigestValue", HMS.SP.SPUtil.toString(spContextWebInformation.FormDigestValue_)); //String;
            pos = this.add_lineAt(pos,level,  "LibraryVersion", HMS.SP.SPUtil.toString(spContextWebInformation.LibraryVersion_)); //String;
            pos = this.add_lineAt(pos,level,  "SiteFullUrl", HMS.SP.SPUtil.toString(spContextWebInformation.SiteFullUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "SupportedSchemaVersions", HMS.SP.SPUtil.toString(spContextWebInformation.SupportedSchemaVersions_)); //String;
            pos = this.add_lineAt(pos,level,  "WebFullUrl", HMS.SP.SPUtil.toString(spContextWebInformation.WebFullUrl_)); //String;
            return pos;
        }
        public int add_ContextWebInformation_deferred(int pos, int level, HMS.SP.ContextWebInformation spContextWebInformation)
        {
            {
                string useUrl = spContextWebInformation.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "ContextWebInformation","", knownPages.pageContextWebInformation, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "ContextWebInformation", "",knownPages.NONE, "");
                    pos = this.add_ContextWebInformation(pos, level+1, spContextWebInformation);
                }
            }
        return pos;
        }
    }
}

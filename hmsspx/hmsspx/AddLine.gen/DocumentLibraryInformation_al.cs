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
        public int add_DocumentLibraryInformation(int level, HMS.SP.DocumentLibraryInformation spDocumentLibraryInformation)
        {
            return add_DocumentLibraryInformation(-1, level, spDocumentLibraryInformation);
        }
        public int  add_DocumentLibraryInformation(int pos, int level, HMS.SP.DocumentLibraryInformation spDocumentLibraryInformation)
        {
            if (spDocumentLibraryInformation.__HMSError_ != null && (spDocumentLibraryInformation.__HMSError_.errno != 0 || spDocumentLibraryInformation.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spDocumentLibraryInformation.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spDocumentLibraryInformation.__deferred_);
            pos = this.add__metadata(pos, level, spDocumentLibraryInformation.__metadata_);
            pos = this.add__rest(pos, level, spDocumentLibraryInformation.__rest);
            pos = this.add_lineAt(pos,level,  "Modified", HMS.SP.SPUtil.toString(spDocumentLibraryInformation.Modified_)); //DateTime;
            pos = this.add_lineAt(pos,level,  "ModifiedFriendlyDisplay", HMS.SP.SPUtil.toString(spDocumentLibraryInformation.ModifiedFriendlyDisplay_)); //String;
            pos = this.add_lineAt(pos,level,  "ServerRelativeUrl", HMS.SP.SPUtil.toString(spDocumentLibraryInformation.ServerRelativeUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spDocumentLibraryInformation.Title_)); //String;
            return pos;
        }
        public int add_DocumentLibraryInformation_deferred(int pos, int level, HMS.SP.DocumentLibraryInformation spDocumentLibraryInformation)
        {
            if (spDocumentLibraryInformation.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "DocumentLibraryInformation", HMS.SP.SPUtil.toString(spDocumentLibraryInformation.Title_), knownPages.NONE,""); //String;
                pos = add_DocumentLibraryInformation(pos, level + 1, spDocumentLibraryInformation);
            }
            else
            {
                string useUrl = spDocumentLibraryInformation.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spDocumentLibraryInformation.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spDocumentLibraryInformation.Title_, "", knownPages.pageDocumentLibraryInformation, useUrl);
            }
        return pos;
        }
    }
}

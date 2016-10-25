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
        public int add_ViewCreationInformation(int level, HMS.SP.ViewCreationInformation spViewCreationInformation)
        {
            return add_ViewCreationInformation(-1, level, spViewCreationInformation);
        }
        public int  add_ViewCreationInformation(int pos, int level, HMS.SP.ViewCreationInformation spViewCreationInformation)
        {
            if (spViewCreationInformation.__HMSError_ != null && (spViewCreationInformation.__HMSError_.errno != 0 || spViewCreationInformation.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spViewCreationInformation.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spViewCreationInformation.__deferred_);
            pos = this.add__metadata(pos, level, spViewCreationInformation.__metadata_);
            pos = this.add__rest(pos, level, spViewCreationInformation.__rest);
            pos = this.add_lineAt(pos,level,  "Paged", HMS.SP.SPUtil.toString(spViewCreationInformation.Paged_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "PersonalView", HMS.SP.SPUtil.toString(spViewCreationInformation.PersonalView_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Query", HMS.SP.SPUtil.toString(spViewCreationInformation.Query_)); //String;
            pos = this.add_lineAt(pos,level,  "RowLimit", HMS.SP.SPUtil.toString(spViewCreationInformation.RowLimit_)); //Int32;
            pos = this.add_lineAt(pos,level,  "SetAsDefaultView", HMS.SP.SPUtil.toString(spViewCreationInformation.SetAsDefaultView_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spViewCreationInformation.Title_)); //String;
            pos = this.add_lineAt(pos,level,  "ViewFields", HMS.SP.SPUtil.toString(spViewCreationInformation.ViewFields_)); //String;
            pos = this.add_lineAt(pos,level,  "ViewTypeKind", HMS.SP.SPUtil.toString(spViewCreationInformation.ViewTypeKind_)); //Int32;
            return pos;
        }
        public int add_ViewCreationInformation_deferred(int pos, int level, HMS.SP.ViewCreationInformation spViewCreationInformation)
        {
            if (spViewCreationInformation.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "ViewCreationInformation", HMS.SP.SPUtil.toString(spViewCreationInformation.Title_), knownPages.NONE,""); //String;
                pos = add_ViewCreationInformation(pos, level + 1, spViewCreationInformation);
            }
            else
            {
                string useUrl = spViewCreationInformation.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spViewCreationInformation.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spViewCreationInformation.Title_, "", knownPages.pageViewCreationInformation, useUrl);
            }
        return pos;
        }
    }
}

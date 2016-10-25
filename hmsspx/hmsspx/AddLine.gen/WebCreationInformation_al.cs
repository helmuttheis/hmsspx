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
        public int add_WebCreationInformation(int level, HMS.SP.WebCreationInformation spWebCreationInformation)
        {
            return add_WebCreationInformation(-1, level, spWebCreationInformation);
        }
        public int  add_WebCreationInformation(int pos, int level, HMS.SP.WebCreationInformation spWebCreationInformation)
        {
            if (spWebCreationInformation.__HMSError_ != null && (spWebCreationInformation.__HMSError_.errno != 0 || spWebCreationInformation.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spWebCreationInformation.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spWebCreationInformation.__deferred_);
            pos = this.add__metadata(pos, level, spWebCreationInformation.__metadata_);
            pos = this.add__rest(pos, level, spWebCreationInformation.__rest);
            pos = this.add_lineAt(pos,level,  "Description", HMS.SP.SPUtil.toString(spWebCreationInformation.Description_)); //String;
            pos = this.add_lineAt(pos,level,  "Language", HMS.SP.SPUtil.toString(spWebCreationInformation.Language_)); //Int32;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spWebCreationInformation.Title_)); //String;
            pos = this.add_lineAt(pos,level,  "Url", HMS.SP.SPUtil.toString(spWebCreationInformation.Url_)); //String;
            pos = this.add_lineAt(pos,level,  "UseSamePermissionsAsParentSite", HMS.SP.SPUtil.toString(spWebCreationInformation.UseSamePermissionsAsParentSite_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "WebTemplate", HMS.SP.SPUtil.toString(spWebCreationInformation.WebTemplate_)); //String;
            return pos;
        }
        public int add_WebCreationInformation_deferred(int pos, int level, HMS.SP.WebCreationInformation spWebCreationInformation)
        {
            if (spWebCreationInformation.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "WebCreationInformation", HMS.SP.SPUtil.toString(spWebCreationInformation.Title_), knownPages.NONE,""); //String;
                pos = add_WebCreationInformation(pos, level + 1, spWebCreationInformation);
            }
            else
            {
                string useUrl = spWebCreationInformation.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spWebCreationInformation.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spWebCreationInformation.Title_, "", knownPages.pageWebCreationInformation, useUrl);
            }
        return pos;
        }
    }
}

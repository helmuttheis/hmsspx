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
        public int add_WebInfoCreationInformation(int level, HMS.SP.WebInfoCreationInformation spWebInfoCreationInformation)
        {
            return add_WebInfoCreationInformation(-1, level, spWebInfoCreationInformation);
        }
        public int  add_WebInfoCreationInformation(int pos, int level, HMS.SP.WebInfoCreationInformation spWebInfoCreationInformation)
        {
            if (spWebInfoCreationInformation.__HMSError_ != null && (spWebInfoCreationInformation.__HMSError_.errno != 0 || spWebInfoCreationInformation.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spWebInfoCreationInformation.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spWebInfoCreationInformation.__deferred_);
            pos = this.add__metadata(pos, level, spWebInfoCreationInformation.__metadata_);
            pos = this.add__rest(pos, level, spWebInfoCreationInformation.__rest);
            pos = this.add_lineAt(pos,level,  "Description", HMS.SP.SPUtil.toString(spWebInfoCreationInformation.Description_)); //String;
            pos = this.add_lineAt(pos,level,  "Language", HMS.SP.SPUtil.toString(spWebInfoCreationInformation.Language_)); //Int32;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spWebInfoCreationInformation.Title_)); //String;
            pos = this.add_lineAt(pos,level,  "Url", HMS.SP.SPUtil.toString(spWebInfoCreationInformation.Url_)); //String;
            pos = this.add_lineAt(pos,level,  "UseUniquePermissions", HMS.SP.SPUtil.toString(spWebInfoCreationInformation.UseUniquePermissions_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "WebTemplate", HMS.SP.SPUtil.toString(spWebInfoCreationInformation.WebTemplate_)); //String;
            return pos;
        }
        public int add_WebInfoCreationInformation_deferred(int pos, int level, HMS.SP.WebInfoCreationInformation spWebInfoCreationInformation)
        {
            if (spWebInfoCreationInformation.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "WebInfoCreationInformation", HMS.SP.SPUtil.toString(spWebInfoCreationInformation.Title_), knownPages.NONE,""); //String;
                pos = add_WebInfoCreationInformation(pos, level + 1, spWebInfoCreationInformation);
            }
            else
            {
                string useUrl = spWebInfoCreationInformation.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spWebInfoCreationInformation.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spWebInfoCreationInformation.Title_, "", knownPages.pageWebInfoCreationInformation, useUrl);
            }
        return pos;
        }
    }
}

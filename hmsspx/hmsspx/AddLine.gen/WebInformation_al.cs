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
        public int add_WebInformation(int level, HMS.SP.WebInformation spWebInformation)
        {
            return add_WebInformation(-1, level, spWebInformation);
        }
        public int  add_WebInformation(int pos, int level, HMS.SP.WebInformation spWebInformation)
        {
            if (spWebInformation.__HMSError_ != null && (spWebInformation.__HMSError_.errno != 0 || spWebInformation.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spWebInformation.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spWebInformation.__deferred_);
            pos = this.add__metadata(pos, level, spWebInformation.__metadata_);
            pos = this.add__rest(pos, level, spWebInformation.__rest);
            pos = this.add_lineAt(pos,level,  "Configuration", HMS.SP.SPUtil.toString(spWebInformation.Configuration_)); //Int16;
            pos = this.add_lineAt(pos,level,  "Created", HMS.SP.SPUtil.toString(spWebInformation.Created_)); //Object;
            pos = this.add_lineAt(pos,level,  "Description", HMS.SP.SPUtil.toString(spWebInformation.Description_)); //String;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spWebInformation.Id_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "Language", HMS.SP.SPUtil.toString(spWebInformation.Language_)); //Number;
            pos = this.add_lineAt(pos,level,  "LastItemModifiedDate", HMS.SP.SPUtil.toString(spWebInformation.LastItemModifiedDate_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "ServerRelativeUrl", HMS.SP.SPUtil.toString(spWebInformation.ServerRelativeUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spWebInformation.Title_)); //String;
            pos = this.add_lineAt(pos,level,  "WebTemplate", HMS.SP.SPUtil.toString(spWebInformation.WebTemplate_)); //Object;
            pos = this.add_lineAt(pos,level,  "WebTemplateId", HMS.SP.SPUtil.toString(spWebInformation.WebTemplateId_)); //Int32;
            return pos;
        }
        public int add_WebInformation_deferred(int pos, int level, HMS.SP.WebInformation spWebInformation)
        {
            {
                string useUrl = spWebInformation.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "WebInformation","", knownPages.pageWebInformation, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "WebInformation", "",knownPages.NONE, "");
                    pos = this.add_WebInformation(pos, level+1, spWebInformation);
                }
            }
        return pos;
        }
    }
}

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
        public int add_WebTemplate(int level, HMS.SP.WebTemplate spWebTemplate)
        {
            return add_WebTemplate(-1, level, spWebTemplate);
        }
        public int  add_WebTemplate(int pos, int level, HMS.SP.WebTemplate spWebTemplate)
        {
            if (spWebTemplate.__HMSError_ != null && (spWebTemplate.__HMSError_.errno != 0 || spWebTemplate.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spWebTemplate.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spWebTemplate.__deferred_);
            pos = this.add__metadata(pos, level, spWebTemplate.__metadata_);
            pos = this.add__rest(pos, level, spWebTemplate.__rest);
            pos = this.add_lineAt(pos,level,  "Description", HMS.SP.SPUtil.toString(spWebTemplate.Description_)); //String;
            pos = this.add_lineAt(pos,level,  "DisplayCategory", HMS.SP.SPUtil.toString(spWebTemplate.DisplayCategory_)); //String;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spWebTemplate.Id_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "ImageUrl", HMS.SP.SPUtil.toString(spWebTemplate.ImageUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "IsHidden", HMS.SP.SPUtil.toString(spWebTemplate.IsHidden_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "IsRootWebOnly", HMS.SP.SPUtil.toString(spWebTemplate.IsRootWebOnly_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "IsSubWebOnly", HMS.SP.SPUtil.toString(spWebTemplate.IsSubWebOnly_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Lcid", HMS.SP.SPUtil.toString(spWebTemplate.Lcid_)); //Number;
            pos = this.add_lineAt(pos,level,  "Name", HMS.SP.SPUtil.toString(spWebTemplate.Name_)); //String;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spWebTemplate.Title_)); //String;
            return pos;
        }
        public int add_WebTemplate_deferred(int pos, int level, HMS.SP.WebTemplate spWebTemplate)
        {
            {
                string useUrl = spWebTemplate.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "WebTemplate","", knownPages.pageWebTemplate, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "WebTemplate", "",knownPages.NONE, "");
                    pos = this.add_WebTemplate(pos, level+1, spWebTemplate);
                }
            }
        return pos;
        }
    }
}

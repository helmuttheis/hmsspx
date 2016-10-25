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
        public int add_ListCreationInformation(int level, HMS.SP.ListCreationInformation spListCreationInformation)
        {
            return add_ListCreationInformation(-1, level, spListCreationInformation);
        }
        public int  add_ListCreationInformation(int pos, int level, HMS.SP.ListCreationInformation spListCreationInformation)
        {
            if (spListCreationInformation.__HMSError_ != null && (spListCreationInformation.__HMSError_.errno != 0 || spListCreationInformation.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spListCreationInformation.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spListCreationInformation.__deferred_);
            pos = this.add__metadata(pos, level, spListCreationInformation.__metadata_);
            pos = this.add__rest(pos, level, spListCreationInformation.__rest);
            pos = this.add_lineAt(pos,level,  "CustomSchemaXml", HMS.SP.SPUtil.toString(spListCreationInformation.CustomSchemaXml_)); //String;
            pos = this.add_lineAt(pos,level,  "DataSourceProperties", HMS.SP.SPUtil.toString(spListCreationInformation.DataSourceProperties_)); //Dictionary;
            pos = this.add_lineAt(pos,level,  "Description", HMS.SP.SPUtil.toString(spListCreationInformation.Description_)); //String;
            pos = this.add_lineAt(pos,level,  "DocumentTemplateType", HMS.SP.SPUtil.toString(spListCreationInformation.DocumentTemplateType_)); //Number;
            pos = this.add_lineAt(pos,level,  "QuickLaunchOption", HMS.SP.SPUtil.toString(spListCreationInformation.QuickLaunchOption_)); //Number;
            pos = this.add_lineAt(pos,level,  "TemplateFeatureId", HMS.SP.SPUtil.toString(spListCreationInformation.TemplateFeatureId_)); //Guid;
            pos = this.add_lineAt(pos,level,  "TemplateType", HMS.SP.SPUtil.toString(spListCreationInformation.TemplateType_)); //Number;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spListCreationInformation.Title_)); //String;
            pos = this.add_lineAt(pos,level,  "TypeId", HMS.SP.SPUtil.toString(spListCreationInformation.TypeId_)); //String;
            pos = this.add_lineAt(pos,level,  "Url", HMS.SP.SPUtil.toString(spListCreationInformation.Url_)); //String;
            return pos;
        }
        public int add_ListCreationInformation_deferred(int pos, int level, HMS.SP.ListCreationInformation spListCreationInformation)
        {
            {
                string useUrl = spListCreationInformation.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "ListCreationInformation","", knownPages.pageListCreationInformation, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "ListCreationInformation", "",knownPages.NONE, "");
                    pos = this.add_ListCreationInformation(pos, level+1, spListCreationInformation);
                }
            }
        return pos;
        }
    }
}

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
        public int add_ListTemplate(int level, HMS.SP.ListTemplate spListTemplate)
        {
            return add_ListTemplate(-1, level, spListTemplate);
        }
        public int  add_ListTemplate(int pos, int level, HMS.SP.ListTemplate spListTemplate)
        {
            if (spListTemplate.__HMSError_ != null && (spListTemplate.__HMSError_.errno != 0 || spListTemplate.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spListTemplate.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spListTemplate.__deferred_);
            pos = this.add__metadata(pos, level, spListTemplate.__metadata_);
            pos = this.add__rest(pos, level, spListTemplate.__rest);
            pos = this.add_lineAt(pos,level,  "AllowsFolderCreation", HMS.SP.SPUtil.toString(spListTemplate.AllowsFolderCreation_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "BaseType", HMS.SP.SPUtil.toString(spListTemplate.BaseType_)); //BaseType;
            pos = this.add_lineAt(pos,level,  "Description", HMS.SP.SPUtil.toString(spListTemplate.Description_)); //String;
            pos = this.add_lineAt(pos,level,  "FeatureId", HMS.SP.SPUtil.toString(spListTemplate.FeatureId_)); //Guid;
            pos = this.add_lineAt(pos,level,  "Hidden", HMS.SP.SPUtil.toString(spListTemplate.Hidden_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "ImageUrl", HMS.SP.SPUtil.toString(spListTemplate.ImageUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "InternalName", HMS.SP.SPUtil.toString(spListTemplate.InternalName_)); //String;
            pos = this.add_lineAt(pos,level,  "IsCustomTemplate", HMS.SP.SPUtil.toString(spListTemplate.IsCustomTemplate_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "ListTemplateTypeKind", HMS.SP.SPUtil.toString(spListTemplate.ListTemplateTypeKind_)); //Number;
            pos = this.add_lineAt(pos,level,  "Name", HMS.SP.SPUtil.toString(spListTemplate.Name_)); //String;
            pos = this.add_lineAt(pos,level,  "OnQuickLaunch", HMS.SP.SPUtil.toString(spListTemplate.OnQuickLaunch_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Unique", HMS.SP.SPUtil.toString(spListTemplate.Unique_)); //Boolean;
            return pos;
        }
        public int add_ListTemplate_deferred(int pos, int level, HMS.SP.ListTemplate spListTemplate)
        {
            {
                string useUrl = spListTemplate.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "ListTemplate","", knownPages.pageListTemplate, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "ListTemplate", "",knownPages.NONE, "");
                    pos = this.add_ListTemplate(pos, level+1, spListTemplate);
                }
            }
        return pos;
        }
    }
}

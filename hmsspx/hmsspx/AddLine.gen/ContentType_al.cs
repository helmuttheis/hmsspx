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
        public int add_ContentType(int level, HMS.SP.ContentType spContentType)
        {
            return add_ContentType(-1, level, spContentType);
        }
        public int  add_ContentType(int pos, int level, HMS.SP.ContentType spContentType)
        {
            if (spContentType.__HMSError_ != null && (spContentType.__HMSError_.errno != 0 || spContentType.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spContentType.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spContentType.__deferred_);
            pos = this.add__metadata(pos, level, spContentType.__metadata_);
            pos = this.add__rest(pos, level, spContentType.__rest);
            pos = this.add_lineAt(pos,level,  "Description", HMS.SP.SPUtil.toString(spContentType.Description_)); //String;
            pos = this.add_lineAt(pos,level,  "DisplayFormTemplateName", HMS.SP.SPUtil.toString(spContentType.DisplayFormTemplateName_)); //String;
            pos = this.add_lineAt(pos,level,  "DisplayFormUrl", HMS.SP.SPUtil.toString(spContentType.DisplayFormUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "DocumentTemplate", HMS.SP.SPUtil.toString(spContentType.DocumentTemplate_)); //String;
            pos = this.add_lineAt(pos,level,  "DocumentTemplateUrl", HMS.SP.SPUtil.toString(spContentType.DocumentTemplateUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "EditFormTemplateName", HMS.SP.SPUtil.toString(spContentType.EditFormTemplateName_)); //String;
            pos = this.add_lineAt(pos,level,  "EditFormUrl", HMS.SP.SPUtil.toString(spContentType.EditFormUrl_)); //String;
            pos = this.add_deferredAt(pos,level, "FieldLinks", "...", myType.GetType("SP.FieldLink"), spContentType.FieldLinks_.__deferred_); //FieldLink;
            pos = this.add_deferredAt(pos,level, "Fields", "...", myType.GetType("SP.Field"), spContentType.Fields_.__deferred_); //Field;
            pos = this.add_lineAt(pos,level,  "Group", HMS.SP.SPUtil.toString(spContentType.Group_)); //String;
            pos = this.add_lineAt(pos,level,  "Hidden", HMS.SP.SPUtil.toString(spContentType.Hidden_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spContentType.Id_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "Name", HMS.SP.SPUtil.toString(spContentType.Name_)); //String;
            pos = this.add_lineAt(pos,level,  "NewFormTemplateName", HMS.SP.SPUtil.toString(spContentType.NewFormTemplateName_)); //String;
            pos = this.add_lineAt(pos,level,  "NewFormUrl", HMS.SP.SPUtil.toString(spContentType.NewFormUrl_)); //String;
            pos = this.add_deferredAt(pos,level, "Parent", "...", knownPages.pageContentType , spContentType.Parent_.__deferred_); //ContentType;
            pos = this.add_lineAt(pos,level,  "ReadOnly", HMS.SP.SPUtil.toString(spContentType.ReadOnly_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "SchemaXml", HMS.SP.SPUtil.toString(spContentType.SchemaXml_)); //String;
            pos = this.add_lineAt(pos,level,  "SchemaXmlWithResourceTokens", HMS.SP.SPUtil.toString(spContentType.SchemaXmlWithResourceTokens_)); //Object;
            pos = this.add_lineAt(pos,level,  "Scope", HMS.SP.SPUtil.toString(spContentType.Scope_)); //String;
            pos = this.add_lineAt(pos,level,  "Sealed", HMS.SP.SPUtil.toString(spContentType.Sealed_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "StringId", HMS.SP.SPUtil.toString(spContentType.StringId_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "WorkflowAssociations", HMS.SP.SPUtil.toString(spContentType.WorkflowAssociations_)); //Workflow.WorkflowAssociation;
            return pos;
        }
        public int add_ContentType_deferred(int pos, int level, HMS.SP.ContentType spContentType)
        {
            {
                string useUrl = spContentType.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "ContentType","", knownPages.pageContentType, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "ContentType", "",knownPages.NONE, "");
                    pos = this.add_ContentType(pos, level+1, spContentType);
                }
            }
        return pos;
        }
    }
}

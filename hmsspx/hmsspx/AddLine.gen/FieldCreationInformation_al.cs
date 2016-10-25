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
        public int add_FieldCreationInformation(int level, HMS.SP.FieldCreationInformation spFieldCreationInformation)
        {
            return add_FieldCreationInformation(-1, level, spFieldCreationInformation);
        }
        public int  add_FieldCreationInformation(int pos, int level, HMS.SP.FieldCreationInformation spFieldCreationInformation)
        {
            if (spFieldCreationInformation.__HMSError_ != null && (spFieldCreationInformation.__HMSError_.errno != 0 || spFieldCreationInformation.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spFieldCreationInformation.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spFieldCreationInformation.__deferred_);
            pos = this.add__metadata(pos, level, spFieldCreationInformation.__metadata_);
            pos = this.add__rest(pos, level, spFieldCreationInformation.__rest);
            pos = this.add_lineAt(pos,level,  "Choices", HMS.SP.SPUtil.toString(spFieldCreationInformation.Choices_)); //String;
            pos = this.add_lineAt(pos,level,  "IsCompactName", HMS.SP.SPUtil.toString(spFieldCreationInformation.IsCompactName_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "LookupFieldName", HMS.SP.SPUtil.toString(spFieldCreationInformation.LookupFieldName_)); //String;
            pos = this.add_lineAt(pos,level,  "LookupListId", HMS.SP.SPUtil.toString(spFieldCreationInformation.LookupListId_)); //Guid;
            pos = this.add_lineAt(pos,level,  "LookupWebId", HMS.SP.SPUtil.toString(spFieldCreationInformation.LookupWebId_)); //Guid;
            pos = this.add_lineAt(pos,level,  "Required", HMS.SP.SPUtil.toString(spFieldCreationInformation.Required_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spFieldCreationInformation.Title_)); //String;
            pos = this.add_lineAt(pos,level,  "FieldTypeKind", HMS.SP.SPUtil.toString(spFieldCreationInformation.FieldTypeKind_)); //Int32;
            return pos;
        }
        public int add_FieldCreationInformation_deferred(int pos, int level, HMS.SP.FieldCreationInformation spFieldCreationInformation)
        {
            if (spFieldCreationInformation.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "FieldCreationInformation", HMS.SP.SPUtil.toString(spFieldCreationInformation.Title_), knownPages.NONE,""); //String;
                pos = add_FieldCreationInformation(pos, level + 1, spFieldCreationInformation);
            }
            else
            {
                string useUrl = spFieldCreationInformation.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spFieldCreationInformation.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spFieldCreationInformation.Title_, "", knownPages.pageFieldCreationInformation, useUrl);
            }
        return pos;
        }
    }
}

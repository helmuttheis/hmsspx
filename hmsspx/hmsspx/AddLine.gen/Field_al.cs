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
        public int add_Field(int level, HMS.SP.Field spField)
        {
            return add_Field(-1, level, spField);
        }
        public int  add_Field(int pos, int level, HMS.SP.Field spField)
        {
            if (spField.__HMSError_ != null && (spField.__HMSError_.errno != 0 || spField.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spField.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spField.__deferred_);
            pos = this.add__metadata(pos, level, spField.__metadata_);
            pos = this.add__rest(pos, level, spField.__rest);
            pos = this.add_lineAt(pos,level,  "CanBeDeleted", HMS.SP.SPUtil.toString(spField.CanBeDeleted_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "DefaultValue", HMS.SP.SPUtil.toString(spField.DefaultValue_)); //String;
            pos = this.add_lineAt(pos,level,  "Description", HMS.SP.SPUtil.toString(spField.Description_)); //String;
            pos = this.add_lineAt(pos,level,  "Direction", HMS.SP.SPUtil.toString(spField.Direction_)); //String;
            pos = this.add_lineAt(pos,level,  "EnforceUniqueValues", HMS.SP.SPUtil.toString(spField.EnforceUniqueValues_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "EntityPropertyName", HMS.SP.SPUtil.toString(spField.EntityPropertyName_)); //String;
            pos = this.add_lineAt(pos,level,  "FieldTypeKind", HMS.SP.SPUtil.toString(spField.FieldTypeKind_)); //Int32;
            pos = this.add_lineAt(pos,level,  "Filterable", HMS.SP.SPUtil.toString(spField.Filterable_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "FromBaseType", HMS.SP.SPUtil.toString(spField.FromBaseType_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Group", HMS.SP.SPUtil.toString(spField.Group_)); //String;
            pos = this.add_lineAt(pos,level,  "Hidden", HMS.SP.SPUtil.toString(spField.Hidden_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spField.Id_)); //Guid;
            pos = this.add_lineAt(pos,level,  "Indexed", HMS.SP.SPUtil.toString(spField.Indexed_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "InternalName", HMS.SP.SPUtil.toString(spField.InternalName_)); //String;
            pos = this.add_lineAt(pos,level,  "JSLink", HMS.SP.SPUtil.toString(spField.JSLink_)); //String;
            pos = this.add_lineAt(pos,level,  "ReadOnlyField", HMS.SP.SPUtil.toString(spField.ReadOnlyField_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Required", HMS.SP.SPUtil.toString(spField.Required_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "SchemaXml", HMS.SP.SPUtil.toString(spField.SchemaXml_)); //String;
            pos = this.add_lineAt(pos,level,  "SchemaXmlWithResourceTokens", HMS.SP.SPUtil.toString(spField.SchemaXmlWithResourceTokens_)); //String;
            pos = this.add_lineAt(pos,level,  "Scope", HMS.SP.SPUtil.toString(spField.Scope_)); //String;
            pos = this.add_lineAt(pos,level,  "Sealed", HMS.SP.SPUtil.toString(spField.Sealed_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Sortable", HMS.SP.SPUtil.toString(spField.Sortable_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "StaticName", HMS.SP.SPUtil.toString(spField.StaticName_)); //String;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spField.Title_)); //String;
            pos = this.add_lineAt(pos,level,  "TypeAsString", HMS.SP.SPUtil.toString(spField.TypeAsString_)); //String;
            pos = this.add_lineAt(pos,level,  "TypeDisplayName", HMS.SP.SPUtil.toString(spField.TypeDisplayName_)); //String;
            pos = this.add_lineAt(pos,level,  "TypeShortDescription", HMS.SP.SPUtil.toString(spField.TypeShortDescription_)); //String;
            pos = this.add_lineAt(pos,level,  "ValidationFormula", HMS.SP.SPUtil.toString(spField.ValidationFormula_)); //String;
            pos = this.add_lineAt(pos,level,  "ValidationMessage", HMS.SP.SPUtil.toString(spField.ValidationMessage_)); //String;
            return pos;
        }
        public int add_Field_deferred(int pos, int level, HMS.SP.Field spField)
        {
            if (spField.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "Field", HMS.SP.SPUtil.toString(spField.Title_), knownPages.NONE,""); //String;
                pos = add_Field(pos, level + 1, spField);
            }
            else
            {
                string useUrl = spField.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spField.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spField.Title_, "", knownPages.pageField, useUrl);
            }
        return pos;
        }
    }
}

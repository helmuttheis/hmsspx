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
        public int add_FieldLookup(int level, HMS.SP.FieldLookup spFieldLookup)
        {
            return add_FieldLookup(-1, level, spFieldLookup);
        }
        public int  add_FieldLookup(int pos, int level, HMS.SP.FieldLookup spFieldLookup)
        {
            if (spFieldLookup.__HMSError_ != null && (spFieldLookup.__HMSError_.errno != 0 || spFieldLookup.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spFieldLookup.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spFieldLookup.__deferred_);
            pos = this.add__metadata(pos, level, spFieldLookup.__metadata_);
            pos = this.add__rest(pos, level, spFieldLookup.__rest);
            pos = this.add_lineAt(pos,level,  "AllowMultipleValues", HMS.SP.SPUtil.toString(spFieldLookup.AllowMultipleValues_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "IsRelationship", HMS.SP.SPUtil.toString(spFieldLookup.IsRelationship_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "LookupField", HMS.SP.SPUtil.toString(spFieldLookup.LookupField_)); //String;
            pos = this.add_lineAt(pos,level,  "LookupList", HMS.SP.SPUtil.toString(spFieldLookup.LookupList_)); //String;
            pos = this.add_lineAt(pos,level,  "LookupWebId", HMS.SP.SPUtil.toString(spFieldLookup.LookupWebId_)); //Guid;
            pos = this.add_lineAt(pos,level,  "PrimaryFieldId", HMS.SP.SPUtil.toString(spFieldLookup.PrimaryFieldId_)); //String;
            pos = this.add_lineAt(pos,level,  "RelationshipDeleteBehavior", HMS.SP.SPUtil.toString(spFieldLookup.RelationshipDeleteBehavior_)); //Object;
            return pos;
        }
        public int add_FieldLookup_deferred(int pos, int level, HMS.SP.FieldLookup spFieldLookup)
        {
            {
                string useUrl = spFieldLookup.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "FieldLookup","", knownPages.pageFieldLookup, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "FieldLookup", "",knownPages.NONE, "");
                    pos = this.add_FieldLookup(pos, level+1, spFieldLookup);
                }
            }
        return pos;
        }
    }
}

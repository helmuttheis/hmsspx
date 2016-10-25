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
        public int add_ListDataValidationFailure(int level, HMS.SP.ListDataValidationFailure spListDataValidationFailure)
        {
            return add_ListDataValidationFailure(-1, level, spListDataValidationFailure);
        }
        public int  add_ListDataValidationFailure(int pos, int level, HMS.SP.ListDataValidationFailure spListDataValidationFailure)
        {
            if (spListDataValidationFailure.__HMSError_ != null && (spListDataValidationFailure.__HMSError_.errno != 0 || spListDataValidationFailure.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spListDataValidationFailure.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spListDataValidationFailure.__deferred_);
            pos = this.add__metadata(pos, level, spListDataValidationFailure.__metadata_);
            pos = this.add__rest(pos, level, spListDataValidationFailure.__rest);
            pos = this.add_lineAt(pos,level,  "DisplayName", HMS.SP.SPUtil.toString(spListDataValidationFailure.DisplayName_)); //String;
            pos = this.add_lineAt(pos,level,  "Message", HMS.SP.SPUtil.toString(spListDataValidationFailure.Message_)); //String;
            pos = this.add_lineAt(pos,level,  "Name", HMS.SP.SPUtil.toString(spListDataValidationFailure.Name_)); //String;
            pos = this.add_lineAt(pos,level,  "Reason", HMS.SP.SPUtil.toString(spListDataValidationFailure.Reason_)); //Int32;
            pos = this.add_lineAt(pos,level,  "ValidationType", HMS.SP.SPUtil.toString(spListDataValidationFailure.ValidationType_)); //Int32;
            return pos;
        }
        public int add_ListDataValidationFailure_deferred(int pos, int level, HMS.SP.ListDataValidationFailure spListDataValidationFailure)
        {
            {
                string useUrl = spListDataValidationFailure.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "ListDataValidationFailure","", knownPages.pageListDataValidationFailure, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "ListDataValidationFailure", "",knownPages.NONE, "");
                    pos = this.add_ListDataValidationFailure(pos, level+1, spListDataValidationFailure);
                }
            }
        return pos;
        }
    }
}

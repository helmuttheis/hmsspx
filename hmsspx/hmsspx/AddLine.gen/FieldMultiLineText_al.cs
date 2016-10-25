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
        public int add_FieldMultiLineText(int level, HMS.SP.FieldMultiLineText spFieldMultiLineText)
        {
            return add_FieldMultiLineText(-1, level, spFieldMultiLineText);
        }
        public int  add_FieldMultiLineText(int pos, int level, HMS.SP.FieldMultiLineText spFieldMultiLineText)
        {
            if (spFieldMultiLineText.__HMSError_ != null && (spFieldMultiLineText.__HMSError_.errno != 0 || spFieldMultiLineText.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spFieldMultiLineText.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spFieldMultiLineText.__deferred_);
            pos = this.add__metadata(pos, level, spFieldMultiLineText.__metadata_);
            pos = this.add__rest(pos, level, spFieldMultiLineText.__rest);
            pos = this.add_lineAt(pos,level,  "AllowHyperlink", HMS.SP.SPUtil.toString(spFieldMultiLineText.AllowHyperlink_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "AppendOnly", HMS.SP.SPUtil.toString(spFieldMultiLineText.AppendOnly_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "NumberOfLines", HMS.SP.SPUtil.toString(spFieldMultiLineText.NumberOfLines_)); //Number;
            pos = this.add_lineAt(pos,level,  "RestrictedMode", HMS.SP.SPUtil.toString(spFieldMultiLineText.RestrictedMode_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "RichText", HMS.SP.SPUtil.toString(spFieldMultiLineText.RichText_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "WikiLinking", HMS.SP.SPUtil.toString(spFieldMultiLineText.WikiLinking_)); //Boolean;
            return pos;
        }
        public int add_FieldMultiLineText_deferred(int pos, int level, HMS.SP.FieldMultiLineText spFieldMultiLineText)
        {
            {
                string useUrl = spFieldMultiLineText.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "FieldMultiLineText","", knownPages.pageFieldMultiLineText, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "FieldMultiLineText", "",knownPages.NONE, "");
                    pos = this.add_FieldMultiLineText(pos, level+1, spFieldMultiLineText);
                }
            }
        return pos;
        }
    }
}

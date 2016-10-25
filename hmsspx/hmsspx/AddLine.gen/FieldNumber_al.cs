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
        public int add_FieldNumber(int level, HMS.SP.FieldNumber spFieldNumber)
        {
            return add_FieldNumber(-1, level, spFieldNumber);
        }
        public int  add_FieldNumber(int pos, int level, HMS.SP.FieldNumber spFieldNumber)
        {
            if (spFieldNumber.__HMSError_ != null && (spFieldNumber.__HMSError_.errno != 0 || spFieldNumber.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spFieldNumber.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spFieldNumber.__deferred_);
            pos = this.add__metadata(pos, level, spFieldNumber.__metadata_);
            pos = this.add__rest(pos, level, spFieldNumber.__rest);
            pos = this.add_lineAt(pos,level,  "MaximumValue", HMS.SP.SPUtil.toString(spFieldNumber.MaximumValue_)); //Double;
            pos = this.add_lineAt(pos,level,  "MinimumValue", HMS.SP.SPUtil.toString(spFieldNumber.MinimumValue_)); //Double;
            return pos;
        }
        public int add_FieldNumber_deferred(int pos, int level, HMS.SP.FieldNumber spFieldNumber)
        {
            {
                string useUrl = spFieldNumber.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "FieldNumber","", knownPages.pageFieldNumber, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "FieldNumber", "",knownPages.NONE, "");
                    pos = this.add_FieldNumber(pos, level+1, spFieldNumber);
                }
            }
        return pos;
        }
    }
}

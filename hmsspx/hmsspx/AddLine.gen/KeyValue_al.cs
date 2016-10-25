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
        public int add_KeyValue(int level, HMS.SP.KeyValue spKeyValue)
        {
            return add_KeyValue(-1, level, spKeyValue);
        }
        public int  add_KeyValue(int pos, int level, HMS.SP.KeyValue spKeyValue)
        {
            if (spKeyValue.__HMSError_ != null && (spKeyValue.__HMSError_.errno != 0 || spKeyValue.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spKeyValue.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spKeyValue.__deferred_);
            pos = this.add__metadata(pos, level, spKeyValue.__metadata_);
            pos = this.add__rest(pos, level, spKeyValue.__rest);
            pos = this.add_lineAt(pos,level,  "Key", HMS.SP.SPUtil.toString(spKeyValue.Key_)); //String;
            pos = this.add_lineAt(pos,level,  "Value", HMS.SP.SPUtil.toString(spKeyValue.Value_)); //String;
            pos = this.add_lineAt(pos,level,  "ValueType", HMS.SP.SPUtil.toString(spKeyValue.ValueType_)); //String;
            return pos;
        }
        public int add_KeyValue_deferred(int pos, int level, HMS.SP.KeyValue spKeyValue)
        {
            {
                string useUrl = spKeyValue.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "KeyValue","", knownPages.pageKeyValue, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "KeyValue", "",knownPages.NONE, "");
                    pos = this.add_KeyValue(pos, level+1, spKeyValue);
                }
            }
        return pos;
        }
    }
}

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
        public int add_SubwebQuery(int level, HMS.SP.SubwebQuery spSubwebQuery)
        {
            return add_SubwebQuery(-1, level, spSubwebQuery);
        }
        public int  add_SubwebQuery(int pos, int level, HMS.SP.SubwebQuery spSubwebQuery)
        {
            if (spSubwebQuery.__HMSError_ != null && (spSubwebQuery.__HMSError_.errno != 0 || spSubwebQuery.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spSubwebQuery.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spSubwebQuery.__deferred_);
            pos = this.add__metadata(pos, level, spSubwebQuery.__metadata_);
            pos = this.add__rest(pos, level, spSubwebQuery.__rest);
            pos = this.add_lineAt(pos,level,  "ConfigurationFilter", HMS.SP.SPUtil.toString(spSubwebQuery.ConfigurationFilter_)); //Number;
            pos = this.add_lineAt(pos,level,  "TypeId", HMS.SP.SPUtil.toString(spSubwebQuery.TypeId_)); //String;
            pos = this.add_lineAt(pos,level,  "WebTemplateFilter", HMS.SP.SPUtil.toString(spSubwebQuery.WebTemplateFilter_)); //Number;
            return pos;
        }
        public int add_SubwebQuery_deferred(int pos, int level, HMS.SP.SubwebQuery spSubwebQuery)
        {
            {
                string useUrl = spSubwebQuery.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "SubwebQuery","", knownPages.pageSubwebQuery, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "SubwebQuery", "",knownPages.NONE, "");
                    pos = this.add_SubwebQuery(pos, level+1, spSubwebQuery);
                }
            }
        return pos;
        }
    }
}

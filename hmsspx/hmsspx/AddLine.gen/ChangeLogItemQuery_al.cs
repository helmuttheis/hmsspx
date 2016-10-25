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
        public int add_ChangeLogItemQuery(int level, HMS.SP.ChangeLogItemQuery spChangeLogItemQuery)
        {
            return add_ChangeLogItemQuery(-1, level, spChangeLogItemQuery);
        }
        public int  add_ChangeLogItemQuery(int pos, int level, HMS.SP.ChangeLogItemQuery spChangeLogItemQuery)
        {
            if (spChangeLogItemQuery.__HMSError_ != null && (spChangeLogItemQuery.__HMSError_.errno != 0 || spChangeLogItemQuery.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spChangeLogItemQuery.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spChangeLogItemQuery.__deferred_);
            pos = this.add__metadata(pos, level, spChangeLogItemQuery.__metadata_);
            pos = this.add__rest(pos, level, spChangeLogItemQuery.__rest);
            pos = this.add_lineAt(pos,level,  "ChangeToken", HMS.SP.SPUtil.toString(spChangeLogItemQuery.ChangeToken_)); //String;
            pos = this.add_lineAt(pos,level,  "Contains", HMS.SP.SPUtil.toString(spChangeLogItemQuery.Contains_)); //String;
            pos = this.add_lineAt(pos,level,  "Query", HMS.SP.SPUtil.toString(spChangeLogItemQuery.Query_)); //String;
            pos = this.add_lineAt(pos,level,  "QueryOptions", HMS.SP.SPUtil.toString(spChangeLogItemQuery.QueryOptions_)); //String;
            pos = this.add_lineAt(pos,level,  "RowLimit", HMS.SP.SPUtil.toString(spChangeLogItemQuery.RowLimit_)); //String;
            pos = this.add_lineAt(pos,level,  "ViewFields", HMS.SP.SPUtil.toString(spChangeLogItemQuery.ViewFields_)); //String;
            pos = this.add_lineAt(pos,level,  "ViewName", HMS.SP.SPUtil.toString(spChangeLogItemQuery.ViewName_)); //String;
            return pos;
        }
        public int add_ChangeLogItemQuery_deferred(int pos, int level, HMS.SP.ChangeLogItemQuery spChangeLogItemQuery)
        {
            {
                string useUrl = spChangeLogItemQuery.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "ChangeLogItemQuery","", knownPages.pageChangeLogItemQuery, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "ChangeLogItemQuery", "",knownPages.NONE, "");
                    pos = this.add_ChangeLogItemQuery(pos, level+1, spChangeLogItemQuery);
                }
            }
        return pos;
        }
    }
}

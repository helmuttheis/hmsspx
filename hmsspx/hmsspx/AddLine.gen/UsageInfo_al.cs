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
        public int add_UsageInfo(int level, HMS.SP.UsageInfo spUsageInfo)
        {
            return add_UsageInfo(-1, level, spUsageInfo);
        }
        public int  add_UsageInfo(int pos, int level, HMS.SP.UsageInfo spUsageInfo)
        {
            if (spUsageInfo.__HMSError_ != null && (spUsageInfo.__HMSError_.errno != 0 || spUsageInfo.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spUsageInfo.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spUsageInfo.__deferred_);
            pos = this.add__metadata(pos, level, spUsageInfo.__metadata_);
            pos = this.add__rest(pos, level, spUsageInfo.__rest);
            pos = this.add_lineAt(pos,level,  "Bandwidth", HMS.SP.SPUtil.toString(spUsageInfo.Bandwidth_)); //Int64;
            pos = this.add_lineAt(pos,level,  "DiscussionStorage", HMS.SP.SPUtil.toString(spUsageInfo.DiscussionStorage_)); //Int64;
            pos = this.add_lineAt(pos,level,  "Hits", HMS.SP.SPUtil.toString(spUsageInfo.Hits_)); //Int64;
            pos = this.add_lineAt(pos,level,  "Storage", HMS.SP.SPUtil.toString(spUsageInfo.Storage_)); //Int64;
            pos = this.add_lineAt(pos,level,  "StoragePercentageUsed", HMS.SP.SPUtil.toString(spUsageInfo.StoragePercentageUsed_)); //Double;
            pos = this.add_lineAt(pos,level,  "Visits", HMS.SP.SPUtil.toString(spUsageInfo.Visits_)); //Int64;
            return pos;
        }
        public int add_UsageInfo_deferred(int pos, int level, HMS.SP.UsageInfo spUsageInfo)
        {
            {
                string useUrl = spUsageInfo.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "UsageInfo","", knownPages.pageUsageInfo, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "UsageInfo", "",knownPages.NONE, "");
                    pos = this.add_UsageInfo(pos, level+1, spUsageInfo);
                }
            }
        return pos;
        }
    }
}

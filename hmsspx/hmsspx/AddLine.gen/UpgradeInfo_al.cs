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
        public int add_UpgradeInfo(int level, HMS.SP.UpgradeInfo spUpgradeInfo)
        {
            return add_UpgradeInfo(-1, level, spUpgradeInfo);
        }
        public int  add_UpgradeInfo(int pos, int level, HMS.SP.UpgradeInfo spUpgradeInfo)
        {
            if (spUpgradeInfo.__HMSError_ != null && (spUpgradeInfo.__HMSError_.errno != 0 || spUpgradeInfo.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spUpgradeInfo.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spUpgradeInfo.__deferred_);
            pos = this.add__metadata(pos, level, spUpgradeInfo.__metadata_);
            pos = this.add__rest(pos, level, spUpgradeInfo.__rest);
            pos = this.add_lineAt(pos,level,  "ErrorFile", HMS.SP.SPUtil.toString(spUpgradeInfo.ErrorFile_)); //String;
            pos = this.add_lineAt(pos,level,  "Errors", HMS.SP.SPUtil.toString(spUpgradeInfo.Errors_)); //Int32;
            pos = this.add_lineAt(pos,level,  "LastUpdated", HMS.SP.SPUtil.toString(spUpgradeInfo.LastUpdated_)); //DateTime;
            pos = this.add_lineAt(pos,level,  "LogFile", HMS.SP.SPUtil.toString(spUpgradeInfo.LogFile_)); //String;
            pos = this.add_lineAt(pos,level,  "RequestDate", HMS.SP.SPUtil.toString(spUpgradeInfo.RequestDate_)); //DateTime;
            pos = this.add_lineAt(pos,level,  "RetryCount", HMS.SP.SPUtil.toString(spUpgradeInfo.RetryCount_)); //Int32;
            pos = this.add_lineAt(pos,level,  "StartTime", HMS.SP.SPUtil.toString(spUpgradeInfo.StartTime_)); //DateTime;
            pos = this.add_lineAt(pos,level,  "Status", HMS.SP.SPUtil.toString(spUpgradeInfo.Status_)); //Int32;
            pos = this.add_lineAt(pos,level,  "UpgradeType", HMS.SP.SPUtil.toString(spUpgradeInfo.UpgradeType_)); //Int32;
            pos = this.add_lineAt(pos,level,  "Warnings", HMS.SP.SPUtil.toString(spUpgradeInfo.Warnings_)); //Int32;
            return pos;
        }
        public int add_UpgradeInfo_deferred(int pos, int level, HMS.SP.UpgradeInfo spUpgradeInfo)
        {
            {
                string useUrl = spUpgradeInfo.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "UpgradeInfo","", knownPages.pageUpgradeInfo, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "UpgradeInfo", "",knownPages.NONE, "");
                    pos = this.add_UpgradeInfo(pos, level+1, spUpgradeInfo);
                }
            }
        return pos;
        }
    }
}

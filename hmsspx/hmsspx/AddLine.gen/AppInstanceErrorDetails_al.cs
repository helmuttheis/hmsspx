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
        public int add_AppInstanceErrorDetails(int level, HMS.SP.AppInstanceErrorDetails spAppInstanceErrorDetails)
        {
            return add_AppInstanceErrorDetails(-1, level, spAppInstanceErrorDetails);
        }
        public int  add_AppInstanceErrorDetails(int pos, int level, HMS.SP.AppInstanceErrorDetails spAppInstanceErrorDetails)
        {
            if (spAppInstanceErrorDetails.__HMSError_ != null && (spAppInstanceErrorDetails.__HMSError_.errno != 0 || spAppInstanceErrorDetails.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spAppInstanceErrorDetails.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spAppInstanceErrorDetails.__deferred_);
            pos = this.add__metadata(pos, level, spAppInstanceErrorDetails.__metadata_);
            pos = this.add__rest(pos, level, spAppInstanceErrorDetails.__rest);
            pos = this.add_lineAt(pos,level,  "CorrelationId", HMS.SP.SPUtil.toString(spAppInstanceErrorDetails.CorrelationId_)); //Object;
            pos = this.add_lineAt(pos,level,  "ErrorDetail", HMS.SP.SPUtil.toString(spAppInstanceErrorDetails.ErrorDetail_)); //Object;
            pos = this.add_lineAt(pos,level,  "ErrorType", HMS.SP.SPUtil.toString(spAppInstanceErrorDetails.ErrorType_)); //Object;
            pos = this.add_lineAt(pos,level,  "ErrorTypeName", HMS.SP.SPUtil.toString(spAppInstanceErrorDetails.ErrorTypeName_)); //Object;
            pos = this.add_lineAt(pos,level,  "ExceptionMessage", HMS.SP.SPUtil.toString(spAppInstanceErrorDetails.ExceptionMessage_)); //Object;
            pos = this.add_lineAt(pos,level,  "Source", HMS.SP.SPUtil.toString(spAppInstanceErrorDetails.Source_)); //Object;
            pos = this.add_lineAt(pos,level,  "SourceName", HMS.SP.SPUtil.toString(spAppInstanceErrorDetails.SourceName_)); //Object;
            return pos;
        }
        public int add_AppInstanceErrorDetails_deferred(int pos, int level, HMS.SP.AppInstanceErrorDetails spAppInstanceErrorDetails)
        {
            {
                string useUrl = spAppInstanceErrorDetails.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "AppInstanceErrorDetails","", knownPages.pageAppInstanceErrorDetails, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "AppInstanceErrorDetails", "",knownPages.NONE, "");
                    pos = this.add_AppInstanceErrorDetails(pos, level+1, spAppInstanceErrorDetails);
                }
            }
        return pos;
        }
    }
}

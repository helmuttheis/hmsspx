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
        public int add_Attachment(int level, HMS.SP.Attachment spAttachment)
        {
            return add_Attachment(-1, level, spAttachment);
        }
        public int  add_Attachment(int pos, int level, HMS.SP.Attachment spAttachment)
        {
            if (spAttachment.__HMSError_ != null && (spAttachment.__HMSError_.errno != 0 || spAttachment.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spAttachment.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spAttachment.__deferred_);
            pos = this.add__metadata(pos, level, spAttachment.__metadata_);
            pos = this.add__rest(pos, level, spAttachment.__rest);
            pos = this.add_lineAt(pos,level,  "FileName", HMS.SP.SPUtil.toString(spAttachment.FileName_)); //Object;
            pos = this.add_lineAt(pos,level,  "ServerRelativeUrl", HMS.SP.SPUtil.toString(spAttachment.ServerRelativeUrl_)); //String;
            return pos;
        }
        public int add_Attachment_deferred(int pos, int level, HMS.SP.Attachment spAttachment)
        {
            {
                string useUrl = spAttachment.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "Attachment","", knownPages.pageAttachment, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "Attachment", "",knownPages.NONE, "");
                    pos = this.add_Attachment(pos, level+1, spAttachment);
                }
            }
        return pos;
        }
    }
}

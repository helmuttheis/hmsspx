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
        public int add_AttachmentCreationInformation(int level, HMS.SP.AttachmentCreationInformation spAttachmentCreationInformation)
        {
            return add_AttachmentCreationInformation(-1, level, spAttachmentCreationInformation);
        }
        public int  add_AttachmentCreationInformation(int pos, int level, HMS.SP.AttachmentCreationInformation spAttachmentCreationInformation)
        {
            if (spAttachmentCreationInformation.__HMSError_ != null && (spAttachmentCreationInformation.__HMSError_.errno != 0 || spAttachmentCreationInformation.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spAttachmentCreationInformation.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spAttachmentCreationInformation.__deferred_);
            pos = this.add__metadata(pos, level, spAttachmentCreationInformation.__metadata_);
            pos = this.add__rest(pos, level, spAttachmentCreationInformation.__rest);
            pos = this.add_lineAt(pos,level,  "ContentStream", HMS.SP.SPUtil.toString(spAttachmentCreationInformation.ContentStream_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "FileName", HMS.SP.SPUtil.toString(spAttachmentCreationInformation.FileName_)); //Object;
            pos = this.add_lineAt(pos,level,  "TypeId", HMS.SP.SPUtil.toString(spAttachmentCreationInformation.TypeId_)); //String;
            return pos;
        }
        public int add_AttachmentCreationInformation_deferred(int pos, int level, HMS.SP.AttachmentCreationInformation spAttachmentCreationInformation)
        {
            {
                string useUrl = spAttachmentCreationInformation.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "AttachmentCreationInformation","", knownPages.pageAttachmentCreationInformation, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "AttachmentCreationInformation", "",knownPages.NONE, "");
                    pos = this.add_AttachmentCreationInformation(pos, level+1, spAttachmentCreationInformation);
                }
            }
        return pos;
        }
    }
}

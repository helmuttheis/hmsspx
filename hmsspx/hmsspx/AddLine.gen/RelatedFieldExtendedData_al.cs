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
        public int add_RelatedFieldExtendedData(int level, HMS.SP.RelatedFieldExtendedData spRelatedFieldExtendedData)
        {
            return add_RelatedFieldExtendedData(-1, level, spRelatedFieldExtendedData);
        }
        public int  add_RelatedFieldExtendedData(int pos, int level, HMS.SP.RelatedFieldExtendedData spRelatedFieldExtendedData)
        {
            if (spRelatedFieldExtendedData.__HMSError_ != null && (spRelatedFieldExtendedData.__HMSError_.errno != 0 || spRelatedFieldExtendedData.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spRelatedFieldExtendedData.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spRelatedFieldExtendedData.__deferred_);
            pos = this.add__metadata(pos, level, spRelatedFieldExtendedData.__metadata_);
            pos = this.add__rest(pos, level, spRelatedFieldExtendedData.__rest);
            pos = this.add_lineAt(pos,level,  "FieldId", HMS.SP.SPUtil.toString(spRelatedFieldExtendedData.FieldId_)); //Guid;
            pos = this.add_lineAt(pos,level,  "ListId", HMS.SP.SPUtil.toString(spRelatedFieldExtendedData.ListId_)); //Guid;
            pos = this.add_lineAt(pos,level,  "ListImageUrl", HMS.SP.SPUtil.toString(spRelatedFieldExtendedData.ListImageUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "ResolvedListTitle", HMS.SP.SPUtil.toString(spRelatedFieldExtendedData.ResolvedListTitle_)); //String;
            pos = this.add_lineAt(pos,level,  "ToolTipDescription", HMS.SP.SPUtil.toString(spRelatedFieldExtendedData.ToolTipDescription_)); //String;
            pos = this.add_lineAt(pos,level,  "WebId", HMS.SP.SPUtil.toString(spRelatedFieldExtendedData.WebId_)); //Guid;
            return pos;
        }
        public int add_RelatedFieldExtendedData_deferred(int pos, int level, HMS.SP.RelatedFieldExtendedData spRelatedFieldExtendedData)
        {
            {
                string useUrl = spRelatedFieldExtendedData.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "RelatedFieldExtendedData","", knownPages.pageRelatedFieldExtendedData, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "RelatedFieldExtendedData", "",knownPages.NONE, "");
                    pos = this.add_RelatedFieldExtendedData(pos, level+1, spRelatedFieldExtendedData);
                }
            }
        return pos;
        }
    }
}

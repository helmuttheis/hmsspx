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
        public int add_FileVersion(int level, HMS.SP.FileVersion spFileVersion)
        {
            return add_FileVersion(-1, level, spFileVersion);
        }
        public int  add_FileVersion(int pos, int level, HMS.SP.FileVersion spFileVersion)
        {
            if (spFileVersion.__HMSError_ != null && (spFileVersion.__HMSError_.errno != 0 || spFileVersion.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spFileVersion.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spFileVersion.__deferred_);
            pos = this.add__metadata(pos, level, spFileVersion.__metadata_);
            pos = this.add__rest(pos, level, spFileVersion.__rest);
            pos = this.add_lineAt(pos,level,  "CheckInComment", HMS.SP.SPUtil.toString(spFileVersion.CheckInComment_)); //String;
            pos = this.add_lineAt(pos,level,  "Created", HMS.SP.SPUtil.toString(spFileVersion.Created_)); //Object;
            pos = this.add_deferredAt(pos,level, "CreatedBy", "...", knownPages.pageUser , spFileVersion.CreatedBy_.__deferred_); //User;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spFileVersion.Id_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "IsCurrentVersion", HMS.SP.SPUtil.toString(spFileVersion.IsCurrentVersion_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Size", HMS.SP.SPUtil.toString(spFileVersion.Size_)); //Number;
            pos = this.add_lineAt(pos,level,  "Url", HMS.SP.SPUtil.toString(spFileVersion.Url_)); //String;
            pos = this.add_lineAt(pos,level,  "VersionLabel", HMS.SP.SPUtil.toString(spFileVersion.VersionLabel_)); //String;
            return pos;
        }
        public int add_FileVersion_deferred(int pos, int level, HMS.SP.FileVersion spFileVersion)
        {
            {
                string useUrl = spFileVersion.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "FileVersion","", knownPages.pageFileVersion, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "FileVersion", "",knownPages.NONE, "");
                    pos = this.add_FileVersion(pos, level+1, spFileVersion);
                }
            }
        return pos;
        }
    }
}

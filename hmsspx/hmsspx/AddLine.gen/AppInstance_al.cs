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
        public int add_AppInstance(int level, HMS.SP.AppInstance spAppInstance)
        {
            return add_AppInstance(-1, level, spAppInstance);
        }
        public int  add_AppInstance(int pos, int level, HMS.SP.AppInstance spAppInstance)
        {
            if (spAppInstance.__HMSError_ != null && (spAppInstance.__HMSError_.errno != 0 || spAppInstance.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spAppInstance.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spAppInstance.__deferred_);
            pos = this.add__metadata(pos, level, spAppInstance.__metadata_);
            pos = this.add__rest(pos, level, spAppInstance.__rest);
            pos = this.add_lineAt(pos,level,  "AppPrincipalId", HMS.SP.SPUtil.toString(spAppInstance.AppPrincipalId_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "AppWebFullUrl", HMS.SP.SPUtil.toString(spAppInstance.AppWebFullUrl_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spAppInstance.Id_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "InError", HMS.SP.SPUtil.toString(spAppInstance.InError_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "RemoteAppUrl", HMS.SP.SPUtil.toString(spAppInstance.RemoteAppUrl_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "SettingsPageUrl", HMS.SP.SPUtil.toString(spAppInstance.SettingsPageUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "SiteId", HMS.SP.SPUtil.toString(spAppInstance.SiteId_)); //Guid;
            pos = this.add_lineAt(pos,level,  "StartPage", HMS.SP.SPUtil.toString(spAppInstance.StartPage_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "Status", HMS.SP.SPUtil.toString(spAppInstance.Status_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spAppInstance.Title_)); //String;
            pos = this.add_lineAt(pos,level,  "WebId", HMS.SP.SPUtil.toString(spAppInstance.WebId_)); //Guid;
            return pos;
        }
        public int add_AppInstance_deferred(int pos, int level, HMS.SP.AppInstance spAppInstance)
        {
            {
                string useUrl = spAppInstance.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "AppInstance","", knownPages.pageAppInstance, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "AppInstance", "",knownPages.NONE, "");
                    pos = this.add_AppInstance(pos, level+1, spAppInstance);
                }
            }
        return pos;
        }
    }
}

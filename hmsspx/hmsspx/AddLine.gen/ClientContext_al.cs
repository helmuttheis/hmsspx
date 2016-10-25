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
        public int add_ClientContext(int level, HMS.SP.ClientContext spClientContext)
        {
            return add_ClientContext(-1, level, spClientContext);
        }
        public int  add_ClientContext(int pos, int level, HMS.SP.ClientContext spClientContext)
        {
            if (spClientContext.__HMSError_ != null && (spClientContext.__HMSError_.errno != 0 || spClientContext.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spClientContext.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spClientContext.__deferred_);
            pos = this.add__metadata(pos, level, spClientContext.__metadata_);
            pos = this.add__rest(pos, level, spClientContext.__rest);
            pos = this.add_lineAt(pos,level,  "ApplicationName", HMS.SP.SPUtil.toString(spClientContext.ApplicationName_)); //String;
            pos = this.add_deferredAt(pos,level, "Current", "...", knownPages.pageClientContext , spClientContext.Current_.__deferred_); //ClientContext;
            pos = this.add_lineAt(pos,level,  "FormDigestHandlingEnabled", HMS.SP.SPUtil.toString(spClientContext.FormDigestHandlingEnabled_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "HasPendingRequest", HMS.SP.SPUtil.toString(spClientContext.HasPendingRequest_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "PendingRequest", HMS.SP.SPUtil.toString(spClientContext.PendingRequest_)); //ClientRequest;
            pos = this.add_lineAt(pos,level,  "RequestTimeout", HMS.SP.SPUtil.toString(spClientContext.RequestTimeout_)); //int;
            pos = this.add_lineAt(pos,level,  "ServerLibraryVersion", HMS.SP.SPUtil.toString(spClientContext.ServerLibraryVersion_)); //String;
            pos = this.add_lineAt(pos,level,  "ServerSchemaVersion", HMS.SP.SPUtil.toString(spClientContext.ServerSchemaVersion_)); //String;
            pos = this.add_lineAt(pos,level,  "ServerVersion", HMS.SP.SPUtil.toString(spClientContext.ServerVersion_)); //String;
            pos = this.add_deferredAt(pos,level, "Site", "...", knownPages.pageSite , spClientContext.Site_.__deferred_); //Site;
            pos = this.add_lineAt(pos,level,  "TraceCorrelationId", HMS.SP.SPUtil.toString(spClientContext.TraceCorrelationId_)); //String;
            pos = this.add_lineAt(pos,level,  "Url", HMS.SP.SPUtil.toString(spClientContext.Url_)); //String;
            pos = this.add_deferredAt(pos,level, "Web", "...", knownPages.pageWeb , spClientContext.Web_.__deferred_); //Web;
            return pos;
        }
        public int add_ClientContext_deferred(int pos, int level, HMS.SP.ClientContext spClientContext)
        {
            {
                string useUrl = spClientContext.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "ClientContext","", knownPages.pageClientContext, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "ClientContext", "",knownPages.NONE, "");
                    pos = this.add_ClientContext(pos, level+1, spClientContext);
                }
            }
        return pos;
        }
    }
}

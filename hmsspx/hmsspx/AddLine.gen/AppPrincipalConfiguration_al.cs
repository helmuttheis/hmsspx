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
        public int add_AppPrincipalConfiguration(int level, HMS.SP.AppPrincipalConfiguration spAppPrincipalConfiguration)
        {
            return add_AppPrincipalConfiguration(-1, level, spAppPrincipalConfiguration);
        }
        public int  add_AppPrincipalConfiguration(int pos, int level, HMS.SP.AppPrincipalConfiguration spAppPrincipalConfiguration)
        {
            if (spAppPrincipalConfiguration.__HMSError_ != null && (spAppPrincipalConfiguration.__HMSError_.errno != 0 || spAppPrincipalConfiguration.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spAppPrincipalConfiguration.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spAppPrincipalConfiguration.__deferred_);
            pos = this.add__metadata(pos, level, spAppPrincipalConfiguration.__metadata_);
            pos = this.add__rest(pos, level, spAppPrincipalConfiguration.__rest);
            pos = this.add_lineAt(pos,level,  "ApplicationEndpointAuthorities", HMS.SP.SPUtil.toString(spAppPrincipalConfiguration.ApplicationEndpointAuthorities_)); //String;
            pos = this.add_lineAt(pos,level,  "ApplicationPrincipalNames", HMS.SP.SPUtil.toString(spAppPrincipalConfiguration.ApplicationPrincipalNames_)); //String;
            pos = this.add_lineAt(pos,level,  "NameIdentifier", HMS.SP.SPUtil.toString(spAppPrincipalConfiguration.NameIdentifier_)); //String;
            pos = this.add_lineAt(pos,level,  "RedirectAddresses", HMS.SP.SPUtil.toString(spAppPrincipalConfiguration.RedirectAddresses_)); //String;
            return pos;
        }
        public int add_AppPrincipalConfiguration_deferred(int pos, int level, HMS.SP.AppPrincipalConfiguration spAppPrincipalConfiguration)
        {
            {
                string useUrl = spAppPrincipalConfiguration.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "AppPrincipalConfiguration","", knownPages.pageAppPrincipalConfiguration, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "AppPrincipalConfiguration", "",knownPages.NONE, "");
                    pos = this.add_AppPrincipalConfiguration(pos, level+1, spAppPrincipalConfiguration);
                }
            }
        return pos;
        }
    }
}

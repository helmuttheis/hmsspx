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
        public int add_ExternalAppPrincipalCreationParameters(int level, HMS.SP.ExternalAppPrincipalCreationParameters spExternalAppPrincipalCreationParameters)
        {
            return add_ExternalAppPrincipalCreationParameters(-1, level, spExternalAppPrincipalCreationParameters);
        }
        public int  add_ExternalAppPrincipalCreationParameters(int pos, int level, HMS.SP.ExternalAppPrincipalCreationParameters spExternalAppPrincipalCreationParameters)
        {
            if (spExternalAppPrincipalCreationParameters.__HMSError_ != null && (spExternalAppPrincipalCreationParameters.__HMSError_.errno != 0 || spExternalAppPrincipalCreationParameters.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spExternalAppPrincipalCreationParameters.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spExternalAppPrincipalCreationParameters.__deferred_);
            pos = this.add__metadata(pos, level, spExternalAppPrincipalCreationParameters.__metadata_);
            pos = this.add__rest(pos, level, spExternalAppPrincipalCreationParameters.__rest);
            pos = this.add_lineAt(pos,level,  "AppIdentifier", HMS.SP.SPUtil.toString(spExternalAppPrincipalCreationParameters.AppIdentifier_)); //String;
            pos = this.add_lineAt(pos,level,  "ApplicationEndpointAuthorities", HMS.SP.SPUtil.toString(spExternalAppPrincipalCreationParameters.ApplicationEndpointAuthorities_)); //String;
            pos = this.add_lineAt(pos,level,  "DisplayName", HMS.SP.SPUtil.toString(spExternalAppPrincipalCreationParameters.DisplayName_)); //String;
            pos = this.add_lineAt(pos,level,  "RedirectAddresses", HMS.SP.SPUtil.toString(spExternalAppPrincipalCreationParameters.RedirectAddresses_)); //String;
            pos = this.add_lineAt(pos,level,  "TrustedForDelegation", HMS.SP.SPUtil.toString(spExternalAppPrincipalCreationParameters.TrustedForDelegation_)); //Boolean;
            return pos;
        }
        public int add_ExternalAppPrincipalCreationParameters_deferred(int pos, int level, HMS.SP.ExternalAppPrincipalCreationParameters spExternalAppPrincipalCreationParameters)
        {
            {
                string useUrl = spExternalAppPrincipalCreationParameters.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "ExternalAppPrincipalCreationParameters","", knownPages.pageExternalAppPrincipalCreationParameters, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "ExternalAppPrincipalCreationParameters", "",knownPages.NONE, "");
                    pos = this.add_ExternalAppPrincipalCreationParameters(pos, level+1, spExternalAppPrincipalCreationParameters);
                }
            }
        return pos;
        }
    }
}

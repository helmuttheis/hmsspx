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
        public int add_NavigationNodeCreationInformation(int level, HMS.SP.NavigationNodeCreationInformation spNavigationNodeCreationInformation)
        {
            return add_NavigationNodeCreationInformation(-1, level, spNavigationNodeCreationInformation);
        }
        public int  add_NavigationNodeCreationInformation(int pos, int level, HMS.SP.NavigationNodeCreationInformation spNavigationNodeCreationInformation)
        {
            if (spNavigationNodeCreationInformation.__HMSError_ != null && (spNavigationNodeCreationInformation.__HMSError_.errno != 0 || spNavigationNodeCreationInformation.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spNavigationNodeCreationInformation.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spNavigationNodeCreationInformation.__deferred_);
            pos = this.add__metadata(pos, level, spNavigationNodeCreationInformation.__metadata_);
            pos = this.add__rest(pos, level, spNavigationNodeCreationInformation.__rest);
            pos = this.add_lineAt(pos,level,  "AsLastNode", HMS.SP.SPUtil.toString(spNavigationNodeCreationInformation.AsLastNode_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "IsExternal", HMS.SP.SPUtil.toString(spNavigationNodeCreationInformation.IsExternal_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spNavigationNodeCreationInformation.Title_)); //String;
            pos = this.add_lineAt(pos,level,  "Url", HMS.SP.SPUtil.toString(spNavigationNodeCreationInformation.Url_)); //String;
            return pos;
        }
        public int add_NavigationNodeCreationInformation_deferred(int pos, int level, HMS.SP.NavigationNodeCreationInformation spNavigationNodeCreationInformation)
        {
            if (spNavigationNodeCreationInformation.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "NavigationNodeCreationInformation", HMS.SP.SPUtil.toString(spNavigationNodeCreationInformation.Title_), knownPages.NONE,""); //String;
                pos = add_NavigationNodeCreationInformation(pos, level + 1, spNavigationNodeCreationInformation);
            }
            else
            {
                string useUrl = spNavigationNodeCreationInformation.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spNavigationNodeCreationInformation.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spNavigationNodeCreationInformation.Title_, "", knownPages.pageNavigationNodeCreationInformation, useUrl);
            }
        return pos;
        }
    }
}

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
        public int add_NavigationNode(int level, HMS.SP.NavigationNode spNavigationNode)
        {
            return add_NavigationNode(-1, level, spNavigationNode);
        }
        public int  add_NavigationNode(int pos, int level, HMS.SP.NavigationNode spNavigationNode)
        {
            if (spNavigationNode.__HMSError_ != null && (spNavigationNode.__HMSError_.errno != 0 || spNavigationNode.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spNavigationNode.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spNavigationNode.__deferred_);
            pos = this.add__metadata(pos, level, spNavigationNode.__metadata_);
            pos = this.add__rest(pos, level, spNavigationNode.__rest);
            pos = this.add_deferredAt(pos,level, "Children", "...", myType.GetType("SP.NavigationNode"), spNavigationNode.Children_.__deferred_); //NavigationNode;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spNavigationNode.Id_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "IsDocLib", HMS.SP.SPUtil.toString(spNavigationNode.IsDocLib_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "IsExternal", HMS.SP.SPUtil.toString(spNavigationNode.IsExternal_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "IsVisible", HMS.SP.SPUtil.toString(spNavigationNode.IsVisible_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spNavigationNode.Title_)); //String;
            pos = this.add_lineAt(pos,level,  "Url", HMS.SP.SPUtil.toString(spNavigationNode.Url_)); //String;
            return pos;
        }
        public int add_NavigationNode_deferred(int pos, int level, HMS.SP.NavigationNode spNavigationNode)
        {
            {
                string useUrl = spNavigationNode.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "NavigationNode","", knownPages.pageNavigationNode, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "NavigationNode", "",knownPages.NONE, "");
                    pos = this.add_NavigationNode(pos, level+1, spNavigationNode);
                }
            }
        return pos;
        }
    }
}

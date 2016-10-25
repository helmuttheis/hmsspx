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
        public int add_MenuState(int level, HMS.SP.MenuState spMenuState)
        {
            return add_MenuState(-1, level, spMenuState);
        }
        public int  add_MenuState(int pos, int level, HMS.SP.MenuState spMenuState)
        {
            if (spMenuState.__HMSError_ != null && (spMenuState.__HMSError_.errno != 0 || spMenuState.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spMenuState.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spMenuState.__deferred_);
            pos = this.add__metadata(pos, level, spMenuState.__metadata_);
            pos = this.add__rest(pos, level, spMenuState.__rest);
            pos = this.add_lineAt(pos,level,  "FriendlyUrlPrefix", HMS.SP.SPUtil.toString(spMenuState.FriendlyUrlPrefix_)); //String;
            pos = this.add_linesAt(pos,level, "Nodes", spMenuState.Nodes_, Type.GetType("SP.MenuNode")); //MenuNode;
            pos = this.add_lineAt(pos,level,  "SimpleUrl", HMS.SP.SPUtil.toString(spMenuState.SimpleUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "SPSitePrefix", HMS.SP.SPUtil.toString(spMenuState.SPSitePrefix_)); //String;
            pos = this.add_lineAt(pos,level,  "SPWebPrefix", HMS.SP.SPUtil.toString(spMenuState.SPWebPrefix_)); //String;
            pos = this.add_lineAt(pos,level,  "StartingNodeKey", HMS.SP.SPUtil.toString(spMenuState.StartingNodeKey_)); //String;
            pos = this.add_lineAt(pos,level,  "StartingNodeTitle", HMS.SP.SPUtil.toString(spMenuState.StartingNodeTitle_)); //String;
            pos = this.add_lineAt(pos,level,  "Version", HMS.SP.SPUtil.toString(spMenuState.Version_)); //String;
            return pos;
        }
        public int add_MenuState_deferred(int pos, int level, HMS.SP.MenuState spMenuState)
        {
            {
                string useUrl = spMenuState.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "MenuState","", knownPages.pageMenuState, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "MenuState", "",knownPages.NONE, "");
                    pos = this.add_MenuState(pos, level+1, spMenuState);
                }
            }
        return pos;
        }
    }
}

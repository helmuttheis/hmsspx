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
        public int add_MenuNode(int level, HMS.SP.MenuNode spMenuNode)
        {
            return add_MenuNode(-1, level, spMenuNode);
        }
        public int  add_MenuNode(int pos, int level, HMS.SP.MenuNode spMenuNode)
        {
            if (spMenuNode.__HMSError_ != null && (spMenuNode.__HMSError_.errno != 0 || spMenuNode.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spMenuNode.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spMenuNode.__deferred_);
            pos = this.add__metadata(pos, level, spMenuNode.__metadata_);
            pos = this.add__rest(pos, level, spMenuNode.__rest);
            pos = this.add_linesAt(pos,level, "CustomProperties", spMenuNode.CustomProperties_, Type.GetType("SP.KeyValue")); //KeyValue;
            pos = this.add_lineAt(pos,level,  "FriendlyUrlSegment", HMS.SP.SPUtil.toString(spMenuNode.FriendlyUrlSegment_)); //String;
            pos = this.add_lineAt(pos,level,  "IsHidden", HMS.SP.SPUtil.toString(spMenuNode.IsHidden_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Key", HMS.SP.SPUtil.toString(spMenuNode.Key_)); //String;
            pos = this.add_linesAt(pos,level, "Nodes", spMenuNode.Nodes_, Type.GetType("SP.MenuNode")); //MenuNode;
            pos = this.add_lineAt(pos,level,  "NodeType", HMS.SP.SPUtil.toString(spMenuNode.NodeType_)); //Int32;
            pos = this.add_lineAt(pos,level,  "SimpleUrl", HMS.SP.SPUtil.toString(spMenuNode.SimpleUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spMenuNode.Title_)); //String;
            return pos;
        }
        public int add_MenuNode_deferred(int pos, int level, HMS.SP.MenuNode spMenuNode)
        {
            if (spMenuNode.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "MenuNode", HMS.SP.SPUtil.toString(spMenuNode.Title_), knownPages.NONE,""); //String;
                pos = add_MenuNode(pos, level + 1, spMenuNode);
            }
            else
            {
                string useUrl = spMenuNode.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spMenuNode.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spMenuNode.Title_, "", knownPages.pageMenuNode, useUrl);
            }
        return pos;
        }
    }
}

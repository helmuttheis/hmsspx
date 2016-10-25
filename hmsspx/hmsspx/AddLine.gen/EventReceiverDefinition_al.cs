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
        public int add_EventReceiverDefinition(int level, HMS.SP.EventReceiverDefinition spEventReceiverDefinition)
        {
            return add_EventReceiverDefinition(-1, level, spEventReceiverDefinition);
        }
        public int  add_EventReceiverDefinition(int pos, int level, HMS.SP.EventReceiverDefinition spEventReceiverDefinition)
        {
            if (spEventReceiverDefinition.__HMSError_ != null && (spEventReceiverDefinition.__HMSError_.errno != 0 || spEventReceiverDefinition.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spEventReceiverDefinition.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spEventReceiverDefinition.__deferred_);
            pos = this.add__metadata(pos, level, spEventReceiverDefinition.__metadata_);
            pos = this.add__rest(pos, level, spEventReceiverDefinition.__rest);
            pos = this.add_lineAt(pos,level,  "EventType", HMS.SP.SPUtil.toString(spEventReceiverDefinition.EventType_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "ReceiverAssembly", HMS.SP.SPUtil.toString(spEventReceiverDefinition.ReceiverAssembly_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "ReceiverClass", HMS.SP.SPUtil.toString(spEventReceiverDefinition.ReceiverClass_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "ReceiverId", HMS.SP.SPUtil.toString(spEventReceiverDefinition.ReceiverId_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "ReceiverName", HMS.SP.SPUtil.toString(spEventReceiverDefinition.ReceiverName_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "ReceiverUrl", HMS.SP.SPUtil.toString(spEventReceiverDefinition.ReceiverUrl_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "SequenceNumber", HMS.SP.SPUtil.toString(spEventReceiverDefinition.SequenceNumber_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "Synchronization", HMS.SP.SPUtil.toString(spEventReceiverDefinition.Synchronization_)); //Object;
            return pos;
        }
        public int add_EventReceiverDefinition_deferred(int pos, int level, HMS.SP.EventReceiverDefinition spEventReceiverDefinition)
        {
            {
                string useUrl = spEventReceiverDefinition.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "EventReceiverDefinition","", knownPages.pageEventReceiverDefinition, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "EventReceiverDefinition", "",knownPages.NONE, "");
                    pos = this.add_EventReceiverDefinition(pos, level+1, spEventReceiverDefinition);
                }
            }
        return pos;
        }
    }
}

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
using System.Collections.Generic;

namespace hmsspx
{
    partial class pageBase
    {
        public int add__generic(int level, HMS.SP.__generic spGeneric)
        {
            return add__generic(-1, level, spGeneric);
        }
        public int add__generic(int pos, int level, HMS.SP.__generic spGeneric)
        {
            pos = this.add_lineAt(pos, level, true, "_generic", "", knownPages.NONE, ""); //;
            int curNr = pos;
            if (spGeneric == null)
            {
            }
            else
            {
                if (spGeneric.__HMSError_ != null && (spGeneric.__HMSError_.errno != 0 || spGeneric.__HMSError_.info != ""))
                {
                    pos = this.add_lineAt(pos, level+1, "__HMSError", HMS.Util.__HMSError.toString(spGeneric.__HMSError_));
                }
                if (spGeneric.__deferred_ != null)
                    pos = this.add__deferred(pos, level + 1, spGeneric.__deferred_);
                if (spGeneric.__metadata_ != null)
                    pos = this.add__metadata(pos, level+1, spGeneric.__metadata_);
                pos = this.add__rest(pos, level + 1,  spGeneric.__rest); 
            }

            this.entryCollapse(curNr);
            return curNr; // pos
        }
        
    }
}

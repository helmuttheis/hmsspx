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
        public int add_FieldGeolocationValue(int level, HMS.SP.FieldGeolocationValue spFieldGeolocationValue)
        {
            return add_FieldGeolocationValue(-1, level, spFieldGeolocationValue);
        }
        public int  add_FieldGeolocationValue(int pos, int level, HMS.SP.FieldGeolocationValue spFieldGeolocationValue)
        {
            if (spFieldGeolocationValue.__HMSError_ != null && (spFieldGeolocationValue.__HMSError_.errno != 0 || spFieldGeolocationValue.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spFieldGeolocationValue.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spFieldGeolocationValue.__deferred_);
            pos = this.add__metadata(pos, level, spFieldGeolocationValue.__metadata_);
            pos = this.add__rest(pos, level, spFieldGeolocationValue.__rest);
            pos = this.add_lineAt(pos,level,  "Altitude", HMS.SP.SPUtil.toString(spFieldGeolocationValue.Altitude_)); //Double;
            pos = this.add_lineAt(pos,level,  "Latitude", HMS.SP.SPUtil.toString(spFieldGeolocationValue.Latitude_)); //Double;
            pos = this.add_lineAt(pos,level,  "Longitude", HMS.SP.SPUtil.toString(spFieldGeolocationValue.Longitude_)); //Double;
            pos = this.add_lineAt(pos,level,  "Measure", HMS.SP.SPUtil.toString(spFieldGeolocationValue.Measure_)); //Double;
            return pos;
        }
        public int add_FieldGeolocationValue_deferred(int pos, int level, HMS.SP.FieldGeolocationValue spFieldGeolocationValue)
        {
            {
                string useUrl = spFieldGeolocationValue.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "FieldGeolocationValue","", knownPages.pageFieldGeolocationValue, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "FieldGeolocationValue", "",knownPages.NONE, "");
                    pos = this.add_FieldGeolocationValue(pos, level+1, spFieldGeolocationValue);
                }
            }
        return pos;
        }
    }
}

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
        public int add__metadata(int level, HMS.SP.__metadata spMetadata)
        {
            return add__metadata(-1, level, spMetadata);
        }
        public int add__metadata(int pos, int level, HMS.SP.__metadata spMetadata)
        {
            pos = this.add_lineAt(pos, level,true, "__metadata", "",knownPages.NONE,""); //;
            int curNr = pos;
            if (spMetadata == null)
            {
            }
            else
            {
                pos = this.add_lineAt(pos, level + 1, "etag", HMS.SP.SPUtil.toString(spMetadata.etag_)); //;
                pos = this.add_lineAt(pos, level + 1, "id", HMS.SP.SPUtil.toString(spMetadata.id_)); //;
                pos = this.add_lineAt(pos, level + 1, "type", HMS.SP.SPUtil.toString(spMetadata.type_)); //;
                pos = this.add_lineAt(pos, level + 1, "uri", HMS.SP.SPUtil.toString(spMetadata.uri_)); //;
                if( !string.IsNullOrEmpty(spMetadata.rest))
                    pos = this.add_lineAt(pos, level + 1, "rest", HMS.SP.SPUtil.toString(spMetadata.rest)); //;
            }

            this.entryCollapse(curNr);
            return curNr; // pos
        }
        public int add__rest(int pos, int level, Dictionary<string,string> rest)
        {
            int curNr = pos;

            if (rest == null)
            {
            }
            else if (rest.Count == 0)
            {
            }
            else
            {
                pos = this.add_lineAt(pos, level, true, "__rest", "", knownPages.NONE, ""); //;
                curNr = pos;
                foreach (KeyValuePair<string,string> kv in rest)
                {
                    dynamic jobject = null;
                    try
                    {
                        jobject = Newtonsoft.Json.JsonConvert.DeserializeObject(kv.Value);
                    }
                    catch (Exception)
                    {
                    }
                    dynamic refObj = null;
                    try
                    {
                        refObj = jobject.__deferred;
                    }
                    catch (Exception)
                    {
                    }
                    if (refObj != null )
                    {
                        var __deferred_ = new HMS.SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj));
                        knownPages thisPage = knownPages.NONE;
                        string[] teile = __deferred_.uri.Split('/');
                        Enum.TryParse(teile[teile.Length-1],out thisPage);

                        pos = this.add_deferredAt(pos, level + 1, kv.Key, __deferred_.uri, thisPage, __deferred_); //;
                    }
                    else
                    {
                        
                        string val = HMS.SP.SPUtil.toString(kv.Value);
                        val = val.Replace("\r\n", " ");
                        val = val.Replace("\n", " ");
                        val = val.Replace("\r", " ");
                        pos = this.add_lineAt(pos, level + 1, kv.Key, val); //;
                    }
                }
                this.entryCollapse(curNr);
            }

            return curNr; // pos
        }
    }
}

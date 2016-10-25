/* **********************************************************************************************************
 * The MIT License (MIT)																					*
 * 																											*
 * Copyright (c) 2016 Hypermediasystems Ges. f. Software mbH										*
 * Web: http://www.hypermediasystems.de																		*
 * This file is part of hmssp																			*
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
using System.Dynamic;
using System.Reflection;
using Newtonsoft.Json;
namespace HMS.SP
{
    public class __metadata
    {
        [JsonProperty("id")]
        public string id_;

        [JsonProperty("uri")]
        public string uri_;

        [JsonProperty("etag")]
        public string etag_;

        [JsonProperty("type")]
        public string type_;

        public string rest;

        public __metadata(string json)
        {
            if (json == String.Empty)
                return;
            dynamic jobject = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            var refObj = jobject;

            if (jobject.d != null)
                refObj = jobject.d;
            if (jobject.__metadata != null)
                refObj = jobject.__metadata;

            // this.uri_ = refObj.uri.Value;
            // this.id_ = refObj.id.Value;
            // this.type_ = refObj.type.Value;
            // this.etag_ = refObj.etag.Value;


            HMS.SP.SPUtil.dyn_ValueSet("uri", refObj, this);
            HMS.SP.SPUtil.dyn_ValueSet("id", refObj, this);
            HMS.SP.SPUtil.dyn_ValueSet("type", refObj, this);
            HMS.SP.SPUtil.dyn_ValueSet("etag", refObj, this);
            var dyn = ((Newtonsoft.Json.Linq.JContainer)refObj).First;
            this.rest = "";
            while( dyn != null )
            {
                string Name = ((Newtonsoft.Json.Linq.JProperty)dyn).Name;
                string Value = ((Newtonsoft.Json.Linq.JProperty)dyn).Value.ToString();
                if( "[uri][id][type][etag]".IndexOf("[" + Name + "]") < 0 )
                    this.rest += Name + " = " + Value;
                dyn = dyn.Next;
            }

        }
    }
}
﻿/* **********************************************************************************************************
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
    public class __generic
    {
        [JsonProperty("__HMSError")]
        public HMS.Util.__HMSError __HMSError_ { set; get; }
        [JsonProperty("__deferred")]
        public SP.__deferred __deferred_ { set; get; }
        [JsonProperty("__metadata")]
        public SP.__metadata __metadata_ { set; get; }
        public Dictionary<string, string> __rest;

        public __generic(string json)
        {
            string errInfo = "";
            if (json == String.Empty)
                return;
            dynamic jobject = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            var refObj = jobject;

            if (jobject.d != null)
                refObj = jobject.d;
            if (refObj.results != null)
            {
                if (refObj.results.Count > 1)
                    errInfo = "Result is Collection, only 1. entry displayed.";
                refObj = refObj.results[0];
            }
            List<string> usedFields = new List<string>();

            if (refObj.__deferred != null )
                this.__deferred_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.__deferred));
            if (refObj.__metadata != null)
                this.__metadata_ = new SP.__metadata(HMS.SP.SPUtil.dyn_toString(refObj.__metadata));
            usedFields.Add("__deferred");
            usedFields.Add("__metadata");

            this.__rest = new Dictionary<string, string>();
            var dyn = ((Newtonsoft.Json.Linq.JContainer)refObj).First;
            while (dyn != null)
            {
                string Name = ((Newtonsoft.Json.Linq.JProperty)dyn).Name;
                string Value = ((Newtonsoft.Json.Linq.JProperty)dyn).Value.ToString();
                if (!usedFields.Contains(Name))
                    this.__rest.Add(Name, Value);
                dyn = dyn.Next;
            }

            if (errInfo != "")
            {
                this.__HMSError_ = new Util.__HMSError();
                this.__HMSError_.info = errInfo;
            }
        }
    }
}
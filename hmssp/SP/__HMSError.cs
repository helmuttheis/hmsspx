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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.SPxx
{
    public class __HMSError
    {
        public int errno;
        public string msg;
        public string info;
        public __HMSError()
        {

        }
        public __HMSError(string json)
        {
            this.errno = 0;
            this.msg = "";
            this.info = "";
            if (json == String.Empty)
                return;
            
            dynamic jobject = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            var refObj = jobject;

            if (jobject.d != null)
                refObj = jobject.d;
            if (jobject.__deferred != null)
                refObj = jobject.__HMSError;
            this.errno = -999;
            this.msg = "unknown ";
            this.info = "";
            if (refObj.errno != null )
                this.errno = (int)refObj.errno.Value;

            if (refObj.msg != null)
                this.msg = refObj.msg.Value;
        }

        public __HMSError(int errno, string msg)
        {
            this.errno = errno;
            this.msg = msg;
            this.info = "";
        }
        public static string toJSON(int errno, string msg)
        {
            return "{__HMSError: {\"errno\" : " + errno.ToString() + ", \"msg\" : \"" + msg + "\", \"info\" : \"\"}}";
        }
        public static string toJSON(int errno, string msg,string info)
        {
            return "{__HMSError: {\"errno\" : " + errno.ToString() + ", \"msg\" : \"" + msg + "\", \"info\" : \"" + info + "\"}}";
        }
        public static string toString(HMS.Util.__HMSError hmsError)
        {
            if (hmsError != null)
            {
                return hmsError.errno.ToString() + " "  + hmsError.msg + " " + hmsError.info;
            }
            return "unknown error";
        }
    }
}

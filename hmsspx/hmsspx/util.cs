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
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;

namespace hmsspx
{
    class myType
    {
        public static Type GetType(string typename)
        {
            if (!typename.StartsWith("HMS."))
                typename = "HMS." + typename;
            return Type.GetType(typename + ",hmssp");
        }
    }
    class util
    {
        private static string FullyQualifiedName = "";
        public static Boolean isUWP()
        {
#if WINDOWS_APP
            return true;
#else
            util.getFullyQualifiedName();
            return util.FullyQualifiedName.Contains(".UWP");
#endif
        }
        public static Boolean isWindowsPhone()
        {
#if WINDOWS_PHONE_APP
            return true;
#else
            util.getFullyQualifiedName();
            return util.FullyQualifiedName.Contains("SharedData\\PhoneTools");
#endif
        }
        private static void getFullyQualifiedName()
        {
            if( util.FullyQualifiedName == "" )
            {
                var assembly = typeof(HMS.SP.Web).GetTypeInfo().Assembly;
                util.FullyQualifiedName = assembly.ManifestModule.FullyQualifiedName;

            }
        }
        public static List<objEntry> dyn2list(ExpandoObject expObj)
        {
            List<objEntry> list = new List<objEntry>();

            addToDict(0, list, expObj);

            return list;
        }
        private static void addToDict(int level, List<objEntry> list, ExpandoObject expObj)
        {
            foreach (var prop in expObj)
            {
                string name = prop.Key;
                objEntry newEntry = new objEntry(level, name);
                list.Add(newEntry);
                if( prop.Value is ExpandoObject)
                {
                    addToDict(level + 1, list, (ExpandoObject)prop.Value);
                }
                else
                {
                    newEntry.value = prop.Value.ToString();
                }

            }
        }

    }
    class objEntry
    {
        public int level;
        public string name;
        public string value;
        public objEntry(int level, string name)
        {
            this.level = level;
            this.name = name;
        
        }
    }
#if false
    class myWebRequest : IDisposable
    {
        public Windows.Web.Http.HttpClient myClient;
        public Windows.Web.Http.Filters.HttpBaseProtocolFilter myFilter;
        public Windows.Web.Http.HttpRequestMessage myRequest;
        public Windows.Web.Http.HttpResponseMessage myResponse;
        // public WebResponse webResponse;
        public string lastError;
        public HttpStatusCode StatusCode;

        string userName;
        string password;
        string domain;
        public myWebRequest(string info, string url,string userName, string  password, string domain) : base()
        {
            string prefix = "";
            if (util.isUWP() || util.isWindowsPhone())
            {
                prefix = "UWP ";

                // this.DefaultRequestHeaders.Add("Connection", "close");               
            }
            // HMS 160826 this is important!!
            // this.DefaultRequestHeaders.Add("Connection", "keep-alive");
            // this.DefaultRequestHeaders.Add("X-HMSInfo", prefix + info);
            this.userName = userName;
            this.password = password;
            this.domain = domain;
            this.reset(info, url);
        }
        public void reset(string info, string url)
        {
            // webResponse = null;
            StatusCode = HttpStatusCode.Gone;

            myFilter = new Windows.Web.Http.Filters.HttpBaseProtocolFilter();
            myFilter.ServerCredential = new Windows.Security.Credentials.PasswordCredential(url,this.userName,this.password);
            myFilter.AllowAutoRedirect = false;

            myRequest = new Windows.Web.Http.HttpRequestMessage();
            myRequest.Headers.Add("X-HeaderKey", "HeaderValue");

            // Read more at https://blogs.windows.com/buildingapps/2015/11/23/demystifying-httpclient-apis-in-the-universal-windows-platform/#GU50VYYlYurlkYgj.99
            myClient = new Windows.Web.Http.HttpClient(myFilter);
                        
            setHeader("Connection", "keep-alive");
            setHeader("accept", "application/json");
            setHeader("CacheControl", "no-cache");

            // setHeader("accept", "odata=verbose");
        }
        public static TaskAwaiter GetAwaiter<TProgress>(this IAsyncActionWithProgress<Windows.Web.Http.HttpResponseMessage,TProgress> source)
        {
            return WindowsRuntimeSystemExtensions.AsTask(source).GetAwaiter();
        }
        public async Task<WebResponse> GetResponseAsync()
        {

            Windows.Web.Http.HttpCompletionOption comOption = Windows.Web.Http.HttpCompletionOption.ResponseContentRead;

            try
            {
                var waitTask = await this.GetAwaiter(myClient.SendRequestAsync(myRequest, comOption));
                HttpResponseMessage response = await waitTask.re;
                this.StatusCode = HttpStatusCode.OK;
            }
            catch (WebException ex)
            {
                if (ex.Message.ToLower().Contains("unauthorized"))
                    this.StatusCode = HttpStatusCode.Unauthorized; //  (int)ex.Status;
                else
                    this.StatusCode = HttpStatusCode.BadRequest; //  (int)ex.Status;
            }


            return null;
        }
        public void setHeaderXXX(HttpRequestHeader type, string str)
        {
            var headers = myClient.DefaultRequestHeaders;

            
            switch (type)
            {
            }
        }
        public void setHeader(string name, string str)
        {
            myClient.DefaultRequestHeaders.Add(name, str);


        }
        public string getHeader(HttpRequestHeader type)
        {
            string ret = "";
            var headers = myResponse.Headers;
            try
            {
                ret = headers[type].ToString();

            }
            catch (Exception)
            {
            }

            return ret;
        }
        public string getHeader(string name)
        {
            string ret = "";
            var headers = myResponse.Headers;
            try
            {
                ret = headers[name].ToString();
            }
            catch (Exception)
            {
            }

            return ret;
        }
        public async string getData()
        {
            var ret = await myResponse.Content.ReadAsStringAsync();

            return "" ;
        }
        public void Dispose()
        {
            if (myClient != null)
            {
                myClient.Dispose();
            }
        }
    }
#endif

    class myWebRequestxx :IDisposable
    {
        public HttpWebRequest webRequest;
        public WebResponse webResponse;
        public string lastError;
        public HttpStatusCode StatusCode;
        public myWebRequestxx(string info, string url) : base()
        {
            string prefix = "";
            if (util.isUWP() || util.isWindowsPhone())
            {
                prefix = "UWP ";
                
                // this.DefaultRequestHeaders.Add("Connection", "close");               
            }
            // HMS 160826 this is important!!
            // this.DefaultRequestHeaders.Add("Connection", "keep-alive");
            // this.DefaultRequestHeaders.Add("X-HMSInfo", prefix + info);
            this.reset(info, url);
        }
        public void reset(string info, string url)
        {
            webResponse = null;
            StatusCode = HttpStatusCode.Gone;
            webRequest = WebRequest.CreateHttp(url);
            HMS.SP.SPUtil.dyn_ValueSetBoolean("AllowAutoRedirect", webRequest, false);
            setHeader(HttpRequestHeader.Connection, "keep-alive");
            setHeader("accept", "application/json");
            webRequest.Headers[HttpRequestHeader.CacheControl] = "no-cache";
            
            // setHeader("accept", "odata=verbose");
        }
        public async Task<WebResponse> GetResponseAsync()
        {
            webResponse = null;
            try
            {
                webResponse = await webRequest.GetResponseAsync();
                this.StatusCode = HttpStatusCode.OK;
            }
            catch (WebException ex)
            {
                webResponse = ex.Response;
                if ( ex.Message.ToLower().Contains("unauthorized"))
                    this.StatusCode = HttpStatusCode.Unauthorized; //  (int)ex.Status;
                else
                    this.StatusCode = HttpStatusCode.BadRequest; //  (int)ex.Status;
            }

            
            return webResponse;
        }
        public void setHeader(HttpRequestHeader type, string str)
        {
            WebHeaderCollection headers = webRequest.Headers;

            switch (type)
            {
                case HttpRequestHeader.Accept:
                    webRequest.Accept = str;                    
                    break;
                default:
                    headers[type] = str;
                    break;
            }
        }
        public void setHeader(string name, string str)
        {
            if (name.ToUpper() == "ACCEPT")
                webRequest.Accept = str;
            else
            {
                WebHeaderCollection headers = webRequest.Headers;
                string[] teile = str.Split(';');
                for (int t = 0; t < teile.Length; t++)
                {
                    if (name.ToUpper() == "CONNECTION")
                        headers[HttpRequestHeader.Connection] = teile[t];
                    else
                    {
                        try
                        {
                            headers[name] = teile[t];
                        }
                        catch (Exception ex)
                        {

                            throw;
                        }
                    }
                }
            }

        }
        public string getHeader(HttpRequestHeader type)
        {
            string ret = "";
            WebHeaderCollection headers = webResponse.Headers;
            try
            {
                ret = headers[type].ToString();

            }
            catch (Exception)
            {
            }

            return ret;
        }
        public string getHeader(string name)
        {
            string ret = "";
            WebHeaderCollection headers = webResponse.Headers;
            try
            {
                ret = headers[name].ToString();
            }
            catch (Exception)
            {
            }

            return ret;
        }
        public string getData()
        {
            string ret = "";
            StreamReader streamReader = new StreamReader(webResponse.GetResponseStream(), true);
            try
            {
                ret = streamReader.ReadToEnd();
            }
            finally
            {
                streamReader.Dispose();
            }

            return ret;
        }
        public void Dispose()
        {
            if (webRequest != null)
            {
            }
        }
    }


    class myHttpClient : HttpClient
    {
        public string lastError = "";
        public myHttpClient(string info) : base()
        {
            string prefix = "";
            if (util.isUWP() || util.isWindowsPhone())
            {
                prefix = "UWP ";
                this.DefaultRequestHeaders.Add("Connection", "close");
            }
            this.DefaultRequestHeaders.Add("X-HMSInfo", prefix+ info);

        }
        public myHttpClient(string info, HttpClientHandler handler) : base(handler)
        {
            string prefix = "";
            if (util.isUWP() || util.isWindowsPhone() )
            {
                prefix = "UWP ";
                this.DefaultRequestHeaders.Remove("Connection");
                // this.DefaultRequestHeaders.Add("Connection", "close");               
            }
            // HMS 160826 this is important!!
            this.DefaultRequestHeaders.Add("Connection", "keep-alive");
            this.DefaultRequestHeaders.Add("X-HMSInfo", prefix + info);
            
        }
        
        public async Task<HttpResponseMessage> GetAsyncX(string requestUri)
        {
            lastError = "";
            try
            {
                return await this.GetAsync(requestUri);
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
                lastError = ex.Message + " ";
                if (ex.InnerException != null)
                {
                    if (ex.InnerException.Message != null)
                    {
                        lastError += " " + ex.InnerException.Message.ToString();
                    }
                    else
                    {
                        lastError += " " + ex.InnerException.ToString();

                    }

                }
                return response;
            }
        }
        public async Task<HttpResponseMessage> SendAsyncX(HttpRequestMessage request)
        {
            lastError = "";
            try
            {
                return await this.SendAsync(request);
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
                lastError = ex.Message + " " ;
                if(ex.InnerException != null )
                {
                    if (ex.InnerException.Message != null)
                    {
                        lastError += " " + ex.InnerException.Message.ToString();
                    }
                    else
                    {
                        lastError += " " + ex.InnerException.ToString();

                    }

                }
                return response;
            }
        }
    }
    public static class EnumerableExt
    {
        /// <summary>Concatenates a scalar to a sequence.</summary>
        /// <typeparam name="T">The type of elements in the sequence.</typeparam>
        /// <param name="sequence">a sequence.</param>
        /// <param name="item">The scalar item to concatenate to the sequence.</param>
        /// <returns>A sequence which has the specified item appended to it.</returns>
        /// <remarks>
        /// The standard .Net IEnumerable extensions includes a Concat() operator which concatenates a sequence to another sequence.
        /// However, it does not allow you to concat a scalar to a sequence. This operator provides that ability.
        /// </remarks>

        public static IEnumerable<T> Concat<T>(this IEnumerable<T> sequence, T item)
        {
            return sequence.Concat(new[] { item });
        }
    }
    
}

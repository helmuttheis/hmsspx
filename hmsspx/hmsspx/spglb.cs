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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using hmsspx;

namespace hmsspx
{
    partial class spglb
    {
        public static HMS.Auth.AppPlatform platform;
        public static HMS.Auth.Login myClient;
        public static HMS.SP.SPEndpoints.SPEndpoints spEndpoints;
        public static HMS.SP.SPMode mode = HMS.SP.SPMode.SP2010;

        public async void showConfirm(pageBase pb)
        {
            pageConfirm pc = new pageConfirm(false, "Frage", true);
            await pb.Navigation.PushAsync(pc);
            await pc.PageClosedTask; // Wait here until the SettingsPage is dismissed
        }
        public static void reinit(pageBase pb)
        {
            myClient = null;
            init(pb);
        }
        public static void init(pageBase pb)
        {
            if (myClient == null)
            {                
                try
                {
                    if ((Boolean)Application.Current.Properties["SPOnline.isSelected"] == true)
                        mode = HMS.SP.SPMode.SPOnline;
                    if ((Boolean)Application.Current.Properties["SP2010.isSelected"] == true)
                        mode = HMS.SP.SPMode.SP2010;
                    if ((Boolean)Application.Current.Properties["SP2016.isSelected"] == true)
                        mode = HMS.SP.SPMode.SP2016;
                }
                catch (Exception)
                {
                }
                if (mode == HMS.SP.SPMode.SPOnline)
                {
                    string baseurl = "https://DOMAIN.sharepoint.com/";
                    string userName = "USERNAME";
                    string password = "PASSWORD";

                    if (Application.Current.Properties.ContainsKey("SPOnline.server"))
                    {
                        baseurl = Application.Current.Properties["SPOnline.server"].ToString();
                    }
                    if (Application.Current.Properties.ContainsKey("SPOnline.user"))
                    {
                        userName = Application.Current.Properties["SPOnline.user"].ToString();
                    }
                    if (Application.Current.Properties.ContainsKey("SPOnline.password"))
                    {
                        password = Application.Current.Properties["SPOnline.password"].ToString();
                    }
                    // myClient = NETClient.SPOnline(baseurl, userName, password);
                    myClient = new HMS.Auth.LoginSPO(baseurl, userName, password);
                    spEndpoints = new HMS.SP.SPEndpoints.SPOnline();
                }
                else if (mode == HMS.SP.SPMode.SP2010)
                {
                    string baseurl = "http://win2008r2:12345/cm/";// this is an Intranet URL
                    string domain = "DOMAIN";
                    string userName = "USERNAME";
                    string password = "PASSWORD";
                    if (Application.Current.Properties.ContainsKey("SP2010.server"))
                    {
                        baseurl = Application.Current.Properties["SP2010.server"].ToString();
                    }
                    if (Application.Current.Properties.ContainsKey("SP2010.domain"))
                    {
                        domain = Application.Current.Properties["SP2010.domain"].ToString();
                    }
                    if (Application.Current.Properties.ContainsKey("SP2010.user"))
                    {
                        userName = Application.Current.Properties["SP2010.user"].ToString();
                    }
                    if (Application.Current.Properties.ContainsKey("SP2010.password"))
                    {
                        password = Application.Current.Properties["SP2010.password"].ToString();
                    }
                    // myClient = NETClient.SP2010(baseurl, domain, userName, password);
                    myClient = new HMS.Auth.LoginNTLM(baseurl, domain, userName, password);
                    spEndpoints = new HMS.SP.SPEndpoints.SP2010();
                }
                else if (mode == HMS.SP.SPMode.SP2016)
                {
                    string baseurl = "http://hmsspx/";// this is an Intranet URL
                    string domain = "DOMAIN";
                    string userName = "USERNAME";
                    string password = "PASSWORD";
                    if (Application.Current.Properties.ContainsKey("SP2016.server"))
                    {
                        baseurl = Application.Current.Properties["SP2016.server"].ToString();
                    }
                    if (Application.Current.Properties.ContainsKey("SP2016.domain"))
                    {
                        domain = Application.Current.Properties["SP2016.domain"].ToString();
                    }
                    if (Application.Current.Properties.ContainsKey("SP2016.user"))
                    {
                        userName = Application.Current.Properties["SP2016.user"].ToString();
                    }
                    if (Application.Current.Properties.ContainsKey("SP2016.password"))
                    {
                        password = Application.Current.Properties["SP2016.password"].ToString();
                    }
                    // myClient = NETClient.SP2016( baseurl, domain, userName, password);
                    myClient = new HMS.Auth.LoginNTLM(baseurl, domain, userName, password);
                    spEndpoints = new HMS.SP.SPEndpoints.SP2016();
                }
                else
                {
                    throw new Exception("not implemented");

                }
            }
            myClient.showProgress = pb.showProgress;
            myClient.setPlatform(spglb.platform);
        }

        public static void setPlatform(string strPlatform)
        {
            
            HMS.Auth.AppPlatform tmpPlatform;
            if (Enum.TryParse(strPlatform, out tmpPlatform) == true)
                platform = tmpPlatform;
        }


    }
}

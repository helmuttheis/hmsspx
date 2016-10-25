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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

// using Microsoft.SharePoint.Client;
using System.Reflection;


namespace hmsspx
{
    public class AppInfo
    {
        public enum appPlatform
        {
            iOS,
            Droid,
            Windows,
            WindowsPhone,
            UWP

        }
        public appPlatform platform;
        
        public AppInfo(appPlatform platform)
        {
            this.platform = platform;
        }
    }
    public class App : Application
    {
        /// <summary>
        /// initialize the app for the given platform
        /// </summary>
        /// <param name="appInfo"></param>
        public App(AppInfo appInfo)
        {
            init(appInfo, null);
        }
        /// <summary>
        /// initialize the app for the given platform <para/>
        /// hmsClient may replace the System.Net.HTTPClient. This is needed for UWP and POST requests.<para/>
        /// </summary>
        /// <param name="appInfo"></param>
        /// <param name="hmsClient"></param>
        public App(AppInfo appInfo, HMS.Auth.IHttpClient hmsClient)
        {
            init(appInfo, hmsClient);
        }
        private void init(AppInfo appInfo, HMS.Auth.IHttpClient hmsClient)
        {
            spglb.setPlatform(appInfo.platform.ToString());
            MainPage = new NavigationPage(new pageStart(false, hmsClient));
            ((NavigationPage)MainPage).Popped += (object sender, NavigationEventArgs e) =>
            {
                if (e.Page is pageSetup)
                {
                    // allow save()
                    ((pageSetup)e.Page).willClose();
                }
                else
                {
                    ((pageBase)(e.Page)).cancelRunningTask();
                }
                // update the status bar
                ((pageBase)((NavigationPage)MainPage).CurrentPage).setServerUser();
                ((pageBase)((NavigationPage)MainPage).CurrentPage).setPlatform(appInfo.platform.ToString());
                // ((pageBase)e.Page).setServerUser();

            };
            ((NavigationPage)MainPage).Pushed += (object sender, NavigationEventArgs e) =>
            {
                pageBase.NameWidth = (int)Application.Current.MainPage.Width / 3;
                // ((pageBase)e.Page).setServerUser();

            };
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
    public interface ISaveAndLoad
    {
        void SaveText(string filename, string text);
        string LoadText(string filename);
    }
}

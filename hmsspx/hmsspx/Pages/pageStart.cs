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
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace hmsspx
{
    class pageStart : pageBase
    {
        public static Page GetFormsApp()
        {
            NavigationPage navpage = null;
            return navpage = new NavigationPage(new ContentPage
            {
                Content = new Button
                {
                    Text = "Show Login dialog",
                    Command = new Command(async o => {
                        Debug.WriteLine("Showing sign in dialog");
                        var result = await SignInAsync(navpage);
                        Debug.WriteLine(result);
                    })
                }
            });
        }

        static Task<bool> SignInAsync(NavigationPage navpage)
        {
            Random rnd = new Random();
            var tcs = new TaskCompletionSource<bool>();
            navpage.Navigation.PushModalAsync(new ContentPage
            {
                Content = new Button
                {
                    Text = "Try login",
                    Command = new Command(o => {
                        var result = rnd.Next(2) == 1;
                        navpage.Navigation.PopModalAsync();
                        tcs.SetResult(result);
                    })
                }
            });
            return tcs.Task;
        }
        public pageStart(Boolean withListView, HMS.Auth.IHttpClient hmsClient) : base(withListView)
        {

            init(withListView, hmsClient);


            this.hide_running();
        }


        private void init(Boolean withListView, HMS.Auth.IHttpClient hmsClient)
        {
            // store the hmsClient
            HMS.Auth.haHttpClient.hmsClient = hmsClient;

            // this is a test for a modal dialog 
            Button btnDebug = this.createButton("Debug");
            btnDebug.Clicked += async (sender, e) =>
            {
                pageConfirm pc = new pageConfirm(false, "This is just a test for a modal dialog.", true);
                await Navigation.PushAsync(pc);
                await pc.PageClosedTask; // Wait here until the confirmPage is dismissed
                var ret = pc.Return;
                
            };

            Button btnBrowse = this.createButton("Browse");
            btnBrowse.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new pageBrowse(true));

            };
            Button btnSetup = this.createButton("Setup");
            btnSetup.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new pageSetup(false));

            };

            // create the left pane containig the buttons
            StackLayout btnLayout = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Vertical
            };
            btnLayout.Children.Add(btnDebug);
            btnLayout.Children.Add(btnBrowse);
            btnLayout.Children.Add(btnSetup);

            Label labelInfo = new Label();
            labelInfo.Text = "For more information about HMS see:";
            btnLayout.Children.Add(labelInfo);

            Label labelUri = new Label();
            labelUri.Text = "http://www.hypermediasystems.de/";
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                Device.OpenUri(new Uri(((Label)s).Text));
            };
            labelUri.GestureRecognizers.Add(tapGestureRecognizer);

            btnLayout.Children.Add(labelUri);


            base.contentStack.Children.Add(btnLayout);

            // Put the StackLayout in a ScrollView.         
            Content = base.mainStack;
            this.setServerUser();
            this.hide_running();
        }
    }
}

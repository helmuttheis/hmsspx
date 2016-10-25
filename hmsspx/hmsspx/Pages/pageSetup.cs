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

namespace hmsspx
{
    class pageSetup : pageBase
    {
        private Boolean needSave = false;
        private Dictionary<string, Entry> sp2010Entries = new Dictionary<string, Entry>();
        private Dictionary<string, Entry> sp2016Entries = new Dictionary<string, Entry>();
        private Dictionary<string, Entry> spOnlineEntries = new Dictionary<string, Entry>();

        private Dictionary<string, Entry> spGlobalEntries = new Dictionary<string, Entry>();

        

        StackLayout sp2010Layout = new StackLayout();
        StackLayout sp2016Layout = new StackLayout();
        StackLayout spOnlineLayout = new StackLayout();

        StackLayout spGlobalLayout = new StackLayout();

        Button btnSP2010;
        Button btnSP2016;
        Button btnSPOnline;
        Label lblResult;
        public pageSetup(Boolean withListView) : base(withListView)
        {
            // this is accessed in loadData()
            lblResult = this.createLabel("");
            StackLayout btnLayout = new StackLayout() {
                HorizontalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Horizontal
            };
            btnSP2010 = this.createButton("SharePoint 2010");
            btnSP2010.Clicked += (sender, e) =>
            {
                needSave = true;
                this.select_sp2010();
            };
            btnSP2016 = this.createButton("SharePoint 2016");
            btnSP2016.Clicked += (sender, e) =>
            {
                needSave = true;
                this.select_sp2016();
            };
            btnSPOnline = this.createButton("SharePoint Online");
            btnSPOnline.Clicked += (sender, e) =>
            {
                needSave = true;
                this.select_spOnline();
            };

            setup_sp2010Layout(sp2010Layout);
            setup_sp2016Layout(sp2016Layout);
            setup_spOnlineLayout(spOnlineLayout);

            setup_spGlobalLayout(spGlobalLayout);

            loadData();

            btnLayout.Children.Add(btnSP2010);
            btnLayout.Children.Add(btnSP2016);
            btnLayout.Children.Add(btnSPOnline);

            base.contentStack.Children.Add(btnLayout);

            base.contentStack.Children.Add(sp2010Layout);
            base.contentStack.Children.Add(sp2016Layout);
            base.contentStack.Children.Add(spOnlineLayout);

            base.contentStack.Children.Add(spGlobalLayout);

            Button btnSave = this.createButton("save");
            btnSave.Clicked += (sender, e) =>
            {
                saveData();
            };
            base.contentStack.Children.Add(btnSave);
            Button btnCheck = this.createButton("check");
            btnCheck.Clicked += (sender, e) =>
            {
                saveData();
                // checkData();
                checkDataBasic();
            };
            base.contentStack.Children.Add(btnCheck);
            base.contentStack.Children.Add(this.createLabel("Result:"));
            
            base.contentStack.Children.Add(lblResult);

            Button btnDefaults = this.createButton("defaults");
            btnDefaults.Clicked += (sender, e) =>
            {
                loadDefaults();
            };
            base.contentStack.Children.Add(btnDefaults);



            Content = base.mainStack;
            this.setServerUser();
            this.hide_running();

        }


        public void willClose()
        {
            if (needSave == true)
            {
                this.saveData();
            }
        }
        private void loadDefaults()
        {
            {
                // SPonline
                string baseurl = "https://hypermediasystems.sharepoint.com/";
                string userName = "heth@Hypermediasystems.onmicrosoft.com";
                string password = "F+ujR(KJM4";
                spOnlineEntries["server"].Text = baseurl;
                spOnlineEntries["user"].Text = userName;
                spOnlineEntries["password"].Text = password;
            }
            {
                // SP2010
                string baseurl = "http://win2008r2:12345/cm/";
                string domain = "asus02";
                string userName = "administrator";
                string password = "mds";
                sp2010Entries["server"].Text =baseurl;
                sp2010Entries["user"].Text = userName;
                sp2010Entries["domain"].Text = domain;
                sp2010Entries["password"].Text = password;
            }
            {
                // SP2016
                string baseurl = "http://13.95.223.137/"; //  hmsspx/";
                string domain = "hmsspx0";
                string userName = "helle";
                string password = "597526@Mds12";
                sp2016Entries["server"].Text = baseurl;
                sp2016Entries["user"].Text = userName;
                sp2016Entries["domain"].Text = domain;
                sp2016Entries["password"].Text = password;
            }
        }
        private void loadData()
        {
            
            foreach (KeyValuePair<string, Entry> entry in sp2010Entries)
            {
                if (Application.Current.Properties.ContainsKey("SP2010." + entry.Key))
                {
                    entry.Value.Text = Application.Current.Properties["SP2010." + entry.Key].ToString(); 
                }
            }
            foreach (KeyValuePair<string, Entry> entry in sp2016Entries)
            {
                if (Application.Current.Properties.ContainsKey("SP2016." + entry.Key))
                {
                    entry.Value.Text = Application.Current.Properties["SP2016." + entry.Key].ToString();
                }
            }
            foreach (KeyValuePair<string, Entry> entry in spOnlineEntries)
            {
                if (Application.Current.Properties.ContainsKey("SPOnline." + entry.Key))
                {
                    entry.Value.Text = Application.Current.Properties["SPOnline." + entry.Key].ToString();
                }
            }

            foreach (KeyValuePair<string, Entry> entry in spGlobalEntries)
            {
                if (Application.Current.Properties.ContainsKey("SPGlobal." + entry.Key))
                {
                    entry.Value.Text = Application.Current.Properties["SPGlobal." + entry.Key].ToString();
                }
            }


            try
            {
                if ((Boolean)Application.Current.Properties["SP2010.isSelected"] == true)
                    select_sp2010();
                if ((Boolean)Application.Current.Properties["SP2016.isSelected"] == true)
                    select_sp2016();
                if ((Boolean)Application.Current.Properties["SPOnline.isSelected"] == true)
                    select_spOnline();
            }
            catch (Exception)
            {
                select_sp2016();
            }

        }
        private async void checkData()
        {
            this.showProgress("Checking the login data ...");
#if false
            spglb.reinit(this);
            Boolean inited = await spglb.myClient.init();
            this.showProgress("");
            if (!inited)
            {
                lblResult.Text = DateTime.Now.ToString() + " could not connect with server." +Environment.NewLine + spglb.myClient.initError;
            }
            else
            {
                lblResult.Text = DateTime.Now.ToString() + " connected with server.";
            }
#else
            HMS.Auth.Login hmsLogin = null;
            HMS.SP.SPEndpoints.SPEndpoints spEP = null;
            
            if (spOnlineLayout.IsVisible == true)
            {
                hmsLogin = new HMS.Auth.LoginSPO(spOnlineEntries["server"].Text, spOnlineEntries["user"].Text, spOnlineEntries["password"].Text);
                spEP = new HMS.SP.SPEndpoints.SPOnline();
            }
            else if (sp2016Layout.IsVisible == true)
            {
                hmsLogin = new HMS.Auth.LoginNTLM(sp2016Entries["server"].Text, sp2016Entries["domain"].Text, sp2016Entries["user"].Text, sp2016Entries["password"].Text);
                spEP = new HMS.SP.SPEndpoints.SPOnline();
            }
            else if (sp2010Layout.IsVisible == true)
            {
                hmsLogin = new HMS.Auth.LoginNTLM(sp2010Entries["server"].Text, sp2010Entries["domain"].Text, sp2010Entries["user"].Text, sp2010Entries["password"].Text);
                spEP = new HMS.SP.SPEndpoints.SP2010();
                
            }
            if (hmsLogin != null)
            {
                hmsLogin.showProgress = showProgress;
                hmsLogin.setPlatform(this.platform);
                string ret = await hmsLogin.getJSON(spEP.Root);
                Boolean inited = hmsLogin.inited;
                this.showProgress("");
                if (!inited)
                {
                    lblResult.Text = DateTime.Now.ToString() + " could not connect with server." + Environment.NewLine + hmsLogin.initError;
                }
                else
                {
                    lblResult.Text = DateTime.Now.ToString() + " connected with server.";
                }
            }
            else
            {
                lblResult.Text = DateTime.Now.ToString() + " no server set.";

            }
#endif
        }
        private async void checkDataBasic()
        {
            this.showProgress("Checking the login data ...");

            // we need this call, if we want to access the SP namespace
            spglb.reinit(this);

            HMS.Auth.Login hmsLogin = null;
            HMS.SP.SPEndpoints.SPEndpoints spEP = null;

            
            hmsLogin = new HMS.Auth.LoginBasic("http://winxmap/basic/", "authtest", "hello@123");
            spEP = new HMS.SP.SPEndpoints.SPEndpoints();
            spEP.Root = "data.json";

            if (hmsLogin != null)
            {
                hmsLogin.showProgress = showProgress;
                hmsLogin.setPlatform(spglb.platform);
                string ret = await hmsLogin.getJSON(spEP.Root);
                Boolean inited = hmsLogin.inited;
                this.showProgress("");
                if (!inited)
                {
                    lblResult.Text = DateTime.Now.ToString() + " could not connect with server." + Environment.NewLine + hmsLogin.initError;
                }
                else
                {
                    lblResult.Text = DateTime.Now.ToString() + " connected with server.";
                }
            }
            else
            {
                lblResult.Text = DateTime.Now.ToString() + " no server set.";

            }

        }
        private void saveData()
        {
            foreach (KeyValuePair<string, Entry> entry in sp2010Entries)
            {
                Application.Current.Properties["SP2010." + entry.Key] = entry.Value.Text;
            }
            foreach (KeyValuePair<string, Entry> entry in sp2016Entries)
            {
                Application.Current.Properties["SP2016." + entry.Key] = entry.Value.Text;
            }

            foreach (KeyValuePair<string, Entry> entry in spOnlineEntries)
            {
                Application.Current.Properties["SPOnline." + entry.Key] = entry.Value.Text;
            }
            Application.Current.Properties["SP2010.isSelected"] = sp2010Layout.IsVisible;
            Application.Current.Properties["SP2016.isSelected"] = sp2016Layout.IsVisible;
            Application.Current.Properties["SPOnline.isSelected"] = spOnlineLayout.IsVisible;

            foreach (KeyValuePair<string, Entry> entry in spGlobalEntries)
            {
                Application.Current.Properties["SPGlobal." + entry.Key] = entry.Value.Text;
            }


            Application.Current.SavePropertiesAsync();
        }
        private void select_sp2010()
        {
            sp2010Layout.IsVisible = true;
            sp2016Layout.IsVisible = false;
            spOnlineLayout.IsVisible = false;
            btnSP2010.BackgroundColor = Color.Gray;
            btnSP2016.BackgroundColor = Color.Transparent;
            btnSPOnline.BackgroundColor = Color.Transparent;
            this.setServerUser("SP2010: " + sp2010Entries["server"].Text, sp2010Entries["user"].Text);
            this.setResult( "");
        }
        private void select_sp2016()
        {
            sp2010Layout.IsVisible = false;
            sp2016Layout.IsVisible = true;
            spOnlineLayout.IsVisible = false;
            btnSP2010.BackgroundColor = Color.Transparent;
            btnSP2016.BackgroundColor = Color.Gray;
            btnSPOnline.BackgroundColor = Color.Transparent;
            this.setServerUser("SP2016: " + sp2016Entries["server"].Text, sp2016Entries["user"].Text);
            this.setResult("");
        }
        private void select_spOnline()
        {
            sp2010Layout.IsVisible = false;
            sp2016Layout.IsVisible = false;
            spOnlineLayout.IsVisible = true;
            btnSP2010.BackgroundColor = Color.Transparent;
            btnSP2016.BackgroundColor = Color.Transparent;
            btnSPOnline.BackgroundColor = Color.Gray;

            this.setServerUser("SPOnline: " + spOnlineEntries["server"].Text, spOnlineEntries["user"].Text);
            this.setResult("");
        }
        public void setResult(string result)
        {
            lblResult.Text = result;

        }

        private Entry createLabelEntry(Dictionary<string, Entry> spEntries, StackLayout spLayout,string lbl, string tag, string placeholder, Boolean isPassword)
        {
            return createLabelEntry(spEntries, spLayout, lbl, tag, placeholder, isPassword, "");
        }
        private Entry createLabelEntry(Dictionary<string, Entry> spEntries, StackLayout spLayout, string lbl, string tag, string placeholder, Boolean isPassword, string def)
        {
            spLayout.Children.Add(this.createLabel(lbl));
            Entry newEntry = new Entry { Text = def, Placeholder = placeholder, IsPassword = isPassword };
            newEntry.TextChanged += (object sender, TextChangedEventArgs e) => { this.needSave = true; };
            spEntries.Add(tag, newEntry);// statt sp2010Entries
            spLayout.Children.Add(newEntry);

            return newEntry;
        }
        private void setup_sp2010Layout(StackLayout spLayout)
        {
            spLayout.Children.Add(this.createLabel("SharePoint 2010"));
            
            createLabelEntry(sp2010Entries, spLayout, "Server:","server", "Server URL", false);
            createLabelEntry(sp2010Entries, spLayout, "Domain:", "domain", "Domain", false);
            createLabelEntry(sp2010Entries, spLayout, "User:", "user", "Username", false);
            createLabelEntry(sp2010Entries, spLayout, "Password:", "password", "Password", false);

        }
        private void setup_spGlobalLayout(StackLayout spLayout)
        {
            spLayout.Children.Add(this.createLabel("Global settings"));

            createLabelEntry(spGlobalEntries, spLayout, "maxCollectionCount:", "maxCollectionCount", "", false,"50");

        }
        private void setup_sp2010Layoutxxx(StackLayout spLayout)
        {
            spLayout.Children.Add(this.createLabel("SharePoint 2010"));

            spLayout.Children.Add(this.createLabel("Server:"));
            Entry newEntry = new Entry { Text = "", Placeholder = "Server URL" };
            newEntry.TextChanged += (object sender, TextChangedEventArgs e) => { this.needSave = true; };
            sp2010Entries.Add("server", newEntry) ;
            spLayout.Children.Add(newEntry);

            spLayout.Children.Add(this.createLabel("Domain:"));
            newEntry = new Entry { Text = "", Placeholder = "Domain" };
            newEntry.TextChanged += (object sender, TextChangedEventArgs e) => { this.needSave = true; };

            sp2010Entries.Add("domain", newEntry); 
            spLayout.Children.Add(newEntry);

            spLayout.Children.Add(this.createLabel("User:"));
            newEntry = new Entry { Text = "", Placeholder = "Username" };
            newEntry.TextChanged += (object sender, TextChangedEventArgs e) => { this.needSave = true; };
            spLayout.Children.Add(newEntry);

            spLayout.Children.Add(this.createLabel("Password:"));
            newEntry = new Entry { Text = "", Placeholder = "Password" };
            newEntry.TextChanged += (object sender, TextChangedEventArgs e) => { this.needSave = true; };
            sp2010Entries.Add("password", newEntry); ;
            spLayout.Children.Add(newEntry);

        }

        

        private void setup_sp2016Layout(StackLayout spLayout)
        {
            spLayout.Children.Add(this.createLabel("SharePoint 2016"));
            spLayout.Children.Add(this.createLabel("Server:"));
            Entry newEntry = new Entry { Text = "", Placeholder = "Server URL" };
            newEntry.TextChanged += NewEntry_TextChanged;
            sp2016Entries.Add("server", new Entry { Text = "", Placeholder = "Server URL" }); ;
            spLayout.Children.Add(sp2016Entries["server"]);

            spLayout.Children.Add(this.createLabel("Domain:"));
            sp2016Entries.Add("domain", new Entry { Text = "", Placeholder = "Domain" }); ;
            spLayout.Children.Add(sp2016Entries["domain"]);

            spLayout.Children.Add(this.createLabel("User:"));
            sp2016Entries.Add("user", new Entry { Text = "", Placeholder = "Username" }); ;
            spLayout.Children.Add(sp2016Entries["user"]);

            spLayout.Children.Add(this.createLabel("Password:"));
            sp2016Entries.Add("password", new Entry { Text = "", Placeholder = "Password", IsPassword = true }); ;
            spLayout.Children.Add(sp2016Entries["password"]);
        }

        private void NewEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.needSave = true;
        }

        private void setup_spOnlineLayout(StackLayout spLayout)
        {
            spLayout.Children.Add(this.createLabel("SharePoint Online"));
            spLayout.Children.Add(this.createLabel("Server:"));
            spOnlineEntries.Add("server", new Entry { Text = "", Placeholder = "Server URL" }); ;
            spLayout.Children.Add(spOnlineEntries["server"]);

            spLayout.Children.Add(this.createLabel("User:"));
            spOnlineEntries.Add("user", new Entry { Text = "", Placeholder = "Username" }); ;
            spLayout.Children.Add(spOnlineEntries["user"]);

            spLayout.Children.Add(this.createLabel("Password:"));
            spOnlineEntries.Add("password", new Entry { Text = "", Placeholder = "Password", IsPassword = true }); ;
            spLayout.Children.Add(spOnlineEntries["password"]);
        }
    }
}

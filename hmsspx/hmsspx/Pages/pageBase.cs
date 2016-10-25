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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace hmsspx
{
    
    public partial class pageBase : ContentPage
    {
        enum line_part
        {
            nrLabel = 0,
            indentLabel,
            icon,
            nameLabel,
            valueLabel,
            uriLabel,
            nextPageLabel
        }
        private Boolean runningTask = false;
        private Boolean cancelTask = false;

        public static int TitleSize = 80;
        public static int NameWidth = 125;
        public enum knownPages
        {
            NONE,
            pageAccessRequests,
            pageAlternateUrl,
            pageApp,
            pageAppCatalog,
            pageAppContextSite,
            pageAppInstance,
            pageAppInstanceErrorDetails,
            pageAppLicense,
            pageAppPrincipalConfiguration,
            pageAppPrincipalCredentialReference,
            pageAttachment,
            pageAttachmentCreationInformation,
            pageBasePermissions,
            pageCamlQuery,
            pageChange,
            pageChangeAlert,
            pageChangeContentType,
            pageChangeField,
            pageChangeFile,
            pageChangeFolder,
            pageChangeGroup,
            pageChangeItem,
            pageChangeList,
            pageChangeLogItemQuery,
            pageChangeQuery,
            pageChangeToken,
            pageChangeUser,
            pageChangeView,
            pageChangeWeb,
            pageClientContext,
            pageContentType,
            pageContentTypeCreationInformation,
            pageContentTypeId,
            pageContextWebInformation,
            pageDocumentLibraryInformation,
            pageEventReceiverDefinition,
            pageEventReceiverDefinitionCreationInformation,
            pageExternalAppPrincipalCreationParameters,
            pageFeature,
            pageField,
            pageFieldCalculated,
            pageFieldCalculatedErrorValue,
            pageFieldChoice,
            pageFieldComputed,
            pageFieldCreationInformation,
            pageFieldCurrency,
            pageFieldDateTime,
            pageFieldGeolocationValue,
            pageFieldLink,
            pageFieldLinkCreationInformation,
            pageFieldLookup,
            pageFieldLookupValue,
            pageFieldMultiChoice,
            pageFieldMultiLineText,
            pageFieldNumber,
            pageFieldRatingScale,
            pageFieldRatingScaleQuestionAnswer,
            pageFieldStringValues,
            pageFieldText,
            pageFieldUrl,
            pageFieldUrlValue,
            pageFieldUser,
            pageFieldUserValue,
            pageFile,
            pageFileCreationInformation,
            pageFileSaveBinaryInformation,
            pageFileVersion,
            pageFolder,
            pageForm,
            pageGroup,
            pageGroupCreationInformation,
            pageImplementationnotes,
            pageInformationRightsManagementSettings,
            pageKeyValue,
            pageLanguage,
            pageList,
            pageListCreationInformation,
            pageListDataSource,
            pageListDataValidationExceptionValue,
            pageListDataValidationFailure,
            pageListItem,
            pageListItemCollectionPosition,
            pageListItemCreationInformation,
            pageListItemEntity,
            pageListItemFormUpdateValue,
            pageListTemplate,
            pageMenuNode,
            pageMenuState,
            pageNavigation,
            pageNavigationNode,
            pageNavigationNodeCreationInformation,
            pageObjectSharingInformation,
            pageObjectSharingInformationUser,
            pagePrincipal,
            pagePropertyValues,
            pagePushNotificationSubscriber,
            pageRecycleBinItem,
            pageRegionalSettings,
            pageRelatedField,
            pageRelatedFieldExtendedData,
            pageRelatedItem,
            pageRelatedItemManager,
            pageRenderListDataParameters,
            pageRequestContext,
            pageRequestVariable,
            pageRoleAssignment,
            pageRoleDefinition,
            pageRoleDefinitionBinding,
            pageRoleDefinitionCreationInformation,
            pageSecurableObject,
            pageServerSettings,
            pageSimpleDataRow,
            pageSimpleDataTable,
            pageSite,
            pageSubwebQuery,
            pageThemeInfo,
            pageTimeZone,
            pageTimeZoneInformation,
            pageULS,
            pageUpgradeInfo,
            pageUsageInfo,
            pageUser,
            pageUserCreationInformation,
            pageUserCustomAction,
            pageUserIdInfo,
            pageView,
            pageViewCreationInformation,
            pageViewField,
            pageWeb,
            pageWebCreationInformation,
            pageWebInfoCreationInformation,
            pageWebInformation,
            pageWebProxy,
            pageWebRequestInfo,
            pageWebResponseInfo,
            pageWebTemplate,
            pageXmlSchemaFieldCreationInformation,

        }
        public Label lblTitle;
        public Label lblProgress;
        public Label lblServerUser;
        
        public StackLayout headerStack;
        public StackLayout contentStack;
        public StackLayout footerStack;
        public Entry footerText;

        public ScrollView scrollView;
        public StackLayout mainStack;
        public ListView listView;

        public TableView tableView;
        public TableRoot tableRoot;
        public ActivityIndicator activityIndicator;
        public ObservableCollection<entry> entryList = new ObservableCollection<entry>();


        public  HMS.Auth.AppPlatform platform = HMS.Auth.AppPlatform.Windows;
        public pageBase(Boolean withListView)
        {            
            // define the controls
            lblProgress = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "",
                 
            };
            // showProgressBinding = new ShowProgressBinding();
            // lblProgress.SetBinding<ShowProgressBinding>(Label.TextProperty, viewModel => viewModel.lblProgressText);


            lblServerUser = new Label
            {
                HorizontalTextAlignment = TextAlignment.End,
                Text = "Server/User"
            };
            lblTitle = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "HMS SharePoint Explorer",
                FontSize = 20,
                FontAttributes = FontAttributes.Bold
            };
            activityIndicator = new ActivityIndicator
            {
                WidthRequest = 110,
                HeightRequest = 70,
                IsRunning = true,
                IsVisible = true,
                Color = Color.Black,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            // define the StackLayouts
            headerStack = new StackLayout
            {
                VerticalOptions = LayoutOptions.Start,
                Children = {
                        lblTitle
                }
            };
            footerText = new Entry();
            footerStack = new StackLayout
            {
                VerticalOptions = LayoutOptions.End,
                Children = {
                    footerText,
                    activityIndicator,
                    lblProgress,
                    lblServerUser
                }
            };
            contentStack = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Children = {
                    
                }
            };


            scrollView = new ScrollView
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
               //  HorizontalOptions = LayoutOptions.StartAndExpand,
                Content = new StackLayout
                {
                    Children = {
                    contentStack,
                    }
                }
            };
            
            mainStack = new StackLayout
            {
                Children = {
                    headerStack,
                    scrollView,
                    footerStack
                    }

            };
            if (withListView == true)
            {
                listView = new ListView
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    ItemsSource = entryList,
                    ItemTemplate = new DataTemplate(() =>
                    {
                        var nrLabel = new Label() { TextColor = Color.Green, WidthRequest = 0 };
                        var indentLabel = new Label() { TextColor = Color.Green, WidthRequest = 0 };
                        var icon = new Image
                        {
                            Aspect = Aspect.AspectFit,
                            VerticalOptions = LayoutOptions.Center,
                            HorizontalOptions = LayoutOptions.Center,
                            WidthRequest = 16,
                            HeightRequest = 16
                        };
                        
                        var nameLabel = new Label() { TextColor = Color.Black,BackgroundColor=new Color(128,128,128), WidthRequest = pageBase.NameWidth }; // 
                        var uriLabel = new Label() { TextColor = Color.Gray };
                        var nextPageLabel = new Label() { TextColor = Color.Green, HorizontalOptions = LayoutOptions.EndAndExpand }; // , WidthRequest = pageBase.NameWidth };

                        var valueLabel = new Label() { TextColor = Color.Gray,HorizontalOptions= LayoutOptions.Fill };
                        var stack = new StackLayout
                        {
                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Horizontal,
                            BackgroundColor = Color.Black,
                            Children =
                            {
                            new StackLayout
                            {
                                VerticalOptions = LayoutOptions.Center,
                                Orientation = StackOrientation.Horizontal,
                                Spacing = 40,
                                Children =
                                {
                                    nrLabel,
                                    indentLabel,
                                    icon,
                                    nameLabel,
                                    valueLabel,
                                    uriLabel,
                                    nextPageLabel
                                }
                            }
                            }
                        };
                        icon.SetBinding(Image.SourceProperty, "icon");
                        indentLabel.SetBinding(Label.WidthRequestProperty, "indent");
                        indentLabel.SetBinding(Label.WidthProperty, "indent");
                        indentLabel.SetBinding(Label.MinimumWidthRequestProperty, "indent");
                        
                        nameLabel.SetBinding(Label.TextProperty, "name");
                        valueLabel.SetBinding(Label.TextProperty, "value");

                        uriLabel.SetBinding(Label.TextProperty, "url");
                        nrLabel.SetBinding(Label.TextProperty, "nr");

                        stack.BackgroundColor = Color.White;

                        ViewCell vc = new ViewCell
                        {
                            View = stack
                        };
                        
                        // we create a named function in order to resue the var names
                        // vc.Tapped += Vc_Tapped;

                        var tapNameGestureRecognizer = new TapGestureRecognizer();
                        tapNameGestureRecognizer.Tapped += Vc_LabelTapped;
                        nameLabel.GestureRecognizers.Add(tapNameGestureRecognizer);

                        // var tapValueGestureRecognizer = new TapGestureRecognizer();
                        // tapValueGestureRecognizer.Tapped += Vc_LabelTapped;
                        valueLabel.GestureRecognizers.Add(tapNameGestureRecognizer);

                        // var tapUriGestureRecognizer = new TapGestureRecognizer();
                        // tapUriGestureRecognizer.Tapped += Vc_LabelTapped;
                        uriLabel.GestureRecognizers.Add(tapNameGestureRecognizer);

                        var tapGestureRecognizer = new TapGestureRecognizer();
                        tapGestureRecognizer.Tapped += Vc_IconTapped;
                        icon.GestureRecognizers.Add(tapGestureRecognizer);
                        return vc;
                    })
                };
                contentStack.Children.Add(listView);
            }
            setServerUser();

        }
        private void Vc_IconTapped(object sender, EventArgs e)
        {
            Image icon = (Image)sender;
            
            StackLayout stackLoc = (StackLayout)icon.Parent;

            Label nrLabel = (Label)stackLoc.Children[(int)line_part.nrLabel];

            int nr = -1;
            int.TryParse(nrLabel.Text, out nr);
            entry curEntry = this.getEntry(nr);
            if (curEntry.nextPage != hmsspx.pageBase.knownPages.NONE)
            {
                Type t = Type.GetType("hmsspx." + curEntry.nextPage.ToString());
                if (t != null)
                {
                    this.cancelRunningTask();
                    object[] args = { true, curEntry.url, lblTitle.Text };
                    var myObj = (pageBase)Activator.CreateInstance(t, args);
                    Navigation.PushAsync(myObj);
                }

            }
            else if (curEntry.hasChildren == true)
            {
                if (curEntry.isExpanded == false)
                {
                    curEntry.isExpanded = true;
                    if (curEntry.children != null)
                    {
                        // add all children back to the list
                        int eIndex = this.getEntryIndex(curEntry.nr);
                        for (int i =  curEntry.children.Count -1;i>=0;  i--)
                        {
                            entryList_Insert(eIndex+1, curEntry.children[i]);
                        }
                        curEntry.children = null;
                    }
                    else
                    {
                        if (curEntry.isDeferred == true)
                        {
                            if (this.runningTask == false)
                            {
                                this.add_ObjAt(nr, curEntry.level + 1, curEntry.t, curEntry.url);
                            }
                            else
                            {
                                this.cancelRunningTask();
                            }
                        }
                        else
                        {
                            this.cancelRunningTask();
                            this.add_lineAt(nr, curEntry.level + 1, false, "unset", nrLabel.Text.ToString(), hmsspx.pageBase.knownPages.NONE, "");
                        }
                    }
                }
                else
                {
                    // push all following entries into the children list
                    int level = curEntry.level;
                    int eIndex = this.getEntryIndex(curEntry.nr);
                    int i = eIndex + 1;
                    curEntry.children = new List<entry>();
                    while (i< entryList.Count)
                    {
                        if (entryList[i].level <= level)
                            break;
                        curEntry.children.Add(entryList[i]);
                        entryList.RemoveAt(i);
                    }
                    if (curEntry.children.Count == 0)
                        curEntry.children = null;


                    curEntry.isExpanded = false;
                }
            }
            else
            {
            }
        }
        public void entryCollapse(int nr)
        {
            entry curEntry = getEntry(nr);
            // push all following entries into the children list
            int level = curEntry.level;
            int eIndex = this.getEntryIndex(curEntry.nr);
            int i = eIndex + 1;
            curEntry.children = new List<entry>();
            while (i < entryList.Count)
            {
                if (entryList[i].level <= level)
                    break;
                curEntry.children.Add(entryList[i]);
                entryList.RemoveAt(i);
            }
            if (curEntry.children.Count == 0)
                curEntry.children = null;


            curEntry.isExpanded = false;
        }
        private void Vc_Tapped(object sender, EventArgs e)
        {
            ViewCell vcx = (ViewCell)sender;
            StackLayout stackLoc = (StackLayout)vcx.View;
            stackLoc = (StackLayout)stackLoc.Children[0];

            Label nrLabel = (Label)stackLoc.Children[(int)line_part.nrLabel];

            int nr = -1;
            int.TryParse(nrLabel.Text, out nr);
            entry curEntry = this.getEntry(nr);

            footerText.Text = "";
            if (curEntry != null)
            {
                if( !string.IsNullOrEmpty(curEntry.url) )
                    footerText.Text = curEntry.url;
                else if (!string.IsNullOrEmpty(curEntry.value))
                    footerText.Text = curEntry.value;
            }
#if false

            if (curEntry.nextPage != hmsspx.pageBase.knownPages.NONE )
            {
                Type t = Type.GetType("hmsspx." + curEntry.nextPage.ToString());
                if (t != null)
                {
                    this.cancelRunningTask();
                    object[] args = { true, curEntry.url, lblTitle.Text };
                    var myObj = (pageBase)Activator.CreateInstance(t, args);
                    Navigation.PushAsync(myObj);
                }

            }
            else if (curEntry.hasChildren == true && curEntry.isExpanded == false )
            {                
                curEntry.isExpanded = true;

                if( curEntry.isDeferred == true )
                {
                    if (this.runningTask == false)
                    {
                        this.add_ObjAt(nr, curEntry.level + 1, curEntry.t, curEntry.url);
                    }
                    else
                    {
                        this.cancelRunningTask();
                    }
                }
                else
                {
                    this.cancelRunningTask();
                    this.add_lineAt(nr, curEntry.level + 1, false, "web", nrLabel.Text.ToString(), hmsspx.pageBase.knownPages.NONE,  "");
                }
            }
            else
            {
            }
#endif
        }
        private void Vc_LabelTapped(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;

            footerText.Text = lbl.Text;

        }


        public entry getEntry(int nr)
        {
            for (int e = 0; e < entryList.Count ; e++)
            {
                if (entryList[e].nr == nr)
                {
                    return entryList[e];
                }
            }
            return null;
        }
        public int getEntryIndex(int nr)
        {
            for (int e = 0; e < entryList.Count; e++)
            {
                if (entryList[e].nr == nr)
                {
                    return e;
                }
            }
            return -1;
        }
        public int add_line(int level,  string name, string value)
        {
            return this.add_lineAt(-1, level, false, name, value, knownPages.NONE, "");
        }
        public int add_line(int level, Boolean hasChildren,string name,string value, hmsspx.pageBase.knownPages nextPage, string url)
        {
            return this.add_lineAt(-1, level, hasChildren, name, value, nextPage,  url);            
        }
        
        public int add_line(int level, Boolean hasChildren, string name, string value, Type t,  string url)
        {
            return this.add_lineAt(-1, level, hasChildren, name, value, t,  url);
        }
        public int add_lineAt(int nr, int level, string name, string value)
        {
            return this.add_lineAt(nr, level, false, name, value, knownPages.NONE, "");
        }
        public int add_linesAt(int nr, int level, string name, Object[] value, Type t)
        {
            if (value != null)
            {
                // SP.spUtil.toString(
                return this.add_lineAt(nr, level, false, name, HMS.SP.SPUtil.toString(value[0]), knownPages.NONE, "");
            }
            else
                return this.add_lineAt(nr, level, false, name, "empty", knownPages.NONE, "");
        }
        public int add_lineAt(int nr, int level, Boolean hasChildren, string name, string value, Type t,  string url)
        {
            return this.add_lineAt(nr, level, hasChildren, name, value, hmsspx.pageBase.knownPages.NONE,t,  url);
        }
        public int add_lineAt(int nr, int level, Boolean hasChildren, string name, string value, hmsspx.pageBase.knownPages nextPage,  string url)
        {
            return this.add_lineAt(nr, level, hasChildren, name, value, nextPage, null,  url);
            
        }
        public int add_lineReplace(int nr, int level, Boolean hasChildren, string name, string value, hmsspx.pageBase.knownPages nextPage, string url)
        {
            return this.add_lineReplace(nr, level, hasChildren, name, value, nextPage, null, url);
        }
        public int add_lineBefore(int nr, int level, string name, string value)
        {
            return this.add_lineAt(nr, level, false, name, value, knownPages.NONE, "");
        }
        public int add_lineBefore(int nr, int level, Boolean hasChildren, string name, string value, Type t, string url)
        {
            return this.add_lineAt(nr, level, hasChildren, name, value, hmsspx.pageBase.knownPages.NONE, t, url);
        }
        public int add_lineBefore(int nr, int level, Boolean hasChildren, string name, string value, hmsspx.pageBase.knownPages nextPage, string url)
        {
            return this.add_lineBefore(nr, level, hasChildren, name, value, nextPage, null, url);
        }
        private void entryList_Add(entry newEntry)
        {
            // Device.BeginInvokeOnMainThread(() => {
                entryList.Add( newEntry);
            //});            
        }
        private void entryList_Insert(int index, entry newEntry)
        {
            // Device.BeginInvokeOnMainThread(() => {
                entryList.Insert(index, newEntry);
            // });
        }
        private void entryList_RemoveAt(int index)
        {
            // Device.BeginInvokeOnMainThread(() => {
                entryList.RemoveAt(index);
            // });
        }
        private int add_lineAt(int nr, int level, Boolean hasChildren, string name, string value, hmsspx.pageBase.knownPages nextPage,Type t, string url)
        {
            Boolean added = false;
            entry newEntry = new entry( level, hasChildren, name, value, nextPage,t,  url);
            
            if (nr >= 0 )
            {
                for (int e =0;e < entryList.Count-1;e++)
                {
                    if (entryList[e].nr == nr)
                    {
                        entryList_Insert(e+1, newEntry);
                        added = true;
                        break;
                    }
                }
            }
            if( added == false )
                entryList_Add(newEntry);
            
            return newEntry.nr;
        }
        private int add_lineReplace(int nr, int level, Boolean hasChildren, string name, string value, hmsspx.pageBase.knownPages nextPage, Type t, string url)
        {
            Boolean added = false;
            entry newEntry = new entry( level, hasChildren, name, value, nextPage, t, url);

            if (nr >= 0)
            {
                for (int e = 0; e < entryList.Count ; e++)
                {
                    if (entryList[e].nr == nr)
                    {                        
                        entryList_Insert(e, newEntry);
                        entryList_RemoveAt(e + 1);
                        
                        added = true;
                        break;
                    }
                }
            }
            if (added == false)
            {
                entryList_Add(newEntry);
            }
            return newEntry.nr;
        }
        private int add_lineRemove(int nr)
        {

            if (nr >= 0)
            {
                for (int e = 0; e < entryList.Count; e++)
                {
                    if (entryList[e].nr == nr)
                    {
                        entryList_RemoveAt(e);

                        break;
                    }
                }
            }
            return nr;
        }
        private int add_lineBefore(int nr, int level, Boolean hasChildren, string name, string value, hmsspx.pageBase.knownPages nextPage, Type t, string url)
        {
            Boolean added = false;
            entry newEntry = new entry( level, hasChildren, name, value, nextPage, t, url);

            if (nr >= 0)
            {
                for (int e = 0; e < entryList.Count ; e++)
                {
                    if (entryList[e].nr == nr)
                    {
                        entryList_Insert(e , newEntry);
                        added = true;
                        break;
                    }
                }
            }
            if (added == false)
                entryList_Add(newEntry);
            return newEntry.nr;
        }
        public int add_deferred(int level, string name, string value, knownPages pageType, HMS.SP.__deferred deferred)
        {
            return add_deferredAt(-1, level, name, value, pageType, deferred);
        }
        public int add_deferredAt(int nr, int level, string name,string value, knownPages pageType, HMS.SP.__deferred deferred)
        {
            int newNr = nr;            
            if (deferred != null)
            {
                if (!String.IsNullOrEmpty(deferred.uri))
                    newNr = this.add_lineAt(nr, level, true, name, value, pageType,  deferred.uri);
            }
            return newNr;
        }
        public int add_deferredBefore(int nr, int level, string name, string value, knownPages pageType, HMS.SP.__deferred deferred)
        {
            int newNr = nr;
            if (deferred != null)
            {
                if (!String.IsNullOrEmpty(deferred.uri))
                    newNr = this.add_lineBefore(nr, level, true, name, value, pageType, deferred.uri);
            }
            return newNr;
        }
        public int add_deferred(int level, string name, string value,Type t, HMS.SP.__deferred deferred)
        {
            return add_deferredAt(-1, level, name, value, t, deferred);
        }
        public int add_deferredAt(int nr, int level, string name, string value, Type t, HMS.SP.__deferred deferred)
        {
            int newNr = nr;

            if (deferred != null)
            {
                if (!String.IsNullOrEmpty(deferred.uri))
                {
                    {
                        newNr = this.add_lineAt(nr, level, true, name, value, t, deferred.uri);
                    }
                }
                else
                {
                    newNr = this.add_lineAt(nr, level,  name, "no deferred uri");

                }
            }
            return newNr;
        }
        public int add_deferredBefore(int nr, int level, string name, string value, Type t, HMS.SP.__deferred deferred)
        {
            int newNr = nr;
            if (deferred != null)
            {
                if (!String.IsNullOrEmpty(deferred.uri))
                {
                    {
                        newNr = this.add_lineBefore(nr, level, true, name, value, t, deferred.uri);
                    }
                }
                else
                {
                    newNr = this.add_lineBefore(nr, level, name, "no deferred uri");
                }

            }
            return newNr;
        }
        public void show_running()
        {
            scrollView.IsEnabled = false;
            activityIndicator.IsVisible = true;

        }
        public void hide_running()
        {
            scrollView.IsEnabled = true;
            activityIndicator.IsVisible = false;
            this.cancelTask = false;
        }


        public Boolean showProgress(string info)
        {
            // Device.BeginInvokeOnMainThread(() => {
                lblProgress.Text = info;
            // });
            return this.cancelTask;
            // showProgressBinding.lblProgressText = info;
           // await System.Threading.Tasks.Task.Delay(50);
        }
        public void cancelRunningTask()
        {
            this.cancelTask = true;
        }
        public void setTitle(string title)
        {
            lblTitle.Text = title;
        }
        public void setServerUser(string server, string user)
        {
            lblServerUser.Text = server + "/" + user;

        }
        public void setPlatform(HMS.Auth.AppPlatform platform)
        {
            this.platform = platform;
        }
        public void setPlatform(string strPlatform)
        {
            HMS.Auth.AppPlatform tmpPlatform;
            if(Enum.TryParse(strPlatform,out tmpPlatform))
                this.platform = tmpPlatform;
        }
        public void setServerUser()
        {
            HMS.SP.SPUtil.maxCollectionCount = LocalStorage.getInt("SPGlobal.maxCollectionCount", 49);
            string server = "";
            string user = "";
            if (LocalStorage.getBoolean("SPOnline.isSelected", false) == true)
            {
                server = "SPOnline: " + getServer("SPOnline");
                user = getDomain("SPOnline") + "\\";
                user += getUser("SPOnline");

            }
            if (LocalStorage.getBoolean("SP2010.isSelected", false) == true)
            {
                server = "SP2010: " + getServer("SP2010");
                user = getDomain("SP2010") + "\\";
                user += getUser("SP2010");

            }
            if (LocalStorage.getBoolean("SP2016.isSelected", false) == true)
            {
                server = "SP2016: " + getServer("SP2016");
                user = getDomain("SP2016") + "\\";
                user += getUser("SP2016");
            }
            setServerUser( server , user);
        }
        public string getServer(string mode)
        {
            return getStorage(mode, "server");
        }
        public string getDomain(string mode)
        {
            return getStorage(mode, "domain");
        }
        public string getUser(string mode)
        {
            return getStorage(mode, "user");
        }
        public string getPassword(string mode)
        {
            return getStorage(mode, "password");
        }
        public string getStorage(string mode, string tag)
        {
            string value = "";
            if (Application.Current.Properties.ContainsKey(mode + "." + tag))
            {
                value = Application.Current.Properties[mode + "." + tag].ToString();
            }
            return value;
        }

        public Label createLabel(string text)
        {
            Label label = new Label
            {
                HorizontalTextAlignment = TextAlignment.Start,
                Text = text
            };
            return label;
        }
        public Button createButton(string text)
        {
            Button btn = new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Start,
                Text = text
            };
            return btn;
        }
    }
    public class entry : INotifyPropertyChanged
    {
        // boiler-plate
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        protected bool SetField<T>(ref T field, T value, string propertyName)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        static ImageSource openImageSource = ImageSource.FromFile("open_16x.png");
        static ImageSource expandImageSource = ImageSource.FromFile("expand_16xlg.png");
        static ImageSource collapseImageSource = ImageSource.FromFile("collapse_16xlg.png");

        public int indentValue = 20;
        public int nr { set; get; }
        public string name        { private set; get; }
        public string value        { private set; get; }
        public hmsspx.pageBase.knownPages nextPage        { private set; get; }
        // public string id        { private set; get; }
        public string url { private set; get; }
        public int level { private set; get; }
        public int indent { private set; get; }
        public Boolean hasChildren { private set; get; }
        private Boolean _isExpanded;
        public Boolean isExpanded {
            set {
                if (value == true && this._isExpanded == false)
                {
                    this.icon = collapseImageSource;
                    this.OnPropertyChanged("icon");
                }
                else if (value == false && this._isExpanded == true)
                {
                    this.icon = expandImageSource;
                    this.OnPropertyChanged("icon");
                }
                this._isExpanded = value;
            }
            get { return this._isExpanded; }
        }
        public Boolean isDeferred { set; get; }
        public ImageSource icon { set; get; }
        public Type t { set; get; }
        public List<entry> children;
        static int lastNr = 0;
        public entry( int level, Boolean hasChildren, string name, string value, hmsspx.pageBase.knownPages nextPage,  string url)
        {
            this.init(level, hasChildren, name, value, nextPage, null,  url);
        }
        public entry(int level, Boolean hasChildren, string name, string value, hmsspx.pageBase.knownPages nextPage,Type t,  string url)
        {
            this.init(  level,  hasChildren,  name,  value,  nextPage,  t,    url);
        }
        private void init( int level, Boolean hasChildren, string name, string value, hmsspx.pageBase.knownPages nextPage, Type t, string url)
        {
            this.nr = entry.lastNr++;
            this.level = level;
            this.indent = level * indentValue;
            this.hasChildren = hasChildren;
            this.isExpanded = false;
            this.isDeferred = !String.IsNullOrEmpty(url);
            this.name = name;
            this.value = value;
            this.nextPage = nextPage;
            this.t = t;            
            this.url = url;
            this.icon = null;
            if (nextPage != hmsspx.pageBase.knownPages.NONE)
            {
                this.icon = openImageSource;
            }
            else if (this.hasChildren == true)
            {
                // if we don't have an valid url, this is a generated Title entry for Collections
                if (String.IsNullOrEmpty(url))
                {
                    // this.icon = collapseImageSource;
                    this.isExpanded = true;
                }
                else
                {
                    this.icon = expandImageSource;
                }
            }
        }
    }
}

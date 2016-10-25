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
    class pageConfirm : pageBase
    {
        public Boolean Return = false;
        public static Boolean isRunning = false;
        // Use this to wait on the page to be finished with/closed/dismissed
        public Task PageClosedTask { get { return tcs.Task; } }

        private TaskCompletionSource<bool> tcs { get; set; }
        public pageConfirm(Boolean withListView,string question,Boolean def) : base(withListView)
        {
            tcs = new System.Threading.Tasks.TaskCompletionSource<bool>();

            Return = def;
            // this is accessed in loadData()
            Label lblResult = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = question
            };

            Button btnYes =  new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "Yes"
            };
            btnYes.Clicked += async (sender, e) =>
            {
                Return = true;
                await Navigation.PopAsync();
                tcs.SetResult(true);

            };
            Button btnNo =  new Button
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = "No"
            };
            btnNo.Clicked += async (sender, e) =>
            {
                Return = false;
                await Navigation.PopAsync();
                tcs.SetResult(false);

            };

            base.contentStack.Children.Add(lblResult);
            base.contentStack.Children.Add(btnYes);
            base.contentStack.Children.Add(btnNo);


            Content = base.mainStack;
            this.setServerUser();
            this.hide_running();

        }
        protected override bool OnBackButtonPressed()
        {
            Return = false;
            tcs.SetResult(false);
            return base.OnBackButtonPressed();
        }
        // Or provide your own PopAsync function so that when you decide to leave the page explicitly the TaskCompletion is triggered
        public async Task PopAwaitableAsync()
        {
            await Navigation.PopAsync();
            tcs.SetResult(true);
        }

    }
}

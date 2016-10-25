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

namespace hmsspx
{
    public class pageListCreationInformation : pageBase
    {
        public pageListCreationInformation(Boolean withListView, string url, string breadcrumb):base(withListView)
        {
            // we need this call, if we want to access the SP namespace
            spglb.init(this);
            load(url);

            // Put the StackLayout in a ScrollView.         
            Content = base.mainStack;
            string title = breadcrumb + " ListCreationInformation";
            if( title.Length > pageBase.TitleSize )
                title = title.Substring(title.Length - pageBase.TitleSize);
            setTitle(title);
        }
        private async void load(string url)
        {
            HMS.SP.ListCreationInformation spListCreationInformation = await SPGet.getListCreationInformation(spglb.myClient,url);
            this.add_ListCreationInformation(1, spListCreationInformation);
            this.hide_running();      
        }
    }
}

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
    class pageBrowse : pageBase
    {
        public pageBrowse(Boolean withListView) : base(withListView)
        {
            // we need this call, if we want to access the SP namespace
            spglb.reinit(this);
            load();

            // Put the StackLayout in a ScrollView.         
            Content = base.mainStack;
            this.setServerUser();
            this.setTitle("Server/Web");
            HMS.SP.SPBase.showProgress = this.showProgress;            
        }
        private async void load()
        {
            if (spglb.mode == HMS.SP.SPMode.SP2010)
            {
                string json = await spglb.myClient.getJSON(spglb.spEndpoints.Root);
                dynamic jobject = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                dynamic refObj = jobject;
                if (jobject.d != null)
                    refObj = jobject.d;

                if (refObj.EntitySets != null)
                    refObj = refObj.EntitySets;
                this.add_line(0, "SharePoint 2010", "you get only the list of EntitySets");
                if( refObj.Count != null )
                {
                    for(int i=0;i< refObj.Count;i++)
                    {
                        this.add_line(1, refObj[i].ToString(), "");

                    }
                }
            }
            else
            {
                HMS.SP.Web spWeb = await SPGet.getRootWeb(spglb.myClient, spglb.spEndpoints.Root);

                this.add_Web(0, spWeb);
            }
            this.hide_running();

        }
    }
}

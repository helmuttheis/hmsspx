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
    partial class pageBase
    {
        public int add_View(int level, HMS.SP.View spView)
        {
            return add_View(-1, level, spView);
        }
        public int  add_View(int pos, int level, HMS.SP.View spView)
        {
            if (spView.__HMSError_ != null && (spView.__HMSError_.errno != 0 || spView.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spView.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spView.__deferred_);
            pos = this.add__metadata(pos, level, spView.__metadata_);
            pos = this.add__rest(pos, level, spView.__rest);
            pos = this.add_lineAt(pos,level,  "Aggregations", HMS.SP.SPUtil.toString(spView.Aggregations_)); //String;
            pos = this.add_lineAt(pos,level,  "AggregationsStatus", HMS.SP.SPUtil.toString(spView.AggregationsStatus_)); //String;
            pos = this.add_lineAt(pos,level,  "BaseViewId", HMS.SP.SPUtil.toString(spView.BaseViewId_)); //String;
            pos = this.add_deferredAt(pos,level, "ContentTypeId", "...", knownPages.pageContentTypeId , spView.ContentTypeId_.__deferred_); //ContentTypeId;
            pos = this.add_lineAt(pos,level,  "DefaultView", HMS.SP.SPUtil.toString(spView.DefaultView_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "DefaultViewForContentType", HMS.SP.SPUtil.toString(spView.DefaultViewForContentType_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "EditorModified", HMS.SP.SPUtil.toString(spView.EditorModified_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Formats", HMS.SP.SPUtil.toString(spView.Formats_)); //String;
            pos = this.add_lineAt(pos,level,  "Hidden", HMS.SP.SPUtil.toString(spView.Hidden_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "HtmlSchemaXml", HMS.SP.SPUtil.toString(spView.HtmlSchemaXml_)); //String;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spView.Id_)); //Guid;
            pos = this.add_lineAt(pos,level,  "ImageUrl", HMS.SP.SPUtil.toString(spView.ImageUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "IncludeRootFolder", HMS.SP.SPUtil.toString(spView.IncludeRootFolder_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "JsLink", HMS.SP.SPUtil.toString(spView.JsLink_)); //String;
            pos = this.add_lineAt(pos,level,  "ListViewXml", HMS.SP.SPUtil.toString(spView.ListViewXml_)); //String;
            pos = this.add_lineAt(pos,level,  "Method", HMS.SP.SPUtil.toString(spView.Method_)); //String;
            pos = this.add_lineAt(pos,level,  "MobileDefaultView", HMS.SP.SPUtil.toString(spView.MobileDefaultView_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "MobileView", HMS.SP.SPUtil.toString(spView.MobileView_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "ModerationType", HMS.SP.SPUtil.toString(spView.ModerationType_)); //String;
            pos = this.add_lineAt(pos,level,  "OrderedView", HMS.SP.SPUtil.toString(spView.OrderedView_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Paged", HMS.SP.SPUtil.toString(spView.Paged_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "PersonalView", HMS.SP.SPUtil.toString(spView.PersonalView_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "ReadOnlyView", HMS.SP.SPUtil.toString(spView.ReadOnlyView_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "RequiresClientIntegration", HMS.SP.SPUtil.toString(spView.RequiresClientIntegration_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "RowLimit", HMS.SP.SPUtil.toString(spView.RowLimit_)); //Int32;
            pos = this.add_lineAt(pos,level,  "Scope", HMS.SP.SPUtil.toString(spView.Scope_)); //Int32;
            pos = this.add_lineAt(pos,level,  "ServerRelativeUrl", HMS.SP.SPUtil.toString(spView.ServerRelativeUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "StyleId", HMS.SP.SPUtil.toString(spView.StyleId_)); //String;
            pos = this.add_lineAt(pos,level,  "Threaded", HMS.SP.SPUtil.toString(spView.Threaded_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spView.Title_)); //String;
            pos = this.add_lineAt(pos,level,  "Toolbar", HMS.SP.SPUtil.toString(spView.Toolbar_)); //String;
            pos = this.add_lineAt(pos,level,  "ToolbarTemplateName", HMS.SP.SPUtil.toString(spView.ToolbarTemplateName_)); //String;
            pos = this.add_lineAt(pos,level,  "ViewData", HMS.SP.SPUtil.toString(spView.ViewData_)); //String;
            pos = this.add_lineAt(pos,level,  "ViewFields", HMS.SP.SPUtil.toString(spView.ViewFields_)); //ViewField;
            pos = this.add_lineAt(pos,level,  "ViewJoins", HMS.SP.SPUtil.toString(spView.ViewJoins_)); //String;
            pos = this.add_lineAt(pos,level,  "ViewProjectedFields", HMS.SP.SPUtil.toString(spView.ViewProjectedFields_)); //String;
            pos = this.add_lineAt(pos,level,  "ViewQuery", HMS.SP.SPUtil.toString(spView.ViewQuery_)); //String;
            pos = this.add_lineAt(pos,level,  "ViewType", HMS.SP.SPUtil.toString(spView.ViewType_)); //String;
            return pos;
        }
        public int add_View_deferred(int pos, int level, HMS.SP.View spView)
        {
            if (spView.TitleResource_.uri == null)
            {
                pos = this.add_lineAt(pos, level,true, "View", HMS.SP.SPUtil.toString(spView.Title_), knownPages.NONE,""); //String;
                pos = add_View(pos, level + 1, spView);
            }
            else
            {
                string useUrl = spView.__deferred_.uri;
                if(String.IsNullOrEmpty(useUrl) )
                {
                    useUrl = spView.TitleResource_.uri.Replace("/TitleResource", "");
                }
                pos = this.add_lineAt(pos, level, false,  spView.Title_, "", knownPages.pageView, useUrl);
            }
        return pos;
        }
    }
}

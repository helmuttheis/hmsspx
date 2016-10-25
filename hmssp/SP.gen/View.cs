/* **********************************************************************************************************
 * The MIT License (MIT)																					*
 * 																											*
 * Copyright (c) 2016 Hypermediasystems Ges. f. Software mbH										*
 * Web: http://www.hypermediasystems.de																		*
 * This file is part of hmssp																			*
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
using System.Reflection;
using Newtonsoft.Json;
namespace HMS.SP{
    /// <summary>
    /// <para>https://msdn.microsoft.com/en-us/library/office/dn531433.aspx#bk_View</para>
    /// </summary>
    public class View : SPBase,iSP{
        [JsonProperty("__HMSError")]
        public HMS.Util.__HMSError __HMSError_ { set; get; }
        [JsonProperty("__status")]
        public SP.__status __status_ { set; get; }
        [JsonProperty("__deferred")]
        public SP.__deferred __deferred_ { set; get; }
        [JsonProperty("__metadata")]
        public SP.__metadata __metadata_ { set; get; }
        public Dictionary<string, string> __rest;
        /// <summary>
        /// <para>Gets or sets a value that specifies fields and functions that define totals shown in a list view. If not null, the XML must conform to FieldRefDefinitionAggregation, as specified in [MS-WSSCAML]. </para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Aggregations")]
        public String Aggregations_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether totals are shown in the list view.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("AggregationsStatus")]
        public String AggregationsStatus_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the base view identifier of the list view.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("BaseViewId")]
        public String BaseViewId_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the identifier of the content type with which the view is associated so that the view is available only on folders of this content type.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ContentTypeId")]
        public SP.ContentTypeId ContentTypeId_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the list view is the default list view.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("DefaultView")]
        public Boolean DefaultView_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the list view is the default list view for the content type specified by contentTypeId.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("DefaultViewForContentType")]
        public Boolean DefaultViewForContentType_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the list view was modified in an editor.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("EditorModified")]
        public Boolean EditorModified_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the column and row formatting for the list view. If not null, the XML must conform to ViewFormatDefinitions, as specified in [MS-WSSCAML]. </para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Formats")]
        public String Formats_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the list view is hidden.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Hidden")]
        public Boolean Hidden_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the XML document that represents the list view.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("HtmlSchemaXml")]
        public String HtmlSchemaXml_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the view identifier of the list view.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Id")]
        public Guid Id_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the URI (Uniform Resource Identifier) of the image for the list view.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public String ImageUrl_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the current folder is displayed in the list view.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("IncludeRootFolder")]
        public Boolean IncludeRootFolder_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the name of the JavaScript file used for the view.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("JsLink")]
        public String JsLink_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a string that represents the view XML.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ListViewXml")]
        public String ListViewXml_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the view method for the list view. If not null, the XML must conform to Method, as specified in [MS-WSSCAP]. </para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Method")]
        public String Method_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the list view is the default mobile list view.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("MobileDefaultView")]
        public Boolean MobileDefaultView_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the list view is a mobile list view.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("MobileView")]
        public Boolean MobileView_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the content approval type for the list view.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ModerationType")]
        public String ModerationType_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether list items can be reordered in the list view.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("OrderedView")]
        public Boolean OrderedView_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the list view is a paged view.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Paged")]
        public Boolean Paged_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the list view is a personal view.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("PersonalView")]
        public Boolean PersonalView_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the list view is read-only.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ReadOnlyView")]
        public Boolean ReadOnlyView_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the list view requires client integration rights.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("RequiresClientIntegration")]
        public Boolean RequiresClientIntegration_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the maximum number of list items to display in a visual page of the list view.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("RowLimit")]
        public Int32 RowLimit_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the scope for the list view. Represents a ViewScope value. DefaultValue = 0, Recursive = 1, RecursiveAll = 2, FilesOnly = 3.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Scope")]
        public Int32 Scope_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the server-relative URL of the list view page.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ServerRelativeUrl")]
        public String ServerRelativeUrl_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the identifier of the view style for the list view.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("StyleId")]
        public String StyleId_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the list view is a threaded view.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Threaded")]
        public Boolean Threaded_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the display name of the list view.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Title")]
        public String Title_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the display name of the list view.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("TitleResource")]
        public SP.__deferred TitleResource_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the toolbar for the list view.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Toolbar")]
        public String Toolbar_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the name of the template for the toolbar that is used in the list view.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ToolbarTemplateName")]
        public String ToolbarTemplateName_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the view data for the list view. If not null, the XML must conform to FieldRefDefinitionViewData, as specified in [MS-WSSCAML]. </para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ViewData")]
        public String ViewData_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the collection of fields in the list view.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("ViewFields")]
        public SP.ViewFieldCollection ViewFields_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the joins that are used in the list view. If not null, the XML must conform to ListJoinsDefinition, as specified in [MS-WSSCAML].</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ViewJoins")]
        public String ViewJoins_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the projected fields that will be used by the list view. If not null, the XML must conform to ProjectedFieldsDefinitionType, as specified in [MS-WSSCAML].</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ViewProjectedFields")]
        public String ViewProjectedFields_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the query that is used by the list view. If not null, the XML must conform to CamlQueryRoot, as specified in [MS-WSSCAML].</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ViewQuery")]
        public String ViewQuery_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the type of the list view. Can be HTML, GRID, CALENDAR, RECURRENCE, CHART, or GANTT.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ViewType")]
        public String ViewType_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
            "http://<site url>/_api/web/lists(guid'<list id>')/views('<view id>')",
        };

        public View(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(View));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  View()
        {
        }
        public  View(string json)
        {
            if( json == String.Empty )
                return;
            dynamic jobject = Newtonsoft.Json.JsonConvert.DeserializeObject(json);            
            dynamic refObj = jobject;
            if (jobject.d != null)
                refObj = jobject.d;
            string errInfo = "";
            if (refObj.results != null)
            {
                if (refObj.results.Count > 1)
                    errInfo = "Result is Collection, only 1. entry displayed.";
                refObj = refObj.results[0];
            }
            List<string> usedFields = new List<string>();
                usedFields.Add("__HMSError");
            HMS.SP.SPUtil.dyn_ValueSet("__HMSError", refObj, this);
                usedFields.Add("__deferred");
            this.__deferred_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.__deferred));
                usedFields.Add("__metadata");
            this.__metadata_ = new SP.__metadata(HMS.SP.SPUtil.dyn_toString(refObj.__metadata));
                usedFields.Add("Aggregations");
            HMS.SP.SPUtil.dyn_ValueSet("Aggregations", refObj, this);
                usedFields.Add("AggregationsStatus");
            HMS.SP.SPUtil.dyn_ValueSet("AggregationsStatus", refObj, this);
                usedFields.Add("BaseViewId");
            HMS.SP.SPUtil.dyn_ValueSet("BaseViewId", refObj, this);
                usedFields.Add("ContentTypeId");
            this.ContentTypeId_ = new SP.ContentTypeId(HMS.SP.SPUtil.dyn_toString(refObj.ContentTypeId));
                usedFields.Add("DefaultView");
            HMS.SP.SPUtil.dyn_ValueSet("DefaultView", refObj, this);
                usedFields.Add("DefaultViewForContentType");
            HMS.SP.SPUtil.dyn_ValueSet("DefaultViewForContentType", refObj, this);
                usedFields.Add("EditorModified");
            HMS.SP.SPUtil.dyn_ValueSet("EditorModified", refObj, this);
                usedFields.Add("Formats");
            HMS.SP.SPUtil.dyn_ValueSet("Formats", refObj, this);
                usedFields.Add("Hidden");
            HMS.SP.SPUtil.dyn_ValueSet("Hidden", refObj, this);
                usedFields.Add("HtmlSchemaXml");
            HMS.SP.SPUtil.dyn_ValueSet("HtmlSchemaXml", refObj, this);
                usedFields.Add("Id");
            HMS.SP.SPUtil.dyn_ValueSet("Id", refObj, this);
                usedFields.Add("ImageUrl");
            HMS.SP.SPUtil.dyn_ValueSet("ImageUrl", refObj, this);
                usedFields.Add("IncludeRootFolder");
            HMS.SP.SPUtil.dyn_ValueSet("IncludeRootFolder", refObj, this);
                usedFields.Add("JsLink");
            HMS.SP.SPUtil.dyn_ValueSet("JsLink", refObj, this);
                usedFields.Add("ListViewXml");
            HMS.SP.SPUtil.dyn_ValueSet("ListViewXml", refObj, this);
                usedFields.Add("Method");
            HMS.SP.SPUtil.dyn_ValueSet("Method", refObj, this);
                usedFields.Add("MobileDefaultView");
            HMS.SP.SPUtil.dyn_ValueSet("MobileDefaultView", refObj, this);
                usedFields.Add("MobileView");
            HMS.SP.SPUtil.dyn_ValueSet("MobileView", refObj, this);
                usedFields.Add("ModerationType");
            HMS.SP.SPUtil.dyn_ValueSet("ModerationType", refObj, this);
                usedFields.Add("OrderedView");
            HMS.SP.SPUtil.dyn_ValueSet("OrderedView", refObj, this);
                usedFields.Add("Paged");
            HMS.SP.SPUtil.dyn_ValueSet("Paged", refObj, this);
                usedFields.Add("PersonalView");
            HMS.SP.SPUtil.dyn_ValueSet("PersonalView", refObj, this);
                usedFields.Add("ReadOnlyView");
            HMS.SP.SPUtil.dyn_ValueSet("ReadOnlyView", refObj, this);
                usedFields.Add("RequiresClientIntegration");
            HMS.SP.SPUtil.dyn_ValueSet("RequiresClientIntegration", refObj, this);
                usedFields.Add("RowLimit");
            HMS.SP.SPUtil.dyn_ValueSet("RowLimit", refObj, this);
                usedFields.Add("Scope");
            HMS.SP.SPUtil.dyn_ValueSet("Scope", refObj, this);
                usedFields.Add("ServerRelativeUrl");
            HMS.SP.SPUtil.dyn_ValueSet("ServerRelativeUrl", refObj, this);
                usedFields.Add("StyleId");
            HMS.SP.SPUtil.dyn_ValueSet("StyleId", refObj, this);
                usedFields.Add("Threaded");
            HMS.SP.SPUtil.dyn_ValueSet("Threaded", refObj, this);
                usedFields.Add("Title");
            HMS.SP.SPUtil.dyn_ValueSet("Title", refObj, this);
                usedFields.Add("TitleResource");
            this.TitleResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.TitleResource));
                usedFields.Add("Toolbar");
            HMS.SP.SPUtil.dyn_ValueSet("Toolbar", refObj, this);
                usedFields.Add("ToolbarTemplateName");
            HMS.SP.SPUtil.dyn_ValueSet("ToolbarTemplateName", refObj, this);
                usedFields.Add("ViewData");
            HMS.SP.SPUtil.dyn_ValueSet("ViewData", refObj, this);
                usedFields.Add("ViewFields");
            this.ViewFields_ = new SP.ViewFieldCollection(HMS.SP.SPUtil.dyn_toString(refObj.ViewFields));
                usedFields.Add("ViewJoins");
            HMS.SP.SPUtil.dyn_ValueSet("ViewJoins", refObj, this);
                usedFields.Add("ViewProjectedFields");
            HMS.SP.SPUtil.dyn_ValueSet("ViewProjectedFields", refObj, this);
                usedFields.Add("ViewQuery");
            HMS.SP.SPUtil.dyn_ValueSet("ViewQuery", refObj, this);
                usedFields.Add("ViewType");
            HMS.SP.SPUtil.dyn_ValueSet("ViewType", refObj, this);
            this.__rest = new Dictionary<string, string>();
            var dyn = ((Newtonsoft.Json.Linq.JContainer)refObj).First;
            while (dyn != null)
            {
                string Name = ((Newtonsoft.Json.Linq.JProperty)dyn).Name;
                string Value = ((Newtonsoft.Json.Linq.JProperty)dyn).Value.ToString();
                if ( !usedFields.Contains( Name ))
                    this.__rest.Add( Name, Value);
                dyn = dyn.Next;
            }
            if( errInfo != "")
                this.__HMSError_.info = errInfo;
        }
    }
}

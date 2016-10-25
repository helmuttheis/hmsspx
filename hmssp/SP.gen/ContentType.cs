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
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj245579.aspx#properties</para>
    /// </summary>
    public class ContentType : SPBase{
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
        /// <para>Gets or sets a description of the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj246343.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Description")]
        public String Description_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a description of the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj246343.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DescriptionResource")]
        public SP.__deferred DescriptionResource_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the name of a custom display form template to use for list items that have been assigned the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj246165.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DisplayFormTemplateName")]
        public String DisplayFormTemplateName_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the URL of a custom display form to use for list items that have been assigned the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj245685.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DisplayFormUrl")]
        public String DisplayFormUrl_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the file path to the document template used for a new list item that has been assigned the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj245436.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DocumentTemplate")]
        public String DocumentTemplate_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the URL of the document template assigned to the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj247017.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DocumentTemplateUrl")]
        public String DocumentTemplateUrl_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the name of a custom edit form template to use for list items that have been assigned the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj246863.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("EditFormTemplateName")]
        public String EditFormTemplateName_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the URL of a custom edit form to use for list items that have been assigned the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj246105.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("EditFormUrl")]
        public String EditFormUrl_ { set; get; }
        /// <summary>
        /// <para>Gets the column (also known as field) references in the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj246293.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("FieldLinks")]
        public SP.FieldLinkCollection FieldLinks_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the collection of fields for the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj247177.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Fields")]
        public SP.FieldCollection Fields_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the content type group for the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj245924.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Group")]
        public String Group_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the content type is unavailable for creation or usage directly from a user interface.(s. https://msdn.microsoft.com/en-us/library/office/jj246068.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Hidden")]
        public Boolean Hidden_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets a value that specifies an identifier for the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj245809.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Id")]
        public Object Id_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the name of the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj247011.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Name")]
        public String Name_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the name of the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj246984.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("NewFormTemplateName")]
        public String NewFormTemplateName_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the name of the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj246425.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("NewFormUrl")]
        public String NewFormUrl_ { set; get; }
        /// <summary>
        /// <para>Gets the parent content type of the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj245682.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Parent")]
        public SP.ContentType Parent_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether changes to the content type properties are denied.(s. https://msdn.microsoft.com/en-us/library/office/jj247098.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ReadOnly")]
        public Boolean ReadOnly_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the XML Schema representing the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj245045.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("SchemaXml")]
        public String SchemaXml_ { set; get; }
        /// <summary>
        /// <para>Gets a non-localized version of the XML schema that defines the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj838387.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("SchemaXmlWithResourceTokens")]
        public Object SchemaXmlWithResourceTokens_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies a server-relative path to the content type scope of the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj247140.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Scope")]
        public String Scope_ { set; get; }
        /// <summary>
        /// <para>Gets or sets whether the content type can be modified.(s. https://msdn.microsoft.com/en-us/library/office/jj245257.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Sealed")]
        public Boolean Sealed_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>A string representation of the value of the Id.(s. https://msdn.microsoft.com/en-us/library/office/jj245819.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("StringId")]
        public Object StringId_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the collection of workflow associations for the content type.(s. https://msdn.microsoft.com/en-us/library/office/jj245048.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("WorkflowAssociations")]
        public SP.Workflow.WorkflowAssociationCollection WorkflowAssociations_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public ContentType(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(ContentType));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  ContentType()
        {
        }
        public  ContentType(string json)
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
                usedFields.Add("Description");
            HMS.SP.SPUtil.dyn_ValueSet("Description", refObj, this);
                usedFields.Add("DescriptionResource");
            this.DescriptionResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.DescriptionResource));
                usedFields.Add("DisplayFormTemplateName");
            HMS.SP.SPUtil.dyn_ValueSet("DisplayFormTemplateName", refObj, this);
                usedFields.Add("DisplayFormUrl");
            HMS.SP.SPUtil.dyn_ValueSet("DisplayFormUrl", refObj, this);
                usedFields.Add("DocumentTemplate");
            HMS.SP.SPUtil.dyn_ValueSet("DocumentTemplate", refObj, this);
                usedFields.Add("DocumentTemplateUrl");
            HMS.SP.SPUtil.dyn_ValueSet("DocumentTemplateUrl", refObj, this);
                usedFields.Add("EditFormTemplateName");
            HMS.SP.SPUtil.dyn_ValueSet("EditFormTemplateName", refObj, this);
                usedFields.Add("EditFormUrl");
            HMS.SP.SPUtil.dyn_ValueSet("EditFormUrl", refObj, this);
                usedFields.Add("FieldLinks");
            this.FieldLinks_ = new SP.FieldLinkCollection(HMS.SP.SPUtil.dyn_toString(refObj.FieldLinks));
                usedFields.Add("Fields");
            this.Fields_ = new SP.FieldCollection(HMS.SP.SPUtil.dyn_toString(refObj.Fields));
                usedFields.Add("Group");
            HMS.SP.SPUtil.dyn_ValueSet("Group", refObj, this);
                usedFields.Add("Hidden");
            HMS.SP.SPUtil.dyn_ValueSet("Hidden", refObj, this);
                usedFields.Add("Id");
            HMS.SP.SPUtil.dyn_ValueSet("Id", refObj, this);
                usedFields.Add("Name");
            HMS.SP.SPUtil.dyn_ValueSet("Name", refObj, this);
                usedFields.Add("NewFormTemplateName");
            HMS.SP.SPUtil.dyn_ValueSet("NewFormTemplateName", refObj, this);
                usedFields.Add("NewFormUrl");
            HMS.SP.SPUtil.dyn_ValueSet("NewFormUrl", refObj, this);
                usedFields.Add("Parent");
            this.Parent_ = new SP.ContentType(HMS.SP.SPUtil.dyn_toString(refObj.Parent));
                usedFields.Add("ReadOnly");
            HMS.SP.SPUtil.dyn_ValueSet("ReadOnly", refObj, this);
                usedFields.Add("SchemaXml");
            HMS.SP.SPUtil.dyn_ValueSet("SchemaXml", refObj, this);
                usedFields.Add("SchemaXmlWithResourceTokens");
            HMS.SP.SPUtil.dyn_ValueSet("SchemaXmlWithResourceTokens", refObj, this);
                usedFields.Add("Scope");
            HMS.SP.SPUtil.dyn_ValueSet("Scope", refObj, this);
                usedFields.Add("Sealed");
            HMS.SP.SPUtil.dyn_ValueSet("Sealed", refObj, this);
                usedFields.Add("StringId");
            HMS.SP.SPUtil.dyn_ValueSet("StringId", refObj, this);
                usedFields.Add("WorkflowAssociations");
            this.WorkflowAssociations_ = new SP.Workflow.WorkflowAssociationCollection(HMS.SP.SPUtil.dyn_toString(refObj.WorkflowAssociations));
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

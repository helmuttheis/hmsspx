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
    /// <para>https://msdn.microsoft.com/en-us/library/office/dn600182.aspx#bk_Field</para>
    /// </summary>
    public class Field : SPBase,iSP{
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
        /// <para>Gets a value that specifies whether the field can be deleted.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("CanBeDeleted")]
        public Boolean CanBeDeleted_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the default value for the field.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("DefaultValue")]
        public String DefaultValue_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the description of the field.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Description")]
        public String Description_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the description of the field.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("DescriptionResource")]
        public SP.__deferred DescriptionResource_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the reading order of the field.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Direction")]
        public String Direction_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether to require unique field values in a list or library column.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("EnforceUniqueValues")]
        public Boolean EnforceUniqueValues_ { set; get; }
        /// <summary>
        /// <para>Gets the name of the entity property for the list item entity that uses this field.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("EntityPropertyName")]
        public String EntityPropertyName_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the type of the field. Represents a FieldType value. See FieldType in the .NET client object model reference for a list of field type values.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("FieldTypeKind")]
        public Int32 FieldTypeKind_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether list items in the list can be filtered by the field value.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Filterable")]
        public Boolean Filterable_ { set; get; }
        /// <summary>
        /// <para>Gets a Boolean value that indicates whether the field derives from a base field type.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("FromBaseType")]
        public Boolean FromBaseType_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the field group.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Group")]
        public String Group_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the field is hidden in list views and list forms.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Hidden")]
        public Boolean Hidden_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the field identifier.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Id")]
        public Guid Id_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a Boolean value that specifies whether the field is indexed.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Indexed")]
        public Boolean Indexed_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the field internal name.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("InternalName")]
        public String InternalName_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the name of an external JS file containing any client rendering logic for fields of this type.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("JSLink")]
        public String JSLink_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the value of the field is read-only.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ReadOnlyField")]
        public Boolean ReadOnlyField_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether the field requires a value.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Required")]
        public Boolean Required_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the XML schema that defines the field.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("SchemaXml")]
        public String SchemaXml_ { set; get; }
        /// <summary>
        /// <para>Gets the schema that defines the field and includes resource tokens.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:No</para>
        /// </summary>
        [JsonProperty("SchemaXmlWithResourceTokens")]
        public String SchemaXmlWithResourceTokens_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the server-relative URL of the list or the site to which the field belongs.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Scope")]
        public String Scope_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether properties on the field cannot be changed and whether the field cannot be deleted.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Sealed")]
        public Boolean Sealed_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether list items in the list can be sorted by the field value.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Sortable")]
        public Boolean Sortable_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies a customizable identifier of the field.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("StaticName")]
        public String StaticName_ { set; get; }
        /// <summary>
        /// <para>Gets or sets value that specifies the display name of the field.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("Title")]
        public String Title_ { set; get; }
        /// <summary>
        /// <para>Gets or sets value that specifies the display name of the field.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("TitleResource")]
        public SP.__deferred TitleResource_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the type of the field.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("TypeAsString")]
        public String TypeAsString_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the display name for the type of the field.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("TypeDisplayName")]
        public String TypeDisplayName_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the description for the type of the field.</para>
        /// <para>R/W: R</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("TypeShortDescription")]
        public String TypeShortDescription_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the data validation criteria for the value of the field.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ValidationFormula")]
        public String ValidationFormula_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the error message returned when data validation fails for the field.</para>
        /// <para>R/W: RW</para>
        /// <para>Returned with resource:Yes</para>
        /// </summary>
        [JsonProperty("ValidationMessage")]
        public String ValidationMessage_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
            "http://<site url>/_api/web/fields('<field id>')",
            "http://<site url>/_api/web/lists(guid'<list id>')/fields('<field id>')",
        };

        public Field(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(Field));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  Field()
        {
        }
        public  Field(string json)
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
                usedFields.Add("CanBeDeleted");
            HMS.SP.SPUtil.dyn_ValueSet("CanBeDeleted", refObj, this);
                usedFields.Add("DefaultValue");
            HMS.SP.SPUtil.dyn_ValueSet("DefaultValue", refObj, this);
                usedFields.Add("Description");
            HMS.SP.SPUtil.dyn_ValueSet("Description", refObj, this);
                usedFields.Add("DescriptionResource");
            this.DescriptionResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.DescriptionResource));
                usedFields.Add("Direction");
            HMS.SP.SPUtil.dyn_ValueSet("Direction", refObj, this);
                usedFields.Add("EnforceUniqueValues");
            HMS.SP.SPUtil.dyn_ValueSet("EnforceUniqueValues", refObj, this);
                usedFields.Add("EntityPropertyName");
            HMS.SP.SPUtil.dyn_ValueSet("EntityPropertyName", refObj, this);
                usedFields.Add("FieldTypeKind");
            HMS.SP.SPUtil.dyn_ValueSet("FieldTypeKind", refObj, this);
                usedFields.Add("Filterable");
            HMS.SP.SPUtil.dyn_ValueSet("Filterable", refObj, this);
                usedFields.Add("FromBaseType");
            HMS.SP.SPUtil.dyn_ValueSet("FromBaseType", refObj, this);
                usedFields.Add("Group");
            HMS.SP.SPUtil.dyn_ValueSet("Group", refObj, this);
                usedFields.Add("Hidden");
            HMS.SP.SPUtil.dyn_ValueSet("Hidden", refObj, this);
                usedFields.Add("Id");
            HMS.SP.SPUtil.dyn_ValueSet("Id", refObj, this);
                usedFields.Add("Indexed");
            HMS.SP.SPUtil.dyn_ValueSet("Indexed", refObj, this);
                usedFields.Add("InternalName");
            HMS.SP.SPUtil.dyn_ValueSet("InternalName", refObj, this);
                usedFields.Add("JSLink");
            HMS.SP.SPUtil.dyn_ValueSet("JSLink", refObj, this);
                usedFields.Add("ReadOnlyField");
            HMS.SP.SPUtil.dyn_ValueSet("ReadOnlyField", refObj, this);
                usedFields.Add("Required");
            HMS.SP.SPUtil.dyn_ValueSet("Required", refObj, this);
                usedFields.Add("SchemaXml");
            HMS.SP.SPUtil.dyn_ValueSet("SchemaXml", refObj, this);
                usedFields.Add("SchemaXmlWithResourceTokens");
            HMS.SP.SPUtil.dyn_ValueSet("SchemaXmlWithResourceTokens", refObj, this);
                usedFields.Add("Scope");
            HMS.SP.SPUtil.dyn_ValueSet("Scope", refObj, this);
                usedFields.Add("Sealed");
            HMS.SP.SPUtil.dyn_ValueSet("Sealed", refObj, this);
                usedFields.Add("Sortable");
            HMS.SP.SPUtil.dyn_ValueSet("Sortable", refObj, this);
                usedFields.Add("StaticName");
            HMS.SP.SPUtil.dyn_ValueSet("StaticName", refObj, this);
                usedFields.Add("Title");
            HMS.SP.SPUtil.dyn_ValueSet("Title", refObj, this);
                usedFields.Add("TitleResource");
            this.TitleResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.TitleResource));
                usedFields.Add("TypeAsString");
            HMS.SP.SPUtil.dyn_ValueSet("TypeAsString", refObj, this);
                usedFields.Add("TypeDisplayName");
            HMS.SP.SPUtil.dyn_ValueSet("TypeDisplayName", refObj, this);
                usedFields.Add("TypeShortDescription");
            HMS.SP.SPUtil.dyn_ValueSet("TypeShortDescription", refObj, this);
                usedFields.Add("ValidationFormula");
            HMS.SP.SPUtil.dyn_ValueSet("ValidationFormula", refObj, this);
                usedFields.Add("ValidationMessage");
            HMS.SP.SPUtil.dyn_ValueSet("ValidationMessage", refObj, this);
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

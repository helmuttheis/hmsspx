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
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj245565.aspx#properties</para>
    /// </summary>
    public class ListTemplate : SPBase{
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
        /// <para>Gets a value that specifies whether new list folders can be added to a list created from the list template.(s. https://msdn.microsoft.com/en-us/library/office/jj245481.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AllowsFolderCreation")]
        public Boolean AllowsFolderCreation_ { set; get; }
// undefined class SP.BaseType : Object { }
        /// <summary>
        /// <para>Gets a value that specifies the base type of the list template.(s. https://msdn.microsoft.com/en-us/library/office/jj246055.aspx)[SP.BaseType]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("BaseType")]
        public Object BaseType_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the description of the list template.(s. https://msdn.microsoft.com/en-us/library/office/jj246343.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Description")]
        public String Description_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the description of the list template.(s. https://msdn.microsoft.com/en-us/library/office/jj246343.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DescriptionResource")]
        public SP.__deferred DescriptionResource_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the feature identifier of the feature that contains the list schema for the list template.(s. https://msdn.microsoft.com/en-us/library/office/jj246861.aspx) [SP.Guid]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("FeatureId")]
        public Guid FeatureId_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the list template is hidden from the user interface for creating new lists.(s. https://msdn.microsoft.com/en-us/library/office/jj246068.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Hidden")]
        public Boolean Hidden_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the URL for the icon of the list template.(s. https://msdn.microsoft.com/en-us/library/office/jj245413.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ImageUrl")]
        public String ImageUrl_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the identifier for the list template.(s. https://msdn.microsoft.com/en-us/library/office/jj244864.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("InternalName")]
        public String InternalName_ { set; get; }
        /// <summary>
        /// <para>Specifies whether the list template is user created.(s. https://msdn.microsoft.com/en-us/library/office/jj246619.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("IsCustomTemplate")]
        public Boolean IsCustomTemplate_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the list server template.(s. https://msdn.microsoft.com/en-us/library/office/jj244836.aspx) [Number]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ListTemplateTypeKind")]
        public Int32 ListTemplateTypeKind_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies the display name of the list template.(s. https://msdn.microsoft.com/en-us/library/office/jj247011.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Name")]
        public String Name_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the list template can be used to create only one list in a site collection, and that the list template is hidden from the user interface for creating new lists.(s. https://msdn.microsoft.com/en-us/library/office/jj245427.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("OnQuickLaunch")]
        public Boolean OnQuickLaunch_ { set; get; }
        /// <summary>
        /// <para>Gets a value that specifies whether the list template can be used to create only one list in a site collection, and that the list template is hidden from the user interface for creating new lists.(s. https://msdn.microsoft.com/en-us/library/office/jj245040.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Unique")]
        public Boolean Unique_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public ListTemplate(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(ListTemplate));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  ListTemplate()
        {
        }
        public  ListTemplate(string json)
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
                usedFields.Add("AllowsFolderCreation");
            HMS.SP.SPUtil.dyn_ValueSet("AllowsFolderCreation", refObj, this);
                usedFields.Add("BaseType");
            HMS.SP.SPUtil.dyn_ValueSet("BaseType", refObj, this);
                usedFields.Add("Description");
            HMS.SP.SPUtil.dyn_ValueSet("Description", refObj, this);
                usedFields.Add("DescriptionResource");
            this.DescriptionResource_ = new SP.__deferred(HMS.SP.SPUtil.dyn_toString(refObj.DescriptionResource));
                usedFields.Add("FeatureId");
            HMS.SP.SPUtil.dyn_ValueSet("FeatureId", refObj, this);
                usedFields.Add("Hidden");
            HMS.SP.SPUtil.dyn_ValueSet("Hidden", refObj, this);
                usedFields.Add("ImageUrl");
            HMS.SP.SPUtil.dyn_ValueSet("ImageUrl", refObj, this);
                usedFields.Add("InternalName");
            HMS.SP.SPUtil.dyn_ValueSet("InternalName", refObj, this);
                usedFields.Add("IsCustomTemplate");
            HMS.SP.SPUtil.dyn_ValueSet("IsCustomTemplate", refObj, this);
                usedFields.Add("ListTemplateTypeKind");
            HMS.SP.SPUtil.dyn_ValueSet("ListTemplateTypeKind", refObj, this);
                usedFields.Add("Name");
            HMS.SP.SPUtil.dyn_ValueSet("Name", refObj, this);
                usedFields.Add("OnQuickLaunch");
            HMS.SP.SPUtil.dyn_ValueSet("OnQuickLaunch", refObj, this);
                usedFields.Add("Unique");
            HMS.SP.SPUtil.dyn_ValueSet("Unique", refObj, this);
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

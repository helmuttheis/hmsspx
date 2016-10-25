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
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj245154.aspx#properties</para>
    /// </summary>
    public class FieldLookup : SPBase{
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
        /// <para>Gets or sets a value that specifies whether the lookup field allows multiple values.(s. https://msdn.microsoft.com/en-us/library/office/jj245835.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AllowMultipleValues")]
        public Boolean AllowMultipleValues_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether this lookup field is returned by SP.List.getRelatedFields from the list being looked up to.(s. https://msdn.microsoft.com/en-us/library/office/jj247041.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("IsRelationship")]
        public Boolean IsRelationship_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the internal field name of the field used as the lookup values.(s. https://msdn.microsoft.com/en-us/library/office/jj246035.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("LookupField")]
        public String LookupField_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the list identifier of the list that contains the field to use as the lookup values.(s. https://msdn.microsoft.com/en-us/library/office/jj245483.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("LookupList")]
        public String LookupList_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the ID of the Web site that contains the list that is the source of this field's value.(s. https://msdn.microsoft.com/en-us/library/office/jj245766.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("LookupWebId")]
        public Guid LookupWebId_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the primary lookup field identifier if this is a dependent lookup field. Otherwise, it is an empty string.(s. https://msdn.microsoft.com/en-us/library/office/jj245289.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("PrimaryFieldId")]
        public String PrimaryFieldId_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the delete behavior of the lookup field.(s. https://msdn.microsoft.com/en-us/library/office/jj246443.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("RelationshipDeleteBehavior")]
        public Object RelationshipDeleteBehavior_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public FieldLookup(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(FieldLookup));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  FieldLookup()
        {
        }
        public  FieldLookup(string json)
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
                usedFields.Add("AllowMultipleValues");
            HMS.SP.SPUtil.dyn_ValueSet("AllowMultipleValues", refObj, this);
                usedFields.Add("IsRelationship");
            HMS.SP.SPUtil.dyn_ValueSet("IsRelationship", refObj, this);
                usedFields.Add("LookupField");
            HMS.SP.SPUtil.dyn_ValueSet("LookupField", refObj, this);
                usedFields.Add("LookupList");
            HMS.SP.SPUtil.dyn_ValueSet("LookupList", refObj, this);
                usedFields.Add("LookupWebId");
            HMS.SP.SPUtil.dyn_ValueSet("LookupWebId", refObj, this);
                usedFields.Add("PrimaryFieldId");
            HMS.SP.SPUtil.dyn_ValueSet("PrimaryFieldId", refObj, this);
                usedFields.Add("RelationshipDeleteBehavior");
            HMS.SP.SPUtil.dyn_ValueSet("RelationshipDeleteBehavior", refObj, this);
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

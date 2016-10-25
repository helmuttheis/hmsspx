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
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj246199.aspx#properties</para>
    /// </summary>
    public class FieldUser : SPBase{
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
        /// <para>Gets or sets a value that specifies whether to display the name of the user in a survey list.(s. https://msdn.microsoft.com/en-us/library/office/jj246087.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AllowDisplay")]
        public Boolean AllowDisplay_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether presence is enabled on the field.(s. https://msdn.microsoft.com/en-us/library/office/jj245245.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Presence")]
        public Boolean Presence_ { set; get; }
        /// <summary>
        /// <para>Gets or sets a value that specifies the identifier of the SharePoint group whose members can be selected as values of the field.(s. https://msdn.microsoft.com/en-us/library/office/jj244860.aspx) [Number]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("SelectionGroup")]
        public Int32 SelectionGroup_ { set; get; }
// undefined class SP.FieldUserSelectionMode : Object { }
        /// <summary>
        /// <para>Gets or sets a value that specifies whether users and groups or only users can be selected.(s. https://msdn.microsoft.com/en-us/library/office/jj245488.aspx)[SP.FieldUserSelectionMode]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("SelectionMode")]
        public Object SelectionMode_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public FieldUser(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(FieldUser));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  FieldUser()
        {
        }
        public  FieldUser(string json)
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
                usedFields.Add("AllowDisplay");
            HMS.SP.SPUtil.dyn_ValueSet("AllowDisplay", refObj, this);
                usedFields.Add("Presence");
            HMS.SP.SPUtil.dyn_ValueSet("Presence", refObj, this);
                usedFields.Add("SelectionGroup");
            HMS.SP.SPUtil.dyn_ValueSet("SelectionGroup", refObj, this);
                usedFields.Add("SelectionMode");
            HMS.SP.SPUtil.dyn_ValueSet("SelectionMode", refObj, this);
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

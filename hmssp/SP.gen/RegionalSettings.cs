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
    /// <para>https://msdn.microsoft.com/en-us/library/office/jj247219.aspx#properties</para>
    /// </summary>
    public class RegionalSettings : SPBase{
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
        /// <para>Gets or sets the number of days to extend or reduce the current month in Hijri calendars.(s. https://msdn.microsoft.com/en-us/library/office/jj246385.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AdjustHijriDays")]
        public Int16 AdjustHijriDays_ { set; get; }
        /// <summary>
        /// <para>Gets or sets an alternate calendar type that is used on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj246898.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AlternateCalendarType")]
        public Int16 AlternateCalendarType_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the string that is used to represent A.M. on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj245130.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("AM")]
        public Object AM_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets or sets the calendar type that is used on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj244936.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("CalendarType")]
        public Object CalendarType_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets or sets the first week of the year used in calendars on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj245864.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Collation")]
        public Object Collation_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the locale identifier (LCID) for the collation rules that are used on the site.(s. https://msdn.microsoft.com/en-us/library/office/jj246108.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("CollationLCID")]
        public Object CollationLCID_ { set; get; }
// undefined class SP.DateTimeFieldFormatType : Object { }
        /// <summary>
        /// <para>Gets the date format that is used on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj245010.aspx)[SP.DateTimeFieldFormatType]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DateFormat")]
        public Object DateFormat_ { set; get; }
        /// <summary>
        /// <para>Gets the separator that is used for dates on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj246435.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DateSeparator")]
        public String DateSeparator_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the separator that is used for decimals on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj246650.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DecimalSeparator")]
        public Object DecimalSeparator_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the separator that is used in grouping digits.(s. https://msdn.microsoft.com/en-us/library/office/jj245631.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("DigitGrouping")]
        public Object DigitGrouping_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets or sets the first day of the week used in calendars on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj246191.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("FirstDayOfWeek")]
        public Object FirstDayOfWeek_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets or sets the first week of the year used in calendars on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj247095.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("FirstWeekOfYear")]
        public Object FirstWeekOfYear_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets a Boolean value that indicates whether the Web site locale is an East Asian locale.(s. https://msdn.microsoft.com/en-us/library/office/jj245907.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("IsEastAsia")]
        public Object IsEastAsia_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the separator that is used for decimals on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj244844.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("IsRightToLeft")]
        public Object IsRightToLeft_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets a Boolean value that indicates whether the Web site user interface (UI) uses a right-to-left language.(s. https://msdn.microsoft.com/en-us/library/office/jj246233.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("IsUIRightToLeft")]
        public Object IsUIRightToLeft_ { set; get; }
        /// <summary>
        /// <para>Gets the separator used in lists on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj245224.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ListSeparator")]
        public String ListSeparator_ { set; get; }
        /// <summary>
        /// <para>Gets or sets the locale ID in use on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj246672.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("LocaleId")]
        public UInt32 LocaleId_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the symbol that is used to represent a negative sign on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj245419.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("NegativeSign")]
        public Object NegativeSign_ { set; get; }
        /// <summary>
        /// <para>Gets the negative number mode that is used for displaying negative numbers in calculated fields based on the locale of the server.(s. https://msdn.microsoft.com/en-us/library/office/jj245991.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("NegNumberMode")]
        public UInt32 NegNumberMode_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the string that is used to represent P.M. on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj245082.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("PM")]
        public Object PM_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the symbol that is used to represent a positive sign on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj245267.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("PositiveSign")]
        public Object PositiveSign_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets or sets a Boolean value that specifies whether to display the week number in day or week views of a calendar.(s. https://msdn.microsoft.com/en-us/library/office/jj245030.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ShowWeeks")]
        public Object ShowWeeks_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the thousand separator used for numbers on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj245966.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("ThousandSeparator")]
        public Object ThousandSeparator_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets or sets a Boolean value that specifies whether to use a 24-hour time format in representing the hours of the day.(s. https://msdn.microsoft.com/en-us/library/office/jj247152.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("Time24")]
        public Object Time24_ { set; get; }
        /// <summary>
        /// <para>Gets a value that indicates whether A.M. and P.M. appear before or after the time string.(s. https://msdn.microsoft.com/en-us/library/office/jj245723.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("TimeMarkerPosition")]
        public UInt32 TimeMarkerPosition_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets the time separator that is used on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj246858.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("TimeSeparator")]
        public Object TimeSeparator_ { set; get; }
        /// <summary>
        /// <para>Gets the time zone that is used on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj245450.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("TimeZone")]
        public SP.TimeZone TimeZone_ { set; get; }
        /// <summary>
        /// <para>Gets the collection of time zones used in a server farm.(s. https://msdn.microsoft.com/en-us/library/office/jj247008.aspx)</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("TimeZones")]
        public SP.TimeZoneCollection TimeZones_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets or sets the default hour at which the work day ends on the calendar that is in use on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj246324.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("WorkDayEndHour")]
        public Object WorkDayEndHour_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets or sets a number that represents the work days of Web site calendars.(s. https://msdn.microsoft.com/en-us/library/office/jj246987.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("WorkDays")]
        public Object WorkDays_ { set; get; }
// undefined class Undefined : Object { }
        /// <summary>
        /// <para>Gets or sets the default hour at which the work day starts on the calendar that is in use on the server.(s. https://msdn.microsoft.com/en-us/library/office/jj245186.aspx)[Undefined]</para>
        /// <para>R/W: </para>
        /// <para>Returned with resource:</para>
        /// </summary>
        [JsonProperty("WorkDayStartHour")]
        public Object WorkDayStartHour_ { set; get; }
        /// <summary>
        /// <para> Endpoints </para>
        /// </summary>
        static string[] endpoints = {
        };

        public RegionalSettings(ExpandoObject expObj)
        {
             try
             {
                var use_EO = ((dynamic)expObj).entry.content.properties;
                HMS.SP.SPUtil.expando2obj(use_EO, this, typeof(RegionalSettings));
             }
             catch (Exception ex)
             {
             
             }
        
        }
        // used by Newtonsoft.JSON 
        public  RegionalSettings()
        {
        }
        public  RegionalSettings(string json)
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
                usedFields.Add("AdjustHijriDays");
            HMS.SP.SPUtil.dyn_ValueSet("AdjustHijriDays", refObj, this);
                usedFields.Add("AlternateCalendarType");
            HMS.SP.SPUtil.dyn_ValueSet("AlternateCalendarType", refObj, this);
                usedFields.Add("AM");
            HMS.SP.SPUtil.dyn_ValueSet("AM", refObj, this);
                usedFields.Add("CalendarType");
            HMS.SP.SPUtil.dyn_ValueSet("CalendarType", refObj, this);
                usedFields.Add("Collation");
            HMS.SP.SPUtil.dyn_ValueSet("Collation", refObj, this);
                usedFields.Add("CollationLCID");
            HMS.SP.SPUtil.dyn_ValueSet("CollationLCID", refObj, this);
                usedFields.Add("DateFormat");
            HMS.SP.SPUtil.dyn_ValueSet("DateFormat", refObj, this);
                usedFields.Add("DateSeparator");
            HMS.SP.SPUtil.dyn_ValueSet("DateSeparator", refObj, this);
                usedFields.Add("DecimalSeparator");
            HMS.SP.SPUtil.dyn_ValueSet("DecimalSeparator", refObj, this);
                usedFields.Add("DigitGrouping");
            HMS.SP.SPUtil.dyn_ValueSet("DigitGrouping", refObj, this);
                usedFields.Add("FirstDayOfWeek");
            HMS.SP.SPUtil.dyn_ValueSet("FirstDayOfWeek", refObj, this);
                usedFields.Add("FirstWeekOfYear");
            HMS.SP.SPUtil.dyn_ValueSet("FirstWeekOfYear", refObj, this);
                usedFields.Add("IsEastAsia");
            HMS.SP.SPUtil.dyn_ValueSet("IsEastAsia", refObj, this);
                usedFields.Add("IsRightToLeft");
            HMS.SP.SPUtil.dyn_ValueSet("IsRightToLeft", refObj, this);
                usedFields.Add("IsUIRightToLeft");
            HMS.SP.SPUtil.dyn_ValueSet("IsUIRightToLeft", refObj, this);
                usedFields.Add("ListSeparator");
            HMS.SP.SPUtil.dyn_ValueSet("ListSeparator", refObj, this);
                usedFields.Add("LocaleId");
            HMS.SP.SPUtil.dyn_ValueSet("LocaleId", refObj, this);
                usedFields.Add("NegativeSign");
            HMS.SP.SPUtil.dyn_ValueSet("NegativeSign", refObj, this);
                usedFields.Add("NegNumberMode");
            HMS.SP.SPUtil.dyn_ValueSet("NegNumberMode", refObj, this);
                usedFields.Add("PM");
            HMS.SP.SPUtil.dyn_ValueSet("PM", refObj, this);
                usedFields.Add("PositiveSign");
            HMS.SP.SPUtil.dyn_ValueSet("PositiveSign", refObj, this);
                usedFields.Add("ShowWeeks");
            HMS.SP.SPUtil.dyn_ValueSet("ShowWeeks", refObj, this);
                usedFields.Add("ThousandSeparator");
            HMS.SP.SPUtil.dyn_ValueSet("ThousandSeparator", refObj, this);
                usedFields.Add("Time24");
            HMS.SP.SPUtil.dyn_ValueSet("Time24", refObj, this);
                usedFields.Add("TimeMarkerPosition");
            HMS.SP.SPUtil.dyn_ValueSet("TimeMarkerPosition", refObj, this);
                usedFields.Add("TimeSeparator");
            HMS.SP.SPUtil.dyn_ValueSet("TimeSeparator", refObj, this);
                usedFields.Add("TimeZone");
            this.TimeZone_ = new SP.TimeZone(HMS.SP.SPUtil.dyn_toString(refObj.TimeZone));
                usedFields.Add("TimeZones");
            this.TimeZones_ = new SP.TimeZoneCollection(HMS.SP.SPUtil.dyn_toString(refObj.TimeZones));
                usedFields.Add("WorkDayEndHour");
            HMS.SP.SPUtil.dyn_ValueSet("WorkDayEndHour", refObj, this);
                usedFields.Add("WorkDays");
            HMS.SP.SPUtil.dyn_ValueSet("WorkDays", refObj, this);
                usedFields.Add("WorkDayStartHour");
            HMS.SP.SPUtil.dyn_ValueSet("WorkDayStartHour", refObj, this);
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

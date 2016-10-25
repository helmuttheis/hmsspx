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
        public int add_RegionalSettings(int level, HMS.SP.RegionalSettings spRegionalSettings)
        {
            return add_RegionalSettings(-1, level, spRegionalSettings);
        }
        public int  add_RegionalSettings(int pos, int level, HMS.SP.RegionalSettings spRegionalSettings)
        {
            if (spRegionalSettings.__HMSError_ != null && (spRegionalSettings.__HMSError_.errno != 0 || spRegionalSettings.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spRegionalSettings.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spRegionalSettings.__deferred_);
            pos = this.add__metadata(pos, level, spRegionalSettings.__metadata_);
            pos = this.add__rest(pos, level, spRegionalSettings.__rest);
            pos = this.add_lineAt(pos,level,  "AdjustHijriDays", HMS.SP.SPUtil.toString(spRegionalSettings.AdjustHijriDays_)); //Int16;
            pos = this.add_lineAt(pos,level,  "AlternateCalendarType", HMS.SP.SPUtil.toString(spRegionalSettings.AlternateCalendarType_)); //Int16;
            pos = this.add_lineAt(pos,level,  "AM", HMS.SP.SPUtil.toString(spRegionalSettings.AM_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "CalendarType", HMS.SP.SPUtil.toString(spRegionalSettings.CalendarType_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "Collation", HMS.SP.SPUtil.toString(spRegionalSettings.Collation_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "CollationLCID", HMS.SP.SPUtil.toString(spRegionalSettings.CollationLCID_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "DateFormat", HMS.SP.SPUtil.toString(spRegionalSettings.DateFormat_)); //DateTimeFieldFormatType;
            pos = this.add_lineAt(pos,level,  "DateSeparator", HMS.SP.SPUtil.toString(spRegionalSettings.DateSeparator_)); //String;
            pos = this.add_lineAt(pos,level,  "DecimalSeparator", HMS.SP.SPUtil.toString(spRegionalSettings.DecimalSeparator_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "DigitGrouping", HMS.SP.SPUtil.toString(spRegionalSettings.DigitGrouping_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "FirstDayOfWeek", HMS.SP.SPUtil.toString(spRegionalSettings.FirstDayOfWeek_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "FirstWeekOfYear", HMS.SP.SPUtil.toString(spRegionalSettings.FirstWeekOfYear_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "IsEastAsia", HMS.SP.SPUtil.toString(spRegionalSettings.IsEastAsia_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "IsRightToLeft", HMS.SP.SPUtil.toString(spRegionalSettings.IsRightToLeft_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "IsUIRightToLeft", HMS.SP.SPUtil.toString(spRegionalSettings.IsUIRightToLeft_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "ListSeparator", HMS.SP.SPUtil.toString(spRegionalSettings.ListSeparator_)); //String;
            pos = this.add_lineAt(pos,level,  "LocaleId", HMS.SP.SPUtil.toString(spRegionalSettings.LocaleId_)); //UInt32;
            pos = this.add_lineAt(pos,level,  "NegativeSign", HMS.SP.SPUtil.toString(spRegionalSettings.NegativeSign_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "NegNumberMode", HMS.SP.SPUtil.toString(spRegionalSettings.NegNumberMode_)); //UInt32;
            pos = this.add_lineAt(pos,level,  "PM", HMS.SP.SPUtil.toString(spRegionalSettings.PM_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "PositiveSign", HMS.SP.SPUtil.toString(spRegionalSettings.PositiveSign_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "ShowWeeks", HMS.SP.SPUtil.toString(spRegionalSettings.ShowWeeks_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "ThousandSeparator", HMS.SP.SPUtil.toString(spRegionalSettings.ThousandSeparator_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "Time24", HMS.SP.SPUtil.toString(spRegionalSettings.Time24_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "TimeMarkerPosition", HMS.SP.SPUtil.toString(spRegionalSettings.TimeMarkerPosition_)); //UInt32;
            pos = this.add_lineAt(pos,level,  "TimeSeparator", HMS.SP.SPUtil.toString(spRegionalSettings.TimeSeparator_)); //Undefined;
            pos = this.add_deferredAt(pos,level, "TimeZone", "...", knownPages.pageTimeZone , spRegionalSettings.TimeZone_.__deferred_); //TimeZone;
            pos = this.add_deferredAt(pos,level, "TimeZones", "...", myType.GetType("SP.TimeZone"), spRegionalSettings.TimeZones_.__deferred_); //TimeZone;
            pos = this.add_lineAt(pos,level,  "WorkDayEndHour", HMS.SP.SPUtil.toString(spRegionalSettings.WorkDayEndHour_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "WorkDays", HMS.SP.SPUtil.toString(spRegionalSettings.WorkDays_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "WorkDayStartHour", HMS.SP.SPUtil.toString(spRegionalSettings.WorkDayStartHour_)); //Undefined;
            return pos;
        }
        public int add_RegionalSettings_deferred(int pos, int level, HMS.SP.RegionalSettings spRegionalSettings)
        {
            {
                string useUrl = spRegionalSettings.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "RegionalSettings","", knownPages.pageRegionalSettings, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "RegionalSettings", "",knownPages.NONE, "");
                    pos = this.add_RegionalSettings(pos, level+1, spRegionalSettings);
                }
            }
        return pos;
        }
    }
}

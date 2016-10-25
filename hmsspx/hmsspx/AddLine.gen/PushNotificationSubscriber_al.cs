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
        public int add_PushNotificationSubscriber(int level, HMS.SP.PushNotificationSubscriber spPushNotificationSubscriber)
        {
            return add_PushNotificationSubscriber(-1, level, spPushNotificationSubscriber);
        }
        public int  add_PushNotificationSubscriber(int pos, int level, HMS.SP.PushNotificationSubscriber spPushNotificationSubscriber)
        {
            if (spPushNotificationSubscriber.__HMSError_ != null && (spPushNotificationSubscriber.__HMSError_.errno != 0 || spPushNotificationSubscriber.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spPushNotificationSubscriber.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spPushNotificationSubscriber.__deferred_);
            pos = this.add__metadata(pos, level, spPushNotificationSubscriber.__metadata_);
            pos = this.add__rest(pos, level, spPushNotificationSubscriber.__rest);
            pos = this.add_lineAt(pos,level,  "CustomArgs", HMS.SP.SPUtil.toString(spPushNotificationSubscriber.CustomArgs_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "DeviceAppInstanceId", HMS.SP.SPUtil.toString(spPushNotificationSubscriber.DeviceAppInstanceId_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "LastModifiedTimeStamp", HMS.SP.SPUtil.toString(spPushNotificationSubscriber.LastModifiedTimeStamp_)); //Object;
            pos = this.add_lineAt(pos,level,  "RegistrationTimeStamp", HMS.SP.SPUtil.toString(spPushNotificationSubscriber.RegistrationTimeStamp_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "ServiceToken", HMS.SP.SPUtil.toString(spPushNotificationSubscriber.ServiceToken_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "SubscriberType", HMS.SP.SPUtil.toString(spPushNotificationSubscriber.SubscriberType_)); //Undefined;
            pos = this.add_deferredAt(pos,level, "User", "...", knownPages.pageUser , spPushNotificationSubscriber.User_.__deferred_); //User;
            return pos;
        }
        public int add_PushNotificationSubscriber_deferred(int pos, int level, HMS.SP.PushNotificationSubscriber spPushNotificationSubscriber)
        {
            {
                string useUrl = spPushNotificationSubscriber.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "PushNotificationSubscriber","", knownPages.pagePushNotificationSubscriber, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "PushNotificationSubscriber", "",knownPages.NONE, "");
                    pos = this.add_PushNotificationSubscriber(pos, level+1, spPushNotificationSubscriber);
                }
            }
        return pos;
        }
    }
}

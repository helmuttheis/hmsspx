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
using System.Threading.Tasks; 

namespace hmsspx
{
    partial class SPGet
    {
        public static async Task<HMS.SP.AppLicenseCollection> getAppLicenseCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.AppLicenseCollection(ret);
        }
        public static async Task<HMS.SP.AttachmentCollection> getAttachmentCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.AttachmentCollection(ret);
        }
        public static async Task<HMS.SP.ChangeCollection> getChangeCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ChangeCollection(ret);
        }
        public static async Task<HMS.SP.ContentTypeCollection> getContentTypeCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ContentTypeCollection(ret);
        }
        public static async Task<HMS.SP.EventReceiverDefinitionCollection> getEventReceiverDefinitionCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.EventReceiverDefinitionCollection(ret);
        }
        public static async Task<HMS.SP.FeatureCollection> getFeatureCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FeatureCollection(ret);
        }
        public static async Task<HMS.SP.FieldCollection> getFieldCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldCollection(ret);
        }
        public static async Task<HMS.SP.FieldLinkCollection> getFieldLinkCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldLinkCollection(ret);
        }
        public static async Task<HMS.SP.FileCollection> getFileCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FileCollection(ret);
        }
        public static async Task<HMS.SP.FileVersionCollection> getFileVersionCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FileVersionCollection(ret);
        }
        public static async Task<HMS.SP.FolderCollection> getFolderCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FolderCollection(ret);
        }
        public static async Task<HMS.SP.FormCollection> getFormCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FormCollection(ret);
        }
        public static async Task<HMS.SP.GroupCollection> getGroupCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.GroupCollection(ret);
        }
        public static async Task<HMS.SP.ListCollection> getListCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ListCollection(ret);
        }
        public static async Task<HMS.SP.ListItemCollection> getListItemCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ListItemCollection(ret);
        }
        public static async Task<HMS.SP.ListItemEntityCollection> getListItemEntityCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ListItemEntityCollection(ret);
        }
        public static async Task<HMS.SP.ListTemplateCollection> getListTemplateCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ListTemplateCollection(ret);
        }
        public static async Task<HMS.SP.NavigationNodeCollection> getNavigationNodeCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.NavigationNodeCollection(ret);
        }
        public static async Task<HMS.SP.PushNotificationSubscriberCollection> getPushNotificationSubscriberCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.PushNotificationSubscriberCollection(ret);
        }
        public static async Task<HMS.SP.RecycleBinItemCollection> getRecycleBinItemCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RecycleBinItemCollection(ret);
        }
        public static async Task<HMS.SP.RelatedFieldCollection> getRelatedFieldCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RelatedFieldCollection(ret);
        }
        public static async Task<HMS.SP.RelatedFieldExtendedDataCollection> getRelatedFieldExtendedDataCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RelatedFieldExtendedDataCollection(ret);
        }
        public static async Task<HMS.SP.RoleAssignmentCollection> getRoleAssignmentCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RoleAssignmentCollection(ret);
        }
        public static async Task<HMS.SP.RoleDefinitionBindingCollection> getRoleDefinitionBindingCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RoleDefinitionBindingCollection(ret);
        }
        public static async Task<HMS.SP.RoleDefinitionCollection> getRoleDefinitionCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RoleDefinitionCollection(ret);
        }
        public static async Task<HMS.SP.TimeZoneCollection> getTimeZoneCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.TimeZoneCollection(ret);
        }
        public static async Task<HMS.SP.UserCollection> getUserCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.UserCollection(ret);
        }
        public static async Task<HMS.SP.UserCustomActionCollection> getUserCustomActionCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.UserCustomActionCollection(ret);
        }
        public static async Task<HMS.SP.ViewCollection> getViewCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ViewCollection(ret);
        }
        public static async Task<HMS.SP.ViewFieldCollection> getViewFieldCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ViewFieldCollection(ret);
        }
        public static async Task<HMS.SP.WebCollection> getWebCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.WebCollection(ret);
        }
        public static async Task<HMS.SP.WebTemplateCollection> getWebTemplateCollection(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.WebTemplateCollection(ret);
        }
    }
}

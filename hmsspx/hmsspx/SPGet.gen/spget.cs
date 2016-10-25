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
        public static async Task<HMS.SP.AccessRequests> getAccessRequests(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.AccessRequests(ret);
        }
        public static async Task<HMS.SP.AlternateUrl> getAlternateUrl(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.AlternateUrl(ret);
        }
        public static async Task<HMS.SP.App> getApp(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.App(ret);
        }
        public static async Task<HMS.SP.AppCatalog> getAppCatalog(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.AppCatalog(ret);
        }
        public static async Task<HMS.SP.Site> getSite(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.Site(ret);
        }
        public static async Task<HMS.SP.Web> getWeb(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.Web(ret);
        }
        public static async Task<HMS.SP.AppContextSite> getAppContextSite(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.AppContextSite(ret);
        }
        public static async Task<HMS.SP.AppInstance> getAppInstance(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.AppInstance(ret);
        }
        public static async Task<HMS.SP.AppInstanceErrorDetails> getAppInstanceErrorDetails(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.AppInstanceErrorDetails(ret);
        }
        public static async Task<HMS.SP.AppLicense> getAppLicense(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.AppLicense(ret);
        }
        public static async Task<HMS.SP.AppPrincipalConfiguration> getAppPrincipalConfiguration(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.AppPrincipalConfiguration(ret);
        }
        public static async Task<HMS.SP.AppPrincipalCredentialReference> getAppPrincipalCredentialReference(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.AppPrincipalCredentialReference(ret);
        }
        public static async Task<HMS.SP.Attachment> getAttachment(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.Attachment(ret);
        }
        public static async Task<HMS.SP.AttachmentCreationInformation> getAttachmentCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.AttachmentCreationInformation(ret);
        }
        public static async Task<HMS.SP.BasePermissions> getBasePermissions(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.BasePermissions(ret);
        }
        public static async Task<HMS.SP.ListItemCollectionPosition> getListItemCollectionPosition(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ListItemCollectionPosition(ret);
        }
        public static async Task<HMS.SP.CamlQuery> getCamlQuery(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.CamlQuery(ret);
        }
        public static async Task<HMS.SP.ChangeToken> getChangeToken(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ChangeToken(ret);
        }
        public static async Task<HMS.SP.Change> getChange(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.Change(ret);
        }
        public static async Task<HMS.SP.ChangeAlert> getChangeAlert(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ChangeAlert(ret);
        }
        public static async Task<HMS.SP.ContentTypeId> getContentTypeId(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ContentTypeId(ret);
        }
        public static async Task<HMS.SP.ChangeContentType> getChangeContentType(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ChangeContentType(ret);
        }
        public static async Task<HMS.SP.ChangeField> getChangeField(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ChangeField(ret);
        }
        public static async Task<HMS.SP.ChangeFile> getChangeFile(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ChangeFile(ret);
        }
        public static async Task<HMS.SP.ChangeFolder> getChangeFolder(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ChangeFolder(ret);
        }
        public static async Task<HMS.SP.ChangeGroup> getChangeGroup(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ChangeGroup(ret);
        }
        public static async Task<HMS.SP.ChangeItem> getChangeItem(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ChangeItem(ret);
        }
        public static async Task<HMS.SP.ChangeList> getChangeList(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ChangeList(ret);
        }
        public static async Task<HMS.SP.ChangeLogItemQuery> getChangeLogItemQuery(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ChangeLogItemQuery(ret);
        }
        public static async Task<HMS.SP.ChangeQuery> getChangeQuery(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ChangeQuery(ret);
        }
        public static async Task<HMS.SP.ChangeUser> getChangeUser(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ChangeUser(ret);
        }
        public static async Task<HMS.SP.ChangeView> getChangeView(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ChangeView(ret);
        }
        public static async Task<HMS.SP.ChangeWeb> getChangeWeb(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ChangeWeb(ret);
        }
        public static async Task<HMS.SP.ClientContext> getClientContext(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ClientContext(ret);
        }
        public static async Task<HMS.SP.ContentType> getContentType(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ContentType(ret);
        }
        public static async Task<HMS.SP.ContentTypeCreationInformation> getContentTypeCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ContentTypeCreationInformation(ret);
        }
        public static async Task<HMS.SP.ContextWebInformation> getContextWebInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ContextWebInformation(ret);
        }
        public static async Task<HMS.SP.DocumentLibraryInformation> getDocumentLibraryInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.DocumentLibraryInformation(ret);
        }
        public static async Task<HMS.SP.EventReceiverDefinition> getEventReceiverDefinition(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.EventReceiverDefinition(ret);
        }
        public static async Task<HMS.SP.EventReceiverDefinitionCreationInformation> getEventReceiverDefinitionCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.EventReceiverDefinitionCreationInformation(ret);
        }
        public static async Task<HMS.SP.ExternalAppPrincipalCreationParameters> getExternalAppPrincipalCreationParameters(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ExternalAppPrincipalCreationParameters(ret);
        }
        public static async Task<HMS.SP.Feature> getFeature(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.Feature(ret);
        }
        public static async Task<HMS.SP.Field> getField(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.Field(ret);
        }
        public static async Task<HMS.SP.FieldCalculated> getFieldCalculated(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldCalculated(ret);
        }
        public static async Task<HMS.SP.FieldCalculatedErrorValue> getFieldCalculatedErrorValue(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldCalculatedErrorValue(ret);
        }
        public static async Task<HMS.SP.FieldChoice> getFieldChoice(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldChoice(ret);
        }
        public static async Task<HMS.SP.FieldComputed> getFieldComputed(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldComputed(ret);
        }
        public static async Task<HMS.SP.FieldCreationInformation> getFieldCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldCreationInformation(ret);
        }
        public static async Task<HMS.SP.FieldCurrency> getFieldCurrency(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldCurrency(ret);
        }
        public static async Task<HMS.SP.FieldDateTime> getFieldDateTime(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldDateTime(ret);
        }
        public static async Task<HMS.SP.FieldGeolocationValue> getFieldGeolocationValue(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldGeolocationValue(ret);
        }
        public static async Task<HMS.SP.FieldLink> getFieldLink(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldLink(ret);
        }
        public static async Task<HMS.SP.FieldLinkCreationInformation> getFieldLinkCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldLinkCreationInformation(ret);
        }
        public static async Task<HMS.SP.FieldLookup> getFieldLookup(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldLookup(ret);
        }
        public static async Task<HMS.SP.FieldLookupValue> getFieldLookupValue(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldLookupValue(ret);
        }
        public static async Task<HMS.SP.FieldMultiChoice> getFieldMultiChoice(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldMultiChoice(ret);
        }
        public static async Task<HMS.SP.FieldMultiLineText> getFieldMultiLineText(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldMultiLineText(ret);
        }
        public static async Task<HMS.SP.FieldNumber> getFieldNumber(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldNumber(ret);
        }
        public static async Task<HMS.SP.FieldRatingScale> getFieldRatingScale(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldRatingScale(ret);
        }
        public static async Task<HMS.SP.FieldRatingScaleQuestionAnswer> getFieldRatingScaleQuestionAnswer(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldRatingScaleQuestionAnswer(ret);
        }
        public static async Task<HMS.SP.FieldStringValues> getFieldStringValues(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldStringValues(ret);
        }
        public static async Task<HMS.SP.FieldText> getFieldText(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldText(ret);
        }
        public static async Task<HMS.SP.FieldUrl> getFieldUrl(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldUrl(ret);
        }
        public static async Task<HMS.SP.FieldUrlValue> getFieldUrlValue(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldUrlValue(ret);
        }
        public static async Task<HMS.SP.FieldUser> getFieldUser(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldUser(ret);
        }
        public static async Task<HMS.SP.FieldUserValue> getFieldUserValue(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FieldUserValue(ret);
        }
        public static async Task<HMS.SP.User> getUser(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.User(ret);
        }
        public static async Task<HMS.SP.ListItem> getListItem(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ListItem(ret);
        }
        public static async Task<HMS.SP.File> getFile(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.File(ret);
        }
        public static async Task<HMS.SP.FileCreationInformation> getFileCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FileCreationInformation(ret);
        }
        public static async Task<HMS.SP.FileSaveBinaryInformation> getFileSaveBinaryInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FileSaveBinaryInformation(ret);
        }
        public static async Task<HMS.SP.FileVersion> getFileVersion(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.FileVersion(ret);
        }
        public static async Task<HMS.SP.Folder> getFolder(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.Folder(ret);
        }
        public static async Task<HMS.SP.PropertyValues> getPropertyValues(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.PropertyValues(ret);
        }
        public static async Task<HMS.SP.Form> getForm(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.Form(ret);
        }
        public static async Task<HMS.SP.Principal> getPrincipal(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.Principal(ret);
        }
        public static async Task<HMS.SP.Group> getGroup(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.Group(ret);
        }
        public static async Task<HMS.SP.GroupCreationInformation> getGroupCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.GroupCreationInformation(ret);
        }
        public static async Task<HMS.SP.Implementationnotes> getImplementationnotes(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.Implementationnotes(ret);
        }
        public static async Task<HMS.SP.InformationRightsManagementSettings> getInformationRightsManagementSettings(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.InformationRightsManagementSettings(ret);
        }
        public static async Task<HMS.SP.KeyValue> getKeyValue(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.KeyValue(ret);
        }
        public static async Task<HMS.SP.Language> getLanguage(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.Language(ret);
        }
        public static async Task<HMS.SP.ListDataSource> getListDataSource(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ListDataSource(ret);
        }
        public static async Task<HMS.SP.View> getView(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.View(ret);
        }
        public static async Task<HMS.SP.SecurableObject> getSecurableObject(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.SecurableObject(ret);
        }
        public static async Task<HMS.SP.List> getList(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.List(ret);
        }
        public static async Task<HMS.SP.ListCreationInformation> getListCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ListCreationInformation(ret);
        }
        public static async Task<HMS.SP.ListDataValidationFailure> getListDataValidationFailure(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ListDataValidationFailure(ret);
        }
        public static async Task<HMS.SP.ListDataValidationExceptionValue> getListDataValidationExceptionValue(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ListDataValidationExceptionValue(ret);
        }
        public static async Task<HMS.SP.ListItemCreationInformation> getListItemCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ListItemCreationInformation(ret);
        }
        public static async Task<HMS.SP.ListItemFormUpdateValue> getListItemFormUpdateValue(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ListItemFormUpdateValue(ret);
        }
        public static async Task<HMS.SP.ListTemplate> getListTemplate(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ListTemplate(ret);
        }
        public static async Task<HMS.SP.MenuNode> getMenuNode(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.MenuNode(ret);
        }
        public static async Task<HMS.SP.MenuState> getMenuState(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.MenuState(ret);
        }
        public static async Task<HMS.SP.Navigation> getNavigation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.Navigation(ret);
        }
        public static async Task<HMS.SP.NavigationNode> getNavigationNode(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.NavigationNode(ret);
        }
        public static async Task<HMS.SP.NavigationNodeCreationInformation> getNavigationNodeCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.NavigationNodeCreationInformation(ret);
        }
        public static async Task<HMS.SP.ObjectSharingInformation> getObjectSharingInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ObjectSharingInformation(ret);
        }
        public static async Task<HMS.SP.ObjectSharingInformationUser> getObjectSharingInformationUser(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ObjectSharingInformationUser(ret);
        }
        public static async Task<HMS.SP.PushNotificationSubscriber> getPushNotificationSubscriber(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.PushNotificationSubscriber(ret);
        }
        public static async Task<HMS.SP.RecycleBinItem> getRecycleBinItem(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RecycleBinItem(ret);
        }
        public static async Task<HMS.SP.TimeZone> getTimeZone(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.TimeZone(ret);
        }
        public static async Task<HMS.SP.RegionalSettings> getRegionalSettings(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RegionalSettings(ret);
        }
        public static async Task<HMS.SP.RelatedField> getRelatedField(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RelatedField(ret);
        }
        public static async Task<HMS.SP.RelatedFieldExtendedData> getRelatedFieldExtendedData(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RelatedFieldExtendedData(ret);
        }
        public static async Task<HMS.SP.RelatedItem> getRelatedItem(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RelatedItem(ret);
        }
        public static async Task<HMS.SP.RelatedItemManager> getRelatedItemManager(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RelatedItemManager(ret);
        }
        public static async Task<HMS.SP.RenderListDataParameters> getRenderListDataParameters(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RenderListDataParameters(ret);
        }
        public static async Task<HMS.SP.RequestContext> getRequestContext(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RequestContext(ret);
        }
        public static async Task<HMS.SP.RequestVariable> getRequestVariable(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RequestVariable(ret);
        }
        public static async Task<HMS.SP.RoleAssignment> getRoleAssignment(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RoleAssignment(ret);
        }
        public static async Task<HMS.SP.RoleDefinition> getRoleDefinition(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RoleDefinition(ret);
        }
        public static async Task<HMS.SP.RoleDefinitionCreationInformation> getRoleDefinitionCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.RoleDefinitionCreationInformation(ret);
        }
        public static async Task<HMS.SP.ServerSettings> getServerSettings(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ServerSettings(ret);
        }
        public static async Task<HMS.SP.SimpleDataRow> getSimpleDataRow(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.SimpleDataRow(ret);
        }
        public static async Task<HMS.SP.SimpleDataTable> getSimpleDataTable(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.SimpleDataTable(ret);
        }
        public static async Task<HMS.SP.UsageInfo> getUsageInfo(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.UsageInfo(ret);
        }
        public static async Task<HMS.SP.SubwebQuery> getSubwebQuery(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.SubwebQuery(ret);
        }
        public static async Task<HMS.SP.ThemeInfo> getThemeInfo(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ThemeInfo(ret);
        }
        public static async Task<HMS.SP.TimeZoneInformation> getTimeZoneInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.TimeZoneInformation(ret);
        }
        public static async Task<HMS.SP.ULS> getULS(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ULS(ret);
        }
        public static async Task<HMS.SP.UpgradeInfo> getUpgradeInfo(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.UpgradeInfo(ret);
        }
        public static async Task<HMS.SP.UserIdInfo> getUserIdInfo(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.UserIdInfo(ret);
        }
        public static async Task<HMS.SP.UserCreationInformation> getUserCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.UserCreationInformation(ret);
        }
        public static async Task<HMS.SP.UserCustomAction> getUserCustomAction(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.UserCustomAction(ret);
        }
        public static async Task<HMS.SP.ViewCreationInformation> getViewCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.ViewCreationInformation(ret);
        }
        public static async Task<HMS.SP.WebInformation> getWebInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.WebInformation(ret);
        }
        public static async Task<HMS.SP.WebCreationInformation> getWebCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.WebCreationInformation(ret);
        }
        public static async Task<HMS.SP.WebInfoCreationInformation> getWebInfoCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.WebInfoCreationInformation(ret);
        }
        public static async Task<HMS.SP.WebProxy> getWebProxy(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.WebProxy(ret);
        }
        public static async Task<HMS.SP.WebRequestInfo> getWebRequestInfo(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.WebRequestInfo(ret);
        }
        public static async Task<HMS.SP.WebResponseInfo> getWebResponseInfo(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.WebResponseInfo(ret);
        }
        public static async Task<HMS.SP.WebTemplate> getWebTemplate(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.WebTemplate(ret);
        }
        public static async Task<HMS.SP.XmlSchemaFieldCreationInformation> getXmlSchemaFieldCreationInformation(HMS.Auth.Login myClient,string url)
        {
            string ret = await myClient.getJSON(url);
            return new HMS.SP.XmlSchemaFieldCreationInformation(ret);
        }
    }
}

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

/*
 * This file contains the missing SharePoint classes.
 * In an ideal world, this should be empty.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.SP
{
    
    // class ContentTypeCollection    {        SP.ContentType[] items;    }

    // class InformationRightsManagementSettings : Object { }
    // class EventReceiverDefinitionCollection    {        SP.EventReceiverDefinition[] items;    }
    // class SecurableObject : Object { }
    // class FormCollection    {        SP.Form[] items;    }
    // class ViewCollection : Object { }
    public class EventReceiverCollection: SPMissingCollection
    {

        public List<Object> items;// SP.EventReceiver[] items;
        public EventReceiverCollection() { }
        public EventReceiverCollection(string json) { }
    }
    // class FeatureCollection    {        SP.Feature[] items;    }
    public class FolderCollection : SPMissingCollection
    {

        public List<HMS.SP.Folder> items;

        public FolderCollection() { }
        public FolderCollection(string json) { }
    }
    public class FileCollection : SPMissingCollection
    {
        public List<HMS.SP.File> items;
        public FileCollection() { }
        public FileCollection(string json) { }
    }
    public class FileVersionCollection : SPMissingCollection
    {
        public List<HMS.SP.FileVersion> items;
        public FileVersionCollection() { }
        public FileVersionCollection(string json) { }
    }
    // class AttachmentCollection    {        SP.Attachment[] items;    }

    // class ListTemplateCollection    {        SP.ListTemplate[] items;    }
    public class WorkflowAssociationCollection : SPMissingCollection
    {
        public List<Object> items;// SP.WorkflowAssociation[] items;
        public WorkflowAssociationCollection() { }
        public WorkflowAssociationCollection(string json) { }
    }
    public class WorkflowTemplateCollection : SPMissingCollection
    {
        public Object[] items;// SP.WorkflowTemplate[] items;
        public WorkflowTemplateCollection() { }
        public WorkflowTemplateCollection(string json) { }
    }
    // class WebInformation { }
    // class Navigation { }

    // class PushNotificationSubscriberCollection    {        SP.PushNotificationSubscriber[] items;    }
    public class RecycleBin
    {
        public RecycleBin() { }
        public RecycleBin(string json) { }
    }
    // class ThemeInfo { }
    public class SPObj
    {
        public SPObj() { }
        public SPObj(string json) { }
    }
    public class SPMissingCollection :SPObj
    {
        public long Count;
        public HMS.Util.__HMSError __HMSError_ { set; get; }
        public SP.__status __status_ { set; get; }
        public SP.__deferred __deferred_ { set; get; }

    }
}
namespace HMS.SP.Workflow
{
    public class WorkflowAssociationCollection
    {
        public WorkflowAssociationCollection() { }
        public WorkflowAssociationCollection(string json) { }
    }
}
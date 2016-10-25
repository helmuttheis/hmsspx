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
        public int add_UserCustomAction(int level, HMS.SP.UserCustomAction spUserCustomAction)
        {
            return add_UserCustomAction(-1, level, spUserCustomAction);
        }
        public int  add_UserCustomAction(int pos, int level, HMS.SP.UserCustomAction spUserCustomAction)
        {
            if (spUserCustomAction.__HMSError_ != null && (spUserCustomAction.__HMSError_.errno != 0 || spUserCustomAction.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spUserCustomAction.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spUserCustomAction.__deferred_);
            pos = this.add__metadata(pos, level, spUserCustomAction.__metadata_);
            pos = this.add__rest(pos, level, spUserCustomAction.__rest);
            pos = this.add_lineAt(pos,level,  "CommandUIExtension", HMS.SP.SPUtil.toString(spUserCustomAction.CommandUIExtension_)); //String;
            pos = this.add_lineAt(pos,level,  "Description", HMS.SP.SPUtil.toString(spUserCustomAction.Description_)); //String;
            pos = this.add_lineAt(pos,level,  "Group", HMS.SP.SPUtil.toString(spUserCustomAction.Group_)); //String;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spUserCustomAction.Id_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "ImageUrl", HMS.SP.SPUtil.toString(spUserCustomAction.ImageUrl_)); //String;
            pos = this.add_lineAt(pos,level,  "Location", HMS.SP.SPUtil.toString(spUserCustomAction.Location_)); //String;
            pos = this.add_lineAt(pos,level,  "Name", HMS.SP.SPUtil.toString(spUserCustomAction.Name_)); //String;
            pos = this.add_lineAt(pos,level,  "RegistrationId", HMS.SP.SPUtil.toString(spUserCustomAction.RegistrationId_)); //String;
            pos = this.add_lineAt(pos,level,  "RegistrationType", HMS.SP.SPUtil.toString(spUserCustomAction.RegistrationType_)); //UserCustomActionRegistrationType;
            pos = this.add_deferredAt(pos,level, "Rights", "...", knownPages.pageBasePermissions , spUserCustomAction.Rights_.__deferred_); //BasePermissions;
            pos = this.add_lineAt(pos,level,  "Scope", HMS.SP.SPUtil.toString(spUserCustomAction.Scope_)); //String;
            pos = this.add_lineAt(pos,level,  "ScriptBlock", HMS.SP.SPUtil.toString(spUserCustomAction.ScriptBlock_)); //String;
            pos = this.add_lineAt(pos,level,  "ScriptSrc", HMS.SP.SPUtil.toString(spUserCustomAction.ScriptSrc_)); //String;
            pos = this.add_lineAt(pos,level,  "Sequence", HMS.SP.SPUtil.toString(spUserCustomAction.Sequence_)); //Number;
            pos = this.add_lineAt(pos,level,  "Title", HMS.SP.SPUtil.toString(spUserCustomAction.Title_)); //String;
            pos = this.add_lineAt(pos,level,  "Url", HMS.SP.SPUtil.toString(spUserCustomAction.Url_)); //String;
            pos = this.add_lineAt(pos,level,  "VersionOfUserCustomAction", HMS.SP.SPUtil.toString(spUserCustomAction.VersionOfUserCustomAction_)); //String;
            return pos;
        }
        public int add_UserCustomAction_deferred(int pos, int level, HMS.SP.UserCustomAction spUserCustomAction)
        {
            {
                string useUrl = spUserCustomAction.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "UserCustomAction","", knownPages.pageUserCustomAction, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "UserCustomAction", "",knownPages.NONE, "");
                    pos = this.add_UserCustomAction(pos, level+1, spUserCustomAction);
                }
            }
        return pos;
        }
    }
}

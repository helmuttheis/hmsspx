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
        public int add_RoleDefinition(int level, HMS.SP.RoleDefinition spRoleDefinition)
        {
            return add_RoleDefinition(-1, level, spRoleDefinition);
        }
        public int  add_RoleDefinition(int pos, int level, HMS.SP.RoleDefinition spRoleDefinition)
        {
            if (spRoleDefinition.__HMSError_ != null && (spRoleDefinition.__HMSError_.errno != 0 || spRoleDefinition.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spRoleDefinition.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spRoleDefinition.__deferred_);
            pos = this.add__metadata(pos, level, spRoleDefinition.__metadata_);
            pos = this.add__rest(pos, level, spRoleDefinition.__rest);
            pos = this.add_deferredAt(pos,level, "BasePermissions", "...", knownPages.pageBasePermissions , spRoleDefinition.BasePermissions_.__deferred_); //BasePermissions;
            pos = this.add_lineAt(pos,level,  "Description", HMS.SP.SPUtil.toString(spRoleDefinition.Description_)); //String;
            pos = this.add_lineAt(pos,level,  "Hidden", HMS.SP.SPUtil.toString(spRoleDefinition.Hidden_)); //Boolean;
            pos = this.add_lineAt(pos,level,  "Id", HMS.SP.SPUtil.toString(spRoleDefinition.Id_)); //Undefined;
            pos = this.add_lineAt(pos,level,  "Name", HMS.SP.SPUtil.toString(spRoleDefinition.Name_)); //String;
            pos = this.add_lineAt(pos,level,  "Order", HMS.SP.SPUtil.toString(spRoleDefinition.Order_)); //Number;
            pos = this.add_lineAt(pos,level,  "RoleTypeKind", HMS.SP.SPUtil.toString(spRoleDefinition.RoleTypeKind_)); //RoleType;
            return pos;
        }
        public int add_RoleDefinition_deferred(int pos, int level, HMS.SP.RoleDefinition spRoleDefinition)
        {
            {
                string useUrl = spRoleDefinition.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "RoleDefinition","", knownPages.pageRoleDefinition, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "RoleDefinition", "",knownPages.NONE, "");
                    pos = this.add_RoleDefinition(pos, level+1, spRoleDefinition);
                }
            }
        return pos;
        }
    }
}

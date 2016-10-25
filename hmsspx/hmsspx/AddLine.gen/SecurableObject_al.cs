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
        public int add_SecurableObject(int level, HMS.SP.SecurableObject spSecurableObject)
        {
            return add_SecurableObject(-1, level, spSecurableObject);
        }
        public int  add_SecurableObject(int pos, int level, HMS.SP.SecurableObject spSecurableObject)
        {
            if (spSecurableObject.__HMSError_ != null && (spSecurableObject.__HMSError_.errno != 0 || spSecurableObject.__HMSError_.info != "" ))
            {
                pos = this.add_lineAt(pos, level, "__HMSError", HMS.Util.__HMSError.toString(spSecurableObject.__HMSError_)); 
            }
            pos = this.add__deferred(pos, level, spSecurableObject.__deferred_);
            pos = this.add__metadata(pos, level, spSecurableObject.__metadata_);
            pos = this.add__rest(pos, level, spSecurableObject.__rest);
            pos = this.add_deferredAt(pos,level, "FirstUniqueAncestorSecurableObject", "...", knownPages.pageSecurableObject , spSecurableObject.FirstUniqueAncestorSecurableObject_.__deferred_); //SecurableObject;
            pos = this.add_lineAt(pos,level,  "HasUniqueRoleAssignments", HMS.SP.SPUtil.toString(spSecurableObject.HasUniqueRoleAssignments_)); //Boolean;
            pos = this.add_deferredAt(pos,level, "RoleAssignments", "...", myType.GetType("SP.RoleAssignment"), spSecurableObject.RoleAssignments_.__deferred_); //RoleAssignment;
            return pos;
        }
        public int add_SecurableObject_deferred(int pos, int level, HMS.SP.SecurableObject spSecurableObject)
        {
            {
                string useUrl = spSecurableObject.__deferred_.uri;
                if( !String.IsNullOrEmpty(useUrl) )
                {
                    pos = this.add_lineAt(pos, level, false,  "SecurableObject","", knownPages.pageSecurableObject, useUrl);
                }
                else
                {
                    pos = this.add_lineAt(pos, level, true,   "SecurableObject", "",knownPages.NONE, "");
                    pos = this.add_SecurableObject(pos, level+1, spSecurableObject);
                }
            }
        return pos;
        }
    }
}

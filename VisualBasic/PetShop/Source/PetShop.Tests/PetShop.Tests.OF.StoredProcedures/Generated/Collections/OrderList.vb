﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.0.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'       Changes to this template will not be lost.
'
'     Template: EditableChildList.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic

Imports Csla

Namespace PetShop.Tests.OF.StoredProcedures
    ''' <summary>
    ''' The OrderList class is a CSLA editable child list class collection of <see cref="Order"/> objects.  See CSLA documentation for a more detailed description.
    ''' </summary>
    Public Partial Class OrderList
#Region "Authorization Rules"
    
        ''' <summary>
        ''' Allows the specification of CSLA based authorization rules for a collection list.  Specifies what roles can 
        ''' perform which operations for a given business object
        ''' </summary>
        Private Sub AddAuthorizationRules()
            'Csla.Rules.BusinessRules.AddRule(GetType(OrderList), New Global.Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.CreateObject, "SomeRole"))
            'Csla.Rules.BusinessRules.AddRule(GetType(OrderList), New Global.Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.EditObject, "SomeRole"))
            'Csla.Rules.BusinessRules.AddRule(GetType(OrderList), New Global.Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.DeleteObject, "SomeRole", "SomeAdminRole"))
        End Sub
    
#End Region
    End Class
End Namespace
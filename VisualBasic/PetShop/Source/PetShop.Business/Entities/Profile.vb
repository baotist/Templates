'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v4.0.0.
'       Changes to this template will not be lost.
'
'     Template: SwitchableObject.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Security
Imports Csla.Rules

Namespace PetShop.Business
    Public Partial Class Profile
#Region "Business Rules"
    
        ''' <summary>
        ''' All custom rules need to be placed in this method.
        ''' </summary>
        ''' <Returns>Return true to override the generated rules If false generated rules will be run.</Returns>
        Protected Function AddBusinessValidationRules() As Boolean
            ' TODO: add validation rules
            'ValidationRules.AddRule(RuleMethod, "")
    
            Return False
        End Function
    
#End Region
    
#Region "Authorization Rules"
    
#If Not SILVERLIGHT Then
        Protected Shared Sub AddObjectAuthorizationRules()
            'Csla.Rules.BusinessRules.AddRule(GetType(Profile), New Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.CreateObject, "SomeRole"))
            'Csla.Rules.BusinessRules.AddRule(GetType(Profile), New Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.EditObject, "SomeRole"))
            'Csla.Rules.BusinessRules.AddRule(GetType(Profile), New Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.DeleteObject, "SomeRole", "SomeAdminRole"))
        End Sub
#End If

#End Region

#Region "Custom Factory Methods"

#If Not Silverlight Then
        Public Shared Function GetProfile(ByVal username As String) As Profile
            Dim criteria As New ProfileCriteria()
            criteria.Username = username

            Return DataPortal.Fetch(Of Profile)(criteria)
        End Function
#Else
        Public Shared Sub GetProfile(ByVal username As String, ByVal handler As EventHandler(Of DataPortalResult(Of Profile)))
            Dim dp As New DataPortal(Of Profile)()
            AddHandler dp.FetchCompleted, handler

            Dim criteria As New ProfileCriteria()
            criteria.Username = username

            dp.BeginFetch(criteria)
        End Sub
#End If

#End Region

#Region "Custom Business Methods"

    Private Shared ReadOnly _shoppingCart As PropertyInfo(Of CartList) = RegisterProperty(Of CartList)(Function(p As Profile) p.ShoppingCart, Csla.RelationshipTypes.LazyLoad)
    Public ReadOnly Property ShoppingCart() As CartList
        Get
            If Not FieldManager.FieldExists(_shoppingCart) Then
                SetProperty(_shoppingCart, CartList.GetCart(UniqueID, True))
            End If

            Return GetProperty(_shoppingCart)
        End Get
    End Property

    Private Shared ReadOnly _wishList As PropertyInfo(Of CartList) = RegisterProperty(Of CartList)(Function(p As Profile) p.WishList, Csla.RelationshipTypes.LazyLoad)
    Public ReadOnly Property WishList() As CartList
        Get
            If Not FieldManager.FieldExists(_wishList) Then
                SetProperty(_wishList, CartList.GetCart(UniqueID, False))
            End If

            Return GetProperty(_wishList)
        End Get
    End Property

#End Region

    End Class
End Namespace
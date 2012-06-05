﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Order.vb'.
'
'     Template: ObjectFactory.DataAccess.StoredProcedures.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data
Imports Csla.Server

Imports PetShop.Tests.OF.StoredProcedures

Namespace PetShop.Tests.OF.StoredProcedures.DAL
    Public Partial Class OrderFactory
        Inherits ObjectFactory
    
#Region "Create"
    
        ''' <summary>
        ''' Creates New Order with default values.
        ''' </summary>
        ''' <Returns>New Order.</Returns>
        <RunLocal()> _
        Public Function Create() As Order
            Dim item As Order = CType(Activator.CreateInstance(GetType(Order), True), Order)
    
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return item
            End If
    
            Using BypassPropertyChecks(item)
                ' Default values.
    
                CheckRules(item)
                MarkNew(item)
            End Using
    
            OnCreated()
    
            Return item
        End Function
    
        ''' <summary>
        ''' Creates New Order with default values.
        ''' </summary>
        ''' <Returns>New Order.</Returns>
        <RunLocal()> _
        Private Function Create(ByVal criteria As OrderCriteria) As  Order
            Dim item As Order = CType(Activator.CreateInstance(GetType(Order), True), Order)
    
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return item
            End If
    
            Dim resource As Order = Fetch(criteria)
    
            Using BypassPropertyChecks(item)
                item.UserId = resource.UserId
                item.OrderDate = resource.OrderDate
                item.ShipAddr1 = resource.ShipAddr1
                item.ShipAddr2 = resource.ShipAddr2
                item.ShipCity = resource.ShipCity
                item.ShipState = resource.ShipState
                item.ShipZip = resource.ShipZip
                item.ShipCountry = resource.ShipCountry
                item.BillAddr1 = resource.BillAddr1
                item.BillAddr2 = resource.BillAddr2
                item.BillCity = resource.BillCity
                item.BillState = resource.BillState
                item.BillZip = resource.BillZip
                item.BillCountry = resource.BillCountry
                item.Courier = resource.Courier
                item.TotalPrice = resource.TotalPrice
                item.BillToFirstName = resource.BillToFirstName
                item.BillToLastName = resource.BillToLastName
                item.ShipToFirstName = resource.ShipToFirstName
                item.ShipToLastName = resource.ShipToLastName
                item.AuthorizationNumber = resource.AuthorizationNumber
                item.Locale = resource.Locale
            End Using
    
            CheckRules(item)
            MarkNew(item)
    
            OnCreated()
    
            Return item
        End Function
    
#End Region

#Region "Fetch"
    
        ''' <summary>
        ''' Fetch Order.
        ''' </summary>
        ''' <param name="criteria">The criteria.</param>
        Public Function Fetch(ByVal criteria As OrderCriteria) As Order
            Dim item As Order = Nothing
            
            Dim cancel As Boolean = False
            OnFetching(criteria, cancel)
            If (cancel) Then
                Return item
            End If
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Order_Select]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    command.Parameters.AddWithValue("@p_ShipAddr2HasValue", criteria.ShipAddr2HasValue)
                command.Parameters.AddWithValue("@p_BillAddr2HasValue", criteria.BillAddr2HasValue)
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            item = Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found In 'dbo.Orders' using the following criteria: {0}.", criteria))
                        End If
                    End Using
                End Using
            End Using
    
            MarkOld(item)
    
            OnFetched()
    
            Return item
        End Function
    
#End Region
    
#Region "Insert"
    
        Private Sub DoInsert(ByRef item As Order, ByVal stopProccessingChildren As Boolean)
            ' Don't update If the item isn't dirty.
            If Not (item.IsDirty) Then
                Return
            End If
    
            Dim cancel As Boolean = False
            OnInserting(cancel)
            If (cancel) Then
                Return
            End If
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Order_Insert]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@p_OrderId", item.OrderId)
                command.Parameters("@p_OrderId").Direction = ParameterDirection.Output
                command.Parameters.AddWithValue("@p_UserId", item.UserId)
                command.Parameters.AddWithValue("@p_OrderDate", item.OrderDate)
                command.Parameters.AddWithValue("@p_ShipAddr1", item.ShipAddr1)
                command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(item.ShipAddr2))
                command.Parameters.AddWithValue("@p_ShipCity", item.ShipCity)
                command.Parameters.AddWithValue("@p_ShipState", item.ShipState)
                command.Parameters.AddWithValue("@p_ShipZip", item.ShipZip)
                command.Parameters.AddWithValue("@p_ShipCountry", item.ShipCountry)
                command.Parameters.AddWithValue("@p_BillAddr1", item.BillAddr1)
                command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(item.BillAddr2))
                command.Parameters.AddWithValue("@p_BillCity", item.BillCity)
                command.Parameters.AddWithValue("@p_BillState", item.BillState)
                command.Parameters.AddWithValue("@p_BillZip", item.BillZip)
                command.Parameters.AddWithValue("@p_BillCountry", item.BillCountry)
                command.Parameters.AddWithValue("@p_Courier", item.Courier)
                command.Parameters.AddWithValue("@p_TotalPrice", item.TotalPrice)
                command.Parameters.AddWithValue("@p_BillToFirstName", item.BillToFirstName)
                command.Parameters.AddWithValue("@p_BillToLastName", item.BillToLastName)
                command.Parameters.AddWithValue("@p_ShipToFirstName", item.ShipToFirstName)
                command.Parameters.AddWithValue("@p_ShipToLastName", item.ShipToLastName)
                command.Parameters.AddWithValue("@p_AuthorizationNumber", item.AuthorizationNumber)
                command.Parameters.AddWithValue("@p_Locale", item.Locale)
    
                    command.ExecuteNonQuery()
    
                        item.OrderId = DirectCast(command.Parameters("@p_OrderId").Value, System.Int32)
                End Using
            End Using
    
    
            MarkOld(item)
            CheckRules(item)
            
            If Not (stopProccessingChildren) Then
                ' Update Child Items.
                Update_LineItems_LineItems_FK__LineItem__OrderI__03317E3D(item)
                Update_OrderStatuses_OrderStatuses_FK__OrderStat__Order__060DEAE8(item)
            End If
    
            OnInserted()
        End Sub
    
#End Region

#Region "Update"
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Public Function Update(ByVal item As Order) As Order
            Return Update(item, false)
        End Function
    
        Public Function Update(ByVal item As Order, ByVal stopProccessingChildren as Boolean) As Order
            If(item.IsDeleted) Then
                DoDelete(item)
                MarkNew(item)
            Else If(item.IsNew) Then
                DoInsert(item, stopProccessingChildren)
            Else
            DoUpdate(item, stopProccessingChildren)
            End If
    
            Return item
        End Function
    
        Private Sub DoUpdate(ByRef item As Order, ByVal stopProccessingChildren As Boolean)
            Dim cancel As Boolean = False
            OnUpdating(cancel)
            If (cancel) Then
                Return
            End If
    
            ' Don't update If the item isn't dirty.
            If (item.IsDirty) Then
    
                Using connection As New SqlConnection(ADOHelper.ConnectionString)
                    connection.Open()
                    Using command As New SqlCommand("[dbo].[CSLA_Order_Update]", connection)
                        command.CommandType = CommandType.StoredProcedure
                        command.Parameters.AddWithValue("@p_OrderId", item.OrderId)
                command.Parameters.AddWithValue("@p_UserId", item.UserId)
                command.Parameters.AddWithValue("@p_OrderDate", item.OrderDate)
                command.Parameters.AddWithValue("@p_ShipAddr1", item.ShipAddr1)
                command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(item.ShipAddr2))
                command.Parameters.AddWithValue("@p_ShipCity", item.ShipCity)
                command.Parameters.AddWithValue("@p_ShipState", item.ShipState)
                command.Parameters.AddWithValue("@p_ShipZip", item.ShipZip)
                command.Parameters.AddWithValue("@p_ShipCountry", item.ShipCountry)
                command.Parameters.AddWithValue("@p_BillAddr1", item.BillAddr1)
                command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(item.BillAddr2))
                command.Parameters.AddWithValue("@p_BillCity", item.BillCity)
                command.Parameters.AddWithValue("@p_BillState", item.BillState)
                command.Parameters.AddWithValue("@p_BillZip", item.BillZip)
                command.Parameters.AddWithValue("@p_BillCountry", item.BillCountry)
                command.Parameters.AddWithValue("@p_Courier", item.Courier)
                command.Parameters.AddWithValue("@p_TotalPrice", item.TotalPrice)
                command.Parameters.AddWithValue("@p_BillToFirstName", item.BillToFirstName)
                command.Parameters.AddWithValue("@p_BillToLastName", item.BillToLastName)
                command.Parameters.AddWithValue("@p_ShipToFirstName", item.ShipToFirstName)
                command.Parameters.AddWithValue("@p_ShipToLastName", item.ShipToLastName)
                command.Parameters.AddWithValue("@p_AuthorizationNumber", item.AuthorizationNumber)
                command.Parameters.AddWithValue("@p_Locale", item.Locale)
    
                        'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        Dim result As Integer = command.ExecuteNonQuery()
                        If (result = 0) Then
                            throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                        End If
                        
                        item.OrderId = DirectCast(command.Parameters("@p_OrderId").Value, System.Int32)
                    End Using
                End Using
            End If
    

            MarkOld(item)
            CheckRules(item)

            If Not (stopProccessingChildren) Then
                ' Update Child Items.
                Update_LineItems_LineItems_FK__LineItem__OrderI__03317E3D(item)
                Update_OrderStatuses_OrderStatuses_FK__OrderStat__Order__060DEAE8(item)
            End If

            OnUpdated()
        End Sub

#End Region

#Region "Delete"

        <Transactional(TransactionalTypes.TransactionScope)> _
        Public Sub Delete(ByVal criteria As OrderCriteria)
            ' Note: this call to delete is for immediate deletion and doesn't keep track of any entity state.
            DoDelete(criteria)
        End Sub

        Protected Sub DoDelete(ByRef item As Order)
            ' If we're not dirty then don't update the database.
            If Not (item.IsDirty) Then
                Return
            End If

            ' If we're New then don't call delete.
            If (item.IsNew) Then
                Return
            End If
    
            Dim criteria As New OrderCriteria()
                criteria.OrderId = item.OrderId
            DoDelete(criteria)

            MarkNew(item)
        End Sub

        Private Sub DoDelete(ByVal criteria As OrderCriteria)
            Dim cancel As Boolean = False
            OnDeleting(criteria, cancel)
            If (cancel) Then
                Return
            End If

            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_Order_Delete]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))

                    'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    Dim result As Integer = command.ExecuteNonQuery()
                    If (result = 0) Then
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                    End If
                End Using
            End Using

            OnDeleted()
        End Sub

#End Region

#Region "Helper Methods"
    
        Public Function Map(ByVal reader As SafeDataReader) As Order
            Dim item As Order = CType(Activator.CreateInstance(GetType(Order), True), Order)
            Using BypassPropertyChecks(item)
                item.OrderId = reader.GetInt32("OrderId")
                item.UserId = reader.GetString("UserId")
                item.OrderDate = reader.GetDateTime("OrderDate")
                item.ShipAddr1 = reader.GetString("ShipAddr1")
                item.ShipAddr2 = reader.GetString("ShipAddr2")
                item.ShipCity = reader.GetString("ShipCity")
                item.ShipState = reader.GetString("ShipState")
                item.ShipZip = reader.GetString("ShipZip")
                item.ShipCountry = reader.GetString("ShipCountry")
                item.BillAddr1 = reader.GetString("BillAddr1")
                item.BillAddr2 = reader.GetString("BillAddr2")
                item.BillCity = reader.GetString("BillCity")
                item.BillState = reader.GetString("BillState")
                item.BillZip = reader.GetString("BillZip")
                item.BillCountry = reader.GetString("BillCountry")
                item.Courier = reader.GetString("Courier")
                item.TotalPrice = reader.GetDecimal("TotalPrice")
                item.BillToFirstName = reader.GetString("BillToFirstName")
                item.BillToLastName = reader.GetString("BillToLastName")
                item.ShipToFirstName = reader.GetString("ShipToFirstName")
                item.ShipToLastName = reader.GetString("ShipToLastName")
                item.AuthorizationNumber = reader.GetInt32("AuthorizationNumber")
                item.Locale = reader.GetString("Locale")
            End Using

            MarkOld(item)

            Return item
        End Function
    
        'Where(Function(a) a.AssociationType = AssociationType.OneToMany OrElse a.AssociationType = AssociationType.ZeroOrOneToMany OrElse a.AssociationType = AssociationType.ManyToMany)
        Private Shared Sub Update_LineItems_LineItems_FK__LineItem__OrderI__03317E3D(ByRef item As Order)
            For Each itemToUpdate As LineItem In item.LineItems
            itemToUpdate.OrderId = item.OrderId
    
                Dim factory As New LineItemFactory
                factory.Update(itemToUpdate, True)
            Next
        End Sub
        'Where(Function(a) a.AssociationType = AssociationType.OneToMany OrElse a.AssociationType = AssociationType.ZeroOrOneToMany OrElse a.AssociationType = AssociationType.ManyToMany)
        Private Shared Sub Update_OrderStatuses_OrderStatuses_FK__OrderStat__Order__060DEAE8(ByRef item As Order)
            For Each itemToUpdate As OrderStatus In item.OrderStatuses
            itemToUpdate.OrderId = item.OrderId
    
                Dim factory As New OrderStatusFactory
                factory.Update(itemToUpdate, True)
            Next
        End Sub

#End Region

#Region "DataPortal partial methods"
    
        ''' <summary>
        ''' CodeSmith generated stub method that is called when creating the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="Order"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnCreated()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when fetching the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="OrderCriteria"/> object containing the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnFetching(ByVal criteria As OrderCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="Order"/> object has been fetched. 
        ''' </summary>    
        Partial Private Sub OnFetched()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByRef cancel As Boolean)
        End Sub
 
        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="Order"/> object has been mapped. 
        ''' </summary>
        Partial Private Sub OnMapped()
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called when inserting the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        Partial Private Sub OnInserting(ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="Order"/> object has been inserted. 
        ''' </summary>
        Partial Private Sub OnInserted()
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called when updating the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="Order"/> object has been updated. 
        ''' </summary>
        Partial Private Sub OnUpdated()
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called when self deleting the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        Partial Private Sub OnSelfDeleting(ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="Order"/> object has been deleted. 
        ''' </summary>
        Partial Private Sub OnSelfDeleted()
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called when deleting the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="OrderCriteria"/> object containing the criteria of the object to delete.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        Partial Private Sub OnDeleting(ByVal criteria As OrderCriteria, ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="Order"/> object with the specified criteria has been deleted. 
        ''' </summary>
        Partial Private Sub OnDeleted()
        End Sub
        Private Partial Sub OnChildLoading(ByVal childProperty As Global.Csla.Core.IPropertyInfo, ByRef cancel As Boolean)
        End Sub
    
#End Region
    End Class
End Namespace
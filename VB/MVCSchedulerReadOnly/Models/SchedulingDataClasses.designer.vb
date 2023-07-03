'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Data
Imports System.Collections.Generic
Imports System.Reflection
Imports System.Linq
Imports System.Linq.Expressions
Imports System.ComponentModel
Imports System

Namespace MVCSchedulerReadOnly.Models

    <Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="SchedulerCars")>
    Public Partial Class SchedulingDataClassesDataContext
        Inherits System.Data.Linq.DataContext

        Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New System.Data.Linq.Mapping.AttributeMappingSource()

'#Region "Extensibility Method Definitions"
        Partial Private Sub OnCreated()
        End Sub

        Partial Private Sub InsertDBAppointment(ByVal instance As MVCSchedulerReadOnly.Models.DBAppointment)
        End Sub

        Partial Private Sub UpdateDBAppointment(ByVal instance As MVCSchedulerReadOnly.Models.DBAppointment)
        End Sub

        Partial Private Sub DeleteDBAppointment(ByVal instance As MVCSchedulerReadOnly.Models.DBAppointment)
        End Sub

        Partial Private Sub InsertDBResource(ByVal instance As MVCSchedulerReadOnly.Models.DBResource)
        End Sub

        Partial Private Sub UpdateDBResource(ByVal instance As MVCSchedulerReadOnly.Models.DBResource)
        End Sub

        Partial Private Sub DeleteDBResource(ByVal instance As MVCSchedulerReadOnly.Models.DBResource)
        End Sub

'#End Region
        Public Sub New()
            MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings(CStr(("SchedulerCarsConnectionString"))).ConnectionString, MVCSchedulerReadOnly.Models.SchedulingDataClassesDataContext.mappingSource)
            Me.OnCreated()
        End Sub

        Public Sub New(ByVal connection As String)
            MyBase.New(connection, MVCSchedulerReadOnly.Models.SchedulingDataClassesDataContext.mappingSource)
            Me.OnCreated()
        End Sub

        Public Sub New(ByVal connection As System.Data.IDbConnection)
            MyBase.New(connection, MVCSchedulerReadOnly.Models.SchedulingDataClassesDataContext.mappingSource)
            Me.OnCreated()
        End Sub

        Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
            MyBase.New(connection, mappingSource)
            Me.OnCreated()
        End Sub

        Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
            MyBase.New(connection, mappingSource)
            Me.OnCreated()
        End Sub

        Public ReadOnly Property DBAppointments As System.Data.Linq.Table(Of MVCSchedulerReadOnly.Models.DBAppointment)
            Get
                Return Me.GetTable(Of MVCSchedulerReadOnly.Models.DBAppointment)()
            End Get
        End Property

        Public ReadOnly Property DBResources As System.Data.Linq.Table(Of MVCSchedulerReadOnly.Models.DBResource)
            Get
                Return Me.GetTable(Of MVCSchedulerReadOnly.Models.DBResource)()
            End Get
        End Property
    End Class

    <Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.DBAppointments")>
    Public Partial Class DBAppointment
        Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged

        Private Shared emptyChangingEventArgs As System.ComponentModel.PropertyChangingEventArgs = New System.ComponentModel.PropertyChangingEventArgs(System.[String].Empty)

        Private _UniqueID As Integer

        Private _Type As System.Nullable(Of Integer)

        Private _StartDate As System.Nullable(Of System.DateTime)

        Private _EndDate As System.Nullable(Of System.DateTime)

        Private _AllDay As System.Nullable(Of Boolean)

        Private _Subject As String

        Private _Location As String

        Private _Description As String

        Private _Status As System.Nullable(Of Integer)

        Private _Label As System.Nullable(Of Integer)

        Private _ResourceID As System.Nullable(Of Integer)

        Private _ReminderInfo As String

        Private _RecurrenceInfo As String

        Private _CustomField1 As String

'#Region "Extensibility Method Definitions"
        Partial Private Sub OnLoaded()
        End Sub

        Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
        End Sub

        Partial Private Sub OnCreated()
        End Sub

        Partial Private Sub OnUniqueIDChanging(ByVal value As Integer)
        End Sub

        Partial Private Sub OnUniqueIDChanged()
        End Sub

        Partial Private Sub OnTypeChanging(ByVal value As System.Nullable(Of Integer))
        End Sub

        Partial Private Sub OnTypeChanged()
        End Sub

        Partial Private Sub OnStartDateChanging(ByVal value As System.Nullable(Of System.DateTime))
        End Sub

        Partial Private Sub OnStartDateChanged()
        End Sub

        Partial Private Sub OnEndDateChanging(ByVal value As System.Nullable(Of System.DateTime))
        End Sub

        Partial Private Sub OnEndDateChanged()
        End Sub

        Partial Private Sub OnAllDayChanging(ByVal value As System.Nullable(Of Boolean))
        End Sub

        Partial Private Sub OnAllDayChanged()
        End Sub

        Partial Private Sub OnSubjectChanging(ByVal value As String)
        End Sub

        Partial Private Sub OnSubjectChanged()
        End Sub

        Partial Private Sub OnLocationChanging(ByVal value As String)
        End Sub

        Partial Private Sub OnLocationChanged()
        End Sub

        Partial Private Sub OnDescriptionChanging(ByVal value As String)
        End Sub

        Partial Private Sub OnDescriptionChanged()
        End Sub

        Partial Private Sub OnStatusChanging(ByVal value As System.Nullable(Of Integer))
        End Sub

        Partial Private Sub OnStatusChanged()
        End Sub

        Partial Private Sub OnLabelChanging(ByVal value As System.Nullable(Of Integer))
        End Sub

        Partial Private Sub OnLabelChanged()
        End Sub

        Partial Private Sub OnResourceIDChanging(ByVal value As System.Nullable(Of Integer))
        End Sub

        Partial Private Sub OnResourceIDChanged()
        End Sub

        Partial Private Sub OnReminderInfoChanging(ByVal value As String)
        End Sub

        Partial Private Sub OnReminderInfoChanged()
        End Sub

        Partial Private Sub OnRecurrenceInfoChanging(ByVal value As String)
        End Sub

        Partial Private Sub OnRecurrenceInfoChanged()
        End Sub

        Partial Private Sub OnCustomField1Changing(ByVal value As String)
        End Sub

        Partial Private Sub OnCustomField1Changed()
        End Sub

'#End Region
        Public Sub New()
            Me.OnCreated()
        End Sub

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UniqueID", AutoSync:=System.Data.Linq.Mapping.AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=True, IsDbGenerated:=True)>
        Public Property UniqueID As Integer
            Get
                Return Me._UniqueID
            End Get

            Set(ByVal value As Integer)
                If(Me._UniqueID <> value) Then
                    Me.OnUniqueIDChanging(value)
                    Me.SendPropertyChanging()
                    Me._UniqueID = value
                    Me.SendPropertyChanged("UniqueID")
                    Me.OnUniqueIDChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Type", DbType:="Int")>
        Public Property Type As System.Nullable(Of Integer)
            Get
                Return Me._Type
            End Get

            Set(ByVal value As System.Nullable(Of Integer))
                If(Me._Type <> value) Then
                    Me.OnTypeChanging(value)
                    Me.SendPropertyChanging()
                    Me._Type = value
                    Me.SendPropertyChanged("Type")
                    Me.OnTypeChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_StartDate", DbType:="SmallDateTime")>
        Public Property StartDate As System.Nullable(Of System.DateTime)
            Get
                Return Me._StartDate
            End Get

            Set(ByVal value As System.Nullable(Of System.DateTime))
                If(Me._StartDate <> value) Then
                    Me.OnStartDateChanging(value)
                    Me.SendPropertyChanging()
                    Me._StartDate = value
                    Me.SendPropertyChanged("StartDate")
                    Me.OnStartDateChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EndDate", DbType:="SmallDateTime")>
        Public Property EndDate As System.Nullable(Of System.DateTime)
            Get
                Return Me._EndDate
            End Get

            Set(ByVal value As System.Nullable(Of System.DateTime))
                If(Me._EndDate <> value) Then
                    Me.OnEndDateChanging(value)
                    Me.SendPropertyChanging()
                    Me._EndDate = value
                    Me.SendPropertyChanged("EndDate")
                    Me.OnEndDateChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AllDay", DbType:="Bit")>
        Public Property AllDay As System.Nullable(Of Boolean)
            Get
                Return Me._AllDay
            End Get

            Set(ByVal value As System.Nullable(Of Boolean))
                If(Me._AllDay <> value) Then
                    Me.OnAllDayChanging(value)
                    Me.SendPropertyChanging()
                    Me._AllDay = value
                    Me.SendPropertyChanged("AllDay")
                    Me.OnAllDayChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Subject", DbType:="NVarChar(100)")>
        Public Property Subject As String
            Get
                Return Me._Subject
            End Get

            Set(ByVal value As String)
                If(Not Equals(Me._Subject, value)) Then
                    Me.OnSubjectChanging(value)
                    Me.SendPropertyChanging()
                    Me._Subject = value
                    Me.SendPropertyChanged("Subject")
                    Me.OnSubjectChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Location", DbType:="NVarChar(50)")>
        Public Property Location As String
            Get
                Return Me._Location
            End Get

            Set(ByVal value As String)
                If(Not Equals(Me._Location, value)) Then
                    Me.OnLocationChanging(value)
                    Me.SendPropertyChanging()
                    Me._Location = value
                    Me.SendPropertyChanged("Location")
                    Me.OnLocationChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Description", DbType:="NText", UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)>
        Public Property Description As String
            Get
                Return Me._Description
            End Get

            Set(ByVal value As String)
                If(Not Equals(Me._Description, value)) Then
                    Me.OnDescriptionChanging(value)
                    Me.SendPropertyChanging()
                    Me._Description = value
                    Me.SendPropertyChanged("Description")
                    Me.OnDescriptionChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Status", DbType:="Int")>
        Public Property Status As System.Nullable(Of Integer)
            Get
                Return Me._Status
            End Get

            Set(ByVal value As System.Nullable(Of Integer))
                If(Me._Status <> value) Then
                    Me.OnStatusChanging(value)
                    Me.SendPropertyChanging()
                    Me._Status = value
                    Me.SendPropertyChanged("Status")
                    Me.OnStatusChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Label", DbType:="Int")>
        Public Property Label As System.Nullable(Of Integer)
            Get
                Return Me._Label
            End Get

            Set(ByVal value As System.Nullable(Of Integer))
                If(Me._Label <> value) Then
                    Me.OnLabelChanging(value)
                    Me.SendPropertyChanging()
                    Me._Label = value
                    Me.SendPropertyChanged("Label")
                    Me.OnLabelChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ResourceID", DbType:="Int")>
        Public Property ResourceID As System.Nullable(Of Integer)
            Get
                Return Me._ResourceID
            End Get

            Set(ByVal value As System.Nullable(Of Integer))
                If(Me._ResourceID <> value) Then
                    Me.OnResourceIDChanging(value)
                    Me.SendPropertyChanging()
                    Me._ResourceID = value
                    Me.SendPropertyChanged("ResourceID")
                    Me.OnResourceIDChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ReminderInfo", DbType:="NText", UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)>
        Public Property ReminderInfo As String
            Get
                Return Me._ReminderInfo
            End Get

            Set(ByVal value As String)
                If(Not Equals(Me._ReminderInfo, value)) Then
                    Me.OnReminderInfoChanging(value)
                    Me.SendPropertyChanging()
                    Me._ReminderInfo = value
                    Me.SendPropertyChanged("ReminderInfo")
                    Me.OnReminderInfoChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_RecurrenceInfo", DbType:="NText", UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)>
        Public Property RecurrenceInfo As String
            Get
                Return Me._RecurrenceInfo
            End Get

            Set(ByVal value As String)
                If(Not Equals(Me._RecurrenceInfo, value)) Then
                    Me.OnRecurrenceInfoChanging(value)
                    Me.SendPropertyChanging()
                    Me._RecurrenceInfo = value
                    Me.SendPropertyChanged("RecurrenceInfo")
                    Me.OnRecurrenceInfoChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CustomField1", DbType:="NText", UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)>
        Public Property CustomField1 As String
            Get
                Return Me._CustomField1
            End Get

            Set(ByVal value As String)
                If(Not Equals(Me._CustomField1, value)) Then
                    Me.OnCustomField1Changing(value)
                    Me.SendPropertyChanging()
                    Me._CustomField1 = value
                    Me.SendPropertyChanged("CustomField1")
                    Me.OnCustomField1Changed()
                End If
            End Set
        End Property

        Public Event PropertyChanging As System.ComponentModel.PropertyChangingEventHandler Implements Global.System.ComponentModel.INotifyPropertyChanging.PropertyChanging

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements Global.System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Overridable Sub SendPropertyChanging()
            RaiseEvent PropertyChanging(Me, MVCSchedulerReadOnly.Models.DBAppointment.emptyChangingEventArgs)
        End Sub

        Protected Overridable Sub SendPropertyChanged(ByVal propertyName As System.[String])
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
        End Sub
    End Class

    <Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.DBResources")>
    Public Partial Class DBResource
        Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged

        Private Shared emptyChangingEventArgs As System.ComponentModel.PropertyChangingEventArgs = New System.ComponentModel.PropertyChangingEventArgs(System.[String].Empty)

        Private _UniqueID As Integer

        Private _ResourceID As Integer

        Private _ResourceName As String

        Private _Color As System.Nullable(Of Integer)

        Private _Image As System.Data.Linq.Binary

        Private _CustomField1 As String

'#Region "Extensibility Method Definitions"
        Partial Private Sub OnLoaded()
        End Sub

        Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
        End Sub

        Partial Private Sub OnCreated()
        End Sub

        Partial Private Sub OnUniqueIDChanging(ByVal value As Integer)
        End Sub

        Partial Private Sub OnUniqueIDChanged()
        End Sub

        Partial Private Sub OnResourceIDChanging(ByVal value As Integer)
        End Sub

        Partial Private Sub OnResourceIDChanged()
        End Sub

        Partial Private Sub OnResourceNameChanging(ByVal value As String)
        End Sub

        Partial Private Sub OnResourceNameChanged()
        End Sub

        Partial Private Sub OnColorChanging(ByVal value As System.Nullable(Of Integer))
        End Sub

        Partial Private Sub OnColorChanged()
        End Sub

        Partial Private Sub OnImageChanging(ByVal value As System.Data.Linq.Binary)
        End Sub

        Partial Private Sub OnImageChanged()
        End Sub

        Partial Private Sub OnCustomField1Changing(ByVal value As String)
        End Sub

        Partial Private Sub OnCustomField1Changed()
        End Sub

'#End Region
        Public Sub New()
            Me.OnCreated()
        End Sub

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_UniqueID", AutoSync:=System.Data.Linq.Mapping.AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=True, IsDbGenerated:=True)>
        Public Property UniqueID As Integer
            Get
                Return Me._UniqueID
            End Get

            Set(ByVal value As Integer)
                If(Me._UniqueID <> value) Then
                    Me.OnUniqueIDChanging(value)
                    Me.SendPropertyChanging()
                    Me._UniqueID = value
                    Me.SendPropertyChanged("UniqueID")
                    Me.OnUniqueIDChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ResourceID", DbType:="Int NOT NULL")>
        Public Property ResourceID As Integer
            Get
                Return Me._ResourceID
            End Get

            Set(ByVal value As Integer)
                If(Me._ResourceID <> value) Then
                    Me.OnResourceIDChanging(value)
                    Me.SendPropertyChanging()
                    Me._ResourceID = value
                    Me.SendPropertyChanged("ResourceID")
                    Me.OnResourceIDChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ResourceName", DbType:="NVarChar(50)")>
        Public Property ResourceName As String
            Get
                Return Me._ResourceName
            End Get

            Set(ByVal value As String)
                If(Not Equals(Me._ResourceName, value)) Then
                    Me.OnResourceNameChanging(value)
                    Me.SendPropertyChanging()
                    Me._ResourceName = value
                    Me.SendPropertyChanged("ResourceName")
                    Me.OnResourceNameChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Color", DbType:="Int")>
        Public Property Color As System.Nullable(Of Integer)
            Get
                Return Me._Color
            End Get

            Set(ByVal value As System.Nullable(Of Integer))
                If(Me._Color <> value) Then
                    Me.OnColorChanging(value)
                    Me.SendPropertyChanging()
                    Me._Color = value
                    Me.SendPropertyChanged("Color")
                    Me.OnColorChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Image", DbType:="Image", UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)>
        Public Property Image As System.Data.Linq.Binary
            Get
                Return Me._Image
            End Get

            Set(ByVal value As System.Data.Linq.Binary)
                If(Me._Image IsNot value) Then
                    Me.OnImageChanging(value)
                    Me.SendPropertyChanging()
                    Me._Image = value
                    Me.SendPropertyChanged("Image")
                    Me.OnImageChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CustomField1", DbType:="NText", UpdateCheck:=System.Data.Linq.Mapping.UpdateCheck.Never)>
        Public Property CustomField1 As String
            Get
                Return Me._CustomField1
            End Get

            Set(ByVal value As String)
                If(Not Equals(Me._CustomField1, value)) Then
                    Me.OnCustomField1Changing(value)
                    Me.SendPropertyChanging()
                    Me._CustomField1 = value
                    Me.SendPropertyChanged("CustomField1")
                    Me.OnCustomField1Changed()
                End If
            End Set
        End Property

        Public Event PropertyChanging As System.ComponentModel.PropertyChangingEventHandler Implements Global.System.ComponentModel.INotifyPropertyChanging.PropertyChanging

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements Global.System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Overridable Sub SendPropertyChanging()
            RaiseEvent PropertyChanging(Me, MVCSchedulerReadOnly.Models.DBResource.emptyChangingEventArgs)
        End Sub

        Protected Overridable Sub SendPropertyChanged(ByVal propertyName As System.[String])
            RaiseEvent PropertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End Namespace

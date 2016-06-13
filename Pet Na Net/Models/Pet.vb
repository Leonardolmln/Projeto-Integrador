Option Explicit On
Option Strict On

Public Class Pet
    Private _id As Integer
    Private _nome As String
    Private _nascimento As Date
    Private _dono As Cliente
    Private _tipoPet As String

    Public Sub New(ByVal nome As String, ByVal nascimento As Date, ByVal dono As Cliente, ByVal tipoPet As String)
        _nome = nome
        _nascimento = nascimento
        _dono = dono
        _tipoPet = tipoPet
    End Sub

    Public Sub New(ByVal id As Integer, ByVal nome As String, ByVal nascimento As Date, ByVal dono As Cliente, ByVal tipoPet As String)
        Me.New(nome, nascimento, dono, tipoPet)
        _id = id
    End Sub

    Public Sub New()

    End Sub

    Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Property Nascimento As Date
        Get
            Return _nascimento
        End Get
        Set(value As Date)
            _nascimento = value
        End Set
    End Property

    Property Dono As Cliente
        Get
            Return _dono
        End Get
        Set(value As Cliente)
            _dono = value
        End Set
    End Property

    Property TipoPet As String
        Get
            Return _tipoPet
        End Get
        Set(value As String)
            _tipoPet = value
        End Set
    End Property

End Class

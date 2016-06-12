Option Explicit On
Option Strict On

Public Class Servico
    Private _id As Integer
    Private _dataCriacao As Date
    Private _cliente As Cliente
    Private _tipo As String
    Private _valor As Double
    Private _status As String
    Private _dataServico As Date
    Private _veterinario As Veterinario
    Private _dataFinalizacao As Date
    Private _funcionarioFinal As Funcionario

    Public Sub New()

    End Sub

    Public Sub New(dataCriacao As Date, cliente As Cliente, tipo As String, valor As Double, status As String, dataServico As Date)
        _cliente = cliente
        _dataCriacao = dataCriacao
        _tipo = tipo
        _valor = valor
        _status = status
        _dataServico = dataServico
    End Sub

    Public Sub New(dataCriacao As Date, cliente As Cliente, tipo As String, valor As Double, status As String, dataServico As Date, veterinario As Veterinario)
        Me.New(dataCriacao, cliente, tipo, valor, status, dataServico)
        _veterinario = veterinario
    End Sub

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property DataCriacao As Date
        Get
            Return _dataCriacao
        End Get
        Set(value As Date)
            _dataCriacao = value
        End Set
    End Property

    Public Property DataServico As Date
        Get
            Return _dataServico
        End Get
        Set(value As Date)
            _dataServico = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Public Property Valor As Double
        Get
            Return _valor
        End Get
        Set(value As Double)
            _valor = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            _status = value
        End Set
    End Property

    Public Property DataFinalizacao As Date
        Get
            Return _dataFinalizacao
        End Get
        Set(value As Date)
            _dataFinalizacao = value
        End Set
    End Property

    Public Property FuncionarioFinal As Funcionario
        Get
            Return _funcionarioFinal
        End Get
        Set(value As Funcionario)
            _funcionarioFinal = value
        End Set
    End Property

    Public Property Veterinario As Veterinario
        Get
            Return _veterinario
        End Get
        Set(value As Veterinario)
            _veterinario = value
        End Set
    End Property

    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Set(value As Cliente)
            _cliente = value
        End Set
    End Property

End Class

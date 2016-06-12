Option Explicit On
Option Strict On

Public Class Movimento
    Private _id As Integer
    Private _notaFiscal As NotaFiscal
    Private _tipo As TipoMovimento
    Private _data As Date
    Private _itens As List(Of Item)
    Private _cliente As Cliente
    Private _fornecedor As Fornecedor

    Public Sub New(NF As NotaFiscal, tipo As Integer, data As Date, cli As Cliente)
        _notaFiscal = NF
        _tipo = DirectCast(tipo, Pet_Na_Net.TipoMovimento)
        _data = data
        _fornecedor = Nothing
        _itens = New List(Of Item)
        _cliente = cli
    End Sub

    Public Sub New(NF As NotaFiscal, tipo As Integer, data As Date, forn As Fornecedor)
        _notaFiscal = NF
        _tipo = DirectCast(tipo, Pet_Na_Net.TipoMovimento)
        _data = data
        _itens = New List(Of Item)
        _fornecedor = forn
        _cliente = Nothing
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

    Property NotaFiscal As NotaFiscal
        Get
            Return _notaFiscal
        End Get
        Set(value As NotaFiscal)
            _notaFiscal = value
        End Set
    End Property

    Property Itens As List(Of Item)
        Get
            Return _itens
        End Get
        Set(value As List(Of Item))
            _itens = value

            For Each item As Item In _itens
                item.Movimento = Me
            Next
        End Set
    End Property

    Property Data As Date
        Get
            Return _data
        End Get
        Set(value As Date)
            _data = value
        End Set
    End Property

    Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Set(value As Cliente)
            _cliente = value
        End Set
    End Property

    Property Fornecedor As Fornecedor
        Get
            Return _fornecedor
        End Get
        Set(value As Fornecedor)
            _fornecedor = value
        End Set
    End Property

    Property Tipo As Integer
        Get
            Return _tipo
        End Get
        Set(value As Integer)
            _tipo = DirectCast(value, Pet_Na_Net.TipoMovimento)
        End Set
    End Property


End Class

Option Explicit On
Option Strict On

Public Class NotaFiscal
    Private _id As Integer
    Private _numeroNF As Integer
    Private _emissao As Date
    Private _produtos As List(Of Produto)

    Public Sub New(numeroNF As Integer, emissao As Date)
        _numeroNF = numeroNF
        _emissao = emissao
        _produtos = New List(Of Produto)
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

    Property NumeroNF As Integer
        Get
            Return _numeroNF
        End Get
        Set(value As Integer)
            _numeroNF = value
        End Set
    End Property

    Property Emissao As Date
        Get
            Return _emissao
        End Get
        Set(value As Date)
            _emissao = value
        End Set
    End Property

    Property Produtos As List(Of Produto)
        Get
            Return _produtos
        End Get
        Set(value As List(Of Produto))
            _produtos = value
        End Set
    End Property
End Class

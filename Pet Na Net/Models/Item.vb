Option Explicit On
Option Strict On

Public Class Item
    Private _id As Integer
    Private _movimento As Movimento
    Private _quantidade As Integer
    Private _valorUnit As Double
    Private _valorTotal As Double
    Private _produto As Produto
    
    Public Sub New(mov As Movimento, qtde As Integer, valorUnit As Double, valorTotal As Double, prod As Produto)
        _movimento = mov
        _quantidade = qtde
        _valorUnit = valorUnit
        _valorTotal = valorTotal
        _produto = prod
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

    Property Movimento As Movimento
        Get
            Return _movimento
        End Get
        Set(value As Movimento)
            _movimento = value
        End Set
    End Property

    Property Quantidade As Integer
        Get
            Return _quantidade
        End Get
        Set(value As Integer)
            _quantidade = value
        End Set
    End Property

    Property ValorUnitario As Double
        Get
            Return _valorUnit
        End Get
        Set(value As Double)
            _valorUnit = value
        End Set
    End Property

    Property ValorTotal As Double
        Get
            Return _valorTotal
        End Get
        Set(value As Double)
            _valorTotal = value
        End Set
    End Property

    Property Produto As Produto
        Get
            Return _produto
        End Get
        Set(value As Produto)
            _produto = value
        End Set
    End Property

End Class

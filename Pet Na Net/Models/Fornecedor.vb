Option Explicit On
Option Strict On

Public Class Fornecedor : Inherits PessoaJuridica
    Private _id As Integer
    Private _produtos As List(Of Produto)

    Public Sub New()
        _produtos = New List(Of Produto)
    End Sub

    Public Sub New(razaoSocial As String, cnpj As String, endereco As String, telefone As String)
        Me.New()
        _razaoSocial = razaoSocial
        _CNPJ = CleanString(cnpj)
        _endereco = endereco
        _telefone = CleanString(telefone)
    End Sub

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Produtos As List(Of Produto)
        Get
            Return _produtos
        End Get
        Set(value As List(Of Produto))
            _produtos = value
        End Set
    End Property

End Class

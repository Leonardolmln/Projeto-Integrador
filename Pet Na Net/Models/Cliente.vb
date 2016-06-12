'Regra de Negócio 01: Desconto = (Número de Pets / 2) x Multiplicador de Tipo do Cliente
'Regra de Negócio 02: Desconto não pode ser maior que 15%
'Regra de Negócio 03: Tipo do Cliente baseado no tempo de relacionamento ou número de Pets
'Regra de Negócio 04: Se o cliente estiver com status diferente de ativo, não há desconto

Option Explicit On
Option Strict On

Public Class Cliente : Inherits PessoaFisica
    Private _id As Integer
    Private _inicioRelacionamento As Date
    Private _desconto As Integer
    Private _tipoCliente As TipoCliente
    Private _pets As List(Of Pet)
    Private _status As String

    Public Sub New(ByVal nome As String, ByVal cpf As String, ByVal endereco As String, ByVal telefone As String)
        _pets = New List(Of Pet)
        _nome = nome
        _CPF = CleanString(cpf)
        _inicioRelacionamento = Now
        _endereco = endereco
        _telefone = CleanString(telefone)
        updateTipoCliente()
        updateDesconto()
    End Sub

    Sub New()
        _pets = New List(Of Pet)
    End Sub

    Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Property InicioRelacionamento As Date
        Get
            Return _inicioRelacionamento
        End Get
        Set(value As Date)
            _inicioRelacionamento = value
        End Set
    End Property

    Property TipoCliente As Integer
        Get
            Return _tipoCliente
        End Get
        Set(value As Integer)
            _tipoCliente = DirectCast(value, Pet_Na_Net.TipoCliente)
        End Set
    End Property

    Property Pets As List(Of Pet)
        Get
            Return _pets
        End Get
        Set(value As List(Of Pet))
            _pets = value
        End Set
    End Property

    Property Desconto As Integer
        Get
            Return _desconto
        End Get
        Set(value As Integer)
            _desconto = value
        End Set
    End Property

    Property Status As String
        Get
            Return _status
        End Get
        Set(value As String)
            If (StatusCadastro.GetStatus().Contains(value)) Then
                _status = value
            Else : _status = StatusCadastro.Irregular
            End If
        End Set
    End Property

    Public Sub updateDesconto()
        _desconto = CInt((_pets.Count) * _tipoCliente)
        If (_desconto > 15) Then _desconto = 15
        If (Status <> StatusCadastro.Ativo) Then _desconto = 0
    End Sub

    Public Sub updateTipoCliente()
        Dim diasDif As System.TimeSpan = Now.Date - InicioRelacionamento
        If (diasDif.Days > 730) OrElse (Pets.Count > 5) Then
            _tipoCliente = Pet_Na_Net.TipoCliente.Platinum
        ElseIf (diasDif.Days > 365) OrElse (Pets.Count > 3) Then
            _tipoCliente = Pet_Na_Net.TipoCliente.Gold
        Else : _tipoCliente = Pet_Na_Net.TipoCliente.Normal
        End If
    End Sub
End Class

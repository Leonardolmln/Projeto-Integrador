Option Explicit On
Option Strict On

Public Class Veterinario : Inherits Funcionario
    Private _crmv As String
    Private _validadeCRMV As Date

    Public Sub New(ByVal cpf As String, ByVal nome As String, ByVal matricula As String, ByVal salario As Double, ByVal crmv As String, ByVal validadeCRMV As Date)
        MyBase.New(cpf, nome, matricula, TipoFuncionario.Veterinario, salario)
        _crmv = CleanString(crmv)
        _validadeCRMV = validadeCRMV
    End Sub

    Public Sub New(ByVal id As Integer, ByVal cpf As String, ByVal nome As String, ByVal matricula As String, ByVal salario As Double, ByVal crmv As String, ByVal validadeCRMV As Date)
        MyBase.New(id, cpf, nome, matricula, TipoFuncionario.Veterinario, salario)
        _crmv = CleanString(crmv)
        _validadeCRMV = validadeCRMV
    End Sub

    Public Sub New()
    End Sub

    Property CRMV As String
        Get
            Return _crmv
        End Get
        Set(value As String)
            _crmv = CleanString(value)
        End Set
    End Property

    Property ValidadeCRMV As Date
        Get
            Return _validadeCRMV
        End Get
        Set(value As Date)
            _validadeCRMV = value
        End Set
    End Property

End Class

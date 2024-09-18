Imports System.Runtime.CompilerServices

Public Class frmShowFullTimeEmployee
    Private ReadOnly id As Integer

    Public Sub New(id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.id = id

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CtrlFullTimeEmployee1.LoadFullTimeEmployeeInfo(Me.id)
    End Sub

    Private Sub btnCLose_Click(sender As Object, e As EventArgs) Handles btnCLose.Click
        Me.Close()
    End Sub
End Class
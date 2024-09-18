Imports System.Runtime.CompilerServices

Public Class frmShowPartTimeEmployeeInfo
    Private _id As Integer
    Public Sub New(id As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        _id = id

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmPartTimeEmployeeInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CtrlPartTimeEmployee1.LoadEmployeeInfo(_id)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnCLose.Click
        Me.Close()
    End Sub
End Class
﻿Public Class fmrListaPersonal
    Private Sub fmrListaPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dsPersonal.registrodepersonal' Puede moverla o quitarla según sea necesario.
        Me.registrodepersonalTableAdapter.Fill(Me.dsPersonal.registrodepersonal)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
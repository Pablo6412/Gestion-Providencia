﻿Imports System.Data.SqlClient

Public Class FrmComedor

    Private Sub FrmComedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        abrir()
        Importe()
    End Sub

    Private Sub Importe()
        Dim comedor As String = "SELECT DISTINCT comedor_importe FROM cursos"
        Dim comando As New SqlCommand(comedor, conexion)
        TxtValorActual.Text = comando.ExecuteScalar()
        'TxtValorActual.Text = comando.ExecuteScalar
        If comando.ExecuteNonQuery = 0 Then
            MsgBox("Error leyendo base de datos")
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxtNuevoValor.Text = "" Then
            MsgBox("Debe ingresar un importe")
        Else
            Dim actualiza As String = "UPDATE cursos SET comedor_importe = " & Val(TxtNuevoValor.Text) & " "
            Dim comandoActualiza As New SqlCommand(actualiza, conexion)
            If comandoActualiza.ExecuteNonQuery = 0 Then
                MsgBox("Error al guardar datos")
            Else
                MsgBox("Nuevo valor guardado")

                Importe()
                'Dim refresco As String = "SELECT DISTINCT COMEDOR"
            End If
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


End Class
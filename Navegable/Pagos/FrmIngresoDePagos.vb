
Imports System.Data.SqlClient
Public Class FrmIngresoDePagos

    Public cmd As SqlCommand
    Dim datos As DataSet
    Dim adaptador As SqlDataAdapter
    Private Sub FrmIngresoDePagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()

        'buscamos padres para cargar alumnos


        abrir()

        Try
            Dim concatena As String = "select codigo_familia, apellido_padre, nombre_padre, apellido_madre, nombre_madre, concat (apellido_padre,' - ', apellido_madre) as familia, estado from gestion_providencia.familias"


            adaptador = New SqlDataAdapter(concatena, conexion)
            datos = New DataSet
            datos.Tables.Add("gestion_providencia.familias")
            adaptador.Fill(datos.Tables("gestion_providencia.familias"))

            CbxFamilia.DataSource = datos.Tables("gestion_providencia.familias")
            CbxFamilia.DisplayMember = "familia"
            CbxCodigo.DataSource = datos.Tables("gestion_providencia.familias")
            CbxCodigo.DisplayMember = "codigo_familia"


        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
        End Try

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub TxtTotal_TextChanged(sender As Object, e As EventArgs) Handles TxtTotal.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
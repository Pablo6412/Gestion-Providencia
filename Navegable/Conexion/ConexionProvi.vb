
Imports System.Data.SqlClient
Module ConexionProvi

    Public conexion As New SqlConnection(checkServer)


    'Public ConexionPrueva As New SqlConnection
    Sub conectar()
        cerrar()
        conexion.ConnectionString = "Data source=LUIS\SQLEXPRESS; Initial Catalog= gestion_providencia; Integrated security = True"
        Try
            abrir()

            ' MessageBox.Show("Conexión creada exitosamente", "Conexión a gestión_providencia", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox("¡NO SE PUDO CONECTAR CON LA BASE DE DATOS!")

        End Try
    End Sub
    Sub abrir()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub

    Sub cerrar()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub
End Module

Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Net.Mail
Public Class FrmEnviaMail
    Dim conexion As New MySqlConnection
    Public cmd As MySqlCommand
    Dim datos As DataSet
    Dim adaptador As MySqlDataAdapter
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Dim menor As Integer
    Dim mayor As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Dim minimo As String
        Dim menor As Integer
        Dim maximo As String
        Dim mayor As Integer
        'Dim cantidadFlias As String
        'Dim totalFamilias As Integer

        minimo = "select min(codigo_familia) from familias"
        Dim cmd = New MySql.Data.MySqlClient.MySqlCommand(minimo, conexion)
        Dim comando As New MySqlCommand
        menor = cmd.ExecuteScalar


        maximo = "select max(codigo_familia) from familias"
        Dim cmd1 = New MySql.Data.MySqlClient.MySqlCommand(maximo, conexion)
        Dim comando1 As New MySqlCommand
        mayor = cmd1.ExecuteScalar


        Dim correos As String
        Dim lista As Byte
        Dim diferencia As Integer = mayor - menor


        TxtEmisor.Text = "fliacomerci@gmail.com"
        TxtPassword.Text = "Triticumaestivum"

        While menor <= mayor
            If ProgressBar1.Value + (100 / (diferencia + 1)) <= 100 Then

                If ProgressBar1.Value < 100 Then
                    ProgressBar1.Value = ProgressBar1.Value + 100 / (diferencia + 1)
                    LblProgressBar.Text = "Enviando mails al: " & ProgressBar1.Value & "%"

                End If
            End If


            correos = "select codigo_familia, email, factura from familias where codigo_familia = '" & menor & "'"
            adaptador = New MySqlDataAdapter(correos, conexion)
            Dim comando2 As New MySqlCommand
            datos = New DataSet


            adaptador.Fill(datos, "familias")
            lista = datos.Tables("familias").Rows.Count

            If lista = 0 Then
                menor += 1
            Else
                TxtReceptor.Text = datos.Tables("familias").Rows(0).Item("email")
                TxtRutaArchivo.Text = datos.Tables("familias").Rows(0).Item("factura")
                If TxtReceptor.Text <> "" Then
                    enviarCorreo(TxtEmisor.Text, TxtPassword.Text, RtbMensaje.Text, TxtAsunto.Text, TxtReceptor.Text, TxtRutaArchivo.Text)

                End If
                menor += 1

            End If

        End While


        MsgBox("Los mensajes fueron enviados correctamente. ", MsgBoxStyle.Information, "Mensaje")
        Me.Close()


    End Sub

    Private Sub BtnAdjuntar_Click(sender As Object, e As EventArgs) Handles BtnAdjuntar.Click
        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then
                TxtRutaArchivo.Text = Me.OpenFileDialog1.FileName
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub FrmEnviaMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            conexion = New MySqlConnection("server=localhost; user=root; password=; database= Gestion_Providencia")
            conexion.Open()

        Catch ex As Exception
            MsgBox("¡NO SE PUDO CONECTAR CON LA BASE DE DATOS!")

        End Try


    End Sub


End Class
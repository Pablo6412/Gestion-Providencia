Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Xml

Public Class FrmConexionManual
    Private aes As New AES()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxtCnString.Text = "" Then
            MessageBox.Show("Por favor ingrese la cadena de conexión..", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SavetoXML(aes.Encrypt(TxtCnString.Text, appPwdUnique, Integer.Parse("256")))
            mostrarFamilias()
        End If

    End Sub

    Sub mostrarFamilias()
        Dim conexionPrueva As New SqlConnection(TxtCnString.Text)
        Dim codigo_familia As Integer
        Dim com As New SqlCommand("select codigo_familia from familias", conexionPrueva)
        Try
            conexionPrueva.Open()
            codigo_familia = (com.ExecuteScalar())
            conexionPrueva.Close()
            MessageBox.Show("Conexión creada exitosamente", "Conexión a gestión_providencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Algo salió mal, revise la cadena de conexión", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

    End Sub
    Public Sub SavetoXML(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("ConnectionString.xml")
        Dim root As XmlElement = doc.DocumentElement
        root.Attributes.Item(0).Value = dbcnString
        Dim writer As XmlTextWriter = New XmlTextWriter("ConnectionString.xml", Nothing)
        writer.Formatting = Formatting.Indented
        doc.Save(writer)
        writer.Close()
    End Sub
    Dim dbcnString As String
    Public Sub ReadfromXML()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("ConnectionString.xml")
            Dim root As XmlElement = doc.DocumentElement
            dbcnString = root.Attributes.Item(0).Value
            TxtCnString.Text = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))
        Catch ex As System.Security.Cryptography.CryptographicException
        End Try
    End Sub

    Private Sub FrmConexionManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadfromXML()
    End Sub

    Sub PruevaConexion()
        Try
            Dim codigo_familia As Integer
            Dim com As New SqlCommand("SELECT * from familias")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
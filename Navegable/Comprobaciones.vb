Imports System.Text.RegularExpressions   'Necesario para validar formato de correo electrónico
Module Comprobaciones
    'Función que permite solo el ingreso de números
    Public Function SoloNumeros(e)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        Return e.Handled

    End Function

    Public Function Validar_Mail(ByVal sMail As String) As Boolean
        Return Regex.IsMatch(sMail, "^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
    End Function

    Public Function CalculaEdad(FechaNacimiento, FechaActual) As Integer
        Dim dias As Integer
        Dim Meses As Integer
        Dim Anios As Integer
        Dim Edad As Integer

        Anios = CStr(FechaActual.Year - FechaNacimiento.Year)
        Meses = CStr(FechaActual.Month - FechaNacimiento.Month)
        dias = CStr(FechaActual.Day - FechaNacimiento.Day)


        If (DateTime.Compare(FechaActual, FechaNacimiento) <= 0) Then
            MessageBox.Show("Fecha de nacimiento inválida", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (FechaActual.Month < FechaNacimiento.Month) Then
            Edad = Anios
        ElseIf FechaActual.Month > FechaNacimiento.Month Then
            Edad = Anios + 1
        Else
            If (FechaActual.Day < FechaNacimiento.Day) Then
                Edad = Anios
            ElseIf (FechaActual.Day > FechaNacimiento.Day) Then
                Edad = Anios + 1
            Else
                Edad = Anios + 1
            End If
        End If
        Return Edad

    End Function

    Public Sub SoloLetras(e)
        ' Private Sub txtOnlyLetters_KeyPress(sender ...)
        If Not Char.IsLetter(e.KeyChar) _
                         AndAlso Not Char.IsControl(e.KeyChar) _
                         AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Public Sub AgregaTaller(txtTaller)
        'If RdbSinAsignar1.Text = "Sin asignar" Then
        '    RdbSinAsignar1.Hide()
        'End If
    End Sub




End Module

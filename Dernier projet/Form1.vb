Public Class Form1
    Dim firstnumber As Decimal
    Dim secondnumber As Decimal
    Dim operations As Integer
    Dim operatorSelect As Boolean = False
    Private Sub Button_click(sender As Object, e As EventArgs) Handles Button1.Click
        If Output.Text <> "0" Then
            Output.Text += "1"
        Else
            Output.Text = "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Output.Text <> "0" Then
            Output.Text += "2"
        Else
            Output.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Output.Text <> "0" Then
            Output.Text += "3"
        Else
            Output.Text = "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Output.Text <> "0" Then
            Output.Text += "4"
        Else
            Output.Text = "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Output.Text <> "0" Then
            Output.Text += "5"
        Else
            Output.Text = "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Output.Text <> "0" Then
            Output.Text += "6"
        Else
            Output.Text = "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Output.Text <> "0" Then
            Output.Text += "7"
        Else
            Output.Text = "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Output.Text <> "0" Then
            Output.Text += "8"
        Else
            Output.Text = "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Output.Text <> "0" Then
            Output.Text += "9"
        Else
            Output.Text = "9"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Output.Text <> "0" Then
            Output.Text += "0"
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Not (Output.Text.Contains(".")) Then
            Output.Text += "."
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Output.Text = "0"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        firstnumber = Output.Text
        Output.Text = ""
        operatorSelect = 1
        operatorSelect = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        firstnumber = Output.Text
        Output.Text = ""
        operatorSelect = 2
        operatorSelect = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        firstnumber = Output.Text
        Output.Text = ""
        operatorSelect = 3
        operatorSelect = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        firstnumber = Output.Text
        Output.Text = ""
        operatorSelect = 4
        operatorSelect = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If operatorSelect = True Then
            secondnumber = Output.Text
            If operations = 1 Then
                Output.Text = firstnumber + secondnumber
            ElseIf operations = 2 Then
                Output.Text = firstnumber - secondnumber
            ElseIf operations = 3 Then
                Output.Text = firstnumber * secondnumber
            ElseIf secondnumber = 0 Then
                Output.Text = "erreur"
                Else
                Output.Text = firstnumber / secondnumber

            End If

        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If operatorSelect = True Then
            secondnumber = Output.Text
            If operations = 1 Then
                Output.Text = firstnumber + secondnumber
            ElseIf operations = 2 Then
                Output.Text = firstnumber - secondnumber
            ElseIf operations = 3 Then
                Output.Text = firstnumber * secondnumber
            ElseIf secondnumber = 0 Then
                Output.Text = "erreur"
            Else
                Output.Text = firstnumber * secondnumber

            End If

        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If operatorSelect = True Then
            secondnumber = Output.Text
            If operations = 1 Then
                Output.Text = firstnumber + secondnumber
            ElseIf operations = 2 Then
                Output.Text = firstnumber - secondnumber
            ElseIf operations = 3 Then
                Output.Text = firstnumber * secondnumber
            ElseIf secondnumber = 0 Then
                Output.Text = "erreur"
            Else
                Output.Text = firstnumber - secondnumber

            End If

        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If operatorSelect = True Then
            secondnumber = Output.Text
            If operations = 1 Then
                Output.Text = firstnumber + secondnumber
            ElseIf operations = 2 Then
                Output.Text = firstnumber - secondnumber
            ElseIf operations = 3 Then
                Output.Text = firstnumber * secondnumber
            ElseIf secondnumber = 0 Then
                Output.Text = "erreur"
            Else
                Output.Text = firstnumber + secondnumber

            End If

        End If
    End Sub
End Class

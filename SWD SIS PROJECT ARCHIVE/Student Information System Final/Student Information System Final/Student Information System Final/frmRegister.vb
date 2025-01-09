
Imports System.Data.OleDb
Imports System.Media

Public Class frmRegister

    Private Sub frmRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Screen As System.Drawing.Rectangle
        Screen = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea()
        Me.Top = (Screen.Height \ 2) - (Me.Height \ 2)
        Me.Left = (Screen.Width \ 2) - (Me.Width \ 2)
    End Sub
    Private Sub txtfirstname_Enter(sender As Object, e As EventArgs) Handles txtfirstname.Enter

        Label4.ForeColor = Color.Red

    End Sub

    Private Sub txtfirstname_Leave(sender As Object, e As EventArgs) Handles txtfirstname.Leave

        Label4.ForeColor = Color.Black

    End Sub

    Private Sub txtlastname_Enter(sender As Object, e As EventArgs) Handles txtlastname.Enter

        Label5.ForeColor = Color.Red

    End Sub

    Private Sub txtlastname_Leave(sender As Object, e As EventArgs) Handles txtlastname.Leave

        Label5.ForeColor = Color.Black

    End Sub
    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter

        Label2.ForeColor = Color.Red

    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave

        Label2.ForeColor = Color.Black

    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter

        Label3.ForeColor = Color.Red

    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave

        Label3.ForeColor = Color.Black

    End Sub


    Private Function GetTxtUsername() As TextBox
        Return txtUsername
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        frmlogin.Show()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If txtUsername.Text.Trim().Length = 0 Then
            MsgBox("Username Cannot be Empty.", MsgBoxStyle.Exclamation, "Reminder")
            txtUsername.Focus()
            Exit Sub


        ElseIf txtPassword.Text.Trim().Length = 0 Then
            MsgBox("Password Cannot be Empty.", MsgBoxStyle.Exclamation, "Reminder")
            txtPassword.Focus()
            Exit Sub


        End If

        Dim connection As New OleDbConnection("Provider= Microsoft.Jet.oledb.4.0; Data Source = ..\Database1.mdb;")

        Dim command As New OleDbCommand("INSERT INTO tbluser ([USERNAME],[PASSWORD],[FIRSTNAME],[LASTNAME]) VALUES (username,password,firstname,lastname)", connection)

        Dim command2 As New OleDbCommand("SELECT COUNT(*)  FROM tbluser WHERE username = '" & txtUsername.Text & "'", connection)

        Dim usernameParam As New OleDbParameter("username", txtUsername.Text)
        Dim passwordParam As New OleDbParameter("password", txtPassword.Text)
        Dim firstnameParam As New OleDbParameter("firstname", txtfirstname.Text)
        Dim lastnameParam As New OleDbParameter("lastname", txtlastname.Text)


        command.Parameters.Add(usernameParam)
        command.Parameters.Add(passwordParam)
        command.Parameters.Add(firstnameParam)
        command.Parameters.Add(lastnameParam)


        command.Connection.Open()


        Dim count = Convert.ToInt32(command2.ExecuteScalar())
        If count > 0 Then
            MsgBox("Record Already Exist in the Database. Please Try New Username.", MsgBoxStyle.Exclamation, "Reminder")
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtfirstname.Text = ""
            txtlastname.Text = ""

            txtUsername.Focus()
        Else
            command.ExecuteNonQuery()
            MsgBox("Record Successfully Saved in the Database.", MsgBoxStyle.Information, "Information")
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtfirstname.Text = ""
            txtlastname.Text = ""

            txtUsername.Focus()
        End If
        command.Connection.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPassword.UseSystemPasswordChar = True
        Else
            txtPassword.UseSystemPasswordChar = False
        End If
    End Sub
End Class
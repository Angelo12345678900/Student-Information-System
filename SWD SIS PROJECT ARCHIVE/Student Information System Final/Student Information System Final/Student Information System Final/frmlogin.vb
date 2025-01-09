Imports System.Data.OleDb
Imports System.Media
Imports Student_Information_System

Public Class frmlogin
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Me.Hide()
        frmRegister.ShowDialog()
    End Sub
    Private Sub BtnRegister_MouseEnter(sender As Object, e As EventArgs) Handles BtnRegister.MouseEnter

        BtnRegister.ForeColor = Color.Red
    End Sub

    Private Sub BtnRegister_MouseLeave(sender As Object, e As EventArgs) Handles BtnRegister.MouseLeave

        BtnRegister.ForeColor = Color.Black
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles TxtUsername.Enter

        Label1.ForeColor = Color.Red

    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles TxtUsername.Leave

        Label1.ForeColor = Color.Black

    End Sub
    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles TxtPassword.Enter

        Label2.ForeColor = Color.Red

    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles TxtPassword.Leave

        Label2.ForeColor = Color.Black

    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim connection As New OleDbConnection("Provider= Microsoft.Jet.oledb.4.0; Data Source = ..\Database1.mdb;")

        Dim command As New OleDbCommand("SELECT [USERNAME],[PASSWORD],[FIRSTNAME],[LASTNAME] FROM [TBLUSER] WHERE [usernameFIELD] = USERNAME AND [passwordFIELD] = PASSWORD", connection)

        Dim usernameParam As New OleDbParameter("username", Me.TxtUsername.Text)
        Dim passwordParam As New OleDbParameter("password", Me.TxtPassword.Text)


        command.Parameters.Add(usernameParam)
        command.Parameters.Add(passwordParam)


        command.Connection.Open()

        Dim fname As String
        Dim lname As String


        Dim reader As OleDbDataReader = command.ExecuteReader()
        If (reader.Read() = True) Then
            MessageBox.Show("Welcome! : " & UCase(Me.TxtUsername.Text))
            TxtPassword.Text = ""
            Me.Hide()

            fname = reader("FIRSTNAME").ToString()
            lname = reader("LASTNAME").ToString()

            frmmain.lbluser.Text = UCase(fname) + " " + UCase(lname)

            frmmain.Show()
        Else
            MessageBox.Show("Username and or Password in not correct. Try Again Please")
            TxtUsername.Text = ""
            TxtPassword.Text = ""
            TxtUsername.Focus()
        End If

        command.Connection.Close()
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            TxtPassword.UseSystemPasswordChar = True
        Else
            TxtPassword.UseSystemPasswordChar = False
        End If
    End Sub
End Class

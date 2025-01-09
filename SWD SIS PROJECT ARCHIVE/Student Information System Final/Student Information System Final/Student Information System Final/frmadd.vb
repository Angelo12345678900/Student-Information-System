Imports System.Data.OleDb
Public Class frmadd

    Private Sub frmadd_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Call cleartext()
        txtsn.Focus()
        frmmain.lststudent.SelectedItems.Clear()
    End Sub

    Private Sub cleartext()
        Me.txtsn.Clear()
        Me.txtfn.Clear()
        Me.txtln.Clear()
        Me.txtmn.Clear()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtsn.Text = "" Or txtmn.Text = "" Or txtfn.Text = "" Or cmbcourse.Text = "" Then
            MsgBox("Please don't leave blank textfields", MsgBoxStyle.Information, "Missing data")
            Exit Sub
        End If
        Try
            Call openconnection()
            OleDa.InsertCommand = New OleDbCommand()
            OleDa.InsertCommand.CommandText = "INSERT INTO tblstudent (studentno, firstname, middlename, lastname, course)" &
            "VALUES (@studentno , @firstname, @middlename, @lastname, @course)"
            OleDa.InsertCommand.Connection = OleCn
            OleDa.InsertCommand.Parameters.Add("@studentno", OleDbType.VarWChar, 50, "studentno").Value = txtsn.Text
            OleDa.InsertCommand.Parameters.Add("@firstname", OleDbType.VarWChar, 50, "firstname").Value = txtfn.Text
            OleDa.InsertCommand.Parameters.Add("@middlename", OleDbType.VarWChar, 50, "middlename").Value = txtmn.Text
            OleDa.InsertCommand.Parameters.Add("@lastname", OleDbType.VarWChar, 50, "lastname").Value = txtln.Text
            OleDa.InsertCommand.Parameters.Add("@course", OleDbType.VarWChar, 50, "course").Value = cmbcourse.Text
            OleDa.InsertCommand.ExecuteNonQuery()
            Call frmmain.LoadListView()
            Call closeconnection()

            MsgBox("Student Saved", MsgBoxStyle.Information, "Saved")
            Me.Close()

        Catch ex As Exception
            MsgBox("Cannot Save this record, Existing Student Number", MsgBoxStyle.Information, "Error")

            Call closeconnection()
            txtsn.Focus()
            txtsn.SelectAll()
        End Try
    End Sub


    Private Sub txtfn_Enter(sender As Object, e As EventArgs) Handles txtfn.Enter

        Fn.ForeColor = Color.Red

    End Sub

    Private Sub txtfn_Leave(sender As Object, e As EventArgs) Handles txtfn.Leave

        Fn.ForeColor = Color.Black

    End Sub
    Private Sub txtmn_Enter(sender As Object, e As EventArgs) Handles txtmn.Enter

        mn.ForeColor = Color.Red

    End Sub

    Private Sub txtmn_Leave(sender As Object, e As EventArgs) Handles txtmn.Leave

        mn.ForeColor = Color.Black

    End Sub

    Private Sub txtln_Enter(sender As Object, e As EventArgs) Handles txtln.Enter

        ln.ForeColor = Color.Red

    End Sub

    Private Sub txtln_Leave(sender As Object, e As EventArgs) Handles txtln.Leave

        ln.ForeColor = Color.Black

    End Sub

    Private Sub txtsn_Enter(sender As Object, e As EventArgs) Handles txtsn.Enter

        sn.ForeColor = Color.Red

    End Sub

    Private Sub txtsn_Leave(sender As Object, e As EventArgs) Handles txtsn.Leave

        sn.ForeColor = Color.Black

    End Sub
    Private Sub cmbcourse_Enter(sender As Object, e As EventArgs) Handles cmbcourse.Enter

        course.ForeColor = Color.Red

    End Sub

    Private Sub cmbcourse_Leave(sender As Object, e As EventArgs) Handles cmbcourse.Leave

        course.ForeColor = Color.Black

    End Sub
    Private Sub txtsn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsn.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtsn_TextChanged(sender As Object, e As EventArgs) Handles txtsn.TextChanged

    End Sub
End Class
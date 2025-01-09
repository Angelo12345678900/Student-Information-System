Imports System.Data.OleDb
Public Class frmedit

    Private Sub frmedit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Call cleartext()
        txtsn.Focus()
        frmmain.lststudent.SelectedItems.Clear()
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

    Private Sub frmedit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call openconnection()
        Call Initialized()
        txtsn.Text = CStr(frmmain.lststudent.SelectedItems(0).Text)
        Call Fill()
        Call closeconnection()
    End Sub
    Private Sub cleartext()
        Me.txtsn.Clear()
        Me.txtfn.Clear()
        Me.txtln.Clear()
    End Sub
    Private Sub Fill()
        Dim OleDr As OleDbDataReader
        OleDa.SelectCommand = New OleDbCommand()
        OleDa.SelectCommand.CommandText = "SELECT * From tblstudent WHERE studentno = @studentno"
        OleDa.SelectCommand.Parameters.Add("@studentno", OleDbType.VarWChar, 50, "studentno").Value = txtsn.Text
        OleDa.SelectCommand.Connection = OleCn
        OleDr = OleDa.SelectCommand.ExecuteReader()

        If OleDr.HasRows() Then
            OleDr.Read()
            txtsn.Text = OleDr("studentno").ToString()
            txtfn.Text = OleDr("firstname").ToString()
            txtln.Text = OleDr("lastname").ToString()
            txtmn.Text = OleDr("middlename").ToString()
            cmbcourse.Text = OleDr("course").ToString()

        End If
        OleDr.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtsn.Text = "" Or txtfn.Text = "" Or txtln.Text = "" Or txtmn.Text = "" Or cmbcourse.Text = "" Then
            MsgBox("Dont leave blank textfields")
            Exit Sub
        End If
        Try
            Call openconnection()
            OleDa.UpdateCommand = New OleDbCommand()
            OleDa.UpdateCommand.CommandText = "UPDATE tblstudent SET studentno = @studentno, firstname = @firstname, middlename = @middlename, lastname = @lastname, course = @course WHERE studentno = ?"
            OleDa.UpdateCommand.Connection = OleCn
            OleDa.UpdateCommand.Parameters.Add("@studentno", OleDbType.VarWChar, 50, "studentno").Value = txtsn.Text
            OleDa.UpdateCommand.Parameters.Add("@firstname", OleDbType.VarWChar, 50, "firstname").Value = txtfn.Text
            OleDa.UpdateCommand.Parameters.Add("@lastName", OleDbType.VarWChar, 50, "lastName").Value = txtln.Text
            OleDa.UpdateCommand.Parameters.Add("@middlename", OleDbType.VarWChar, 50, "middlename").Value = txtmn.Text
            OleDa.UpdateCommand.Parameters.Add("@Course", OleDbType.VarWChar, 50, "course").Value = cmbcourse.Text
            OleDa.UpdateCommand.Parameters.Add(New System.Data.OleDb.OleDbParameter("EmpID", System.Data.OleDb.OleDbType.VarWChar, 50,
                                                System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "studentno",
                                                System.Data.DataRowVersion.Original, Nothing)).Value = frmmain.lststudent.SelectedItems(0).Text
            OleDa.UpdateCommand.ExecuteNonQuery()
            Call frmmain.LoadListView()
            Call closeconnection()

            MsgBox("Records Updated")
            Me.Close()

        Catch ex As Exception
            MsgBox("Cannot Update StudentNo is present")
            Call closeconnection()
            txtsn.Focus()
            txtsn.SelectAll()
        End Try
    End Sub
    Private Sub txtsn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsn.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class

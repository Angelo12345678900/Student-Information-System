<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmedit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmedit))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtmn = New System.Windows.Forms.TextBox()
        Me.mn = New System.Windows.Forms.Label()
        Me.cmbcourse = New System.Windows.Forms.ComboBox()
        Me.txtln = New System.Windows.Forms.TextBox()
        Me.txtfn = New System.Windows.Forms.TextBox()
        Me.txtsn = New System.Windows.Forms.TextBox()
        Me.course = New System.Windows.Forms.Label()
        Me.ln = New System.Windows.Forms.Label()
        Me.Fn = New System.Windows.Forms.Label()
        Me.sn = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Location = New System.Drawing.Point(480, 404)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(112, 35)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Location = New System.Drawing.Point(360, 403)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 35)
        Me.btnSave.TabIndex = 18
        Me.btnSave.Text = "UPDATE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(176, 91)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(553, 41)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "STUDENT PROFILE SYSTEM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(173, 23)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(411, 50)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Update Information"
        '
        'txtmn
        '
        Me.txtmn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmn.Location = New System.Drawing.Point(44, 309)
        Me.txtmn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtmn.Multiline = True
        Me.txtmn.Name = "txtmn"
        Me.txtmn.Size = New System.Drawing.Size(253, 37)
        Me.txtmn.TabIndex = 27
        '
        'mn
        '
        Me.mn.AutoSize = True
        Me.mn.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mn.Location = New System.Drawing.Point(41, 279)
        Me.mn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.mn.Name = "mn"
        Me.mn.Size = New System.Drawing.Size(131, 24)
        Me.mn.TabIndex = 29
        Me.mn.Text = "Middle Name"
        '
        'cmbcourse
        '
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.Items.AddRange(New Object() {"BSCpE 1A", "BSCpE 1B", "BSCpE 2A", "BSCpE 2B"})
        Me.cmbcourse.Location = New System.Drawing.Point(360, 309)
        Me.cmbcourse.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(253, 28)
        Me.cmbcourse.TabIndex = 28
        '
        'txtln
        '
        Me.txtln.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtln.Location = New System.Drawing.Point(43, 403)
        Me.txtln.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtln.Multiline = True
        Me.txtln.Name = "txtln"
        Me.txtln.Size = New System.Drawing.Size(253, 37)
        Me.txtln.TabIndex = 26
        '
        'txtfn
        '
        Me.txtfn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfn.Location = New System.Drawing.Point(44, 218)
        Me.txtfn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtfn.Multiline = True
        Me.txtfn.Name = "txtfn"
        Me.txtfn.Size = New System.Drawing.Size(252, 37)
        Me.txtfn.TabIndex = 25
        '
        'txtsn
        '
        Me.txtsn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsn.Location = New System.Drawing.Point(360, 218)
        Me.txtsn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtsn.Multiline = True
        Me.txtsn.Name = "txtsn"
        Me.txtsn.Size = New System.Drawing.Size(253, 37)
        Me.txtsn.TabIndex = 24
        '
        'course
        '
        Me.course.AutoSize = True
        Me.course.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.course.Location = New System.Drawing.Point(356, 276)
        Me.course.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.course.Name = "course"
        Me.course.Size = New System.Drawing.Size(214, 24)
        Me.course.TabIndex = 23
        Me.course.Text = "Course/ Yr. Level/ Blk"
        '
        'ln
        '
        Me.ln.AutoSize = True
        Me.ln.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ln.Location = New System.Drawing.Point(42, 373)
        Me.ln.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.ln.Name = "ln"
        Me.ln.Size = New System.Drawing.Size(110, 24)
        Me.ln.TabIndex = 22
        Me.ln.Text = "Last Name"
        '
        'Fn
        '
        Me.Fn.AutoSize = True
        Me.Fn.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fn.Location = New System.Drawing.Point(40, 188)
        Me.Fn.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Fn.Name = "Fn"
        Me.Fn.Size = New System.Drawing.Size(112, 24)
        Me.Fn.TabIndex = 21
        Me.Fn.Text = "First Name"
        '
        'sn
        '
        Me.sn.AutoSize = True
        Me.sn.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sn.Location = New System.Drawing.Point(356, 188)
        Me.sn.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.sn.Name = "sn"
        Me.sn.Size = New System.Drawing.Size(116, 24)
        Me.sn.TabIndex = 20
        Me.sn.Text = "Student No"
        '
        'frmedit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(736, 475)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtmn)
        Me.Controls.Add(Me.mn)
        Me.Controls.Add(Me.cmbcourse)
        Me.Controls.Add(Me.txtln)
        Me.Controls.Add(Me.txtfn)
        Me.Controls.Add(Me.txtsn)
        Me.Controls.Add(Me.course)
        Me.Controls.Add(Me.ln)
        Me.Controls.Add(Me.Fn)
        Me.Controls.Add(Me.sn)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmedit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Student"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtmn As TextBox
    Friend WithEvents mn As Label
    Friend WithEvents cmbcourse As ComboBox
    Friend WithEvents txtln As TextBox
    Friend WithEvents txtfn As TextBox
    Friend WithEvents txtsn As TextBox
    Friend WithEvents course As Label
    Friend WithEvents ln As Label
    Friend WithEvents Fn As Label
    Friend WithEvents sn As Label
End Class

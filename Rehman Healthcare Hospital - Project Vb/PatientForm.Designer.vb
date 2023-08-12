<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.dtDob = New System.Windows.Forms.DateTimePicker()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.RichTextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.label8 = New System.Windows.Forms.Label()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.label10 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.label9 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.mskPhoneNo = New System.Windows.Forms.MaskedTextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtfirstName = New System.Windows.Forms.TextBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.Purple
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.Location = New System.Drawing.Point(336, 478)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(130, 35)
        Me.button1.TabIndex = 113
        Me.button1.Text = "Back To Main"
        Me.button1.UseVisualStyleBackColor = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Red
        Me.lblEmail.Location = New System.Drawing.Point(227, 272)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(0, 12)
        Me.lblEmail.TabIndex = 111
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNo.ForeColor = System.Drawing.Color.Red
        Me.lblPhoneNo.Location = New System.Drawing.Point(227, 402)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(0, 12)
        Me.lblPhoneNo.TabIndex = 110
        '
        'dtDob
        '
        Me.dtDob.Location = New System.Drawing.Point(226, 208)
        Me.dtDob.Name = "dtDob"
        Me.dtDob.Size = New System.Drawing.Size(270, 20)
        Me.dtDob.TabIndex = 109
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Red
        Me.lblAddress.Location = New System.Drawing.Point(227, 366)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(0, 12)
        Me.lblAddress.TabIndex = 108
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.ForeColor = System.Drawing.Color.Red
        Me.lblLastName.Location = New System.Drawing.Point(373, 165)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(0, 12)
        Me.lblLastName.TabIndex = 107
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.Red
        Me.lblFirstName.Location = New System.Drawing.Point(227, 165)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(0, 12)
        Me.lblFirstName.TabIndex = 106
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(727, 143)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(248, 282)
        Me.txtResult.TabIndex = 105
        Me.txtResult.Text = ""
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.ForeColor = System.Drawing.Color.Red
        Me.lblGender.Location = New System.Drawing.Point(145, 41)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(0, 12)
        Me.lblGender.TabIndex = 70
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(884, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(91, 35)
        Me.btnLogout.TabIndex = 112
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lblGender)
        Me.groupBox1.Controls.Add(Me.rdoFemale)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.rdoMale)
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBox1.Location = New System.Drawing.Point(79, 411)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(312, 61)
        Me.groupBox1.TabIndex = 104
        Me.groupBox1.TabStop = False
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Location = New System.Drawing.Point(226, 19)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(59, 17)
        Me.rdoFemale.TabIndex = 19
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.Location = New System.Drawing.Point(17, 19)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(52, 17)
        Me.label8.TabIndex = 17
        Me.label8.Text = "Gender"
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Location = New System.Drawing.Point(147, 19)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(48, 17)
        Me.rdoMale.TabIndex = 18
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.Location = New System.Drawing.Point(97, 302)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(57, 17)
        Me.label10.TabIndex = 103
        Me.label10.Text = "Address"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(227, 286)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(269, 75)
        Me.txtAddress.TabIndex = 102
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(97, 208)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(36, 17)
        Me.label9.TabIndex = 101
        Me.label9.Text = "DOB"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(224, 478)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(91, 35)
        Me.btnSubmit.TabIndex = 100
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'mskPhoneNo
        '
        Me.mskPhoneNo.Location = New System.Drawing.Point(227, 381)
        Me.mskPhoneNo.Mask = "0000-0000000"
        Me.mskPhoneNo.Name = "mskPhoneNo"
        Me.mskPhoneNo.Size = New System.Drawing.Size(111, 20)
        Me.mskPhoneNo.TabIndex = 99
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(97, 383)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(69, 17)
        Me.label6.TabIndex = 98
        Me.label6.Text = "Phone No"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(227, 251)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(269, 20)
        Me.txtEmail.TabIndex = 97
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(97, 253)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(42, 17)
        Me.label4.TabIndex = 96
        Me.label4.Text = "Email"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label5.Location = New System.Drawing.Point(369, 121)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(59, 14)
        Me.label5.TabIndex = 95
        Me.label5.Text = "Last Name"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Gadugi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.label3.Location = New System.Drawing.Point(224, 121)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(61, 14)
        Me.label3.TabIndex = 94
        Me.label3.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(372, 140)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(124, 20)
        Me.txtLastName.TabIndex = 93
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Gadugi", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(97, 142)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(44, 17)
        Me.label2.TabIndex = 92
        Me.label2.Text = "Name"
        '
        'txtfirstName
        '
        Me.txtfirstName.Location = New System.Drawing.Point(227, 140)
        Me.txtfirstName.Name = "txtfirstName"
        Me.txtfirstName.Size = New System.Drawing.Size(127, 20)
        Me.txtfirstName.TabIndex = 89
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.IndianRed
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(1019, 55)
        Me.pictureBox1.TabIndex = 91
        Me.pictureBox1.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.IndianRed
        Me.label1.Font = New System.Drawing.Font("Yu Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(235, 7)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(444, 48)
        Me.label1.TabIndex = 90
        Me.label1.Text = "PATIENT ENTRY FORM"
        '
        'PatientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 537)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhoneNo)
        Me.Controls.Add(Me.dtDob)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.mskPhoneNo)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtfirstName)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Name = "PatientForm"
        Me.Text = "PatientForm"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button1 As Button
    Private WithEvents lblEmail As Label
    Private WithEvents lblPhoneNo As Label
    Private WithEvents dtDob As DateTimePicker
    Private WithEvents lblAddress As Label
    Private WithEvents lblLastName As Label
    Private WithEvents lblFirstName As Label
    Private WithEvents txtResult As RichTextBox
    Private WithEvents lblGender As Label
    Private WithEvents btnLogout As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents rdoFemale As RadioButton
    Private WithEvents label8 As Label
    Private WithEvents rdoMale As RadioButton
    Private WithEvents label10 As Label
    Private WithEvents txtAddress As TextBox
    Private WithEvents label9 As Label
    Private WithEvents btnSubmit As Button
    Private WithEvents mskPhoneNo As MaskedTextBox
    Private WithEvents label6 As Label
    Private WithEvents txtEmail As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label5 As Label
    Private WithEvents label3 As Label
    Private WithEvents txtLastName As TextBox
    Private WithEvents label2 As Label
    Private WithEvents txtfirstName As TextBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label1 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanelForm
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
        Me.btnDisease = New System.Windows.Forms.Button()
        Me.btnWard = New System.Windows.Forms.Button()
        Me.btnPatient = New System.Windows.Forms.Button()
        Me.btnNurse = New System.Windows.Forms.Button()
        Me.btnEquipment = New System.Windows.Forms.Button()
        Me.btnLab = New System.Windows.Forms.Button()
        Me.btnDoctor = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox8 = New System.Windows.Forms.PictureBox()
        Me.pictureBox7 = New System.Windows.Forms.PictureBox()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.pictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDisease
        '
        Me.btnDisease.BackColor = System.Drawing.Color.Indigo
        Me.btnDisease.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisease.ForeColor = System.Drawing.Color.White
        Me.btnDisease.Location = New System.Drawing.Point(12, 346)
        Me.btnDisease.Name = "btnDisease"
        Me.btnDisease.Size = New System.Drawing.Size(172, 39)
        Me.btnDisease.TabIndex = 30
        Me.btnDisease.Text = "Diseases"
        Me.btnDisease.UseVisualStyleBackColor = False
        '
        'btnWard
        '
        Me.btnWard.BackColor = System.Drawing.Color.Indigo
        Me.btnWard.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWard.ForeColor = System.Drawing.Color.White
        Me.btnWard.Location = New System.Drawing.Point(12, 301)
        Me.btnWard.Name = "btnWard"
        Me.btnWard.Size = New System.Drawing.Size(172, 39)
        Me.btnWard.TabIndex = 29
        Me.btnWard.Text = "Wards"
        Me.btnWard.UseVisualStyleBackColor = False
        '
        'btnPatient
        '
        Me.btnPatient.BackColor = System.Drawing.Color.Indigo
        Me.btnPatient.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatient.ForeColor = System.Drawing.Color.White
        Me.btnPatient.Location = New System.Drawing.Point(12, 256)
        Me.btnPatient.Name = "btnPatient"
        Me.btnPatient.Size = New System.Drawing.Size(172, 39)
        Me.btnPatient.TabIndex = 28
        Me.btnPatient.Text = "Patients"
        Me.btnPatient.UseVisualStyleBackColor = False
        '
        'btnNurse
        '
        Me.btnNurse.BackColor = System.Drawing.Color.Indigo
        Me.btnNurse.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNurse.ForeColor = System.Drawing.Color.White
        Me.btnNurse.Location = New System.Drawing.Point(12, 121)
        Me.btnNurse.Name = "btnNurse"
        Me.btnNurse.Size = New System.Drawing.Size(172, 39)
        Me.btnNurse.TabIndex = 27
        Me.btnNurse.Text = "Nurses"
        Me.btnNurse.UseVisualStyleBackColor = False
        '
        'btnEquipment
        '
        Me.btnEquipment.BackColor = System.Drawing.Color.Indigo
        Me.btnEquipment.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquipment.ForeColor = System.Drawing.Color.White
        Me.btnEquipment.Location = New System.Drawing.Point(12, 166)
        Me.btnEquipment.Name = "btnEquipment"
        Me.btnEquipment.Size = New System.Drawing.Size(172, 39)
        Me.btnEquipment.TabIndex = 26
        Me.btnEquipment.Text = "Medical Equipment "
        Me.btnEquipment.UseVisualStyleBackColor = False
        '
        'btnLab
        '
        Me.btnLab.BackColor = System.Drawing.Color.Indigo
        Me.btnLab.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLab.ForeColor = System.Drawing.Color.White
        Me.btnLab.Location = New System.Drawing.Point(12, 211)
        Me.btnLab.Name = "btnLab"
        Me.btnLab.Size = New System.Drawing.Size(172, 39)
        Me.btnLab.TabIndex = 25
        Me.btnLab.Text = "Laboratory"
        Me.btnLab.UseVisualStyleBackColor = False
        '
        'btnDoctor
        '
        Me.btnDoctor.BackColor = System.Drawing.Color.Indigo
        Me.btnDoctor.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctor.ForeColor = System.Drawing.Color.White
        Me.btnDoctor.Location = New System.Drawing.Point(12, 77)
        Me.btnDoctor.Name = "btnDoctor"
        Me.btnDoctor.Size = New System.Drawing.Size(172, 39)
        Me.btnDoctor.TabIndex = 24
        Me.btnDoctor.Text = "Doctors"
        Me.btnDoctor.UseVisualStyleBackColor = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Location = New System.Drawing.Point(13, 106)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(171, 24)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox2.TabIndex = 32
        Me.pictureBox2.TabStop = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Firebrick
        Me.btnLogout.Font = New System.Drawing.Font("Gill Sans MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(676, 405)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(74, 39)
        Me.btnLogout.TabIndex = 31
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.IndianRed
        Me.label1.Location = New System.Drawing.Point(168, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(464, 30)
        Me.label1.TabIndex = 23
        Me.label1.Text = "Rehman Healthcare - Admin Panel"
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.IndianRed
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(800, 50)
        Me.pictureBox1.TabIndex = 22
        Me.pictureBox1.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Location = New System.Drawing.Point(13, 152)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(171, 24)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox3.TabIndex = 33
        Me.pictureBox3.TabStop = False
        '
        'pictureBox8
        '
        Me.pictureBox8.Location = New System.Drawing.Point(12, 196)
        Me.pictureBox8.Name = "pictureBox8"
        Me.pictureBox8.Size = New System.Drawing.Size(171, 24)
        Me.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox8.TabIndex = 38
        Me.pictureBox8.TabStop = False
        '
        'pictureBox7
        '
        Me.pictureBox7.Location = New System.Drawing.Point(12, 241)
        Me.pictureBox7.Name = "pictureBox7"
        Me.pictureBox7.Size = New System.Drawing.Size(171, 24)
        Me.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox7.TabIndex = 37
        Me.pictureBox7.TabStop = False
        '
        'pictureBox6
        '
        Me.pictureBox6.Location = New System.Drawing.Point(13, 287)
        Me.pictureBox6.Name = "pictureBox6"
        Me.pictureBox6.Size = New System.Drawing.Size(171, 24)
        Me.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox6.TabIndex = 36
        Me.pictureBox6.TabStop = False
        '
        'pictureBox5
        '
        Me.pictureBox5.Location = New System.Drawing.Point(13, 333)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(171, 24)
        Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox5.TabIndex = 35
        Me.pictureBox5.TabStop = False
        '
        'pictureBox4
        '
        Me.pictureBox4.Location = New System.Drawing.Point(13, 342)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(171, 98)
        Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox4.TabIndex = 34
        Me.pictureBox4.TabStop = False
        '
        'AdminPanelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDisease)
        Me.Controls.Add(Me.btnWard)
        Me.Controls.Add(Me.btnPatient)
        Me.Controls.Add(Me.btnNurse)
        Me.Controls.Add(Me.btnEquipment)
        Me.Controls.Add(Me.btnLab)
        Me.Controls.Add(Me.btnDoctor)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.pictureBox8)
        Me.Controls.Add(Me.pictureBox7)
        Me.Controls.Add(Me.pictureBox6)
        Me.Controls.Add(Me.pictureBox5)
        Me.Controls.Add(Me.pictureBox4)
        Me.Name = "AdminPanelForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminPanelForm"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnDisease As Button
    Private WithEvents btnWard As Button
    Private WithEvents btnPatient As Button
    Private WithEvents btnNurse As Button
    Private WithEvents btnEquipment As Button
    Private WithEvents btnLab As Button
    Private WithEvents btnDoctor As Button
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents btnLogout As Button
    Private WithEvents label1 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents pictureBox8 As PictureBox
    Private WithEvents pictureBox7 As PictureBox
    Private WithEvents pictureBox6 As PictureBox
    Private WithEvents pictureBox5 As PictureBox
    Private WithEvents pictureBox4 As PictureBox
End Class

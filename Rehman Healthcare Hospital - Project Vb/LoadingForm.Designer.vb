<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadingForm))
        Me.label2 = New System.Windows.Forms.Label()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblLoadingfrm = New System.Windows.Forms.Label()
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label2.Font = New System.Drawing.Font("Verdana", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.LightCoral
        Me.label2.Location = New System.Drawing.Point(430, 257)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(330, 78)
        Me.label2.TabIndex = 9
        Me.label2.Text = "Hospital"
        '
        'timer1
        '
        Me.timer1.Enabled = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pictureBox1.ErrorImage = CType(resources.GetObject("pictureBox1.ErrorImage"), System.Drawing.Image)
        Me.pictureBox1.Image = Global.Rehman_Healthcare_Hospital___Project_Vb.My.Resources.Resources.LoadingGif
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(800, 421)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 5
        Me.pictureBox1.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.LightCoral
        Me.label1.Location = New System.Drawing.Point(525, 245)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(140, 25)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Healthcare"
        '
        'lblLoadingfrm
        '
        Me.lblLoadingfrm.AutoSize = True
        Me.lblLoadingfrm.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLoadingfrm.Font = New System.Drawing.Font("Verdana", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadingfrm.ForeColor = System.Drawing.Color.LightCoral
        Me.lblLoadingfrm.Location = New System.Drawing.Point(379, 172)
        Me.lblLoadingfrm.Name = "lblLoadingfrm"
        Me.lblLoadingfrm.Size = New System.Drawing.Size(432, 78)
        Me.lblLoadingfrm.TabIndex = 7
        Me.lblLoadingfrm.Text = "Al-Rehman"
        '
        'progressBar1
        '
        Me.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.progressBar1.Location = New System.Drawing.Point(0, 418)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(800, 32)
        Me.progressBar1.TabIndex = 6
        '
        'LoadingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblLoadingfrm)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Name = "LoadingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Rehman HealthCare Hospital - Loading"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label2 As Label
    Private WithEvents timer1 As Timer
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents lblLoadingfrm As Label
    Private WithEvents progressBar1 As ProgressBar
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.txtVersion = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.imgLogo = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.KryptonWrapLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
        Me.txbName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnGo = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2007Blue
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Maths123.My.Resources.Resources.wavy_background
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.txtVersion)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.imgLogo)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 397)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Maths123.My.Resources.Resources.spot2
        Me.PictureBox2.Location = New System.Drawing.Point(486, 257)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'txtVersion
        '
        Me.txtVersion.Location = New System.Drawing.Point(12, 365)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(51, 20)
        Me.txtVersion.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.txtVersion.TabIndex = 7
        Me.txtVersion.Values.Text = "Version"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Maths123.My.Resources.Resources.Maths123
        Me.PictureBox1.Location = New System.Drawing.Point(126, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'imgLogo
        '
        Me.imgLogo.BackColor = System.Drawing.Color.Transparent
        Me.imgLogo.Image = Global.Maths123.My.Resources.Resources.calculator6
        Me.imgLogo.Location = New System.Drawing.Point(1, -7)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(128, 128)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgLogo.TabIndex = 1
        Me.imgLogo.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.Maths123.My.Resources.Resources.loginbg
        Me.Panel2.Controls.Add(Me.KryptonWrapLabel1)
        Me.Panel2.Controls.Add(Me.txbName)
        Me.Panel2.Controls.Add(Me.btnGo)
        Me.Panel2.Location = New System.Drawing.Point(152, 160)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(420, 95)
        Me.Panel2.TabIndex = 6
        '
        'KryptonWrapLabel1
        '
        Me.KryptonWrapLabel1.Font = New System.Drawing.Font("Segoe UI", 13.5!, System.Drawing.FontStyle.Bold)
        Me.KryptonWrapLabel1.ForeColor = System.Drawing.Color.White
        Me.KryptonWrapLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.KryptonWrapLabel1.Location = New System.Drawing.Point(7, 14)
        Me.KryptonWrapLabel1.Name = "KryptonWrapLabel1"
        Me.KryptonWrapLabel1.Size = New System.Drawing.Size(308, 25)
        Me.KryptonWrapLabel1.StateCommon.TextColor = System.Drawing.Color.White
        Me.KryptonWrapLabel1.Text = "Please type your name to continue"
        '
        'txbName
        '
        Me.txbName.Location = New System.Drawing.Point(13, 42)
        Me.txbName.Name = "txbName"
        Me.txbName.Size = New System.Drawing.Size(333, 40)
        Me.txbName.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbName.StateNormal.Content.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbName.TabIndex = 1
        Me.txbName.WordWrap = False
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(352, 42)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(58, 40)
        Me.btnGo.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.TabIndex = 4
        Me.btnGo.Values.Text = "Go"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 397)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maths123"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents imgLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents KryptonWrapLabel1 As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
    Friend WithEvents txbName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents btnGo As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtVersion As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class

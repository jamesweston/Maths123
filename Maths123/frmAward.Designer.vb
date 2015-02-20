<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAward
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAward))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtName = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnMenu = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnPrint = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.imgLogo = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtSc = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtScore = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.txtTopic = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Maths123.My.Resources.Resources.wavy_background
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.btnMenu)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.imgLogo)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 397)
        Me.Panel1.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.AutoSize = False
        Me.txtName.Location = New System.Drawing.Point(80, 114)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(446, 72)
        Me.txtName.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.txtName.TabIndex = 5
        Me.txtName.Values.Text = "Name"
        '
        'btnMenu
        '
        Me.btnMenu.AutoSize = True
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Location = New System.Drawing.Point(201, 337)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(181, 76)
        Me.btnMenu.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnMenu.StateCommon.Border.Rounding = 50
        Me.btnMenu.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        Me.btnMenu.Values.Text = "Menu"
        '
        'btnPrint
        '
        Me.btnPrint.AutoSize = True
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Location = New System.Drawing.Point(388, 337)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(197, 76)
        Me.btnPrint.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnPrint.StateCommon.Border.Rounding = 50
        Me.btnPrint.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Values.Text = "Print"
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
        Me.Panel2.BackgroundImage = Global.Maths123.My.Resources.Resources.calcwindows
        Me.Panel2.Controls.Add(Me.txtTopic)
        Me.Panel2.Controls.Add(Me.txtSc)
        Me.Panel2.Controls.Add(Me.txtScore)
        Me.Panel2.Location = New System.Drawing.Point(13, 191)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(560, 144)
        Me.Panel2.TabIndex = 12
        '
        'txtSc
        '
        Me.txtSc.Location = New System.Drawing.Point(220, -8)
        Me.txtSc.Name = "txtSc"
        Me.txtSc.Size = New System.Drawing.Size(131, 56)
        Me.txtSc.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.txtSc.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSc.TabIndex = 6
        Me.txtSc.Values.Text = "scored"
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(108, 16)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(382, 96)
        Me.txtScore.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.txtScore.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.txtScore.TabIndex = 7
        Me.txtScore.Values.Text = "10 out of 10"
        '
        'txtTopic
        '
        Me.txtTopic.AutoSize = False
        Me.txtTopic.Location = New System.Drawing.Point(7, 88)
        Me.txtTopic.Name = "txtTopic"
        Me.txtTopic.Size = New System.Drawing.Size(561, 56)
        Me.txtTopic.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.txtTopic.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTopic.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.txtTopic.TabIndex = 13
        Me.txtTopic.Values.Text = "in Addition"
        '
        'frmAward
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 397)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAward"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maths123"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

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
    Friend WithEvents btnPrint As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMenu As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtScore As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtName As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtSc As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtTopic As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class

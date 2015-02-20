<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMultiplication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMultiplication))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtCount = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtNum1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.txtNum2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.btnCheck = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtDetails = New System.Windows.Forms.Label
        Me.imgDetails = New System.Windows.Forms.PictureBox
        Me.txtNum3 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.btnMenu = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtWelcome = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
        Me.btnTime = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnNext = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.imgLogo = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.imgDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Maths123.My.Resources.Resources.wavy_background
        Me.Panel1.Controls.Add(Me.txtCount)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnMenu)
        Me.Panel1.Controls.Add(Me.txtWelcome)
        Me.Panel1.Controls.Add(Me.btnTime)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.imgLogo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 397)
        Me.Panel1.TabIndex = 0
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(13, 127)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(48, 20)
        Me.txtCount.TabIndex = 13
        Me.txtCount.Values.Text = "0 of 10"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.Maths123.My.Resources.Resources.calcwindows
        Me.Panel2.Controls.Add(Me.txtNum1)
        Me.Panel2.Controls.Add(Me.txtNum2)
        Me.Panel2.Controls.Add(Me.btnCheck)
        Me.Panel2.Controls.Add(Me.txtDetails)
        Me.Panel2.Controls.Add(Me.imgDetails)
        Me.Panel2.Controls.Add(Me.txtNum3)
        Me.Panel2.Controls.Add(Me.KryptonLabel3)
        Me.Panel2.Controls.Add(Me.KryptonLabel1)
        Me.Panel2.Location = New System.Drawing.Point(12, 151)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(560, 144)
        Me.Panel2.TabIndex = 11
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(15, 25)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(116, 82)
        Me.txtNum1.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue
        Me.txtNum1.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNum1.StateCommon.Content.Color1 = System.Drawing.Color.White
        Me.txtNum1.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum1.StateCommon.Content.Padding = New System.Windows.Forms.Padding(-1, -5, -1, -1)
        Me.txtNum1.TabIndex = 1
        Me.txtNum1.Text = "0"
        Me.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNum1.WordWrap = False
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(176, 25)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 82)
        Me.txtNum2.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue
        Me.txtNum2.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNum2.StateCommon.Content.Color1 = System.Drawing.Color.White
        Me.txtNum2.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum2.StateCommon.Content.Padding = New System.Windows.Forms.Padding(-1, -5, -1, -1)
        Me.txtNum2.TabIndex = 2
        Me.txtNum2.Text = "0"
        Me.txtNum2.WordWrap = False
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(446, 20)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(105, 90)
        Me.btnCheck.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheck.TabIndex = 4
        Me.btnCheck.Values.Text = "Check"
        '
        'txtDetails
        '
        Me.txtDetails.AutoSize = True
        Me.txtDetails.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetails.ForeColor = System.Drawing.Color.White
        Me.txtDetails.Location = New System.Drawing.Point(447, 86)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(110, 30)
        Me.txtDetails.TabIndex = 15
        Me.txtDetails.Text = "Well Done"
        Me.txtDetails.Visible = False
        '
        'imgDetails
        '
        Me.imgDetails.Image = Global.Maths123.My.Resources.Resources.accept
        Me.imgDetails.Location = New System.Drawing.Point(465, 19)
        Me.imgDetails.Name = "imgDetails"
        Me.imgDetails.Size = New System.Drawing.Size(64, 64)
        Me.imgDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgDetails.TabIndex = 14
        Me.imgDetails.TabStop = False
        Me.imgDetails.Visible = False
        '
        'txtNum3
        '
        Me.txtNum3.Location = New System.Drawing.Point(341, 25)
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.Size = New System.Drawing.Size(100, 82)
        Me.txtNum3.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue
        Me.txtNum3.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtNum3.StateCommon.Content.Color1 = System.Drawing.Color.White
        Me.txtNum3.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum3.StateCommon.Content.Padding = New System.Windows.Forms.Padding(-1, -5, -1, -1)
        Me.txtNum3.TabIndex = 3
        Me.txtNum3.Text = "0"
        Me.txtNum3.WordWrap = False
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(273, 16)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(73, 96)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 12
        Me.KryptonLabel3.Values.Text = "="
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(119, 15)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(73, 96)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 9
        Me.KryptonLabel1.Values.Text = "×"
        '
        'btnMenu
        '
        Me.btnMenu.AutoSize = True
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Location = New System.Drawing.Point(201, 315)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(181, 76)
        Me.btnMenu.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnMenu.StateCommon.Border.Rounding = 50
        Me.btnMenu.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.TabIndex = 6
        Me.btnMenu.TabStop = False
        Me.btnMenu.Values.Text = "Menu"
        '
        'txtWelcome
        '
        Me.txtWelcome.AutoSize = False
        Me.txtWelcome.Font = New System.Drawing.Font("Segoe UI", 13.5!, System.Drawing.FontStyle.Bold)
        Me.txtWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.txtWelcome.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.txtWelcome.Location = New System.Drawing.Point(122, 93)
        Me.txtWelcome.Name = "txtWelcome"
        Me.txtWelcome.Size = New System.Drawing.Size(458, 55)
        Me.txtWelcome.Text = "Hello NULL please answer the addition questions"
        '
        'btnTime
        '
        Me.btnTime.AutoSize = True
        Me.btnTime.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTime.Location = New System.Drawing.Point(0, 315)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(196, 76)
        Me.btnTime.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnTime.StateCommon.Border.Rounding = 50
        Me.btnTime.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTime.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnTime.TabIndex = 7
        Me.btnTime.Values.Text = "Time"
        Me.btnTime.Visible = False
        '
        'btnNext
        '
        Me.btnNext.AutoSize = True
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.Location = New System.Drawing.Point(388, 315)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(197, 76)
        Me.btnNext.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnNext.StateCommon.Border.Rounding = 50
        Me.btnNext.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnNext.TabIndex = 5
        Me.btnNext.TabStop = False
        Me.btnNext.Values.Text = "Next"
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
        'frmMultiplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 397)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMultiplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maths123"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.imgDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtWelcome As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
    Friend WithEvents btnNext As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnTime As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMenu As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtNum3 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents imgDetails As System.Windows.Forms.PictureBox
    Friend WithEvents txtDetails As System.Windows.Forms.Label
    Friend WithEvents btnCheck As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtNum1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtNum2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtCount As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmData))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.HBarChart1 = New BarChart.HBarChart
        Me.txtCount = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblQu = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
        Me.txtDetails = New System.Windows.Forms.Label
        Me.imgDetails = New System.Windows.Forms.PictureBox
        Me.btnMenu = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtWelcome = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
        Me.btnTime = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnNext = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.imgLogo = New System.Windows.Forms.PictureBox
        Me.imgMoney = New System.Windows.Forms.ImageList(Me.components)
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
        Me.Panel1.Controls.Add(Me.HBarChart1)
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
        'HBarChart1
        '
        Me.HBarChart1.BackColor = System.Drawing.SystemColors.Control
        Me.HBarChart1.Background.GradientColor1 = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.HBarChart1.Background.GradientColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.HBarChart1.Background.PaintingMode = BarChart.CBackgroundProperty.PaintingModes.RadialGradient
        Me.HBarChart1.Background.SolidColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.HBarChart1.BarsGap = 4
        Me.HBarChart1.BarWidth = 24
        Me.HBarChart1.Border.BoundRect = CType(resources.GetObject("resource.BoundRect"), System.Drawing.RectangleF)
        Me.HBarChart1.Border.Color = System.Drawing.Color.White
        Me.HBarChart1.Border.Visible = True
        Me.HBarChart1.Border.Width = 1
        Me.HBarChart1.Description.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HBarChart1.Description.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.HBarChart1.Description.FontDefaultSize = 14.0!
        Me.HBarChart1.Description.Text = ""
        Me.HBarChart1.Description.Visible = True
        Me.HBarChart1.Items.DefaultWidth = 0
        Me.HBarChart1.Items.DrawingMode = BarChart.HBarItems.DrawingModes.Glass
        Me.HBarChart1.Items.ShouldReCalculate = False
        Me.HBarChart1.Label.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HBarChart1.Label.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.HBarChart1.Label.FontDefaultSize = 8.0!
        Me.HBarChart1.Label.Visible = True
        Me.HBarChart1.Location = New System.Drawing.Point(153, 127)
        Me.HBarChart1.Name = "HBarChart1"
        Me.HBarChart1.Shadow.ColorInner = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HBarChart1.Shadow.ColorOuter = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HBarChart1.Shadow.Mode = BarChart.CShadowProperty.Modes.Inner
        Me.HBarChart1.Shadow.WidthInner = 5
        Me.HBarChart1.Shadow.WidthOuter = 5
        Me.HBarChart1.Size = New System.Drawing.Size(300, 182)
        Me.HBarChart1.SizingMode = BarChart.HBarChart.BarSizingMode.Normal
        Me.HBarChart1.TabIndex = 16
        Me.HBarChart1.Values.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HBarChart1.Values.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.HBarChart1.Values.FontDefaultSize = 7.0!
        Me.HBarChart1.Values.Mode = BarChart.CValueProperty.ValueMode.Digit
        Me.HBarChart1.Values.Visible = True
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
        Me.Panel2.Controls.Add(Me.lblQu)
        Me.Panel2.Controls.Add(Me.txtDetails)
        Me.Panel2.Controls.Add(Me.imgDetails)
        Me.Panel2.Location = New System.Drawing.Point(12, 151)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(560, 144)
        Me.Panel2.TabIndex = 11
        '
        'lblQu
        '
        Me.lblQu.AutoSize = False
        Me.lblQu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblQu.ForeColor = System.Drawing.Color.White
        Me.lblQu.Location = New System.Drawing.Point(3, 9)
        Me.lblQu.Name = "lblQu"
        Me.lblQu.Size = New System.Drawing.Size(132, 123)
        Me.lblQu.StateNormal.TextColor = System.Drawing.Color.White
        Me.lblQu.Text = "Hello NULL please answer the money questions"
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
        Me.txtWelcome.Text = "Hello NULL please answer the money questions"
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
        'imgMoney
        '
        Me.imgMoney.ImageStream = CType(resources.GetObject("imgMoney.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgMoney.TransparentColor = System.Drawing.Color.Magenta
        Me.imgMoney.Images.SetKeyName(0, "1penny.png")
        Me.imgMoney.Images.SetKeyName(1, "2PENCE.png")
        Me.imgMoney.Images.SetKeyName(2, "5PENCE.png")
        Me.imgMoney.Images.SetKeyName(3, "10PENCE.png")
        Me.imgMoney.Images.SetKeyName(4, "20PENCE.png")
        Me.imgMoney.Images.SetKeyName(5, "50pence.png")
        Me.imgMoney.Images.SetKeyName(6, "1pound.png")
        Me.imgMoney.Images.SetKeyName(7, "2pounds.png")
        '
        'frmData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 397)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmData"
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
    Friend WithEvents imgDetails As System.Windows.Forms.PictureBox
    Friend WithEvents txtDetails As System.Windows.Forms.Label
    Friend WithEvents txtCount As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents imgMoney As System.Windows.Forms.ImageList
    Friend WithEvents HBarChart1 As BarChart.HBarChart
    Friend WithEvents lblQu As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
End Class

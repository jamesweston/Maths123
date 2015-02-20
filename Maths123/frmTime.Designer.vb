<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTime))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtCount = New ComponentFactory.Krypton.Toolkit.KryptonLabel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.time4 = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
        Me.time3 = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
        Me.time2 = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
        Me.time1 = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
        Me.aClock = New AC.StdControls.Toolkit.Common.AnalogClock
        Me.txtDetails = New System.Windows.Forms.Label
        Me.imgDetails = New System.Windows.Forms.PictureBox
        Me.txtTime = New System.Windows.Forms.Label
        Me.pbTime = New System.Windows.Forms.PictureBox
        Me.btnMenu = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtWelcome = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
        Me.btnTime = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnNext = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.imgLogo = New System.Windows.Forms.PictureBox
        Me.imgTime = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.imgDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Maths123.My.Resources.Resources.wavy_background
        Me.Panel1.Controls.Add(Me.txtCount)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtTime)
        Me.Panel1.Controls.Add(Me.pbTime)
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
        Me.Panel2.Controls.Add(Me.time4)
        Me.Panel2.Controls.Add(Me.time3)
        Me.Panel2.Controls.Add(Me.time2)
        Me.Panel2.Controls.Add(Me.time1)
        Me.Panel2.Controls.Add(Me.aClock)
        Me.Panel2.Controls.Add(Me.txtDetails)
        Me.Panel2.Controls.Add(Me.imgDetails)
        Me.Panel2.Location = New System.Drawing.Point(12, 151)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(560, 144)
        Me.Panel2.TabIndex = 11
        '
        'time4
        '
        Me.time4.AutoSize = False
        Me.time4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.time4.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time4.ForeColor = System.Drawing.Color.White
        Me.time4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.time4.Location = New System.Drawing.Point(291, 65)
        Me.time4.Name = "time4"
        Me.time4.Size = New System.Drawing.Size(149, 62)
        Me.time4.StateCommon.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time4.StateCommon.TextColor = System.Drawing.Color.White
        Me.time4.Text = "12:00"
        '
        'time3
        '
        Me.time3.AutoSize = False
        Me.time3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.time3.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time3.ForeColor = System.Drawing.Color.White
        Me.time3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.time3.Location = New System.Drawing.Point(142, 65)
        Me.time3.Name = "time3"
        Me.time3.Size = New System.Drawing.Size(149, 62)
        Me.time3.StateCommon.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time3.StateCommon.TextColor = System.Drawing.Color.White
        Me.time3.Text = "12:00"
        '
        'time2
        '
        Me.time2.AutoSize = False
        Me.time2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.time2.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time2.ForeColor = System.Drawing.Color.White
        Me.time2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.time2.Location = New System.Drawing.Point(291, 3)
        Me.time2.Name = "time2"
        Me.time2.Size = New System.Drawing.Size(149, 62)
        Me.time2.StateCommon.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time2.StateCommon.TextColor = System.Drawing.Color.White
        Me.time2.Text = "12:00"
        '
        'time1
        '
        Me.time1.AutoSize = False
        Me.time1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.time1.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time1.ForeColor = System.Drawing.Color.White
        Me.time1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.time1.Location = New System.Drawing.Point(142, 3)
        Me.time1.Name = "time1"
        Me.time1.Size = New System.Drawing.Size(149, 62)
        Me.time1.StateCommon.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time1.StateCommon.TextColor = System.Drawing.Color.White
        Me.time1.Text = "12:00"
        '
        'aClock
        '
        Me.aClock.DrawDropShadow = False
        Me.aClock.DrawHourHand = True
        Me.aClock.DrawHourHandShadow = True
        Me.aClock.DrawMinuteHand = True
        Me.aClock.DrawMinuteHandShadow = True
        Me.aClock.DrawSecondHand = False
        Me.aClock.DropShadowColor = System.Drawing.Color.Black
        Me.aClock.DropShadowOffset = New System.Drawing.Point(0, 0)
        Me.aClock.FaceColorHigh = System.Drawing.Color.RoyalBlue
        Me.aClock.FaceColorLow = System.Drawing.Color.SkyBlue
        Me.aClock.FaceGradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.aClock.FaceImage = Nothing
        Me.aClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aClock.HourHandColor = System.Drawing.Color.Gainsboro
        Me.aClock.HourHandDropShadowColor = System.Drawing.Color.Gray
        Me.aClock.Location = New System.Drawing.Point(-5, -5)
        Me.aClock.MinuteHandColor = System.Drawing.Color.WhiteSmoke
        Me.aClock.MinuteHandDropShadowColor = System.Drawing.Color.Gray
        Me.aClock.MinuteHandTickStyle = AC.StdControls.Toolkit.Common.TickStyle.Smooth
        Me.aClock.Name = "aClock"
        Me.aClock.NumeralColor = System.Drawing.Color.WhiteSmoke
        Me.aClock.RimColorHigh = System.Drawing.Color.RoyalBlue
        Me.aClock.RimColorLow = System.Drawing.Color.SkyBlue
        Me.aClock.RimGradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.aClock.SecondHandColor = System.Drawing.Color.Tomato
        Me.aClock.SecondHandDropShadowColor = System.Drawing.Color.Gray
        Me.aClock.SecondHandEndCap = System.Drawing.Drawing2D.LineCap.Flat
        Me.aClock.SecondHandTickStyle = AC.StdControls.Toolkit.Common.TickStyle.Normal
        Me.aClock.Size = New System.Drawing.Size(149, 149)
        Me.aClock.TabIndex = 18
        Me.aClock.Time = New Date(CType(0, Long))
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
        'txtTime
        '
        Me.txtTime.AutoSize = True
        Me.txtTime.Location = New System.Drawing.Point(517, 69)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(39, 13)
        Me.txtTime.TabIndex = 17
        Me.txtTime.Text = "Label1"
        Me.txtTime.Visible = False
        '
        'pbTime
        '
        Me.pbTime.Location = New System.Drawing.Point(520, 85)
        Me.pbTime.Name = "pbTime"
        Me.pbTime.Size = New System.Drawing.Size(60, 60)
        Me.pbTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTime.TabIndex = 16
        Me.pbTime.TabStop = False
        Me.pbTime.Visible = False
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
        Me.txtWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txtWelcome.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.txtWelcome.Location = New System.Drawing.Point(122, 93)
        Me.txtWelcome.Name = "txtWelcome"
        Me.txtWelcome.Size = New System.Drawing.Size(458, 55)
        Me.txtWelcome.Text = "Hello NULL please answer the time questions"
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
        'imgTime
        '
        Me.imgTime.ImageStream = CType(resources.GetObject("imgTime.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgTime.TransparentColor = System.Drawing.Color.Transparent
        Me.imgTime.Images.SetKeyName(0, "0.jpg")
        Me.imgTime.Images.SetKeyName(1, "1.jpg")
        Me.imgTime.Images.SetKeyName(2, "2.jpg")
        Me.imgTime.Images.SetKeyName(3, "3.jpg")
        Me.imgTime.Images.SetKeyName(4, "4.jpg")
        Me.imgTime.Images.SetKeyName(5, "5.jpg")
        Me.imgTime.Images.SetKeyName(6, "6.jpg")
        Me.imgTime.Images.SetKeyName(7, "7.jpg")
        Me.imgTime.Images.SetKeyName(8, "8.jpg")
        Me.imgTime.Images.SetKeyName(9, "9.jpg")
        Me.imgTime.Images.SetKeyName(10, "10.jpg")
        Me.imgTime.Images.SetKeyName(11, "11.jpg")
        Me.imgTime.Images.SetKeyName(12, "12.jpg")
        Me.imgTime.Images.SetKeyName(13, "13.jpg")
        Me.imgTime.Images.SetKeyName(14, "14.jpg")
        Me.imgTime.Images.SetKeyName(15, "15.jpg")
        Me.imgTime.Images.SetKeyName(16, "16.jpg")
        Me.imgTime.Images.SetKeyName(17, "17.jpg")
        Me.imgTime.Images.SetKeyName(18, "18.jpg")
        Me.imgTime.Images.SetKeyName(19, "19.jpg")
        Me.imgTime.Images.SetKeyName(20, "20.jpg")
        Me.imgTime.Images.SetKeyName(21, "21.jpg")
        Me.imgTime.Images.SetKeyName(22, "22.jpg")
        Me.imgTime.Images.SetKeyName(23, "23.jpg")
        Me.imgTime.Images.SetKeyName(24, "24.jpg")
        Me.imgTime.Images.SetKeyName(25, "25.jpg")
        Me.imgTime.Images.SetKeyName(26, "26.jpg")
        Me.imgTime.Images.SetKeyName(27, "27.jpg")
        Me.imgTime.Images.SetKeyName(28, "28.jpg")
        Me.imgTime.Images.SetKeyName(29, "29.jpg")
        Me.imgTime.Images.SetKeyName(30, "30.jpg")
        Me.imgTime.Images.SetKeyName(31, "31.jpg")
        Me.imgTime.Images.SetKeyName(32, "32.jpg")
        Me.imgTime.Images.SetKeyName(33, "33.jpg")
        Me.imgTime.Images.SetKeyName(34, "34.jpg")
        Me.imgTime.Images.SetKeyName(35, "35.jpg")
        Me.imgTime.Images.SetKeyName(36, "36.jpg")
        Me.imgTime.Images.SetKeyName(37, "37.jpg")
        Me.imgTime.Images.SetKeyName(38, "38.jpg")
        Me.imgTime.Images.SetKeyName(39, "39.jpg")
        Me.imgTime.Images.SetKeyName(40, "40.jpg")
        Me.imgTime.Images.SetKeyName(41, "41.jpg")
        Me.imgTime.Images.SetKeyName(42, "42.jpg")
        Me.imgTime.Images.SetKeyName(43, "43.jpg")
        Me.imgTime.Images.SetKeyName(44, "44.jpg")
        Me.imgTime.Images.SetKeyName(45, "45.jpg")
        Me.imgTime.Images.SetKeyName(46, "46.jpg")
        Me.imgTime.Images.SetKeyName(47, "47.jpg")
        '
        'frmTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 397)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maths123"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.imgDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTime, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents imgTime As System.Windows.Forms.ImageList
    Friend WithEvents pbTime As System.Windows.Forms.PictureBox
    Friend WithEvents txtTime As System.Windows.Forms.Label
    Friend WithEvents aClock As AC.StdControls.Toolkit.Common.AnalogClock
    Friend WithEvents time4 As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
    Friend WithEvents time3 As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
    Friend WithEvents time2 As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
    Friend WithEvents time1 As ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
End Class

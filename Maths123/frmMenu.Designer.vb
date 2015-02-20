<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnMoney = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.s = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.txtWelcome = New ComponentFactory.Krypton.Toolkit.KryptonWrapLabel
        Me.btnLogout = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnTime = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnOrdering = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnDivision = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnMultiplication = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.btnAddition = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.imgLogo = New System.Windows.Forms.PictureBox
        Me.btnSubtraction = New ComponentFactory.Krypton.Toolkit.KryptonButton
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Maths123.My.Resources.Resources.wavy_background
        Me.Panel1.Controls.Add(Me.btnMoney)
        Me.Panel1.Controls.Add(Me.s)
        Me.Panel1.Controls.Add(Me.txtWelcome)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnTime)
        Me.Panel1.Controls.Add(Me.btnOrdering)
        Me.Panel1.Controls.Add(Me.btnDivision)
        Me.Panel1.Controls.Add(Me.btnMultiplication)
        Me.Panel1.Controls.Add(Me.btnAddition)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.imgLogo)
        Me.Panel1.Controls.Add(Me.btnSubtraction)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 397)
        Me.Panel1.TabIndex = 0
        '
        'btnMoney
        '
        Me.btnMoney.AutoSize = True
        Me.btnMoney.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMoney.Location = New System.Drawing.Point(202, 151)
        Me.btnMoney.Name = "btnMoney"
        Me.btnMoney.Size = New System.Drawing.Size(181, 76)
        Me.btnMoney.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnMoney.StateCommon.Border.Rounding = 50
        Me.btnMoney.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoney.TabIndex = 9
        Me.btnMoney.Values.Text = "Money"
        '
        's
        '
        Me.s.AutoSize = True
        Me.s.Cursor = System.Windows.Forms.Cursors.Hand
        Me.s.Location = New System.Drawing.Point(201, 315)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(181, 76)
        Me.s.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.s.StateCommon.Border.Rounding = 50
        Me.s.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s.TabIndex = 0
        Me.s.TabStop = False
        Me.s.Values.Text = "Exit"
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
        Me.txtWelcome.Text = "Welcome NULL please select your topic for today" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnLogout
        '
        Me.btnLogout.AutoSize = True
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Location = New System.Drawing.Point(202, 233)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(181, 76)
        Me.btnLogout.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnLogout.StateCommon.Border.Rounding = 50
        Me.btnLogout.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Values.Text = "Logout"
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
        '
        'btnOrdering
        '
        Me.btnOrdering.AutoSize = True
        Me.btnOrdering.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrdering.Location = New System.Drawing.Point(0, 233)
        Me.btnOrdering.Name = "btnOrdering"
        Me.btnOrdering.Size = New System.Drawing.Size(196, 76)
        Me.btnOrdering.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnOrdering.StateCommon.Border.Rounding = 50
        Me.btnOrdering.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdering.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnOrdering.TabIndex = 6
        Me.btnOrdering.Values.Text = "Ordering"
        '
        'btnDivision
        '
        Me.btnDivision.AutoSize = True
        Me.btnDivision.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDivision.Location = New System.Drawing.Point(0, 151)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(196, 76)
        Me.btnDivision.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnDivision.StateCommon.Border.Rounding = 50
        Me.btnDivision.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near
        Me.btnDivision.TabIndex = 5
        Me.btnDivision.Values.Text = "Division"
        '
        'btnMultiplication
        '
        Me.btnMultiplication.AutoSize = True
        Me.btnMultiplication.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMultiplication.Location = New System.Drawing.Point(388, 315)
        Me.btnMultiplication.Name = "btnMultiplication"
        Me.btnMultiplication.Size = New System.Drawing.Size(197, 76)
        Me.btnMultiplication.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnMultiplication.StateCommon.Border.Rounding = 50
        Me.btnMultiplication.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplication.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnMultiplication.TabIndex = 4
        Me.btnMultiplication.Values.Text = "Multiplication"
        '
        'btnAddition
        '
        Me.btnAddition.AutoSize = True
        Me.btnAddition.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddition.Location = New System.Drawing.Point(389, 151)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(196, 76)
        Me.btnAddition.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnAddition.StateCommon.Border.Rounding = 50
        Me.btnAddition.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddition.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnAddition.TabIndex = 2
        Me.btnAddition.Values.Text = "Addition"
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
        'btnSubtraction
        '
        Me.btnSubtraction.AutoSize = True
        Me.btnSubtraction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubtraction.Location = New System.Drawing.Point(389, 233)
        Me.btnSubtraction.Name = "btnSubtraction"
        Me.btnSubtraction.Size = New System.Drawing.Size(196, 76)
        Me.btnSubtraction.StateCommon.Border.DrawBorders = CType(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.btnSubtraction.StateCommon.Border.Rounding = 50
        Me.btnSubtraction.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtraction.StateCommon.Content.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.btnSubtraction.TabIndex = 3
        Me.btnSubtraction.Values.Text = "Subtraction"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 397)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maths123"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents btnSubtraction As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnAddition As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnOrdering As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnDivision As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMultiplication As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnLogout As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnTime As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents s As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnMoney As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class

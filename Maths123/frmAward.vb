Imports System.Drawing.Printing
Imports System.Net
Imports System.Net.Sockets
Imports System.IO

Public Class frmAward
    Private Declare Auto Function BitBlt Lib "gdi32.dll" (ByVal _
    hdcDest As IntPtr, ByVal nXDest As Integer, ByVal _
    nYDest As Integer, ByVal nWidth As Integer, ByVal _
    nHeight As Integer, ByVal hdcSrc As IntPtr, ByVal nXSrc _
    As Integer, ByVal nYSrc As Integer, ByVal dwRop As  _
    System.Int32) As Boolean
    Private Const SRCCOPY As Integer = &HCC0020
    Private m_PrintBitmap As Bitmap
    Private WithEvents m_PrintDocument As PrintDocument
    Private HPHack = False

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        General.ClearResults()
        General.Topic = Nothing
        General.MenuAction(Me, frmMenu)
    End Sub

    Private Sub frmAward_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtName.Text = General.Name
        txtScore.Text = General.Correct & " out of " & General.Answered + 1
        txtTopic.Text = "in " + General.Topic
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        btnPrint.Visible = False
        btnMenu.Visible = False
        m_PrintBitmap = GetFormImage()
        btnPrint.Visible = True
        btnMenu.Visible = True
        ' Make a PrintDocument and print.
        m_PrintDocument = New PrintDocument
        Dim printerName As String = m_PrintDocument.PrinterSettings.PrinterName.ToString
        Dim query As String = String.Format("SELECT * from Win32_Printer WHERE Name LIKE '%{0}'", printerName)
        Dim searcher As New System.Management.ManagementObjectSearcher(query)
        Dim coll As System.Management.ManagementObjectCollection = searcher.[Get]()
        Dim ipAdd As System.Net.IPAddress
        For Each printer As System.Management.ManagementObject In coll
            Dim portName As String = printer("PortName").ToString()
            If portName.StartsWith("IP_") And HPHack = True Then
                'MessageBox.Show(String.Format("Printer IP Address: {0}", portName.Substring(3)))
                ipAdd = IPAddress.Parse(portName.Substring(3))
                HPDisplay(ipAdd, "Printing Award for " + General.Name)
                m_PrintDocument.DocumentName = "Printing Award for " + General.Name
                m_PrintDocument.Print()
                HPDisplayClear(ipAdd, "End of Printing for " + General.Name)
            ElseIf Char.IsDigit(portName(0)) And HPHack = True Then
                'MessageBox.Show(String.Format("Printer IP Address: {0}", portName))
                ipAdd = IPAddress.Parse(portName)
                HPDisplay(ipAdd, "Printing Award for " + General.Name)
                m_PrintDocument.DocumentName = "Printing Award for " + General.Name
                m_PrintDocument.Print()
                HPDisplayClear(ipAdd, "End of Printing for " + General.Name)
            Else
                m_PrintDocument.DocumentName = "Printing Award for " + General.Name
                m_PrintDocument.Print()
            End If
        Next
    End Sub

    Private Function GetFormImage() As Bitmap
        ' Get this form's Graphics object.
        Dim me_gr As Graphics = Me.CreateGraphics

        ' Make a Bitmap to hold the image.
        Dim bm As New Bitmap(Me.ClientSize.Width, _
            Me.ClientSize.Height, me_gr)
        Dim bm_gr As Graphics = Graphics.FromImage(bm)
        Dim bm_hdc As IntPtr = bm_gr.GetHdc

        ' Get the form's hDC. We must do this after 
        ' creating the new Bitmap, which uses me_gr.
        Dim me_hdc As IntPtr = me_gr.GetHdc

        ' BitBlt the form's image onto the Bitmap.
        BitBlt(bm_hdc, 0, 0, Me.ClientSize.Width, _
            Me.ClientSize.Height, _
            me_hdc, 0, 0, SRCCOPY)
        me_gr.ReleaseHdc(me_hdc)
        bm_gr.ReleaseHdc(bm_hdc)

        ' Return the result.
        Return bm
    End Function


    Private Sub m_PrintDocument_PrintPage(ByVal sender As _
    Object, ByVal e As  _
    System.Drawing.Printing.PrintPageEventArgs) Handles _
    m_PrintDocument.PrintPage
        ' Draw the image centered.
        Dim x As Integer = e.MarginBounds.X + _
            (e.MarginBounds.Width - m_PrintBitmap.Width) \ 2
        Dim y As Integer = e.MarginBounds.Y + _
            (e.MarginBounds.Height - m_PrintBitmap.Height) \ 2
        e.Graphics.DrawImage(m_PrintBitmap, x, y)

        ' There's only one page.
        e.HasMorePages = False
    End Sub


    Private Sub HPDisplay(ByRef RHost As IPAddress, ByRef Message As String)
        Try
            Dim wSock As New TcpClient
            'Set wSock = CreateObject("mswinsock.winsock") ' create the winsock socket
            wSock.Connect(RHost, "9100") '"149.160.31.105"
            Dim stream As NetworkStream = wSock.GetStream
            Dim data As Byte() = System.Text.Encoding.ASCII.GetBytes(Chr(27) & "%-12345X@PJL JOB NAME = " & Chr(34) & Message & Chr(34) & vbCrLf & _
                                                                     "@PJL JOB DISPLAY = " & Chr(34) & Message & Chr(34) & vbCrLf & _
                                                                     "@PJL RDYMSG DISPLAY = " & Chr(34) & Message & Chr(34) & vbCrLf)
            Dim data2 As Byte() = System.Text.Encoding.ASCII.GetBytes((Chr(27) & "!%-12345X" & vbCrLf))
            stream.Write(data, 0, data.Length)
            stream.Write(data2, 0, data2.Length)
            wSock.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub HPDisplayClear(ByRef RHost As IPAddress, ByRef Message As String)
        Try
            Dim wSock As New TcpClient
            'Set wSock = CreateObject("mswinsock.winsock") ' create the winsock socket
            wSock.Connect(RHost, "9100") '"149.160.31.105"
            Dim stream As NetworkStream = wSock.GetStream
            Dim data As Byte() = System.Text.Encoding.ASCII.GetBytes(Chr(27) & "%-12345X@PJL COMMENT Restore READY message" & vbCrLf & _
                                                                     "@PJL RDYMSG DISPLAY = " & Chr(34) & "" & Chr(34) & vbCrLf & _
                                                                     "@PJL EOF Name = " & Chr(34) & Message & Chr(34) & vbCrLf)
            Dim data2 As Byte() = System.Text.Encoding.ASCII.GetBytes((Chr(27) & "!%-12345X" & vbCrLf))
            stream.Write(data, 0, data.Length)
            stream.Write(data2, 0, data2.Length)
            wSock.Close()
        Catch ex As Exception

        End Try

    End Sub

End Class

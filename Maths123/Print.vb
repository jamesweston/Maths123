Imports System.Drawing.Printing

Module Print
    Private Declare Auto Function BitBlt Lib "gdi32.dll" (ByVal _
    hdcDest As IntPtr, ByVal nXDest As Integer, ByVal _
    nYDest As Integer, ByVal nWidth As Integer, ByVal _
    nHeight As Integer, ByVal hdcSrc As IntPtr, ByVal nXSrc _
    As Integer, ByVal nYSrc As Integer, ByVal dwRop As  _
    System.Int32) As Boolean
    Private Const SRCCOPY As Integer = &HCC0020

    ' Variables used to print.

    Public Function GetFormImage(ByVal PrintForm As Form) As Bitmap
        ' Get this form's Graphics object.
        Dim me_gr As Graphics = PrintForm.CreateGraphics

        ' Make a Bitmap to hold the image.
        Dim bm As New Bitmap(PrintForm.ClientSize.Width, PrintForm.ClientSize.Height, me_gr)
        Dim bm_gr As Graphics = Graphics.FromImage(bm)
        Dim bm_hdc As IntPtr = bm_gr.GetHdc

        ' Get the form's hDC. We must do this after 
        ' creating the new Bitmap, which uses me_gr.
        Dim me_hdc As IntPtr = me_gr.GetHdc

        ' BitBlt the form's image onto the Bitmap.
        BitBlt(bm_hdc, 0, 0, PrintForm.ClientSize.Width, _
           PrintForm.ClientSize.Height, _
            me_hdc, 0, 0, SRCCOPY)
        me_gr.ReleaseHdc(me_hdc)
        bm_gr.ReleaseHdc(bm_hdc)

        ' Return the result.
        Return bm
    End Function

End Module

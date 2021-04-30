Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim min As String = Hou.Text.Trim
        'Dim days As Double
        'days = CDbl(min) / 24 / 60
        'Me.Days.Text = Format(days, "0.00")
        Dim Inval As String = TextBox1.Text
        If Inval.Length = 0 Then
            MsgBox("请输入要转换的值")
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MsgBox("请选择要转换的内容")
            Exit Sub
        End If
        Select Case ComboBox1.Text
            Case "秒"
                Sec.Text = Inval
                Min.Text = Format(CDbl(Inval) / 60, "0.000")
                Hou.Text = Format(CDbl(Inval) / 60 / 60, "0.000")
                Days.Text = Format(CDbl(Inval) / 60 / 60 / 24, "0.000")

            Case "分"
                Sec.Text = Format(CDbl(Inval) * 60, "0.000")
                Min.Text = Inval
                Hou.Text = Format(CDbl(Inval) / 60, "0.000")
                Days.Text = Format(CDbl(Inval) / 60 / 24, "0.000")

            Case "时"
                Sec.Text = Format(CDbl(Inval) * 60 * 60, "0.000")
                Min.Text = Format(CDbl(Inval) * 60, "0.000")
                Hou.Text = Inval
                Days.Text = Format(CDbl(Inval) /  24, "0.000")
            Case "天"
                Hou.Text = Format(CDbl(Inval) * 24, "0.000")
                Min.Text = Format(CDbl(Inval) * 60 * 60, "0.000")
                Sec.Text = Format(CDbl(Inval) * 60 * 60 * 24, "0.000")
                Days.Text = Inval
        End Select




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Text = ""
        Days.Text = ""
        Hou.Text = ""
        Min.Text = ""
        Sec.Text = ""
        TextBox1.Text = ""
    End Sub
End Class


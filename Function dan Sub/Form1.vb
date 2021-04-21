Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Papar()
    End Sub

    Private Sub Papar()
        lbl1.Text = "Quotes"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim strText As String
        strText = txtbox1.Text
        lbl2.Text = strText
        Quotes(strQuotes:=txtbox1.Text)
    End Sub

    Private Sub Quotes(ByVal strQuotes As String)
        Dim strInsert As String
    End Sub

    Function paparNama()
        lbl3.Text = "Quotes By"
    End Function

    Private Function btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        paparNama()
    End Function

    Function Quotesby(ByVal strQuotesby As String)
        Dim strInsert2 As String
    End Function

    Private Function btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Dim strText2 As String
        strText2 = txtbox2.Text
        lbl4.Text = strText2
        Quotesby(strQuotesby:=txtbox2.Text)
    End Function


End Class

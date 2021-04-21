Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Papar()
    End Sub

    Private Sub Papar()
        lbl1.Text = "Quotes"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim strText As String = txtbox1.Text
        Quotes(strText)
        lbl2.Text = strText
    End Sub

    Private Sub Quotes(ByRef strQuotes As String)
        strQuotes = "Hello " & strQuotes
    End Sub

    Function paparNama()
        lbl3.Text = "Quotes By"
        Return paparNama
    End Function

    Private Function btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        paparNama()
    End Function

    Function Quotesby(ByVal strQuotesby As String)
        Dim strInsert2 As String
        strInsert2 = txtbox2.Text
        lbl4.Text = strInsert2
        Return Quotesby
    End Function

    Private Function btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Quotesby(txtbox2.Text)
    End Function
End Class

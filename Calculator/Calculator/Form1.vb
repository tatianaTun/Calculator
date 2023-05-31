Public Class Form1


    '''''''   VARIABLES   '''''''

    Dim storage As Double = 0 'Double here so can store numbers with decimal
    Dim arithOperator As String = ""
    Dim result As Double


    '''''''   FUNCTIONS   '''''''

    Sub Calculate()  ' we create a function(subroutine) 
        If arithOperator = "+" Then
            result = storage + Convert.ToDouble(RichTextBox1.Text)
        ElseIf arithOperator = "-" Then
            result = storage - Convert.ToDouble(RichTextBox1.Text)
        ElseIf arithOperator = "*" Then
            result = storage * Convert.ToDouble(RichTextBox1.Text)
        ElseIf arithOperator = "/" Then
            result = storage / Convert.ToDouble(RichTextBox1.Text)
        Else
            result = storage 'QUESTION - Not sure about this part, should I keep it?
        End If
        arithOperator = "="
        RichTextBox1.Text = result.ToString()
        storage = result
    End Sub


    '''''''   NUMBERS BUTTONS   '''''''

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If RichTextBox1.Text = "0" Then
            RichTextBox1.Text = "0"
        ElseIf RichTextBox1.Text = Convert.ToString(result) Then
            RichTextBox1.Text = "0"
        ElseIf Not RichTextBox1.Text = "0" And Not arithOperator = "" Then
            RichTextBox1.Text += "0"
        Else
            RichTextBox1.Text += "0"
        End If
        RichTextBox2.Text += "0"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If RichTextBox1.Text = "0" Then
            RichTextBox1.Text = "1"
        ElseIf RichTextBox1.Text = Convert.ToString(result) Then
            RichTextBox1.Text = "1"
        ElseIf Not RichTextBox1.Text = "0" And Not arithOperator = "" Then
            RichTextBox1.Text += "1"
        Else
            RichTextBox1.Text += "1" 'Do I need this part?
        End If
        RichTextBox2.Text += "1"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If RichTextBox1.Text = "0" Then
            RichTextBox1.Text = "2"
        ElseIf RichTextBox1.Text = Convert.ToString(result) Then
            RichTextBox1.Text = "2"
        ElseIf Not RichTextBox1.Text = "0" And Not arithOperator = "" Then
            RichTextBox1.Text += "2"
        Else
            RichTextBox1.Text += "2"
        End If
        RichTextBox2.Text += "2"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If RichTextBox1.Text = "0" Then
            RichTextBox1.Text = "3"
        ElseIf RichTextBox1.Text = Convert.ToString(result) Then
            RichTextBox1.Text = "3"
        ElseIf Not RichTextBox1.Text = "0" And Not arithOperator = "" Then
            RichTextBox1.Text += "3"
        Else
            RichTextBox1.Text += "3"
        End If
        RichTextBox2.Text += "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If RichTextBox1.Text = "0" Then
            RichTextBox1.Text = "4"
        ElseIf RichTextBox1.Text = Convert.ToString(result) Then
            RichTextBox1.Text = "4"
        ElseIf Not RichTextBox1.Text = "0" And Not arithOperator = "" Then
            RichTextBox1.Text += "4"
        Else
            RichTextBox1.Text += "4"
        End If
        RichTextBox2.Text += "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If RichTextBox1.Text = "0" Then
            RichTextBox1.Text = "5"
        ElseIf RichTextBox1.Text = Convert.ToString(result) Then
            RichTextBox1.Text = "5"
        ElseIf Not RichTextBox1.Text = "0" And Not arithOperator = "" Then
            RichTextBox1.Text += "5"
        Else
            RichTextBox1.Text += "5"
        End If
        RichTextBox2.Text += "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If RichTextBox1.Text = "0" Then
            RichTextBox1.Text = "6"
        ElseIf RichTextBox1.Text = Convert.ToString(result) Then
            RichTextBox1.Text = "6"
        ElseIf Not RichTextBox1.Text = "0" And Not arithOperator = "" Then
            RichTextBox1.Text += "6"
        Else
            RichTextBox1.Text += "6"
        End If
        RichTextBox2.Text += "6"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RichTextBox1.Text = "0" Then
            RichTextBox1.Text = "7"
        ElseIf RichTextBox1.Text = Convert.ToString(result) Then
            RichTextBox1.Text = "7"
        ElseIf Not RichTextBox1.Text = "0" And Not arithOperator = "" Then
            RichTextBox1.Text += "7"
        Else
            RichTextBox1.Text += "7"
        End If
        RichTextBox2.Text += "7"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RichTextBox1.Text = "0" Then
            RichTextBox1.Text = "8"
        ElseIf RichTextBox1.Text = Convert.ToString(result) Then
            RichTextBox1.Text = "8"
        ElseIf Not RichTextBox1.Text = "0" And Not arithOperator = "" Then
            RichTextBox1.Text += "8"
        Else
            RichTextBox1.Text += "8"
        End If
        RichTextBox2.Text += "8"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RichTextBox1.Text = "0" Then
            RichTextBox1.Text = "9"
        ElseIf RichTextBox1.Text = Convert.ToString(result) Then
            RichTextBox1.Text = "9"
        ElseIf Not RichTextBox1.Text = "0" And Not arithOperator = "" Then
            RichTextBox1.Text += "9"
        Else
            RichTextBox1.Text += "9"
        End If
        RichTextBox2.Text += "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Not RichTextBox1.Text.Contains(".") Then
            RichTextBox1.Text += "."
            RichTextBox2.Text += "."
        End If

    End Sub


    '''''''   OPERATIONS BUTTONS   '''''''

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        RichTextBox1.Clear()
        RichTextBox2.Clear()
        storage = 0
        arithOperator = ""

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If RichTextBox1.Text <> "" Then
            RichTextBox1.Text = RichTextBox1.Text.Substring(0, RichTextBox1.TextLength - 1)
            RichTextBox2.Text = RichTextBox2.Text.Substring(0, RichTextBox2.TextLength - 1)
        End If
        'Another way for demonstration
        'Dim textLength As Integer = RichTextBox1.TextLength - 1
        'Dim textboxText As String = RichTextBox1.Text
        'RichTextBox1.Text = textboxText.Substring(0, textLength)
    End Sub

    Private Sub Addtion_Click(sender As Object, e As EventArgs) Handles Addtion.Click
        If arithOperator <> "" Then
            Calculate()
        Else
            storage = Convert.ToDouble(RichTextBox1.Text)
            RichTextBox1.Clear()
        End If
        arithOperator = "+"
        RichTextBox2.Text += "+"
    End Sub

    Private Sub Substraction_Click(sender As Object, e As EventArgs) Handles Substraction.Click
        If arithOperator <> "" Then
            Calculate()
        Else
            storage = Convert.ToDouble(RichTextBox1.Text)
            RichTextBox1.Clear()
        End If
        arithOperator = "-"
        RichTextBox2.Text += "-"
    End Sub

    Private Sub Multiplication_Click(sender As Object, e As EventArgs) Handles Multiplication.Click
        If arithOperator <> "" Then
            Calculate()
        Else
            storage = Convert.ToDouble(RichTextBox1.Text)
            RichTextBox1.Clear()
        End If
        arithOperator = "*"
        RichTextBox2.Text += "*"
    End Sub

    Private Sub Division_Click(sender As Object, e As EventArgs) Handles Division.Click
        If arithOperator <> "" Then
            Calculate()
        Else
            storage = Convert.ToDouble(RichTextBox1.Text)
            RichTextBox1.Clear()
        End If
        arithOperator = "/"
        RichTextBox2.Text += "/"
    End Sub

    Private Sub Equal_Click(sender As Object, e As EventArgs) Handles Equal.Click
        Calculate() 'calls for the function I created at the top
    End Sub
End Class

Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim firstNumber As Double = Double.Parse(txtFirstNumber.Text)
        Dim secondNumber As Double = Double.Parse(txtSecondNumber.Text)
        txtResult.Text = (firstNumber + secondNumber).ToString()
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        Dim firstNumber As Double = Double.Parse(txtFirstNumber.Text)
        Dim secondNumber As Double = Double.Parse(txtSecondNumber.Text)
        txtResult.Text = (firstNumber - secondNumber).ToString()
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Dim firstNumber As Double = Double.Parse(txtFirstNumber.Text)
        Dim secondNumber As Double = Double.Parse(txtSecondNumber.Text)
        txtResult.Text = (firstNumber * secondNumber).ToString()
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Dim firstNumber As Double = Double.Parse(txtFirstNumber.Text)
        Dim secondNumber As Double = Double.Parse(txtSecondNumber.Text)
        If secondNumber <> 0 Then
            txtResult.Text = (firstNumber / secondNumber).ToString()
        Else
            MessageBox.Show("Cannot divide by zero")
        End If
    End Sub

    Private Sub btnExponentiate_Click(sender As Object, e As EventArgs) Handles btnExponentiate.Click
        Dim baseNumber As Double = Double.Parse(txtFirstNumber.Text)
        Dim exponent As Double = Double.Parse(txtSecondNumber.Text)
        txtResult.Text = (Math.Pow(baseNumber, exponent)).ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstNumber.Clear()
        txtSecondNumber.Clear()
        txtResult.Clear()
    End Sub
End Class

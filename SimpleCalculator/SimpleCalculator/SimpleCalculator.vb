Public Class SimpleCalculatorForm

    Private Sub addButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click

        Dim value1 As Integer
        Dim value2 As Integer
        Dim result As Integer

        value1 = Val(firstNumberTextBox.Text)
        value2 = Val(secondNumberTextBox.Text)
        result = value1 + value2

        resultLabel.Text = result
    End Sub

    Private Sub subtractButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subtractButton.Click

        Dim value1 As Integer
        Dim value2 As Integer
        Dim result As Integer

        value1 = Val(firstNumberTextBox.Text)
        value2 = Val(secondNumberTextBox.Text)
        result = value1 - value2

        resultLabel.Text = result
    End Sub

    Private Sub multiplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiplyButton.Click

        Dim value1 As Integer
        Dim value2 As Integer
        Dim result As Integer

        value1 = Val(firstNumberTextBox.Text)
        value2 = Val(secondNumberTextBox.Text)
        result = value1 * value2

        resultLabel.Text = result
    End Sub

    Private Sub divideButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divideButton.Click

        Dim value1 As Integer
        Dim value2 As Integer
        Dim result As Integer

        value1 = Val(firstNumberTextBox.Text)
        value2 = Val(secondNumberTextBox.Text)
        result = value1 / value2

        resultLabel.Text = result
    End Sub
End Class ' SimpleCalculatorForm
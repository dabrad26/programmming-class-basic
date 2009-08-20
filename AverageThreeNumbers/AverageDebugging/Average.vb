Public Class AverageForm
   ' handles Click event
   Private Sub calculateButton_Click(ByVal sender As  _
      System.Object, ByVal e As System.EventArgs) _
      Handles calculateButton.Click

      ' variables to store user input
      Dim number1 As Integer
      Dim number2 As Integer
      Dim number3 As Integer
      Dim average As Integer

      ' obtain user inputs
      number1 = Val(firstNumberTextBox.Text)
      number2 = Val(secondNumberTextBox.Text)
      number3 = Val(thirdNumberTextBox.Text)

      ' average numbers
        average = (number1 + number2 + number3) / 3

        ' display result
        resultLabel.Text = average
    End Sub
End Class

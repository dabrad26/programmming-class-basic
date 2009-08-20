Public Class InventoryForm

   Private Sub calculateButton_Click(ByVal sender As  _
      System.Object, ByVal e As System.EventArgs) _
      Handles calculateButton.Click

        'Declare Variables
        Dim cartons As Integer
        Dim items As Integer
        Dim result As Integer

        'Retrieve Numbers from TextBox
        cartons = Val(cartonsTextBox.Text)
        items = Val(itemsTextBox.Text)

        'Multiply the Two Numbers
        result = cartons * items

        'Display the Results in the Label
        totalResultLabel.Text = result

   End Sub ' calculateButton_Click

    Private Sub cartonsTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cartonsTextBox.TextChanged

        'Clear Output Label
        totalResultLabel.Text = ""

    End Sub

    Private Sub itemsTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemsTextBox.TextChanged

        'Clear Output Label
        totalResultLabel.Text = ""

    End Sub
End Class ' InventoryForm

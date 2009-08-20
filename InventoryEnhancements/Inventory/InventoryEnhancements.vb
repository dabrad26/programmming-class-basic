Public Class InventoryForm

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click

        ' Multiply values input and display result in Label
        totalResultLabel.Text = _
         (Val(cartonsTextBox.Text) * Val(itemsTextBox.Text) * Val(shipmentsTextBox.Text))

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shipmentsTextBox.TextChanged

    End Sub

End Class

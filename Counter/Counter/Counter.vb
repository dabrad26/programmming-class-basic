Public Class CounterForm

    Private Sub countButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countButton.Click
        ' Count how many clicks

        Dim sales As Integer
        Dim bonus As Integer

        sales = 5000

        If sales > 10000 Then
            bonus = 250
        ElseIf sales > 5000 Then
            bonus = 100
        End If

        countTotalLabel.Text = (bonus)

    End Sub
End Class

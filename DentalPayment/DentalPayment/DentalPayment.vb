Public Class DentalPaymentForm

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click

        'Clear Text displayed in label
        totalResultLabel.Text = ""

        'If no name is entered, display error message
        If (nameTextBox.Text = "") OrElse _
        (cleanCheckBox.Checked = False AndAlso _
            xrayCheckBox.Checked = False AndAlso _
            CavityCheckBox.Checked = False AndAlso _
            flourideCheckBox.Checked = False AndAlso _
            rootCanalCheckBox.Checked = False AndAlso _
            otherCheckBox.Checked = False) Then

            'Display an error message in a dialog
            MessageBox.Show("Please enter a name and check at least one item", _
                            "Missing Information", MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
        Else


            'Total contains amount to bill payment
            Dim total As Decimal = 0

            'If patient had a cleaning
            If cleanCheckBox.Checked = True Then
                total += Val(cleanCostLabel.Text)
            End If

            'If patient had a cavity filled
            If CavityCheckBox.Checked = True Then
                total += Val(fillingCostLabel.Text)
            End If

            'If patient had an X-Ray Taken
            If xrayCheckBox.Checked = True Then
                total += Val(xrayCostLabel.Text)
            End If

            'If patient had Flouride
            If flourideCheckBox.Checked = True Then
                total += Val(flourideCostLabel.Text)
            End If

            'If patient had a Root Canal
            If rootCanalCheckBox.Checked = True Then
                total += Val(rootCanalCostLabel.Text)
            End If

            'If patient had Other Services
            If (otherCheckBox.Checked = True) AndAlso _
                (otherTextBox.Text = "") Then
                'Display an error message in a dialog
                MessageBox.Show("Please Enter Cost of Service", _
                                "No Cost Entered", MessageBoxButtons.OK, _
                                MessageBoxIcon.Error)
            ElseIf (otherCheckBox.Checked = True) Then
                total += Val(otherTextBox.Text)

            End If

            'Display the total
            totalResultLabel.Text = String.Format("{0:C}", total)
        End If

    End Sub
End Class
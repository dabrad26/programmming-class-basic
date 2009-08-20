Public Class WageCalculatorForm

    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click

        'Declaring Variables
        Dim hours As Double
        Dim wage As Decimal
        Dim earnings As Decimal

        'Declaring Constants
        Const HOUR_LIMIT As Integer = 40

        'Assign Values from User Input
        hours = Val(hoursTextBox.Text)
        wage = Val(wageTextBox.Text)

        'Determine Earnings
        'If hours is less than or equal to 40
        If hours <= HOUR_LIMIT Then
            earnings = hours * wage
        Else
            'If hours is over 40, get regular wage for first 40 hours
            earnings = HOUR_LIMIT * wage
            'Time and a Half for over 40
            earnings += (hours - HOUR_LIMIT) * (1.5 * wage)

        End If

        'Assign value to UI output
        earningsResultLabel.Text = String.Format("{0:C}", earnings)

    End Sub
End Class ' WageCalculatorForm
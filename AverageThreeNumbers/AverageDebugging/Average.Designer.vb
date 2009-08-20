<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AverageForm
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.firstNumberLabel = New System.Windows.Forms.Label
      Me.secondNumberLabel = New System.Windows.Forms.Label
      Me.thirdNumberLabel = New System.Windows.Forms.Label
      Me.averageLabel = New System.Windows.Forms.Label
      Me.resultLabel = New System.Windows.Forms.Label
      Me.firstNumberTextBox = New System.Windows.Forms.TextBox
      Me.secondNumberTextBox = New System.Windows.Forms.TextBox
      Me.thirdNumberTextBox = New System.Windows.Forms.TextBox
      Me.calculateButton = New System.Windows.Forms.Button
      Me.SuspendLayout()
      '
      'firstNumberLabel
      '
      Me.firstNumberLabel.AutoSize = True
      Me.firstNumberLabel.Location = New System.Drawing.Point(12, 13)
      Me.firstNumberLabel.Name = "firstNumberLabel"
      Me.firstNumberLabel.Size = New System.Drawing.Size(105, 15)
      Me.firstNumberLabel.TabIndex = 0
      Me.firstNumberLabel.Text = "Enter first number:"
      '
      'secondNumberLabel
      '
      Me.secondNumberLabel.AutoSize = True
      Me.secondNumberLabel.Location = New System.Drawing.Point(12, 42)
      Me.secondNumberLabel.Name = "secondNumberLabel"
      Me.secondNumberLabel.Size = New System.Drawing.Size(123, 15)
      Me.secondNumberLabel.TabIndex = 1
      Me.secondNumberLabel.Text = "Enter second number:"
      '
      'thirdNumberLabel
      '
      Me.thirdNumberLabel.AutoSize = True
      Me.thirdNumberLabel.Location = New System.Drawing.Point(12, 71)
      Me.thirdNumberLabel.Name = "thirdNumberLabel"
      Me.thirdNumberLabel.Size = New System.Drawing.Size(110, 15)
      Me.thirdNumberLabel.TabIndex = 2
      Me.thirdNumberLabel.Text = "Enter third number:"
      '
      'averageLabel
      '
      Me.averageLabel.AutoSize = True
      Me.averageLabel.Location = New System.Drawing.Point(12, 101)
      Me.averageLabel.Name = "averageLabel"
      Me.averageLabel.Size = New System.Drawing.Size(64, 15)
      Me.averageLabel.TabIndex = 3
      Me.averageLabel.Text = "Average is:"
      '
      'resultLabel
      '
      Me.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.resultLabel.Location = New System.Drawing.Point(141, 97)
      Me.resultLabel.Name = "resultLabel"
      Me.resultLabel.Size = New System.Drawing.Size(67, 23)
      Me.resultLabel.TabIndex = 4
      Me.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'firstNumberTextBox
      '
      Me.firstNumberTextBox.Location = New System.Drawing.Point(141, 10)
      Me.firstNumberTextBox.Name = "firstNumberTextBox"
      Me.firstNumberTextBox.Size = New System.Drawing.Size(67, 23)
      Me.firstNumberTextBox.TabIndex = 5
      Me.firstNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'secondNumberTextBox
      '
      Me.secondNumberTextBox.Location = New System.Drawing.Point(141, 39)
      Me.secondNumberTextBox.Name = "secondNumberTextBox"
      Me.secondNumberTextBox.Size = New System.Drawing.Size(67, 23)
      Me.secondNumberTextBox.TabIndex = 6
      Me.secondNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'thirdNumberTextBox
      '
      Me.thirdNumberTextBox.Location = New System.Drawing.Point(141, 68)
      Me.thirdNumberTextBox.Name = "thirdNumberTextBox"
      Me.thirdNumberTextBox.Size = New System.Drawing.Size(67, 23)
      Me.thirdNumberTextBox.TabIndex = 7
      Me.thirdNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'calculateButton
      '
      Me.calculateButton.Location = New System.Drawing.Point(228, 10)
      Me.calculateButton.Name = "calculateButton"
      Me.calculateButton.Size = New System.Drawing.Size(75, 23)
      Me.calculateButton.TabIndex = 8
      Me.calculateButton.Text = "Calculate"
      Me.calculateButton.UseVisualStyleBackColor = True
      '
      'AverageForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(319, 130)
      Me.Controls.Add(Me.calculateButton)
      Me.Controls.Add(Me.thirdNumberTextBox)
      Me.Controls.Add(Me.secondNumberTextBox)
      Me.Controls.Add(Me.firstNumberTextBox)
      Me.Controls.Add(Me.resultLabel)
      Me.Controls.Add(Me.averageLabel)
      Me.Controls.Add(Me.thirdNumberLabel)
      Me.Controls.Add(Me.secondNumberLabel)
      Me.Controls.Add(Me.firstNumberLabel)
      Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Name = "AverageForm"
      Me.Text = "Average Three Numbers"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents firstNumberLabel As System.Windows.Forms.Label
   Friend WithEvents secondNumberLabel As System.Windows.Forms.Label
   Friend WithEvents thirdNumberLabel As System.Windows.Forms.Label
   Friend WithEvents averageLabel As System.Windows.Forms.Label
   Friend WithEvents resultLabel As System.Windows.Forms.Label
   Friend WithEvents firstNumberTextBox As System.Windows.Forms.TextBox
   Friend WithEvents secondNumberTextBox As System.Windows.Forms.TextBox
   Friend WithEvents thirdNumberTextBox As System.Windows.Forms.TextBox
   Friend WithEvents calculateButton As System.Windows.Forms.Button

End Class

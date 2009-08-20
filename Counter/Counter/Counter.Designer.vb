<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CounterForm
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
        Me.countTotalLabel = New System.Windows.Forms.Label
        Me.countButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'countTotalLabel
        '
        Me.countTotalLabel.AutoSize = True
        Me.countTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.countTotalLabel.Location = New System.Drawing.Point(41, 18)
        Me.countTotalLabel.MaximumSize = New System.Drawing.Size(100, 25)
        Me.countTotalLabel.MinimumSize = New System.Drawing.Size(80, 25)
        Me.countTotalLabel.Name = "countTotalLabel"
        Me.countTotalLabel.Size = New System.Drawing.Size(80, 25)
        Me.countTotalLabel.TabIndex = 0
        Me.countTotalLabel.Text = "0"
        Me.countTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'countButton
        '
        Me.countButton.Location = New System.Drawing.Point(41, 69)
        Me.countButton.Name = "countButton"
        Me.countButton.Size = New System.Drawing.Size(80, 25)
        Me.countButton.TabIndex = 1
        Me.countButton.Text = "Count"
        Me.countButton.UseVisualStyleBackColor = True
        '
        'CounterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(160, 106)
        Me.Controls.Add(Me.countButton)
        Me.Controls.Add(Me.countTotalLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CounterForm"
        Me.Text = "Counter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents countTotalLabel As System.Windows.Forms.Label
    Friend WithEvents countButton As System.Windows.Forms.Button

End Class

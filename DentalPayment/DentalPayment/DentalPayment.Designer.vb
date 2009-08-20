<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DentalPaymentForm
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
        Me.titleLabel = New System.Windows.Forms.Label
        Me.nameLabel = New System.Windows.Forms.Label
        Me.nameTextBox = New System.Windows.Forms.TextBox
        Me.cleanCostLabel = New System.Windows.Forms.Label
        Me.fillingCostLabel = New System.Windows.Forms.Label
        Me.xrayCostLabel = New System.Windows.Forms.Label
        Me.totalResultLabel = New System.Windows.Forms.Label
        Me.totalLabel = New System.Windows.Forms.Label
        Me.calculateButton = New System.Windows.Forms.Button
        Me.cleanCheckBox = New System.Windows.Forms.CheckBox
        Me.CavityCheckBox = New System.Windows.Forms.CheckBox
        Me.xrayCheckBox = New System.Windows.Forms.CheckBox
        Me.rootCanalCheckBox = New System.Windows.Forms.CheckBox
        Me.flourideCheckBox = New System.Windows.Forms.CheckBox
        Me.rootCanalCostLabel = New System.Windows.Forms.Label
        Me.flourideCostLabel = New System.Windows.Forms.Label
        Me.otherCheckBox = New System.Windows.Forms.CheckBox
        Me.otherTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(19, 19)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(235, 28)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Dental Payment Form"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nameLabel
        '
        Me.nameLabel.Location = New System.Drawing.Point(19, 65)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(91, 21)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "Patient name:"
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(132, 65)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(117, 23)
        Me.nameTextBox.TabIndex = 2
        '
        'cleanCostLabel
        '
        Me.cleanCostLabel.Location = New System.Drawing.Point(211, 112)
        Me.cleanCostLabel.Name = "cleanCostLabel"
        Me.cleanCostLabel.Size = New System.Drawing.Size(38, 24)
        Me.cleanCostLabel.TabIndex = 3
        Me.cleanCostLabel.Text = "35"
        Me.cleanCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fillingCostLabel
        '
        Me.fillingCostLabel.Location = New System.Drawing.Point(211, 159)
        Me.fillingCostLabel.Name = "fillingCostLabel"
        Me.fillingCostLabel.Size = New System.Drawing.Size(38, 24)
        Me.fillingCostLabel.TabIndex = 4
        Me.fillingCostLabel.Text = "150"
        Me.fillingCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'xrayCostLabel
        '
        Me.xrayCostLabel.Location = New System.Drawing.Point(211, 206)
        Me.xrayCostLabel.Name = "xrayCostLabel"
        Me.xrayCostLabel.Size = New System.Drawing.Size(38, 24)
        Me.xrayCostLabel.TabIndex = 5
        Me.xrayCostLabel.Text = "85"
        Me.xrayCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'totalResultLabel
        '
        Me.totalResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalResultLabel.Location = New System.Drawing.Point(193, 404)
        Me.totalResultLabel.Name = "totalResultLabel"
        Me.totalResultLabel.Size = New System.Drawing.Size(56, 21)
        Me.totalResultLabel.TabIndex = 6
        Me.totalResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalLabel
        '
        Me.totalLabel.Location = New System.Drawing.Point(145, 404)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(41, 21)
        Me.totalLabel.TabIndex = 7
        Me.totalLabel.Text = "Total:"
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(180, 444)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(70, 24)
        Me.calculateButton.TabIndex = 8
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'cleanCheckBox
        '
        Me.cleanCheckBox.Location = New System.Drawing.Point(22, 113)
        Me.cleanCheckBox.Name = "cleanCheckBox"
        Me.cleanCheckBox.Size = New System.Drawing.Size(122, 24)
        Me.cleanCheckBox.TabIndex = 9
        Me.cleanCheckBox.Text = "Cleaning"
        Me.cleanCheckBox.UseVisualStyleBackColor = True
        '
        'CavityCheckBox
        '
        Me.CavityCheckBox.Location = New System.Drawing.Point(22, 160)
        Me.CavityCheckBox.Name = "CavityCheckBox"
        Me.CavityCheckBox.Size = New System.Drawing.Size(122, 24)
        Me.CavityCheckBox.TabIndex = 10
        Me.CavityCheckBox.Text = "Cavity Filling"
        Me.CavityCheckBox.UseVisualStyleBackColor = True
        '
        'xrayCheckBox
        '
        Me.xrayCheckBox.Location = New System.Drawing.Point(22, 207)
        Me.xrayCheckBox.Name = "xrayCheckBox"
        Me.xrayCheckBox.Size = New System.Drawing.Size(122, 24)
        Me.xrayCheckBox.TabIndex = 11
        Me.xrayCheckBox.Text = "X-Ray"
        Me.xrayCheckBox.UseVisualStyleBackColor = True
        '
        'rootCanalCheckBox
        '
        Me.rootCanalCheckBox.Location = New System.Drawing.Point(22, 299)
        Me.rootCanalCheckBox.Name = "rootCanalCheckBox"
        Me.rootCanalCheckBox.Size = New System.Drawing.Size(122, 24)
        Me.rootCanalCheckBox.TabIndex = 15
        Me.rootCanalCheckBox.Text = "Root Canal"
        Me.rootCanalCheckBox.UseVisualStyleBackColor = True
        '
        'flourideCheckBox
        '
        Me.flourideCheckBox.Location = New System.Drawing.Point(22, 252)
        Me.flourideCheckBox.Name = "flourideCheckBox"
        Me.flourideCheckBox.Size = New System.Drawing.Size(122, 24)
        Me.flourideCheckBox.TabIndex = 14
        Me.flourideCheckBox.Text = "Flouride"
        Me.flourideCheckBox.UseVisualStyleBackColor = True
        '
        'rootCanalCostLabel
        '
        Me.rootCanalCostLabel.Location = New System.Drawing.Point(211, 298)
        Me.rootCanalCostLabel.Name = "rootCanalCostLabel"
        Me.rootCanalCostLabel.Size = New System.Drawing.Size(38, 24)
        Me.rootCanalCostLabel.TabIndex = 13
        Me.rootCanalCostLabel.Text = "800"
        Me.rootCanalCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'flourideCostLabel
        '
        Me.flourideCostLabel.Location = New System.Drawing.Point(211, 251)
        Me.flourideCostLabel.Name = "flourideCostLabel"
        Me.flourideCostLabel.Size = New System.Drawing.Size(38, 24)
        Me.flourideCostLabel.TabIndex = 12
        Me.flourideCostLabel.Text = "50"
        Me.flourideCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'otherCheckBox
        '
        Me.otherCheckBox.Location = New System.Drawing.Point(22, 348)
        Me.otherCheckBox.Name = "otherCheckBox"
        Me.otherCheckBox.Size = New System.Drawing.Size(122, 24)
        Me.otherCheckBox.TabIndex = 17
        Me.otherCheckBox.Text = "Other"
        Me.otherCheckBox.UseVisualStyleBackColor = True
        '
        'otherTextBox
        '
        Me.otherTextBox.Location = New System.Drawing.Point(206, 351)
        Me.otherTextBox.Name = "otherTextBox"
        Me.otherTextBox.Size = New System.Drawing.Size(42, 23)
        Me.otherTextBox.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(170, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 24)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "$"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DentalPaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 485)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.otherTextBox)
        Me.Controls.Add(Me.otherCheckBox)
        Me.Controls.Add(Me.rootCanalCheckBox)
        Me.Controls.Add(Me.flourideCheckBox)
        Me.Controls.Add(Me.rootCanalCostLabel)
        Me.Controls.Add(Me.flourideCostLabel)
        Me.Controls.Add(Me.xrayCheckBox)
        Me.Controls.Add(Me.CavityCheckBox)
        Me.Controls.Add(Me.cleanCheckBox)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.totalResultLabel)
        Me.Controls.Add(Me.xrayCostLabel)
        Me.Controls.Add(Me.fillingCostLabel)
        Me.Controls.Add(Me.cleanCostLabel)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DentalPaymentForm"
        Me.Text = "Dental Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents titleLabel As System.Windows.Forms.Label
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cleanCostLabel As System.Windows.Forms.Label
    Friend WithEvents fillingCostLabel As System.Windows.Forms.Label
    Friend WithEvents xrayCostLabel As System.Windows.Forms.Label
    Friend WithEvents totalResultLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents cleanCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CavityCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents xrayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents rootCanalCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents flourideCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents rootCanalCostLabel As System.Windows.Forms.Label
    Friend WithEvents flourideCostLabel As System.Windows.Forms.Label
    Friend WithEvents otherCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents otherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class

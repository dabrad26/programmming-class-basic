﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryForm
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
        Me.cartonsLabel = New System.Windows.Forms.Label
        Me.itemsLabel = New System.Windows.Forms.Label
        Me.totalLabel = New System.Windows.Forms.Label
        Me.totalResultLabel = New System.Windows.Forms.Label
        Me.cartonsTextBox = New System.Windows.Forms.TextBox
        Me.itemsTextBox = New System.Windows.Forms.TextBox
        Me.calculateButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cartonsLabel
        '
        Me.cartonsLabel.AutoSize = True
        Me.cartonsLabel.Location = New System.Drawing.Point(9, 15)
        Me.cartonsLabel.Name = "cartonsLabel"
        Me.cartonsLabel.Size = New System.Drawing.Size(127, 15)
        Me.cartonsLabel.TabIndex = 0
        Me.cartonsLabel.Text = "Cartons per shipment: "
        Me.cartonsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'itemsLabel
        '
        Me.itemsLabel.AutoSize = True
        Me.itemsLabel.Location = New System.Drawing.Point(9, 46)
        Me.itemsLabel.Name = "itemsLabel"
        Me.itemsLabel.Size = New System.Drawing.Size(99, 15)
        Me.itemsLabel.TabIndex = 1
        Me.itemsLabel.Text = "Items per carton: "
        Me.itemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(190, 15)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(40, 15)
        Me.totalLabel.TabIndex = 2
        Me.totalLabel.Text = "Total: "
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'totalResultLabel
        '
        Me.totalResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalResultLabel.Location = New System.Drawing.Point(243, 11)
        Me.totalResultLabel.Name = "totalResultLabel"
        Me.totalResultLabel.Size = New System.Drawing.Size(50, 23)
        Me.totalResultLabel.TabIndex = 3
        Me.totalResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cartonsTextBox
        '
        Me.cartonsTextBox.Location = New System.Drawing.Point(136, 12)
        Me.cartonsTextBox.Name = "cartonsTextBox"
        Me.cartonsTextBox.Size = New System.Drawing.Size(40, 23)
        Me.cartonsTextBox.TabIndex = 4
        Me.cartonsTextBox.Text = "0"
        Me.cartonsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'itemsTextBox
        '
        Me.itemsTextBox.Location = New System.Drawing.Point(136, 43)
        Me.itemsTextBox.Name = "itemsTextBox"
        Me.itemsTextBox.Size = New System.Drawing.Size(40, 23)
        Me.itemsTextBox.TabIndex = 5
        Me.itemsTextBox.Text = "0"
        Me.itemsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(193, 42)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(100, 24)
        Me.calculateButton.TabIndex = 6
        Me.calculateButton.Text = "Calculate Total"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'InventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 74)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.itemsTextBox)
        Me.Controls.Add(Me.cartonsTextBox)
        Me.Controls.Add(Me.totalResultLabel)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.itemsLabel)
        Me.Controls.Add(Me.cartonsLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "InventoryForm"
        Me.Text = "Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cartonsLabel As System.Windows.Forms.Label
    Friend WithEvents itemsLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents totalResultLabel As System.Windows.Forms.Label
    Friend WithEvents cartonsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents itemsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button

End Class

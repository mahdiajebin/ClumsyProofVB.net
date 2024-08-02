<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderSummary
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OrderTotal = New System.Windows.Forms.Label()
        Me.EstimatedTaxToBeCollected = New System.Windows.Forms.Label()
        Me.TotalBeforeTax = New System.Windows.Forms.Label()
        Me.FreeShipping = New System.Windows.Forms.Label()
        Me.ShippingHandaling = New System.Windows.Forms.Label()
        Me.Items = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.14815!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.85185!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 677.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(547, 677)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 0, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 667)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(2, 280)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(268, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Order total:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 228)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(268, 37)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Estimated tax to be Collected:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 183)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label6.Size = New System.Drawing.Size(268, 37)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Total before tax:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 134)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(268, 37)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Free Shipping:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 89)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(268, 37)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Shipping && handling:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 45)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(268, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Items:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(268, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Order Summary"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.OrderTotal)
        Me.Panel2.Controls.Add(Me.EstimatedTaxToBeCollected)
        Me.Panel2.Controls.Add(Me.TotalBeforeTax)
        Me.Panel2.Controls.Add(Me.FreeShipping)
        Me.Panel2.Controls.Add(Me.ShippingHandaling)
        Me.Panel2.Controls.Add(Me.Items)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(372, 5)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(171, 361)
        Me.Panel2.TabIndex = 4
        '
        'OrderTotal
        '
        Me.OrderTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrderTotal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OrderTotal.Location = New System.Drawing.Point(37, 280)
        Me.OrderTotal.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.OrderTotal.Name = "OrderTotal"
        Me.OrderTotal.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.OrderTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OrderTotal.Size = New System.Drawing.Size(126, 57)
        Me.OrderTotal.TabIndex = 2
        Me.OrderTotal.Text = "$00"
        '
        'EstimatedTaxToBeCollected
        '
        Me.EstimatedTaxToBeCollected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstimatedTaxToBeCollected.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EstimatedTaxToBeCollected.Location = New System.Drawing.Point(7, 228)
        Me.EstimatedTaxToBeCollected.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.EstimatedTaxToBeCollected.Name = "EstimatedTaxToBeCollected"
        Me.EstimatedTaxToBeCollected.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.EstimatedTaxToBeCollected.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EstimatedTaxToBeCollected.Size = New System.Drawing.Size(160, 37)
        Me.EstimatedTaxToBeCollected.TabIndex = 2
        Me.EstimatedTaxToBeCollected.Text = "$0.00"
        '
        'TotalBeforeTax
        '
        Me.TotalBeforeTax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalBeforeTax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalBeforeTax.Location = New System.Drawing.Point(7, 183)
        Me.TotalBeforeTax.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.TotalBeforeTax.Name = "TotalBeforeTax"
        Me.TotalBeforeTax.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.TotalBeforeTax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TotalBeforeTax.Size = New System.Drawing.Size(164, 37)
        Me.TotalBeforeTax.TabIndex = 2
        Me.TotalBeforeTax.Text = "$00"
        '
        'FreeShipping
        '
        Me.FreeShipping.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FreeShipping.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FreeShipping.Location = New System.Drawing.Point(7, 134)
        Me.FreeShipping.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.FreeShipping.Name = "FreeShipping"
        Me.FreeShipping.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FreeShipping.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FreeShipping.Size = New System.Drawing.Size(164, 37)
        Me.FreeShipping.TabIndex = 2
        Me.FreeShipping.Text = "$00"
        '
        'ShippingHandaling
        '
        Me.ShippingHandaling.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShippingHandaling.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShippingHandaling.Location = New System.Drawing.Point(7, 89)
        Me.ShippingHandaling.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.ShippingHandaling.Name = "ShippingHandaling"
        Me.ShippingHandaling.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.ShippingHandaling.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShippingHandaling.Size = New System.Drawing.Size(156, 37)
        Me.ShippingHandaling.TabIndex = 2
        Me.ShippingHandaling.Text = "$00"
        '
        'Items
        '
        Me.Items.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Items.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Items.Location = New System.Drawing.Point(7, 45)
        Me.Items.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Items.Name = "Items"
        Me.Items.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Items.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Items.Size = New System.Drawing.Size(164, 37)
        Me.Items.TabIndex = 2
        Me.Items.Text = "$00"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(2, 2)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label14.Size = New System.Drawing.Size(124, 37)
        Me.Label14.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 198.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(-4, 371)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(547, 48)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'Button
        '
        Me.Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button.FlatAppearance.BorderSize = 0
        Me.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button.ForeColor = System.Drawing.Color.White
        Me.Button.Location = New System.Drawing.Point(174, 0)
        Me.Button.Margin = New System.Windows.Forms.Padding(0)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(198, 48)
        Me.Button.TabIndex = 0
        Me.Button.Text = "Place Your Order"
        Me.Button.UseVisualStyleBackColor = False
        '
        'OrderSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "OrderSummary"
        Me.Size = New System.Drawing.Size(547, 677)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents OrderTotal As Label
    Friend WithEvents EstimatedTaxToBeCollected As Label
    Friend WithEvents TotalBeforeTax As Label
    Friend WithEvents FreeShipping As Label
    Friend WithEvents ShippingHandaling As Label
    Friend WithEvents Items As Label
    Friend WithEvents Label14 As Label
    '  Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    '  Friend WithEvents LineShape3 As PowerPacks.LineShape
    '   Friend WithEvents LineShape4 As PowerPacks.LineShape
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    '   Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    '   Friend WithEvents LineShape2 As PowerPacks.LineShape
    '   Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button As Button
End Class

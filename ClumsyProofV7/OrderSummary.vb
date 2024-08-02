Public Class OrderSummary
    Private _Total As Decimal = 0.00
    Public Property Total() As Decimal
        Get
            Return _Total
        End Get
        Set(ByVal value As Decimal)
            _Total += value
            Items.Text = "$" & _Total
            ShippingHandaling.Text = "$10.00"
            'free Shipping
            If _Total >= 30 Then
                FreeShipping.Text = "-$10.00"
                TotalBeforeTax.Text = "$" & _Total
                Dim tax As Decimal = _Total * 0.08
                EstimatedTaxToBeCollected.Text = "$" & tax
                OrderTotal.Text = "$" & CDec((_Total * 0.08) + _Total)
            Else
                FreeShipping.Text = "$0.00"
                TotalBeforeTax.Text = "$" & _Total + 10
                Dim tax As Decimal = (_Total + 10) * 0.08
                EstimatedTaxToBeCollected.Text = "$" & tax
                OrderTotal.Text = "$" & CDec((_Total + 10) * 0.08 + (_Total + 10))
            End If
        End Set
    End Property


    Public Event PlaceYourOrder_Click()
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        RaiseEvent PlaceYourOrder_Click()
    End Sub

End Class

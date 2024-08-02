
Public Class ProductDashboard
    Dim con As MyDBConnection = New MyDBConnection()

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CustomerName.Text = "Welcome, " + UserInformation.Name
        Me.CenterToScreen()
    End Sub

    'top menu bar 


    Public Event ClickOnCart(ByVal CartItem As Integer)

    Private _UserName As String = ""
    Public Property UserName() As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            Try
                ' Label2.Text = value.Substring(0, 1)
                If value.Length > 5 Then
                    CustomerName.Text = value.Remove(4) + "..."
                Else
                    CustomerName.Text = value
                End If
            Catch ex As Exception

            End Try

            _UserName = value
        End Set
    End Property
    Private _CartItem As Integer = 0
    Public Property CartItem() As Integer
        Get
            Return _CartItem
        End Get
        Set(ByVal value As Integer)
            If value > 9 Then
                If value > 99 Then
                    numberofItems.Text = "99"
                    numberofItems.ForeColor = Color.Red
                Else
                    numberofItems.Text = value
                End If
                numberofItems.Location = New System.Drawing.Point(numberofItems.Location.X - 2, 15)
            Else
                numberofItems.Text = value
                numberofItems.Location = New System.Drawing.Point(numberofItems.Location.X, 15)
            End If
            _CartItem = value
        End Set
    End Property

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, numberofItems.Click
        RaiseEvent ClickOnCart(CartItem())
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover, numberofItems.MouseHover
        PictureBox2.BorderStyle = BorderStyle.Fixed3D

    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave, numberofItems.MouseLeave
        '    OvalShape1.BringToFront()
        PictureBox1.BorderStyle = BorderStyle.None

    End Sub





    'End of top panel














    'GridView 

    Public Sub AddItems(ByVal Items() As ItemLayout)
        'Console.WriteLine(Items.Length)
        Dim height As Integer = -Items(0).Height + 50

        Dim colum = 0
        Me.SuspendLayout()
        FlowLayoutPanel1.Controls.Clear()


        For Each Item As ItemLayout In Items

            height += Items(0).Height
            '  Item.Margin.Left = 10
            FlowLayoutPanel1.Controls.Add(Item)

        Next
        Me.Refresh()
        Me.ResumeLayout(False)
    End Sub






    'Items 




    '-----------------------------------------------------------------------------]
    'Product 

    Dim Result As DataTable
    Dim items() As ItemLayout



    Private Sub LoadingItems(ByVal Type As String)

        ' MessageBox.Show(Type)

        Result = con.GetProduct(Type)
        items = New ItemLayout(Result.Rows.Count) {}
        'Console.WriteLine(Result.Rows.Count)
        If Result.Rows.Count > 0 Then
            For Each Row As DataRow In Result.Rows
                Dim img() As Byte = Row("Image")
                Dim ms As New System.IO.MemoryStream(img)
                Dim Item = New ItemLayout With {
                    .SelectImage = Image.FromStream(ms),
                    .Price = "$" + Row("Price").ToString,
                    .Title = Row("Name").ToString,
                    .Description = Row("Description").ToString,
                    .ItemId = Row("Id")
                }
                AddHandler Item.AddtoCart_Click, AddressOf AddtoCart
                items(Result.Rows.IndexOf(Row)) = Item
            Next
            Me.AddItems(items)

            Me.Show()
        Else
            Me.Show()
        End If


    End Sub

    Private Sub AddtoCart(ByVal ItemID As Integer)
        If con.AdItemToCart(UserInformation.UserID, ItemID) Then
            UserInformation.CartItems = con.CartItem(UserInformation.UserID)
            Me.CartItem = UserInformation.CartItems
            MessageBox.Show("Item Added to Cart")
        Else
            MessageBox.Show("Item Already in Cart")
        End If
    End Sub

    Private Sub Product_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.UserName = UserInformation.Name
        Me.CartItem = UserInformation.CartItems
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub NavBar1_CartClick(CartItem As Integer) Handles Me.ClickOnCart
        If UserInformation.CartItems >= 1 Then
            OrderPage.ShowOrder(Me)
            Me.Hide()
        Else
            MessageBox.Show("Add Some Item to The Shopping Cart")
        End If
    End Sub



    Public Sub Iphone()
        LoadingItems("Iphone")
    End Sub

    Public Sub Cake()
        LoadingItems("Android")
    End Sub

    Public Sub Coffee()
        LoadingItems("Tablet")
    End Sub

    Private Sub Product_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UserInformation.CartItems = con.CartItem(UserInformation.UserID)
        Me.CartItem = UserInformation.CartItems
        'Console.WriteLine("Activated")
    End Sub

    Private Sub btnIphone_Click(sender As Object, e As EventArgs) Handles btnIphone.Click
        LoadingItems("Iphone")
    End Sub

    Private Sub btnAndroid_Click(sender As Object, e As EventArgs) Handles btnAndroid.Click
        LoadingItems("Android")
    End Sub

    Private Sub btnTablets_Click(sender As Object, e As EventArgs) Handles btnTablets.Click
        LoadingItems("Tablet")
    End Sub

    'Inserrt image to the database code 

    '    Insert Into PRODUCT(Id, Name, Price, Description, Image, Type)



    'Select Case'40', N'RIFLE PAPER CO.', N'20.99', N'Keep it fresh with genuine flowers!  Delicately dried flowers with eye-catching metallic elements are encased in clear resin to give this case a truly elegant twist. ', BulkColumn , N'Tablet'

    'from Openrowset(Bulk 'C:\Users\mahdi\source\repos\ClumsyProofV7\ClumsyProofV7\Resources\t14.jpg', Single_Blob) as Image
















End Class
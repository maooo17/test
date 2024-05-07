Imports System.Drawing.Printing
Imports System.Globalization

Public Class Form2
    'is used to store an image representation of the DataGridView for the printing recipt

    Private bitmap As Bitmap



    ' Function to calculate the total cost of items
    Private Function Cost_of_item() As Double
        Dim sum As Double = 0
        Dim i As Integer = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            sum = sum + Convert.ToDouble(DataGridView1.Rows(i).Cells(2).Value)
        Next i
        Return sum
    End Function

    ' Subroutine to update the cost-related labels on the form
    Sub addcost()
        Dim tax, q As Double ' Variables for tax and subtotal
        tax = 3.9 ' Tax rate

        If DataGridView1.Rows.Count > 0 Then
            LabelTAX.Text = Cost_of_item().ToString("C2", CultureInfo.GetCultureInfo("en-PH"))
            ' Calculate and display the tax
            LabelSUBTOTAL.Text = Cost_of_item().ToString("C2", CultureInfo.GetCultureInfo("en-PH"))
            ' Display the subtotal
            q = ((Cost_of_item() * tax) / 100) ' Calculate the total including tax
            LabelTOTAL.Text = (q + Cost_of_item()).ToString("C2", CultureInfo.GetCultureInfo("en-PH"))
            ' Display the total including tax
            labelBarcode.Text = (q + Cost_of_item()).ToString("0.00")
            ' Display the total including tax (for barcode)
        End If
    End Sub

    ' Subroutine to calculate and display the change
    Sub CHANGE()
        Dim tax, q, c As Double ' Variables for tax, total, and cash payment
        tax = 3.9 ' Tax rate

        If DataGridView1.Rows.Count > 0 Then
            q = ((Cost_of_item() * tax) / 100) + Cost_of_item()
            ' Calculate the total including tax
            c = Val(labelCOST.Text) ' Get the cash payment
            LabelCHANGE.Text = (c - q).ToString("C2", CultureInfo.GetCultureInfo("en-PH"))
            ' Calculate and display the change
        End If
    End Sub

    ' Event handler for numeric buttons to input numbers
    Private Sub NumbersOnly(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click, Buttondot.Click, Button0.Click
        Dim b As Button = sender
        If (labelCOST.Text = "0") Then
            labelCOST.Text = ""
            labelCOST.Text = b.Text
        ElseIf (b.Text = ".") Then
            If (Not labelCOST.Text.Contains(".")) Then
                labelCOST.Text = labelCOST.Text + b.Text
            End If
        Else
            labelCOST.Text = labelCOST.Text + b.Text
        End If
    End Sub

    ' Event handler to clear the cost label and combo box selection
    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        labelCOST.Text = "0"
        CBOPAYMENT.Text = ""
        LabelCHANGE.Text = "0"
    End Sub

    ' Event handler to reset all fields and clear DataGridView
    Private Sub ButtonRest_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        LabelCHANGE.Text = ""
        labelCOST.Text = ""
        LabelSUBTOTAL.Text = "0"
        DataGridView1.Rows.Clear()
        DataGridView1.Refresh()
        CBOPAYMENT.Text = ""
    End Sub

    ' Event handler to initialize combo box items on form load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBOPAYMENT.Items.Add("CASH")
        CBOPAYMENT.Items.Add("GCASH/paypal")
        CBOPAYMENT.Items.Add("CREDITCARD/VISACARD")
        CBOPAYMENT.Items.Add("palawan")
        labelBarcode.Text = ""
    End Sub

    ' Event handler for the "PAY" button
    Private Sub ButtonPAY_Click(sender As Object, e As EventArgs) Handles ButtonPAY.Click
        If (CBOPAYMENT.Text = "CASH") Then
            ' Handle cash payment
            CHANGE()
        ElseIf (CBOPAYMENT.Text = "GCASH/paypal") Then
            ' Handle Palawan payment
            CHANGE()
        ElseIf (CBOPAYMENT.Text = "CREDITCARD/VISACARD") Then
            ' Handle Visa Card payment
            CHANGE() ' Call the CHANGE() function
        ElseIf (CBOPAYMENT.Text = "palawan") Then
            CHANGE()

        Else
            LabelCHANGE.Text = "0"
            labelCOST.Text = "0"
        End If
    End Sub

    ' Event handler to remove selected item from DataGridView
    Private Sub ButtonRemove_Click(sender As Object, e As EventArgs) Handles ButtonREMOVE.Click
        For Each Row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(Row)
        Next
        addcost()
        If (CBOPAYMENT.Text = "CASH") Then
            CHANGE()
        ElseIf (CBOPAYMENT.Text = "GCASH/paypal") Then
            CHANGE()
        ElseIf (CBOPAYMENT.Text = "CREDITCARD/VISACARD") Then
            ' Handle Visa Card payment
            CHANGE() ' Call the CHANGE() function
        ElseIf (CBOPAYMENT.Text = "palawan") Then
            CHANGE()
        Else
            LabelCHANGE.Text = "0"
            labelCOST.Text = "0"
        End If
    End Sub

    ' Event handler to print DataGridView contents
    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        Dim height As Integer = DataGridView1.Height

        DataGridView1.Height = (DataGridView1.RowCount + 1) * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = height

    End Sub



    ' Event handler to print DataGridView contents
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 10, 10)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles LOGOUTBUTTON.Click
        MsgBox("byebye")
        Form1.Show()
        Me.Hide()

    End Sub


    Private Sub updatebutton_Click(sender As Object, e As EventArgs)
        Form3.Show()


    End Sub

    Private Sub RemoveProductButton_Click(sender As Object, e As EventArgs, buttonToRemove As Button, updateButton As Button, decreaseButton As Button)
        ' Remove the product button and its associated buttons
        product.Controls.Remove(buttonToRemove)
        product.Controls.Remove(updateButton)
        product.Controls.Remove(decreaseButton)
        product.Controls.Remove(DirectCast(sender, Button))
        ' Remove the product button and its associated remove button
        product.Controls.Remove(buttonToRemove)
        product.Controls.Remove(DirectCast(sender, Button))
    End Sub

    Private Sub ADDBUTTON_Click(sender As Object, e As EventArgs) Handles ADDBUTTON.Click
        ' Retrieve product information from textboxes
        Dim productName As String = nameTextBox1.Text
        Dim productPrice As Decimal
        Dim productQuantity As Integer

        ' Attempt to parse price and quantity
        If Decimal.TryParse(PRICETextBox2.Text, productPrice) AndAlso Integer.TryParse(QuantityTextBox3.Text, productQuantity) Then
            ' Create a new button for the product
            Dim newButton As New Button()
            newButton.Text = $"{productName}{vbCrLf}Price: {productPrice:C}{vbCrLf}Quantity: {productQuantity}"
            newButton.Width = 200 ' Set the width of the button
            newButton.Height = 60 ' Set the height of the button
            ' Add a click event handler for the new button
            AddHandler newButton.Click, AddressOf ProductButton_Click

            ' Create a new update button for the product
            Dim updateButton As New Button()
            updateButton.Text = "Update"
            updateButton.Width = 80 ' Set the width of the update button
            updateButton.Height = 30 ' Set the height of the update button
            ' Add a click event handler for the update button
            AddHandler updateButton.Click, Sub(senderUpdate As Object, eUpdate As EventArgs) UpdateProductQuantity(senderUpdate, eUpdate, newButton)

            ' Create a new decrease button for the product
            Dim decreaseButton As New Button()
            decreaseButton.Text = "Decrease"
            decreaseButton.Width = 80 ' Set the width of the decrease button
            decreaseButton.Height = 30 ' Set the height of the decrease button
            ' Add a click event handler for the decrease button
            AddHandler decreaseButton.Click, Sub(senderDecrease As Object, eDecrease As EventArgs) DecreaseProductQuantity(senderDecrease, eDecrease, newButton)

            ' Create a new remove button for the product
            Dim removeButton As New Button()
            removeButton.Text = "Remove"
            removeButton.Width = 80 ' Set the width of the remove button
            removeButton.Height = 30 ' Set the height of the remove button
            ' Add a click event handler for the remove button
            AddHandler removeButton.Click, Sub(senderRemove As Object, eRemove As EventArgs) RemoveProductButton_Click(senderRemove, eRemove, newButton, updateButton, decreaseButton)

            ' Set the positions of the buttons horizontally
            updateButton.Left = newButton.Right + 5 ' Adjust the spacing between buttons
            decreaseButton.Left = updateButton.Right + 5 ' Adjust the spacing between buttons
            removeButton.Left = decreaseButton.Right + 5 ' Adjust the spacing between buttons

            ' Add the buttons to the layout panel's controls
            product.Controls.Add(newButton)
            product.Controls.Add(updateButton)
            product.Controls.Add(decreaseButton)
            product.Controls.Add(removeButton)
        Else
            ' Display an error message if price or quantity is not a valid number
            MessageBox.Show("Please enter valid numbers for price and quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Clear textboxes after displaying product information or error message
        nameTextBox1.Clear()
        PRICETextBox2.Clear()
        QuantityTextBox3.Clear()
    End Sub

    Private Sub ProductButton_Click(sender As Object, e As EventArgs)
        ' Handle click events for product buttons
        ' Add one quantity of the product to the DataGridView
        Dim clickedButton As Button = DirectCast(sender, Button)
        Dim productInfo As String() = clickedButton.Text.Split({vbCrLf}, StringSplitOptions.RemoveEmptyEntries)
        Dim productName As String = productInfo(0)
        Dim productPrice As Decimal = Decimal.Parse(productInfo(1).Substring(productInfo(1).IndexOf(":") + 1).Trim(), NumberStyles.Currency)

        ' Add one quantity of the product to the DataGridView
        DataGridView1.Rows.Add(productName, 1, productPrice)

        ' Update the product button text to reflect the new quantity
        Dim productQuantity As Integer = Integer.Parse(productInfo(2).Substring(productInfo(2).IndexOf(":") + 1).Trim())
        If productQuantity > 0 Then
            productQuantity -= 1
            clickedButton.Text = $"{productName}{vbCrLf}Price: {productPrice}{vbCrLf}Quantity: {productQuantity}"
        Else
            ' If the product is out of stock, disable the button
            clickedButton.Enabled = False
        End If

        ' Update the cost-related labels
        addcost()

        ' Update the subtotal label
        LabelSUBTOTAL.Text = Cost_of_item().ToString("C2", CultureInfo.GetCultureInfo("en-PH"))

        ' Update the tax label
        LabelTAX.Text = (Cost_of_item() * 0.039).ToString("C2", CultureInfo.GetCultureInfo("en-PH"))

        ' Update the total label
        LabelTOTAL.Text = (Cost_of_item() + (Cost_of_item() * 0.039)).ToString("C2", CultureInfo.GetCultureInfo("en-PH"))
    End Sub



    Private Sub UpdateProductQuantity(sender As Object, e As EventArgs, buttonToUpdate As Button)
        ' Update the quantity of the product
        Dim productInfo As String() = buttonToUpdate.Text.Split({vbCrLf}, StringSplitOptions.RemoveEmptyEntries)
        Dim productName As String = productInfo(0)
        Dim productPrice As Decimal = Decimal.Parse(productInfo(1).Substring(productInfo(1).IndexOf(":") + 1).Trim(), NumberStyles.Currency)
        Dim productQuantity As Integer = Integer.Parse(productInfo(2).Substring(productInfo(2).IndexOf(":") + 1).Trim())

        ' Increment the quantity by 1
        productQuantity += 1

        ' Update the button text to reflect the new quantity
        buttonToUpdate.Text = $"{productName}{vbCrLf}Price: {productPrice:C}{vbCrLf}Quantity: {productQuantity}"

        ' Enable the button if quantity is greater than 0
        If productQuantity > 0 Then
            buttonToUpdate.Enabled = True
        End If
    End Sub

    Private Sub DecreaseProductQuantity(sender As Object, e As EventArgs, buttonToDecrease As Button)
        ' Update the quantity of the product
        Dim productInfo As String() = buttonToDecrease.Text.Split({vbCrLf}, StringSplitOptions.RemoveEmptyEntries)
        Dim productName As String = productInfo(0)
        Dim productPrice As Decimal = Decimal.Parse(productInfo(1).Substring(productInfo(1).IndexOf(":") + 1).Trim(), NumberStyles.Currency)
        Dim productQuantity As Integer = Integer.Parse(productInfo(2).Substring(productInfo(2).IndexOf(":") + 1).Trim())

        ' Decrement the quantity by 1 if it's greater than 0
        If productQuantity > 0 Then
            productQuantity -= 1

            ' Update the button text to reflect the new quantity
            buttonToDecrease.Text = $"{productName}{vbCrLf}Price: {productPrice:C}{vbCrLf}Quantity: {productQuantity}"

            ' Enable the button if quantity is greater than 0
            buttonToDecrease.Enabled = True
        End If
    End Sub

End Class


Public Class Form3
    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click

        Form2.Show()
        Me.Hide()
        nameTextBox1.Clear()
        PRICETextBox2.Clear()
        QuantityTextBox3.Clear()

    End Sub

    Private Sub ADDButton_Click(sender As Object, e As EventArgs) Handles ADDBUTTON.Click


        nameTextBox1.Clear()
        PRICETextBox2.Clear()
        QuantityTextBox3.Clear()
    End Sub

End Class
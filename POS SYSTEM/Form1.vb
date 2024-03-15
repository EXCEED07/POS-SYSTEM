Public Class Form1
    Private Sub BurgerButton_Click(sender As Object, e As EventArgs) Handles BurgerButton.Click

        If TLCButton.Visible Or CheeseButton.Visible Or ChumpButton.Visible Or Quantity1.Visible Or Quantity2.Visible Or Quantity3.Visible Or TLCTextBox.Visible Or CheeseTextBox.Visible Or ChumpTextBox.Visible Then

            TLCButton.Visible = False
            CheeseButton.Visible = False
            ChumpButton.Visible = False
            Quantity1.Visible = False
            TLCTextBox.Visible = False
            Quantity2.Visible = False
            CheeseTextBox.Visible = False
            Quantity3.Visible = False
            ChumpTextBox.Visible = False

        Else
            TLCButton.Visible = True
            CheeseButton.Visible = True
            ChumpButton.Visible = True

        End If

    End Sub

    Private Sub TLCButton_Click(sender As Object, e As EventArgs) Handles TLCButton.Click
        If Quantity1.Visible Or TLCTextBox.Visible Then
            Quantity1.Visible = False
            TLCTextBox.Visible = False

        Else
            Quantity1.Visible = True
            TLCTextBox.Visible = True
        End If
    End Sub

    Private Sub CheeseButton_Click(sender As Object, e As EventArgs) Handles CheeseButton.Click
        If Quantity2.Visible Or CheeseTextBox.Visible Then
            Quantity2.Visible = False
            CheeseTextBox.Visible = False

        Else
            Quantity2.Visible = True
            CheeseTextBox.Visible = True
        End If
    End Sub

    Private Sub ChumpButton_Click(sender As Object, e As EventArgs) Handles ChumpButton.Click
        If Quantity3.Visible Or ChumpTextBox.Visible Then
            Quantity3.Visible = False
            ChumpTextBox.Visible = False

        Else
            Quantity3.Visible = True
            ChumpTextBox.Visible = True
        End If
    End Sub

    Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click
        TCLReceipt.Text = "TLC Burger -" & TLCTextBox.Text

    End Sub

    Private Sub CheeseReceipt_Click(sender As Object, e As EventArgs) Handles CheeseReceipt.Click

    End Sub

    Private Sub TCLReceipt_Click(sender As Object, e As EventArgs) Handles TCLReceipt.Click

    End Sub
End Class

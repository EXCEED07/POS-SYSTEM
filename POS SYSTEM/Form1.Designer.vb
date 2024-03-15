<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        BurgerButton = New Button()
        SButton = New Button()
        Fries = New Button()
        DrinkButton = New Button()
        TLCButton = New Button()
        CheeseButton = New Button()
        ChumpButton = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button14 = New Button()
        Button15 = New Button()
        Button16 = New Button()
        Button10 = New Button()
        Button11 = New Button()
        Button12 = New Button()
        TLCTextBox = New TextBox()
        Quantity1 = New Label()
        Quantity2 = New Label()
        CheeseTextBox = New TextBox()
        Quantity3 = New Label()
        ChumpTextBox = New TextBox()
        PictureBox1 = New PictureBox()
        TotalButton = New Button()
        TCLReceipt = New Label()
        CheeseReceipt = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Viner Hand ITC", 30F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(245, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(312, 65)
        Label1.TabIndex = 0
        Label1.Text = "BLUE CROWS"
        ' 
        ' BurgerButton
        ' 
        BurgerButton.BackColor = SystemColors.Window
        BurgerButton.FlatStyle = FlatStyle.Popup
        BurgerButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BurgerButton.Image = CType(resources.GetObject("BurgerButton.Image"), Image)
        BurgerButton.Location = New Point(12, 95)
        BurgerButton.Name = "BurgerButton"
        BurgerButton.Size = New Size(80, 79)
        BurgerButton.TabIndex = 1
        BurgerButton.Text = "Burger"
        BurgerButton.TextAlign = ContentAlignment.TopCenter
        BurgerButton.UseVisualStyleBackColor = False
        ' 
        ' SButton
        ' 
        SButton.Location = New Point(12, 220)
        SButton.Name = "SButton"
        SButton.Size = New Size(71, 48)
        SButton.TabIndex = 2
        SButton.Text = "Spaghetti"
        SButton.UseVisualStyleBackColor = True
        ' 
        ' Fries
        ' 
        Fries.Location = New Point(12, 353)
        Fries.Name = "Fries"
        Fries.Size = New Size(71, 48)
        Fries.TabIndex = 4
        Fries.Text = "Fries"
        Fries.UseVisualStyleBackColor = True
        ' 
        ' DrinkButton
        ' 
        DrinkButton.Location = New Point(12, 286)
        DrinkButton.Name = "DrinkButton"
        DrinkButton.Size = New Size(71, 48)
        DrinkButton.TabIndex = 3
        DrinkButton.Text = "Drinks"
        DrinkButton.UseVisualStyleBackColor = True
        ' 
        ' TLCButton
        ' 
        TLCButton.BackColor = SystemColors.Window
        TLCButton.BackgroundImageLayout = ImageLayout.Center
        TLCButton.FlatStyle = FlatStyle.Popup
        TLCButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TLCButton.ForeColor = SystemColors.WindowText
        TLCButton.Location = New Point(126, 95)
        TLCButton.Name = "TLCButton"
        TLCButton.Size = New Size(73, 50)
        TLCButton.TabIndex = 5
        TLCButton.Text = "TLC Burger"
        TLCButton.TextAlign = ContentAlignment.TopCenter
        TLCButton.UseVisualStyleBackColor = False
        TLCButton.Visible = False
        ' 
        ' CheeseButton
        ' 
        CheeseButton.BackColor = SystemColors.Window
        CheeseButton.BackgroundImageLayout = ImageLayout.None
        CheeseButton.FlatStyle = FlatStyle.Popup
        CheeseButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        CheeseButton.ImageAlign = ContentAlignment.BottomCenter
        CheeseButton.Location = New Point(220, 95)
        CheeseButton.Name = "CheeseButton"
        CheeseButton.Size = New Size(73, 50)
        CheeseButton.TabIndex = 6
        CheeseButton.Text = "Cheese Burger"
        CheeseButton.TextAlign = ContentAlignment.TopCenter
        CheeseButton.UseVisualStyleBackColor = False
        CheeseButton.Visible = False
        ' 
        ' ChumpButton
        ' 
        ChumpButton.BackColor = SystemColors.Window
        ChumpButton.FlatStyle = FlatStyle.Popup
        ChumpButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        ChumpButton.Location = New Point(314, 95)
        ChumpButton.Name = "ChumpButton"
        ChumpButton.Size = New Size(73, 49)
        ChumpButton.TabIndex = 7
        ChumpButton.Text = "Chump Burger"
        ChumpButton.TextAlign = ContentAlignment.TopCenter
        ChumpButton.UseVisualStyleBackColor = False
        ChumpButton.Visible = False
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(410, 220)
        Button5.Name = "Button5"
        Button5.Size = New Size(71, 48)
        Button5.TabIndex = 12
        Button5.Text = "Burger"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(316, 220)
        Button6.Name = "Button6"
        Button6.Size = New Size(71, 48)
        Button6.TabIndex = 11
        Button6.Text = "Burger"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(222, 220)
        Button7.Name = "Button7"
        Button7.Size = New Size(71, 48)
        Button7.TabIndex = 10
        Button7.Text = "Burger"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(128, 220)
        Button8.Name = "Button8"
        Button8.Size = New Size(71, 48)
        Button8.TabIndex = 9
        Button8.Text = "Burger"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(410, 286)
        Button9.Name = "Button9"
        Button9.Size = New Size(71, 26)
        Button9.TabIndex = 16
        Button9.Text = "Burger"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.Location = New Point(316, 353)
        Button14.Name = "Button14"
        Button14.Size = New Size(71, 48)
        Button14.TabIndex = 19
        Button14.Text = "Burger"
        Button14.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.Location = New Point(222, 353)
        Button15.Name = "Button15"
        Button15.Size = New Size(71, 48)
        Button15.TabIndex = 18
        Button15.Text = "Burger"
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button16
        ' 
        Button16.Location = New Point(128, 353)
        Button16.Name = "Button16"
        Button16.Size = New Size(71, 48)
        Button16.TabIndex = 17
        Button16.Text = "Burger"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(316, 286)
        Button10.Name = "Button10"
        Button10.Size = New Size(71, 26)
        Button10.TabIndex = 20
        Button10.Text = "Burger"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(222, 286)
        Button11.Name = "Button11"
        Button11.Size = New Size(71, 26)
        Button11.TabIndex = 21
        Button11.Text = "Burger"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Location = New Point(128, 286)
        Button12.Name = "Button12"
        Button12.Size = New Size(71, 26)
        Button12.TabIndex = 22
        Button12.Text = "Burger"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' TLCTextBox
        ' 
        TLCTextBox.Location = New Point(126, 174)
        TLCTextBox.Multiline = True
        TLCTextBox.Name = "TLCTextBox"
        TLCTextBox.Size = New Size(73, 21)
        TLCTextBox.TabIndex = 23
        TLCTextBox.Visible = False
        ' 
        ' Quantity1
        ' 
        Quantity1.AutoSize = True
        Quantity1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Quantity1.Location = New Point(126, 154)
        Quantity1.Name = "Quantity1"
        Quantity1.Size = New Size(61, 17)
        Quantity1.TabIndex = 24
        Quantity1.Text = "Quantity"
        Quantity1.Visible = False
        ' 
        ' Quantity2
        ' 
        Quantity2.AutoSize = True
        Quantity2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Quantity2.Location = New Point(222, 154)
        Quantity2.Name = "Quantity2"
        Quantity2.Size = New Size(61, 17)
        Quantity2.TabIndex = 26
        Quantity2.Text = "Quantity"
        Quantity2.Visible = False
        ' 
        ' CheeseTextBox
        ' 
        CheeseTextBox.Location = New Point(222, 174)
        CheeseTextBox.Multiline = True
        CheeseTextBox.Name = "CheeseTextBox"
        CheeseTextBox.Size = New Size(73, 21)
        CheeseTextBox.TabIndex = 25
        CheeseTextBox.Visible = False
        ' 
        ' Quantity3
        ' 
        Quantity3.AutoSize = True
        Quantity3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Quantity3.Location = New Point(314, 154)
        Quantity3.Name = "Quantity3"
        Quantity3.Size = New Size(61, 17)
        Quantity3.TabIndex = 28
        Quantity3.Text = "Quantity"
        Quantity3.Visible = False
        ' 
        ' ChumpTextBox
        ' 
        ChumpTextBox.Location = New Point(314, 174)
        ChumpTextBox.Multiline = True
        ChumpTextBox.Name = "ChumpTextBox"
        ChumpTextBox.Size = New Size(73, 21)
        ChumpTextBox.TabIndex = 27
        ChumpTextBox.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Window
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(785, 48)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(388, 550)
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' TotalButton
        ' 
        TotalButton.Location = New Point(17, 468)
        TotalButton.Name = "TotalButton"
        TotalButton.Size = New Size(75, 23)
        TotalButton.TabIndex = 30
        TotalButton.Text = "Total"
        TotalButton.UseVisualStyleBackColor = True
        ' 
        ' TCLReceipt
        ' 
        TCLReceipt.AutoSize = True
        TCLReceipt.BackColor = SystemColors.Window
        TCLReceipt.Location = New Point(809, 95)
        TCLReceipt.Name = "TCLReceipt"
        TCLReceipt.Size = New Size(13, 15)
        TCLReceipt.TabIndex = 31
        TCLReceipt.Text = "1"
        ' 
        ' CheeseReceipt
        ' 
        CheeseReceipt.AutoSize = True
        CheeseReceipt.BackColor = SystemColors.Window
        CheeseReceipt.Location = New Point(809, 95)
        CheeseReceipt.Name = "CheeseReceipt"
        CheeseReceipt.Size = New Size(13, 15)
        CheeseReceipt.TabIndex = 32
        CheeseReceipt.Text = "1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuHighlight
        ClientSize = New Size(1185, 610)
        Controls.Add(CheeseReceipt)
        Controls.Add(TCLReceipt)
        Controls.Add(TotalButton)
        Controls.Add(PictureBox1)
        Controls.Add(Quantity3)
        Controls.Add(ChumpTextBox)
        Controls.Add(Quantity2)
        Controls.Add(CheeseTextBox)
        Controls.Add(Quantity1)
        Controls.Add(TLCTextBox)
        Controls.Add(Button12)
        Controls.Add(Button11)
        Controls.Add(Button10)
        Controls.Add(Button14)
        Controls.Add(Button15)
        Controls.Add(Button16)
        Controls.Add(Button9)
        Controls.Add(Button5)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Button8)
        Controls.Add(ChumpButton)
        Controls.Add(CheeseButton)
        Controls.Add(TLCButton)
        Controls.Add(Fries)
        Controls.Add(DrinkButton)
        Controls.Add(SButton)
        Controls.Add(BurgerButton)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BurgerButton As Button
    Friend WithEvents SButton As Button
    Friend WithEvents Fries As Button
    Friend WithEvents DrinkButton As Button
    Friend WithEvents TLCButton As Button
    Friend WithEvents CheeseButton As Button
    Friend WithEvents ChumpButton As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents TLCTextBox As TextBox
    Friend WithEvents Quantity1 As Label
    Friend WithEvents Quantity2 As Label
    Friend WithEvents CheeseTextBox As TextBox
    Friend WithEvents Quantity3 As Label
    Friend WithEvents ChumpTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TotalButton As Button
    Friend WithEvents TCLReceipt As Label
    Friend WithEvents CheeseReceipt As Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Script MT Bold", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(126, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(166, 33)
        Label1.TabIndex = 0
        Label1.Text = "Room Details"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Script MT Bold", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(609, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(200, 33)
        Label2.TabIndex = 1
        Label2.Text = "Customer Details"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(14, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 24)
        Label3.TabIndex = 2
        Label3.Text = "RoomType"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(14, 195)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 24)
        Label4.TabIndex = 3
        Label4.Text = "AccessType"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(494, 136)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 24)
        Label5.TabIndex = 4
        Label5.Text = "Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(494, 195)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 24)
        Label6.TabIndex = 5
        Label6.Text = "ID"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(494, 249)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 24)
        Label7.TabIndex = 6
        Label7.Text = "Contact No"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(611, 136)
        TextBox1.Margin = New Padding(3, 4, 3, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(181, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(611, 184)
        TextBox2.Margin = New Padding(3, 4, 3, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(181, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(611, 239)
        TextBox3.Margin = New Padding(3, 4, 3, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(181, 27)
        TextBox3.TabIndex = 9
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Deluxe", "Super Deluxe"})
        ComboBox1.Location = New Point(137, 132)
        ComboBox1.Margin = New Padding(3, 4, 3, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(138, 28)
        ComboBox1.TabIndex = 10
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Restraunt Access", "Pool Access", "All Access"})
        ComboBox2.Location = New Point(137, 191)
        ComboBox2.Margin = New Padding(3, 4, 3, 4)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(138, 28)
        ComboBox2.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(374, 431)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 44)
        Button1.TabIndex = 12
        Button1.Text = "Check-In"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form3"
        Text = "CheckIn"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
End Class

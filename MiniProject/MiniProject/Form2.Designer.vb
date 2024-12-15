<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(14, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(212, 24)
        Label1.TabIndex = 0
        Label1.Text = "No of Rooms Available :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(233, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 24)
        Label2.TabIndex = 1
        Label2.Text = "10"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(14, 368)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 31)
        Button1.TabIndex = 6
        Button1.Text = "Check-In"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(398, 368)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 31)
        Button2.TabIndex = 7
        Button2.Text = "Check-Out"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(779, 368)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(97, 31)
        Button3.TabIndex = 8
        Button3.Text = "LogOut"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(15, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(206, 24)
        Label3.TabIndex = 2
        Label3.Text = "No of Rooms Occupied :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(233, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(20, 24)
        Label4.TabIndex = 3
        Label4.Text = "0"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(914, 404)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form2"
        Text = "MainPage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Script MT Bold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(252, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 25)
        Label1.TabIndex = 0
        Label1.Text = "SSR Group of Hotels"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(159, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 19)
        Label2.TabIndex = 1
        Label2.Text = "UserName"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(159, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 19)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(297, 122)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(138, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(297, 192)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(138, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(312, 250)
        Button1.Name = "Button1"
        Button1.Size = New Size(85, 29)
        Button1.TabIndex = 5
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(667, 336)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "LoginPage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
End Class

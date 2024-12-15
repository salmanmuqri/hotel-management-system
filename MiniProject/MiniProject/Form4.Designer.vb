<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        TextBoxID = New TextBox()
        TextBoxDays = New TextBox()
        ButtonPay = New Button()
        LabelCharge = New Label()
        ButtonCheckID = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(71, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(37, 24)
        Label1.TabIndex = 0
        Label1.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(71, 205)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 24)
        Label2.TabIndex = 1
        Label2.Text = "Days"
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Location = New Point(246, 105)
        TextBoxID.Margin = New Padding(3, 4, 3, 4)
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(114, 27)
        TextBoxID.TabIndex = 3
        ' 
        ' TextBoxDays
        ' 
        TextBoxDays.Location = New Point(246, 205)
        TextBoxDays.Margin = New Padding(3, 4, 3, 4)
        TextBoxDays.Name = "TextBoxDays"
        TextBoxDays.Size = New Size(114, 27)
        TextBoxDays.TabIndex = 4
        ' 
        ' ButtonPay
        ' 
        ButtonPay.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonPay.Location = New Point(376, 327)
        ButtonPay.Margin = New Padding(3, 4, 3, 4)
        ButtonPay.Name = "ButtonPay"
        ButtonPay.Size = New Size(86, 31)
        ButtonPay.TabIndex = 5
        ButtonPay.Text = "Pay"
        ButtonPay.UseVisualStyleBackColor = True
        ' 
        ' LabelCharge
        ' 
        LabelCharge.AutoSize = True
        LabelCharge.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LabelCharge.Location = New Point(148, 271)
        LabelCharge.Name = "LabelCharge"
        LabelCharge.Size = New Size(107, 24)
        LabelCharge.TabIndex = 6
        LabelCharge.Text = "Please Pay:"
        ' 
        ' ButtonCheckID
        ' 
        ButtonCheckID.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonCheckID.Location = New Point(421, 105)
        ButtonCheckID.Margin = New Padding(3, 4, 3, 4)
        ButtonCheckID.Name = "ButtonCheckID"
        ButtonCheckID.Size = New Size(116, 31)
        ButtonCheckID.TabIndex = 7
        ButtonCheckID.Text = "Check Id"
        ButtonCheckID.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Script MT Bold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(82, 327)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 8
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(570, 416)
        Controls.Add(Button1)
        Controls.Add(ButtonCheckID)
        Controls.Add(LabelCharge)
        Controls.Add(ButtonPay)
        Controls.Add(TextBoxDays)
        Controls.Add(TextBoxID)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form4"
        Text = "Payment"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxDays As TextBox
    Friend WithEvents ButtonPay As Button
    Friend WithEvents LabelCharge As Label
    Friend WithEvents ButtonCheckID As Button
    Friend WithEvents Button1 As Button
End Class

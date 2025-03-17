<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(333, 318)
        Button1.Name = "Button1"
        Button1.Size = New Size(182, 33)
        Button1.TabIndex = 11
        Button1.Text = "Save"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F)
        TextBox1.Location = New Point(184, 104)
        TextBox1.MaxLength = 8
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 29)
        TextBox1.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F)
        Label3.Location = New Point(49, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 25)
        Label3.TabIndex = 8
        Label3.Text = "Team ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.Location = New Point(54, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 25)
        Label2.TabIndex = 7
        Label2.Text = "Captain ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(309, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(238, 45)
        Label1.TabIndex = 6
        Label1.Text = "Create Captain "
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F)
        TextBox3.Location = New Point(545, 169)
        TextBox3.MaxLength = 8
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(182, 29)
        TextBox3.TabIndex = 15
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 12F)
        TextBox4.Location = New Point(545, 102)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(182, 29)
        TextBox4.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F)
        Label4.Location = New Point(410, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 25)
        Label4.TabIndex = 13
        Label4.Text = "Player ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F)
        Label5.Location = New Point(409, 104)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 25)
        Label5.TabIndex = 12
        Label5.Text = "Captain Name"
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 12F)
        TextBox5.Location = New Point(545, 234)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(182, 29)
        TextBox5.TabIndex = 19
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 12F)
        TextBox6.Location = New Point(184, 236)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(182, 29)
        TextBox6.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F)
        Label6.Location = New Point(410, 236)
        Label6.Name = "Label6"
        Label6.Size = New Size(106, 25)
        Label6.TabIndex = 17
        Label6.Text = "No of Wins"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14F)
        Label7.Location = New Point(17, 238)
        Label7.Name = "Label7"
        Label7.Size = New Size(166, 25)
        Label7.TabIndex = 16
        Label7.Text = "Years of Captaincy"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 12F)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(184, 172)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 29)
        ComboBox1.TabIndex = 20
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox6)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(TextBox3)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(Label5)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form8"
        Text = "Form8"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class

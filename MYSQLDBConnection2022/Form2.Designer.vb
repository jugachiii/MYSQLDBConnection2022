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
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button2 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(657, 398)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 40)
        Button1.TabIndex = 0
        Button1.Text = "Sign Out"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 14.25F)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(104, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 25)
        Label1.TabIndex = 1
        Label1.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 14.25F)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(32, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 25)
        Label2.TabIndex = 2
        Label2.Text = "First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 14.25F)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(34, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 25)
        Label3.TabIndex = 3
        Label3.Text = "Last Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 14.25F)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(89, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 25)
        Label4.TabIndex = 4
        Label4.Text = "Age"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(161, 269)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 33)
        Button2.TabIndex = 5
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(161, 106)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(161, 145)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(161, 185)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(161, 226)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 9
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.pexels_anniroenkae_3435249
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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


    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        TextBox_Username = New TextBox()
        TextBox_Password = New TextBox()
        Button2 = New Button()
        Welcomemsg = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(449, 393)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 21)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(449, 433)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 21)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' TextBox_Username
        ' 
        TextBox_Username.Location = New Point(539, 390)
        TextBox_Username.Name = "TextBox_Username"
        TextBox_Username.Size = New Size(100, 29)
        TextBox_Username.TabIndex = 3
        ' 
        ' TextBox_Password
        ' 
        TextBox_Password.Location = New Point(539, 430)
        TextBox_Password.Name = "TextBox_Password"
        TextBox_Password.Size = New Size(100, 29)
        TextBox_Password.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.Location = New Point(549, 465)
        Button2.Name = "Button2"
        Button2.Size = New Size(79, 27)
        Button2.TabIndex = 5
        Button2.Text = "LOGIN"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Welcomemsg
        ' 
        Welcomemsg.AutoSize = True
        Welcomemsg.BackColor = Color.Transparent
        Welcomemsg.Font = New Font("Times New Roman", 72.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Welcomemsg.ForeColor = SystemColors.ControlLightLight
        Welcomemsg.Location = New Point(315, 233)
        Welcomemsg.Name = "Welcomemsg"
        Welcomemsg.Size = New Size(561, 109)
        Welcomemsg.TabIndex = 8
        Welcomemsg.Text = "WELCOME!"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 21.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.pexels_anniroenkae_3435249
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1143, 630)
        Controls.Add(Welcomemsg)
        Controls.Add(Button2)
        Controls.Add(TextBox_Password)
        Controls.Add(TextBox_Username)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5, 4, 5, 4)
        Name = "Form1"
        Text = "MYSQL DATABASE CONNECTION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Welcomemsg As Label

End Class

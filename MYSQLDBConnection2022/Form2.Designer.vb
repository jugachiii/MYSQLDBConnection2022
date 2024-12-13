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
        TextBox_id = New TextBox()
        TextBox_fname = New TextBox()
        TextBox_lname = New TextBox()
        TextBox_age = New TextBox()
        Button3_Update = New Button()
        Button4_Delete = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        ComboBox1 = New ComboBox()
        ListBox1 = New ListBox()
        DataGridView1 = New DataGridView()
        Load_Table = New Button()
        Search_txt = New TextBox()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        RadioButton_Male = New RadioButton()
        RadioButton_Female = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker_dob = New DateTimePicker()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        Label1.Location = New Point(84, 10)
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
        Label2.Location = New Point(12, 49)
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
        Label3.Location = New Point(14, 89)
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
        Label4.Location = New Point(69, 130)
        Label4.Name = "Label4"
        Label4.Size = New Size(45, 25)
        Label4.TabIndex = 4
        Label4.Text = "Age"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(113, 214)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 33)
        Button2.TabIndex = 5
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox_id
        ' 
        TextBox_id.Location = New Point(140, 12)
        TextBox_id.Name = "TextBox_id"
        TextBox_id.Size = New Size(120, 23)
        TextBox_id.TabIndex = 6
        ' 
        ' TextBox_fname
        ' 
        TextBox_fname.Location = New Point(140, 51)
        TextBox_fname.Name = "TextBox_fname"
        TextBox_fname.Size = New Size(120, 23)
        TextBox_fname.TabIndex = 7
        ' 
        ' TextBox_lname
        ' 
        TextBox_lname.Location = New Point(140, 91)
        TextBox_lname.Name = "TextBox_lname"
        TextBox_lname.Size = New Size(120, 23)
        TextBox_lname.TabIndex = 8
        ' 
        ' TextBox_age
        ' 
        TextBox_age.Location = New Point(140, 132)
        TextBox_age.Name = "TextBox_age"
        TextBox_age.Size = New Size(120, 23)
        TextBox_age.TabIndex = 9
        ' 
        ' Button3_Update
        ' 
        Button3_Update.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3_Update.Location = New Point(12, 214)
        Button3_Update.Name = "Button3_Update"
        Button3_Update.Size = New Size(95, 33)
        Button3_Update.TabIndex = 10
        Button3_Update.Text = "Update"
        Button3_Update.UseVisualStyleBackColor = True
        ' 
        ' Button4_Delete
        ' 
        Button4_Delete.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4_Delete.Location = New Point(526, 398)
        Button4_Delete.Name = "Button4_Delete"
        Button4_Delete.Size = New Size(125, 40)
        Button4_Delete.TabIndex = 11
        Button4_Delete.Text = "Delete"
        Button4_Delete.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 281)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(157, 23)
        ComboBox1.TabIndex = 12
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(12, 310)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(157, 139)
        ListBox1.TabIndex = 13
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(306, 10)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(482, 263)
        DataGridView1.TabIndex = 14
        ' 
        ' Load_Table
        ' 
        Load_Table.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Load_Table.Location = New Point(342, 279)
        Load_Table.Name = "Load_Table"
        Load_Table.Size = New Size(134, 33)
        Load_Table.TabIndex = 15
        Load_Table.Text = "Load Table"
        Load_Table.UseVisualStyleBackColor = True
        ' 
        ' Search_txt
        ' 
        Search_txt.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Search_txt.Location = New Point(516, 279)
        Search_txt.Name = "Search_txt"
        Search_txt.RightToLeft = RightToLeft.Yes
        Search_txt.Size = New Size(228, 33)
        Search_txt.TabIndex = 16
        Search_txt.TextAlign = HorizontalAlignment.Right
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' RadioButton_Male
        ' 
        RadioButton_Male.AutoSize = True
        RadioButton_Male.Location = New Point(140, 174)
        RadioButton_Male.Name = "RadioButton_Male"
        RadioButton_Male.Size = New Size(51, 19)
        RadioButton_Male.TabIndex = 17
        RadioButton_Male.TabStop = True
        RadioButton_Male.Text = "Male"
        RadioButton_Male.UseVisualStyleBackColor = True
        ' 
        ' RadioButton_Female
        ' 
        RadioButton_Female.AutoSize = True
        RadioButton_Female.Location = New Point(197, 174)
        RadioButton_Female.Name = "RadioButton_Female"
        RadioButton_Female.Size = New Size(63, 19)
        RadioButton_Female.TabIndex = 18
        RadioButton_Female.TabStop = True
        RadioButton_Female.Text = "Female"
        RadioButton_Female.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(13, 252)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 19
        ' 
        ' DateTimePicker_dob
        ' 
        DateTimePicker_dob.Location = New Point(12, 252)
        DateTimePicker_dob.Name = "DateTimePicker_dob"
        DateTimePicker_dob.Size = New Size(200, 23)
        DateTimePicker_dob.TabIndex = 19
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.pexels_anniroenkae_3435249
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(811, 461)
        Controls.Add(DateTimePicker_dob)
        Controls.Add(DateTimePicker1)
        Controls.Add(RadioButton_Female)
        Controls.Add(RadioButton_Male)
        Controls.Add(Search_txt)
        Controls.Add(Load_Table)
        Controls.Add(DataGridView1)
        Controls.Add(ListBox1)
        Controls.Add(ComboBox1)
        Controls.Add(Button4_Delete)
        Controls.Add(Button3_Update)
        Controls.Add(TextBox_age)
        Controls.Add(TextBox_lname)
        Controls.Add(TextBox_fname)
        Controls.Add(TextBox_id)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox_id As TextBox
    Friend WithEvents TextBox_fname As TextBox
    Friend WithEvents TextBox_lname As TextBox
    Friend WithEvents TextBox_age As TextBox
    Friend WithEvents Button3_Update As Button
    Friend WithEvents Button4_Delete As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Load_Table As Button
    Friend WithEvents Search_txt As TextBox
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents RadioButton_Male As RadioButton
    Friend WithEvents RadioButton_Female As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker_dob As DateTimePicker
End Class

Imports MySql.Data.MySqlClient
Public Class Form2
    Dim gender As String
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table_auto()

        BackgroundImage = My.Resources.Resources.pexels_anniroenkae_3435249
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=final_indi"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select * from final_indi.accountdb"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim fname = READER.GetString("fname")
                ComboBox1.Items.Add(fname)
                ListBox1.Items.Add(fname)

            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=final_indi"
        Dim READER As MySqlDataReader

        Try
            conn.Open()
            Dim Query As String
            Query = "INSERT into final_indi.accountdb (id, fname, lname, age, gender, dob) values ('" & TextBox_id.Text & "', '" & TextBox_fname.Text & "', '" & TextBox_lname.Text & "', '" & TextBox_age.Text & "', '" & gender & "', '" & DateTimePicker_dob.Text & "')"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Saved")
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub Button3_Update_Click(sender As Object, e As EventArgs) Handles Button3_Update.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=final_indi"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "UPDATE final_indi.accountdb SET id='" & TextBox_id.Text & "', fname='" & TextBox_fname.Text & "', lname='" & TextBox_lname.Text & "', age='" & TextBox_age.Text & "', gender= '" & gender & "', dob= '" & DateTimePicker_dob.Text & "' where id='" & TextBox_id.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Updated")
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub


    Private Sub Button4_Delete_Click(sender As Object, e As EventArgs) Handles Button4_Delete.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=final_indi"
        Try
            conn.Open()
            Dim Query As String
            Query = "DELETE FROM data WHERE ID = '" & TextBox_id.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            MsgBox("Data deleted successfully!")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=final_indi"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select * from final_indi.accountdb where fname= '" & ComboBox1.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                TextBox_id.Text = READER.GetInt32("id")
                TextBox_fname.Text = READER.GetString("fname")
                TextBox_lname.Text = READER.GetString("lname")
                TextBox_age.Text = READER.GetInt32("age")

            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=final_indi"
        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "select * from final_indi.accountdb where fname= '" & ListBox1.Text & "'"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                TextBox_id.Text = READER.GetInt32("id")
                TextBox_fname.Text = READER.GetString("fname")
                TextBox_lname.Text = READER.GetString("lname")
                TextBox_age.Text = READER.GetInt32("age")

            End While

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub load_table_auto()
        Dim conn As New MySqlConnection
        conn.ConnectionString = ("server=localhost;userid=root;password='';database=final_indi")
        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource

        Try

            conn.Open()

            Dim query As String
            query = "SELECT id as 'Employee ID', fname as 'First Name', lname as 'Last Name', age as 'Age' from final_indi.accountdb"
            COMMAND = New MySqlCommand(query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub Load_Table_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Load_Table.Click
        Dim conn As New MySqlConnection
        conn.ConnectionString = ("server=localhost;userid=root;password='';database=final_indi")
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try

            conn.Open()

            Dim query As String
            query = "SELECT * FROM final_indi.accountdb"
            COMMAND = New MySqlCommand(query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Me.DataGridView1.Rows(e.RowIndex)

            TextBox_id.Text = row.Cells("id").Value.ToString()
            TextBox_fname.Text = row.Cells("fname").Value.ToString()
            TextBox_lname.Text = row.Cells("lname").Value.ToString()
            TextBox_age.Text = row.Cells("age").Value.ToString()
            gender = row.Cells("gender").Value.ToString()
            DateTimePicker_dob.Text = row.Cells("dob").Value.ToString()
        End If

    End Sub

    Private Sub Search_txt_TextChanged(sender As Object, e As EventArgs) Handles Search_txt.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("fname Like '%{0}%'", Search_txt.Text)
        DataGridView1.DataSource = DV
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to close the app?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub

    Private Sub RadioButton_Male_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Male.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub RadioButton_Female_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Female.CheckedChanged
        gender = "Female"
    End Sub
End Class
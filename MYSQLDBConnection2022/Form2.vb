Imports MySql.Data.MySqlClient
Public Class Form2
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundImage = My.Resources.Resources.pexels_anniroenkae_3435249
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Initialize the database connection
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=final_indi"

        Try
            ' Open the database connection
            conn.Open()

            ' Define the SQL query with parameters to prevent SQL injection
            Dim Query As String = "SELECT * FROM accountdb WHERE username = @username AND password = @password"
            COMMAND = New MySqlCommand(Query, conn)
            COMMAND.Parameters.AddWithValue("@username", TextBox1.Text)
            COMMAND.Parameters.AddWithValue("@password", TextBox2.Text)

            Dim READER As MySqlDataReader = COMMAND.ExecuteReader()
            Dim count As Integer = 0

            ' Count the number of matching records
            While READER.Read()
                count += 1
            End While

            ' Process the login result
            If count = 1 Then
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Replace "Form2" with your actual form name
                Dim mainForm As New Form2()
                mainForm.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Duplicate username and password detected.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conn.Close()
        Catch ex As Exception
            ' Display any errors that occur
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.Close()
        End Try
    End Sub
End Class
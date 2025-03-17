Public Class Form1

    Dim sqlitedb As String = "Data Source=C:\Users\hp\PycharmProject\CMS\venv\Sqlite_Script\Cricket_DB"
    Dim sqliteconn As SQLite.SQLiteConnection
    Dim sqlitecom As SQLite.SQLiteCommand
    Dim dr As SQLite.SQLiteDataReader


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Form21.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text = "") Then

            MsgBox("Username Required")
            TextBox1.Focus()
            TextBox1.BackColor = Color.Red
            Exit Sub


        ElseIf (TextBox2.Text = "") Then

            MsgBox("Password Required")
            TextBox2.Focus()
            TextBox2.BackColor = Color.Red
            Exit Sub


        End If

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "select * from Login where Username = '" & TextBox1.Text & "' and Password = '" & TextBox2.Text & "'"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        dr = sqlitecom.ExecuteReader

        If dr.Read Then

            MsgBox("Login Successful")
            Form2.Show()
            Me.Hide()

        Else
            MsgBox("Invalid Login Credentials")

        End If

        dr.Close()
        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub


End Class

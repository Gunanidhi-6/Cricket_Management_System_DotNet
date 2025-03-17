Public Class Form21

    Dim sqlitedb As String = "Data Source=C:\Users\hp\PycharmProject\CMS\venv\Sqlite_Script\Cricket_DB"
    Dim sqliteconn As SQLite.SQLiteConnection
    Dim sqlitecom As SQLite.SQLiteCommand
    Dim dr As SQLite.SQLiteDataReader


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "Insert into Login(Username,Password) values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        sqlitecom.ExecuteNonQuery()

        MsgBox("Account Created Succesfully")
        Me.Close()
        Form1.Show()

        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()


    End Sub


End Class
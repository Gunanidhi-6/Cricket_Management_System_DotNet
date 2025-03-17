Imports System.Data.SQLite

Public Class Form9

    Dim sqlitedb As String = "Data Source=C:\Users\hp\PycharmProject\CMS\venv\Sqlite_Script\Cricket_DB"
    Dim sqliteconn As SQLite.SQLiteConnection
    Dim sqlitecom As SQLite.SQLiteCommand


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "Insert into Team(Team_id,Team_rank,Team_name,country_name,no_of_wins,no_of_loses,no_of_draws,no_of_bowlers,no_of_batsmen) values('" & TextBox1.Text & "','" & TextBox4.Text & "','" & TextBox9.Text & "','" & TextBox3.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "','" & TextBox7.Text & "','" & TextBox2.Text & "','" & TextBox8.Text & "')"

        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        sqlitecom.ExecuteNonQuery()
        MsgBox("Team created successfully")

        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()


    End Sub


End Class
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form12


    Dim sqlitedb As String = "Data Source=C:\Users\hp\PycharmProject\CMS\venv\Sqlite_Script\Cricket_DB"
    Dim sqliteconn As SQLite.SQLiteConnection
    Dim sqlitecom As SQLite.SQLiteCommand
    Dim dr As SQLite.SQLiteDataReader


    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "select * from TEAM"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        dr = sqlitecom.ExecuteReader

        Dim id As String
        While dr.Read

            id = dr.GetValue(0)
            ComboBox1.Items.Add(id)

        End While


        dr.Close()
        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "Insert into Bowler(player_id,team_id,no_of_matches,no_of_t20,no_of_odi,no_of_test,no_of_wickets,type_of_bowler,economy) values('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox9.Text & "','" & TextBox3.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "','" & TextBox7.Text & "','" & ComboBox2.Text & "','" & TextBox8.Text & "')"

        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        sqlitecom.ExecuteNonQuery()
        MsgBox("Bowler created successfully")

        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub



End Class
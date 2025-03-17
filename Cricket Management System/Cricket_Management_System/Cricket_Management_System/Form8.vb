Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form8

    Dim sqlitedb As String = "Data Source=C:\Users\hp\PycharmProject\CMS\venv\Sqlite_Script\Cricket_DB"
    Dim sqliteconn As SQLite.SQLiteConnection
    Dim sqlitecom As SQLite.SQLiteCommand
    Dim dr As SQLite.SQLiteDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "Insert into Captain(Captain_id,Captain_name,team_id,player_id,years_of_captaincy,no_of_wins) values('" & TextBox1.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "')"

        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        sqlitecom.ExecuteNonQuery()
        MsgBox("Captain created successfully")

        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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
        dr.Dispose()
        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub


End Class
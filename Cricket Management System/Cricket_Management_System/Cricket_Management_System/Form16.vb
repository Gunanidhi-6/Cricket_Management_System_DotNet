Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form16

    Dim sqlitedb As String = "Data Source=C:\Users\hp\PycharmProject\CMS\venv\Sqlite_Script\Cricket_DB"
    Dim sqliteconn As SQLite.SQLiteConnection
    Dim sqlitecom As SQLite.SQLiteCommand
    Dim dr As SQLite.SQLiteDataReader



    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "select * from Captain"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        dr = sqlitecom.ExecuteReader

        Dim id As String
        While dr.Read

            id = dr.GetValue(0)
            ComboBox2.Items.Add(id)

        End While

        dr.Close()
        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "select * from Captain where Captain_id = '" & ComboBox2.Text & "'"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        dr = sqlitecom.ExecuteReader

        If dr.Read Then

            TextBox4.Text = dr.GetValue(1)
            ComboBox1.Text = dr.GetValue(2)
            TextBox3.Text = dr.GetValue(3)
            TextBox6.Text = dr.GetValue(4)
            TextBox5.Text = dr.GetValue(5)


        End If

        dr.Close()
        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()


        Dim str As String = "update Captain set years_of_captaincy = '" & TextBox6.Text & "',no_of_wins = '" & TextBox5.Text & "' where Captain_id = '" & ComboBox2.Text & "'"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        sqlitecom.ExecuteNonQuery()

        MsgBox("Captain Details Updated Successfully")

        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "delete from Captain where Captain_id = '" & ComboBox2.Text & "'"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        sqlitecom.ExecuteNonQuery()

        MsgBox("Captain with ID '" & ComboBox2.Text & "' deleted successfully")

        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub




End Class
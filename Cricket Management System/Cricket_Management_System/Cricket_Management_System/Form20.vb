Public Class Form20


    Dim sqlitedb As String = "Data Source=C:\Users\hp\PycharmProject\CMS\venv\Sqlite_Script\Cricket_DB"
    Dim sqliteconn As SQLite.SQLiteConnection
    Dim sqlitecom As SQLite.SQLiteCommand
    Dim dr As SQLite.SQLiteDataReader



    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "select * from Bowler"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        dr = sqlitecom.ExecuteReader

        Dim id As String
        While dr.Read

            id = dr.GetValue(0)
            ComboBox3.Items.Add(id)

        End While

        dr.Close()
        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "select * from Bowler where player_id = '" & ComboBox3.Text & "'"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        dr = sqlitecom.ExecuteReader

        If dr.Read Then

            ComboBox1.Text = dr.GetValue(1)
            TextBox9.Text = dr.GetValue(2)
            TextBox3.Text = dr.GetValue(3)
            TextBox6.Text = dr.GetValue(4)
            TextBox5.Text = dr.GetValue(5)
            TextBox7.Text = dr.GetValue(6)
            ComboBox2.Text = dr.GetValue(7)
            TextBox8.Text = dr.GetValue(8)


        End If

        dr.Close()
        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "update Bowler set no_of_matches = '" & TextBox9.Text & "',no_of_T20 = '" & TextBox3.Text & "',no_of_odi = '" & TextBox6.Text & "',no_of_test = '" & TextBox5.Text & "',no_of_wickets = '" & TextBox7.Text & "',economy = '" & TextBox8.Text & "' where player_id = '" & ComboBox3.Text & "'"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        sqlitecom.ExecuteNonQuery()

        MsgBox("Bowler Details Updated Successfully")

        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()


        Dim str As String = "delete from Bowler where player_id = '" & ComboBox3.Text & "'"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        sqlitecom.ExecuteNonQuery()

        MsgBox("Bowler with ID '" & ComboBox3.Text & "' deleted successfully")

        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub



End Class
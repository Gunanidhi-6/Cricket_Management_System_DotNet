Public Class Form13

    Dim sqlitedb As String = "Data Source=C:\Users\hp\PycharmProject\CMS\venv\Sqlite_Script\Cricket_DB"
    Dim sqliteconn As SQLite.SQLiteConnection
    Dim sqlitecom As SQLite.SQLiteCommand
    Dim dr As SQLite.SQLiteDataReader


    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        GroupBox1.Enabled = False
        GroupBox2.Enabled = False

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        GroupBox1.Enabled = True
        GroupBox2.Enabled = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        GroupBox1.Enabled = False
        GroupBox2.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "Insert into Coach(coach_id,team_id,coach_name) values('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox2.Text & "')"

        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        sqlitecom.ExecuteNonQuery()
        MsgBox("Coach created successfully")

        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "Insert into Umpire(Umpire_id,Umpire_name,no_of_matches,Country) values('" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox3.Text & "','" & TextBox6.Text & "')"

        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        sqlitecom.ExecuteNonQuery()
        MsgBox("Umpire created successfully")

        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()


    End Sub



End Class
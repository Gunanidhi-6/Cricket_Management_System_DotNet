Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form18


    Dim sqlitedb As String = "Data Source=C:\Users\hp\PycharmProject\CMS\venv\Sqlite_Script\Cricket_DB"
    Dim sqliteconn As SQLite.SQLiteConnection
    Dim sqlitecom As SQLite.SQLiteCommand
    Dim dr As SQLite.SQLiteDataReader


    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GroupBox1.Enabled = False
        GroupBox2.Enabled = False

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "select * from Coach"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        dr = sqlitecom.ExecuteReader

        Dim id As String
        While dr.Read

            id = dr.GetValue(0)
            ComboBox2.Items.Add(id)

        End While

        dr.Close()
        sqlitecom.Dispose()



        Dim str1 As String = "select * from Umpire"
        sqlitecom = New SQLite.SQLiteCommand(str1, sqliteconn)
        dr = sqlitecom.ExecuteReader

        Dim id2 As String
        While dr.Read

            id2 = dr.GetValue(0)
            ComboBox3.Items.Add(id2)

        End While

        dr.Close()
        sqlitecom.Dispose()


        Dim str2 As String = "select * from Team"
        sqlitecom = New SQLite.SQLiteCommand(str2, sqliteconn)
        dr = sqlitecom.ExecuteReader

        Dim id3 As String
        While dr.Read

            id3 = dr.GetValue(0)
            ComboBox1.Items.Add(id3)

        End While


        dr.Close()
        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        GroupBox1.Enabled = True
        GroupBox2.Enabled = False


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click


        GroupBox1.Enabled = False
        GroupBox2.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "update Coach set Team_id = '" & ComboBox1.Text & "'"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        sqlitecom.ExecuteNonQuery()
        MsgBox("Coach Details Updated Successfully")

        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "update Umpire set no_of_matches = '" & TextBox3.Text & "'"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        sqlitecom.ExecuteNonQuery()
        MsgBox("Umpire Details Updated Successfully")

        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "delete from Coach where Coach_id = '" & ComboBox2.Text & "'"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        sqlitecom.ExecuteNonQuery()

        MsgBox("Coach with ID '" & ComboBox2.Text & "' deleted successfully")

        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "delete from Umpire where Umpire_id = '" & ComboBox3.Text & "'"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        sqlitecom.ExecuteNonQuery()

        MsgBox("Umpire with ID '" & ComboBox3.Text & "' deleted successfully")

        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "select * from Coach where coach_id = '" & ComboBox2.Text & "'"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        dr = sqlitecom.ExecuteReader


        If dr.Read Then

            ComboBox1.Text = dr.GetValue(1)
            TextBox2.Text = dr.GetValue(2)

        End If

        dr.Close()
        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        sqliteconn = New SQLite.SQLiteConnection(sqlitedb)
        sqliteconn.Open()

        Dim str As String = "select * from Umpire where Umpire_id = '" & ComboBox3.Text & "'"
        sqlitecom = New SQLite.SQLiteCommand(str, sqliteconn)
        dr = sqlitecom.ExecuteReader

        If dr.Read Then

            TextBox5.Text = dr.GetValue(1)
            TextBox3.Text = dr.GetValue(2)
            TextBox6.Text = dr.GetValue(3)

        End If

        dr.Close()
        sqlitecom.Dispose()
        sqliteconn.Close()
        sqliteconn.Dispose()

    End Sub


End Class
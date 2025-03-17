Public Class Form7

    Dim SqliteDB As String = "Data Source=C:\Users\hp\PycharmProject\CMS\venv\Sqlite_Script\Cricket_DB"
    Dim Sqliteconnect As SQLite.SQLiteConnection
    Dim SQlitecommand As SQLite.SQLiteCommand
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim strsql As String = "SELECT * from Batsman"

        Sqliteconnect = New SQLite.SQLiteConnection(SqliteDB)
        Sqliteconnect.Open()

        SQlitecommand = New SQLite.SQLiteCommand(strsql, Sqliteconnect)

        Dim sqlitedataadapter = New SQLite.SQLiteDataAdapter
        sqlitedataadapter.SelectCommand = SQlitecommand

        Dim dt As New DataTable
        sqlitedataadapter.Fill(dt)
        DataGridView1.DataSource = dt
        SQlitecommand.Dispose()
        Sqliteconnect.Close()
        Sqliteconnect.Dispose()



    End Sub


End Class
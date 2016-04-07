Imports MySql.Data.MySqlClient

Public Class message
    Dim conn As MySqlConnection
    Dim data As DataTable
    Dim da As MySqlDataAdapter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim com As MySqlCommand
        Dim i As Integer
        Dim TABLE As New DataTable
        Dim adapter As New MySqlDataAdapter

        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("Select * From 称重管理", conn)

            With adapter
                .SelectCommand = com
                .Fill(TABLE )
            End With

            For i = 0 To TABLE.Rows.Count - 1
                With ListView1
                    .Items.Add(TABLE.Rows(i)("车牌号"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(TABLE.Rows(i)("净重"))
                        .Add(TABLE.Rows(i)("时间"))
                        .Add(TABLE.Rows(i)("管理账户"))
                    End With
                End With
            Next

        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try

    End Sub

    Private Sub message_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button1
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class
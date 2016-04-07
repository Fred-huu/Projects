Imports MySql.Data.MySqlClient

Public Class autoadmin
    Dim conn As MySqlConnection
    Dim data As DataTable
    Dim da As MySqlDataAdapter
    Dim com As MySqlCommand

    Private Sub autoadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        administer.Close()
    End Sub

    Private Sub 手动模式ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 手动模式ToolStripMenuItem.Click
        administer.Show()
        Me.Close()
    End Sub

    Private Sub 注销ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 注销ToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Timer1.Enabled = True

        '数据库连接与操作
        '  Dim dr As MySqlDataReader

        ' Try
        '    conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
        '   conn.Open()

        '    com = New MySqlCommand("Insert Into driver.称重管理 (车牌号,净重,时间,管理账户) Values (@车牌号,@净重,@时间,'" & Label2.Text & "')", conn)
        '    dr = com.ExecuteReader
        '    insertdata()

        '   conn.Close()

        ' Catch myerror As MySqlException
        '     MsgBox("Error connecting to the server:" & myerror.Message)
        ' End Try
    End Sub

    Private Sub insertdata()
        '数据库连接与操作
        '   Dim dr As MySqlDataReader

        '  Try
        '      conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
        '     conn.Open()

        '    com = New MySqlCommand("Select * From 车辆,司机 Where 驾驶证号=(Select 驾驶证号 From 驾驶 Where 车牌号='" & TextBox7.Text & "') And 车牌号='" & TextBox7.Text & "'", conn)

        '    dr = com.ExecuteReader

        '     conn.Close()

        '  Catch myerror As MySqlException
        '      MsgBox("Error connecting to the server:" & myerror.Message)
        '  End Try
    End Sub

    Private Sub 暂停ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles 暂停ToolStripMenuItem.Click
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub 复位ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 复位ToolStripMenuItem.Click

    End Sub
End Class
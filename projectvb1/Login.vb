Imports MySql.Data.MySqlClient

Public Class Login
    Dim conn As MySqlConnection
    Dim data As DataTable
    Dim da As MySqlDataAdapter
    Dim com As MySqlCommand

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Label4.Text = System.DateTime.Now
        Me.AcceptButton = OK
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Now
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        '数据库操作
        Dim dr As MySqlDataReader

        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("Select * From 用户 Where 账号='" & UsernameTextBox.Text & "' And 密码='" & PasswordTextBox.Text & "'", conn)
            dr = com.ExecuteReader()
            If dr.Read() Then ' 表示有找到通过验证
                admin.Show()
                Me.Close()
            Else
                'MessageBox.Show("密码或用户名错误，请重新输入!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("你这个笨蛋！居然把密码（用户名）输错了!Orz", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("密码忘啦？！快让我们一起找回密码！")
        MessageBox.Show("其实啦...我也不知道怎样找回密码！这个功能还没有做出来！当然我也不打算错 (￣▽￣)~*这个键其实没什么用处！（不服来打我啊！）但是，有句话我想对你说：")
        MessageBox.Show("你密码忘了关我屁事！怪我咯！你这个笨蛋！ ╮(￣▽￣)╭")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        UserName.Show()
        Me.Close()
    End Sub


End Class

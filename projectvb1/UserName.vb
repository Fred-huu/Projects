Imports MySql.Data.MySqlClient

Public Class UserName
    Dim conn As MySqlConnection
    Dim data As DataTable
    Dim da As MySqlDataAdapter
    Dim com As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '数据库操作
        Dim dr As MySqlDataReader

        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("Select * From 用户 Where 账号='" & TextBox1.Text & "'", conn)
            dr = com.ExecuteReader()
            If dr.Read() Then ' 表示有找到通过验证
                'MessageBox.Show("账号已被注册，请重新输入!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("笨蛋，这个账号已被注册，快重新想一个!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Text = ""
            Else
                If TextBox2.Text <> TextBox3.Text Then
                    'MessageBox.Show("两次密码输入不一致，请重新输入!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MessageBox.Show("笨蛋！两次密码输入不一致，快重新输入!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    insertuser()
                    'MessageBox.Show("账号注册成功！")
                    MessageBox.Show("哇！账号居然注册成功啦~！恭喜入坑！")
                    Login.Show()
                    Me.Close()
                End If
            End If
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try

    End Sub

    Private Sub insertuser()
        Dim dr As MySqlDataReader

        '数据库连接与操作
        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("INSERT INTO driver.用户 (姓名,账号,密码,权限) VALUES ('" & TextBox4.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "')", conn)
            dr = com.ExecuteReader
            conn.Close()
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Login.Show()
        admin.Show()
        Me.Close()
    End Sub

    Private Sub UserName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button1
    End Sub
End Class
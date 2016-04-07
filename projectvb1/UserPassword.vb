Imports MySql.Data.MySqlClient

Public Class UserPassword
    Dim conn As MySqlConnection
    Dim data As DataTable
    Dim da As MySqlDataAdapter
    Dim com As MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub UserPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '数据库操作

        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("Select * From 用户 Where 账号='" & administer.UserLabel.Text & "' And 密码='" & TextBox1.Text & "'", conn)
            dr = com.ExecuteReader()
            If dr.Read() Then ' 表示有找到通过验证
                conn.Close()
                If TextBox3.Text = TextBox2.Text Then

                    If TextBox3.Text = TextBox1.Text Then
                        MessageBox.Show("新密码与旧密码一致，请重新输入！", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TextBox1.TabIndex = 4
                        TextBox2.TabIndex = 1
                        TextBox3.TabIndex = 2
                        Button1.TabIndex = 3
                    Else
                        change_password()

                        MessageBox.Show("恭喜，你居然能成功修改密码！")
                        'MessageBox.Show("修改密码成功！")

                        TextBox1.Text = ""
                        TextBox2.Text = ""
                        TextBox3.Text = ""
                        TextBox1.TabIndex = 1
                        TextBox2.TabIndex = 2
                        TextBox3.TabIndex = 3
                        Button1.TabIndex = 4
                    End If

                Else
                    MessageBox.Show("笨蛋，两次密码输入不一致，快重新输入！", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'MessageBox.Show("两次密码输入不一致，请重新输入！", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TextBox1.TabIndex = 4
                    TextBox2.TabIndex = 1
                    TextBox3.TabIndex = 2
                    Button1.TabIndex = 3
                End If

            Else
                MessageBox.Show("原密码错误，请重新输入!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conn.Close()
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try
    End Sub

    Private Sub change_password()
        '数据库操作,修改密码

        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()

            com = New MySqlCommand("UPDATE driver.用户 SET 密码 = '" & TextBox3.Text & "' WHERE 账号='" & administer.UserLabel.Text & "'", conn)
            dr = com.ExecuteReader
            conn.Close()

        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try
    End Sub
End Class
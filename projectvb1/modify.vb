Imports MySql.Data.MySqlClient
Public Class modify
    Dim conn As MySqlConnection
    Dim data As DataTable
    Dim da As MySqlDataAdapter

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click

        Dim com As MySqlCommand
        Dim dr As MySqlDataReader

        If Me.TextBox1.Text <> "" Then
            '将修改后的车牌号传输到administer上
            administer.TextBox7.Text = Me.TextBox1.Text

            '清空administer的值
            If administer.TextBox1.Text <> "" And administer.TextBox2.Text <> "" And administer.TextBox3.Text <> "" And administer.TextBox4.Text <> "" And administer.TextBox5.Text <> "" And administer.TextBox6.Text <> "" And administer.TextBox8.Text <> "" And administer.TextBox10.Text <> "" And administer.TextBox12.Text <> "" Then
                administer.TextBox1.Text = ""
                administer.TextBox2.Text = ""
                administer.TextBox3.Text = ""
                administer.TextBox4.Text = ""
                administer.TextBox5.Text = ""
                administer.TextBox6.Text = ""
                administer.TextBox8.Text = ""
                administer.TextBox10.Text = ""
                administer.TextBox12.Text = ""
            End If

            'administer数据库操作
            Try
                conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
                conn.Open()
                com = New MySqlCommand("Select * From 车辆,司机 Where 驾驶证号=(Select 驾驶证号 From 驾驶 Where 车牌号='" & administer.TextBox7.Text & "') And 车牌号='" & administer.TextBox7.Text & "'", conn)
                dr = com.ExecuteReader()
                While dr.Read()
                    administer.TextBox1.AppendText(dr!驾驶证号 & vbCrLf)
                    administer.TextBox2.AppendText(dr!姓名 & vbCrLf)
                    administer.TextBox3.AppendText(dr!出生日期 & vbCrLf)
                    administer.TextBox4.AppendText(dr!部门 & vbCrLf)
                    administer.TextBox5.AppendText(dr!驾照类型 & vbCrLf)
                    administer.TextBox6.AppendText(dr!联系电话 & vbCrLf)
                    administer.TextBox8.AppendText(dr!车型 & vbCrLf)
                    administer.TextBox10.AppendText(dr!车重 & vbCrLf)
                End While
                dr.Close()
            Catch myerror As MySqlException
                'MsgBox("Error connecting to the server:" & myerror.Message)
                MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
            End Try

            '重新计算货物重量
            Dim a As Single
            Dim b As Single
            If (administer.TextBox11.Text <> "" And administer.TextBox10.Text <> "") Then
                a = administer.TextBox11.Text
                b = administer.TextBox10.Text
                administer.TextBox12.Text = a - b
            Else
                administer.TextBox12.Text = ""
            End If

            administer.Show()

            Me.Close()

            '当输入数据为空时
        Else
            MessageBox.Show("什么都没输入，快输入数据!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MessageBox.Show("输入数据为空!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
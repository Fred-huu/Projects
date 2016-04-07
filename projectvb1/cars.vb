Imports MySql.Data.MySqlClient
Imports System.IO

Public Class cars
    Dim conn As MySqlConnection
    Dim data As DataTable
    Dim da As MySqlDataAdapter
    Dim a As OpenFileDialog = New OpenFileDialog

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Insert image to database
        ' Dim mstream As New System.IO.MemoryStream()
        'PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        'Dim arrImage() As Byte = mstream.GetBuffer()
        ' mstream.Close()

        Dim com As MySqlCommand
        Dim dr As MySqlDataReader

        '数据库连接与操作
        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("INSERT INTO driver.车辆 (车牌号,车型,出厂日期,车重,核定载重) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "','" & TextBox4.Text & "')", conn)
            'com = New MySqlCommand("INSERT INTO driver.车辆 (车牌号,车型,出厂日期,车重,核定载重,照片) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "','" & TextBox4.Text & "'，@Photo)", conn)
            'com.Parameters.AddWithValue("@Photo", arrImage)
            dr = com.ExecuteReader

            MessageBox.Show("数据存储成功！")

            conn.Close()
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try

    End Sub

    Private Sub cars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button1
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        '清空数据
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenDlg.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg|*.gif|*.bmp"  '这是限定图片的格式
        If OpenDlg.ShowDialog() = DialogResult.OK Then
            Me.PictureBox1.Image = Image.FromFile(OpenDlg.FileName)
        End If
    End Sub
End Class
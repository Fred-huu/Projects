Imports MySql.Data.MySqlClient

Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
'Imports System.IO

Public Class administer
    Dim conn As MySqlConnection
    Dim data As DataTable
    Dim da As MySqlDataAdapter

    Dim myPort As Array
    Delegate Sub SetTextCallback(ByVal [text] As String)

    Sub RecieveRefreshMethod(ByVal str As String) '定义一个实例方法
        ShowRecieveData(str)
    End Sub

    Private Sub ShowRecieveData(ByVal str As String)
        On Error GoTo Err

        Exit Sub
Err:    MsgBox("数据接收或显示错误！" + vbNewLine + ErrorToString())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '串口连接相关
        SerialPort1.PortName = ComboBox1.Text
        SerialPort1.BaudRate = ComboBox2.Text
        SerialPort1.Open()

        Dim rcv As Byte() = New Byte(2) {}

        For i As Integer = 0 To 2
            rcv(i) = SerialPort1.ReadExisting
        Next
        TextBox7.Text = rcv(0)
        TextBox9.Text = rcv(1)
        TextBox11.Text = rcv(2)

        '数据库相关
        Dim com As MySqlCommand
        Dim dr As MySqlDataReader

        Button2.Enabled = True

        '清空数据
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox8.Text <> "" And TextBox10.Text <> "" And TextBox12.Text <> "" Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            'TextBox7.Text = ""
            TextBox8.Text = ""
            'TextBox9.Text = ""
            TextBox10.Text = ""
            'TextBox11.Text = ""
            TextBox12.Text = ""
        End If

        '数据库连接与操作
        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("Select * From 车辆,司机 Where 驾驶证号=(Select 驾驶证号 From 驾驶 Where 车牌号='" & TextBox7.Text & "') And 车牌号='" & TextBox7.Text & "'", conn)
            dr = com.ExecuteReader()
            While dr.Read()
                TextBox1.AppendText(dr!驾驶证号 & vbCrLf)
                TextBox2.AppendText(dr!姓名 & vbCrLf)
                TextBox3.AppendText(dr!出生日期 & vbCrLf)
                TextBox4.AppendText(dr!部门 & vbCrLf)
                TextBox5.AppendText(dr!驾照类型 & vbCrLf)
                TextBox6.AppendText(dr!联系电话 & vbCrLf)
                TextBox8.AppendText(dr!车型 & vbCrLf)
                TextBox10.AppendText(dr!车重 & vbCrLf)
                'Dim data As Byte() = DirectCast(dr("Photo"), Byte())
                'Dim ms As New MemoryStream(data)
                'PictureBox1.Image = Image.FromStream(ms)
            End While
            conn.Close()
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try

        '货物净重称量
        Dim a As Single
        Dim b As Single
        If (TextBox11.Text <> "" And TextBox10.Text <> "") Then
            a = TextBox11.Text
            b = TextBox10.Text
            TextBox12.Text = a - b
        Else
            TextBox12.Text = ""
        End If

    End Sub

    'Private Sub SerialPort1_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
    ' ReceivedText(SerialPort1.ReadExisting())
    'End Sub

    'Private Sub ReceivedText(ByVal [text] As String) 'input from ReadExisting
    '   If Me.TextBox7.InvokeRequired Then
    '    Dim x As New SetTextCallback(AddressOf ReceivedText)
    '    Me.Invoke(x, New Object() {(text)})
    '   Else
    'Me.TextBox7.Text &= [text] 'append text

    ' ’Dim rcv As Byte() = New Byte(2) {}

    ' ’For i As Integer = 0 To 2
    '  ’        rcv(i) = SerialPort1.ReadExisting
    '   ’Next
    '     ’TextBox7.Text = rcv(0)
    '     ’TextBox9.Text = rcv(1)
    '     ’TextBox11.Text = rcv(2)
    '  End If
    'End Sub

    Private Sub administer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserLabel.Text = Login.UsernameTextBox.Text
        Login.Close()
        autoadmin.Close()
        Me.AcceptButton = Button1

        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBox1.Items.AddRange(myPort)
    End Sub

    Private Sub 数据修改ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 数据修改ToolStripMenuItem.Click
        modify.Show()
    End Sub

    Private Sub 记录查询ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        message.Show()
    End Sub

    Private Sub 称重历史查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 称重历史查询ToolStripMenuItem.Click
        message.Show()
    End Sub

    Private Sub 司机信息查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 司机信息查询ToolStripMenuItem.Click
        DMessage.Show()
    End Sub

    Private Sub 车辆信息录入ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 车辆信息录入ToolStripMenuItem.Click
        cars.Show()
    End Sub

    Private Sub 车辆信息查询ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 车辆信息查询ToolStripMenuItem.Click
        CMessage.Show()
    End Sub

    Private Sub 司机信息录入ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 司机信息录入ToolStripMenuItem.Click
        drivers.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim com As MySqlCommand
        Dim dr As MySqlDataReader

        '数据库连接与操作
        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("INSERT INTO driver.称重管理 (车牌号,净重,时间,管理账户) VALUES ('" & TextBox7.Text & "','" & TextBox12.Text & "','" & TextBox9.Text & "','" & UserLabel.Text & "')", conn)
            dr = com.ExecuteReader

            conn.Close()
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try

    End Sub

    Private Sub 复位ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 复位ToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub 注销ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 注销ToolStripMenuItem.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub 自动模式ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        autoadmin.Show()
        Me.Close()
    End Sub

    Private Sub 修改密码ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改密码ToolStripMenuItem.Click
        UserPassword.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class

﻿'导入各种库
Imports MySql.Data.MySqlClient

Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.IO

Public Class admin
    '定义全局变量

    '数据库
    Dim conn As MySqlConnection
    Dim data As DataTable
    Dim da As MySqlDataAdapter

    '-------------------------------------------

    '读取文件
    Dim a As OpenFileDialog = New OpenFileDialog

    '-------------------------------------------

    '串口通信
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

    '-------------------------------------------

    '窗口界面
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        time.Text = Now

        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBox1.Items.AddRange(myPort)

        Me.AcceptButton = entryButton

        USERTextBox.Text = ""
        PasswordTextBox.Text = ""

        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        '一级菜单
        admin0.Visible = False
        admin1.Visible = True
        mess0.Visible = True
        mess1.Visible = False
        add0.Visible = True
        add1.Visible = False
        user0.Visible = True
        user1.Visible = False
        including0.Visible = True
        including1.Visible = False

        'panel容器
        loginPanel.Visible = True
        newuserPanel.Visible = False
        adminPanel.Visible = False
        wPanel.Visible = False
        cmPanel.Visible = False
        dmPanel.Visible = False
        caddPanel.Visible = False
        daddPanel.Visible = False
        usermessPanel.Visible = False
        pwdPanel.Visible = False
        helpPanel.Visible = False
        suggestPanel.Visible = False
        aboutPanel.Visible = False


        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBox1.Items.AddRange(myPort)

    End Sub

    '-------------------------------------------

    '登录界面
    '确定按钮
    Private Sub entryButton_Click(sender As Object, e As EventArgs) Handles entryButton.Click
        '数据库操作
        Dim dr As MySqlDataReader
        Dim com As MySqlCommand

        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("Select * From 用户 Where 账号='" & USERTextBox.Text & "' And 密码='" & PasswordTextBox.Text & "'", conn)
            dr = com.ExecuteReader()
            If dr.Read() Then ' 表示有找到通过验证
                loginPanel.Visible = False
                menuPanel.Visible = True
                adminPanel.Visible = True
                UserLabel.Text = dr!姓名 & vbCrLf
            Else
                'MessageBox.Show("密码或用户名错误，请重新输入!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("你这个笨蛋！居然把密码（用户名）输错了!Orz", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try

    End Sub

    '取消按钮
    Private Sub offButton_Click(sender As Object, e As EventArgs) Handles offButton.Click
        Me.Close()
    End Sub

    '忘记密码
    Private Sub 忘记密码LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles 忘记密码LinkLabel.LinkClicked
        MessageBox.Show("密码忘啦？！快让我们一起找回密码！")
        MessageBox.Show("其实啦...我也不知道怎样找回密码！这个功能还没有做出来！当然我也不打算错 (￣▽￣)~*这个键其实没什么用处！（不服来打我啊！）但是，有句话我想对你说：")
        MessageBox.Show("你密码忘了关我屁事！怪我咯！你这个笨蛋！ ╮(￣▽￣)╭")
    End Sub

    '注册
    Private Sub 账号注册LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles 账号注册LinkLabel.LinkClicked
        '进入注册界面
        newuserPanel.Visible = True
        loginPanel.Visible = False

        '清除注册界面数据
        newuserTextBox.Text = ""
        newpasswTextBox.Text = ""
        newapasswTextBox.Text = ""
        newnameTextBox.Text = ""
        newaccessTextBox.Text = ""
    End Sub

    '-------------------------------------------

    '账号注册界面
    Private Sub newokButton_Click(sender As Object, e As EventArgs) Handles newokButton.Click
        '数据库操作
        Dim dr As MySqlDataReader
        Dim com As MySqlCommand

        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("Select * From 用户 Where 账号='" & newuserTextBox.Text & "'", conn)
            dr = com.ExecuteReader()

            If newnameTextBox.Text = "" Or newuserTextBox.Text = "" Or newpasswTextBox.Text = "" Or newapasswTextBox.Text = "" Or newapasswTextBox.Text = "" Then
                'MessageBox.Show("有数据没有输入，请输入!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("笨蛋，数据都没输完，激动什么!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf dr.Read() Then ' 表示有找到通过验证
                'MessageBox.Show("账号已被注册，请重新输入!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("笨蛋，这个账号已被注册，快重新想一个!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                newuserTextBox.Text = ""
            Else
                If newapasswTextBox.Text <> newpasswTextBox.Text Then
                    'MessageBox.Show("两次密码输入不一致，请重新输入!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MessageBox.Show("笨蛋！两次密码输入不一致，快重新输入!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    insertuser()
                    'MessageBox.Show("账号注册成功！")
                    MessageBox.Show("哇！账号居然注册成功啦~！恭喜入坑！")

                    '清除登录界面的数据
                    USERTextBox.Text = ""
                    PasswordTextBox.Text = ""

                    '返回登陆界面
                    loginPanel.Visible = True
                    newuserPanel.Visible = False

                End If
            End If
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try
    End Sub

    Private Sub insertuser()
        Dim dr As MySqlDataReader
        Dim com As MySqlCommand

        '数据库连接与操作
        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("INSERT INTO driver.用户 (姓名,账号,密码,权限) VALUES ('" & newnameTextBox.Text & "','" & newuserTextBox.Text & "','" & newapasswTextBox.Text & "','" & newaccessTextBox.Text & "')", conn)
            dr = com.ExecuteReader
            conn.Close()
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try

    End Sub

    '返回登陆界面
    Private Sub newcancelButton_Click(sender As Object, e As EventArgs) Handles newcancelButton.Click
        loginPanel.Visible = True
        newuserPanel.Visible = False
    End Sub

    '-------------------------------------------

    '管理界面
    '点击“管理界面”（未选中）
    Private Sub admin0_Click(sender As Object, e As EventArgs) Handles admin0.Click
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        '一级菜单
        admin0.Visible = False
        admin1.Visible = True
        mess0.Visible = True
        mess1.Visible = False
        add0.Visible = True
        add1.Visible = False
        user0.Visible = True
        user1.Visible = False
        including0.Visible = True
        including1.Visible = False

        'panel容器
        adminPanel.Visible = True
        wPanel.Visible = False
        cmPanel.Visible = False
        dmPanel.Visible = False
        caddPanel.Visible = False
        daddPanel.Visible = False
        usermessPanel.Visible = False
        pwdPanel.Visible = False
        helpPanel.Visible = False
        suggestPanel.Visible = False
        aboutPanel.Visible = False

    End Sub

    '启动按钮
    Private Sub openButton_Click(sender As Object, e As EventArgs) Handles openButton.Click
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

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

        updateButton.Enabled = True

        '清空数据
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox8.Text <> "" And TextBox10.Text <> "" And TextBox12.Text <> "" Then
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

    Private Sub SerialPort1_DataReceived(sender As System.Object, e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())
    End Sub

    Private Sub ReceivedText(ByVal [text] As String) 'input from ReadExisting
        If Me.TextBox7.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.TextBox7.Text &= [text] 'append text

            'Dim rcv As Byte() = New Byte(2) {}

            'For i As Integer = 0 To 2
            '        rcv(i) = SerialPort1.ReadExisting
            'Next
            'TextBox7.Text = rcv(0)
            'TextBox9.Text = rcv(1)
            'TextBox11.Text = rcv(2)
        End If
    End Sub

    '上传按钮
    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        Dim com As MySqlCommand
        Dim dr As MySqlDataReader

        '数据库连接与操作
        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("INSERT INTO driver.称重管理 (车牌号,净重,时间,管理账户) VALUES ('" & TextBox7.Text & "','" & TextBox12.Text & "','" & TextBox9.Text & "','" & USERTextBox.Text & "')", conn)
            dr = com.ExecuteReader

            conn.Close()
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try

        SerialPort1.Close()

    End Sub

    '复位键
    Private Sub 复位LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles 复位LinkLabel.LinkClicked
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

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

    '修改车牌号界面
    '打开修改界面
    Private Sub 修改LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles 修改LinkLabel.LinkClicked
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        modifyPanel.Visible = True
    End Sub

    '确定修改车牌号
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        Dim com As MySqlCommand
        Dim dr As MySqlDataReader

        If modifyTextBox.Text <> "" Then
            '将修改后的车牌号传输到管理界面上
            TextBox7.Text = modifyTextBox.Text

            '清空管理界面的值
            If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox8.Text <> "" And TextBox10.Text <> "" And TextBox12.Text <> "" Then
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox8.Text = ""
                TextBox10.Text = ""
                TextBox12.Text = ""
            End If

            '管理界面数据库操作
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
                End While
                dr.Close()
            Catch myerror As MySqlException
                'MsgBox("Error connecting to the server:" & myerror.Message)
                MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
            End Try

            '重新计算货物重量
            Dim a As Single
            Dim b As Single
            If (TextBox11.Text <> "" And TextBox10.Text <> "") Then
                a = TextBox11.Text
                b = TextBox10.Text
                TextBox12.Text = a - b
            Else
                TextBox12.Text = ""
            End If

            '隐藏修改界面
            modifyPanel.Visible = False

            '当输入数据为空时
        Else
            MessageBox.Show("什么都没输入，快输入数据!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'MessageBox.Show("输入数据为空!", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    '取消修改
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        modifyPanel.Visible = False
    End Sub

    '-------------------------------------------

    '信息查询界面
    '点击“信息查询”（未选中）
    Private Sub mess0_Click(sender As Object, e As EventArgs) Handles mess0.Click
        '二级菜单
        wmess0.Visible = True
        wmess1.Visible = False
        cmess0.Visible = True
        cmess1.Visible = False
        dmess0.Visible = True
        dmess1.Visible = False

        messPanel.Visible = True
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        '一级菜单
        admin0.Visible = True
        admin1.Visible = False
        mess0.Visible = False
        mess1.Visible = True
        add0.Visible = True
        add1.Visible = False
        user0.Visible = True
        user1.Visible = False
        including0.Visible = True
        including1.Visible = False
    End Sub

    '点击“信息查询”（选中）
    Private Sub mess1_Click(sender As Object, e As EventArgs) Handles mess1.Click
        If messPanel.Visible = True Then
            messPanel.Visible = False
        Else
            messPanel.Visible = True
        End If
    End Sub

    '-------------------------------------------

    '称量信息查询界面
    '点击“称量信息查询界面”（未选中）
    Private Sub wmess0_Click(sender As Object, e As EventArgs) Handles wmess0.Click
        '二级菜单
        wmess0.Visible = False
        wmess1.Visible = True
        cmess0.Visible = True
        cmess1.Visible = False
        dmess0.Visible = True
        dmess1.Visible = False

        messPanel.Visible = False

        'panel容器
        adminPanel.Visible = False
        wPanel.Visible = True
        cmPanel.Visible = False
        dmPanel.Visible = False
        caddPanel.Visible = False
        daddPanel.Visible = False
        usermessPanel.Visible = False
        pwdPanel.Visible = False
        helpPanel.Visible = False
        suggestPanel.Visible = False
        aboutPanel.Visible = False
    End Sub

    '点击“称量信息查询界面”（选中）
    Private Sub wmess1_Click(sender As Object, e As EventArgs) Handles wmess1.Click
        messPanel.Visible = False
    End Sub

    '查询按钮
    Private Sub selectButton_Click(sender As Object, e As EventArgs) Handles selectButton.Click
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

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
                .Fill(TABLE)
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

    '-------------------------------------------

    '车辆信息查询界面
    '点击“车辆信息查询界面”（未选中）
    Private Sub cmess0_Click(sender As Object, e As EventArgs) Handles cmess0.Click
        '二级菜单
        wmess0.Visible = True
        wmess1.Visible = False
        cmess0.Visible = False
        cmess1.Visible = True
        dmess0.Visible = True
        dmess1.Visible = False

        messPanel.Visible = False

        'panel容器
        adminPanel.Visible = False
        wPanel.Visible = False
        cmPanel.Visible = True
        dmPanel.Visible = False
        caddPanel.Visible = False
        daddPanel.Visible = False
        usermessPanel.Visible = False
        pwdPanel.Visible = False
        helpPanel.Visible = False
        suggestPanel.Visible = False
        aboutPanel.Visible = False
    End Sub

    '点击“车辆信息查询界面”（选中）
    Private Sub cmess1_Click(sender As Object, e As EventArgs) Handles cmess1.Click
        messPanel.Visible = False
    End Sub

    '查询按钮
    Private Sub carselectButton_Click(sender As Object, e As EventArgs) Handles carselectButton.Click
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        If cmTextBox.Text <> "" Then
            TextBox13.Text = ""
            TextBox14.Text = ""
            TextBox15.Text = ""
            TextBox16.Text = ""
            TextBox17.Text = ""
        End If

        Dim com As MySqlCommand
        Dim dr As MySqlDataReader

        '数据库连接与操作
        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("Select * From 车辆 Where 车牌号='" & cmTextBox.Text & "'", conn)
            dr = com.ExecuteReader()
            While dr.Read()
                TextBox13.AppendText(dr!车牌号 & vbCrLf)
                TextBox14.AppendText(dr!车型 & vbCrLf)
                TextBox15.AppendText(dr!出厂日期 & vbCrLf)
                TextBox17.AppendText(dr!车重 & vbCrLf)
                TextBox16.AppendText(dr!核定载重 & vbCrLf)
            End While
            dr.Close()
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try
    End Sub

    '-------------------------------------------

    '司机信息查询界面
    '点击“司机信息查询界面”（未选中）
    Private Sub dmess0_Click(sender As Object, e As EventArgs) Handles dmess0.Click
        '二级菜单
        wmess0.Visible = True
        wmess1.Visible = False
        cmess0.Visible = True
        cmess1.Visible = False
        dmess0.Visible = False
        dmess1.Visible = True

        messPanel.Visible = False

        'panel容器
        adminPanel.Visible = False
        wPanel.Visible = False
        cmPanel.Visible = False
        dmPanel.Visible = True
        caddPanel.Visible = False
        daddPanel.Visible = False
        usermessPanel.Visible = False
        pwdPanel.Visible = False
        helpPanel.Visible = False
        suggestPanel.Visible = False
        aboutPanel.Visible = False
    End Sub

    '点击“司机信息查询界面”（选中）
    Private Sub dmess1_Click(sender As Object, e As EventArgs) Handles dmess1.Click
        messPanel.Visible = False
    End Sub

    '查询按钮
    Private Sub driverselectButton_Click(sender As Object, e As EventArgs) Handles driverselectButton.Click
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        If dmTextBox.Text <> "" Then
            TextBox18.Text = ""
            TextBox19.Text = ""
            TextBox20.Text = ""
            TextBox21.Text = ""
            TextBox22.Text = ""
            TextBox23.Text = ""
        End If

        Dim com As MySqlCommand
        Dim dr As MySqlDataReader

        '数据库连接与操作
        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("Select * From 司机 Where 驾驶证号='" & dmTextBox.Text & "'", conn)
            dr = com.ExecuteReader()
            While dr.Read()
                TextBox18.AppendText(dr!驾驶证号 & vbCrLf)
                TextBox19.AppendText(dr!姓名 & vbCrLf)
                TextBox20.AppendText(dr!出生日期 & vbCrLf)
                TextBox21.AppendText(dr!驾照类型 & vbCrLf)
                TextBox22.AppendText(dr!部门 & vbCrLf)
                TextBox23.AppendText(dr!联系电话 & vbCrLf)
            End While
            dr.Close()
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try

    End Sub

    '-------------------------------------------

    '信息录入界面
    '点击“信息录入界面”（未选中）
    Private Sub add0_Click(sender As Object, e As EventArgs) Handles add0.Click
        '二级菜单
        addcmess0.Visible = True
        addcmess1.Visible = False
        adddmess0.Visible = True
        adddmess1.Visible = False

        addPanel.Visible = True
        messPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        '一级菜单
        admin0.Visible = True
        admin1.Visible = False
        mess0.Visible = True
        mess1.Visible = False
        add0.Visible = False
        add1.Visible = True
        user0.Visible = True
        user1.Visible = False
        including0.Visible = True
        including1.Visible = False
    End Sub

    '点击“信息录入界面”（选中）
    Private Sub add1_Click(sender As Object, e As EventArgs) Handles add1.Click
        If addPanel.Visible = True Then
            addPanel.Visible = False
        Else
            addPanel.Visible = True
        End If
    End Sub

    '-------------------------------------------

    '车辆信息录入界面
    '点击“车辆信息录入界面”（未选中）
    Private Sub addcmess0_Click(sender As Object, e As EventArgs) Handles addcmess0.Click
        '二级菜单
        addcmess0.Visible = False
        addcmess1.Visible = True
        adddmess0.Visible = True
        adddmess1.Visible = False

        addPanel.Visible = False

        'panel容器
        adminPanel.Visible = False
        wPanel.Visible = False
        cmPanel.Visible = False
        dmPanel.Visible = False
        caddPanel.Visible = True
        daddPanel.Visible = False
        usermessPanel.Visible = False
        pwdPanel.Visible = False
        helpPanel.Visible = False
        suggestPanel.Visible = False
        aboutPanel.Visible = False
    End Sub

    '点击“车辆信息录入界面”（选中）
    Private Sub addcmess1_Click(sender As Object, e As EventArgs) Handles addcmess1.Click
        addPanel.Visible = False
    End Sub

    '上传按钮
    Private Sub carupdateButton_Click(sender As Object, e As EventArgs) Handles carupdateButton.Click
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        '插入图片
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
            com = New MySqlCommand("INSERT INTO driver.车辆 (车牌号,车型,出厂日期,车重,核定载重) VALUES ('" & TextBox24.Text & "','" & TextBox25.Text & "','" & TextBox26.Text & "','" & TextBox28.Text & "','" & TextBox27.Text & "')", conn)
            'com = New MySqlCommand("INSERT INTO driver.车辆 (车牌号,车型,出厂日期,车重,核定载重,照片) VALUES ('" & TextBox24.Text & "','" & TextBox25.Text & "','" & TextBox26.Text & "','" & TextBox28.Text & "','" & TextBox27.Text & "'，@Photo)", conn)
            'com.Parameters.AddWithValue("@Photo", arrImage)
            dr = com.ExecuteReader

            MessageBox.Show("数据存储成功！")

            conn.Close()
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try
    End Sub

    '照片添加按钮
    Private Sub pictureButton_Click(sender As Object, e As EventArgs) Handles pictureButton.Click
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        OpenDlg.Filter = "图片文件(*.jpg,*.gif,*.bmp)|*.jpg|*.gif|*.bmp"  '这是限定图片的格式
        If OpenDlg.ShowDialog() = DialogResult.OK Then
            Me.carPictureBox.Image = Image.FromFile(OpenDlg.FileName)
        End If
    End Sub

    '清空数据
    Private Sub clearLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles clearLinkLabel.LinkClicked
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        '清空数据
        TextBox24.Text = ""
        TextBox25.Text = ""
        TextBox26.Text = ""
        TextBox27.Text = ""
        TextBox28.Text = ""
    End Sub

    '-------------------------------------------

    '司机信息录入界面
    '点击“司机信息录入界面”（未选中）
    Private Sub adddmess0_Click(sender As Object, e As EventArgs) Handles adddmess0.Click
        '二级菜单
        addcmess0.Visible = True
        addcmess1.Visible = False
        adddmess0.Visible = False
        adddmess1.Visible = True

        addPanel.Visible = False

        'panel容器
        adminPanel.Visible = False
        wPanel.Visible = False
        cmPanel.Visible = False
        dmPanel.Visible = False
        caddPanel.Visible = False
        daddPanel.Visible = True
        usermessPanel.Visible = False
        pwdPanel.Visible = False
        helpPanel.Visible = False
        suggestPanel.Visible = False
        aboutPanel.Visible = False
    End Sub

    '点击“司机信息录入界面”（选中）
    Private Sub adddmess1_Click(sender As Object, e As EventArgs) Handles adddmess1.Click
        addPanel.Visible = False
    End Sub

    '上传按钮
    Private Sub driverupdateButton_Click(sender As Object, e As EventArgs) Handles driverupdateButton.Click
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        Dim com As MySqlCommand
        Dim dr As MySqlDataReader

        '数据库连接与操作
        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("INSERT INTO driver.司机 (驾驶证号,姓名,出生日期,驾照类型,部门,联系电话) VALUES ('" & TextBox29.Text & "','" & TextBox30.Text & "','" & TextBox31.Text & "','" & TextBox32.Text & "','" & TextBox33.Text & "','" & TextBox34.Text & "')", conn)
            dr = com.ExecuteReader

            MessageBox.Show("存储成功！")

            conn.Close()
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try

    End Sub

    '清空数据
    Private Sub clearLinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles clearLinkLabel2.LinkClicked
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        '清空数据
        TextBox29.Text = ""
        TextBox30.Text = ""
        TextBox31.Text = ""
        TextBox32.Text = ""
        TextBox33.Text = ""
        TextBox34.Text = ""
    End Sub

    '-------------------------------------------

    '个人中心界面
    '点击“个人中心界面”（未选中）
    Private Sub user0_Click(sender As Object, e As EventArgs) Handles user0.Click
        '二级菜单
        usermess0.Visible = True
        usermess1.Visible = False
        PWD0.Visible = True
        PWD1.Visible = False

        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = True
        includingPanel.Visible = False

        '一级菜单
        admin0.Visible = True
        admin1.Visible = False
        mess0.Visible = True
        mess1.Visible = False
        add0.Visible = True
        add1.Visible = False
        user0.Visible = False
        user1.Visible = True
        including0.Visible = True
        including1.Visible = False
    End Sub

    '点击“个人中心界面”（选中）
    Private Sub user1_Click(sender As Object, e As EventArgs) Handles user1.Click
        If userPanel.Visible = True Then
            userPanel.Visible = False
        Else
            userPanel.Visible = True
        End If
    End Sub

    '-------------------------------------------

    '用户信息界面
    '点击“用户信息界面”（未选中）
    Private Sub usermess0_Click(sender As Object, e As EventArgs) Handles usermess0.Click
        '二级菜单
        usermess0.Visible = False
        usermess1.Visible = True
        PWD0.Visible = True
        PWD1.Visible = False

        userPanel.Visible = False

        'panel容器
        adminPanel.Visible = False
        wPanel.Visible = False
        cmPanel.Visible = False
        dmPanel.Visible = False
        caddPanel.Visible = False
        daddPanel.Visible = False
        usermessPanel.Visible = True
        pwdPanel.Visible = False
        helpPanel.Visible = False
        suggestPanel.Visible = False
        aboutPanel.Visible = False

    End Sub

    '点击“用户信息界面”（选中）
    Private Sub usermess1_Click(sender As Object, e As EventArgs) Handles usermess1.Click
        userPanel.Visible = False
    End Sub

    '“用户信息界面”数据展现
    Private Sub usermessPanel_Paint(sender As Object, e As PaintEventArgs) Handles usermessPanel.Paint
        Dim com As MySqlCommand
        Dim dr As MySqlDataReader

        '数据库连接与操作
        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("Select * From 用户 Where 账号='" & USERTextBox.Text & "'", conn)
            dr = com.ExecuteReader()
            While dr.Read()
                usernameTextBox.Text = dr!姓名 & vbCrLf
                nameTextBox.Text = dr!账号 & vbCrLf
                accessTextBox.Text = dr!权限 & vbCrLf
            End While
            dr.Close()
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try
    End Sub

    '注销账号
    Private Sub signoutLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signoutLinkLabel.LinkClicked
        MsgBox("常来玩啊！我会想念你的！(≧ω≦)")

        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        '清空登录界面数据
        USERTextBox.Text = ""
        PasswordTextBox.Text = ""

        loginPanel.Visible = True
        menuPanel.Visible = False
        usermessPanel.Visible = False
    End Sub

    '-------------------------------------------

    '修改密码界面
    '点击“修改密码界面”（未选中）
    Private Sub PWD0_Click(sender As Object, e As EventArgs) Handles PWD0.Click
        '二级菜单
        usermess0.Visible = True
        usermess1.Visible = False
        PWD0.Visible = False
        PWD1.Visible = True

        userPanel.Visible = False

        'panel容器
        adminPanel.Visible = False
        wPanel.Visible = False
        cmPanel.Visible = False
        dmPanel.Visible = False
        caddPanel.Visible = False
        daddPanel.Visible = False
        usermessPanel.Visible = False
        pwdPanel.Visible = True
        helpPanel.Visible = False
        suggestPanel.Visible = False
        aboutPanel.Visible = False
    End Sub

    '点击“修改密码界面”（选中）
    Private Sub PWD1_Click(sender As Object, e As EventArgs) Handles PWD1.Click
        userPanel.Visible = False
    End Sub

    '确认修改密码
    Private Sub pwdOK_Click(sender As Object, e As EventArgs) Handles pwdOK.Click
        '二级菜单
        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = False

        '数据库操作
        Dim com As MySqlCommand
        Dim dr As MySqlDataReader

        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("Select * From 用户 Where 账号='" & USERTextBox.Text & "' And 密码='" & oldpwdTextBox.Text & "'", conn)
            dr = com.ExecuteReader()
            If dr.Read() Then ' 表示有找到通过验证
                conn.Close()
                If newpwdagainTextBox.Text = newpwdTextBox.Text Then

                    If newpwdagainTextBox.Text = oldpwdTextBox.Text Then
                        MessageBox.Show("新密码与旧密码一致，请重新输入！", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        oldpwdTextBox.TabIndex = 4
                        newpwdTextBox.TabIndex = 1
                        newpwdagainTextBox.TabIndex = 2
                        pwdOK.TabIndex = 3
                    Else
                        change_password()

                        'MessageBox.Show("恭喜，你居然能成功修改密码！")
                        MessageBox.Show("修改密码成功！")

                        oldpwdTextBox.Text = ""
                        newpwdTextBox.Text = ""
                        newpwdagainTextBox.Text = ""
                        oldpwdTextBox.TabIndex = 1
                        newpwdTextBox.TabIndex = 2
                        newpwdagainTextBox.TabIndex = 3
                        pwdOK.TabIndex = 4
                    End If

                Else
                    MessageBox.Show("笨蛋，两次密码输入不一致，快重新输入！", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'MessageBox.Show("两次密码输入不一致，请重新输入！", "错误提示!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    oldpwdTextBox.TabIndex = 4
                    newpwdTextBox.TabIndex = 1
                    newpwdagainTextBox.TabIndex = 2
                    pwdOK.TabIndex = 3
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
        Dim com As MySqlCommand
        Dim dr As MySqlDataReader

        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()

            com = New MySqlCommand("UPDATE driver.用户 SET 密码 = '" & newpwdagainTextBox.Text & "' WHERE 账号='" & USERTextBox.Text & "'", conn)
            dr = com.ExecuteReader
            conn.Close()

        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try
    End Sub

    '-------------------------------------------

    '系统说明界面
    '点击“系统说明界面”（未选中）
    Private Sub including0_Click(sender As Object, e As EventArgs) Handles including0.Click
        '二级菜单
        help0.Visible = True
        help1.Visible = False
        suggest0.Visible = True
        suggest1.Visible = False
        about0.Visible = True
        about1.Visible = False

        messPanel.Visible = False
        addPanel.Visible = False
        userPanel.Visible = False
        includingPanel.Visible = True

        '一级菜单
        admin0.Visible = True
        admin1.Visible = False
        mess0.Visible = True
        mess1.Visible = False
        add0.Visible = True
        add1.Visible = False
        user0.Visible = True
        user1.Visible = False
        including0.Visible = False
        including1.Visible = True
    End Sub

    '点击“系统说明界面”（选中）
    Private Sub including1_Click(sender As Object, e As EventArgs) Handles including1.Click
        If includingPanel.Visible = True Then
            includingPanel.Visible = False
        Else
            includingPanel.Visible = True
        End If
    End Sub

    '-------------------------------------------

    '使用帮助界面
    '点击“使用帮助界面”（未选中）
    Private Sub help0_Click(sender As Object, e As EventArgs) Handles help0.Click
        '二级菜单
        help0.Visible = False
        help1.Visible = True
        suggest0.Visible = True
        suggest1.Visible = False
        about0.Visible = True
        about1.Visible = False

        includingPanel.Visible = False

        'panel容器
        adminPanel.Visible = False
        wPanel.Visible = False
        cmPanel.Visible = False
        dmPanel.Visible = False
        caddPanel.Visible = False
        daddPanel.Visible = False
        usermessPanel.Visible = False
        pwdPanel.Visible = False
        helpPanel.Visible = True
        suggestPanel.Visible = False
        aboutPanel.Visible = False
    End Sub

    '点击“使用帮助界面”（选中）
    Private Sub help1_Click(sender As Object, e As EventArgs) Handles help1.Click
        includingPanel.Visible = False
    End Sub

    '-------------------------------------------

    '意见反馈界面
    '点击“意见反馈界面”（未选中）
    Private Sub suggest0_Click(sender As Object, e As EventArgs) Handles suggest0.Click
        '二级菜单
        help0.Visible = True
        help1.Visible = False
        suggest0.Visible = False
        suggest1.Visible = True
        about0.Visible = True
        about1.Visible = False

        includingPanel.Visible = False

        'panel容器
        adminPanel.Visible = False
        wPanel.Visible = False
        cmPanel.Visible = False
        dmPanel.Visible = False
        caddPanel.Visible = False
        daddPanel.Visible = False
        usermessPanel.Visible = False
        pwdPanel.Visible = False
        helpPanel.Visible = False
        suggestPanel.Visible = True
        aboutPanel.Visible = False
    End Sub

    '点击“意见反馈界面”（选中）
    Private Sub suggest1_Click(sender As Object, e As EventArgs) Handles suggest1.Click
        includingPanel.Visible = False
    End Sub

    '-------------------------------------------

    '关于界面
    '点击“关于界面”（未选中）
    Private Sub about0_Click(sender As Object, e As EventArgs) Handles about0.Click
        '二级菜单
        help0.Visible = True
        help1.Visible = False
        suggest0.Visible = True
        suggest1.Visible = False
        about0.Visible = False
        about1.Visible = True

        includingPanel.Visible = False

        'panel容器
        adminPanel.Visible = False
        wPanel.Visible = False
        cmPanel.Visible = False
        dmPanel.Visible = False
        caddPanel.Visible = False
        daddPanel.Visible = False
        usermessPanel.Visible = False
        pwdPanel.Visible = False
        helpPanel.Visible = False
        suggestPanel.Visible = False
        aboutPanel.Visible = True
    End Sub

    '点击“关于界面”（选中）
    Private Sub about1_Click(sender As Object, e As EventArgs) Handles about1.Click
        includingPanel.Visible = False
    End Sub

End Class
﻿Imports MySql.Data.MySqlClient
Public Class CMessage
    Dim conn As MySqlConnection
    Dim data As DataTable
    Dim da As MySqlDataAdapter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
        End If

        Dim com As MySqlCommand
        Dim dr As MySqlDataReader

        '数据库连接与操作
        Try
            conn = New MySqlConnection("Data source=localhost;Initial Catalog=driver;" + "User ID=root;PWD=admin")
            conn.Open()
            com = New MySqlCommand("Select * From 车辆 Where 车牌号='" & TextBox1.Text & "'", conn)
            dr = com.ExecuteReader()
            While dr.Read()
                TextBox2.AppendText(dr!车牌号 & vbCrLf)
                TextBox3.AppendText(dr!车型 & vbCrLf)
                TextBox4.AppendText(dr!出厂日期 & vbCrLf)
                TextBox6.AppendText(dr!车重 & vbCrLf)
                TextBox5.AppendText(dr!核定载重 & vbCrLf)
            End While
            dr.Close()
        Catch myerror As MySqlException
            'MsgBox("Error connecting to the server:" & myerror.Message)
            MsgBox("数据库连接出错啦~~来看看错在哪里（前提是你这个笨蛋能看得懂！  ╮(╯▽╰)╭ ）:" & myerror.Message)
        End Try

    End Sub

    Private Sub CMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button1
    End Sub
End Class
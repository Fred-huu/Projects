<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class administer
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(administer))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.维护ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.数据修改ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.信息录入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.司机信息录入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.车辆信息录入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复位ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.修改密码ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.注销ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.使用说明ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.意见反馈ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.司机信息查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.车辆信息查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.称重历史查询ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.UserLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(375, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "启动(&S)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button2.Location = New System.Drawing.Point(200, 410)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 33)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "上传(&U)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label16.Location = New System.Drawing.Point(290, 150)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 31)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "称量信息"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(30, 335)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 18)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "驾照类型"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(30, 370)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 18)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "联系电话"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 300)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 18)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "部门"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "出生日期"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(290, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "汽车类型"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 18)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "姓名"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 18)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "驾驶证号"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(115, 365)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(150, 28)
        Me.TextBox6.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(290, 335)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "车辆毛重"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(290, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 18)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "车牌号"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 31)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "司机信息"
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(375, 225)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(89, 28)
        Me.TextBox8.TabIndex = 36
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(375, 190)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(89, 28)
        Me.TextBox7.TabIndex = 37
        Me.TextBox7.Text = "123"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(115, 260)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(150, 28)
        Me.TextBox3.TabIndex = 41
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(115, 295)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(150, 28)
        Me.TextBox4.TabIndex = 42
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(115, 330)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(150, 28)
        Me.TextBox5.TabIndex = 43
        '
        'TextBox9
        '
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(375, 260)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(89, 28)
        Me.TextBox9.TabIndex = 38
        Me.TextBox9.Text = "2016-3-10"
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(375, 295)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(89, 28)
        Me.TextBox10.TabIndex = 46
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(290, 370)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 18)
        Me.Label17.TabIndex = 47
        Me.Label17.Text = "货物净重"
        '
        'TextBox11
        '
        Me.TextBox11.Enabled = False
        Me.TextBox11.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBox11.Location = New System.Drawing.Point(375, 330)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(89, 28)
        Me.TextBox11.TabIndex = 49
        Me.TextBox11.Text = "50"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(290, 300)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 18)
        Me.Label19.TabIndex = 50
        Me.Label19.Text = "车辆皮重"
        '
        'TextBox12
        '
        Me.TextBox12.Enabled = False
        Me.TextBox12.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.TextBox12.Location = New System.Drawing.Point(375, 365)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(89, 28)
        Me.TextBox12.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(290, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "称量时间"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(465, 370)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 18)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "t"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(465, 335)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 18)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "t"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(465, 300)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(17, 18)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "t"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        '维护ToolStripMenuItem
        '
        Me.维护ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.数据修改ToolStripMenuItem, Me.信息录入ToolStripMenuItem, Me.复位ToolStripMenuItem, Me.ToolStripSeparator3, Me.修改密码ToolStripMenuItem, Me.注销ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.维护ToolStripMenuItem.Name = "维护ToolStripMenuItem"
        Me.维护ToolStripMenuItem.Size = New System.Drawing.Size(88, 28)
        Me.维护ToolStripMenuItem.Text = "管理(&M)"
        '
        '数据修改ToolStripMenuItem
        '
        Me.数据修改ToolStripMenuItem.Name = "数据修改ToolStripMenuItem"
        Me.数据修改ToolStripMenuItem.Size = New System.Drawing.Size(219, 30)
        Me.数据修改ToolStripMenuItem.Text = "信息修改"
        '
        '信息录入ToolStripMenuItem
        '
        Me.信息录入ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.司机信息录入ToolStripMenuItem, Me.车辆信息录入ToolStripMenuItem})
        Me.信息录入ToolStripMenuItem.Name = "信息录入ToolStripMenuItem"
        Me.信息录入ToolStripMenuItem.Size = New System.Drawing.Size(219, 30)
        Me.信息录入ToolStripMenuItem.Text = "信息录入"
        '
        '司机信息录入ToolStripMenuItem
        '
        Me.司机信息录入ToolStripMenuItem.Name = "司机信息录入ToolStripMenuItem"
        Me.司机信息录入ToolStripMenuItem.Size = New System.Drawing.Size(201, 30)
        Me.司机信息录入ToolStripMenuItem.Text = "司机信息录入"
        '
        '车辆信息录入ToolStripMenuItem
        '
        Me.车辆信息录入ToolStripMenuItem.Name = "车辆信息录入ToolStripMenuItem"
        Me.车辆信息录入ToolStripMenuItem.Size = New System.Drawing.Size(201, 30)
        Me.车辆信息录入ToolStripMenuItem.Text = "车辆信息录入"
        '
        '复位ToolStripMenuItem
        '
        Me.复位ToolStripMenuItem.Name = "复位ToolStripMenuItem"
        Me.复位ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.复位ToolStripMenuItem.Size = New System.Drawing.Size(219, 30)
        Me.复位ToolStripMenuItem.Text = "复位(&R)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(216, 6)
        '
        '修改密码ToolStripMenuItem
        '
        Me.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem"
        Me.修改密码ToolStripMenuItem.Size = New System.Drawing.Size(219, 30)
        Me.修改密码ToolStripMenuItem.Text = "修改密码"
        '
        '注销ToolStripMenuItem
        '
        Me.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem"
        Me.注销ToolStripMenuItem.Size = New System.Drawing.Size(219, 30)
        Me.注销ToolStripMenuItem.Text = "注销"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(219, 30)
        Me.退出ToolStripMenuItem.Text = "退出(&E)"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.使用说明ToolStripMenuItem, Me.意见反馈ToolStripMenuItem, Me.关于ToolStripMenuItem})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(84, 28)
        Me.帮助ToolStripMenuItem.Text = "帮助(&H)"
        '
        '使用说明ToolStripMenuItem
        '
        Me.使用说明ToolStripMenuItem.Name = "使用说明ToolStripMenuItem"
        Me.使用说明ToolStripMenuItem.Size = New System.Drawing.Size(165, 30)
        Me.使用说明ToolStripMenuItem.Text = "使用说明"
        '
        '意见反馈ToolStripMenuItem
        '
        Me.意见反馈ToolStripMenuItem.Name = "意见反馈ToolStripMenuItem"
        Me.意见反馈ToolStripMenuItem.Size = New System.Drawing.Size(165, 30)
        Me.意见反馈ToolStripMenuItem.Text = "意见反馈"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(165, 30)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.维护ToolStripMenuItem, Me.查询ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(828, 32)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '查询ToolStripMenuItem
        '
        Me.查询ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.司机信息查询ToolStripMenuItem, Me.车辆信息查询ToolStripMenuItem, Me.称重历史查询ToolStripMenuItem})
        Me.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem"
        Me.查询ToolStripMenuItem.Size = New System.Drawing.Size(75, 28)
        Me.查询ToolStripMenuItem.Text = "查询(&I)"
        '
        '司机信息查询ToolStripMenuItem
        '
        Me.司机信息查询ToolStripMenuItem.Name = "司机信息查询ToolStripMenuItem"
        Me.司机信息查询ToolStripMenuItem.Size = New System.Drawing.Size(201, 30)
        Me.司机信息查询ToolStripMenuItem.Text = "司机信息查询"
        '
        '车辆信息查询ToolStripMenuItem
        '
        Me.车辆信息查询ToolStripMenuItem.Name = "车辆信息查询ToolStripMenuItem"
        Me.车辆信息查询ToolStripMenuItem.Size = New System.Drawing.Size(201, 30)
        Me.车辆信息查询ToolStripMenuItem.Text = "车辆信息查询"
        '
        '称重历史查询ToolStripMenuItem
        '
        Me.称重历史查询ToolStripMenuItem.Name = "称重历史查询ToolStripMenuItem"
        Me.称重历史查询ToolStripMenuItem.Size = New System.Drawing.Size(201, 30)
        Me.称重历史查询ToolStripMenuItem.Text = "称重历史查询"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(115, 190)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 28)
        Me.TextBox1.TabIndex = 61
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(115, 225)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(150, 28)
        Me.TextBox2.TabIndex = 62
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Location = New System.Drawing.Point(88, 467)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(62, 18)
        Me.UserLabel.TabIndex = 63
        Me.UserLabel.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 467)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "用户名："
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(30, 105)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 18)
        Me.Label18.TabIndex = 68
        Me.Label18.Text = "波特率"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(30, 65)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 18)
        Me.Label21.TabIndex = 67
        Me.Label21.Text = "端口"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"110", "300", "600", "1200", "2400", "4800", "9600", "19200", "38400", "56000", "57600", "115200"})
        Me.ComboBox2.Location = New System.Drawing.Point(115, 100)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(180, 26)
        Me.ComboBox2.TabIndex = 66
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(115, 61)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 26)
        Me.ComboBox1.TabIndex = 65
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(520, 75)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 318)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(520, 406)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 18)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "车辆照片"
        '
        'administer
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(828, 494)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(22, 56)
        Me.Name = "administer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "汽车衡称重系统手动管理界面"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents 维护ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 数据修改ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 复位ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 使用说明ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 意见反馈ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 查询ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 司机信息查询ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 车辆信息查询ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 称重历史查询ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 信息录入ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 司机信息录入ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 车辆信息录入ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents UserLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents 注销ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents 修改密码ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class autoadmin
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(autoadmin))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.暂停ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.模式切换ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.手动模式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复位ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.注销ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.使用说明ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.意见反馈ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.时间 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.姓名 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.驾驶证号 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.电话 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.车牌号 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.汽型 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.皮重 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.毛重 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.净重 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.部门 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.UserLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 381)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 18)
        Me.Label12.TabIndex = 97
        Me.Label12.Text = "称量照片"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(23, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 318)
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.暂停ToolStripMenuItem, Me.模式切换ToolStripMenuItem, Me.复位ToolStripMenuItem, Me.注销ToolStripMenuItem, Me.退出ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1898, 32)
        Me.MenuStrip1.TabIndex = 63
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '暂停ToolStripMenuItem
        '
        Me.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem"
        Me.暂停ToolStripMenuItem.Size = New System.Drawing.Size(124, 28)
        Me.暂停ToolStripMenuItem.Text = "暂停/继续(&S)"
        '
        '模式切换ToolStripMenuItem
        '
        Me.模式切换ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.手动模式ToolStripMenuItem})
        Me.模式切换ToolStripMenuItem.Name = "模式切换ToolStripMenuItem"
        Me.模式切换ToolStripMenuItem.Size = New System.Drawing.Size(118, 28)
        Me.模式切换ToolStripMenuItem.Text = "模式切换(&C)"
        '
        '手动模式ToolStripMenuItem
        '
        Me.手动模式ToolStripMenuItem.Name = "手动模式ToolStripMenuItem"
        Me.手动模式ToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.手动模式ToolStripMenuItem.Text = "手动模式"
        '
        '复位ToolStripMenuItem
        '
        Me.复位ToolStripMenuItem.Name = "复位ToolStripMenuItem"
        Me.复位ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.复位ToolStripMenuItem.Size = New System.Drawing.Size(82, 28)
        Me.复位ToolStripMenuItem.Text = "复位(&R)"
        '
        '注销ToolStripMenuItem
        '
        Me.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem"
        Me.注销ToolStripMenuItem.Size = New System.Drawing.Size(85, 28)
        Me.注销ToolStripMenuItem.Text = "注销(&O)"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(80, 28)
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
        Me.使用说明ToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.使用说明ToolStripMenuItem.Text = "使用说明"
        '
        '意见反馈ToolStripMenuItem
        '
        Me.意见反馈ToolStripMenuItem.Name = "意见反馈ToolStripMenuItem"
        Me.意见反馈ToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.意见反馈ToolStripMenuItem.Text = "意见反馈"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(211, 30)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        'ListView1
        '
        Me.ListView1.BackgroundImageTiled = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.时间, Me.姓名, Me.驾驶证号, Me.部门, Me.电话, Me.车牌号, Me.汽型, Me.皮重, Me.毛重, Me.净重})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(296, 50)
        Me.ListView1.MinimumSize = New System.Drawing.Size(4, 4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(950, 400)
        Me.ListView1.TabIndex = 98
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        '时间
        '
        Me.时间.Text = "称量时间"
        Me.时间.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.时间.Width = 75
        '
        '姓名
        '
        Me.姓名.Text = "司机姓名"
        Me.姓名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '驾驶证号
        '
        Me.驾驶证号.Text = "驾驶证号"
        Me.驾驶证号.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.驾驶证号.Width = 75
        '
        '电话
        '
        Me.电话.Text = "联系电话"
        Me.电话.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.电话.Width = 85
        '
        '车牌号
        '
        Me.车牌号.Text = "车牌号"
        Me.车牌号.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.车牌号.Width = 65
        '
        '汽型
        '
        Me.汽型.Text = "汽车类型"
        Me.汽型.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '皮重
        '
        Me.皮重.Text = "皮重(t)"
        Me.皮重.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.皮重.Width = 55
        '
        '毛重
        '
        Me.毛重.Text = "毛重(t)"
        Me.毛重.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.毛重.Width = 55
        '
        '净重
        '
        Me.净重.Text = "净重(t)"
        Me.净重.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.净重.Width = 55
        '
        'Timer1
        '
        '
        '部门
        '
        Me.部门.Text = "部门"
        Me.部门.Width = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 457)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "用户名："
        '
        'UserLabel
        '
        Me.UserLabel.AutoSize = True
        Me.UserLabel.Location = New System.Drawing.Point(88, 457)
        Me.UserLabel.Name = "UserLabel"
        Me.UserLabel.Size = New System.Drawing.Size(62, 18)
        Me.UserLabel.TabIndex = 99
        Me.UserLabel.Text = "Label2"
        '
        'autoadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1898, 484)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserLabel)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "autoadmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "汽车衡智能称重系统自动管理界面"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 使用说明ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 意见反馈ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListView1 As ListView
    Friend WithEvents 车牌号 As ColumnHeader
    Friend WithEvents 时间 As ColumnHeader
    Friend WithEvents 毛重 As ColumnHeader
    Friend WithEvents 净重 As ColumnHeader
    Friend WithEvents 姓名 As ColumnHeader
    Friend WithEvents 驾驶证号 As ColumnHeader
    Friend WithEvents 电话 As ColumnHeader
    Friend WithEvents 汽型 As ColumnHeader
    Friend WithEvents 皮重 As ColumnHeader
    Friend WithEvents 暂停ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 模式切换ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 手动模式ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 复位ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 注销ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents 部门 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents UserLabel As Label
End Class

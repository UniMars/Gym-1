﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeptManagement_UI
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeptManagement_UI))
        Me.Root = New System.Windows.Forms.SplitContainer()
        Me.HomepageLink = New System.Windows.Forms.LinkLabel()
        Me.LogoutLink = New System.Windows.Forms.LinkLabel()
        Me.UserName = New System.Windows.Forms.Label()
        Me.WelcomeText = New System.Windows.Forms.Label()
        Me.DeptManagementUIText = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToAlterStatus = New System.Windows.Forms.Button()
        Me.ToConfirmMaintain = New System.Windows.Forms.Button()
        Me.AlterStatusPanel = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ConfirmMaintainPanel = New System.Windows.Forms.Panel()
        Me.Confirm = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToConfirmGame = New System.Windows.Forms.Button()
        Me.ConfirmGamePanel = New System.Windows.Forms.Panel()
        Me.ConfirmGame = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Root.Panel1.SuspendLayout()
        Me.Root.Panel2.SuspendLayout()
        Me.Root.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.AlterStatusPanel.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConfirmMaintainPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ConfirmGamePanel.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Root
        '
        Me.Root.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Root.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Root.IsSplitterFixed = True
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Root.Panel1
        '
        Me.Root.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Root.Panel1.Controls.Add(Me.HomepageLink)
        Me.Root.Panel1.Controls.Add(Me.LogoutLink)
        Me.Root.Panel1.Controls.Add(Me.UserName)
        Me.Root.Panel1.Controls.Add(Me.WelcomeText)
        Me.Root.Panel1.Controls.Add(Me.DeptManagementUIText)
        Me.Root.Panel1MinSize = 50
        '
        'Root.Panel2
        '
        Me.Root.Panel2.Controls.Add(Me.SplitContainer1)
        Me.Root.Size = New System.Drawing.Size(865, 500)
        Me.Root.SplitterDistance = 52
        Me.Root.SplitterWidth = 1
        Me.Root.TabIndex = 0
        '
        'HomepageLink
        '
        Me.HomepageLink.ActiveLinkColor = System.Drawing.Color.White
        Me.HomepageLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomepageLink.AutoSize = True
        Me.HomepageLink.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.HomepageLink.LinkColor = System.Drawing.Color.DarkBlue
        Me.HomepageLink.Location = New System.Drawing.Point(823, 2)
        Me.HomepageLink.Name = "HomepageLink"
        Me.HomepageLink.Size = New System.Drawing.Size(42, 22)
        Me.HomepageLink.TabIndex = 9
        Me.HomepageLink.TabStop = True
        Me.HomepageLink.Text = "主页"
        '
        'LogoutLink
        '
        Me.LogoutLink.ActiveLinkColor = System.Drawing.Color.White
        Me.LogoutLink.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoutLink.AutoSize = True
        Me.LogoutLink.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LogoutLink.LinkColor = System.Drawing.Color.DarkBlue
        Me.LogoutLink.Location = New System.Drawing.Point(823, 25)
        Me.LogoutLink.Name = "LogoutLink"
        Me.LogoutLink.Size = New System.Drawing.Size(42, 22)
        Me.LogoutLink.TabIndex = 7
        Me.LogoutLink.TabStop = True
        Me.LogoutLink.Text = "退出"
        '
        'UserName
        '
        Me.UserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserName.AutoSize = True
        Me.UserName.ForeColor = System.Drawing.Color.White
        Me.UserName.Location = New System.Drawing.Point(774, 27)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(41, 12)
        Me.UserName.TabIndex = 5
        Me.UserName.Text = "某某某"
        '
        'WelcomeText
        '
        Me.WelcomeText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WelcomeText.AutoSize = True
        Me.WelcomeText.ForeColor = System.Drawing.Color.White
        Me.WelcomeText.Location = New System.Drawing.Point(774, 9)
        Me.WelcomeText.Name = "WelcomeText"
        Me.WelcomeText.Size = New System.Drawing.Size(29, 12)
        Me.WelcomeText.TabIndex = 4
        Me.WelcomeText.Text = "你好"
        '
        'DeptManagementUIText
        '
        Me.DeptManagementUIText.AutoSize = True
        Me.DeptManagementUIText.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.DeptManagementUIText.ForeColor = System.Drawing.Color.Navy
        Me.DeptManagementUIText.Location = New System.Drawing.Point(12, 12)
        Me.DeptManagementUIText.Name = "DeptManagementUIText"
        Me.DeptManagementUIText.Size = New System.Drawing.Size(105, 27)
        Me.DeptManagementUIText.TabIndex = 0
        Me.DeptManagementUIText.Text = "管理部门专区"
        Me.DeptManagementUIText.UseCompatibleTextRendering = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToConfirmGame)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToAlterStatus)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToConfirmMaintain)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ConfirmMaintainPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ConfirmGamePanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AlterStatusPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(865, 447)
        Me.SplitContainer1.SplitterDistance = 108
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'ToAlterStatus
        '
        Me.ToAlterStatus.BackColor = System.Drawing.Color.AliceBlue
        Me.ToAlterStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToAlterStatus.Location = New System.Drawing.Point(0, 42)
        Me.ToAlterStatus.Name = "ToAlterStatus"
        Me.ToAlterStatus.Size = New System.Drawing.Size(108, 23)
        Me.ToAlterStatus.TabIndex = 10
        Me.ToAlterStatus.Text = "更改状态"
        Me.ToAlterStatus.UseVisualStyleBackColor = False
        '
        'ToConfirmMaintain
        '
        Me.ToConfirmMaintain.BackColor = System.Drawing.Color.AliceBlue
        Me.ToConfirmMaintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToConfirmMaintain.Location = New System.Drawing.Point(0, 0)
        Me.ToConfirmMaintain.Name = "ToConfirmMaintain"
        Me.ToConfirmMaintain.Size = New System.Drawing.Size(108, 23)
        Me.ToConfirmMaintain.TabIndex = 9
        Me.ToConfirmMaintain.Text = "确认报修"
        Me.ToConfirmMaintain.UseVisualStyleBackColor = False
        '
        'AlterStatusPanel
        '
        Me.AlterStatusPanel.Controls.Add(Me.DataGridView2)
        Me.AlterStatusPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlterStatusPanel.Location = New System.Drawing.Point(0, 0)
        Me.AlterStatusPanel.Name = "AlterStatusPanel"
        Me.AlterStatusPanel.Size = New System.Drawing.Size(756, 447)
        Me.AlterStatusPanel.TabIndex = 1
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(252, 154)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 23
        Me.DataGridView2.Size = New System.Drawing.Size(392, 250)
        Me.DataGridView2.TabIndex = 0
        '
        'ConfirmMaintainPanel
        '
        Me.ConfirmMaintainPanel.Controls.Add(Me.Confirm)
        Me.ConfirmMaintainPanel.Controls.Add(Me.DataGridView1)
        Me.ConfirmMaintainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConfirmMaintainPanel.Location = New System.Drawing.Point(0, 0)
        Me.ConfirmMaintainPanel.Name = "ConfirmMaintainPanel"
        Me.ConfirmMaintainPanel.Size = New System.Drawing.Size(756, 447)
        Me.ConfirmMaintainPanel.TabIndex = 0
        '
        'Confirm
        '
        Me.Confirm.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Confirm.Location = New System.Drawing.Point(357, 56)
        Me.Confirm.Name = "Confirm"
        Me.Confirm.Size = New System.Drawing.Size(75, 23)
        Me.Confirm.TabIndex = 10
        Me.Confirm.Text = "确认"
        Me.Confirm.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(147, 164)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(456, 199)
        Me.DataGridView1.TabIndex = 0
        '
        'ToConfirmGame
        '
        Me.ToConfirmGame.BackColor = System.Drawing.Color.AliceBlue
        Me.ToConfirmGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ToConfirmGame.Location = New System.Drawing.Point(0, 22)
        Me.ToConfirmGame.Name = "ToConfirmGame"
        Me.ToConfirmGame.Size = New System.Drawing.Size(108, 23)
        Me.ToConfirmGame.TabIndex = 11
        Me.ToConfirmGame.Text = "确认比赛"
        Me.ToConfirmGame.UseVisualStyleBackColor = False
        '
        'ConfirmGamePanel
        '
        Me.ConfirmGamePanel.Controls.Add(Me.ConfirmGame)
        Me.ConfirmGamePanel.Controls.Add(Me.DataGridView3)
        Me.ConfirmGamePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConfirmGamePanel.Location = New System.Drawing.Point(0, 0)
        Me.ConfirmGamePanel.Name = "ConfirmGamePanel"
        Me.ConfirmGamePanel.Size = New System.Drawing.Size(756, 447)
        Me.ConfirmGamePanel.TabIndex = 1
        '
        'ConfirmGame
        '
        Me.ConfirmGame.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ConfirmGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ConfirmGame.Location = New System.Drawing.Point(360, 70)
        Me.ConfirmGame.Name = "ConfirmGame"
        Me.ConfirmGame.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmGame.TabIndex = 12
        Me.ConfirmGame.Text = "确认"
        Me.ConfirmGame.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(150, 178)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 23
        Me.DataGridView3.Size = New System.Drawing.Size(456, 199)
        Me.DataGridView3.TabIndex = 11
        '
        'DeptManagement_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(865, 500)
        Me.Controls.Add(Me.Root)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(750, 500)
        Me.Name = "DeptManagement_UI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeptManagement_UI"
        Me.Root.Panel1.ResumeLayout(False)
        Me.Root.Panel1.PerformLayout()
        Me.Root.Panel2.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Root.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.AlterStatusPanel.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConfirmMaintainPanel.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ConfirmGamePanel.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Root As Windows.Forms.SplitContainer
    Public WithEvents DeptManagementUIText As Windows.Forms.Label
    Friend WithEvents UserName As Windows.Forms.Label
    Friend WithEvents WelcomeText As Windows.Forms.Label
    Friend WithEvents LogoutLink As Windows.Forms.LinkLabel
    Friend WithEvents HomepageLink As Windows.Forms.LinkLabel
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents ToAlterStatus As Windows.Forms.Button
    Friend WithEvents ToConfirmMaintain As Windows.Forms.Button
    Friend WithEvents AlterStatusPanel As Windows.Forms.Panel
    Friend WithEvents ConfirmMaintainPanel As Windows.Forms.Panel
    Friend WithEvents DataGridView1 As Windows.Forms.DataGridView
    Friend WithEvents Confirm As Windows.Forms.Button
    Friend WithEvents DataGridView2 As Windows.Forms.DataGridView
    Friend WithEvents ToConfirmGame As Windows.Forms.Button
    Friend WithEvents ConfirmGamePanel As Windows.Forms.Panel
    Friend WithEvents ConfirmGame As Windows.Forms.Button
    Friend WithEvents DataGridView3 As Windows.Forms.DataGridView
End Class

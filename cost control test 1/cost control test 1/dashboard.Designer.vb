﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_admin = New System.Windows.Forms.Button()
        Me.btn_dash = New System.Windows.Forms.Button()
        Me.btn_inven = New System.Windows.Forms.Button()
        Me.btn_cost_menu = New System.Windows.Forms.Button()
        Me.jam = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.status_trip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.hari_tgl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.panel_cost_control = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pnl_inven = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panel_dash = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panel_admin = New System.Windows.Forms.Panel()
        Me.btn_dash_tender = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.status_trip.SuspendLayout()
        Me.panel_cost_control.SuspendLayout()
        Me.pnl_inven.SuspendLayout()
        Me.panel_dash.SuspendLayout()
        Me.panel_admin.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem1, Me.MasterDataAdminToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(861, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ToolStripSeparator1, Me.KeluarToolStripMenuItem})
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(37, 19)
        Me.LogoutToolStripMenuItem1.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MasterDataAdminToolStripMenuItem
        '
        Me.MasterDataAdminToolStripMenuItem.Name = "MasterDataAdminToolStripMenuItem"
        Me.MasterDataAdminToolStripMenuItem.Size = New System.Drawing.Size(121, 19)
        Me.MasterDataAdminToolStripMenuItem.Text = "Master Data Admin"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 398)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 39)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "© Copyright 2022" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PT. KALTA CITRA UTAMA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.btn_admin)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_dash)
        Me.Panel1.Controls.Add(Me.btn_inven)
        Me.Panel1.Controls.Add(Me.btn_cost_menu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 446)
        Me.Panel1.TabIndex = 12
        '
        'btn_admin
        '
        Me.btn_admin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_admin.FlatAppearance.BorderSize = 0
        Me.btn_admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_admin.ForeColor = System.Drawing.Color.White
        Me.btn_admin.Location = New System.Drawing.Point(0, 231)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(141, 45)
        Me.btn_admin.TabIndex = 12
        Me.btn_admin.Text = "Administrasi"
        Me.btn_admin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_admin.UseVisualStyleBackColor = True
        '
        'btn_dash
        '
        Me.btn_dash.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_dash.FlatAppearance.BorderSize = 0
        Me.btn_dash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dash.ForeColor = System.Drawing.Color.White
        Me.btn_dash.Location = New System.Drawing.Point(0, 78)
        Me.btn_dash.Name = "btn_dash"
        Me.btn_dash.Size = New System.Drawing.Size(141, 45)
        Me.btn_dash.TabIndex = 2
        Me.btn_dash.Text = "Dashboard"
        Me.btn_dash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_dash.UseVisualStyleBackColor = True
        '
        'btn_inven
        '
        Me.btn_inven.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_inven.FlatAppearance.BorderSize = 0
        Me.btn_inven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_inven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inven.ForeColor = System.Drawing.Color.White
        Me.btn_inven.Location = New System.Drawing.Point(0, 300)
        Me.btn_inven.Name = "btn_inven"
        Me.btn_inven.Size = New System.Drawing.Size(141, 45)
        Me.btn_inven.TabIndex = 1
        Me.btn_inven.Text = "Inventory"
        Me.btn_inven.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_inven.UseVisualStyleBackColor = True
        '
        'btn_cost_menu
        '
        Me.btn_cost_menu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cost_menu.FlatAppearance.BorderSize = 0
        Me.btn_cost_menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_cost_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cost_menu.ForeColor = System.Drawing.Color.White
        Me.btn_cost_menu.Location = New System.Drawing.Point(0, 152)
        Me.btn_cost_menu.Name = "btn_cost_menu"
        Me.btn_cost_menu.Size = New System.Drawing.Size(141, 45)
        Me.btn_cost_menu.TabIndex = 0
        Me.btn_cost_menu.Text = "Cost Control"
        Me.btn_cost_menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cost_menu.UseVisualStyleBackColor = True
        '
        'jam
        '
        Me.jam.Enabled = True
        Me.jam.Interval = 1000
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.status_trip)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(141, 445)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(720, 26)
        Me.Panel2.TabIndex = 13
        '
        'status_trip
        '
        Me.status_trip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.hari_tgl})
        Me.status_trip.Location = New System.Drawing.Point(0, 2)
        Me.status_trip.Name = "status_trip"
        Me.status_trip.Size = New System.Drawing.Size(720, 24)
        Me.status_trip.TabIndex = 0
        Me.status_trip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(352, 19)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "PT. KALTA CITRA UTAMA"
        '
        'hari_tgl
        '
        Me.hari_tgl.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.hari_tgl.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.hari_tgl.Name = "hari_tgl"
        Me.hari_tgl.Size = New System.Drawing.Size(352, 19)
        Me.hari_tgl.Spring = True
        Me.hari_tgl.Text = "25 APR 2025 13:40:00"
        '
        'panel_cost_control
        '
        Me.panel_cost_control.Controls.Add(Me.Button4)
        Me.panel_cost_control.Controls.Add(Me.Button5)
        Me.panel_cost_control.Controls.Add(Me.Label2)
        Me.panel_cost_control.Controls.Add(Me.Button3)
        Me.panel_cost_control.Controls.Add(Me.Button2)
        Me.panel_cost_control.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_cost_control.Location = New System.Drawing.Point(141, 25)
        Me.panel_cost_control.Name = "panel_cost_control"
        Me.panel_cost_control.Size = New System.Drawing.Size(720, 420)
        Me.panel_cost_control.TabIndex = 14
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(83, 157)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 34)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "BPK KANTOR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(264, 157)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(150, 34)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "BPK PROYEK"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cost Control"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(83, 83)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 34)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "BREAKDOWN RAP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(264, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 34)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "BREAKDOWN PO"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pnl_inven
        '
        Me.pnl_inven.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_inven.Controls.Add(Me.Label3)
        Me.pnl_inven.Location = New System.Drawing.Point(147, 25)
        Me.pnl_inven.Name = "pnl_inven"
        Me.pnl_inven.Size = New System.Drawing.Size(714, 417)
        Me.pnl_inven.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(73, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(316, 55)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Coming Soon"
        '
        'panel_dash
        '
        Me.panel_dash.BackgroundImage = Global.cost_control_test_1.My.Resources.Resources.kalta
        Me.panel_dash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panel_dash.Controls.Add(Me.Label4)
        Me.panel_dash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_dash.Location = New System.Drawing.Point(141, 25)
        Me.panel_dash.Name = "panel_dash"
        Me.panel_dash.Size = New System.Drawing.Size(720, 420)
        Me.panel_dash.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(537, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "COST CONTROL     ADMINISTRATION     INVENTORY"
        '
        'panel_admin
        '
        Me.panel_admin.Controls.Add(Me.btn_dash_tender)
        Me.panel_admin.Controls.Add(Me.Button15)
        Me.panel_admin.Controls.Add(Me.Label5)
        Me.panel_admin.Controls.Add(Me.Button16)
        Me.panel_admin.Controls.Add(Me.Button17)
        Me.panel_admin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_admin.Location = New System.Drawing.Point(141, 25)
        Me.panel_admin.Name = "panel_admin"
        Me.panel_admin.Size = New System.Drawing.Size(720, 420)
        Me.panel_admin.TabIndex = 15
        '
        'btn_dash_tender
        '
        Me.btn_dash_tender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dash_tender.Image = Global.cost_control_test_1.My.Resources.Resources.icons8_law_30
        Me.btn_dash_tender.Location = New System.Drawing.Point(108, 158)
        Me.btn_dash_tender.Name = "btn_dash_tender"
        Me.btn_dash_tender.Size = New System.Drawing.Size(150, 44)
        Me.btn_dash_tender.TabIndex = 4
        Me.btn_dash_tender.Text = "Tender"
        Me.btn_dash_tender.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_dash_tender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_dash_tender.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Image = Global.cost_control_test_1.My.Resources.Resources.icons8_report_card_30
        Me.Button15.Location = New System.Drawing.Point(292, 157)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(150, 45)
        Me.Button15.TabIndex = 3
        Me.Button15.Text = "Laporan"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(111, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 24)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Administrasi"
        '
        'Button16
        '
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Image = Global.cost_control_test_1.My.Resources.Resources.icons8_worker_30
        Me.Button16.Location = New System.Drawing.Point(108, 89)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(150, 44)
        Me.Button16.TabIndex = 1
        Me.Button16.Text = "Pekerjaan"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Image = Global.cost_control_test_1.My.Resources.Resources.icons8_money_30
        Me.Button17.Location = New System.Drawing.Point(292, 89)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(150, 44)
        Me.Button17.TabIndex = 0
        Me.Button17.Text = "Upah Kerja"
        Me.Button17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button17.UseVisualStyleBackColor = True
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 19)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.cost_control_test_1.My.Resources.Resources.kalta
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(861, 471)
        Me.Controls.Add(Me.panel_cost_control)
        Me.Controls.Add(Me.panel_dash)
        Me.Controls.Add(Me.panel_admin)
        Me.Controls.Add(Me.pnl_inven)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DASHBOARD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.status_trip.ResumeLayout(False)
        Me.status_trip.PerformLayout()
        Me.panel_cost_control.ResumeLayout(False)
        Me.panel_cost_control.PerformLayout()
        Me.pnl_inven.ResumeLayout(False)
        Me.pnl_inven.PerformLayout()
        Me.panel_dash.ResumeLayout(False)
        Me.panel_dash.PerformLayout()
        Me.panel_admin.ResumeLayout(False)
        Me.panel_admin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LogoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_inven As Button
    Friend WithEvents btn_cost_menu As Button
    Friend WithEvents btn_dash As Button
    Friend WithEvents jam As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents status_trip As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents hari_tgl As ToolStripStatusLabel
    Friend WithEvents panel_cost_control As Panel
    Friend WithEvents pnl_inven As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents panel_dash As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_admin As Button
    Friend WithEvents panel_admin As Panel
    Friend WithEvents btn_dash_tender As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterDataAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class

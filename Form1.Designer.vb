<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        btnPanel3 = New FlowLayoutPanel()
        btnPanel2 = New FlowLayoutPanel()
        BtnPanel1 = New FlowLayoutPanel()
        DashboardBtn = New Button()
        ItemsBtn = New Button()
        SupplierBtn = New Button()
        Panel2 = New Panel()
        ProfileBtn = New Button()
        Panel8 = New Panel()
        LogoutBtn = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MediumBlue
        Panel1.Controls.Add(LogoutBtn)
        Panel1.Controls.Add(btnPanel3)
        Panel1.Controls.Add(btnPanel2)
        Panel1.Controls.Add(BtnPanel1)
        Panel1.Controls.Add(DashboardBtn)
        Panel1.Controls.Add(ItemsBtn)
        Panel1.Controls.Add(SupplierBtn)
        Panel1.Location = New Point(0, 54)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 405)
        Panel1.TabIndex = 0
        ' 
        ' btnPanel3
        ' 
        btnPanel3.BackColor = Color.DodgerBlue
        btnPanel3.Location = New Point(0, 218)
        btnPanel3.Name = "btnPanel3"
        btnPanel3.Size = New Size(12, 44)
        btnPanel3.TabIndex = 12
        btnPanel3.Visible = False
        ' 
        ' btnPanel2
        ' 
        btnPanel2.BackColor = Color.DodgerBlue
        btnPanel2.Location = New Point(0, 159)
        btnPanel2.Name = "btnPanel2"
        btnPanel2.Size = New Size(12, 44)
        btnPanel2.TabIndex = 12
        btnPanel2.Visible = False
        ' 
        ' BtnPanel1
        ' 
        BtnPanel1.BackColor = Color.DodgerBlue
        BtnPanel1.Location = New Point(0, 100)
        BtnPanel1.Name = "BtnPanel1"
        BtnPanel1.Size = New Size(12, 44)
        BtnPanel1.TabIndex = 11
        BtnPanel1.Visible = False
        ' 
        ' DashboardBtn
        ' 
        DashboardBtn.Cursor = Cursors.Hand
        DashboardBtn.FlatAppearance.BorderSize = 0
        DashboardBtn.FlatStyle = FlatStyle.Flat
        DashboardBtn.ForeColor = SystemColors.ButtonHighlight
        DashboardBtn.Image = CType(resources.GetObject("DashboardBtn.Image"), Image)
        DashboardBtn.ImageAlign = ContentAlignment.MiddleLeft
        DashboardBtn.Location = New Point(0, 100)
        DashboardBtn.Name = "DashboardBtn"
        DashboardBtn.Padding = New Padding(10, 0, 0, 0)
        DashboardBtn.Size = New Size(200, 44)
        DashboardBtn.TabIndex = 2
        DashboardBtn.Text = "                 Dashboard"
        DashboardBtn.TextAlign = ContentAlignment.MiddleLeft
        DashboardBtn.UseVisualStyleBackColor = True
        ' 
        ' ItemsBtn
        ' 
        ItemsBtn.Cursor = Cursors.Hand
        ItemsBtn.FlatAppearance.BorderSize = 0
        ItemsBtn.FlatStyle = FlatStyle.Flat
        ItemsBtn.ForeColor = SystemColors.ButtonHighlight
        ItemsBtn.Image = CType(resources.GetObject("ItemsBtn.Image"), Image)
        ItemsBtn.Location = New Point(3, 159)
        ItemsBtn.Name = "ItemsBtn"
        ItemsBtn.Size = New Size(194, 44)
        ItemsBtn.TabIndex = 4
        ItemsBtn.Text = "Items"
        ItemsBtn.UseVisualStyleBackColor = True
        ' 
        ' SupplierBtn
        ' 
        SupplierBtn.Cursor = Cursors.Hand
        SupplierBtn.FlatAppearance.BorderSize = 0
        SupplierBtn.FlatStyle = FlatStyle.Flat
        SupplierBtn.ForeColor = SystemColors.ButtonHighlight
        SupplierBtn.Image = CType(resources.GetObject("SupplierBtn.Image"), Image)
        SupplierBtn.Location = New Point(3, 218)
        SupplierBtn.Name = "SupplierBtn"
        SupplierBtn.Size = New Size(194, 44)
        SupplierBtn.TabIndex = 10
        SupplierBtn.Text = "Suppliers"
        SupplierBtn.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DodgerBlue
        Panel2.Controls.Add(ProfileBtn)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(867, 55)
        Panel2.TabIndex = 1
        ' 
        ' ProfileBtn
        ' 
        ProfileBtn.BackgroundImage = CType(resources.GetObject("ProfileBtn.BackgroundImage"), Image)
        ProfileBtn.BackgroundImageLayout = ImageLayout.Stretch
        ProfileBtn.Cursor = Cursors.Hand
        ProfileBtn.FlatAppearance.BorderSize = 0
        ProfileBtn.FlatStyle = FlatStyle.Flat
        ProfileBtn.Location = New Point(800, 0)
        ProfileBtn.Name = "ProfileBtn"
        ProfileBtn.Size = New Size(55, 55)
        ProfileBtn.TabIndex = 0
        ProfileBtn.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.Location = New Point(200, 54)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(667, 405)
        Panel8.TabIndex = 2
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.Cursor = Cursors.Hand
        LogoutBtn.FlatAppearance.BorderSize = 0
        LogoutBtn.FlatStyle = FlatStyle.Flat
        LogoutBtn.ForeColor = SystemColors.ButtonHighlight
        LogoutBtn.Image = CType(resources.GetObject("LogoutBtn.Image"), Image)
        LogoutBtn.Location = New Point(3, 361)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(194, 44)
        LogoutBtn.TabIndex = 13
        LogoutBtn.Text = "Logout"
        LogoutBtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(867, 459)
        Controls.Add(Panel8)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DashboardBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ItemsBtn As Button
    Friend WithEvents SupplierBtn As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents BtnPanel1 As FlowLayoutPanel
    Friend WithEvents ProfileBtn As Button
    Friend WithEvents btnPanel3 As FlowLayoutPanel
    Friend WithEvents btnPanel2 As FlowLayoutPanel
    Friend WithEvents LogoutBtn As Button

End Class

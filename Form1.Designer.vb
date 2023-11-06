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
        Panel1 = New Panel()
        DashboardBtn = New Button()
        ItemsBtn = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Panel2 = New Panel()
        Panel8 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MediumBlue
        Panel1.Controls.Add(DashboardBtn)
        Panel1.Controls.Add(ItemsBtn)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(0, 54)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 405)
        Panel1.TabIndex = 0
        ' 
        ' DashboardBtn
        ' 
        DashboardBtn.Cursor = Cursors.Hand
        DashboardBtn.FlatAppearance.BorderSize = 0
        DashboardBtn.FlatStyle = FlatStyle.Flat
        DashboardBtn.ForeColor = SystemColors.ButtonHighlight
        DashboardBtn.Image = My.Resources.Resources.apps
        DashboardBtn.Location = New Point(3, 100)
        DashboardBtn.Name = "DashboardBtn"
        DashboardBtn.Padding = New Padding(5, 0, 0, 0)
        DashboardBtn.Size = New Size(194, 44)
        DashboardBtn.TabIndex = 2
        DashboardBtn.Text = "Dashboard"
        DashboardBtn.UseVisualStyleBackColor = True
        ' 
        ' ItemsBtn
        ' 
        ItemsBtn.FlatAppearance.BorderSize = 0
        ItemsBtn.FlatStyle = FlatStyle.Flat
        ItemsBtn.ForeColor = SystemColors.ButtonHighlight
        ItemsBtn.Image = My.Resources.Resources.apps
        ItemsBtn.Location = New Point(3, 150)
        ItemsBtn.Name = "ItemsBtn"
        ItemsBtn.Size = New Size(194, 44)
        ItemsBtn.TabIndex = 4
        ItemsBtn.Text = "Items"
        ItemsBtn.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Image = My.Resources.Resources.apps
        Button4.Location = New Point(3, 282)
        Button4.Name = "Button4"
        Button4.Size = New Size(194, 44)
        Button4.TabIndex = 10
        Button4.Text = "Suppliers"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Image = My.Resources.Resources.apps
        Button3.Location = New Point(3, 238)
        Button3.Name = "Button3"
        Button3.Size = New Size(194, 44)
        Button3.TabIndex = 8
        Button3.Text = "Items Sold"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Image = My.Resources.Resources.apps
        Button2.Location = New Point(3, 194)
        Button2.Name = "Button2"
        Button2.Size = New Size(194, 44)
        Button2.TabIndex = 6
        Button2.Text = "Items In"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DodgerBlue
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(867, 55)
        Panel2.TabIndex = 1
        ' 
        ' Panel8
        ' 
        Panel8.Location = New Point(200, 54)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(667, 405)
        Panel8.TabIndex = 2
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DashboardBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ItemsBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel8 As Panel

End Class

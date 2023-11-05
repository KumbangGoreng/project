<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        Label5 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(74, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 25)
        Label1.TabIndex = 0
        Label1.Text = "DASHBOARD"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Coral
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(75, 92)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 100)
        Panel1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(104, 54)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 32)
        Label3.TabIndex = 1
        Label3.Text = "500"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(16, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 0
        Label2.Text = "PRODUCT"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DeepSkyBlue
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(312, 92)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 100)
        Panel2.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(104, 54)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 32)
        Label4.TabIndex = 1
        Label4.Text = "20"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Transparent
        Label5.Location = New Point(16, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 15)
        Label5.TabIndex = 0
        Label5.Text = "PRODUCT TO RE-ORDER"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class

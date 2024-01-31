<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConverter
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
        Me.txtKm = New System.Windows.Forms.TextBox()
        Me.txtMi = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timerClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblClock = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenüüToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VäljuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtKm
        '
        Me.txtKm.Location = New System.Drawing.Point(360, 137)
        Me.txtKm.Name = "txtKm"
        Me.txtKm.Size = New System.Drawing.Size(240, 26)
        Me.txtKm.TabIndex = 0
        '
        'txtMi
        '
        Me.txtMi.Enabled = False
        Me.txtMi.Location = New System.Drawing.Point(360, 213)
        Me.txtMi.Name = "txtMi"
        Me.txtMi.Size = New System.Drawing.Size(240, 26)
        Me.txtMi.TabIndex = 1
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(360, 169)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(240, 38)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Teisenda"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sisesta kilomeetrid"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tagasta miilides"
        '
        'timerClock
        '
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Location = New System.Drawing.Point(286, 384)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(174, 20)
        Me.lblClock.TabIndex = 5
        Me.lblClock.Text = "Siia kuvatakse kellaaeg"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenüüToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenüüToolStripMenuItem
        '
        Me.MenüüToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VäljuToolStripMenuItem})
        Me.MenüüToolStripMenuItem.Name = "MenüüToolStripMenuItem"
        Me.MenüüToolStripMenuItem.Size = New System.Drawing.Size(83, 29)
        Me.MenüüToolStripMenuItem.Text = "Menüü"
        '
        'VäljuToolStripMenuItem
        '
        Me.VäljuToolStripMenuItem.Name = "VäljuToolStripMenuItem"
        Me.VäljuToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.VäljuToolStripMenuItem.Text = "Välju"
        '
        'FormConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtMi)
        Me.Controls.Add(Me.txtKm)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormConverter"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKm As TextBox
    Friend WithEvents txtMi As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents timerClock As Timer
    Friend WithEvents lblClock As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenüüToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VäljuToolStripMenuItem As ToolStripMenuItem
End Class

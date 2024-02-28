<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKujundid
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKylgB = New System.Windows.Forms.TextBox()
        Me.txtKylgA = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnKolmnurk = New System.Windows.Forms.Button()
        Me.btnRistkylik = New System.Windows.Forms.Button()
        Me.btnRuut = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTyyp = New System.Windows.Forms.Label()
        Me.txtYmbermoot = New System.Windows.Forms.TextBox()
        Me.txtPindala = New System.Windows.Forms.TextBox()
        Me.tmr = New System.Windows.Forms.Timer(Me.components)
        Me.cbTapsus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKorgus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnRomb = New System.Windows.Forms.Button()
        Me.btnRoopkylik = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtKorgus)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtKylgB)
        Me.GroupBox1.Controls.Add(Me.txtKylgA)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(251, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Algandmed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "b="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "a="
        '
        'txtKylgB
        '
        Me.txtKylgB.Location = New System.Drawing.Point(73, 90)
        Me.txtKylgB.Name = "txtKylgB"
        Me.txtKylgB.Size = New System.Drawing.Size(150, 26)
        Me.txtKylgB.TabIndex = 3
        '
        'txtKylgA
        '
        Me.txtKylgA.Location = New System.Drawing.Point(73, 36)
        Me.txtKylgA.Name = "txtKylgA"
        Me.txtKylgA.Size = New System.Drawing.Size(150, 26)
        Me.txtKylgA.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRoopkylik)
        Me.GroupBox2.Controls.Add(Me.btnRomb)
        Me.GroupBox2.Controls.Add(Me.btnKolmnurk)
        Me.GroupBox2.Controls.Add(Me.btnRistkylik)
        Me.GroupBox2.Controls.Add(Me.btnRuut)
        Me.GroupBox2.Location = New System.Drawing.Point(475, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 318)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kujundid"
        '
        'btnKolmnurk
        '
        Me.btnKolmnurk.Location = New System.Drawing.Point(98, 49)
        Me.btnKolmnurk.Name = "btnKolmnurk"
        Me.btnKolmnurk.Size = New System.Drawing.Size(117, 31)
        Me.btnKolmnurk.TabIndex = 3
        Me.btnKolmnurk.Text = "Kolmnurk"
        Me.btnKolmnurk.UseVisualStyleBackColor = True
        '
        'btnRistkylik
        '
        Me.btnRistkylik.Enabled = False
        Me.btnRistkylik.Location = New System.Drawing.Point(98, 156)
        Me.btnRistkylik.Name = "btnRistkylik"
        Me.btnRistkylik.Size = New System.Drawing.Size(117, 34)
        Me.btnRistkylik.TabIndex = 2
        Me.btnRistkylik.Text = "Ristkülik"
        Me.btnRistkylik.UseVisualStyleBackColor = True
        '
        'btnRuut
        '
        Me.btnRuut.Enabled = False
        Me.btnRuut.Location = New System.Drawing.Point(98, 103)
        Me.btnRuut.Name = "btnRuut"
        Me.btnRuut.Size = New System.Drawing.Size(117, 29)
        Me.btnRuut.TabIndex = 1
        Me.btnRuut.Text = "Ruut"
        Me.btnRuut.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblTyyp)
        Me.GroupBox3.Controls.Add(Me.txtYmbermoot)
        Me.GroupBox3.Controls.Add(Me.txtPindala)
        Me.GroupBox3.Location = New System.Drawing.Point(68, 276)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(374, 148)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tulemused"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(123, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Pindala"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ümbermõõt"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Kujundi tüüp"
        '
        'lblTyyp
        '
        Me.lblTyyp.AutoSize = True
        Me.lblTyyp.Enabled = False
        Me.lblTyyp.Location = New System.Drawing.Point(186, 34)
        Me.lblTyyp.Name = "lblTyyp"
        Me.lblTyyp.Size = New System.Drawing.Size(90, 20)
        Me.lblTyyp.TabIndex = 6
        Me.lblTyyp.Text = "määramata"
        '
        'txtYmbermoot
        '
        Me.txtYmbermoot.Enabled = False
        Me.txtYmbermoot.Location = New System.Drawing.Point(190, 66)
        Me.txtYmbermoot.Name = "txtYmbermoot"
        Me.txtYmbermoot.Size = New System.Drawing.Size(100, 26)
        Me.txtYmbermoot.TabIndex = 4
        '
        'txtPindala
        '
        Me.txtPindala.Enabled = False
        Me.txtPindala.Location = New System.Drawing.Point(190, 101)
        Me.txtPindala.Name = "txtPindala"
        Me.txtPindala.Size = New System.Drawing.Size(100, 26)
        Me.txtPindala.TabIndex = 5
        '
        'tmr
        '
        Me.tmr.Enabled = True
        '
        'cbTapsus
        '
        Me.cbTapsus.FormattingEnabled = True
        Me.cbTapsus.Location = New System.Drawing.Point(141, 228)
        Me.cbTapsus.Name = "cbTapsus"
        Me.cbTapsus.Size = New System.Drawing.Size(121, 28)
        Me.cbTapsus.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Täpsus"
        '
        'txtKorgus
        '
        Me.txtKorgus.Location = New System.Drawing.Point(73, 145)
        Me.txtKorgus.Name = "txtKorgus"
        Me.txtKorgus.Size = New System.Drawing.Size(150, 26)
        Me.txtKorgus.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "h="
        '
        'btnRomb
        '
        Me.btnRomb.Enabled = False
        Me.btnRomb.Location = New System.Drawing.Point(98, 208)
        Me.btnRomb.Name = "btnRomb"
        Me.btnRomb.Size = New System.Drawing.Size(117, 34)
        Me.btnRomb.TabIndex = 4
        Me.btnRomb.Text = "Romb"
        Me.btnRomb.UseVisualStyleBackColor = True
        '
        'btnRoopkylik
        '
        Me.btnRoopkylik.Enabled = False
        Me.btnRoopkylik.Location = New System.Drawing.Point(98, 257)
        Me.btnRoopkylik.Name = "btnRoopkylik"
        Me.btnRoopkylik.Size = New System.Drawing.Size(117, 34)
        Me.btnRoopkylik.TabIndex = 5
        Me.btnRoopkylik.Text = "Rööpkülik"
        Me.btnRoopkylik.UseVisualStyleBackColor = True
        '
        'formKujundid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbTapsus)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formKujundid"
        Me.Text = "Kujundid"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtKylgA As TextBox
    Friend WithEvents txtPindala As TextBox
    Friend WithEvents txtKylgB As TextBox
    Friend WithEvents txtYmbermoot As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnKolmnurk As Button
    Friend WithEvents btnRistkylik As Button
    Friend WithEvents btnRuut As Button
    Friend WithEvents lblTyyp As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tmr As Timer
    Friend WithEvents cbTapsus As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtKorgus As TextBox
    Friend WithEvents btnRoopkylik As Button
    Friend WithEvents btnRomb As Button
End Class

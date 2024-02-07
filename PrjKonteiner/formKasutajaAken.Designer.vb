<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formKasutajaAken
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
        Me.components = New System.ComponentModel.Container()
        Me.txtSisendTekst = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst1 = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst2 = New System.Windows.Forms.TextBox()
        Me.lblSisendTekst = New System.Windows.Forms.Label()
        Me.lblValjundTekst1 = New System.Windows.Forms.Label()
        Me.lblValjundTekst2 = New System.Windows.Forms.Label()
        Me.btnPoora1 = New System.Windows.Forms.Button()
        Me.btnPoora2 = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.TimerUuenda = New System.Windows.Forms.Timer(Me.components)
        Me.lblTekstiPikkus = New System.Windows.Forms.Label()
        Me.lblTaisHaalikud = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSisendTekst
        '
        Me.txtSisendTekst.Location = New System.Drawing.Point(353, 79)
        Me.txtSisendTekst.Name = "txtSisendTekst"
        Me.txtSisendTekst.Size = New System.Drawing.Size(210, 26)
        Me.txtSisendTekst.TabIndex = 0
        '
        'txtValjundTekst1
        '
        Me.txtValjundTekst1.Location = New System.Drawing.Point(353, 161)
        Me.txtValjundTekst1.Name = "txtValjundTekst1"
        Me.txtValjundTekst1.Size = New System.Drawing.Size(210, 26)
        Me.txtValjundTekst1.TabIndex = 1
        '
        'txtValjundTekst2
        '
        Me.txtValjundTekst2.Location = New System.Drawing.Point(353, 257)
        Me.txtValjundTekst2.Name = "txtValjundTekst2"
        Me.txtValjundTekst2.Size = New System.Drawing.Size(210, 26)
        Me.txtValjundTekst2.TabIndex = 2
        '
        'lblSisendTekst
        '
        Me.lblSisendTekst.AutoSize = True
        Me.lblSisendTekst.Location = New System.Drawing.Point(131, 85)
        Me.lblSisendTekst.Name = "lblSisendTekst"
        Me.lblSisendTekst.Size = New System.Drawing.Size(97, 20)
        Me.lblSisendTekst.TabIndex = 3
        Me.lblSisendTekst.Text = "Sisendtekst:"
        '
        'lblValjundTekst1
        '
        Me.lblValjundTekst1.AutoSize = True
        Me.lblValjundTekst1.Location = New System.Drawing.Point(40, 167)
        Me.lblValjundTekst1.Name = "lblValjundTekst1"
        Me.lblValjundTekst1.Size = New System.Drawing.Size(188, 20)
        Me.lblValjundTekst1.TabIndex = 4
        Me.lblValjundTekst1.Text = "Pööramine funktsiooniga:"
        '
        'lblValjundTekst2
        '
        Me.lblValjundTekst2.AutoSize = True
        Me.lblValjundTekst2.Location = New System.Drawing.Point(37, 263)
        Me.lblValjundTekst2.Name = "lblValjundTekst2"
        Me.lblValjundTekst2.Size = New System.Drawing.Size(191, 20)
        Me.lblValjundTekst2.TabIndex = 5
        Me.lblValjundTekst2.Text = "Pööramine protseduuriga:"
        '
        'btnPoora1
        '
        Me.btnPoora1.Location = New System.Drawing.Point(353, 193)
        Me.btnPoora1.Name = "btnPoora1"
        Me.btnPoora1.Size = New System.Drawing.Size(210, 32)
        Me.btnPoora1.TabIndex = 6
        Me.btnPoora1.Text = "Pööra funktsiooniga"
        Me.btnPoora1.UseVisualStyleBackColor = True
        '
        'btnPoora2
        '
        Me.btnPoora2.Location = New System.Drawing.Point(353, 289)
        Me.btnPoora2.Name = "btnPoora2"
        Me.btnPoora2.Size = New System.Drawing.Size(210, 31)
        Me.btnPoora2.TabIndex = 7
        Me.btnPoora2.Text = "Pööra protseduuriga"
        Me.btnPoora2.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(238, 365)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(112, 57)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(528, 365)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(116, 57)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'TimerUuenda
        '
        Me.TimerUuenda.Interval = 5000
        '
        'lblTekstiPikkus
        '
        Me.lblTekstiPikkus.AutoSize = True
        Me.lblTekstiPikkus.Location = New System.Drawing.Point(578, 82)
        Me.lblTekstiPikkus.Name = "lblTekstiPikkus"
        Me.lblTekstiPikkus.Size = New System.Drawing.Size(0, 20)
        Me.lblTekstiPikkus.TabIndex = 10
        '
        'lblTaisHaalikud
        '
        Me.lblTaisHaalikud.AutoSize = True
        Me.lblTaisHaalikud.Location = New System.Drawing.Point(645, 82)
        Me.lblTaisHaalikud.Name = "lblTaisHaalikud"
        Me.lblTaisHaalikud.Size = New System.Drawing.Size(0, 20)
        Me.lblTaisHaalikud.TabIndex = 11
        '
        'formKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 450)
        Me.Controls.Add(Me.lblTaisHaalikud)
        Me.Controls.Add(Me.lblTekstiPikkus)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnPoora2)
        Me.Controls.Add(Me.btnPoora1)
        Me.Controls.Add(Me.lblValjundTekst2)
        Me.Controls.Add(Me.lblValjundTekst1)
        Me.Controls.Add(Me.lblSisendTekst)
        Me.Controls.Add(Me.txtValjundTekst2)
        Me.Controls.Add(Me.txtValjundTekst1)
        Me.Controls.Add(Me.txtSisendTekst)
        Me.Name = "formKasutajaAken"
        Me.Text = "Tekstitöötlus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSisendTekst As TextBox
    Friend WithEvents txtValjundTekst1 As TextBox
    Friend WithEvents txtValjundTekst2 As TextBox
    Friend WithEvents lblSisendTekst As Label
    Friend WithEvents lblValjundTekst1 As Label
    Friend WithEvents lblValjundTekst2 As Label
    Friend WithEvents btnPoora1 As Button
    Friend WithEvents btnPoora2 As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents TimerUuenda As Timer
    Friend WithEvents lblTekstiPikkus As Label
    Friend WithEvents lblTaisHaalikud As Label
End Class

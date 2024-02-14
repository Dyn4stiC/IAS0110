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
        Me.components = New System.ComponentModel.Container()
        Me.btnConfused = New System.Windows.Forms.Button()
        Me.btnCool = New System.Windows.Forms.Button()
        Me.btnSmile = New System.Windows.Forms.Button()
        Me.btnStar = New System.Windows.Forms.Button()
        Me.btnTeeth = New System.Windows.Forms.Button()
        Me.btnYell = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.UCtrlEmotion1 = New PrjFaces.UCtrlEmotion()
        Me.UBulb1 = New PrjLightBulb.UBulb()
        Me.USwitch1 = New PrjLightSwitch.USwitch()
        Me.tmrBulb = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnConfused
        '
        Me.btnConfused.Location = New System.Drawing.Point(897, 97)
        Me.btnConfused.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnConfused.Name = "btnConfused"
        Me.btnConfused.Size = New System.Drawing.Size(112, 35)
        Me.btnConfused.TabIndex = 1
        Me.btnConfused.Text = "Confused"
        Me.btnConfused.UseVisualStyleBackColor = True
        '
        'btnCool
        '
        Me.btnCool.Location = New System.Drawing.Point(897, 168)
        Me.btnCool.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCool.Name = "btnCool"
        Me.btnCool.Size = New System.Drawing.Size(112, 35)
        Me.btnCool.TabIndex = 2
        Me.btnCool.Text = "Cool"
        Me.btnCool.UseVisualStyleBackColor = True
        '
        'btnSmile
        '
        Me.btnSmile.Location = New System.Drawing.Point(897, 246)
        Me.btnSmile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSmile.Name = "btnSmile"
        Me.btnSmile.Size = New System.Drawing.Size(112, 35)
        Me.btnSmile.TabIndex = 3
        Me.btnSmile.Text = "Smile"
        Me.btnSmile.UseVisualStyleBackColor = True
        '
        'btnStar
        '
        Me.btnStar.Location = New System.Drawing.Point(897, 331)
        Me.btnStar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStar.Name = "btnStar"
        Me.btnStar.Size = New System.Drawing.Size(112, 35)
        Me.btnStar.TabIndex = 4
        Me.btnStar.Text = "Star"
        Me.btnStar.UseVisualStyleBackColor = True
        '
        'btnTeeth
        '
        Me.btnTeeth.Location = New System.Drawing.Point(897, 422)
        Me.btnTeeth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTeeth.Name = "btnTeeth"
        Me.btnTeeth.Size = New System.Drawing.Size(112, 35)
        Me.btnTeeth.TabIndex = 5
        Me.btnTeeth.Text = "Teeth"
        Me.btnTeeth.UseVisualStyleBackColor = True
        '
        'btnYell
        '
        Me.btnYell.Location = New System.Drawing.Point(897, 512)
        Me.btnYell.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnYell.Name = "btnYell"
        Me.btnYell.Size = New System.Drawing.Size(112, 35)
        Me.btnYell.TabIndex = 6
        Me.btnYell.Text = "Yell"
        Me.btnYell.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Location = New System.Drawing.Point(897, 608)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 35)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Puhasta"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'UCtrlEmotion1
        '
        Me.UCtrlEmotion1.Location = New System.Drawing.Point(64, 18)
        Me.UCtrlEmotion1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UCtrlEmotion1.Name = "UCtrlEmotion1"
        Me.UCtrlEmotion1.Size = New System.Drawing.Size(342, 226)
        Me.UCtrlEmotion1.TabIndex = 0
        '
        'UBulb1
        '
        Me.UBulb1.Location = New System.Drawing.Point(64, 254)
        Me.UBulb1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.UBulb1.Name = "UBulb1"
        Me.UBulb1.Size = New System.Drawing.Size(430, 392)
        Me.UBulb1.TabIndex = 8
        '
        'USwitch1
        '
        Me.USwitch1.Location = New System.Drawing.Point(572, 495)
        Me.USwitch1.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.USwitch1.Name = "USwitch1"
        Me.USwitch1.Size = New System.Drawing.Size(207, 165)
        Me.USwitch1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.USwitch1)
        Me.Controls.Add(Me.UBulb1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnYell)
        Me.Controls.Add(Me.btnTeeth)
        Me.Controls.Add(Me.btnStar)
        Me.Controls.Add(Me.btnSmile)
        Me.Controls.Add(Me.btnCool)
        Me.Controls.Add(Me.btnConfused)
        Me.Controls.Add(Me.UCtrlEmotion1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UCtrlEmotion1 As PrjFaces.UCtrlEmotion
    Friend WithEvents btnConfused As Button
    Friend WithEvents btnCool As Button
    Friend WithEvents btnSmile As Button
    Friend WithEvents btnStar As Button
    Friend WithEvents btnTeeth As Button
    Friend WithEvents btnYell As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents UBulb1 As PrjLightBulb.UBulb
    Friend WithEvents USwitch1 As PrjLightSwitch.USwitch
    Friend WithEvents tmrBulb As Timer
End Class

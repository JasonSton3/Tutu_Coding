﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.UserControl22 = New tutuGUI_Jason_v3.UserControl2()
        Me.UserControl12 = New tutuGUI_Jason_v3.UserControl1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(156, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "EQ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(287, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 35)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "DRC"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(696, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(55, 30)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Plot"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(918, 15)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 35)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Copy"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1194, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 34)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "debug"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(779, 15)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(115, 35)
        Me.Button10.TabIndex = 15
        Me.Button10.Text = "Paste"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'UserControl22
        '
        Me.UserControl22.Location = New System.Drawing.Point(16, 66)
        Me.UserControl22.Name = "UserControl22"
        Me.UserControl22.Size = New System.Drawing.Size(1318, 575)
        Me.UserControl22.TabIndex = 17
        '
        'UserControl12
        '
        Me.UserControl12.BackColor = System.Drawing.SystemColors.Control
        Me.UserControl12.Location = New System.Drawing.Point(37, 62)
        Me.UserControl12.Name = "UserControl12"
        Me.UserControl12.Size = New System.Drawing.Size(1385, 683)
        Me.UserControl12.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(696, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(68, 47)
        Me.Panel1.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(687, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plot is under here"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(26, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 23)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.Text = "Tutu ON"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(26, 41)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(85, 23)
        Me.CheckBox2.TabIndex = 21
        Me.CheckBox2.Text = "Tutu OFF"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(2, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1431, 698)
        Me.Panel2.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1434, 761)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UserControl22)
        Me.Controls.Add(Me.UserControl12)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Tutu Parameter Control Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents UserControl11 As UserControl1
    Friend WithEvents UserControl21 As UserControl2
    Friend WithEvents Button5 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents UserControl12 As UserControl1
    Friend WithEvents UserControl22 As UserControl2
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Panel2 As Panel
End Class

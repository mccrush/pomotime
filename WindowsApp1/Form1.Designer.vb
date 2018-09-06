<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonPause = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonShortBreak = New System.Windows.Forms.Button()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.ButtonLongBreak = New System.Windows.Forms.Button()
        Me.ButtonHide = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonStart
        '
        Me.ButtonStart.BackColor = System.Drawing.SystemColors.WindowFrame
        resources.ApplyResources(Me.ButtonStart, "ButtonStart")
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'ButtonPause
        '
        resources.ApplyResources(Me.ButtonPause, "ButtonPause")
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        resources.ApplyResources(Me.NotifyIcon1, "NotifyIcon1")
        '
        'ContextMenuStrip1
        '
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        '
        'ButtonShortBreak
        '
        resources.ApplyResources(Me.ButtonShortBreak, "ButtonShortBreak")
        Me.ButtonShortBreak.Name = "ButtonShortBreak"
        Me.ButtonShortBreak.UseVisualStyleBackColor = True
        '
        'LabelTime
        '
        Me.LabelTime.BackColor = System.Drawing.Color.Transparent
        Me.LabelTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        resources.ApplyResources(Me.LabelTime, "LabelTime")
        Me.LabelTime.ForeColor = System.Drawing.SystemColors.Window
        Me.LabelTime.Name = "LabelTime"
        '
        'ButtonLongBreak
        '
        resources.ApplyResources(Me.ButtonLongBreak, "ButtonLongBreak")
        Me.ButtonLongBreak.Name = "ButtonLongBreak"
        Me.ButtonLongBreak.UseVisualStyleBackColor = True
        '
        'ButtonHide
        '
        Me.ButtonHide.BackColor = System.Drawing.Color.White
        Me.ButtonHide.FlatAppearance.BorderSize = 0
        Me.ButtonHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.ButtonHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        resources.ApplyResources(Me.ButtonHide, "ButtonHide")
        Me.ButtonHide.Name = "ButtonHide"
        Me.ButtonHide.UseVisualStyleBackColor = False
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.Color.White
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.ButtonClose, "ButtonClose")
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'ButtonReset
        '
        resources.ApplyResources(Me.ButtonReset, "ButtonReset")
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ButtonHide)
        Me.Panel1.Controls.Add(Me.ButtonClose)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.ButtonLongBreak)
        Me.Controls.Add(Me.ButtonShortBreak)
        Me.Controls.Add(Me.ButtonPause)
        Me.Controls.Add(Me.ButtonStart)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonStart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonPause As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonShortBreak As Button
    Friend WithEvents ButtonLongBreak As Button
    Friend WithEvents LabelTime As Label
    Friend WithEvents ButtonHide As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonReset As Button
    Friend WithEvents Panel1 As Panel
End Class

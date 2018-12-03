<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnaForm
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
        Me.MenuStripBipBus = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramıKapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KayıtlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YolcuKaydıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OtobüslerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RaporlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YardımToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripBipBus.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripBipBus
        '
        Me.MenuStripBipBus.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStripBipBus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.KayıtlarToolStripMenuItem, Me.RaporlarToolStripMenuItem, Me.YardımToolStripMenuItem})
        Me.MenuStripBipBus.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripBipBus.Name = "MenuStripBipBus"
        Me.MenuStripBipBus.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStripBipBus.Size = New System.Drawing.Size(816, 24)
        Me.MenuStripBipBus.TabIndex = 1
        Me.MenuStripBipBus.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramıKapatToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "&Program"
        '
        'ProgramıKapatToolStripMenuItem
        '
        Me.ProgramıKapatToolStripMenuItem.Name = "ProgramıKapatToolStripMenuItem"
        Me.ProgramıKapatToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4"
        Me.ProgramıKapatToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ProgramıKapatToolStripMenuItem.Text = "Programı &Kapat"
        '
        'KayıtlarToolStripMenuItem
        '
        Me.KayıtlarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YolcuKaydıToolStripMenuItem, Me.ToolStripMenuItem1, Me.OtobüslerToolStripMenuItem})
        Me.KayıtlarToolStripMenuItem.Name = "KayıtlarToolStripMenuItem"
        Me.KayıtlarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.KayıtlarToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.KayıtlarToolStripMenuItem.Text = "&Kayıtlar"
        '
        'YolcuKaydıToolStripMenuItem
        '
        Me.YolcuKaydıToolStripMenuItem.Name = "YolcuKaydıToolStripMenuItem"
        Me.YolcuKaydıToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.YolcuKaydıToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.YolcuKaydıToolStripMenuItem.Text = "&Yolcu Kaydı"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(151, 6)
        '
        'OtobüslerToolStripMenuItem
        '
        Me.OtobüslerToolStripMenuItem.Name = "OtobüslerToolStripMenuItem"
        Me.OtobüslerToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.OtobüslerToolStripMenuItem.Text = "&Otobüsler"
        '
        'RaporlarToolStripMenuItem
        '
        Me.RaporlarToolStripMenuItem.Name = "RaporlarToolStripMenuItem"
        Me.RaporlarToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.RaporlarToolStripMenuItem.Text = "&Raporlar"
        '
        'YardımToolStripMenuItem
        '
        Me.YardımToolStripMenuItem.Name = "YardımToolStripMenuItem"
        Me.YardımToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.YardımToolStripMenuItem.Text = "&Yardım"
        '
        'AnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 563)
        Me.Controls.Add(Me.MenuStripBipBus)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStripBipBus
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AnaForm"
        Me.Text = "BipBus Otobüs İşletmesi Otomasyonu"
        Me.MenuStripBipBus.ResumeLayout(False)
        Me.MenuStripBipBus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripBipBus As MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramıKapatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KayıtlarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RaporlarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YardımToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YolcuKaydıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents OtobüslerToolStripMenuItem As ToolStripMenuItem
End Class

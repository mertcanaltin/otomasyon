<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class YeniYolcuKayitFormu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.YolcuNoTextBox = New System.Windows.Forms.TextBox()
        Me.TCKimlikNoTextBox = New System.Windows.Forms.TextBox()
        Me.AdiTextBox = New System.Windows.Forms.TextBox()
        Me.SoyadiTextBox = New System.Windows.Forms.TextBox()
        Me.CinsiyetComboBox = New System.Windows.Forms.ComboBox()
        Me.TelefonTextBox = New System.Windows.Forms.TextBox()
        Me.DogumTarihiDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TCVatandasiCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KaydetButton = New System.Windows.Forms.Button()
        Me.SilButton = New System.Windows.Forms.Button()
        Me.DuzenleButton = New System.Windows.Forms.Button()
        Me.YeniKayitButton = New System.Windows.Forms.Button()
        Me.SonKayitButton = New System.Windows.Forms.Button()
        Me.SonrakiKayitButton = New System.Windows.Forms.Button()
        Me.OncekiKayitButton = New System.Windows.Forms.Button()
        Me.ilkKayitButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Yolcu No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "YolcununTC Kimlik No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Yolcunun Adı:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Yolcunun Soyadı:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cinsiyeti:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "İletişim Telefonu:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Doğum Tarihi:"
        '
        'YolcuNoTextBox
        '
        Me.YolcuNoTextBox.Location = New System.Drawing.Point(181, 43)
        Me.YolcuNoTextBox.Name = "YolcuNoTextBox"
        Me.YolcuNoTextBox.ReadOnly = True
        Me.YolcuNoTextBox.Size = New System.Drawing.Size(152, 22)
        Me.YolcuNoTextBox.TabIndex = 7
        '
        'TCKimlikNoTextBox
        '
        Me.TCKimlikNoTextBox.Location = New System.Drawing.Point(181, 81)
        Me.TCKimlikNoTextBox.Name = "TCKimlikNoTextBox"
        Me.TCKimlikNoTextBox.Size = New System.Drawing.Size(152, 22)
        Me.TCKimlikNoTextBox.TabIndex = 8
        '
        'AdiTextBox
        '
        Me.AdiTextBox.Location = New System.Drawing.Point(181, 119)
        Me.AdiTextBox.Name = "AdiTextBox"
        Me.AdiTextBox.Size = New System.Drawing.Size(243, 22)
        Me.AdiTextBox.TabIndex = 9
        '
        'SoyadiTextBox
        '
        Me.SoyadiTextBox.Location = New System.Drawing.Point(181, 157)
        Me.SoyadiTextBox.Name = "SoyadiTextBox"
        Me.SoyadiTextBox.Size = New System.Drawing.Size(243, 22)
        Me.SoyadiTextBox.TabIndex = 10
        '
        'CinsiyetComboBox
        '
        Me.CinsiyetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CinsiyetComboBox.FormattingEnabled = True
        Me.CinsiyetComboBox.Location = New System.Drawing.Point(181, 195)
        Me.CinsiyetComboBox.Name = "CinsiyetComboBox"
        Me.CinsiyetComboBox.Size = New System.Drawing.Size(121, 24)
        Me.CinsiyetComboBox.TabIndex = 11
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.Location = New System.Drawing.Point(181, 235)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(152, 22)
        Me.TelefonTextBox.TabIndex = 12
        '
        'DogumTarihiDateTimePicker
        '
        Me.DogumTarihiDateTimePicker.Location = New System.Drawing.Point(181, 271)
        Me.DogumTarihiDateTimePicker.Name = "DogumTarihiDateTimePicker"
        Me.DogumTarihiDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.DogumTarihiDateTimePicker.TabIndex = 14
        '
        'TCVatandasiCheckBox
        '
        Me.TCVatandasiCheckBox.AutoSize = True
        Me.TCVatandasiCheckBox.Location = New System.Drawing.Point(352, 80)
        Me.TCVatandasiCheckBox.Name = "TCVatandasiCheckBox"
        Me.TCVatandasiCheckBox.Size = New System.Drawing.Size(115, 21)
        Me.TCVatandasiCheckBox.TabIndex = 15
        Me.TCVatandasiCheckBox.Text = "TC Vatandaşı"
        Me.TCVatandasiCheckBox.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.KaydetButton)
        Me.Panel1.Controls.Add(Me.SilButton)
        Me.Panel1.Controls.Add(Me.DuzenleButton)
        Me.Panel1.Controls.Add(Me.YeniKayitButton)
        Me.Panel1.Controls.Add(Me.SonKayitButton)
        Me.Panel1.Controls.Add(Me.SonrakiKayitButton)
        Me.Panel1.Controls.Add(Me.OncekiKayitButton)
        Me.Panel1.Controls.Add(Me.ilkKayitButton)
        Me.Panel1.Location = New System.Drawing.Point(27, 314)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 71)
        Me.Panel1.TabIndex = 16
        '
        'KaydetButton
        '
        Me.KaydetButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.KaydetButton.Image = Global.BipBusOtomasyon.My.Resources.Resources.save
        Me.KaydetButton.Location = New System.Drawing.Point(525, 0)
        Me.KaydetButton.Name = "KaydetButton"
        Me.KaydetButton.Size = New System.Drawing.Size(75, 71)
        Me.KaydetButton.TabIndex = 7
        Me.KaydetButton.UseVisualStyleBackColor = True
        '
        'SilButton
        '
        Me.SilButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.SilButton.Image = Global.BipBusOtomasyon.My.Resources.Resources.delete
        Me.SilButton.Location = New System.Drawing.Point(450, 0)
        Me.SilButton.Name = "SilButton"
        Me.SilButton.Size = New System.Drawing.Size(75, 71)
        Me.SilButton.TabIndex = 6
        Me.SilButton.UseVisualStyleBackColor = True
        '
        'DuzenleButton
        '
        Me.DuzenleButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.DuzenleButton.Image = Global.BipBusOtomasyon.My.Resources.Resources.edit
        Me.DuzenleButton.Location = New System.Drawing.Point(375, 0)
        Me.DuzenleButton.Name = "DuzenleButton"
        Me.DuzenleButton.Size = New System.Drawing.Size(75, 71)
        Me.DuzenleButton.TabIndex = 5
        Me.DuzenleButton.UseVisualStyleBackColor = True
        '
        'YeniKayitButton
        '
        Me.YeniKayitButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.YeniKayitButton.Image = Global.BipBusOtomasyon.My.Resources.Resources.add
        Me.YeniKayitButton.Location = New System.Drawing.Point(300, 0)
        Me.YeniKayitButton.Name = "YeniKayitButton"
        Me.YeniKayitButton.Size = New System.Drawing.Size(75, 71)
        Me.YeniKayitButton.TabIndex = 4
        Me.YeniKayitButton.UseVisualStyleBackColor = True
        '
        'SonKayitButton
        '
        Me.SonKayitButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.SonKayitButton.Image = Global.BipBusOtomasyon.My.Resources.Resources.last
        Me.SonKayitButton.Location = New System.Drawing.Point(225, 0)
        Me.SonKayitButton.Name = "SonKayitButton"
        Me.SonKayitButton.Size = New System.Drawing.Size(75, 71)
        Me.SonKayitButton.TabIndex = 3
        Me.SonKayitButton.UseVisualStyleBackColor = True
        '
        'SonrakiKayitButton
        '
        Me.SonrakiKayitButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.SonrakiKayitButton.Image = Global.BipBusOtomasyon.My.Resources.Resources._next
        Me.SonrakiKayitButton.Location = New System.Drawing.Point(150, 0)
        Me.SonrakiKayitButton.Name = "SonrakiKayitButton"
        Me.SonrakiKayitButton.Size = New System.Drawing.Size(75, 71)
        Me.SonrakiKayitButton.TabIndex = 2
        Me.SonrakiKayitButton.UseVisualStyleBackColor = True
        '
        'OncekiKayitButton
        '
        Me.OncekiKayitButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.OncekiKayitButton.Image = Global.BipBusOtomasyon.My.Resources.Resources.previous
        Me.OncekiKayitButton.Location = New System.Drawing.Point(75, 0)
        Me.OncekiKayitButton.Name = "OncekiKayitButton"
        Me.OncekiKayitButton.Size = New System.Drawing.Size(75, 71)
        Me.OncekiKayitButton.TabIndex = 1
        Me.OncekiKayitButton.UseVisualStyleBackColor = True
        '
        'ilkKayitButton
        '
        Me.ilkKayitButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.ilkKayitButton.Image = Global.BipBusOtomasyon.My.Resources.Resources.first
        Me.ilkKayitButton.Location = New System.Drawing.Point(0, 0)
        Me.ilkKayitButton.Name = "ilkKayitButton"
        Me.ilkKayitButton.Size = New System.Drawing.Size(75, 71)
        Me.ilkKayitButton.TabIndex = 0
        Me.ilkKayitButton.UseVisualStyleBackColor = True
        '
        'YeniYolcuKayitFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 435)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TCVatandasiCheckBox)
        Me.Controls.Add(Me.DogumTarihiDateTimePicker)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(Me.CinsiyetComboBox)
        Me.Controls.Add(Me.SoyadiTextBox)
        Me.Controls.Add(Me.AdiTextBox)
        Me.Controls.Add(Me.TCKimlikNoTextBox)
        Me.Controls.Add(Me.YolcuNoTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "YeniYolcuKayitFormu"
        Me.Text = "Yeni Yolcu Kayıt Formu"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents YolcuNoTextBox As TextBox
    Friend WithEvents TCKimlikNoTextBox As TextBox
    Friend WithEvents AdiTextBox As TextBox
    Friend WithEvents SoyadiTextBox As TextBox
    Friend WithEvents CinsiyetComboBox As ComboBox
    Friend WithEvents TelefonTextBox As TextBox
    Friend WithEvents DogumTarihiDateTimePicker As DateTimePicker
    Friend WithEvents TCVatandasiCheckBox As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents KaydetButton As Button
    Friend WithEvents SilButton As Button
    Friend WithEvents DuzenleButton As Button
    Friend WithEvents YeniKayitButton As Button
    Friend WithEvents SonKayitButton As Button
    Friend WithEvents SonrakiKayitButton As Button
    Friend WithEvents OncekiKayitButton As Button
    Friend WithEvents ilkKayitButton As Button
End Class

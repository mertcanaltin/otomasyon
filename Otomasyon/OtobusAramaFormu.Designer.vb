<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtobusAramaFormu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OtobuslerDataGridView = New System.Windows.Forms.DataGridView()
        Me.OtobusKayit_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Plaka = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkaNo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ModelNo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.KoltukSayisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KoltukDizilisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlakaTextBox = New System.Windows.Forms.TextBox()
        Me.BipBusDataSet = New System.Data.DataSet()
        Me.AraButton = New System.Windows.Forms.Button()
        Me.OtobusTablosuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.markatablosuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.modeltablosuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.OtobuslerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BipBusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtobusTablosuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.markatablosuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.modeltablosuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(352, 562)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "&Tamam"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "&Vazgeç"
        '
        'OtobuslerDataGridView
        '
        Me.OtobuslerDataGridView.AllowUserToAddRows = False
        Me.OtobuslerDataGridView.AllowUserToDeleteRows = False
        Me.OtobuslerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OtobuslerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OtobusKayit_id, Me.Plaka, Me.MarkaNo, Me.ModelNo, Me.KoltukSayisi, Me.Telefon, Me.KoltukDizilisi, Me.Kat})
        Me.OtobuslerDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.OtobuslerDataGridView.Location = New System.Drawing.Point(11, 46)
        Me.OtobuslerDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.OtobuslerDataGridView.MultiSelect = False
        Me.OtobuslerDataGridView.Name = "OtobuslerDataGridView"
        Me.OtobuslerDataGridView.ReadOnly = True
        Me.OtobuslerDataGridView.RowHeadersVisible = False
        Me.OtobuslerDataGridView.RowTemplate.Height = 24
        Me.OtobuslerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OtobuslerDataGridView.Size = New System.Drawing.Size(484, 495)
        Me.OtobuslerDataGridView.TabIndex = 16
        '
        'OtobusKayit_id
        '
        Me.OtobusKayit_id.DataPropertyName = "OtobusKayit_id"
        Me.OtobusKayit_id.HeaderText = "OtobusKayit_id"
        Me.OtobusKayit_id.Name = "OtobusKayit_id"
        Me.OtobusKayit_id.ReadOnly = True
        Me.OtobusKayit_id.Visible = False
        '
        'Plaka
        '
        Me.Plaka.DataPropertyName = "Plaka"
        Me.Plaka.HeaderText = "Otobüs Plakası"
        Me.Plaka.Name = "Plaka"
        Me.Plaka.ReadOnly = True
        '
        'MarkaNo
        '
        Me.MarkaNo.DataPropertyName = "MarkaNo"
        Me.MarkaNo.HeaderText = "Markası"
        Me.MarkaNo.Name = "MarkaNo"
        Me.MarkaNo.ReadOnly = True
        '
        'ModelNo
        '
        Me.ModelNo.DataPropertyName = "ModelNo"
        Me.ModelNo.HeaderText = "Modeli"
        Me.ModelNo.Name = "ModelNo"
        Me.ModelNo.ReadOnly = True
        '
        'KoltukSayisi
        '
        Me.KoltukSayisi.DataPropertyName = "KoltukSayisi"
        Me.KoltukSayisi.HeaderText = "Koltuk Sayısı"
        Me.KoltukSayisi.Name = "KoltukSayisi"
        Me.KoltukSayisi.ReadOnly = True
        '
        'Telefon
        '
        Me.Telefon.DataPropertyName = "Telefon"
        Me.Telefon.HeaderText = "Telefon"
        Me.Telefon.Name = "Telefon"
        Me.Telefon.ReadOnly = True
        '
        'KoltukDizilisi
        '
        Me.KoltukDizilisi.DataPropertyName = "KoltukDizilisi"
        Me.KoltukDizilisi.HeaderText = "Koltuk Düzeni"
        Me.KoltukDizilisi.Name = "KoltukDizilisi"
        Me.KoltukDizilisi.ReadOnly = True
        '
        'Kat
        '
        Me.Kat.DataPropertyName = "Kat"
        Me.Kat.HeaderText = "Kat Sayısı"
        Me.Kat.Name = "Kat"
        Me.Kat.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Otobüs Plakası"
        '
        'PlakaTextBox
        '
        Me.PlakaTextBox.Location = New System.Drawing.Point(92, 12)
        Me.PlakaTextBox.Name = "PlakaTextBox"
        Me.PlakaTextBox.Size = New System.Drawing.Size(322, 20)
        Me.PlakaTextBox.TabIndex = 18
        '
        'BipBusDataSet
        '
        Me.BipBusDataSet.DataSetName = "NewDataSet"
        '
        'AraButton
        '
        Me.AraButton.Image = Global.BipBusOtomasyon.My.Resources.Resources.ara
        Me.AraButton.Location = New System.Drawing.Point(420, 12)
        Me.AraButton.Name = "AraButton"
        Me.AraButton.Size = New System.Drawing.Size(78, 22)
        Me.AraButton.TabIndex = 19
        Me.AraButton.Text = "Ara"
        Me.AraButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.AraButton.UseVisualStyleBackColor = True
        '
        'OtobusTablosuBindingSource
        '
        Me.OtobusTablosuBindingSource.AllowNew = False
        '
        'markatablosuBindingSource
        '
        Me.markatablosuBindingSource.AllowNew = False
        '
        'modeltablosuBindingSource
        '
        Me.modeltablosuBindingSource.AllowNew = False
        '
        'OtobusAramaFormu
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(510, 603)
        Me.Controls.Add(Me.AraButton)
        Me.Controls.Add(Me.PlakaTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OtobuslerDataGridView)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OtobusAramaFormu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Otobüs Arama"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.OtobuslerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BipBusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtobusTablosuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.markatablosuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.modeltablosuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents OtobuslerDataGridView As DataGridView
    Friend WithEvents OtobusKayit_id As DataGridViewTextBoxColumn
    Friend WithEvents Plaka As DataGridViewTextBoxColumn
    Friend WithEvents MarkaNo As DataGridViewComboBoxColumn
    Friend WithEvents ModelNo As DataGridViewComboBoxColumn
    Friend WithEvents KoltukSayisi As DataGridViewTextBoxColumn
    Friend WithEvents Telefon As DataGridViewTextBoxColumn
    Friend WithEvents KoltukDizilisi As DataGridViewTextBoxColumn
    Friend WithEvents Kat As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents PlakaTextBox As TextBox
    Friend WithEvents AraButton As Button
    Friend WithEvents BipBusDataSet As DataSet
    Friend WithEvents OtobusTablosuBindingSource As BindingSource
    Friend WithEvents markatablosuBindingSource As BindingSource
    Friend WithEvents modeltablosuBindingSource As BindingSource
End Class

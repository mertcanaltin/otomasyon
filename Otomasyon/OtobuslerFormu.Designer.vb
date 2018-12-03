<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtobuslerFormu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PlakaTextBox = New System.Windows.Forms.TextBox()
        Me.MarkaNoComboBox = New System.Windows.Forms.ComboBox()
        Me.ModelNoComboBox = New System.Windows.Forms.ComboBox()
        Me.KoltukSayisiNUD = New System.Windows.Forms.NumericUpDown()
        Me.TelefonTextBox = New System.Windows.Forms.TextBox()
        Me.KoltukDizilisiComboBox = New System.Windows.Forms.ComboBox()
        Me.KatNUD = New System.Windows.Forms.NumericUpDown()
        Me.BipBusDataSet = New System.Data.DataSet()
        Me.OtobusTablosuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OtobusTablosuBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Kat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KoltukDizilisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KoltukSayisi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelNo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.MarkaNo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Plaka = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtobusKayit_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtobuslerDataGridView = New System.Windows.Forms.DataGridView()
        Me.AraButton = New System.Windows.Forms.Button()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MarkaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.KoltukSayisiNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KatNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BipBusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtobusTablosuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtobusTablosuBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OtobusTablosuBindingNavigator.SuspendLayout()
        CType(Me.OtobuslerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarkaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plaka:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Marka:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Model:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 148)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Koltuk Sayısı:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 175)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Telefon:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 202)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Koltuk Düzeni:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 228)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Kat Sayısı:"
        '
        'PlakaTextBox
        '
        Me.PlakaTextBox.Location = New System.Drawing.Point(153, 65)
        Me.PlakaTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PlakaTextBox.Name = "PlakaTextBox"
        Me.PlakaTextBox.Size = New System.Drawing.Size(161, 20)
        Me.PlakaTextBox.TabIndex = 7
        '
        'MarkaNoComboBox
        '
        Me.MarkaNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MarkaNoComboBox.FormattingEnabled = True
        Me.MarkaNoComboBox.Location = New System.Drawing.Point(154, 92)
        Me.MarkaNoComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.MarkaNoComboBox.Name = "MarkaNoComboBox"
        Me.MarkaNoComboBox.Size = New System.Drawing.Size(152, 21)
        Me.MarkaNoComboBox.TabIndex = 8
        '
        'ModelNoComboBox
        '
        Me.ModelNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ModelNoComboBox.FormattingEnabled = True
        Me.ModelNoComboBox.Location = New System.Drawing.Point(153, 119)
        Me.ModelNoComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ModelNoComboBox.Name = "ModelNoComboBox"
        Me.ModelNoComboBox.Size = New System.Drawing.Size(152, 21)
        Me.ModelNoComboBox.TabIndex = 9
        '
        'KoltukSayisiNUD
        '
        Me.KoltukSayisiNUD.Location = New System.Drawing.Point(153, 146)
        Me.KoltukSayisiNUD.Margin = New System.Windows.Forms.Padding(2)
        Me.KoltukSayisiNUD.Name = "KoltukSayisiNUD"
        Me.KoltukSayisiNUD.Size = New System.Drawing.Size(75, 20)
        Me.KoltukSayisiNUD.TabIndex = 10
        '
        'TelefonTextBox
        '
        Me.TelefonTextBox.Location = New System.Drawing.Point(153, 172)
        Me.TelefonTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TelefonTextBox.Name = "TelefonTextBox"
        Me.TelefonTextBox.Size = New System.Drawing.Size(113, 20)
        Me.TelefonTextBox.TabIndex = 11
        '
        'KoltukDizilisiComboBox
        '
        Me.KoltukDizilisiComboBox.FormattingEnabled = True
        Me.KoltukDizilisiComboBox.Location = New System.Drawing.Point(153, 199)
        Me.KoltukDizilisiComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.KoltukDizilisiComboBox.Name = "KoltukDizilisiComboBox"
        Me.KoltukDizilisiComboBox.Size = New System.Drawing.Size(92, 21)
        Me.KoltukDizilisiComboBox.TabIndex = 12
        '
        'KatNUD
        '
        Me.KatNUD.Location = New System.Drawing.Point(154, 227)
        Me.KatNUD.Margin = New System.Windows.Forms.Padding(2)
        Me.KatNUD.Name = "KatNUD"
        Me.KatNUD.Size = New System.Drawing.Size(47, 20)
        Me.KatNUD.TabIndex = 13
        '
        'BipBusDataSet
        '
        Me.BipBusDataSet.DataSetName = "NewDataSet"
        '
        'OtobusTablosuBindingSource
        '
        Me.OtobusTablosuBindingSource.DataSource = Me.BipBusDataSet
        Me.OtobusTablosuBindingSource.Position = 0
        '
        'OtobusTablosuBindingNavigator
        '
        Me.OtobusTablosuBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OtobusTablosuBindingNavigator.BindingSource = Me.OtobusTablosuBindingSource
        Me.OtobusTablosuBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OtobusTablosuBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OtobusTablosuBindingNavigator.ImageScalingSize = New System.Drawing.Size(48, 48)
        Me.OtobusTablosuBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.BindingNavigatorSaveItem})
        Me.OtobusTablosuBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OtobusTablosuBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OtobusTablosuBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OtobusTablosuBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OtobusTablosuBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OtobusTablosuBindingNavigator.Name = "OtobusTablosuBindingNavigator"
        Me.OtobusTablosuBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OtobusTablosuBindingNavigator.Size = New System.Drawing.Size(701, 55)
        Me.OtobusTablosuBindingNavigator.TabIndex = 14
        Me.OtobusTablosuBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 52)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 55)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
        Me.BindingNavigatorPositionItem.Text = "1"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 55)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'Kat
        '
        Me.Kat.DataPropertyName = "Kat"
        Me.Kat.HeaderText = "Kat Sayısı"
        Me.Kat.Name = "Kat"
        Me.Kat.ReadOnly = True
        '
        'KoltukDizilisi
        '
        Me.KoltukDizilisi.DataPropertyName = "KoltukDizilisi"
        Me.KoltukDizilisi.HeaderText = "Koltuk Düzeni"
        Me.KoltukDizilisi.Name = "KoltukDizilisi"
        Me.KoltukDizilisi.ReadOnly = True
        '
        'Telefon
        '
        Me.Telefon.DataPropertyName = "Telefon"
        Me.Telefon.HeaderText = "Telefon"
        Me.Telefon.Name = "Telefon"
        Me.Telefon.ReadOnly = True
        '
        'KoltukSayisi
        '
        Me.KoltukSayisi.DataPropertyName = "KoltukSayisi"
        Me.KoltukSayisi.HeaderText = "Koltuk Sayısı"
        Me.KoltukSayisi.Name = "KoltukSayisi"
        Me.KoltukSayisi.ReadOnly = True
        '
        'ModelNo
        '
        Me.ModelNo.DataPropertyName = "ModelNo"
        Me.ModelNo.HeaderText = "Modeli"
        Me.ModelNo.Name = "ModelNo"
        Me.ModelNo.ReadOnly = True
        '
        'MarkaNo
        '
        Me.MarkaNo.DataPropertyName = "MarkaNo"
        Me.MarkaNo.HeaderText = "Markası"
        Me.MarkaNo.Name = "MarkaNo"
        Me.MarkaNo.ReadOnly = True
        '
        'Plaka
        '
        Me.Plaka.DataPropertyName = "Plaka"
        Me.Plaka.HeaderText = "Otobüs Plakası"
        Me.Plaka.Name = "Plaka"
        Me.Plaka.ReadOnly = True
        '
        'OtobusKayit_id
        '
        Me.OtobusKayit_id.DataPropertyName = "OtobusKayit_id"
        Me.OtobusKayit_id.HeaderText = "OtobusKayit_id"
        Me.OtobusKayit_id.Name = "OtobusKayit_id"
        Me.OtobusKayit_id.ReadOnly = True
        Me.OtobusKayit_id.Visible = False
        '
        'OtobuslerDataGridView
        '
        Me.OtobuslerDataGridView.AllowUserToAddRows = False
        Me.OtobuslerDataGridView.AllowUserToDeleteRows = False
        Me.OtobuslerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OtobuslerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OtobusKayit_id, Me.Plaka, Me.MarkaNo, Me.ModelNo, Me.KoltukSayisi, Me.Telefon, Me.KoltukDizilisi, Me.Kat})
        Me.OtobuslerDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.OtobuslerDataGridView.Location = New System.Drawing.Point(349, 65)
        Me.OtobuslerDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.OtobuslerDataGridView.Name = "OtobuslerDataGridView"
        Me.OtobuslerDataGridView.ReadOnly = True
        Me.OtobuslerDataGridView.RowTemplate.Height = 24
        Me.OtobuslerDataGridView.Size = New System.Drawing.Size(343, 366)
        Me.OtobuslerDataGridView.TabIndex = 15
        '
        'AraButton
        '
        Me.AraButton.Image = Global.BipBusOtomasyon.My.Resources.Resources.ara1
        Me.AraButton.Location = New System.Drawing.Point(315, 65)
        Me.AraButton.Name = "AraButton"
        Me.AraButton.Size = New System.Drawing.Size(29, 20)
        Me.AraButton.TabIndex = 16
        Me.AraButton.UseVisualStyleBackColor = True
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = Global.BipBusOtomasyon.My.Resources.Resources.add
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(52, 52)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = Global.BipBusOtomasyon.My.Resources.Resources.delete
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(52, 52)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = Global.BipBusOtomasyon.My.Resources.Resources.first
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(52, 52)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = Global.BipBusOtomasyon.My.Resources.Resources.previous
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(52, 52)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = Global.BipBusOtomasyon.My.Resources.Resources._next
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(52, 52)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = Global.BipBusOtomasyon.My.Resources.Resources.last
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(52, 52)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorSaveItem.Image = Global.BipBusOtomasyon.My.Resources.Resources.save
        Me.BindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(52, 52)
        Me.BindingNavigatorSaveItem.Text = "ToolStripButton1"
        '
        'OtobuslerFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 440)
        Me.Controls.Add(Me.AraButton)
        Me.Controls.Add(Me.OtobuslerDataGridView)
        Me.Controls.Add(Me.OtobusTablosuBindingNavigator)
        Me.Controls.Add(Me.KatNUD)
        Me.Controls.Add(Me.KoltukDizilisiComboBox)
        Me.Controls.Add(Me.TelefonTextBox)
        Me.Controls.Add(Me.KoltukSayisiNUD)
        Me.Controls.Add(Me.ModelNoComboBox)
        Me.Controls.Add(Me.MarkaNoComboBox)
        Me.Controls.Add(Me.PlakaTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "OtobuslerFormu"
        Me.Text = "Otobüsler"
        CType(Me.KoltukSayisiNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KatNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BipBusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtobusTablosuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtobusTablosuBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OtobusTablosuBindingNavigator.ResumeLayout(False)
        Me.OtobusTablosuBindingNavigator.PerformLayout()
        CType(Me.OtobuslerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarkaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PlakaTextBox As TextBox
    Friend WithEvents MarkaNoComboBox As ComboBox
    Friend WithEvents ModelNoComboBox As ComboBox
    Friend WithEvents KoltukSayisiNUD As NumericUpDown
    Friend WithEvents TelefonTextBox As TextBox
    Friend WithEvents KoltukDizilisiComboBox As ComboBox
    Friend WithEvents KatNUD As NumericUpDown
    Friend WithEvents BipBusDataSet As DataSet
    Friend WithEvents OtobusTablosuBindingSource As BindingSource
    Friend WithEvents OtobusTablosuBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MarkaBindingSource As BindingSource
    Friend WithEvents ModelBindingSource As BindingSource
    Friend WithEvents Kat As DataGridViewTextBoxColumn
    Friend WithEvents KoltukDizilisi As DataGridViewTextBoxColumn
    Friend WithEvents Telefon As DataGridViewTextBoxColumn
    Friend WithEvents KoltukSayisi As DataGridViewTextBoxColumn
    Friend WithEvents ModelNo As DataGridViewComboBoxColumn
    Friend WithEvents MarkaNo As DataGridViewComboBoxColumn
    Friend WithEvents Plaka As DataGridViewTextBoxColumn
    Friend WithEvents OtobusKayit_id As DataGridViewTextBoxColumn
    Friend WithEvents OtobuslerDataGridView As DataGridView
    Friend WithEvents AraButton As Button
End Class

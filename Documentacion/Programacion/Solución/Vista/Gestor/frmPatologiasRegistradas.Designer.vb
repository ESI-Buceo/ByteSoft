﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatologiasRegistradas
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBuscar = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnEliminarElementos = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnModificarElemento = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnSeleccionMultiple = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrio = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnDesc = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnRec = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnNom = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnBuscarPor = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCantSelecc = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvListadoPatologias = New System.Windows.Forms.DataGridView()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvListadoPatologias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.Depth = 0
        Me.txtBuscar.Hint = ""
        Me.txtBuscar.Location = New System.Drawing.Point(262, 158)
        Me.txtBuscar.MaxLength = 32767
        Me.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscar.SelectedText = ""
        Me.txtBuscar.SelectionLength = 0
        Me.txtBuscar.SelectionStart = 0
        Me.txtBuscar.Size = New System.Drawing.Size(851, 23)
        Me.txtBuscar.TabIndex = 155
        Me.txtBuscar.TabStop = False
        Me.txtBuscar.Text = "Buscar"
        Me.txtBuscar.UseSystemPasswordChar = False
        '
        'btnEliminarElementos
        '
        Me.btnEliminarElementos.AutoSize = True
        Me.btnEliminarElementos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEliminarElementos.Depth = 0
        Me.btnEliminarElementos.Icon = Nothing
        Me.btnEliminarElementos.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnEliminarElementos.Location = New System.Drawing.Point(775, 96)
        Me.btnEliminarElementos.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEliminarElementos.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEliminarElementos.Name = "btnEliminarElementos"
        Me.btnEliminarElementos.Primary = False
        Me.btnEliminarElementos.Size = New System.Drawing.Size(265, 36)
        Me.btnEliminarElementos.TabIndex = 150
        Me.btnEliminarElementos.Text = "eliminar patología seleccionada"
        Me.btnEliminarElementos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarElementos.UseVisualStyleBackColor = True
        '
        'btnModificarElemento
        '
        Me.btnModificarElemento.AutoSize = True
        Me.btnModificarElemento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnModificarElemento.Depth = 0
        Me.btnModificarElemento.Icon = Nothing
        Me.btnModificarElemento.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnModificarElemento.Location = New System.Drawing.Point(431, 96)
        Me.btnModificarElemento.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnModificarElemento.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnModificarElemento.Name = "btnModificarElemento"
        Me.btnModificarElemento.Primary = False
        Me.btnModificarElemento.Size = New System.Drawing.Size(275, 36)
        Me.btnModificarElemento.TabIndex = 149
        Me.btnModificarElemento.Text = "modificar patología seleccionada"
        Me.btnModificarElemento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificarElemento.UseVisualStyleBackColor = True
        '
        'btnSeleccionMultiple
        '
        Me.btnSeleccionMultiple.AutoSize = True
        Me.btnSeleccionMultiple.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSeleccionMultiple.Depth = 0
        Me.btnSeleccionMultiple.Icon = Nothing
        Me.btnSeleccionMultiple.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnSeleccionMultiple.Location = New System.Drawing.Point(145, 96)
        Me.btnSeleccionMultiple.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSeleccionMultiple.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSeleccionMultiple.Name = "btnSeleccionMultiple"
        Me.btnSeleccionMultiple.Primary = False
        Me.btnSeleccionMultiple.Size = New System.Drawing.Size(222, 36)
        Me.btnSeleccionMultiple.TabIndex = 148
        Me.btnSeleccionMultiple.Text = "activar selección múltiple"
        Me.btnSeleccionMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionMultiple.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPrio)
        Me.Panel1.Controls.Add(Me.btnDesc)
        Me.Panel1.Controls.Add(Me.btnRec)
        Me.Panel1.Controls.Add(Me.btnNom)
        Me.Panel1.Controls.Add(Me.btnBuscarPor)
        Me.Panel1.Location = New System.Drawing.Point(1108, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 188)
        Me.Panel1.TabIndex = 147
        '
        'btnPrio
        '
        Me.btnPrio.AutoSize = True
        Me.btnPrio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPrio.Depth = 0
        Me.btnPrio.Icon = Nothing
        Me.btnPrio.Location = New System.Drawing.Point(0, 150)
        Me.btnPrio.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnPrio.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrio.Name = "btnPrio"
        Me.btnPrio.Primary = False
        Me.btnPrio.Size = New System.Drawing.Size(91, 36)
        Me.btnPrio.TabIndex = 137
        Me.btnPrio.Text = "prioridad"
        Me.btnPrio.UseVisualStyleBackColor = True
        Me.btnPrio.Visible = False
        '
        'btnDesc
        '
        Me.btnDesc.AutoSize = True
        Me.btnDesc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDesc.Depth = 0
        Me.btnDesc.Icon = Nothing
        Me.btnDesc.Location = New System.Drawing.Point(0, 114)
        Me.btnDesc.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnDesc.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDesc.Name = "btnDesc"
        Me.btnDesc.Primary = False
        Me.btnDesc.Size = New System.Drawing.Size(108, 36)
        Me.btnDesc.TabIndex = 136
        Me.btnDesc.Text = "descripción"
        Me.btnDesc.UseVisualStyleBackColor = True
        Me.btnDesc.Visible = False
        '
        'btnRec
        '
        Me.btnRec.AutoSize = True
        Me.btnRec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRec.Depth = 0
        Me.btnRec.Icon = Nothing
        Me.btnRec.Location = New System.Drawing.Point(0, 78)
        Me.btnRec.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRec.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnRec.Name = "btnRec"
        Me.btnRec.Primary = False
        Me.btnRec.Size = New System.Drawing.Size(135, 36)
        Me.btnRec.TabIndex = 135
        Me.btnRec.Text = "recomendación"
        Me.btnRec.UseVisualStyleBackColor = True
        Me.btnRec.Visible = False
        '
        'btnNom
        '
        Me.btnNom.AutoSize = True
        Me.btnNom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNom.Depth = 0
        Me.btnNom.Icon = Nothing
        Me.btnNom.Location = New System.Drawing.Point(0, 42)
        Me.btnNom.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNom.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNom.Name = "btnNom"
        Me.btnNom.Primary = False
        Me.btnNom.Size = New System.Drawing.Size(77, 36)
        Me.btnNom.TabIndex = 134
        Me.btnNom.Text = "nombre"
        Me.btnNom.UseVisualStyleBackColor = True
        Me.btnNom.Visible = False
        '
        'btnBuscarPor
        '
        Me.btnBuscarPor.AutoSize = True
        Me.btnBuscarPor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBuscarPor.Depth = 0
        Me.btnBuscarPor.Icon = Nothing
        Me.btnBuscarPor.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnBuscarPor.Location = New System.Drawing.Point(0, 0)
        Me.btnBuscarPor.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnBuscarPor.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBuscarPor.Name = "btnBuscarPor"
        Me.btnBuscarPor.Primary = False
        Me.btnBuscarPor.Size = New System.Drawing.Size(163, 36)
        Me.btnBuscarPor.TabIndex = 133
        Me.btnBuscarPor.Text = "buscar por nombre"
        Me.btnBuscarPor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarPor.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblCantSelecc)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(0, -2)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1375, 69)
        Me.Panel3.TabIndex = 146
        '
        'lblCantSelecc
        '
        Me.lblCantSelecc.AutoSize = True
        Me.lblCantSelecc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCantSelecc.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantSelecc.ForeColor = System.Drawing.Color.White
        Me.lblCantSelecc.Location = New System.Drawing.Point(49, 17)
        Me.lblCantSelecc.MaximumSize = New System.Drawing.Size(200, 0)
        Me.lblCantSelecc.Name = "lblCantSelecc"
        Me.lblCantSelecc.Size = New System.Drawing.Size(0, 39)
        Me.lblCantSelecc.TabIndex = 25
        Me.lblCantSelecc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Roboto Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(380, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(614, 45)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "LISTADO DE PATOLOGÍAS REGISTRADAS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvListadoPatologias
        '
        Me.dgvListadoPatologias.AllowUserToAddRows = False
        Me.dgvListadoPatologias.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 20)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvListadoPatologias.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoPatologias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListadoPatologias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoPatologias.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoPatologias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListadoPatologias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvListadoPatologias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoPatologias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListadoPatologias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(10, 20, 10, 20)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoPatologias.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListadoPatologias.EnableHeadersVisualStyles = False
        Me.dgvListadoPatologias.Location = New System.Drawing.Point(190, 213)
        Me.dgvListadoPatologias.MultiSelect = False
        Me.dgvListadoPatologias.Name = "dgvListadoPatologias"
        Me.dgvListadoPatologias.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoPatologias.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListadoPatologias.RowHeadersVisible = False
        Me.dgvListadoPatologias.RowHeadersWidth = 51
        Me.dgvListadoPatologias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListadoPatologias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoPatologias.Size = New System.Drawing.Size(994, 470)
        Me.dgvListadoPatologias.TabIndex = 145
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Vista.My.Resources.Resources.icons8_search_30px1
        Me.PictureBox4.Location = New System.Drawing.Point(1076, 103)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 29)
        Me.PictureBox4.TabIndex = 154
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Vista.My.Resources.Resources.icons8_single_choice_24px1
        Me.PictureBox3.Location = New System.Drawing.Point(113, 103)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 29)
        Me.PictureBox3.TabIndex = 153
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Vista.My.Resources.Resources.icons8_delete_48px_11
        Me.PictureBox2.Location = New System.Drawing.Point(738, 102)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 152
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Vista.My.Resources.Resources.icons8_edit_24px1
        Me.PictureBox1.Location = New System.Drawing.Point(399, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 29)
        Me.PictureBox1.TabIndex = 151
        Me.PictureBox1.TabStop = False
        '
        'frmPatologiasRegistradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1375, 704)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEliminarElementos)
        Me.Controls.Add(Me.btnModificarElemento)
        Me.Controls.Add(Me.btnSeleccionMultiple)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgvListadoPatologias)
        Me.Name = "frmPatologiasRegistradas"
        Me.Text = "ListadoPatologias"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvListadoPatologias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtBuscar As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnEliminarElementos As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnModificarElemento As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnSeleccionMultiple As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrio As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnDesc As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnRec As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnNom As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnBuscarPor As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCantSelecc As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvListadoPatologias As DataGridView
End Class

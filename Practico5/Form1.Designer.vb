<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Button2 = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label5 = New Label()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        DataGridView1 = New DataGridView()
        apellido = New DataGridViewTextBoxColumn()
        fechNac = New DataGridViewTextBoxColumn()
        sexo = New DataGridViewTextBoxColumn()
        eliminar = New DataGridViewTextBoxColumn()
        saldo = New DataGridViewTextBoxColumn()
        foto = New DataGridViewTextBoxColumn()
        ruta = New DataGridViewTextBoxColumn()
        nombre = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.catt
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(RadioButton2)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(36, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(451, 257)
        Panel1.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(28, 173)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 13
        Button2.Text = "Foto"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(154, 174)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(265, 20)
        TextBox4.TabIndex = 12
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(154, 142)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(265, 20)
        TextBox3.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(154, 45)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(265, 20)
        TextBox2.TabIndex = 10
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(154, 11)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(265, 20)
        TextBox1.TabIndex = 9
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.BackColor = SystemColors.ActiveCaptionText
        RadioButton2.Cursor = Cursors.Hand
        RadioButton2.Font = New Font("Papyrus", 9.75F)
        RadioButton2.ForeColor = Color.White
        RadioButton2.Location = New Point(239, 107)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(63, 25)
        RadioButton2.TabIndex = 8
        RadioButton2.Text = "Mujer"
        RadioButton2.UseVisualStyleBackColor = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = SystemColors.ActiveCaptionText
        RadioButton1.Checked = True
        RadioButton1.Cursor = Cursors.Hand
        RadioButton1.Font = New Font("Papyrus", 9.75F)
        RadioButton1.ForeColor = Color.White
        RadioButton1.Location = New Point(155, 107)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(78, 25)
        RadioButton1.TabIndex = 7
        RadioButton1.TabStop = True
        RadioButton1.Text = "Hombre"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ActiveCaptionText
        Label5.ForeColor = Color.White
        Label5.Location = New Point(21, 135)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 34)
        Label5.TabIndex = 6
        Label5.Text = "Saldo:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ActiveCaptionText
        Label4.ForeColor = Color.White
        Label4.Location = New Point(21, 101)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 34)
        Label4.TabIndex = 5
        Label4.Text = "Sexo:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Cursor = Cursors.Hand
        DateTimePicker1.Font = New Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(251, 76)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(77, 22)
        DateTimePicker1.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaptionText
        Label3.ForeColor = Color.White
        Label3.Location = New Point(21, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(194, 34)
        Label3.TabIndex = 3
        Label3.Text = "Fecha Nacimiento:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.ForeColor = Color.White
        Label2.Location = New Point(21, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 34)
        Label2.TabIndex = 2
        Label2.Text = "Apellido:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.ForeColor = Color.White
        Label1.Location = New Point(21, 4)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 34)
        Label1.TabIndex = 1
        Label1.Text = "Nombre:"
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Image = My.Resources.Resources.vintage
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(185, 207)
        Button1.Margin = New Padding(1)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 39)
        Button1.TabIndex = 0
        Button1.Text = "Guardar"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.TextImageRelation = TextImageRelation.ImageBeforeText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.user1
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Cursor = Cursors.Default
        PictureBox1.Location = New Point(516, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(232, 257)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {apellido, fechNac, sexo, eliminar, saldo, foto, ruta, nombre})
        DataGridView1.Cursor = Cursors.Default
        DataGridView1.Location = New Point(36, 293)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 10
        DataGridView1.Size = New Size(712, 236)
        DataGridView1.TabIndex = 2
        ' 
        ' apellido
        ' 
        apellido.HeaderText = "Apellido"
        apellido.Name = "apellido"
        ' 
        ' fechNac
        ' 
        fechNac.HeaderText = "Fecha Nacimiento"
        fechNac.Name = "fechNac"
        ' 
        ' sexo
        ' 
        sexo.HeaderText = "Sexo"
        sexo.Name = "sexo"
        ' 
        ' eliminar
        ' 
        eliminar.HeaderText = "Eliminar"
        eliminar.Name = "eliminar"
        ' 
        ' saldo
        ' 
        saldo.HeaderText = "Saldo"
        saldo.Name = "saldo"
        ' 
        ' foto
        ' 
        foto.HeaderText = "Foto"
        foto.Name = "foto"
        ' 
        ' ruta
        ' 
        ruta.HeaderText = "Ruta"
        ruta.Name = "ruta"
        ' 
        ' nombre
        ' 
        nombre.HeaderText = "Nombre"
        nombre.Name = "nombre"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(14F, 33F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.tony
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(786, 541)
        Controls.Add(DataGridView1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Cursor = Cursors.Default
        Font = New Font("Papyrus", 16F)
        Margin = New Padding(5, 7, 5, 7)
        Name = "Form1"
        Text = "Formulario con DataGrid"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents fechNac As DataGridViewTextBoxColumn
    Friend WithEvents sexo As DataGridViewTextBoxColumn
    Friend WithEvents eliminar As DataGridViewTextBoxColumn
    Friend WithEvents saldo As DataGridViewTextBoxColumn
    Friend WithEvents foto As DataGridViewTextBoxColumn
    Friend WithEvents ruta As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn

End Class

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
        lblNama = New Label()
        txtNama = New TextBox()
        txtNotelephone = New TextBox()
        lblNotelephone = New Label()
        lblAlamat = New Label()
        lblNegeri = New Label()
        txtAlamat = New TextBox()
        lblJantina = New Label()
        cbbNegeri = New ComboBox()
        rdoLelaki = New RadioButton()
        rdoPerempuan = New RadioButton()
        lblBayaran = New Label()
        rdoCash = New RadioButton()
        rdoCashless = New RadioButton()
        lblPerisa = New Label()
        rdoCoklat = New CheckBox()
        rdoStrawberi = New CheckBox()
        dgwJadual = New DataGridView()
        dtpDate = New DateTimePicker()
        Me.BtnCreate = New Button()
        Me.BtnRread = New Button()
        Me.BtnUpdate = New Button()
        Me.BtnDelete = New Button()
        gpbJantina = New GroupBox()
        gpbBayaran = New GroupBox()
        lblMaklumatPelajdar = New Label()
        lblDate = New Label()
        clmBil = New DataGridViewTextBoxColumn()
        clmNama = New DataGridViewTextBoxColumn()
        clmNotelephone = New DataGridViewTextBoxColumn()
        CType(dgwJadual, ComponentModel.ISupportInitialize).BeginInit()
        gpbJantina.SuspendLayout()
        gpbBayaran.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(27, 62)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(65, 25)
        lblNama.TabIndex = 0
        lblNama.Text = "NAMA"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(155, 62)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 1
        ' 
        ' txtNotelephone
        ' 
        txtNotelephone.Location = New Point(155, 119)
        txtNotelephone.Name = "txtNotelephone"
        txtNotelephone.Size = New Size(150, 31)
        txtNotelephone.TabIndex = 2
        ' 
        ' lblNotelephone
        ' 
        lblNotelephone.AutoSize = True
        lblNotelephone.Location = New Point(27, 125)
        lblNotelephone.Name = "lblNotelephone"
        lblNotelephone.Size = New Size(121, 25)
        lblNotelephone.TabIndex = 3
        lblNotelephone.Text = "No Telephone"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(27, 179)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(68, 25)
        lblAlamat.TabIndex = 4
        lblAlamat.Text = "Alamat"
        ' 
        ' lblNegeri
        ' 
        lblNegeri.AutoSize = True
        lblNegeri.Location = New Point(26, 276)
        lblNegeri.Name = "lblNegeri"
        lblNegeri.Size = New Size(64, 25)
        lblNegeri.TabIndex = 5
        lblNegeri.Text = "Negeri"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(155, 176)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(150, 79)
        txtAlamat.TabIndex = 6
        ' 
        ' lblJantina
        ' 
        lblJantina.AutoSize = True
        lblJantina.Location = New Point(6, 48)
        lblJantina.Name = "lblJantina"
        lblJantina.Size = New Size(66, 25)
        lblJantina.TabIndex = 7
        lblJantina.Text = "Jantina"
        ' 
        ' cbbNegeri
        ' 
        cbbNegeri.FormattingEnabled = True
        cbbNegeri.Items.AddRange(New Object() {"KEDAH", "SELANGOR"})
        cbbNegeri.Location = New Point(154, 276)
        cbbNegeri.Name = "cbbNegeri"
        cbbNegeri.Size = New Size(182, 33)
        cbbNegeri.TabIndex = 8
        ' 
        ' rdoLelaki
        ' 
        rdoLelaki.AutoSize = True
        rdoLelaki.Location = New Point(132, 53)
        rdoLelaki.Name = "rdoLelaki"
        rdoLelaki.Size = New Size(80, 29)
        rdoLelaki.TabIndex = 9
        rdoLelaki.TabStop = True
        rdoLelaki.Text = "Lelaki"
        rdoLelaki.UseVisualStyleBackColor = True
        ' 
        ' rdoPerempuan
        ' 
        rdoPerempuan.AutoSize = True
        rdoPerempuan.Location = New Point(218, 53)
        rdoPerempuan.Name = "rdoPerempuan"
        rdoPerempuan.Size = New Size(126, 29)
        rdoPerempuan.TabIndex = 10
        rdoPerempuan.TabStop = True
        rdoPerempuan.Text = "Perempuan"
        rdoPerempuan.UseVisualStyleBackColor = True
        ' 
        ' lblBayaran
        ' 
        lblBayaran.AutoSize = True
        lblBayaran.Location = New Point(1, 37)
        lblBayaran.Name = "lblBayaran"
        lblBayaran.Size = New Size(74, 25)
        lblBayaran.TabIndex = 11
        lblBayaran.Text = "Bayaran"
        ' 
        ' rdoCash
        ' 
        rdoCash.AutoSize = True
        rdoCash.Location = New Point(122, 41)
        rdoCash.Name = "rdoCash"
        rdoCash.Size = New Size(75, 29)
        rdoCash.TabIndex = 12
        rdoCash.TabStop = True
        rdoCash.Text = "Cash"
        rdoCash.UseVisualStyleBackColor = True
        ' 
        ' rdoCashless
        ' 
        rdoCashless.AutoSize = True
        rdoCashless.Location = New Point(208, 41)
        rdoCashless.Name = "rdoCashless"
        rdoCashless.Size = New Size(104, 29)
        rdoCashless.TabIndex = 13
        rdoCashless.TabStop = True
        rdoCashless.Text = "Cashless"
        rdoCashless.UseVisualStyleBackColor = True
        ' 
        ' lblPerisa
        ' 
        lblPerisa.AutoSize = True
        lblPerisa.Location = New Point(440, 69)
        lblPerisa.Name = "lblPerisa"
        lblPerisa.Size = New Size(57, 25)
        lblPerisa.TabIndex = 14
        lblPerisa.Text = "Perisa"
        ' 
        ' rdoCoklat
        ' 
        rdoCoklat.AutoSize = True
        rdoCoklat.Location = New Point(504, 68)
        rdoCoklat.Name = "rdoCoklat"
        rdoCoklat.Size = New Size(88, 29)
        rdoCoklat.TabIndex = 15
        rdoCoklat.Text = "Coklat"
        rdoCoklat.UseVisualStyleBackColor = True
        ' 
        ' rdoStrawberi
        ' 
        rdoStrawberi.AutoSize = True
        rdoStrawberi.Location = New Point(506, 103)
        rdoStrawberi.Name = "rdoStrawberi"
        rdoStrawberi.Size = New Size(111, 29)
        rdoStrawberi.TabIndex = 16
        rdoStrawberi.Text = "Strawberi"
        rdoStrawberi.UseVisualStyleBackColor = True
        ' 
        ' dgwJadual
        ' 
        dgwJadual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgwJadual.Columns.AddRange(New DataGridViewColumn() {clmBil, clmNama, clmNotelephone})
        dgwJadual.Location = New Point(421, 198)
        dgwJadual.Name = "dgwJadual"
        dgwJadual.RowHeadersWidth = 62
        dgwJadual.Size = New Size(488, 103)
        dgwJadual.TabIndex = 17
        ' 
        ' dtpDate
        ' 
        dtpDate.Location = New Point(527, 144)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(284, 31)
        dtpDate.TabIndex = 18
        ' 
        ' BtnCreate
        ' 
        Me.BtnCreate.Location = New Point(429, 325)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New Size(112, 34)
        Me.BtnCreate.TabIndex = 19
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = True
        ' 
        ' BtnRread
        ' 
        Me.BtnRread.Location = New Point(429, 372)
        Me.BtnRread.Name = "BtnRread"
        Me.BtnRread.Size = New Size(112, 34)
        Me.BtnRread.TabIndex = 20
        Me.BtnRread.Text = "Read"
        Me.BtnRread.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        Me.BtnUpdate.Location = New Point(560, 325)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New Size(112, 34)
        Me.BtnUpdate.TabIndex = 21
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        Me.BtnDelete.Location = New Point(560, 372)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New Size(112, 34)
        Me.BtnDelete.TabIndex = 22
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' gpbJantina
        ' 
        gpbJantina.Controls.Add(lblJantina)
        gpbJantina.Controls.Add(rdoLelaki)
        gpbJantina.Controls.Add(rdoPerempuan)
        gpbJantina.Location = New Point(12, 338)
        gpbJantina.Name = "gpbJantina"
        gpbJantina.Size = New Size(405, 150)
        gpbJantina.TabIndex = 23
        gpbJantina.TabStop = False
        gpbJantina.Text = "Jantina"
        ' 
        ' gpbBayaran
        ' 
        gpbBayaran.Controls.Add(lblBayaran)
        gpbBayaran.Controls.Add(rdoCash)
        gpbBayaran.Controls.Add(rdoCashless)
        gpbBayaran.Location = New Point(12, 494)
        gpbBayaran.Name = "gpbBayaran"
        gpbBayaran.Size = New Size(405, 150)
        gpbBayaran.TabIndex = 24
        gpbBayaran.TabStop = False
        gpbBayaran.Text = "Bayaran"
        ' 
        ' lblMaklumatPelajdar
        ' 
        lblMaklumatPelajdar.AutoSize = True
        lblMaklumatPelajdar.Font = New Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMaklumatPelajdar.Location = New Point(26, 9)
        lblMaklumatPelajdar.Name = "lblMaklumatPelajdar"
        lblMaklumatPelajdar.Size = New Size(264, 38)
        lblMaklumatPelajdar.TabIndex = 25
        lblMaklumatPelajdar.Text = "Maklumat Pelajar"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Location = New Point(440, 149)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(49, 25)
        lblDate.TabIndex = 26
        lblDate.Text = "Date"
        ' 
        ' clmBil
        ' 
        clmBil.HeaderText = "Bil"
        clmBil.MinimumWidth = 8
        clmBil.Name = "clmBil"
        clmBil.Width = 150
        ' 
        ' clmNama
        ' 
        clmNama.HeaderText = "Nama"
        clmNama.MinimumWidth = 8
        clmNama.Name = "clmNama"
        clmNama.Width = 150
        ' 
        ' clmNotelephone
        ' 
        clmNotelephone.HeaderText = "NoTelephone"
        clmNotelephone.MinimumWidth = 8
        clmNotelephone.Name = "clmNotelephone"
        clmNotelephone.Width = 150
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(932, 730)
        Controls.Add(lblDate)
        Controls.Add(lblMaklumatPelajdar)
        Controls.Add(gpbBayaran)
        Controls.Add(gpbJantina)
        Controls.Add(Me.BtnDelete)
        Controls.Add(Me.BtnUpdate)
        Controls.Add(Me.BtnRread)
        Controls.Add(Me.BtnCreate)
        Controls.Add(dtpDate)
        Controls.Add(dgwJadual)
        Controls.Add(rdoStrawberi)
        Controls.Add(rdoCoklat)
        Controls.Add(lblPerisa)
        Controls.Add(cbbNegeri)
        Controls.Add(txtAlamat)
        Controls.Add(lblNegeri)
        Controls.Add(lblAlamat)
        Controls.Add(lblNotelephone)
        Controls.Add(txtNotelephone)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Name = "Form1"
        Text = "Maklumat Pelanggan"
        CType(dgwJadual, ComponentModel.ISupportInitialize).EndInit()
        gpbJantina.ResumeLayout(False)
        gpbJantina.PerformLayout()
        gpbBayaran.ResumeLayout(False)
        gpbBayaran.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNotelephone As TextBox
    Friend WithEvents lblNotelephone As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblNegeri As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblJantina As Label
    Friend WithEvents cbbNegeri As ComboBox
    Friend WithEvents rdoLelaki As RadioButton
    Friend WithEvents rdoPerempuan As RadioButton
    Friend WithEvents lblBayaran As Label
    Friend WithEvents rdoCash As RadioButton
    Friend WithEvents rdoCashless As RadioButton
    Friend WithEvents lblPerisa As Label
    Friend WithEvents rdoCoklat As CheckBox
    Friend WithEvents rdoStrawberi As CheckBox
    Friend WithEvents dgwJadual As DataGridView
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Bil As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents NoPhone As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents gpbJantina As GroupBox
    Friend WithEvents gpbBayaran As GroupBox
    Friend WithEvents lblMaklumatPelajdar As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents clmBil As DataGridViewTextBoxColumn
    Friend WithEvents clmNama As DataGridViewTextBoxColumn
    Friend WithEvents clmNotelephone As DataGridViewTextBoxColumn

End Class

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
        Label1 = New Label()
        TxtNama = New TextBox()
        TxtNotelephone = New TextBox()
        lblNotelephone = New Label()
        lblAlamat = New Label()
        lblNegeri = New Label()
        TxtAlamat = New TextBox()
        lblJantina = New Label()
        CbbNegeri = New ComboBox()
        RdoLelaki = New RadioButton()
        RdoPerempuan = New RadioButton()
        lblBayaran = New Label()
        RdoCash = New RadioButton()
        RdoCashless = New RadioButton()
        lblPerisa = New Label()
        RdoCoklat = New CheckBox()
        RdoStrawberi = New CheckBox()
        DataGridView1 = New DataGridView()
        dtpDate = New DateTimePicker()
        Me.BtnCreate = New Button()
        Me.BtnRread = New Button()
        Me.BtnUpdate = New Button()
        Me.BtnDelete = New Button()
        GpbJantina = New GroupBox()
        GpbBayaran = New GroupBox()
        lblMaklumatPelajdar = New Label()
        lblDate = New Label()
        clmBil = New DataGridViewTextBoxColumn()
        clmNama = New DataGridViewTextBoxColumn()
        clmNotelephone = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GpbJantina.SuspendLayout()
        GpbBayaran.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 25)
        Label1.TabIndex = 0
        Label1.Text = "NAMA"
        ' 
        ' TxtNama
        ' 
        TxtNama.Location = New Point(155, 62)
        TxtNama.Name = "TxtNama"
        TxtNama.Size = New Size(150, 31)
        TxtNama.TabIndex = 1
        ' 
        ' TxtNotelephone
        ' 
        TxtNotelephone.Location = New Point(155, 119)
        TxtNotelephone.Name = "TxtNotelephone"
        TxtNotelephone.Size = New Size(150, 31)
        TxtNotelephone.TabIndex = 2
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
        ' TxtAlamat
        ' 
        TxtAlamat.Location = New Point(155, 176)
        TxtAlamat.Multiline = True
        TxtAlamat.Name = "TxtAlamat"
        TxtAlamat.Size = New Size(150, 79)
        TxtAlamat.TabIndex = 6
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
        ' CbbNegeri
        ' 
        CbbNegeri.FormattingEnabled = True
        CbbNegeri.Items.AddRange(New Object() {"KEDAH", "SELANGOR"})
        CbbNegeri.Location = New Point(154, 276)
        CbbNegeri.Name = "CbbNegeri"
        CbbNegeri.Size = New Size(182, 33)
        CbbNegeri.TabIndex = 8
        ' 
        ' RdoLelaki
        ' 
        RdoLelaki.AutoSize = True
        RdoLelaki.Location = New Point(132, 53)
        RdoLelaki.Name = "RdoLelaki"
        RdoLelaki.Size = New Size(80, 29)
        RdoLelaki.TabIndex = 9
        RdoLelaki.TabStop = True
        RdoLelaki.Text = "Lelaki"
        RdoLelaki.UseVisualStyleBackColor = True
        ' 
        ' RdoPerempuan
        ' 
        RdoPerempuan.AutoSize = True
        RdoPerempuan.Location = New Point(218, 53)
        RdoPerempuan.Name = "RdoPerempuan"
        RdoPerempuan.Size = New Size(126, 29)
        RdoPerempuan.TabIndex = 10
        RdoPerempuan.TabStop = True
        RdoPerempuan.Text = "Perempuan"
        RdoPerempuan.UseVisualStyleBackColor = True
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
        ' RdoCash
        ' 
        RdoCash.AutoSize = True
        RdoCash.Location = New Point(122, 41)
        RdoCash.Name = "RdoCash"
        RdoCash.Size = New Size(75, 29)
        RdoCash.TabIndex = 12
        RdoCash.TabStop = True
        RdoCash.Text = "Cash"
        RdoCash.UseVisualStyleBackColor = True
        ' 
        ' RdoCashless
        ' 
        RdoCashless.AutoSize = True
        RdoCashless.Location = New Point(208, 41)
        RdoCashless.Name = "RdoCashless"
        RdoCashless.Size = New Size(104, 29)
        RdoCashless.TabIndex = 13
        RdoCashless.TabStop = True
        RdoCashless.Text = "Cashless"
        RdoCashless.UseVisualStyleBackColor = True
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
        ' RdoCoklat
        ' 
        RdoCoklat.AutoSize = True
        RdoCoklat.Location = New Point(504, 68)
        RdoCoklat.Name = "RdoCoklat"
        RdoCoklat.Size = New Size(88, 29)
        RdoCoklat.TabIndex = 15
        RdoCoklat.Text = "Coklat"
        RdoCoklat.UseVisualStyleBackColor = True
        ' 
        ' RdoStrawberi
        ' 
        RdoStrawberi.AutoSize = True
        RdoStrawberi.Location = New Point(506, 103)
        RdoStrawberi.Name = "RdoStrawberi"
        RdoStrawberi.Size = New Size(111, 29)
        RdoStrawberi.TabIndex = 16
        RdoStrawberi.Text = "Strawberi"
        RdoStrawberi.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {clmBil, clmNama, clmNotelephone})
        DataGridView1.Location = New Point(421, 198)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(488, 103)
        DataGridView1.TabIndex = 17
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
        ' GpbJantina
        ' 
        GpbJantina.Controls.Add(lblJantina)
        GpbJantina.Controls.Add(RdoLelaki)
        GpbJantina.Controls.Add(RdoPerempuan)
        GpbJantina.Location = New Point(12, 338)
        GpbJantina.Name = "GpbJantina"
        GpbJantina.Size = New Size(405, 150)
        GpbJantina.TabIndex = 23
        GpbJantina.TabStop = False
        GpbJantina.Text = "Jantina"
        ' 
        ' GpbBayaran
        ' 
        GpbBayaran.Controls.Add(lblBayaran)
        GpbBayaran.Controls.Add(RdoCash)
        GpbBayaran.Controls.Add(RdoCashless)
        GpbBayaran.Location = New Point(12, 494)
        GpbBayaran.Name = "GpbBayaran"
        GpbBayaran.Size = New Size(405, 150)
        GpbBayaran.TabIndex = 24
        GpbBayaran.TabStop = False
        GpbBayaran.Text = "Bayaran"
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
        Controls.Add(GpbBayaran)
        Controls.Add(GpbJantina)
        Controls.Add(Me.BtnDelete)
        Controls.Add(Me.BtnUpdate)
        Controls.Add(Me.BtnRread)
        Controls.Add(Me.BtnCreate)
        Controls.Add(dtpDate)
        Controls.Add(DataGridView1)
        Controls.Add(RdoStrawberi)
        Controls.Add(RdoCoklat)
        Controls.Add(lblPerisa)
        Controls.Add(CbbNegeri)
        Controls.Add(TxtAlamat)
        Controls.Add(lblNegeri)
        Controls.Add(lblAlamat)
        Controls.Add(lblNotelephone)
        Controls.Add(TxtNotelephone)
        Controls.Add(TxtNama)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Maklumat Pelanggan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GpbJantina.ResumeLayout(False)
        GpbJantina.PerformLayout()
        GpbBayaran.ResumeLayout(False)
        GpbBayaran.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtNotelephone As TextBox
    Friend WithEvents lblNotelephone As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblNegeri As Label
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents lblJantina As Label
    Friend WithEvents CbbNegeri As ComboBox
    Friend WithEvents RdoLelaki As RadioButton
    Friend WithEvents RdoPerempuan As RadioButton
    Friend WithEvents lblBayaran As Label
    Friend WithEvents RdoCash As RadioButton
    Friend WithEvents RdoCashless As RadioButton
    Friend WithEvents lblPerisa As Label
    Friend WithEvents RdoCoklat As CheckBox
    Friend WithEvents RdoStrawberi As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Bil As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents NoPhone As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GpbJantina As GroupBox
    Friend WithEvents GpbBayaran As GroupBox
    Friend WithEvents lblMaklumatPelajdar As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents clmBil As DataGridViewTextBoxColumn
    Friend WithEvents clmNama As DataGridViewTextBoxColumn
    Friend WithEvents clmNotelephone As DataGridViewTextBoxColumn

End Class

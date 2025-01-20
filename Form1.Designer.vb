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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TxtAlamat = New TextBox()
        Label5 = New Label()
        CbbNegeri = New ComboBox()
        RdoLelaki = New RadioButton()
        RdoPerempuan = New RadioButton()
        Label6 = New Label()
        RdoCash = New RadioButton()
        RdoCashless = New RadioButton()
        Label7 = New Label()
        RdoCoklat = New CheckBox()
        RdoStrawberi = New CheckBox()
        DataGridView1 = New DataGridView()
        Bil = New DataGridViewTextBoxColumn()
        Nama = New DataGridViewTextBoxColumn()
        NoPhone = New DataGridViewTextBoxColumn()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        GpbJantina = New GroupBox()
        GpbBayaran = New GroupBox()
        Label8 = New Label()
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 25)
        Label2.TabIndex = 3
        Label2.Text = "No Telephone"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 25)
        Label3.TabIndex = 4
        Label3.Text = "Alamat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 276)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 25)
        Label4.TabIndex = 5
        Label4.Text = "Negeri"
        ' 
        ' TxtAlamat
        ' 
        TxtAlamat.Location = New Point(155, 176)
        TxtAlamat.Multiline = True
        TxtAlamat.Name = "TxtAlamat"
        TxtAlamat.Size = New Size(150, 79)
        TxtAlamat.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 48)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 25)
        Label5.TabIndex = 7
        Label5.Text = "Jantina"
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(1, 37)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 25)
        Label6.TabIndex = 11
        Label6.Text = "Bayaran"
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
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(440, 69)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 25)
        Label7.TabIndex = 14
        Label7.Text = "Perisa"
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Bil, Nama, NoPhone})
        DataGridView1.Location = New Point(421, 198)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(488, 103)
        DataGridView1.TabIndex = 17
        ' 
        ' Bil
        ' 
        Bil.HeaderText = "Bil"
        Bil.MinimumWidth = 8
        Bil.Name = "Bil"
        Bil.Width = 150
        ' 
        ' Nama
        ' 
        Nama.HeaderText = "Nama"
        Nama.MinimumWidth = 8
        Nama.Name = "Nama"
        Nama.Width = 150
        ' 
        ' NoPhone
        ' 
        NoPhone.HeaderText = "NoTelephone"
        NoPhone.MinimumWidth = 8
        NoPhone.Name = "NoPhone"
        NoPhone.Width = 150
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(504, 138)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(284, 31)
        DateTimePicker1.TabIndex = 18
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(429, 325)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 19
        Button1.Text = "Create"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(429, 372)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 20
        Button2.Text = "Read"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(560, 325)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 21
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(560, 372)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 22
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' GpbJantina
        ' 
        GpbJantina.Controls.Add(Label5)
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
        GpbBayaran.Controls.Add(Label6)
        GpbBayaran.Controls.Add(RdoCash)
        GpbBayaran.Controls.Add(RdoCashless)
        GpbBayaran.Location = New Point(12, 494)
        GpbBayaran.Name = "GpbBayaran"
        GpbBayaran.Size = New Size(405, 150)
        GpbBayaran.TabIndex = 24
        GpbBayaran.TabStop = False
        GpbBayaran.Text = "Bayaran"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(26, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(146, 25)
        Label8.TabIndex = 25
        Label8.Text = "Maklumat Pelajar"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(932, 730)
        Controls.Add(Label8)
        Controls.Add(GpbBayaran)
        Controls.Add(GpbJantina)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(DataGridView1)
        Controls.Add(RdoStrawberi)
        Controls.Add(RdoCoklat)
        Controls.Add(Label7)
        Controls.Add(CbbNegeri)
        Controls.Add(TxtAlamat)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAlamat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CbbNegeri As ComboBox
    Friend WithEvents RdoLelaki As RadioButton
    Friend WithEvents RdoPerempuan As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents RdoCash As RadioButton
    Friend WithEvents RdoCashless As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents RdoCoklat As CheckBox
    Friend WithEvents RdoStrawberi As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Bil As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents NoPhone As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GpbJantina As GroupBox
    Friend WithEvents GpbBayaran As GroupBox
    Friend WithEvents Label8 As Label

End Class

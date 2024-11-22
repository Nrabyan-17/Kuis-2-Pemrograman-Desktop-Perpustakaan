<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        cbo_buku = New ComboBox()
        cbo_anggota = New ComboBox()
        dtpPinjam = New DateTimePicker()
        dtpKembali = New DateTimePicker()
        tbl_pinjam = New DataGridView()
        btntambah = New Button()
        btnsimpan = New Button()
        btnhapus = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label6 = New Label()
        txtjumlah = New TextBox()
        CType(tbl_pinjam, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(208, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(359, 30)
        Label1.TabIndex = 0
        Label1.Text = "FORM TAMBAH PEMINJAMAN BUKU"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(77, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 1
        Label2.Text = "NAMA BUKU"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(77, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 15)
        Label3.TabIndex = 2
        Label3.Text = "NAMA ANGGOTA"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(430, 88)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 15)
        Label4.TabIndex = 3
        Label4.Text = "TANGGAL PINJAM"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(430, 144)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 15)
        Label5.TabIndex = 4
        Label5.Text = "TANGGAL KEMBALIAN"
        ' 
        ' cbo_buku
        ' 
        cbo_buku.FormattingEnabled = True
        cbo_buku.Location = New Point(208, 88)
        cbo_buku.Name = "cbo_buku"
        cbo_buku.Size = New Size(121, 23)
        cbo_buku.TabIndex = 5
        ' 
        ' cbo_anggota
        ' 
        cbo_anggota.FormattingEnabled = True
        cbo_anggota.Location = New Point(208, 144)
        cbo_anggota.Name = "cbo_anggota"
        cbo_anggota.Size = New Size(121, 23)
        cbo_anggota.TabIndex = 6
        ' 
        ' dtpPinjam
        ' 
        dtpPinjam.Location = New Point(576, 85)
        dtpPinjam.Name = "dtpPinjam"
        dtpPinjam.Size = New Size(200, 23)
        dtpPinjam.TabIndex = 7
        ' 
        ' dtpKembali
        ' 
        dtpKembali.Location = New Point(576, 141)
        dtpKembali.Name = "dtpKembali"
        dtpKembali.Size = New Size(200, 23)
        dtpKembali.TabIndex = 8
        ' 
        ' tbl_pinjam
        ' 
        tbl_pinjam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tbl_pinjam.Location = New Point(77, 222)
        tbl_pinjam.Name = "tbl_pinjam"
        tbl_pinjam.RowTemplate.Height = 25
        tbl_pinjam.Size = New Size(683, 151)
        tbl_pinjam.TabIndex = 9
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(77, 181)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(75, 23)
        btntambah.TabIndex = 10
        btntambah.Text = "TAMBAH"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' btnsimpan
        ' 
        btnsimpan.Location = New Point(77, 393)
        btnsimpan.Name = "btnsimpan"
        btnsimpan.Size = New Size(75, 23)
        btnsimpan.TabIndex = 11
        btnsimpan.Text = "SIMPAN "
        btnsimpan.UseVisualStyleBackColor = True
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(208, 181)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(75, 23)
        btnhapus.TabIndex = 12
        btnhapus.Text = "HAPUS"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(612, 393)
        Button3.Name = "Button3"
        Button3.Size = New Size(132, 24)
        Button3.TabIndex = 16
        Button3.Text = "form laporan"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(455, 393)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 24)
        Button2.TabIndex = 15
        Button2.Text = "form buku"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(276, 392)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 24)
        Button1.TabIndex = 14
        Button1.Text = "form anggota"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(430, 189)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 15)
        Label6.TabIndex = 17
        Label6.Text = "JUMLAH"
        ' 
        ' txtjumlah
        ' 
        txtjumlah.Location = New Point(576, 189)
        txtjumlah.Name = "txtjumlah"
        txtjumlah.Size = New Size(200, 23)
        txtjumlah.TabIndex = 18
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtjumlah)
        Controls.Add(Label6)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnhapus)
        Controls.Add(btnsimpan)
        Controls.Add(btntambah)
        Controls.Add(tbl_pinjam)
        Controls.Add(dtpKembali)
        Controls.Add(dtpPinjam)
        Controls.Add(cbo_anggota)
        Controls.Add(cbo_buku)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(tbl_pinjam, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbo_buku As ComboBox
    Friend WithEvents cbo_anggota As ComboBox
    Friend WithEvents dtpPinjam As DateTimePicker
    Friend WithEvents dtpKembali As DateTimePicker
    Friend WithEvents tbl_pinjam As DataGridView
    Friend WithEvents btntambah As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtjumlah As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        tblanggota = New DataGridView()
        txtnama = New TextBox()
        txtalamat = New TextBox()
        txttelepon = New TextBox()
        btnsimpan = New Button()
        btmhapus = New Button()
        btnupdate = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        CType(tblanggota, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(87, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 15)
        Label1.TabIndex = 0
        Label1.Text = "NAMA ANGGOTA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(281, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(191, 30)
        Label2.TabIndex = 1
        Label2.Text = "DAFTAR ANGGOTA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(87, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 15)
        Label3.TabIndex = 2
        Label3.Text = "ALAMAT"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(87, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 15)
        Label4.TabIndex = 3
        Label4.Text = "TELEPON"
        ' 
        ' tblanggota
        ' 
        tblanggota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tblanggota.Location = New Point(87, 234)
        tblanggota.Name = "tblanggota"
        tblanggota.RowTemplate.Height = 25
        tblanggota.Size = New Size(589, 154)
        tblanggota.TabIndex = 4
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(210, 61)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(281, 23)
        txtnama.TabIndex = 5
        ' 
        ' txtalamat
        ' 
        txtalamat.Location = New Point(210, 98)
        txtalamat.Name = "txtalamat"
        txtalamat.Size = New Size(281, 23)
        txtalamat.TabIndex = 6
        ' 
        ' txttelepon
        ' 
        txttelepon.Location = New Point(210, 144)
        txttelepon.Name = "txttelepon"
        txttelepon.Size = New Size(281, 23)
        txttelepon.TabIndex = 7
        ' 
        ' btnsimpan
        ' 
        btnsimpan.Location = New Point(91, 188)
        btnsimpan.Name = "btnsimpan"
        btnsimpan.Size = New Size(96, 25)
        btnsimpan.TabIndex = 8
        btnsimpan.Text = "SIMPAN"
        btnsimpan.UseVisualStyleBackColor = True
        ' 
        ' btmhapus
        ' 
        btmhapus.Location = New Point(252, 188)
        btmhapus.Name = "btmhapus"
        btmhapus.Size = New Size(96, 25)
        btmhapus.TabIndex = 9
        btmhapus.Text = "HAPUS"
        btmhapus.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.Location = New Point(407, 188)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(96, 25)
        btnupdate.TabIndex = 10
        btnupdate.Text = "UPDATE"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(601, 60)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 24)
        Button1.TabIndex = 11
        Button1.Text = "form transaksi"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(601, 106)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 24)
        Button2.TabIndex = 12
        Button2.Text = "form buku"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(601, 155)
        Button3.Name = "Button3"
        Button3.Size = New Size(132, 24)
        Button3.TabIndex = 13
        Button3.Text = "form laporan"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnupdate)
        Controls.Add(btmhapus)
        Controls.Add(btnsimpan)
        Controls.Add(txttelepon)
        Controls.Add(txtalamat)
        Controls.Add(txtnama)
        Controls.Add(tblanggota)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        CType(tblanggota, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tblanggota As DataGridView
    Friend WithEvents txtnama As TextBox
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents txttelepon As TextBox
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btmhapus As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class

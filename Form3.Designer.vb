<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        btnupdate = New Button()
        btmhapus = New Button()
        btnsimpan = New Button()
        txtpenerbit = New TextBox()
        txtpenulis = New TextBox()
        txtjudul = New TextBox()
        tblbuku = New DataGridView()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        CType(tblbuku, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnupdate
        ' 
        btnupdate.Location = New Point(424, 202)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(96, 25)
        btnupdate.TabIndex = 21
        btnupdate.Text = "UPDATE"
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btmhapus
        ' 
        btmhapus.Location = New Point(269, 202)
        btmhapus.Name = "btmhapus"
        btmhapus.Size = New Size(96, 25)
        btmhapus.TabIndex = 20
        btmhapus.Text = "HAPUS"
        btmhapus.UseVisualStyleBackColor = True
        ' 
        ' btnsimpan
        ' 
        btnsimpan.Location = New Point(108, 202)
        btnsimpan.Name = "btnsimpan"
        btnsimpan.Size = New Size(96, 25)
        btnsimpan.TabIndex = 19
        btnsimpan.Text = "SIMPAN"
        btnsimpan.UseVisualStyleBackColor = True
        ' 
        ' txtpenerbit
        ' 
        txtpenerbit.Location = New Point(241, 139)
        txtpenerbit.Name = "txtpenerbit"
        txtpenerbit.Size = New Size(281, 23)
        txtpenerbit.TabIndex = 18
        ' 
        ' txtpenulis
        ' 
        txtpenulis.Location = New Point(241, 93)
        txtpenulis.Name = "txtpenulis"
        txtpenulis.Size = New Size(281, 23)
        txtpenulis.TabIndex = 17
        ' 
        ' txtjudul
        ' 
        txtjudul.Location = New Point(241, 56)
        txtjudul.Name = "txtjudul"
        txtjudul.Size = New Size(281, 23)
        txtjudul.TabIndex = 16
        ' 
        ' tblbuku
        ' 
        tblbuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tblbuku.Location = New Point(104, 248)
        tblbuku.Name = "tblbuku"
        tblbuku.RowTemplate.Height = 25
        tblbuku.Size = New Size(589, 154)
        tblbuku.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(118, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 15)
        Label4.TabIndex = 14
        Label4.Text = "PENERBIT"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(118, 101)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 15)
        Label3.TabIndex = 13
        Label3.Text = "PENULIS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(312, 4)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 30)
        Label2.TabIndex = 12
        Label2.Text = "DAFTAR BUKU"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(118, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 11
        Label1.Text = "JUDUL"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(612, 149)
        Button3.Name = "Button3"
        Button3.Size = New Size(132, 24)
        Button3.TabIndex = 24
        Button3.Text = "form laporan"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(612, 100)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 24)
        Button2.TabIndex = 23
        Button2.Text = "form anggota"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(612, 54)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 24)
        Button1.TabIndex = 22
        Button1.Text = "form transaksi"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
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
        Controls.Add(txtpenerbit)
        Controls.Add(txtpenulis)
        Controls.Add(txtjudul)
        Controls.Add(tblbuku)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        CType(tblbuku, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnupdate As Button
    Friend WithEvents btmhapus As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents txtpenerbit As TextBox
    Friend WithEvents txtpenulis As TextBox
    Friend WithEvents txtjudul As TextBox
    Friend WithEvents tblbuku As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class

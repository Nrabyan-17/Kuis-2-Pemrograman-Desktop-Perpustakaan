<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        tbl_pinjam = New DataGridView()
        Label1 = New Label()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        CType(tbl_pinjam, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbl_pinjam
        ' 
        tbl_pinjam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tbl_pinjam.Location = New Point(116, 157)
        tbl_pinjam.Name = "tbl_pinjam"
        tbl_pinjam.RowTemplate.Height = 25
        tbl_pinjam.Size = New Size(626, 250)
        tbl_pinjam.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(162, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(463, 45)
        Label1.TabIndex = 1
        Label1.Text = "LAPORAN PEMINJAMAN BUKU"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(493, 105)
        Button3.Name = "Button3"
        Button3.Size = New Size(132, 24)
        Button3.TabIndex = 19
        Button3.Text = "form laporan"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(319, 105)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 24)
        Button2.TabIndex = 18
        Button2.Text = "form buku"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(130, 105)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 24)
        Button1.TabIndex = 17
        Button1.Text = "form anggota"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(tbl_pinjam)
        Name = "Form4"
        Text = "Form4"
        CType(tbl_pinjam, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbl_pinjam As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class

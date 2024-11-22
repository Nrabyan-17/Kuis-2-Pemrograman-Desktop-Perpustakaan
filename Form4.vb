Imports MySql.Data.MySqlClient

Public Class Form4
    ' Define MySQL connection string
    Dim connection As New MySqlConnection("server=localhost;userid=root;password=;database=db_perpustakaan")

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Panggil fungsi untuk menampilkan data
        TampilkanData()
    End Sub

    ' Fungsi untuk menampilkan data dari database ke DataGridView
    Private Sub TampilkanData()
        Try
            ' Buka koneksi
            connection.Open()

            ' Query untuk menampilkan data dengan JOIN
            Dim query As String = "SELECT p.id_peminjaman, a.nama, b.judul, p.tanggal_pinjam, p.tanggal_kembali, rp.jumlah " &
                                  "FROM peminjaman p " &
                                  "JOIN rincian_peminjaman rp ON p.id_peminjaman = rp.id_peminjaman " &
                                  "JOIN buku b ON rp.id_buku = b.id_buku " &
                                  "JOIN anggota a ON p.id_anggota = a.id_anggota"

            ' Buat command dan adapter
            Dim command As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()

            ' Isi DataTable dengan data dari database
            adapter.Fill(table)

            ' Tampilkan data di DataGridView (tbl_pinjam)
            tbl_pinjam.DataSource = table

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            ' Tutup koneksi
            connection.Close()
        End Try
    End Sub
End Class

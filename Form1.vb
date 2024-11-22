Imports MySql.Data.MySqlClient

Public Class Form1
    ' Define MySQL connection string
    Dim connection As New MySqlConnection("server=localhost;userid=root;password=;database=db_perpustakaan")

    ' Add new item to tbl_pinjam DataGridView (not yet saved to the database)
    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        ' Check if ComboBoxes have selected values and if quantity is valid
        If cbo_buku.SelectedIndex <> -1 AndAlso cbo_anggota.SelectedIndex <> -1 AndAlso IsNumeric(txtjumlah.Text) Then
            ' Get the selected IDs
            Dim idBuku As Integer = Convert.ToInt32(cbo_buku.SelectedValue)
            Dim idAnggota As Integer = Convert.ToInt32(cbo_anggota.SelectedValue)

            ' Create a new row in the DataGridView (temporary table)
            Dim row As String() = New String() {
                idBuku.ToString(),
                idAnggota.ToString(),
                cbo_buku.Text,
                cbo_anggota.Text,
                dtpPinjam.Value.ToString("yyyy-MM-dd"),
                dtpKembali.Value.ToString("yyyy-MM-dd"),
                txtjumlah.Text
            }
            tbl_pinjam.Rows.Add(row)

            ' Optionally clear the textboxes after adding
            txtjumlah.Clear()
        Else
            MessageBox.Show("Please select a book, member, and enter a valid quantity.")
        End If
    End Sub

    ' Delete selected row from tbl_pinjam DataGridView (not yet saved to the database)
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If tbl_pinjam.SelectedRows.Count > 0 Then
            tbl_pinjam.Rows.RemoveAt(tbl_pinjam.SelectedRows(0).Index)
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    ' Save data to database in two tables (peminjaman and rincian_peminjaman)
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If cbo_anggota.SelectedIndex <> -1 AndAlso tbl_pinjam.Rows.Count > 0 Then
            If dtpPinjam.Value <= dtpKembali.Value Then
                Dim idAnggota As Integer = Convert.ToInt32(cbo_anggota.SelectedValue)

                Dim transaction As MySqlTransaction = Nothing
                Try
                    connection.Open()
                    transaction = connection.BeginTransaction()

                    ' 1. Insert data ke tabel peminjaman
                    Dim command As New MySqlCommand("INSERT INTO peminjaman (id_anggota, tanggal_pinjam, tanggal_kembali) 
                                                 VALUES (@id_anggota, @tanggal_pinjam, @tanggal_kembali)", connection, transaction)
                    command.Parameters.AddWithValue("@id_anggota", idAnggota)
                    command.Parameters.AddWithValue("@tanggal_pinjam", dtpPinjam.Value)
                    command.Parameters.AddWithValue("@tanggal_kembali", dtpKembali.Value)
                    command.ExecuteNonQuery()

                    Dim idPeminjaman As Integer = CInt(command.LastInsertedId)

                    ' 2. Insert ke tabel rincian_peminjaman
                    For Each row As DataGridViewRow In tbl_pinjam.Rows
                        If Not row.IsNewRow Then
                            Dim idBuku As Integer = Convert.ToInt32(row.Cells("idBuku").Value)
                            Dim jumlah As Integer = Convert.ToInt32(row.Cells("Jumlah").Value)

                            Dim detailCommand As New MySqlCommand("INSERT INTO rincian_peminjaman (id_peminjaman, id_buku, jumlah) 
                                                   VALUES (@id_peminjaman, @id_buku, @jumlah)", connection, transaction)
                            detailCommand.Parameters.AddWithValue("@id_peminjaman", idPeminjaman)
                            detailCommand.Parameters.AddWithValue("@id_buku", idBuku)
                            detailCommand.Parameters.AddWithValue("@jumlah", jumlah)
                            detailCommand.ExecuteNonQuery()
                        End If
                    Next

                    transaction.Commit()
                    MessageBox.Show("Data berhasil disimpan.")
                    ClearForm()

                Catch ex As Exception
                    If transaction IsNot Nothing Then transaction.Rollback()
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            Else
                MessageBox.Show("Tanggal kembali harus lebih besar atau sama dengan tanggal pinjam.")
            End If
        Else
            MessageBox.Show("Pastikan semua data sudah diisi dengan benar.")
        End If
    End Sub

    ' Helper method to clear the form fields
    Private Sub ClearForm()
        cbo_anggota.SelectedIndex = -1
        cbo_buku.SelectedIndex = -1
        txtjumlah.Clear()
        tbl_pinjam.Rows.Clear()
        dtpPinjam.Value = DateTime.Now
        dtpKembali.Value = DateTime.Now.AddDays(7)
    End Sub

    ' Method to load data into cbo_anggota and cbo_buku ComboBoxes
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBoxes()

        ' Add columns to tbl_pinjam DataGridView dynamically
        tbl_pinjam.Columns.Add("idBuku", "ID Buku")
        tbl_pinjam.Columns("idBuku").Visible = False ' Sembunyikan kolom ID Buku
        tbl_pinjam.Columns.Add("idAnggota", "ID Anggota")
        tbl_pinjam.Columns("idAnggota").Visible = False ' Sembunyikan kolom ID Anggota
        tbl_pinjam.Columns.Add("NamaBuku", "Nama Buku")
        tbl_pinjam.Columns.Add("NamaAnggota", "Nama Anggota")
        tbl_pinjam.Columns.Add("TglPinjam", "Tgl Pinjam")
        tbl_pinjam.Columns.Add("TglKembali", "Tgl Kembali")
        tbl_pinjam.Columns.Add("Jumlah", "Jumlah")
    End Sub

    ' Load ComboBox data
    Private Sub LoadComboBoxes()
        Dim anggotaCommand As New MySqlCommand("SELECT id_anggota, nama FROM anggota", connection)
        Dim anggotaAdapter As New MySqlDataAdapter(anggotaCommand)
        Dim anggotaTable As New DataTable()
        anggotaAdapter.Fill(anggotaTable)
        cbo_anggota.DataSource = anggotaTable
        cbo_anggota.DisplayMember = "nama"
        cbo_anggota.ValueMember = "id_anggota"

        Dim bukuCommand As New MySqlCommand("SELECT id_buku, judul FROM buku", connection)
        Dim bukuAdapter As New MySqlDataAdapter(bukuCommand)
        Dim bukuTable As New DataTable()
        bukuAdapter.Fill(bukuTable)
        cbo_buku.DataSource = bukuTable
        cbo_buku.DisplayMember = "judul"
        cbo_buku.ValueMember = "id_buku"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Membuat instance baru dari Form1
        Dim frm As New Form2
        Me.Hide() ' Sembunyikan form saat ini
        frm.Show() ' Tampilkan Form1
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New Form3
        Me.Hide()
        frm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New Form4
        Me.Hide()
        frm.Show()
    End Sub
End Class

Imports MySql.Data.MySqlClient

Public Class Form3
    ' Define the MySQL connection string
    Dim connection As New MySqlConnection("server=localhost;userid=root;password=;database=db_perpustakaan")

    ' Load data into DataGridView
    Private Sub LoadData()
        Dim command As New MySqlCommand("SELECT * FROM buku", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        tblbuku.DataSource = table
    End Sub

    ' Add data to the database
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Try
            connection.Open()
            Dim command As New MySqlCommand("INSERT INTO buku (judul, penulis, penerbit) VALUES (@judul, @penulis, @penerbit)", connection)
            command.Parameters.AddWithValue("@judul", txtjudul.Text)
            command.Parameters.AddWithValue("@penulis", txtpenulis.Text)
            command.Parameters.AddWithValue("@penerbit", txtpenerbit.Text)

            command.ExecuteNonQuery()
            MessageBox.Show("Data saved successfully.")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Delete data from the database
    Private Sub btmhapus_Click(sender As Object, e As EventArgs) Handles btmhapus.Click
        Try
            connection.Open()
            Dim command As New MySqlCommand("DELETE FROM buku WHERE id_buku = @id_buku", connection)
            command.Parameters.AddWithValue("@id_buku", tblbuku.CurrentRow.Cells(0).Value)

            command.ExecuteNonQuery()
            MessageBox.Show("Data deleted successfully.")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Update data in the database
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            connection.Open()
            Dim command As New MySqlCommand("UPDATE buku SET judul = @judul, penulis = @penulis, penerbit = @penerbit WHERE id_buku = @id_buku", connection)
            command.Parameters.AddWithValue("@judul", txtjudul.Text)
            command.Parameters.AddWithValue("@penulis", txtpenulis.Text)
            command.Parameters.AddWithValue("@penerbit", txtpenerbit.Text)
            command.Parameters.AddWithValue("@id_buku", tblbuku.CurrentRow.Cells(0).Value)

            command.ExecuteNonQuery()
            MessageBox.Show("Data updated successfully.")
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Populate textboxes when a row is selected
    Private Sub tblbuku_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tblbuku.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = tblbuku.Rows(e.RowIndex)
            txtjudul.Text = row.Cells("judul").Value.ToString()
            txtpenulis.Text = row.Cells("penulis").Value.ToString()
            txtpenerbit.Text = row.Cells("penerbit").Value.ToString()
        End If
    End Sub

    ' Load data when form loads
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Form1
        Me.Hide()
        frm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New Form2
        Me.Hide()
        frm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New Form4
        Me.Hide()
        frm.Show()
    End Sub
End Class

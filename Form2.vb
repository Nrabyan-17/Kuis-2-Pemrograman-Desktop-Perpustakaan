Imports MySql.Data.MySqlClient

Public Class Form2
    ' Define the MySQL connection string
    Dim connection As New MySqlConnection("server=localhost;userid=root;password=;database=db_perpustakaan")

    ' Load data into DataGridView (tblAnggota)
    Private Sub LoadData()
        Dim command As New MySqlCommand("SELECT * FROM anggota", connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)
        tblanggota.DataSource = table
    End Sub

    ' Save data to the anggota table (Create)
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Try
            connection.Open()

            ' Prepare an SQL command to insert the data
            Dim command As New MySqlCommand("INSERT INTO anggota (nama, alamat, telepon) VALUES (@nama, @alamat, @telepon)", connection)
            command.Parameters.AddWithValue("@nama", txtnama.Text)
            command.Parameters.AddWithValue("@alamat", txtalamat.Text)
            command.Parameters.AddWithValue("@telepon", txttelepon.Text)

            ' Execute the command
            command.ExecuteNonQuery()

            ' Show a message box to confirm successful insertion
            MessageBox.Show("Data saved successfully.")

            ' Refresh the DataGridView with the latest data
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Update data in the anggota table (Update)
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            ' Check if a row is selected
            If tblanggota.SelectedRows.Count > 0 Then
                Dim id As Integer = Convert.ToInt32(tblanggota.SelectedRows(0).Cells("id_anggota").Value)

                connection.Open()

                ' Prepare an SQL command to update the data
                Dim command As New MySqlCommand("UPDATE anggota SET nama = @nama, alamat = @alamat, telepon = @telepon WHERE id_anggota = @id_anggota", connection)
                command.Parameters.AddWithValue("@nama", txtnama.Text)
                command.Parameters.AddWithValue("@alamat", txtalamat.Text)
                command.Parameters.AddWithValue("@telepon", txttelepon.Text)
                command.Parameters.AddWithValue("@id_anggota", id)

                ' Execute the command
                command.ExecuteNonQuery()

                ' Show a message box to confirm successful update
                MessageBox.Show("Data updated successfully.")

                ' Refresh the DataGridView with the latest data
                LoadData()
            Else
                MessageBox.Show("Please select a row to update.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Delete data from the anggota table (Delete)
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btmhapus.Click
        Try
            ' Check if a row is selected
            If tblanggota.SelectedRows.Count > 0 Then
                Dim id As Integer = Convert.ToInt32(tblanggota.SelectedRows(0).Cells("id_anggota").Value)

                connection.Open()

                ' Prepare an SQL command to delete the data
                Dim command As New MySqlCommand("DELETE FROM anggota WHERE id_anggota = @id_anggota", connection)
                command.Parameters.AddWithValue("@id_anggota", id)

                ' Execute the command
                command.ExecuteNonQuery()

                ' Show a message box to confirm successful deletion
                MessageBox.Show("Data deleted successfully.")

                ' Refresh the DataGridView with the latest data
                LoadData()
            Else
                MessageBox.Show("Please select a row to delete.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Form Load event to load data on startup
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into DataGridView
        LoadData()
    End Sub

    ' Button click to navigate to other forms
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Form1
        Me.Hide()
        frm.Show()
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

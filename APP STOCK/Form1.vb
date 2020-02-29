Imports MySql.Data.MySqlClient

Public Class Form1

    'user=your mysql user name; password=your password; database=your database name
    Dim Connection As New MySqlConnection("server=localhost; user=root; password=; database=vb_project")
    Dim MySQLCMD As New MySqlCommand
    Dim MySQLDA As New MySqlDataAdapter
    Dim DT As New DataTable

    Dim Table_Name As String = "vbnet_mysql_item_table" 'your table name
    Dim Data As Integer

    Dim LoadImagesStr As Boolean = False
    Dim IDRam, NameRam, PriceRam, AmountRam As String
    Dim IMG_FileNameInput As String
    Dim StatusInput As String = "Save"
    Dim SqlCmdSearchstr As String
    Dim Col0Ram As Integer = 0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ShowData()
    End Sub

    ' load all table items
    Private Sub ShowData()
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If LoadImagesStr = False Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT Name, ID, Price, Amount FROM " & Table_Name & " ORDER BY Name"
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    DataGridView1.DataSource = Nothing
                    DataGridView1.DataSource = DT
                    DataGridView1.Columns(2).DefaultCellStyle.Format = "c"
                    DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                    DataGridView1.ClearSelection()
                Else
                    DataGridView1.DataSource = DT
                End If
            Else
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT Images FROM " & Table_Name & " WHERE ID LIKE " & IDRam
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)

                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    Dim ImgArray() As Byte = DT.Rows(0).Item("Images")
                    Dim lmgStr As New System.IO.MemoryStream(ImgArray)
                    PictureBoxImagePreview.Image = Image.FromStream(lmgStr)
                    PictureBoxImagePreview.SizeMode = PictureBoxSizeMode.Zoom
                    lmgStr.Close()
                End If
                LoadImagesStr = False
            End If
        Catch ex As Exception
            MsgBox("Failed to load Database !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub

    ' clear form
    Private Sub ClearInputUpdateData()
        TextBoxName.Text = ""
        TextBoxID.Text = ""
        TextBoxPrice.Text = ""
        TextBoxAmount.Text = ""

        PictureBoxImageInput.Image = WindowsApplication1.My.Resources.cover

    End Sub

    Private Sub ButtonIDMaker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIDMaker.Click
        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            Dim r As Random = New Random
            Dim num As Integer
            num = (r.Next(1, 9999))
            Dim IDMaker As String = Strings.Right("0000" & num.ToString(), 4)
            TextBoxID.Text = "1" & IDMaker

            MySQLCMD.CommandType = CommandType.Text
            MySQLCMD.CommandText = "SELECT ID FROM " & Table_Name & " WHERE ID LIKE " & TextBoxID.Text
            MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, Connection)

            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                ButtonIDMaker_Click(sender, e)
            End If
        Catch ex As Exception
            TextBoxID.Text = ""
            MsgBox("Failed to make ID !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            DT = Nothing
            Connection.Close()
            Return
        End Try

        DT = Nothing
        Connection.Close()
    End Sub
    'Button Clear All
    Private Sub ButtonClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClearAll.Click
        ButtonSave.Text = "Save"
        StatusInput = "Save"
        ButtonIDMaker.Enabled = True
        TextBoxID.Enabled = True
        ClearInputUpdateData()
    End Sub

    'Browse Picture
    Private Sub PictureBoxImageInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxImageInput.Click
        OpenFileDialog1.FileName = ""
        'OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.Filter = "JPEG (*.jpeg;*.jpg)|*.jpeg;*.jpg"

        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            IMG_FileNameInput = OpenFileDialog1.FileName
            PictureBoxImageInput.ImageLocation = IMG_FileNameInput
        End If
    End Sub

    'Save Form
    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click

        Dim mstream As New System.IO.MemoryStream()
        Dim arrImage() As Byte

        If TextBoxName.Text = "" Then
            MessageBox.Show("Name cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxPrice.Text = "" Then
            MessageBox.Show("Price cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If TextBoxAmount.Text = "" Then
            MessageBox.Show("Amount cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If StatusInput = "Save" Then
            If IMG_FileNameInput <> "" Then
                PictureBoxImageInput.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()
            Else
                MessageBox.Show("The image has not been selected !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                Connection.Open()
            Catch ex As Exception
                MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            Try
                MySQLCMD = New MySqlCommand
                With MySQLCMD
                    .CommandText = "INSERT INTO " & Table_Name & " (Name, ID, Price, Amount, Images) VALUES (@name, @id, @price, @amount, @images)"
                    .Connection = Connection
                    .Parameters.AddWithValue("@name", TextBoxName.Text)
                    .Parameters.AddWithValue("@id", TextBoxID.Text)
                    .Parameters.AddWithValue("@price", TextBoxPrice.Text)
                    .Parameters.AddWithValue("@amount", TextBoxAmount.Text)
                    .Parameters.AddWithValue("@images", arrImage)
                    .ExecuteNonQuery()
                End With
                MsgBox("Data saved successfully", MsgBoxStyle.Information, "Information")
                IMG_FileNameInput = ""
                ClearInputUpdateData()
            Catch ex As Exception
                MsgBox("Data failed to save !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                Connection.Close()
                Return
            End Try
            Connection.Close()

        Else

            If IMG_FileNameInput <> "" Then
                PictureBoxImageInput.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                arrImage = mstream.GetBuffer()

                Try
                    Connection.Open()
                Catch ex As Exception
                    MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                Try
                    MySQLCMD = New MySqlCommand
                    With MySQLCMD
                        .CommandText = "UPDATE " & Table_Name & " SET  Name=@name,Price=@price,Amount=@amount,Images=@images WHERE ID=@id "
                        .Connection = Connection
                        .Parameters.AddWithValue("@name", TextBoxName.Text)
                        .Parameters.AddWithValue("@id", TextBoxID.Text)
                        .Parameters.AddWithValue("@price", TextBoxPrice.Text)
                        .Parameters.AddWithValue("@amount", TextBoxAmount.Text)
                        .Parameters.AddWithValue("@images", arrImage)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Data updated successfully", MsgBoxStyle.Information, "Information")
                    IMG_FileNameInput = ""
                    ButtonSave.Text = "Save"
                    ButtonIDMaker.Enabled = True
                    TextBoxID.Enabled = True
                    ClearInputUpdateData()
                Catch ex As Exception
                    MsgBox("Data failed to Update !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                    Connection.Close()
                    Return
                End Try
                Connection.Close()

            Else

                Try
                    Connection.Open()
                Catch ex As Exception
                    MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try

                Try
                    MySQLCMD = New MySqlCommand
                    With MySQLCMD
                        .CommandText = "UPDATE " & Table_Name & " SET  Name=@name,Price=@price,Amount=@amount WHERE ID=@id "
                        .Connection = Connection
                        .Parameters.AddWithValue("@name", TextBoxName.Text)
                        .Parameters.AddWithValue("@id", TextBoxID.Text)
                        .Parameters.AddWithValue("@price", TextBoxPrice.Text)
                        .Parameters.AddWithValue("@amount", TextBoxAmount.Text)
                        .ExecuteNonQuery()
                    End With
                    MsgBox("Data updated successfully", MsgBoxStyle.Information, "Information")
                    ButtonSave.Text = "Save"
                    ButtonIDMaker.Enabled = True
                    TextBoxID.Enabled = True
                    ClearInputUpdateData()
                Catch ex As Exception
                    MsgBox("Data failed to Update !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
                    Connection.Close()
                    Return
                End Try
                Connection.Close()
            End If
            StatusInput = "Save"
        End If
        PictureBoxImagePreview.Image = Nothing
        ShowData()
    End Sub

    'Select row Table
    Private Sub DataGridView1_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDown
        Try
            If AllCellsSelected(DataGridView1) = False Then
                If e.Button = MouseButtons.Left Then
                    DataGridView1.CurrentCell = DataGridView1(e.ColumnIndex, e.RowIndex)
                    Dim i As Integer
                    With DataGridView1
                        If e.RowIndex >= 0 Then
                            i = .CurrentRow.Index
                            LoadImagesStr = True
                            IDRam = .Rows(i).Cells("ID").Value.ToString
                            NameRam = .Rows(i).Cells("Name").Value.ToString
                            PriceRam = .Rows(i).Cells("Price").Value.ToString
                            AmountRam = .Rows(i).Cells("Amount").Value.ToString
                            ShowData()
                        End If
                    End With
                End If
            End If
        Catch ex As Exception
            Return
        End Try
    End Sub

    Private Function AllCellsSelected(ByVal dgv As DataGridView) As Boolean
        AllCellsSelected = (DataGridView1.SelectedCells.Count = (DataGridView1.RowCount * DataGridView1.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function

    Private Sub ButtonClearSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClearSelected.Click
        DataGridView1.ClearSelection()
        PictureBoxImagePreview.Image = Nothing
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        If DataGridView1.RowCount = 1 Then
            PictureBoxImageInput.Image = Nothing
            PictureBoxImageInput.Image = PictureBoxImagePreview.Image
            TextBoxName.Text = NameRam
            TextBoxID.Text = IDRam
            TextBoxPrice.Text = PriceRam
            TextBoxAmount.Text = AmountRam
            ButtonIDMaker.Enabled = False
            TextBoxID.Enabled = False
            ButtonSave.Text = "Update"
            StatusInput = "Update"
            Return
        End If

        If AllCellsSelected(DataGridView1) = False Then
            PictureBoxImageInput.Image = Nothing
            PictureBoxImageInput.Image = PictureBoxImagePreview.Image
            TextBoxName.Text = NameRam
            TextBoxID.Text = IDRam
            TextBoxPrice.Text = PriceRam
            TextBoxAmount.Text = AmountRam
            ButtonIDMaker.Enabled = False
            TextBoxID.Enabled = False
            ButtonSave.Text = "Update"
            StatusInput = "Update"
        Else
            MsgBox("Cannot edit !!! " & vbCr & "Please choose one to edit.", MsgBoxStyle.Critical, "Error Message")
        End If
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        If DataGridView1.RowCount = 0 Then
            MsgBox("Cannot delete, table data is empty", MsgBoxStyle.Critical, "Error Message")
            Return
        End If

        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Cannot delete, select the table data to be deleted", MsgBoxStyle.Critical, "Error Message")
            Return
        End If

        If MsgBox("Delete record?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Cancel Then Return

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If AllCellsSelected(DataGridView1) = True Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "DELETE FROM " & Table_Name
                MySQLCMD.Connection = Connection
                MySQLCMD.ExecuteNonQuery()
            End If

            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                If row.Selected = True Then
                    MySQLCMD.CommandType = CommandType.Text
                    MySQLCMD.CommandText = "DELETE FROM " & Table_Name & " WHERE ID='" & row.DataBoundItem(1).ToString & "'"
                    MySQLCMD.Connection = Connection
                    MySQLCMD.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception
            MsgBox("Failed to delete" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
        End Try
        PictureBoxImagePreview.Image = Nothing
        Connection.Close()
        ShowData()
    End Sub

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        ShowData()
    End Sub

    Private Sub TextBoxPrice_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBoxPrice.KeyPress
        'code to only allow numeric input
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = "+") Then
            MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxAmount_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBoxAmount.KeyPress
        'code to only allow numeric input
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = "+") Then
            MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub
    ' Search
    Private Sub TextBoxSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBoxSearch.TextChanged
        If CheckBoxByID.Checked = True Then
            If TextBoxSearch.Text = Nothing Then
                SqlCmdSearchstr = "SELECT Name, ID, Price, Amount FROM " & Table_Name & " ORDER BY Name"
            Else
                SqlCmdSearchstr = "SELECT Name, ID, Price, Amount FROM " & Table_Name & " WHERE ID LIKE'" & TextBoxSearch.Text & "%'"
            End If
        End If
        If CheckBoxByName.Checked = True Then
            If TextBoxSearch.Text = Nothing Then
                SqlCmdSearchstr = "SELECT Name, ID, Price, Amount FROM " & Table_Name & " ORDER BY Name"
            Else
                SqlCmdSearchstr = "SELECT Name, ID, Price, Amount FROM " & Table_Name & " WHERE Name LIKE'" & TextBoxSearch.Text & "%'"
            End If
        End If

        Try
            Connection.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            MySQLDA = New MySqlDataAdapter(SqlCmdSearchstr, Connection)
            DT = New DataTable
            Data = MySQLDA.Fill(DT)
            If Data > 0 Then
                DataGridView1.DataSource = Nothing
                DataGridView1.DataSource = DT
                DataGridView1.Columns(2).DefaultCellStyle.Format = "c"
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.ClearSelection()
            Else
                DataGridView1.DataSource = DT
            End If
        Catch ex As Exception
            MsgBox("Failed to search" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            Connection.Close()
        End Try
        Connection.Close()
    End Sub

    Private Sub CheckBoxByName_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxByName.CheckedChanged
        If CheckBoxByName.Checked = True Then
            CheckBoxByID.Checked = False
        End If
        If CheckBoxByName.Checked = False Then
            CheckBoxByID.Checked = True
        End If
    End Sub

    Private Sub CheckBoxByID_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CheckBoxByID.CheckedChanged
        If CheckBoxByID.Checked = True Then
            CheckBoxByName.Checked = False
        End If
        If CheckBoxByID.Checked = False Then
            CheckBoxByName.Checked = True
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        ButtonDelete_Click(sender, e)
    End Sub

    Private Sub EdittToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EdittToolStripMenuItem.Click
        ButtonEdit_Click(sender, e)
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        DataGridView1.SelectAll()
    End Sub
End Class

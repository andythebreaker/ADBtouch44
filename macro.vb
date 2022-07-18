Imports System.Text.RegularExpressions

Public Class macro
    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        Shell("""Tools\adb.exe"" shell am start -a android.settings.SETTINGS")
    End Sub

    Private Sub GoBackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoBackToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TetherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TetherToolStripMenuItem.Click
        Shell("""Tools\adb.exe"" shell am start -S com.android.settings/.TetherSettings")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToolStripStatusLabel1.Text = My.Settings.macros
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub macro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.PerformClick()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim table1 As DataTable = New DataTable("t1")
        Dim r1 As Regex = New Regex("([a-zA-Z]+):([a-zA-Z]+);")
        Dim input As String = My.Settings.macros
        ' "abs:edf;"
        Dim options As RegexOptions = RegexOptions.Multiline
        table1.Columns.Add("name")
        table1.Columns.Add("macro action")

        For Each m As Match In r1.Matches(input, options)
            '  MessageBox.Show("'" + m.Value + "' found at index " + CStr(m.Index) + ".")
            table1.Rows.Add(m.Groups(1).Value, m.Groups(2).Value)
        Next


        DataGridView1.DataSource = table1
    End Sub

    Private Sub DataGridView1_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles DataGridView1.RowStateChanged
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ToolStripStatusLabel2.Text = DataGridView1.Item(1, e.RowIndex).Value.ToString
    End Sub
End Class
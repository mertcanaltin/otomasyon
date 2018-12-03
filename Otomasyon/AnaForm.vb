Public Class AnaForm
    Private Sub ProgramıKapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramıKapatToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub YolcuKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YolcuKaydıToolStripMenuItem.Click
        YeniYolcuKayitFormu.MdiParent = Me
        YeniYolcuKayitFormu.Show()
    End Sub

    Private Sub OtobüslerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtobüslerToolStripMenuItem.Click
        OtobuslerFormu.MdiParent = Me
        OtobuslerFormu.Show()
        OtobuslerFormu.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AnaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kullanicigirisFormu.ShowDialog(Me)
    End Sub
End Class

Public Class Frm_Principal01
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Banco ByteBank"


    End Sub

    Private Sub ContasCorrentesArrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContasCorrentesArrayToolStripMenuItem.Click
        Dim F As New Frm_ContasCorrentesArray
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ContasCorrentesListasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContasCorrentesListasToolStripMenuItem.Click
        Dim F As New Frm_ContasCorrentesListas
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ContasCorrentesAgenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContasCorrentesAgenciaToolStripMenuItem.Click
        Dim F As New Frm_ContasCorrentesAgencia
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ContasCorrentesAgenciaDicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContasCorrentesAgenciaDicToolStripMenuItem.Click
        Dim F As New Frm_ContasCorrentesAgenciaDic
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub SimulaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimulaçãoToolStripMenuItem.Click
        Dim F As New Frm_Simulacao
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ManutençãoListViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManutençãoListViewToolStripMenuItem.Click
        Dim F As New Frm_ManutencaoCCListView
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub ManutençãoListViewDTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManutençãoListViewDTToolStripMenuItem.Click
        Dim F As New Frm_ManutencaoCCDataTable
        F.MdiParent = Me
        F.Show()
    End Sub
End Class
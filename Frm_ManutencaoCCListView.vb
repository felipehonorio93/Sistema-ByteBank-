Imports System.IO
Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_ManutencaoCCListView

    Dim ListaContas As New List(Of ContaCorrente)
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Manutenção Conta Corrente"
        Grp_Lista.Text = "Lista de Contas Correntes"
        Grp_CriterioOrdenacao.Text = "Critério de Ordenação"
        Rb_Conta.Text = "Conta"
        Rb_Nome.Text = "Nome"
        Rb_Saldo.Text = "Saldo"

        InicializacaoContas()
        FormatarListView()
        CriarColunas()
        AtualizarListView()

    End Sub

    Sub InicializacaoContas()

        Dim NomeArquivo As String = "ListaContasCorrentes.csv"
        Using Fs As New FileStream(NomeArquivo, FileMode.Open)
            Using Leitura As New StreamReader(Fs)
                While Not Leitura.EndOfStream
                    Dim Linha As String = Leitura.ReadLine()
                    Dim vetorLinha As String() = Linha.Split(";")
                    Dim cc As New ContaCorrente(Val(vetorLinha(0)), Val(vetorLinha(1)), vetorLinha(2))
                    cc.Depositar(Val(vetorLinha(3)) - 100)
                    ListaContas.Add(cc)
                End While
            End Using
        End Using

    End Sub

    Sub FormatarListView()
        ' Formatar o ListView

        Lvw_Contas.View = View.Details
        Lvw_Contas.LabelEdit = False
        Lvw_Contas.AllowColumnReorder = False
        Lvw_Contas.FullRowSelect = True
        Lvw_Contas.GridLines = True

    End Sub

    Sub CriarColunas()
        ' Configurar colunas

        Lvw_Contas.Columns.Add("Conta Corrente", 100, HorizontalAlignment.Center)
        Lvw_Contas.Columns.Add("Correntista", 150, HorizontalAlignment.Center)
        Lvw_Contas.Columns.Add("Saldo em R$", 100, HorizontalAlignment.Center)
    End Sub

    Sub AtualizarListView()

        ' Inclusao dos elementos

        Lvw_Contas.Items.Clear()

        For I As Integer = 0 To ListaContas.Count - 1
            Dim vContaNumero As String = ListaContas(I).agencia.ToString +
                "-" + ListaContas(I).numero.ToString
            Dim Linha As New ListViewItem
            Linha.Name = vContaNumero
            Linha.Text = vContaNumero
            Linha.SubItems.Add(ListaContas(I).titular.nome)
            Linha.SubItems.Add(ListaContas(I).saldo.ToString)
            Lvw_Contas.Items.Add(Linha)

        Next

    End Sub

    Private Sub NovoToolStripButton_Click(sender As Object, e As EventArgs) Handles NovoToolStripButton.Click
        Dim F As New Frm_ContaCorrente
        F.ShowDialog()
        If F.Retorno Then
            ListaContas.Add(F.Conta)
            AtualizarListView()
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Dim ListaContasExcluir As New List(Of ContaCorrente)
        For I As Integer = 0 To Lvw_Contas.Items.Count - 1
            If Lvw_Contas.Items(I).Selected Then
                Dim ContaExcluir As ContaCorrente
                ContaExcluir = ListaContas(I)
                ListaContasExcluir.Add(ContaExcluir)
            End If
        Next

        If ListaContasExcluir.Count > 0 Then
            For I As Integer = 0 To ListaContasExcluir.Count - 1
                Dim ContaExcluir As ContaCorrente
                ContaExcluir = ListaContasExcluir(I)
                ListaContas.Remove(ContaExcluir)
            Next
            AtualizarListView()
        End If

    End Sub

    Private Sub Rb_Conta_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Conta.CheckedChanged

        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) = ListaContas _
            .OrderBy(Function(conta As ContaCorrente) conta.agencia) _
            .OrderBy(Function(conta As ContaCorrente) conta.numero)

        AtualizaListaContas(ListaAuxiliar)

    End Sub

    Private Sub Rb_Nome_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Nome.CheckedChanged
        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) = ListaContas _
           .OrderBy(Function(conta As ContaCorrente) conta.titular.nome)

        AtualizaListaContas(ListaAuxiliar)

    End Sub

    Private Sub Rb_Saldo_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Saldo.CheckedChanged
        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) = ListaContas _
          .OrderBy(Function(conta As ContaCorrente) conta.saldo)

        AtualizaListaContas(ListaAuxiliar)
    End Sub

    Sub AtualizaListaContas(ListaAuxiliar As IEnumerable(Of ContaCorrente))
        ListaContas = New List(Of ContaCorrente)

        For I As Integer = 0 To ListaAuxiliar.Count - 1
            ListaContas.Add(ListaAuxiliar(I))
        Next
        AtualizarListView()
    End Sub

    Private Sub SalvarToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvarToolStripButton.Click

        Dim NomeArquivo As String = "ListaContasCorrentes.csv"
        Using Fs As New FileStream(NomeArquivo, FileMode.Create)
            Using Escrita As New StreamWriter(Fs)
                For I As Integer = 0 To ListaContas.Count - 1
                    Dim Linha As String = ""
                    Linha += ListaContas(I).agencia.ToString + ";"
                    Linha += ListaContas(I).numero.ToString + ";"
                    Linha += ListaContas(I).titular.nome + ";"
                    Linha += ListaContas(I).saldo.ToString
                    Escrita.WriteLine(Linha)
                Next
            End Using
        End Using

        MsgBox("Dados de conta correntes salvos com sucesso.")

    End Sub
End Class
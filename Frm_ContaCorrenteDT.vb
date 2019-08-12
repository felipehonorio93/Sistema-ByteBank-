Public Class Frm_ContaCorrenteDT

#Region "PROPRIEDADES"

    Public Property Agencia As Integer
    Public Property Conta As Integer
    Public Property CPF As String
    Public Property Retorno As Boolean


#End Region

    Public Sub New(DtClientes As DataTable)

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Conta Corrente"
        Retorno = False
        Lbl_ContaCorrente.Text = "Conta Corrente"
        Txt_CPF.ReadOnly = True
        Cmb_CPF.Items.Clear()
        For I As Integer = 0 To DtClientes.Rows.Count - 1
            Cmb_CPF.Items.Add(DtClientes.Rows(I)("CPF"))
        Next

    End Sub

    Private Sub SalvarToolStripButton_Click(sender As Object, e As EventArgs) Handles SalvarToolStripButton.Click
        Retorno = True
        Agencia = Txt_Agencia.Text
        Conta = Txt_Conta.Text
        CPF = Txt_CPF.Text
        Me.Close()
    End Sub

    Private Sub Cmb_CPF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_CPF.SelectedIndexChanged
        Txt_CPF.Text = Cmb_CPF.Text
    End Sub
End Class
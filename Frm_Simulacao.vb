
Imports ByteBank.Bibliotecas.Classes.Clientes
Imports ByteBank.Bibliotecas.Classes.Funcionarios
Imports ByteBank.SistemaAgencia.classes

Public Class Frm_Simulacao
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Simulação"
        Lbl_Tempo.Text = "TEMPO DA SIMULAÇÃO: "
        Lbl_TamanhoFila.Text = "TAMANHO DA FILA: "
        Lbl_TempoMedia.Text = "TEMPO MÉDIO DE ESPERA: "
        Grp_Estatisticas.Text = "Estatísticas"
        Btm_FazSimulacao.Text = "Simulação"
        Grp_Parametros.Text = "Parâmetros"
        Lbl_TempoMenorServico.Text = "Tempo Menor Serviço (Segundos)"
        Lbl_TempoMaiorServico.Text = "Tempo Maior Serviço (Segundos)"
        Lbl_NumClientesMinimo.Text = "Num Clientes Mínimo (Minuto)"
        Lbl_NumClientesMaximo.Text = "Num Clientes Máximo (Minuto)"
        Lbl_NumCaixas.Text = "Número Caixas"
        Lbl_TempoSimulacao.Text = "Tempo Date Simulação (Em Segundos)"
        Lbl_TempoPasso.Text = "Tempo Passo (Em Milisegundos)"

        Txt_TempoMenorServico.Text = "40"
        Txt_TempoMaiorServico.Text = "240"
        Txt_NumeroClientesMaximo.Text = "3"
        Txt_NumeroClientesMinimo.Text = "1"
        Txt_TempoPasso.Text = "50"
        Txt_TempoSimulacao.Text = "1200"
        Txt_NumCaixas.Text = "4"

    End Sub

    Private Sub Btm_FazSimulacao_Click(sender As Object, e As EventArgs) Handles Btm_FazSimulacao.Click

        Dim TempoMenorServico As Integer = Txt_TempoMenorServico.Text
        Dim TempoMaiorServico As Integer = Txt_TempoMaiorServico.Text
        Dim NumClieChegamMinutoMinimo As Integer = Txt_NumeroClientesMinimo.Text
        Dim NumClieChegamMinutoMaximo As Integer = Txt_NumeroClientesMaximo.Text
        Dim NumeroCaixas As Integer = Txt_NumCaixas.Text
        Dim TempoPasso As Integer = Txt_TempoPasso.Text
        Dim TempoMaximoSimulacao As Integer = Txt_TempoSimulacao.Text
        Dim vHora As New TimeSpan(10, 0, 0)

        Dim AgenciaBancaria As New Agencia(277)
        For I As Integer = 1 To NumeroCaixas
            AgenciaBancaria.Caixas.Add(New Caixa("CAIXA " + I.ToString))
        Next

        Dim SerieHistoricaServico As New Aleatorio(TempoMenorServico, TempoMaiorServico + 1)
        Dim SerieHistoricaNumClientes As New Aleatorio(NumClieChegamMinutoMinimo, NumClieChegamMinutoMaximo + 1)

        Dim vContadorMinuto As Integer = 1
        For I As Integer = 1 To TempoMaximoSimulacao

            'SE FOR UM MINUTO COMPLETO

            If vContadorMinuto = 1 Then

                ' Quandos clientes chegaram na agencia?
                Dim vNumClientes As Integer = SerieHistoricaNumClientes.getNumeroAleatorio

                '   CHEGAR CLIENTES NA AGENCIA
                '   COLOCA-LOS NA FILA

                For J As Integer = 1 To vNumClientes
                    Dim vTempoServico As Integer = SerieHistoricaServico.getNumeroAleatorio
                    AgenciaBancaria.EntrarNaFila(vTempoServico)
                    System.Threading.Thread.Sleep(100)
                Next
            End If

            'FIM DO SE

            vContadorMinuto += 1
            If vContadorMinuto = 60 Then
                vContadorMinuto = 1
            End If

            'INCREMENTAR TEMPO DE SERVICO E TEMPO DE ESPERA
            AgenciaBancaria.ExecutaAtendimento(1)

            'VER SE EXISTE CAIXA DISPONIVEL PARA TIRAR CLIENTES DA FILA
            AgenciaBancaria.SairDaFila()

            'ESCREVER O STATUS ATUAL
            EscreverAgencia(AgenciaBancaria)

            'ESCREVER AS ESTATISTICAS
            Lbl_Tempo.Text = "TEMPO DA SIMULAÇÃO: " + ConverteSegundosEmHoras(I)
            Lbl_TamanhoFila.Text = "TAMANHO DA FILA: " + AgenciaBancaria.Fila.Count.ToString
            Lbl_TempoMedia.Text = "TEMPO MÉDIO DE ESPERA: " +
                ConverteSegundosEmHoras(Agencia.TempoTotalFila / Agencia.NumeroClienteFila)

            Me.Refresh()
            System.Threading.Thread.Sleep(TempoPasso)
        Next

    End Sub

    Sub EscreverAgencia(AgenciaBancaria As Agencia)

        Txt_Caixas.Text = ""
        Txt_Fila.Text = ""
        For I As Integer = 0 To AgenciaBancaria.Caixas.Count - 1
            Txt_Caixas.Text += AgenciaBancaria.Caixas(I).MostrarStatus + vbCrLf
        Next
        For I As Integer = 0 To AgenciaBancaria.Fila.Count - 1
            Txt_Fila.Text += AgenciaBancaria.Fila(I).Nome + vbCrLf
        Next

    End Sub

    Function ConverteSegundosEmHoras(Segundos As Integer) As String
        Dim iSecond As Double = Segundos
        Dim iSpan As TimeSpan = TimeSpan.FromSeconds(iSecond)

        Return iSpan.Hours.ToString.PadLeft(2, "0"c) & ":" &
                                iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" &
                                iSpan.Seconds.ToString.PadLeft(2, "0"c)
    End Function
End Class
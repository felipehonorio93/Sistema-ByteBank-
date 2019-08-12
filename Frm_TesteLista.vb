Imports ByteBank.Bibliotecas.Classes.Clientes
Imports ByteBank.Bibliotecas.Classes.Criterios

Public Class Frm_TesteLista
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Lista As New List(Of Integer)
        Lista.Add(10)
        Lista.Add(12)
        Lista.Add(8)
        Lista.Add(2)

        MsgBox(Lista.Contains(8))

        Lista.Sort()

        MsgBox(Lista(0))
        MsgBox(Lista(1))
        MsgBox(Lista(2))
        MsgBox(Lista(3))

        Dim ListaS As New List(Of String)
        ListaS.Add("João")
        ListaS.Add("Pedro")
        ListaS.Add("Antonio")
        ListaS.Add("Beatriz")

        MsgBox(ListaS.Contains("Pedro"))

        ListaS.Sort()

        MsgBox(ListaS(0))
        MsgBox(ListaS(1))
        MsgBox(ListaS(2))
        MsgBox(ListaS(3))


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Lista As List(Of Integer)
        Lista = New List(Of Integer)

        Dim Conjunto As ISet(Of Integer)
        Conjunto = New HashSet(Of Integer)

        Lista.Add(25)
        Lista.Add(12)
        Lista.Add(8)

        Conjunto.Add(25)
        Conjunto.Add(12)
        Conjunto.Add(8)

        MsgBox("Lista : " + String.Join(",", Lista) + vbCrLf + "Conjunto : " + String.Join(",", Conjunto))

        Lista.Remove(12)
        Lista.Add(2)

        Conjunto.Remove(12)
        Conjunto.Add(2)

        MsgBox("Lista : " + String.Join(",", Lista) + vbCrLf + "Conjunto : " + String.Join(",", Conjunto))

        Lista.Add(2)
        Conjunto.Add(2)

        MsgBox("Lista : " + String.Join(",", Lista) + vbCrLf + "Conjunto : " + String.Join(",", Conjunto))

        Lista.Sort()

        Dim ListaTemporaria As New List(Of Integer)(Conjunto)
        ListaTemporaria.Sort()

        MsgBox("Lista : " + String.Join(",", Lista) + vbCrLf + "Conjunto : " + String.Join(",", ListaTemporaria))

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim ag As New Agencia(277)

        ag.AbrirContaCorrente(17777, "Marília")
        ag.AbrirContaCorrente(22222, "Márcia")
        ag.AbrirContaCorrente(3333, "Victor")

        MsgBox("Contas correntes da agencia: " +
               ag.agencia.ToString + " Contas: " + String.Join(" | ", ag.ContasCorrentes))

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'Dim ListaDias As New List(Of String)
        'ListaDias.Add("Segunda")
        'ListaDias.Add("Terça")
        'ListaDias.Add("Quinta")
        'ListaDias.Add("Sexta")
        'ListaDias.Add("Sábado")

        'MsgBox(String.Join(" , ", ListaDias))

        'ListaDias.Add("Quarta")

        'MsgBox(String.Join(" , ", ListaDias))


        Dim ListaDiasLink As New LinkedList(Of String)

        Dim D4 As LinkedListNode(Of String) = ListaDiasLink.AddFirst("Quarta")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D2 As LinkedListNode(Of String) = ListaDiasLink.AddBefore(D4, "Segunda")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D3 As LinkedListNode(Of String) = ListaDiasLink.AddBefore(D4, "Terça")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D6 As LinkedListNode(Of String) = ListaDiasLink.AddAfter(D4, "Sexta")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D7 As LinkedListNode(Of String) = ListaDiasLink.AddAfter(D6, "Sábado")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D5 As LinkedListNode(Of String) = ListaDiasLink.AddBefore(D6, "Quinta")
        MsgBox(String.Join(" , ", ListaDiasLink))

        Dim D1 As LinkedListNode(Of String) = ListaDiasLink.AddFirst("Domingo")
        MsgBox(String.Join(" , ", ListaDiasLink))

        MsgBox("A lista linked possui " + ListaDiasLink.Count.ToString + " elementos.")

        For i As Integer = 0 To ListaDiasLink.Count - 1
            MsgBox(ListaDiasLink(i))
        Next

        MsgBox(String.Join(" , ", ListaDiasLink))
        ListaDiasLink.Remove(D1)
        MsgBox(String.Join(" , ", ListaDiasLink))
        ListaDiasLink.Remove("Quarta")
        MsgBox(String.Join(" , ", ListaDiasLink))

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim Paginas As New Stack(Of String)
        Paginas.Push("Página 1")
        Paginas.Push("Página 2")
        Paginas.Push("Página 3")
        Paginas.Push("Página 4")
        Paginas.Push("Página 5")
        MsgBox(String.Join(" , ", Paginas))
        Dim X As String = Paginas.Pop()
        MsgBox(String.Join(" , ", Paginas))
        Dim Y As String = Paginas.Peek()
        MsgBox(String.Join(" , ", Paginas))
        MsgBox(X + " - " + Y)

        Dim PaginasRevertidas = Paginas.Reverse
        MsgBox(String.Join(" , ", Paginas))
        MsgBox(String.Join(" , ", PaginasRevertidas))

        For I As Integer = 0 To Paginas.Count - 1
            MsgBox(Paginas(I))
        Next

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim Conta1 As New ContaCorrente(277, 223444, "João")
        Conta1.Depositar(10000)
        Dim Conta2 As New ContaCorrente(277, 255645, "Pedro")
        Conta2.Depositar(5000)
        Dim Conta3 As New ContaCorrente(500, 166323, "Alberto")
        Conta3.Depositar(7000)

        Dim ListaContasCorrentes As New List(Of ContaCorrente)
        ListaContasCorrentes.Add(Conta1)
        ListaContasCorrentes.Add(Nothing)
        ListaContasCorrentes.Add(Conta2)
        ListaContasCorrentes.Add(Nothing)
        ListaContasCorrentes.Add(Conta3)

        MsgBox("Lista de contas original: " + String.Join(",", ListaContasCorrentes))

        'Dim ListaAuxiliar As New List(Of ContaCorrente)
        'For I As Integer = 0 To ListaContasCorrentes.Count - 1
        '    If Not (ListaContasCorrentes(I) Is Nothing) Then
        '        ListaAuxiliar.Add(ListaContasCorrentes(I))
        '    End If
        'Next

        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) =
            ListaContasCorrentes.Where(Function(conta As ContaCorrente) Not (conta Is Nothing))

        ' ListaContasCorrentes.Sort(New CriterioContaCorrenteNome())
        Dim X As IEnumerable(Of ContaCorrente) =
            ListaAuxiliar.OrderBy(Function(conta As ContaCorrente) conta.titular.nome)

        MsgBox("Lista de contas ordenada por nome: " + String.Join(",", X))

        'ListaContasCorrentes.Sort(New CriterioContaCorrenteSaldo())
        Dim y As IEnumerable(Of ContaCorrente) =
            ListaAuxiliar.OrderBy(Function(conta As ContaCorrente) conta.saldo)

        MsgBox("Lista de contas ordenada por saldo: " + String.Join(",", y))

        'ListaContasCorrentes.Sort(New CriterioContaCorrenteAgenciaNumero())
        Dim z As IEnumerable(Of ContaCorrente) = ListaAuxiliar _
            .OrderBy(Function(conta As ContaCorrente) conta.agencia) _
            .OrderBy(Function(conta As ContaCorrente) conta.numero)

        MsgBox("Lista de contas ordenada por agencia/numero: " + String.Join(",", ListaContasCorrentes))


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim Conta1 As New ContaCorrente(277, 223444, "João")
        Conta1.Depositar(10000)
        Dim Conta2 As New ContaCorrente(277, 255645, "Pedro")
        Conta2.Depositar(5000)
        Dim Conta3 As New ContaCorrente(500, 166323, "Alberto")
        Conta3.Depositar(7000)

        Dim ListaContasCorrentes As New List(Of ContaCorrente)
        ListaContasCorrentes.Add(Conta1)
        ListaContasCorrentes.Add(Nothing)
        ListaContasCorrentes.Add(Conta2)
        ListaContasCorrentes.Add(Nothing)
        ListaContasCorrentes.Add(Conta3)

        Dim ListaContasCorrentes2 As New List(Of ContaCorrente)
        ListaContasCorrentes2.Add(Conta1)
        ListaContasCorrentes2.Add(Conta2)
        ListaContasCorrentes2.Add(Conta3)

        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) = ListaContasCorrentes _
            .Where(Function(conta As ContaCorrente) Not (conta Is Nothing)) _
            .OrderBy(Function(conta As ContaCorrente) conta.titular.nome)

        Dim MaiorSaldo2 As Double = ListaContasCorrentes _
            .Where(Function(conta As ContaCorrente) Not (conta Is Nothing)) _
            .OrderBy(Function(conta As ContaCorrente) conta.titular.nome) _
            .Min(Function(conta As ContaCorrente) conta.saldo)

        MsgBox("Lista de contas ordenada por nome: " + String.Join(",", ListaAuxiliar))

        Dim MenorSaldo As Double = ListaAuxiliar.Min(Function(conta As ContaCorrente) conta.saldo)
        MsgBox("O menor saldo é de: " + MenorSaldo.ToString)

        Dim MaiorSaldo As Double = ListaAuxiliar.Max(Function(conta As ContaCorrente) conta.saldo)
        MsgBox("O maior saldo é de: " + MaiorSaldo.ToString)

        Dim ListaAuxiliarComcatenada As IEnumerable(Of ContaCorrente) = ListaContasCorrentes _
           .Where(Function(conta As ContaCorrente) Not (conta Is Nothing)) _
           .OrderBy(Function(conta As ContaCorrente) conta.titular.nome) _
           .Concat(ListaContasCorrentes2)

        MsgBox("Lista de contas concatenadas " + String.Join(",", ListaAuxiliarComcatenada))

        Dim ListaAuxiliarComcatenada2 As IEnumerable(Of ContaCorrente) = ListaContasCorrentes _
         .Where(Function(conta As ContaCorrente) Not (conta Is Nothing)) _
         .Concat(ListaContasCorrentes2) _
         .OrderBy(Function(conta As ContaCorrente) conta.titular.nome)

        MsgBox("Lista de contas concatenadas " + String.Join(",", ListaAuxiliarComcatenada2))

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim Conta1 As New ContaCorrente(277, 223444, "João")
        Conta1.Depositar(10000)
        Dim Conta2 As New ContaCorrente(277, 255645, "Pedro")
        Conta2.Depositar(5000)
        Dim Conta3 As New ContaCorrente(500, 166323, "Alberto")
        Conta3.Depositar(7000)

        Dim ListaContasCorrentes As New List(Of ContaCorrente)
        ListaContasCorrentes.Add(Conta1)
        ListaContasCorrentes.Add(Conta2)
        ListaContasCorrentes.Add(Conta3)

        Dim Conta4 As New ContaCorrente(300, 881933, "Jorge")
        Conta4.Depositar(8500)
        Dim Conta5 As New ContaCorrente(305, 177383, "Lucia")
        Conta5.Depositar(9500)
        Dim Conta6 As New ContaCorrente(400, 866665, "Victor")

        Dim ListaContasCorrentes2 As New List(Of ContaCorrente)
        ListaContasCorrentes2.Add(Conta4)
        ListaContasCorrentes2.Add(Conta5)
        ListaContasCorrentes2.Add(Conta6)

        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) = ListaContasCorrentes _
            .Where(Function(conta As ContaCorrente) conta.agencia <> 500) _
            .Concat(ListaContasCorrentes2) _
            .Where(Function(conta As ContaCorrente) conta.agencia <> 400) _
            .OrderBy(Function(conta As ContaCorrente) conta.titular.nome)


        MsgBox("Lista de contas concatenadas " + String.Join(",", ListaAuxiliar))



    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        ' ######################################################################
        ' Criar uma lista de contas correntes e clientes
        ' ######################################################################

        Dim Cliente As New List(Of Cliente)
        Cliente.Add(CriarCliente("123123123123", "João da Silva", "Engenheiro"))
        Cliente.Add(CriarCliente("123123129999", "Pedro Alcantara", "Médico"))
        Cliente.Add(CriarCliente("123123888888", "Luzia Medeiros", "Mecânico"))
        Cliente.Add(CriarCliente("125656565656", "Márcia Andrade", "Engenheiro"))
        Cliente.Add(CriarCliente("186868686868", "Joana Silveira", "Empresário"))
        Cliente.Add(CriarCliente("139393939393", "Marcelo Almeira", "Engenheiro"))
        Cliente.Add(CriarCliente("186868686869", "Vitor Junior", "Analista de Sistemas"))

        Dim Contas As New List(Of ContaCorrente)
        Contas.Add(New ContaCorrente(277, 123221))
        Contas(0).titular = Cliente(0)
        Contas.Add(New ContaCorrente(277, 133323))
        Contas(1).titular = Cliente(0)
        Contas.Add(New ContaCorrente(277, 244323))
        Contas(2).titular = Cliente(2)
        Contas.Add(New ContaCorrente(277, 124543))
        Contas(3).titular = Cliente(1)
        Contas.Add(New ContaCorrente(277, 543434))
        Contas(4).titular = Cliente(1)
        Contas.Add(New ContaCorrente(277, 653443))
        Contas(5).titular = Cliente(3)
        Contas.Add(New ContaCorrente(277, 126544))
        Contas(6).titular = Cliente(4)
        Contas.Add(New ContaCorrente(277, 748383))
        Contas(7).titular = Cliente(5)

        ' ######################################################################
        ' criando a tabela de contas correntes
        ' ######################################################################

        ' Conta Corrente : Agencia (Int), Conta (Int), cfp (string), saldo (double)

        Dim Dt As New DataTable
        Dt.Columns.Add(CriarColuna("Agencia", "System.Int32"))
        Dt.Columns.Add(CriarColuna("Conta", "System.Int32"))
        Dt.Columns.Add(CriarColuna("CPF", "System.String"))
        Dt.Columns.Add(CriarColuna("Saldo", "System.Double"))

        ' definir chave primária

        Dim vArrayChavesContas(1) As DataColumn
        Dt.Columns("Agencia").AllowDBNull = False
        Dt.Columns("Conta").AllowDBNull = False
        vArrayChavesContas(0) = Dt.Columns("Agencia")
        vArrayChavesContas(1) = Dt.Columns("Conta")
        Dt.PrimaryKey = vArrayChavesContas

        ' Nome da tabela

        Dt.TableName = "Contas Correntes"

        ' ######################################################################
        ' Criar a tabela de Clientes
        ' ######################################################################

        Dim Dt2 As New DataTable
        Dt2.Columns.Add(CriarColuna("CPF", "System.String"))
        Dt2.Columns.Add(CriarColuna("Nome", "System.String"))
        Dt2.Columns.Add(CriarColuna("Profissao", "System.String"))

        ' Criando chave primária para cliente

        Dim vArrayChavesCliente(0) As DataColumn
        Dt2.Columns("CPF").AllowDBNull = False
        vArrayChavesCliente(0) = Dt2.Columns("CPF")
        Dt2.PrimaryKey = vArrayChavesCliente

        ' Nome da tabela

        Dt2.TableName = "Clientes"

        ' ######################################################################
        ' Criar o DataSET
        ' ######################################################################

        Dim DS As New DataSet
        DS.Tables.Add(Dt)
        DS.Tables.Add(Dt2)

        ' ######################################################################
        ' Criar a chave estrangeira
        '
        ' Clientes -------> Contas Correntes (FK)
        ' ######################################################################

        Dim FKClientesCC As New ForeignKeyConstraint("FKClientesCC",
                    DS.Tables("Clientes").Columns("CPF"),
                    DS.Tables("Contas Correntes").Columns("CPF"))

        FKClientesCC.DeleteRule = Rule.None

        DS.Tables("Contas Correntes").Constraints.Add(FKClientesCC)

        ' ######################################################################
        ' Incluir dados da tabela de clientes do DataSET
        ' ######################################################################

        For I As Integer = 0 To Cliente.Count - 1
            Dim ClienteAtual As Cliente = Cliente(I)
            Dim Dr As DataRow = DS.Tables("Clientes").NewRow

            Dr(0) = ClienteAtual.cpf
            Dr(1) = ClienteAtual.nome
            Dr(2) = ClienteAtual.profissao

            DS.Tables("Clientes").Rows.Add(Dr)

        Next

        ' ######################################################################
        ' Incluir dados da tabela de contas corrente do DataSET
        ' ######################################################################

        For I As Integer = 0 To Contas.Count - 1
            Dim ContaAtual As ContaCorrente = Contas(I)
            Dim Dr As DataRow = DS.Tables("Contas Correntes").NewRow

            Dr(0) = ContaAtual.agencia
            Dr(1) = ContaAtual.numero
            Dr(2) = ContaAtual.titular.cpf
            Dr(3) = ContaAtual.saldo

            DS.Tables("Contas Correntes").Rows.Add(Dr)

        Next

        ' ######################################################################
        ' Exibir dados do DataSet
        ' ######################################################################

        'For I As Integer = 0 To DS.Tables.Count - 1
        '    Dim DtX As New DataTable
        '    DtX = DS.Tables(I)
        '    For J As Integer = 0 To DtX.Rows.Count - 1
        '        Dim vSaida As String = ""
        '        For K As Integer = 0 To DtX.Columns.Count - 1
        '            vSaida += "Tabela => " + DS.Tables(I).TableName.ToString + " - Campo => " + DtX.Columns(K).ColumnName +
        '                " - Valor => " + DtX.Rows(J)(K).ToString + vbCrLf
        '        Next
        '        MsgBox(vSaida)
        '    Next
        'Next

        ' ######################################################################
        ' Criação de filtro para obter contas correntes de um correntista
        ' ######################################################################

        Dim vCriterio As String = "CPF = '123123129999'"
        Dim DtFiltro As DataTable = DS.Tables("Contas Correntes").Clone
        Dim DrLinhas As DataRow() = DS.Tables("Contas Correntes").Select(vCriterio)
        For Each row As DataRow In DrLinhas
            DtFiltro.ImportRow(row)
        Next
        'For I As Integer = 0 To DtFiltro.Rows.Count - 1
        '    Dim vSaida As String = ""
        '    For j As Integer = 0 To DtFiltro.Columns.Count - 1
        '        vSaida += "Campo => " + DtFiltro.Columns(j).ColumnName +
        '            " - Valor => " + DtFiltro.Rows(I)(j).ToString + vbCrLf
        '    Next
        '    MsgBox(vSaida)
        'Next

        ' ######################################################################
        ' Ordenar a tabela de clientes por nome
        ' ######################################################################

        Dim DtView As DataView
        DtView = DS.Tables("Clientes").DefaultView
        Dim vCriterioOrdenacao As String = "Nome"
        DtView.Sort = vCriterioOrdenacao
        Dim DtOrdenado As New DataTable
        DtOrdenado = DtView.ToTable


        ' ######################################################################
        ' Filtrando e ordenando ao mesmo tempo
        ' ######################################################################

        Dim DtView2 As New DataView(DS.Tables("Contas Correntes"), "CPF = '123123129999'",
                                    "CPF", DataViewRowState.CurrentRows)

        ' ######################################################################
        ' Excluindo linhas da tabela
        ' ######################################################################

        ''DS.Tables("Contas Correntes").Rows(0).Delete()
        'DS.Tables("Clientes").Rows(0).Delete()

        Dim vCriterio2 As String = "CPF = '123123129999'"
        Dim DrLinhas2 As DataRow() = DS.Tables("Contas Correntes").Select(vCriterio2)
        For Each row As DataRow In DrLinhas
            DS.Tables("Contas Correntes").Rows.Remove(row)
        Next

    End Sub

    Function CriarCliente(cpf As String, nome As String, profissao As String) As Cliente
        Dim C As New Cliente
        C.cpf = cpf
        C.nome = nome
        C.profissao = profissao
        Return C

    End Function

    Function CriarColuna(NomeColuna As String, TipColuna As String) As DataColumn
        Dim Dc As New DataColumn
        Dc.ColumnName = NomeColuna
        Dc.DataType = System.Type.GetType(TipColuna)
        Return Dc
    End Function
End Class
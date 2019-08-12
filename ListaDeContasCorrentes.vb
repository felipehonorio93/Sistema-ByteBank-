
Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class ListaDeContasCorrentes

#Region "Propriedades"

    Private Property _items() As ContaCorrente()
    Private Property _proximaposicao As Integer

    Public ReadOnly Property tamanho() As Integer
        Get
            Return _proximaposicao
        End Get

    End Property


#End Region

#Region "Indexadores"

    Default Public ReadOnly Property Item(indice As Integer)
        Get
            Return GetContaCorrente(indice)
        End Get

    End Property

#End Region

#Region "Construtores"

    Public Sub New(Optional numeroPosicoesIniciais As Integer = 5)

        _items = New ContaCorrente(numeroPosicoesIniciais - 1) {}
        _proximaposicao = 0

    End Sub

#End Region

#Region "Métodos"

    Public Sub MeuMetodo(Optional vString As String = "String Opcional", Optional vInteger As Integer = 10)
        MsgBox("VString = " + vString + ", vInteger = " + vInteger.ToString)
    End Sub

    Public Sub Adicionar(item As ContaCorrente)

        VerificarCapacidadeArrayCopy(_proximaposicao + 1)
        Console.WriteLine("Novo membro adicionado na posição " + _proximaposicao.ToString)
        _items(_proximaposicao) = item
        _proximaposicao += 1

    End Sub

    Private Sub VerificarCapacidadeArrayCopy(tamanhoNecessario As Integer)

        If _items.Length >= tamanhoNecessario Then
            Return
        End If

        Dim novoTamanho As Integer = _items.Length * 2

        If novoTamanho < tamanhoNecessario Then
            novoTamanho = tamanhoNecessario
        End If

        Dim NovoArray(novoTamanho) As ContaCorrente

        Array.Copy(_items, NovoArray, _items.Length)

        _items = NovoArray

    End Sub

    Private Sub VerificarCapacidadeArray(tamanhoNecessario As Integer)

        If _items.Length >= tamanhoNecessario Then
            Return
        End If

        Dim novoTamanho As Integer = _items.Length * 2

        If novoTamanho < tamanhoNecessario Then
            novoTamanho = tamanhoNecessario
        End If

        Dim NovoArray(novoTamanho) As ContaCorrente

        For i As Integer = 0 To _items.Length - 1
            Console.WriteLine(".")
            NovoArray(i) = _items(i)
        Next
        _items = NovoArray

    End Sub

    Public Function posicaoElemento(Conta As ContaCorrente) As Integer

        For i As Integer = 0 To _proximaposicao - 1
            Dim contaAtual As ContaCorrente = _items(i)
            If contaAtual.Equals(Conta) Then
                Return i
            End If
        Next

        Return -1

    End Function

    Public Sub Remover(Conta As ContaCorrente)


        Dim indice As Integer = posicaoElemento(Conta)
        If indice = -1 Then
            Return
        End If

        _proximaposicao -= 1
        For i As Integer = indice To _proximaposicao - 1
            _items(i) = _items(i + 1)
        Next

    End Sub

    Public Function EscreverElementosArray() As String

        Dim elementos As String = String.Empty
        For i As Integer = 0 To _proximaposicao - 1
            elementos += _items(i).agencia.ToString + " - " + _items(i).numero.ToString + vbCrLf
        Next
        For i As Integer = _proximaposicao To _items.Length - 1
            elementos += "NULL" + vbCrLf
        Next

        Return elementos

    End Function

    Public Function GetContaCorrente(indice As Integer) As ContaCorrente

        If indice < 0 And indice >= _proximaposicao Then
            Throw New ArgumentOutOfRangeException(NameOf(indice))
        End If
        Return _items(indice)

    End Function

    Public Sub AdicionarVarios(contas As ContaCorrente())

        'For i As Integer = 0 To contas.Length - 1
        '    Adicionar(contas(i))
        'Next

        For Each conta As ContaCorrente In contas
            Adicionar(conta)
        Next

    End Sub

    Public Sub AdicionarVariosUmAUm(ParamArray contas As ContaCorrente())

        ''For i As Integer = 0 To contas.Length - 1
        ''    Adicionar(contas(i))
        ''Next

        For Each conta As ContaCorrente In contas
            Adicionar(conta)
        Next

    End Sub

    Public Function somaNumeros(ParamArray numeros() As Integer) As Integer

        Dim soma As Integer = 0
        For Each numero As Integer In numeros
            soma += numero
        Next
        Return soma

    End Function


#End Region




End Class

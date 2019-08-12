

Public Class Lista(Of T)

#Region "Propriedades"

    Private Property _items() As T()
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
            Return GetItem(indice)
        End Get

    End Property

#End Region

#Region "Construtores"

    Public Sub New(Optional numeroPosicoesIniciais As Integer = 5)

        _items = New T(numeroPosicoesIniciais - 1) {}
        _proximaposicao = 0

    End Sub

#End Region

#Region "Métodos"

    Public Sub Adicionar(item As T)

        VerificarCapacidadeArrayCopy(_proximaposicao + 1)
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

        Dim NovoArray(novoTamanho) As T

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

        Dim NovoArray(novoTamanho) As T

        For i As Integer = 0 To _items.Length - 1
            NovoArray(i) = _items(i)
        Next
        _items = NovoArray

    End Sub

    Public Function posicaoElemento(item As T) As Integer

        For i As Integer = 0 To _proximaposicao - 1
            Dim itemAtual As T = _items(i)
            If itemAtual.Equals(item) Then
                Return i
            End If
        Next

        Return -1

    End Function

    Public Sub Remover(item As T)


        Dim indice As Integer = posicaoElemento(item)
        If indice = -1 Then
            Return
        End If

        _proximaposicao -= 1
        For i As Integer = indice To _proximaposicao - 1
            _items(i) = _items(i + 1)
        Next

    End Sub

    Public Function GetItem(indice As Integer) As T

        If indice < 0 And indice >= _proximaposicao Then
            Throw New ArgumentOutOfRangeException(NameOf(indice))
        End If
        Return _items(indice)

    End Function

    Public Sub AdicionarVarios(items As T())

        'For i As Integer = 0 To contas.Length - 1
        '    Adicionar(contas(i))
        'Next

        For Each item As T In items
            Adicionar(item)
        Next

    End Sub

    Public Sub AdicionarVariosUmAUm(ParamArray items As T())

        ''For i As Integer = 0 To contas.Length - 1
        ''    Adicionar(contas(i))
        ''Next

        For Each item As T In items
            Adicionar(item)
        Next

    End Sub

#End Region

End Class

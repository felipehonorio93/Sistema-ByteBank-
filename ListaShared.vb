Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class ListaShared

    Shared Sub AdicionarVarios(Lista As List(Of ContaCorrente), ParamArray ListaInclusao() As ContaCorrente)

        For Each conta As ContaCorrente In ListaInclusao
            Lista.Add(conta)
        Next

    End Sub

End Class

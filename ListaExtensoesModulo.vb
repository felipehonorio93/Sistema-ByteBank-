Imports System.Runtime.CompilerServices
Imports ByteBank.Bibliotecas.Classes.Clientes
Module ListaExtensoesModulo

    <Extension()>
    Public Sub AdicionarVariosUmAUm(Lista As List(Of ContaCorrente), ParamArray ListaInclusao() As ContaCorrente)

        For Each conta As ContaCorrente In ListaInclusao
            Lista.Add(conta)
        Next

    End Sub

End Module

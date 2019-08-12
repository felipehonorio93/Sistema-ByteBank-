Imports ByteBank.Bibliotecas.Classes.Funcionarios

Namespace classes

    Public Class Aleatorio

#Region "PROPRIEDADES"

        Public Property MenorNumero As Double
        Public Property MaiorNumero As Double


#End Region

#Region "CONSTRUTORES"

        Public Sub New(_MenorNumero As Integer, _MaiorNumero As Integer)

            MenorNumero = _MenorNumero
            MaiorNumero = _MaiorNumero

        End Sub
#End Region

#Region "MÉTODOS"

        Public Function getNumeroAleatorio() As Double
            Dim NumeroRandom As New Random()
            Dim NumeroAtual As Double = NumeroRandom.Next(MenorNumero, MaiorNumero)
            Return NumeroAtual
        End Function

#End Region

    End Class

End Namespace



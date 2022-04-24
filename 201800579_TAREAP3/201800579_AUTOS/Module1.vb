Module Module1

    Public Const Tipo1 = 500
    Public Const Tipo2 = 400
    Public Const Tipo3 = 300
    Public Const Tipo4 = 200

    Public Const Kilometro1 = 3.0
    Public Const Kilometro2 = 4.0
    Public Const kilometro3 = 5.0


    Public pos As String
    Public TipoAuto(7) As String
    Public KilometrajeInicial(7) As Double
    Public KilometrajeFinal(7) As Double
    Public NumeroPlaca(7) As Double

    Public CostoAlquiler(7) As Double
    Public CostoKilometraje(7) As Double
    Public PagoTotal(7) As Double


    Sub Limpiar_Grid()

        Form1.DataGridViewDatos.Rows.Clear()

    End Sub

    Sub Limpiar_Entradas()
        Form1.TBKmInicial.Clear()
        Form1.TBKmFinal.Clear()
        Form1.TBNoPlaca.Clear()

        Form1.LBCAlquiler.Text = "0.00"
        Form1.LBCKilometraje.Text = "0.00"
        Form1.LBTotalPagar.Text = "0.00"

        Form1.CBTipoAuto.Text = "Seleccione Tipo"

    End Sub
End Module

Public Class Form1

    Dim resta As Double
    Dim a As Double
    Dim b As Double

    'codigo para que solo permita ingreso de numeros
    Private Sub TextBoxKmInicial_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBKmInicial.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    'codigo para que solo permita ingreso de numeros
    Private Sub TextBoxKmFinal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBKmFinal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'codigo para que solo permita ingreso de numeros

    Private Sub TextBoxNoPlaca_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TBNoPlaca.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea Salir?", vbQuestion + vbYesNo, "Salir") = vbYes Then

            Me.Close()
        End If
    End Sub

    Private Sub CalcularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcularToolStripMenuItem.Click


        If pos < 7 Then

            'si se selecciona el tipo el tipo 1 la unfornacion se enviara de la sigueinte manera
            If CBTipoAuto.SelectedItem = "Tipo 1" Then
                TipoAuto(pos) = CBTipoAuto.SelectedItem
                KilometrajeInicial(pos) = TBKmInicial.Text
                KilometrajeFinal(pos) = TBKmFinal.Text
                NumeroPlaca(pos) = TBNoPlaca.Text

                LBCAlquiler.Text = Tipo1
                CostoAlquiler(pos) = LBCAlquiler.Text
                resta = TBKmFinal.Text - TBKmInicial.Text

                If resta <= 50 Then
                    LBCKilometraje.Text = Kilometro1 * resta
                    CostoKilometraje(pos) = LBCKilometraje.Text
                    a = LBCAlquiler.Text
                    b = LBCKilometraje.Text
                    LBTotalPagar.Text = a + b
                    PagoTotal(pos) = LBTotalPagar.Text

                End If

                If resta >= 51 And resta <= 70 Then
                    LBCKilometraje.Text = Kilometro2 * resta
                    CostoKilometraje(pos) = LBCKilometraje.Text
                    a = LBCAlquiler.Text
                    b = LBCKilometraje.Text
                    LBTotalPagar.Text = a + b
                    PagoTotal(pos) = LBTotalPagar.Text
                End If

                If resta >= 71 Then
                    LBCKilometraje.Text = kilometro3 * resta
                    CostoKilometraje(pos) = LBCKilometraje.Text
                    a = LBCAlquiler.Text
                    b = LBCKilometraje.Text
                    LBTotalPagar.Text = a + b
                    PagoTotal(pos) = LBTotalPagar.Text
                End If

                MsgBox("se registro conexito")
            End If

            ' Código para el tipo 2 de auto ************************************************

            If CBTipoAuto.SelectedItem = "Tipo 2" Then
                TipoAuto(pos) = CBTipoAuto.SelectedItem
                KilometrajeInicial(pos) = TBKmInicial.Text
                KilometrajeFinal(pos) = TBKmFinal.Text
                NumeroPlaca(pos) = TBNoPlaca.Text

                LBCAlquiler.Text = Tipo2
                CostoAlquiler(pos) = LBCAlquiler.Text
                resta = TBKmFinal.Text - TBKmInicial.Text

                If resta <= 50 Then
                    LBCKilometraje.Text = Kilometro1 * resta
                    CostoKilometraje(pos) = LBCKilometraje.Text
                    a = LBCAlquiler.Text
                    b = LBCKilometraje.Text
                    LBTotalPagar.Text = a + b
                    PagoTotal(pos) = LBTotalPagar.Text

                End If

                If resta >= 51 And resta <= 70 Then
                    LBCKilometraje.Text = Kilometro2 * resta
                    CostoKilometraje(pos) = LBCKilometraje.Text
                    a = LBCAlquiler.Text
                    b = LBCKilometraje.Text
                    LBTotalPagar.Text = a + b
                    PagoTotal(pos) = LBTotalPagar.Text
                End If

                If resta >= 71 Then
                    LBCKilometraje.Text = kilometro3 * resta
                    CostoKilometraje(pos) = LBCKilometraje.Text
                    a = LBCAlquiler.Text
                    b = LBCKilometraje.Text
                    LBTotalPagar.Text = a + b
                    PagoTotal(pos) = LBTotalPagar.Text
                End If
                MsgBox("se registro conexito")
            End If

            ' Código para el tipo 3 de auto **********************************************

            If CBTipoAuto.SelectedItem = "Tipo 3" Then
                TipoAuto(pos) = CBTipoAuto.SelectedItem
                KilometrajeInicial(pos) = TBKmInicial.Text
                KilometrajeFinal(pos) = TBKmFinal.Text
                NumeroPlaca(pos) = TBNoPlaca.Text

                LBCAlquiler.Text = Tipo3
                CostoAlquiler(pos) = LBCAlquiler.Text
                resta = TBKmFinal.Text - TBKmInicial.Text

                If resta <= 50 Then
                    LBCKilometraje.Text = Kilometro1 * resta
                    CostoKilometraje(pos) = LBCKilometraje.Text
                    a = LBCAlquiler.Text
                    b = LBCKilometraje.Text
                    LBTotalPagar.Text = a + b
                    PagoTotal(pos) = LBTotalPagar.Text

                End If

                If resta >= 51 And resta <= 70 Then
                    LBCKilometraje.Text = Kilometro2 * resta
                    CostoKilometraje(pos) = LBCKilometraje.Text
                    a = LBCAlquiler.Text
                    b = LBCKilometraje.Text
                    LBTotalPagar.Text = a + b
                    PagoTotal(pos) = LBTotalPagar.Text
                End If

                If resta >= 71 Then
                    LBCKilometraje.Text = kilometro3 * resta
                    CostoKilometraje(pos) = LBCKilometraje.Text
                    a = LBCAlquiler.Text
                    b = LBCKilometraje.Text
                    LBTotalPagar.Text = a + b
                    PagoTotal(pos) = LBTotalPagar.Text
                End If
                MsgBox("se registro conexito")
            End If

            ' Código para el tipo 4 de auto **************************************************

            If CBTipoAuto.SelectedItem = "Tipo 4" Then
                TipoAuto(pos) = CBTipoAuto.SelectedItem
                KilometrajeInicial(pos) = TBKmInicial.Text
                KilometrajeFinal(pos) = TBKmFinal.Text
                NumeroPlaca(pos) = TBNoPlaca.Text

                LBCAlquiler.Text = Tipo4
                CostoAlquiler(pos) = LBCAlquiler.Text
                resta = TBKmFinal.Text - TBKmInicial.Text

                If resta <= 50 Then
                    LBCKilometraje.Text = Kilometro1 * resta
                    CostoKilometraje(pos) = LBCKilometraje.Text
                    a = LBCAlquiler.Text
                    b = LBCKilometraje.Text
                    LBTotalPagar.Text = a + b
                    PagoTotal(pos) = LBTotalPagar.Text

                End If

                If resta >= 51 And resta <= 70 Then
                    LBCKilometraje.Text = Kilometro2 * resta
                    CostoKilometraje(pos) = LBCKilometraje.Text
                    a = LBCAlquiler.Text
                    b = LBCKilometraje.Text
                    LBTotalPagar.Text = a + b
                    PagoTotal(pos) = LBTotalPagar.Text
                End If

                If resta >= 71 Then
                    LBCKilometraje.Text = kilometro3 * resta
                    CostoKilometraje(pos) = LBCKilometraje.Text
                    a = LBCAlquiler.Text
                    b = LBCKilometraje.Text
                    LBTotalPagar.Text = a + b
                    PagoTotal(pos) = LBTotalPagar.Text
                End If
                MsgBox("se registro conexito")
            End If


            DataGridViewDatos.Rows.Add(pos + 1, TipoAuto(pos), KilometrajeInicial(pos), KilometrajeFinal(pos), NumeroPlaca(pos), CostoAlquiler(pos), CostoKilometraje(pos), PagoTotal(pos))
            pos = pos + 1
        Else

            MessageBox.Show("Ya se lleno el cupo")
        End If


    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        pos = 0
        ReDim TipoAuto(7)
        ReDim KilometrajeInicial(7)
        ReDim KilometrajeFinal(7)
        ReDim NumeroPlaca(7)
        ReDim CostoAlquiler(7)
        ReDim CostoKilometraje(7)
        ReDim PagoTotal(7)

        Limpiar_Grid()
        Limpiar_Entradas()


        MessageBox.Show("Vectores Limpios")

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarToolStripMenuItem.Click
        DataGridViewDatos.Visible = True
    End Sub
End Class

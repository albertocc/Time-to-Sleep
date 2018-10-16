Public Class frmOpciones

    Private Sub Opciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmPrincipal.Enabled = False
        PorcentajeBrillo.Value = My.Settings.Brillo_Op
        Op_HorasTxt.Value = My.Settings.Horas_Op
        Op_MinutosTxt.Value = My.Settings.Minutos_Op
        Op_SegundosTxt.Value = My.Settings.Segundos_Op
        Op_Combo.SelectedItem = My.Settings.Combo_Op

        lblBrillo.Text = My.Settings.Brillo_Op + "%"
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        frmPrincipal.Enabled = True
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        My.Settings.Brillo_Op = PorcentajeBrillo.Value
        My.Settings.Horas_Op = Op_HorasTxt.Value
        My.Settings.Minutos_Op = Op_MinutosTxt.Value
        My.Settings.Segundos_Op = Op_SegundosTxt.Value
        My.Settings.Combo_Op = Op_Combo.SelectedItem
        My.Settings.Save()

        frmPrincipal.Enabled = True
        Me.Close()
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles PorcentajeBrillo.Scroll
        lblBrillo.Text = PorcentajeBrillo.Value
        lblBrillo.Text = lblBrillo.Text + "%" 'Esto es una solución un poco chapuza...
    End Sub
End Class
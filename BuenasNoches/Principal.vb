Imports System.Management

Public Class frmPrincipal
    'Atenuar pantalla
    Private brightness As Short = 5

    Public Shared Sub SetBrightness(ByVal targetBrightness As Byte)
        Dim scope As ManagementScope = New ManagementScope("root\WMI")
        Dim query As SelectQuery = New SelectQuery("WmiMonitorBrightnessMethods")
        Using searcher = New ManagementObjectSearcher(scope, query)
            Using objectCollection = searcher.Get()
                For Each mObj As ManagementObject In objectCollection
                    mObj.InvokeMethod("WmiSetBrightness",
                        New Object() {Int32.MaxValue, targetBrightness})
                Next
            End Using
        End Using
    End Sub
    'Cuenta atrás
    Private Sub Contador_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Contador.Tick
        Try
            'Contador
            If Segundos.Value = 0 Then
                If Minutos.Value = 0 Then
                    Horas.Value = Horas.Value - 1
                    Minutos.Value = 59
                Else
                    Minutos.Value = Minutos.Value - 1

                End If
                Segundos.Value = 59
            Else
                Segundos.Value = Segundos.Value - 1
            End If

            'Si está minimizado cambia el título
            If Me.WindowState = FormWindowState.Minimized Then
                'Muestra el tiempo restante en el título
                Me.Text = Horas.Value & ":" & Minutos.Value & ":" & Segundos.Value
            Else
                Me.Text = "Buenas noches"
            End If

            'Si el contador está a cero hiberna
            If Horas.Value = 0 And Minutos.Value = 0 And Segundos.Value = 0 Then

                If My.Settings.Combo_Op = "Hibernar" Then
                    Shell("rundll32.exe PowrProf.dll,SetSuspendState") 'Hibernate computer
                ElseIf My.Settings.Combo_Op = "Suspender" Then
                    Shell("rundll32.exe powrprof.dll,SetSuspendState 0,1,0") 'Sleep computer
                ElseIf My.Settings.Combo_Op = "Apagar" Then
                    Shell("Shutdown.exe -s -t 00") 'Apagar ordenador
                End If

                'Shell("Rundll32.exe User32.dll,LockWorkStation") 'Bloquear

                Me.Close()
            End If

        Catch
        End Try
    End Sub

    Private Sub btnActivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivar.Click
        If btnActivar.Text = "▶" Then
            btnActivar.Text = "⬛"
            Contador.Enabled = True
            Horas.Enabled = False
            Minutos.Enabled = False
            Segundos.Enabled = False
            Atenuar.Enabled = False
            'Atenuar si está marcado
            If Atenuar.Checked = True Then
                'Prueba si la pantalla es compatible...
                Try
                    brightness = My.Settings.Brillo_Op
                    SetBrightness(brightness)
                Catch ex As Exception
                    'Si no es compatible...
                    MsgBox("La opción de 'atenuar pantalla' sólo es compatible con ordenadores portátiles.", MsgBoxStyle.Information)
                    Atenuar.Checked = False
                End Try

            End If
            'Minimiza
            Me.WindowState = FormWindowState.Minimized
        Else
            btnActivar.Text = "▶"
            Contador.Enabled = False
            Horas.Enabled = True
            Minutos.Enabled = True
            Segundos.Enabled = True
            Atenuar.Enabled = True
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MsgBox("Hora de Dormir versión v0.9" & vbNewLine & "Creado por albertocc :)", MsgBoxStyle.Information)
    End Sub

    Private Sub frmPrincipal_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnActivar.PerformClick()
        End If
    End Sub

    Private Sub frmPrincipal_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'Cuando se minimiza (Se puede borrar esto si no se necesita en el futuro)
    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Horas.Value = My.Settings.Horas_Op
        Minutos.Value = My.Settings.Minutos_Op
        Segundos.Value = My.Settings.Segundos_Op

        Atenuar.Checked = My.Settings.Atenuar_Op
    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpcionesToolStripMenuItem.Click
        frmOpciones.Show()
    End Sub

    Private Sub Atenuar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Atenuar.CheckedChanged
        My.Settings.Atenuar_Op = Atenuar.Checked
    End Sub

    Private Sub Horas_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnActivar.PerformClick()
        End If
    End Sub

    Private Sub Minutos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnActivar.PerformClick()
        End If
    End Sub

    Private Sub Segundos_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnActivar.PerformClick()
        End If
    End Sub

    Private Sub Atenuar_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Atenuar.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnActivar.PerformClick()
        End If
    End Sub

    'Añadir un minuto mas cuando se pulsa el botón de subir cuando 59"
    'Private Sub Segundos_ValueChanged(sender As System.Object, e As System.EventArgs) Handles Segundos.ValueChanged
    'If (Convert.ToInt32(Segundos.Text) < Segundos.Value) Then
    'Se ha pulsado ↑
    'Else
    'Se ha pulsado ↓
    'End If
    'End Sub
End Class
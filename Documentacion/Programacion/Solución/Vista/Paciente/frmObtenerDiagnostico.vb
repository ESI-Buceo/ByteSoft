﻿Imports Logica
Public Class frmObtenerDiagnostico

    Dim pat As New ControladorPatologia
    Private Sub frmObtenerDiagnostico_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.Black, ButtonBorderStyle.Solid)
    End Sub
    Private Sub frmObtenerDiagnostico_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim nombreDiagnostico As New ArrayList


        For i As Integer = 0 To dgvPosiblesDiagnosticos.RowCount - 1

            nombreDiagnostico.Add(dgvPosiblesDiagnosticos.Rows(i).Cells(0).Value.ToString)

        Next

        If pat.guardarDiagnostico(Datos_Temporales.user_temp, nombreDiagnostico) = False Then
            MsgBox("Error al almacenar el diagnóstico")
        End If

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub dgvPosiblesDiagnosticos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPosiblesDiagnosticos.CellDoubleClick

        If pat.informacionPatologia(dgvPosiblesDiagnosticos.CurrentCell.Value.ToString) Is Nothing Then
            MsgBox("Error al obtener la descripción")
        Else
            UserControl11.lblNom.Text = dgvPosiblesDiagnosticos.CurrentCell.Value.ToString
            UserControl11.lblDesc.Text = pat.informacionPatologia(dgvPosiblesDiagnosticos.CurrentCell.Value.ToString)
            UserControl11.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmIngresarSintomas.Visible = True
        Me.Dispose()
    End Sub
End Class
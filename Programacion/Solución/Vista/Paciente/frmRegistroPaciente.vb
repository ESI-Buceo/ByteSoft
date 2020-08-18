﻿Imports Logica
Public Class frmRegistroPaciente

    Dim aliTel As New ArrayList
    Dim check As New Verificacion
    Dim seg As New Encriptar
    Dim pass As String
    Dim sexo As String

    Private Sub frmRegistroPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Principal.Singleton.roundedCorners(Me)
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click

        If Principal.Singleton.verificarCedula(check, txtCed.Text) Then
            If Principal.Singleton.verificarContraseña(seg, txtPass1.Text, txtPass2.Text) Then
                pass = seg.HASH256(txtPass1.Text)
                If Principal.Singleton.verificarString(check, txtPrimerNombre.Text, txtPrimerApellido.Text, txtSegundoNombre.Text, txtSegundoApellido.Text) Then
                    If Principal.Singleton.verificarEmail(check, txtMail.Text) Then
                        If Principal.Singleton.verificarTelefonos(dgvTelefonos, aliTel) Then
                            If txtFecNac.Text <> "" Then

                                If cbM.Checked Then
                                    sexo = "M"
                                Else
                                    sexo = "F"
                                End If

                                Dim pac As New ControladorPaciente(txtCed.Text,
                                           pass,
                                           txtPrimerNombre.Text.ToUpper,
                                           txtSegundoNombre.Text.ToUpper,
                                           txtPrimerApellido.Text.ToUpper,
                                           txtSegundoApellido.Text.ToUpper,
                                           aliTel,
                                           txtMail.Text,
                                           sexo,
                                           txtFecNac.Text)

                                If pac.registrar() Then

                                    MsgBox("Paciente registrado, debe esperar a ser habilitiado")
                                    Principal.Singleton.limpiar(txtCed, txtPass1, txtPass2, txtPrimerNombre,
                                            txtPrimerApellido,
                                            txtSegundoApellido, txtSegundoNombre,
                                            txtMail, dgvTelefonos, aliTel)
                                    txtFecNac.Clear()
                                    cbM.Checked = True

                                Else
                                    MsgBox("El paciente ya fue registrado")

                                End If

                            Else
                                MsgBox("Debe ingresar su fecha de nacimiento")
                            End If

                        End If
                    End If
                End If
            End If
        Else
            MsgBox("La cédula ingresada no es correcta")
        End If

    End Sub

    Private Sub MaterialRaisedButton2_Click_1(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click

        If check.verificar_int(dgvTelefonos.Rows(dgvTelefonos.Rows.Count - 2).Cells(0).Value.ToString) = False Then

            MsgBox("Ingresó un teléfono incorrecto")
            dgvTelefonos.Rows.RemoveAt(dgvTelefonos.Rows.Count - 2)

        End If

        Panel12.Hide()
        ''add animacion

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

        If Panel12.Visible = False Then

            Panel12.Visible = True

        End If

    End Sub

    Private Sub MaterialRaisedButton3_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        dgvTelefonos.Rows.RemoveAt(dgvTelefonos.SelectedRows(0).Index)
    End Sub

    Private Sub dgvTelefonos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTelefonos.CellClick

        btnEliminar.Enabled = True
        ' no permite elimianr si no hay ninguna cell seleccionada
    End Sub

    Private Sub txtFecNac_Click(sender As Object, e As EventArgs) Handles txtFecNac.Click
        txtFecNac.Select(0, 0)
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        MsgBox(txtFecNac.Text)
        If Not (txtCed.Text = Nothing And txtPrimerNombre.Text = Nothing And txtPrimerApellido.Text = Nothing And
            txtPrimerNombre.Text = Nothing And txtSegundoApellido.Text = Nothing And txtSegundoNombre.Text = Nothing And
            txtPass1.Text = Nothing And txtPass2.Text = Nothing And dgvTelefonos.Rows.Count > 0) Then 'agregar txtFecnac
            Dim res = MsgBox("Hay información sin guardar, ¿seguro desea salir?", vbYesNo)
            If res = vbYes Then
                Me.Close()
                frmLogin.Show()
            End If
        Else

            Me.Close()
            frmLogin.Show()
        End If

    End Sub
End Class
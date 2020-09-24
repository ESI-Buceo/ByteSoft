﻿Imports Vista
Imports Logica
Public Class main

    Public Shared instancia As main
    Public Shared Function Singleton() As main
        If instancia Is Nothing Then
            instancia = New main
        End If

        Return instancia
    End Function
    Public Function GetInstancia() As main
        Return instancia
    End Function
    Public Sub New()
        InitializeComponent()
        instancia = Me
        Dim frm As New frmLogin
        frm.mcbRecordarUsuario.Visible = False
        frm.lblCrearCuentaPac.Visible = True
        frm.lblApp.Text = "Paciente"
        Principal.Singleton.CargarVentana(ventana, frm)
        Datos_Temporales.rol = Datos_Temporales.enumRol.Paciente
        cambiarTamaño()
    End Sub
    Public Sub cambiarTamaño()
        Me.SuspendLayout()
        Me.Size = New Size(Datos_Temporales.horizontal, Datos_Temporales.vertical + 38)
        Me.MinimumSize = New Size(Datos_Temporales.horizontal, Datos_Temporales.vertical + 38)
        Me.MaximumSize = New Size(Datos_Temporales.horizontal, Datos_Temporales.vertical + 38)
        Me.CenterToScreen()
        Me.ResumeLayout()
    End Sub

End Class
#!/bin/bash

. "/Scripts/InterfazGrafica/Control/inicio.sh"

. "/Scripts/ABM/Menus/VPrincipalMenuUsuarios.sh"
. "/Scripts/Computos/Respaldo/VPrincipalRespaldos.sh"
. "/Scripts/Computos/Logs/VLogs.sh"
. "/Scripts/Computos/Procesos/VAccionesProcesos.sh"
. "/Scripts/Computos/Servicios/VPrincipalMenuServicios.sh"
. "/Scripts/Computos/Servicios/VConexiones.sh"
. "/Scripts/Computos/Red/VPrincipalRedes.sh"

PrincipalComputos() {

    local continuar=true
    
    iniciarPantallaNueva
    dibujarTxt "CENTRO DE COMPUTOS" 43 3 0

    dibujarTxt "4 -> ARRIBA" 11 3 0
    dibujarTxt "5 -> ENTER " 11 4 0
    dibujarTxt "6 -> ABAJO" 11 5 0
    
    dibujarBoton "USUARIOS" 11 6 80 3
    dibujarBoton "SERVICIOS" 11 9 80 3
    dibujarBoton "PROCESOS" 11 12 80 3
    dibujarBoton "IPTABLES" 11 15 80 3
    dibujarBoton "COMPROBAR RED" 11 18 80 3
    dibujarBoton "LOGS" 11 21 80 3
    dibujarBoton "RESPALDOS" 11 24 80 3
    dibujarBoton "VOLVER" 11 27 80 3


    while $continuar; 
    do
        siguientePos

        if $respuestaGestor; 
        then
            continuar=false
        fi 

    done

}

ejecutarComputos() {

    local continuarCiclo=true

    while $continuarCiclo; 
    do
        PrincipalComputos
        case $posDeEsteElemento in 

            "0")
                ejecutarUsuario
                ;;

            "1")
                ejecutarMenuPrincipalServicios 
                ;;
                
            "2")
                ejecutarProcesos
                            
                ;;

            "3")
                ejecutarPrincipalRed
                ;;

            "4")
                comprobarRed
                ;;

            "5") 
                ejecutarLogs                
                ;;
            "6") 
                ejecutarRespaldos
                ;;

            "7")
                continuarCiclo=false
                ;;
                  
            *)
                ;;
        esac
        cerrarPantalla

    done

}
comprobarRed () {

    if ping -c1 8.8.8.8 &>/dev/null;
    then
        mensajeError "Se detectó conexión a internet" 2 37 33 2 2 2
    else
        mensajeError "No Se detectó conexión a internet" 1 37 33 2 1 2
    fi

}
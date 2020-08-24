#!/bin/bash

. "/Scripts/InterfazGrafica/Grafica/disenoVentana.sh" 


pantallaSSH() {
    local usuarios=""
    local root="no"
    local continuar=true

    colorBgDefecto=0
    iniciarPantallaNueva
    

    dibujarRectangulo 11 4 80 40 7
    dibujarTxt "CONFIGURANDO SSH" 44 7 0 7

    dibujarTxt "Usuarios permitidos (user1,user2)" 36 11 0 7
    dibujarEntradaTxt 36 12 31 false

    dibujarTxt "Permitir usuarios root" 40 16 0 7
    dibujarSwitch 36 17 30 3 $root

    dibujarBoton "Configurar" 27 24 50 3

    while $continuar; 
    do
        siguientePos

        case $posDeEsteElemento in

            "0")
                usuarios=$respuestaGestor
                ;;

            "1")
                if [ $codigoRespuesta = "5" ]; 
                then                    
                    if [[ "$root" == "yes" ]]; then
                        root="no"
                    else
                        root="yes"
                    fi
                fi
                ;;

                "2") 
                if $respuestaGestor;
                then
                    configurarSSH $root
                    mensajeError "El puerto por defecto será el 2022" 2 34 33 5 5 2 2
                    continuar=false
                fi   
                ;;  

        esac
    done

}

configurarSSH () {
    # $1 : root
    root=$1
    if [ -z $usuarios ]; 
    then
        cp -a /etc/ssh/sshd_config /var/bytesoft/.sshd_config
        sed -i 's/#Port 22/Port 2022/' /etc/ssh/sshd_config # Cambio el puerto por defecto al 7222
        sed -i "s/#PermitRootLogin yes/PermitRootLogin "$root"/" /etc/ssh/sshd_config
        semanage port -a -t ssh_port_t -p tcp 2022 > /dev/null 2>&1                                         
        systemctl restart sshd > /dev/null 2>&1
    else
       cp -a /etc/ssh/sshd_config /var/bytesoft/.sshd_config
       sed -i 's/#Port 22/Port 2022/' /etc/ssh/sshd_config # Cambio el puerto por defecto al 7222
       echo "AllowUsers $usuarios">>/etc/ssh/sshd_config
       sed -i "s/#PermitRootLogin yes/PermitRootLogin "$root"/" /etc/ssh/sshd_config
       semanage port -a -t ssh_port_t -p tcp 2022 > /dev/null 2>&1
       systemctl restart sshd > /dev/null 2>&1
    fi

}

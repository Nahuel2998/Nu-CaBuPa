#!/bin/bash
Crear () {
    printf "%s\n" "Desea crear un archivo o subdirectorio?" "1)Archivo" "2)Subdirectorio" "3)Salir"
    read OP
    RecD $TD
}

#Recorre el directorio recursivamente
RecD () {
    printf "%s\n" "Donde desea crearlo?"
    printf "%s\n" $(tree)
    read nombre
    Direcciones=$(find -type d -name $nombre)
    if [ ${#Direcciones[@]} -eq 1 ]; then
        DirTemp=$Direcciones[0]
    elif [ ${#Direcciones[@]} -gt 1 ]; then
        printf "%s\n" "A cual directorio se refiere?"
        Num=0
        for dir in Direcciones; do
            printf "$Num)%s\n" $dir
            Num=`expr $num + 1`
        done
        read Opcion
        if [ -d "Direcciones[$Num]" ]; then
            DirTemp=$Direcciones[$Num]
        else
            printf "%s\n" "No se encontró la opción"
        fi
    else
        printf "%s\n" "No se encontró el directorio" "Ingrese 0 para salir"
        read Salir
        if [ $salir -eq 0 ]; then
            exit
        fi
        RecD
    fi
}

TD=""
DirTemp=""
OP=""
#Se pregunta cual es la dirección en la que se creará el arbol
printf "%s\n" "Indique la dirección en la que se creará el arbol"
read TD
#Verificamos que no sea camino absoluto y de que exista
TD=$(echo $TD | sed 's/^\///') 
TD="~/"$TD
if [ -d $TD ] ; then
    else
    mkdir $TD
    fi
Crear


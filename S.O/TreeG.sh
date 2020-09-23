#!/bin/bash
Crear () {
    printf "%s\n" "Desea crear un archivo o subdirectorio?" "1)Archivo" "2)Subdirectorio" "Otro)Salir"
    read OP
    Eleccion=""
    if [ $OP = "1" ]; then
        Eleccion="archivo"
    elif [ $OP = "2" ]; then
        Eleccion="subdirectorio"
    else
    	exit
    fi
    clear
    RecD $TD
}
Nombre(){
    printf "%s\n" "Indique un nombre para el $Eleccion"
    read Nombre
    if [ $OP = "1" ]; then
        touch "$DirTemp/$Nombre"
    elif [ $OP = "2" ]; then
        mkdir "$DirTemp/$Nombre"
    else
    	Error "Nombre"
    fi
    clear
    printf "%s\n" "$Eleccion creado exitosamente en $DirTemp"
    tree $TD
    Crear
}
#Recorre el directorio
RecD () {
    printf "%s\n" "Donde desea crearlo?"
    tree $TD
    read nombre
    if [ nombre = "" ]; then
    	exit
    fi
    Direcciones=($(find $TD -type d -name "$nombre"))
    Result=${#Direcciones[@]}
    if [ $Result -eq 1 ] && [ "${Direcciones[0]}" != "" ]; then
        DirTemp=${Direcciones[0]}
        printf "%s\n" "Encontrado: $DirTemp"
        Nombre
    elif [ $Result -gt 1 ]; then
        printf "%s\n" "A cual directorio se refiere?"
        Num=0
        iter=`expr $Result - 1`
        for i in `seq 0 $iter`; do
            printf "$Num)%s\n" "${Direcciones[$i]}"
            Num=`expr $Num + 1`
        done
        read Num
        eleccion=${Direcciones[$Num]}
        echo $eleccion
        if [ -d "$eleccion" ]; then
            DirTemp=$eleccion
            Nombre
        else
            Error "RecD"
        fi
    else
        Error "RecD"
    fi
}
Error(){
        printf "%s\n" "No se encontró" "Ingrese cualquier caracter para continuar o 0 para salir"
        read Salir
        if [ $Salir -eq 0 ]; then
            exit
        else
        	$1
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
TD="$HOME/"$TD
if [ -d "$TD" ] ; then
    printf "%s\n\n" "Directorio encontrado"
else
    printf "%s\n\n" "Directorio creado"
    mkdir $TD
fi
Crear

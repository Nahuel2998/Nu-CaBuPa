#!/bin/bash
Verificar(){
    Direcciones=($(find "$TD" -type d))
    Result=${#Direcciones[@]}
    if [ $Result -gt 1 ]; then
        ExisteDir="Si"
    else
        ExisteDir="No"
    fi
}
Crear () {
    printf "%s\n" "Desea crear un archivo o subdirectorio?" "1)Archivo" "2)Subdirectorio" "Otro)Salir"
    read OP
    Eleccion=""
    if [ $OP = "1" ]; then
        Eleccion="Archivo"
    elif [ $OP = "2" ]; then
        Eleccion="Subdirectorio"
    else
    	exit
    fi
    clear
    if [ $ExisteDir = "Si" ]; then
        RecD "$TD"
    else 
        DirTemp="$TD"
        Nombre
    fi
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
    printf "%s\n" "$Eleccion creado exitosamente en $TD"
    tree "$TD"
    Verificar
    Crear
}
#Recorre el directorio
RecD () {
    printf "%s\n" "Donde desea crearlo?" "(Ruta relativa o nombre. Ingrese un . para crearlo en el directorio $TD)"
    tree "$TD"
    read nombre
    if [ "$nombre" = "." ]; then
        DirTemp="$TD"
        Nombre
    	exit
    elif [[ "$nombre" =~ "/" ]]; then
        Buscar "wholename"
    else
        Buscar "name"
    fi
}
Buscar(){
    Direcciones=($(find "$TD" -type d -$1 "$nombre" | sed "s/ /'/g"))
    Result=${#Direcciones[@]}
    if [ $Result -eq 1 ] && [ "${Direcciones[0]}" != "''" ]; then
        DirTemp=$(echo ${Direcciones[$i]} | sed "s/'/ /g")
        printf "%s\n" "Encontrado: $DirTemp"
        Nombre
    elif [ $Result -gt 1 ]; then
        printf "%s\n" "A cual directorio se refiere?"
        Num=0
        iter=`expr $Result - 1`
        for i in `seq 0 $iter`; do
            printf "$Num) %s\n" "$(echo ${Direcciones[$i]} | sed "s/'/ /g")"
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
        if [ $Salir = "0" ]; then
            exit
        else
        	$1
        fi
}
TD=""
DirTemp=""
OP=""
ExisteDir=""
while [ "$TD" = "" ]
do
#Se pregunta cual es la dirección en la que se creará el arbol
printf "%s\n" "Bienvenid@ al generador de archivos/directorios"
printf "%s\n" "Indique el nombre del directorio a crear para el árbol" "(Si ya existe se utilizará ese)" "Ingrese un . para salir"
read TD
    if [ "$TD" = "." ]; then
        exit
    fi
done
#Verificamos que no sea camino absoluto y de que exista
TD=$(echo "$TD" | sed 's/^\///') 
TD="$HOME/$TD"
if [ -d "$TD" ] ; then
    printf "%s\n\n" "Directorio encontrado : $TD"
    Verificar
else
    printf "%s\n\n" "Directorio creado"
    mkdir "$TD"
    ExisteDir="No"
fi
echo "$TD" > "$HOME/Direccion.txt"
Crear

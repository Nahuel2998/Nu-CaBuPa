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
Letra1(){
    printf "%s\n" "Directorio: $DirTemp" 
    tree "$TD"
    printf "%s\n" "Indique el caracter a ser cambiado"
    read Letra
    Verificacion=$(echo $Letra | egrep "^[a-Z0-9]$")
    if [ Verificacion = "" ]; then
    	Error "Letra1"
    fi
    Letra2
}
Letra2(){
    printf "%s\n" "Indique el caracter por el cual reemplazar"
    read LetraN
    Verificacion=$(echo "$LetraN" | egrep "^[a-Z0-9]$")
    if [ Verificacion = "" ]; then
    	Error "Letra2"
    fi
    Cambiar
}
Cambiar(){
    Anterior=($(find "$DirTemp" -maxdepth 1 -type f | sed "s/^.*\///" | egrep "$Letra" | sed "s/ /'/g"))
    Nuevo=($(find "$DirTemp" -maxdepth 1 -type f | sed "s/^.*\///" | egrep "$Letra" | sed "s/'$Letra'/'$LetraN'/g" | sed "s/ /'/g"))
    Canti=${#Anterior[@]}
    if [ $Canti -eq 0 ]; then
        clear
        printf "%s\n" "Ningun nombre posee dicho caracter"
        Error "Letra1"
        exit
    fi
    can=`expr $Canti - 1`
    for i in `seq 0 $can`; do
        printf "%s %s %s\n" "'$(echo ${Anterior[$i]} | sed "s/'/ /g")'" "Pasará a ser:" "'$(echo ${Nuevo[$i]} | sed "s/'/ /g")'"
    done
    printf "%s\n" "Para aceptar inserte 'y'" "Para no renombrar 'n'" "Para salir inserte cualquier otro"
    read Salir
        if [ "$Salir" = "y" ]; then
            Renombrar
        elif [ "$Salir" = "n" ]; then
            clear
            Letra1
        else
        	exit
        fi
}
Renombrar(){
    Archivos=$(find "$DirTemp" -maxdepth 1 -type f | egrep "$Letra" | sed "s/ /'/g")
    for o in $Archivos
    do
        i=$(echo "$o" | sed "s/'/ /g")
    	OldName=$i
    	NewName="$DirTemp/$(echo "$i" | sed "s/^.*\///" | sed "s/'$Letra'/'$LetraN'/g")"
    	if [ "$OldName" != "$NewName" ]; then
    		mv "$OldName" "$NewName"
    	fi
    done
    printf "%s\n" "Resultado: "
    tree "$TD"
    printf "\n%s\n\n" "Si quiere seguir modificando inserte 'y', para salir inserte cualquier otro"
    read Salir
        if [ "$Salir" = "y" ]; then
            clear
            Letra1
        else
        	exit
        fi
}
RecD () {
    printf "%s\n" "En que carpeta desea cambiar los nombre?" "(Ruta relativa o nombre. Ingrese un . para usaar en el directorio $TD)"
    tree "$TD"
    read nombre
    if [ "$nombre" = "." ]; then
        DirTemp="$TD"
        Letra1
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
Inicio(){
TD=""
DirTemp=""
OP=""
while [ "$TD" = "" ]
do
    #Se pregunta cual es la dirección en la que se creará el arbol
    printf "%s\n" "Bienvenid@ al renombrador de archivos"
    if [ ! -f "$HOME/Direccion.txt" ]; then
        printf "%s\n" "Indique el nombre del arbol creado" "(O ruta relativa)" "Ingrese un . para salir"
        read TD
        if [ "$TD" = "." ]; then
            exit
        elif [ "$TD" <> "" ]; then
            #Verificamos que no sea camino absoluto y de que exista
            TD=$(echo "$TD" | sed 's/^\///') 
            TD="/home/$USER/$TD"
        fi
    else
        TD=$(cat "Direccion.txt")
    fi
done
if [ -d "$TD" ] ; then
    printf "%s\n\n" "Directorio encontrado : $TD"
    Verificar
else
    Error "Inicio"
fi
if [ $ExisteDir = "Si" ]; then
    RecD
else 
    DirTemp="$TD"
    Letra1
fi
}
ExisteDir=""
Inicio

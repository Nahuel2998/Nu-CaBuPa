#!/bin/bash
Crear () {
    printf "%s\n" "Desea crear un archivo o subdirectorio?" "1)Archivo" "2)Subdirectorio"
    read OP
    Direcciones="."
    #Cantidad de carpetas
    CA=0
    RecD $TD 0
}
#Recorre el directorio recursivamente
RecD () {
    #Nivel de recurrencia
    RL=$2
    Espacio="\t"
    for i in `seq 0 $RL`;do
            Espacio=$Espacio"\t"
        done
    printf "$Espacio%s\n" $(ls -p $1 |egrep -v "/")
    for i in $(ls -p $1 | egrep "/$" | sed 's/^\///'); do
            printf "$Espacio%s)%s\n" $CA "$i"
            Direcciones=$Direcciones":"$1"/"$i
            CA=`expr $CA + 1`
            Num=`expr $RL + 1`
            RecD "$1/$i" $Num
        done
}
TD=""
OP=""
#Se pregunta cual es la dirección en la que se creará el arbol
printf "%s\n" "Indique la dirección en la que se creará el arbol"
read TD
#Verificamos que no sea camino absoluto y de que exista
TD=$(echo $TD | sed 's/^\///') 
TD="/home/manuel/"$TD
if [ -d $TD ] ; then
echo holis
    else
    mkdir $TD
    fi
Crear


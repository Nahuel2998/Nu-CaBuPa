#!/bin/bash
TD=""
OP=""
#Se pregunta cual es la dirección en la que se creará el arbol
printf "%s\n" "Indique la dirección en la que se creará el arbol"
read TD
#Verificamos que no sea camino absoluto y de que exista
TD=$(echo $TD | sed "s/\///g") 
if ! (( -d $TD )) ; then
    mkdir $TD
    fi
done
Create
function Create {
    printf "%s\n" "Desea crear un archivo o subdirectorio?" "1)Archivo" "2)Subdirectorio"
    read OP
    RecD $TD 0
}
#Recorre el directorio recursivamente
function RecD(){
    #Nivel de recurrencia
    RL=$2
    
    Espacio="\t"
    for i in `seq 0 $RL`;do
            Espacio=$Espacio"\t"
        done
    for i in $(ls -p $1 | egrep "/$" | sed "s/\///"); do
            printf "$Espacio%s\n" $i
            printf "$Espacio%s\n" $(ls -p $1 |egrep -v "/")
            RecD $i `expr $RL + 1`
        done
}




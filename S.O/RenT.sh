Letra(){
    printf "%s\n" "Indique el caracter a ser cambiado"
    read Letra
    Verificacion=$(echo $Letra | egrep "^[a-Z0-9]$")
    if [ Verificacion = "" ]; then
    	Error "Letra"
    fi
    Letra2
}
Letra2(){
    printf "%s\n" "Indique el caracter por el cual reemplazar"
    read Letra2
    Verificacion=$(echo $Letra2 | egrep "^[a-Z0-9]$")
    if [ Verificacion = "" ]; then
    	Error "Letra2"
    fi
    Cambiar
}
Cambiar(){
    clear
    printf "%s" $(find $DirTemp -maxdepth 1 -type f | sed "s/^.*\///" | sed "s/.*/'&'/")
    printf "\n%s\n\n" "Pasará a ser:"
    printf "%s" $(find $DirTemp -maxdepth 1 -type f | sed "s/^.*\///" | sed "s/$Letra/$Letra2/g" | sed "s/.*/'&'/")
    printf "\n%s\n\n" "Para aceptar inserte 'y', para salir inserte cualquier otro"
    read Salir
        if [ "$Salir" = "y" ]; then
            Renombrar
        else
        	exit
        fi
}
Renombrar(){
    Archivos=$(find "$DirTemp" -maxdepth 1 -type f | sed "s/.*/'&'/")
    for i in $Archivos
    do
    	OldName=$(echo "$i" | sed "s/'//g")
    	NewName="$DirTemp/$(echo "$i" | sed "s/^.*\///" | sed "s/$Letra/$Letra2/g" | sed "s/'//")"
    	if [ $OldName != $NewName ]; then
    		mv $OldName $NewName
    	fi
    done
    tree "$TD"
    printf "\n%s\n\n" "Si quiere seguir modificando inserte 'y', para salir inserte cualquier otro"
    read Salir
        if [ "$Salir" = "y" ]; then
            Letra
        else
        	exit
        fi
}
RecD () {
    printf "%s\n" "Donde desea modificar?"
    tree "$TD"
    read nombre
    if [ nombre = "" ]; then
    	Direcciones=($(find "$TD" -type d))
    else 
        Direcciones=($(find "$TD" -type d -name "$nombre"))
    fi
    Result=${#Direcciones[@]}
    if [ $Result -eq 1 ] && [ "${Direcciones[0]}" != "" ]; then
        clear
        DirTemp=${Direcciones[0]}
        printf "%s\n" "Encontrado: $DirTemp"
        Letra
    elif [ $Result -gt 1 ]; then
        clear
        printf "%s\n\n" "A cual directorio se refiere?"
        Num=0
        iter=`expr $Result - 1`
        for i in `seq 0 $iter`; do
            printf "$Num)%s\n" "${Direcciones[$i]}"
            Num=`expr $Num + 1`
        done
        read Nume
        eleccion=${Direcciones[$Nume]}
        echo $eleccion
        if [ -d "$eleccion" ]; then
            DirTemp=$eleccion
            Letra
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
Inicio(){
TD=""
DirTemp=""
OP=""
#Se pregunta cual es la dirección en la que se creará el arbol
printf "%s\n" "Indique la dirección en la que se modificará el arbol"
read TD
#Verificamos que no sea camino absoluto y de que exista
TD=$(echo $TD | sed 's/^\///') 
TD="/home/$USER/$TD"
if [ -d "$TD" ] ; then
    printf "%s\n\n" "Directorio encontrado"
else
    Error "Inicio"
fi
RecD
}
Inicio

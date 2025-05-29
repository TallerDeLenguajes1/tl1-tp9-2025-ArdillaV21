using System;


string? path;
do{
    Console.Write("Ingrese el path de el directorio que desea analizar: \n");
    path=Console.ReadLine();
    if(!Directory.Exists(path)){
        Console.Write("La ruta ingresada no es correcta. Porfavor, ingresa una nuevamente.");
    }
}while(!Directory.Exists(path));

Console.WriteLine("Carpetas: \n");

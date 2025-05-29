

string? path;
do{
    Console.Write("Ingrese el path de el directorio que desea analizar: \n");
    path=Console.ReadLine();
    if(!Directory.Exists(path)){
        Console.Write("La ruta ingresada no es correcta. Porfavor, ingresa una nuevamente.");
    }
}while(!Directory.Exists(path));

Console.WriteLine("Carpetas: \n");
string[] carpetas = Directory.GetDirectories(path);

Console.WriteLine("Archivos: \n");
string[] archivos = Directory.GetFiles(path);

foreach (var ar in archivos)
{
    FileInfo info = new FileInfo(ar);
    long tamaño = info.Length; //Bytes
    Console.WriteLine(Path.GetFileName(ar)+" tamaño: " + tamaño);
}

string ruta = "Archivos/reporte_archivos.csv";
FileStream fs = new FileStream(ruta,FileMode.Create);
using (StreamWriter str = new StreamWriter(fs)){
    str.WriteLine("Nombre,Tamaño");
    foreach (var ar in archivos)
    {
        string nombre = Path.GetFileName(ar);
        FileInfo info = new FileInfo(ar);
        long tamano = info.Length; //Bytes
        str.WriteLine($"{nombre},{tamano}");
    }
    foreach (var car in carpetas)
    {
        string nombre = Path.GetFileName(car);
        str.WriteLine("{0}",nombre);
    }
    str.Close();
}


using System;
using System.IO;
using WritterKatarinaLoL.Model;

namespace WritterKatarinaLoL
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\Nobody\Desktop\PruebasVisual";
            string destiny = @"C:\Users\Nobody\Desktop\PruebasVisual\CarpetaInterna";

            File.Create(@"C:\Users\Nobody\Desktop\PruebasVisual\javi.txt");

            string[] fileList = Directory.GetFiles(source);
            
            foreach (string archivo in fileList)
            {
                var pathArchivo = archivo.Split("\\"); //guarda el path del archivo
                var nombre = pathArchivo[pathArchivo.Length - 1];

                Format_Json jsonito = new Format_Json();

                //crear nuevo, copiar al nuevo, borrar viejo
                var nombreSinExt = Path.GetFileNameWithoutExtension(nombre);

                File.Copy($"{source}", $"{destiny}\\{nombreSinExt}.{jsonito.GetExtension()}");
            }

            Console.WriteLine("¿Quieres escribir en la nube o en un archivo en local? Escribe 'Local' o 'Nube'");
            string respuestaUser = Console.ReadLine();

            //Iniciar un objeto contenedor el cual recibirá un objecto de Factory (GetWritter) y otro de Writter (Writte)
            var container = new Container();
            
            switch (respuestaUser)
            {
                case "Local":
                    Console.WriteLine($"Has elegido escribir en un archivo en local.");
                    container.Build(respuestaUser).GetWritter("txt").Write("NombreArchivoEnLocal");
                    break;

                case "Nube":
                    Console.WriteLine($"Has elegido escribir en la nube.");
                    container.Build(respuestaUser).GetWritter("json").Write("NombreArchivoEnLaNube");
                    break;

                default:
                    Console.WriteLine($"Has escrito mal la respuesta.");
                    break;
            }

            Console.ReadLine();
        }
    }
}

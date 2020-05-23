using System;
using static System.Console;
using System.IO;

namespace Consola
{
    class Program
    {
        static void Main()
        {
            // Conseguir nombre del archivo
            Write("Archivo: ");
            var archivo = ReadLine();   // archivo.txt
            // Si no existe archivo
            if(!File.Exists(archivo))
            {
                // terminar
                WriteLine("Archivo no existe!");
                return;
            }              
            // Abrir el archivo
            // Leer todo el archivo en colección de lineas
            var lineas = File.ReadAllLines(archivo);
            // inicializar contadores de lineas y palabras en cero
            var nroLineas = 0; var nroPalabras = 0;
            // tomar primera linea
            var lin = 0;
            // Mientras haya lineas en la colección
            while(lin < lineas.Length)
            {
                // 	agregar 1 al contador de líneas
                nroLineas += 1;
                //	buscar nro de palabras de la línea
                var palabras = lineas[lin].Split(' ','.',',', ';',':');
                // 	agregar nro de palabras al contador de palabras
                foreach (var palabra in palabras)
                {
                    if(palabra.Contains(' ') || palabra.Contains('.') 
                        || palabra.Contains(',') || palabra.Contains(';')
                        || palabra.Contains(':'))
                            continue;
                    nroPalabras += 1;                        
                }
                //	tomar la siguiente linea
                lin++;
            }
            // Desplegar nro de lineas y nro de palabras encontrados
            WriteLine($"Nro de líneas: {nroLineas}");
            WriteLine($"Nro de palabras: {nroPalabras}");
            // Cerrar el archivo
            // Terminar
            return;   
        }

        private static void CreaArchivo()
        {
            var texto = @"archivo.txt
Unhandled exception. System.IO.FileNotFoundException: Could not find file '/Volumes/easystore/Dropbox/Cursos/CursoCSharp8/Consola/archivo.txt'.
File name: '/Volumes/easystore/Dropbox/Cursos/CursoCSharp8/Consola/archivo.txt'
   at Interop.ThrowExceptionForIoErrno(ErrorInfo errorInfo, String path, Boolean isDirectory, Func`2 errorRewriter)
   at Microsoft.Win32.SafeHandles.SafeFileHandle.Open(String path, OpenFlags flags, Int32 mode)
   at System.IO.FileStream.OpenHandle(FileMode mode, FileShare share, FileOptions options)
   at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess access, FileShare share, Int32 bufferSize, FileOptions options)
   at System.IO.StreamReader.ValidateArgsAndOpenPath(String path, Encoding encoding, Int32 bufferSize)
   at System.IO.StreamReader..ctor(String path, Encoding encoding)
   at System.IO.File.InternalReadAllLines(String path, Encoding encoding)
   at System.IO.File.ReadAllLines(String path)
   at Consola.Program.Main() in /Volumes/easystore/Dropbox/Cursos/CursoCSharp8/Consola/Program.cs:line 22";
            File.WriteAllText("archivo.txt", texto);
        }
    }
}

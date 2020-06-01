#region Header
using System;
using static System.IO.File;
using static System.Console; using static System.Math; namespace CursoCSharp { 
class Global { 
#endregion    

static void Main(string[] args) => Iniciar(args);
static void Iniciar(string[] args) 
{
      var archivo = args[0]; 
      EscribirArchivo(archivo);
      var texto = ReadAllText(archivo);
      WriteLine(texto);
}
static void EscribirArchivo(string archivo) =>
       WriteAllText(archivo, 
       @"Maria 57
Pedro 63
Juan 79
Elena 88
Pablo 45
Hugo 24
Paola 93"); // verbose string

#region Footer
}}
#endregion
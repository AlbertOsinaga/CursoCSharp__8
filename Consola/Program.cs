using System;
using static System.Console;
using System.IO;

namespace Consola
{
    class Program
    {
        static void Main()
        {
            try
            {
                uint num = uint.MaxValue;
                WriteLine(num++);
                WriteLine(num);
            }
            catch (NullReferenceException)
            {
                WriteLine("Error: uso de objeto no inicializado! ");
            }
            catch (DivideByZeroException)
            {
                WriteLine("Error de division por cero! ");
            }
            catch (Exception ex)
            {
                WriteLine($"Error: tipo - {ex.GetType().Name} " +
                        $" ; mensaje - {ex.Message} ");
            }
            // catch {
            // WriteLine("Un error inesperado sucedió!");   }
        }



    }
}

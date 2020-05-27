#region Header
using System; using static System.Console; using static System.Math; namespace CursoCSharp { 
class Global { 
#endregion    

static void Main() => Iniciar();
static void Iniciar() 
{
      WriteLine("9 al cuadrado = " + Pow(9, 2));   // 81 
      WriteLine("raiz cuadrada de 64 = " + Sqrt(64));   // 8
      var seno = Sin(45.37);   
      var max = Max(Floor(seno), Round(seno));  
      WriteLine("Seno de 45.37 = " + seno);     // 0.9832851623027296
      WriteLine("Mayor entre Floor y Round = " + max);  // 1
      WriteLine("Valor absoluto de (56-94) = " + Abs(56 - 94));   // 38 
}

#region Footer
}}
#endregion
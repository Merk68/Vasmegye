using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vasmegye
{
  class Program
  {
    static List<szamok> lista = new List<szamok>();
    static void Main(string[] args)
    {
      Beolvasas();
      HarmadikFeladat();
      Console.WriteLine($"{lista.Count}");
      Console.ReadLine();
    }

    private static void HarmadikFeladat()
    {
      
    }

    private static void Beolvasas()
    {
      StreamReader be = new StreamReader("vas.txt");
      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split('-');
        lista.Add(new szamok(Convert.ToInt32(a[0]),Convert.ToInt32(a[1]), Convert.ToInt32(a[2])));
      }
      be.Close();
    }
  }
}

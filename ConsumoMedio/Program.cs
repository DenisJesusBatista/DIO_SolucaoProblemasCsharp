using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoMedio
{
    public class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double combustivelGasto, consumoMedio;

            Console.WriteLine("Informa a distância peccorrida.");
            distancia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informa o combustivél gasto.");
            combustivelGasto = Convert.ToDouble(Console.ReadLine());

            consumoMedio = distancia / combustivelGasto;//Formula para que o codigo funcione corretamente
            Console.WriteLine(" km/l {0:0.000}", consumoMedio);
            Console.ReadLine();
        }
    }
}

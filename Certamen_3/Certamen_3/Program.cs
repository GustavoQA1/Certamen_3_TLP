using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certamen_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("data.txt");
            string line = sr.ReadLine();
            List<data> datos = new List<data>();
            data[] arrayData = new data[200];
            Console.WriteLine("APERTURA | MAXIMO | MINIMO | CIERRE");

            int contador = 0;
            while (line != null)
            {
                var dataLinea = line.Split(';');
               
                arrayData[contador] = new data();
                arrayData[contador].APERTURA = double.Parse(dataLinea[0]);
                arrayData[contador].MAXIMO = double.Parse(dataLinea[1]);
                arrayData[contador].MINIMO = double.Parse(dataLinea[2]);
                arrayData[contador].CIERRE = double.Parse(dataLinea[3]);

             
                line = sr.ReadLine();
                contador++;
            }
            Console.WriteLine();
            for (int i = 0; i < 200; i++)
            {
                
                Console.WriteLine(arrayData[i].APERTURA + " | " + arrayData[i].MAXIMO + " | " + arrayData[i].MINIMO + " | " + arrayData[i].CIERRE);
            }
            Console.WriteLine();
            Console.WriteLine(" Los Valores Maximos son: " + arrayData.Max());
            Console.WriteLine(" Los Valores Minimos son: " + arrayData.Min());




            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double km, gas, consumo;

            Console.WriteLine("Quantos Km você rodou?");
            km = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos litros você gastou?");
            gas = double.Parse(Console.ReadLine());

            consumo = km / gas;

            Console.WriteLine("Esse é o consumo médio do seu carro: " + consumo + " km/l");
        }
    }



















}








    

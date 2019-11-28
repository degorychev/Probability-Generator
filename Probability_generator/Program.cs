using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probability_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Probability_generator gen = new Probability_generator();
            gen.AddVariant("10%", 10); //1-10
            gen.AddVariant("80%", 80); //11-90
            gen.AddVariant("3%", 3); //91-93
            gen.AddVariant("3%", 3); //94-96
            gen.AddVariant("4%", 4);//Итоговая вероятность = 100%

            while(true)
            {
                Console.WriteLine(gen.Next()); //В 80% случаях будет выпадать строка "80%"
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}

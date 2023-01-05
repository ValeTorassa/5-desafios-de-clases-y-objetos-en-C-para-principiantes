using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Piracy
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos nuestra clase Ship(barco) para crear el titanic y el perla negra
            Ship titanic = new Ship(20, 10);
            Ship perlaNegra = new Ship(50, 7);

            //evaluamos si robar el titanic vale la pena
            Console.WriteLine(titanic.valeLaPena());
            //evaluamos si robar el perla negra vale la pena
            Console.WriteLine(perlaNegra.valeLaPena());

            Console.ReadKey();

        }
    }
}

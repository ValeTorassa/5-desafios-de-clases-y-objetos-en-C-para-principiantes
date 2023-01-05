using System;
using System.Collections.Generic;

namespace Tanque_WWII
{
    class Program
    {
        static void Main(string[] args)
        {
            Tanque t34 = new Tanque("T-34", "Union Sovietica", 1940, 26, new List<string> { "Estados Unidos", "Reino Unido" });
            Tanque panzerIV = new Tanque("Panzer IV", "Alemania", 1939, 23, new List<string> { "Italia", "Japon" });
            Tanque m4 = new Tanque("M4 Sherman", "Estados Unidos", 1942, 20, new List<string> { "Union Sovietica", "Reino Unido" });

            //metodo informacion
            panzerIV.informacion();

            //metodo sonAliados
            panzerIV.sonAliados(t34);
            m4.sonAliados(t34);

            //metodo batalla
            t34.Batalla(panzerIV);
            m4.Batalla(t34);

            Console.ReadKey();
        }
    }
}

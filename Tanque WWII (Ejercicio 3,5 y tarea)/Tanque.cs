using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanque_WWII
{
    class Tanque
    {
        public string Nombre;
        public string Pais;
        public int Año;
        public int Peso;
        public List<string> Aliados;

        public Tanque(string nombre, string pais, int año, int peso, List<string> aliados)
        {
            Nombre = nombre;
            Pais = pais;
            Año = año;
            Peso = peso;
            Aliados = aliados;
        }

        public void informacion()
        {
            Console.WriteLine($"El tanque {Nombre} de {Pais} fue ensamblado en {Año} y tiene un peso de {Peso} toneladas");
        }

        public bool sonAliados(Tanque tank)
        {

            if(Aliados.Contains(tank.Pais))
            {
                Console.WriteLine($"{Pais} y {tank.Pais} son aliados!");
                return true;
            }
            else
            {
                Console.WriteLine($"{Pais} y {tank.Pais} son enemigos");
                return false;
            }

        }

        public void Batalla(Tanque enemigo)
        {
            Console.WriteLine($"{Nombre} de {Pais} está batallando contra {enemigo.Nombre} de {enemigo.Pais}");

            if (Aliados.Contains(enemigo.Pais))
            {
                Console.WriteLine($"{Pais} y {enemigo.Pais} son aliados y no pueden pelear entre ellos!");
            }
            else if (Año < enemigo.Año)
            {
                Console.WriteLine($"{enemigo.Nombre} gana porque es más nuevo!");
            }
            else if (Año > enemigo.Año)
            {
                Console.WriteLine($"{Nombre} gana porque es más nuevo!");
            }
            else
            {
                if (Peso > enemigo.Peso)
                {
                    Console.WriteLine($"{Nombre} gana porque es más ligero");
                }
                else if (Peso < enemigo.Peso)
                {
                    Console.WriteLine($"{enemigo.Nombre} gana porque es más ligero");
                }
                else
                {
                    Console.WriteLine("¡Es un empate!");
                }
            }
        }

    }
}

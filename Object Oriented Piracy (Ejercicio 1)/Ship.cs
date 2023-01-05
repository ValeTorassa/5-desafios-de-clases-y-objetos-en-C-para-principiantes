using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Piracy
{
    public class Ship
    {
        //nuestra clase barco tendra dos atributos, cargamento y tripulacion
        public int Cargamento;
        public int Tripulacion;

        //el metodo constructor de ship seria el siguiente:
        public Ship(int cargamento, int tripulacion)
        {
            Tripulacion = tripulacion;
            Cargamento = cargamento;
        }

        //la tarea del programador es crear el metodo valeLaPena() el cual evaluara en base a multiplicar los miembros
        //de la tripulacion por 2(su peso) y restandolo del cargamento para ver si da mas que 20
        //si el peso de la tripulacion (2 por tripulante) restado por el cargamento da mas de 20 la funcionan debe retornar true
        //Ya que si valdria la pena robar el barco, sino debe devolver false
        public bool valeLaPena()
        {

            //AQUI VA TU CODIGO


            int pesoBotin = Cargamento - Tripulacion * 2;

            if (pesoBotin > 20)
            {
                return true;
            } 
            else
            {
                return false;
            }

        }

    }
}

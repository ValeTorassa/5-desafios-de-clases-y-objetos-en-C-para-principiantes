using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_blocks
{
    class Block
    {
        //creo los atributos como privados para que no puedan ser manipulados externamente (encapsulamiento)
        private int _ancho;
        private int _largo;
        private int _alto;

        public Block(int ancho, int largo, int alto)
        {
            //asigno los parametros a mis propiedades publicas (establecidas en base a los atributos)
            Ancho = ancho;
            Largo = largo;
            Alto = alto;
        }

        //tomo esos atributos privados y los leo(get) y escribo(Set) como propiedades publicas
        public int Ancho { get => _ancho; set => _ancho = value; }
        public int Largo { get => _largo; set => _largo = value; }
        public int Alto { get => _alto; set => _alto = value; }

        public int devolverAncho()
        {
            //devuelvo la propiedad publica ancho
            return Ancho;
        }

        public int devolverLargo()
        {
            //devuelvo la propiedad publica largo
            return Largo;
        }

        public int devolverAlto()
        {
            //devuelvo la propiedad publica alto
            return Alto;
        }

        public int devolverVolumen()
        {
            //uso la formula de volumen para calcularlo en base a mis propiedades
            int volumen = Largo * Alto * Ancho;
            //lo retorno
            return volumen;
        }

        public int devolverAreaSuperficie() 
        {
            //uso la formula de superficie del area para calcularlo en base a mis propiedades
            int areaSuperficie = 2 * Largo * Ancho + 2 * Largo * Alto + 2 * Ancho * Alto;
            //lo retorno
            return areaSuperficie;
        }

    }
}

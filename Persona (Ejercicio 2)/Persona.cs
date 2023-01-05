using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Clases_y_Objetos_2
{
    public class Persona
    {
        //creo los atributos de nombre, edad y genero
        public string Nombre;
        public int Edad;
        public string Genero;

        public Persona(string nombre, int edad, string genero)
        {
            //asigno los parametros que le paso al constructor a los atributos de la clase
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
        }

        public void Hablar()
        {
            //hago que la consola imprima el atributo nombre del objeto seguido de las palabras esta hablando
            Console.WriteLine($"{Nombre}, un {Genero} de {Edad} años está hablando.");
        }
    }
}
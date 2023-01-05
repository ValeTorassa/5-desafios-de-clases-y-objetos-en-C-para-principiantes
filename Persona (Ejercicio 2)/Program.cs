using System;

namespace Ejemplo_Clases_y_Objetos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creo un objeto de la clase persona llamada persona1 y paso los parametros al constructor
            Persona persona1 = new Persona("Juan", 30, "Hombre");
            //creo otro objeto de la clase persona llamada persona2 y paso los parametros al constructor
            Persona persona2 = new Persona("María", 25, "Mujer");

            persona1.Hablar(); //invoco el metodo caminar para la persona1

            Console.ReadKey();
        }
    }
}

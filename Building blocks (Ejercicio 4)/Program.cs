using System;

namespace Building_blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio la clase Block para crear un objeto llamado bloque
            Block bloque = new Block(2, 4, 6);
            
            Console.WriteLine(bloque.devolverAlto());//Imprimo el alto, invocando al metodo que me lo retorna
            Console.WriteLine(bloque.devolverAncho());//Imprimo el ancho
            Console.WriteLine(bloque.devolverLargo());//Imprimo el largo
            Console.WriteLine(bloque.devolverVolumen());//Imprimo el volumen
            Console.WriteLine(bloque.devolverAreaSuperficie());//Imprimo el area de la superficie de todo bloque

            Console.ReadKey();
        }
    }
}

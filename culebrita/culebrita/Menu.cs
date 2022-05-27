using System;
using System.Collections.Generic;
using System.Text;


namespace culebrita
{
    internal class Menu
    {
         static void Main()
        { 
            ProgramColaCircular circular= new ProgramColaCircular();
            ProgramColaLinealArreglo linealArreglo = new ProgramColaLinealArreglo();
            ProgramColaListaEnlazada listaEnlazada = new ProgramColaListaEnlazada();
            ProgramColaArrayList arraylilst = new ProgramColaArrayList();
            do {
                Console.WriteLine("\tProyecto Programacion 3" +
                    "\n\t***  CULEBRITA   ***" +
                    "\n" +
                    "\n Digita la opcion que deseas ejecutar..." +
                    "\n 1. Cola ArrayList" +
                    "\n 2. Cola Circular" +
                    "\n 3. Cola Lineal Arreglo" +
                    "\n 4. Cola Lista Enlazada");
                int x = Convert.ToInt32(Console.ReadLine());
               
                switch (x)
                {
                    case 1:
                        arraylilst.MainColaArraylist();
                        break;
                    case 2:
                        circular.MainColaCircular();
                        break;
                    case 3:
                        linealArreglo.MainColaLineaArreglo();
                        break;
                    case 4:
                        listaEnlazada.MainListaEnlazada();
                        break;

                }



            } while (false);

           
        }
        
    }
}

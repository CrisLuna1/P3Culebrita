using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaColaLinealArreglo
{
    internal class ColaLinealArreglo
    {
        protected int fin;
        private static int MAXTAMQ = 900000000;
        protected int frente;

        public int numelement;

        public int numeleme()
        {
            return numelement;
        }

        protected Object[] listaCola;//Lista de elementos de la cola

        public ColaLinealArreglo()//Constructor de la cola circular
        {
            frente = 0;
            fin = -1;
            listaCola = new Object[MAXTAMQ];
        }


        public void insertar(Object elemento)//Metodo para insertar un elemento en la cola
        {
            if (!colaLlena())
            {
                numelement++;
                listaCola[++fin] = elemento;//Agrega el dato a la cola
            }
            else
            {
                throw new Exception("Overflow en la cola");
            }
        
        }//Fin del metodo insertar

        public Object quitar() //Metodo para quitar un elemento de la cola
        {
            if (!colaVacia()){

                numelement--;
                Object aux = listaCola[frente++];//Quita el dato de la cola
                return aux;
            } 
            else {
            throw new Exception("Cola vacia");
            }
        }//Fin del metodo quitar

        public Object finalCola()//Metodo para obtener el ultimo elemento de la cola
        {
            if (!colaVacia())
            {
                return listaCola[fin];//Retorna el ultimo elemento de la cola
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
        }//Fin del metodo finalCola


        public bool colaVacia()
        {
            return frente > fin;//Retorna true si la cola esta vacia
        }

        public bool colaLlena()
        {
            return fin == MAXTAMQ - 1;//Retorna true si la cola esta llena
        }

    }
}

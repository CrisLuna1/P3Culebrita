using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaColaCiruclar
{
    internal class ColaCircular
    {
        private static int fin;
        private static int MAXTAMQ = 900000000; //Tamaño maximo de la cola
        protected int frente;

        public int num;

        public int numeleme()//Metodo para obtener el numero de elementos de la cola
        {
            return num; 
        }



        protected Object[] listaCola;//Lista de elementos de la cola 

        private int siguiente(int r)//MEotod para obtener el siguiente elemento de la cola
        {
            return (r + 1) % MAXTAMQ;
        }

        public ColaCircular()//Constructor de la cola circular
        {
            frente = 0;
            fin = MAXTAMQ - 1;
            listaCola = new Object[MAXTAMQ];
        }

        public void insertar(Object elemento) //Metodo para insertar un elemento en la cola
        {
            if (!colaLlena())
            {
                num++;
                fin = siguiente(fin);//Obtiene el siguiente elemento de la cola
                listaCola[fin] = elemento;//Agrega el dato a la cola
            }
            else
            {
                throw new Exception("Overflow en la cola");
            }
        }//Fin del metodo insertar

        public Object quitar()//Metodo para quitar un elemento de la cola
        {
            if (!colaVacia())
            {
                num--;
                Object tm = listaCola[frente];//Obtiene el primer elemento de la cola
                frente = siguiente(frente);//Quita el primer elemento de la cola
                return tm;
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
        }//Fin del metodo quitar

        public Object finalCola()//Metodo para obtener el ultimo elemento de la cola
        {
            if (!colaVacia())
            {
                return listaCola[fin];//Obtiene el ultimo elemento de la cola
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
        }//Fin del metodo finalcola

        public bool colaVacia()
        {
            return frente == siguiente(fin);//Si la cola esta vacia
        }


        public bool colaLlena()
        {
            return frente == siguiente(siguiente(fin));//Si la cola esta llena
        }





    }

}

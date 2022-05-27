using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LogicaColaArrayList
{
    internal class ColaArrayList
    {
        ArrayList ListaArray = new ArrayList();
        int Tamanno;
        public int TamCola() //Metodo para obtener el tamaño de la cola
        {
            return Tamanno;
        }


        public ColaArrayList() //Constructor 
        {
             this.ListaArray = new ArrayList();
        }//Fin del constructor

        public int numelement;

        public int numeleme()//Metodo para obtener el numero de elementos de la cola
        {
            return numelement;
        }//Fin del metodo numelement

        public Object finalcola()//Metodo para obtener el ultimo elemento de la cola
        {

            return ListaArray[ListaArray.Count - 1];
        }//Fin del metodo finalcola

        public void Insertar(object dato)//Metodo para insertar un elemento en la cola
        {
            if (!colaLlena())
            {
                numelement++;
                ListaArray.Add(dato);//Agrega el dato a la cola
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
            Tamanno++;

        }//Fin del metodo Insertar

        public object quitar()//Metodo para quitar un elemento de la cola
        {
            if (!colaVacia())//Si la cola no esta vacia
            {
                object dato = ListaArray[0];//Obtiene el primer elemento de la cola
                ListaArray.RemoveAt(0);//Quita el primer elemento de la cola
                numelement--;
                Tamanno--;
                return dato;
            }
            else
            {
                throw new Exception("Cola vacia ");
            }
        }//Fin del metodo quitar

         
        
        public bool colaVacia()//Metodo para saber si la cola esta vacia
        {
            if (ListaArray.Count == 1000000000)//Si la cola esta llena
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool colaLlena()//Metodo para saber si la cola esta llena
        {
            if (ListaArray.Count == 1000000000)//Si la cola esta llena 
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

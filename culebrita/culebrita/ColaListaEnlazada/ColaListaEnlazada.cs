using System;
using System.Collections.Generic;
using System.Text;

namespace LogicaColaListaEnlazada
{
    internal class ColaListaEnlazada
    {
        public Nodo primer;
        public Nodo final;
        int tamanno;

        public int num;

        public int numeleme()
        {
            return num;
        }

        public ColaListaEnlazada()//Constructor de la cola circular
        {
            primer = null;
            final = null;
        }

        
        public bool ColaVacia()//Metodo para saber si la cola esta vacia
        {
            return primer == null;
        }

        public Object finalCola()//Metodo para obtener el ultimo elemento de la cola
        {
            if (!ColaVacia())
            {
                return (final.Dato);//Retorna el dato del ultimo nodo
                
            }
            throw new Exception("Cola Vacia");
        }//Fin del metodo finalCola

        public void insertarValor(Object elemento)//Metodo para insertar un elemento en la cola
        {
            num++;
            Nodo nuevo =  new Nodo(elemento);//Crea un nuevo nodo con el dato ingresado
            if (!ColaVacia())//Si la col no esta vacia
            {
                final.Siguiente = nuevo;//El ultimo nodo apunta al nuevo nodo
            }
            else
            {
                primer = nuevo;//Si la cola esta vacia el primero apunta al nuevo nodo
            }
            final = nuevo;//El ultimo nodo apunta al nuevo nodo
            tamanno++;
        }//Fin del metodo insertarValor


        public Object quitarValor()//Metodo para quitar un elemento de la cola
        {
            num--;
            Object auxiliar;//Variable auxiliar para guardar el dato del nodo a quitar
            if (!ColaVacia())
            {
                auxiliar = primer.Dato;//Guarda el dato del primer nodo
                primer = primer.Siguiente;//El primer nodo apunta al segundo nodo
                tamanno--;
            }
            else
            {
                throw new Exception("Cola Vacia");
            }

            return auxiliar;
        }// Fin del metodo quitarValor
    }

}

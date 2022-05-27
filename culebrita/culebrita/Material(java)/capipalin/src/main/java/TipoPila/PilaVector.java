/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package TipoPila;

import java.util.ArrayList;

/**
 *
 * @author Ruldin
 */
public class PilaVector {
   private int cima;
    private ArrayList listaPila;
    
    public PilaVector()
    {
        cima = -1;
        listaPila = new ArrayList();
    }
    
    public void insertar(Object elemento)throws Exception
    {
        cima++;
        listaPila.add(elemento);
    }
    
    public Object quitar() throws Exception
    {
        Object aux;
        if (pilaVacia())
        {
            throw new Exception ("Pila vacía, no se puede extraer.");
        }
        aux = listaPila.get(cima);
        listaPila.remove(cima);
        cima--;
        return aux;
    }
    
    
    public Object cimaPila() throws Exception
    {
        if (pilaVacia())
        {
            throw new Exception ("Pila vacía, no se puede extraer.");
        }
        return listaPila.get(cima);
    }
    
    
    public boolean pilaVacia()
    {
        return cima == -1;
    }
    
    
    public void limpiarPila()throws Exception
    {
        while (! pilaVacia())
            quitar();
    } 
}

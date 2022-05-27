/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.cola.circular;

/**
 *
 * @author Ruldin
 */
public class ColaCircular {
     protected int fin;
    private static int MAXTAMQ=40;
    protected int frente;
    
    protected Object[] listaCola;
    
    private int siguiente(int r){
        return (r+1) % MAXTAMQ;
    }
    
    
    public ColaCircular(){
        frente = 0;
        fin = MAXTAMQ-1;
        listaCola = new Object[MAXTAMQ];
    }
    
    
    /// paste
    // OPERACIONES DE MODIFICACIN DE LA COLA
    
    public void insertar(Object elemento) throws Exception{
        if (!colaLlena()){
            fin = siguiente(fin);
            listaCola[fin] = elemento;
        } else {
            throw new Exception("Overflow en la cola");
        }
        
    }
    
    
    public Object quitar() throws Exception {
        if (!colaVacia()){
            Object aux = listaCola[frente];
            frente = siguiente(frente);
            return aux;
        } else {
            throw new Exception("Cola vacia");
        }
    }
    
//cola vacia
public void borrarCola(){
    frente = 0;
    fin = MAXTAMQ-1;
}    
    
//acceso a la cola
public Object frenteCola() throws Exception{
    if (!colaVacia()){
        return listaCola[frente];
    } else {
        throw new Exception("Cola vacio");
    }
}
    

//metodos de verificacion de cola
public boolean colaVacia(){
    return frente == siguiente(fin);
}

public boolean colaLlena(){
    return fin == siguiente(siguiente(fin));
}

    
}

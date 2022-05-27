/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.ruldin.p3c13colas;

import com.cola.arreglo.ColaLineal;
import com.cola.circular.ColaCircular;

/**
 *
 * @author Ruldin
 */
public class Principal {
    public static void main(String[] args) {
        ColaCircular co = new ColaCircular();
        
        try {
            co.insertar(1);
            co.insertar(2);
            co.insertar(3);
            co.insertar(4);
            co.insertar("hola");
            
           
            
            while(!co.colaVacia()){
                System.out.println("Desencolando:"+co.quitar());
            }
            
            int x=0;
            x=2;
            
        } catch (Exception ex){
            System.out.println("Ups hay error:"+ex.getMessage());
        }
        
    }
}

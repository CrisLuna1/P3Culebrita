/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.ruldin.capipalin;

import TipoCola.ColaCircular;
import TipoPila.PilaVector;
import java.io.BufferedReader;
import java.io.InputStreamReader;

/**
 *
 * @author Ruldin
 */
public class CapiPalin {
    
    static void viejaEscuela(){
        boolean capicua;
        BufferedReader entrada = new BufferedReader(
                new InputStreamReader(System.in));
        String numero;
        PilaVector pila = new PilaVector();
        ColaCircular q = new ColaCircular();
        try {
            capicua = false;
            while (!capicua) {
                do {
                    System.out.print("\nTeclea el número: ");
                    numero = entrada.readLine();
                    
                } while (!valido(numero)); 
                
                
// pone en la cola y en la pila cada dígito
                for (int i = 0; i < numero.length(); i++) {
                    Character c;
                    c = new Character(numero.charAt(i));
                    q.insertar(c);
                    pila.insertar(c);
                }
// se retira de la cola y la pila para comparar
                do {
                    Character d;
                    d = (Character) q.quitar();
                    capicua = d.equals(pila.quitar());//compara por igualdad
                } while (capicua && !q.colaVacia());
                
                
                
                
                
                
                if (capicua) {
                    System.out.println(numero + " es capicúa. ");
                } else {
                    System.out.print(numero + " no es capicúa, ");
                    System.out.println(" intente otro. ");
                }
// se vacía la cola y la pila
                q.borrarCola();
                pila.limpiarPila();
            }
        } catch (Exception er) {
            System.err.println("Error (excepcion) en el proceso: " + er);
        }
    }//end oldschool
    
    
    
     static void NuevaForma(){
        boolean capicua;
        BufferedReader entrada = new BufferedReader(
                new InputStreamReader(System.in));
        
        String numero;
        PilaVector pila = new PilaVector();
        ColaCircular q = new ColaCircular();
        boolean esNumero=false;
        try {
            capicua = false;
            while (!capicua) {
                do {
                    System.out.print("\nTeclea el número: ");
                    numero = entrada.readLine();
                  
                    //java 8 regex
                    esNumero = numero.chars().allMatch(Character::isDigit);
                    
                } while (!esNumero);//(!valido(numero)); 
// pone en la cola y en la pila cada dígito

                
                    numero.chars().forEach(c -> {
                    try{
                        q.insertar(c);
                        pila.insertar(c);
                    } catch(Exception x){
                        System.out.println("Error en interacion");
                    }
                    });    
                
// se retira de la cola y la pila para comparar
                do {
                    capicua = (q.quitar().equals(pila.quitar()));
                } while (capicua && !q.colaVacia());
                if (capicua) {
                    System.out.println(numero + " es capicúa. ");
                } else {
                    System.out.print(numero + " no es capicúa, ");
                    System.out.println(" intente otro. ");
                }
// se vacía la cola y la pila
                q.borrarCola();
                pila.limpiarPila();
            }
        } catch (Exception er) {
            System.err.println("Error (excepcion) en el proceso: " + er);
        }
    }//end oldschool
    
    
    
    
     private static boolean valido(String numero) {
        boolean sw = true;
        int i = 0;
        while (sw && (i < numero.length())) {
            char c;
            c = numero.charAt(i++);
            sw = (c >= '0' && c <= '9');//ternario 
        }
        return sw;
    }
     
     
     
     public static void main(String[] args) {
        NuevaForma();
        
    }
    
    
}

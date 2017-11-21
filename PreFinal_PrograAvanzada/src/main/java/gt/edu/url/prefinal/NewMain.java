/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gt.edu.url.prefinal;

import gt.edu.url.prefinal.serie1.Cesar;
import gt.edu.url.prefinal.serie2.FabricaDeFiguras;
import gt.edu.url.prefinal.serie3.SimuladorJuego;

/**
 *
 * @author Andres
 */
public class NewMain {

    public static void main(String[] args) {

        //--------------------------------------------Serie#1---------------------------------------------------
        Cesar cod = new Cesar();
        System.out.println(cod.cifrarCesarEspañol("Aa Bb Cc Zz", 1));
        //--------------------------------------------Serie#1---------------------------------------------------
        
        
        //--------------------------------------------Serie#2---------------------------------------------------
        FabricaDeFiguras Ff = new FabricaDeFiguras();
        Ff.GenerarFigura();
        //--------------------------------------------Serie#2---------------------------------------------------

        
        //--------------------------------------------Serie#3---------------------------------------------------
        SimuladorJuego juego = new SimuladorJuego();
        juego.Jugar();
        //--------------------------------------------Serie#3---------------------------------------------------
    }
}

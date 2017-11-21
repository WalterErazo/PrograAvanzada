/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gt.edu.url.prefinal.serie2;

/**
 *
 * @author Diego
 */
public class Pentagono implements Polinomio {

    public double area(double lado, double apotema) {
        return (5 * lado * apotema) / 2;
    }

    public double perimetro(double[] lados) {
        double sum = 0;
        for (int i = 0; i < lados.length; i++) {
            sum += lados[i];
        }
        return sum;
    }
}

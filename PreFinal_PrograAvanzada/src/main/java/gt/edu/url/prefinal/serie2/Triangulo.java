/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gt.edu.url.prefinal.serie2;

/**
 *
 * @author Andres
 */
public class Triangulo implements Polinomio {

    @Override
    public double area(double base, double altura) {
        return (base * altura) / 2;
    }

    @Override
    public double perimetro(double[] lados) {
        int sum = 0;
        for (int i = 0; i < lados.length; i++) {
            sum += lados[i];
        }
        return sum;
    }
}

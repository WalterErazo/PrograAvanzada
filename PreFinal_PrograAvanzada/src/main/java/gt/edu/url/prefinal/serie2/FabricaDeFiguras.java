/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gt.edu.url.prefinal.serie2;

import java.util.Arrays;
import java.util.Scanner;

/**
 *
 * @author Laptop
 */
public class FabricaDeFiguras {

    public void GenerarFigura() {

        int numLados;
        Scanner S = new Scanner(System.in);
        System.out.println("Ingrese la cantidad de lados que tiene su polinomio");
        Polinomio x;

        numLados = S.nextInt();
        //======================================Triangulo=========================================================
        if (numLados == 3) {
            double base, altura;
            double[] lados = new double[3];

            for (int i = 0; i < 3; i++) {
                System.out.println("Ingrese el lado: " + (i + 1));
                lados[i] = S.nextInt();
            }
            Arrays.sort(lados);
            
            if (lados[0] == lados[1] || lados[0] == lados[2] || lados[1] == lados[2]) {
                if (lados[0] == lados[1] && lados[1] == lados[2]) {
                    x = new TrianguloEquilatero();
                    base = lados[0];
                    altura = Math.sqrt(Math.pow(lados[0], 2) - Math.pow((lados[0] / 2), 2));
                } else {
                    x = new TrianguloIsoseles();
                    if (lados[0] == lados[1]) {
                        base = lados[2];
                        altura = Math.sqrt(Math.pow(lados[0], 2) - Math.pow((lados[2] / 2), 2));
                    } else {
                        base = lados[0];
                        altura = Math.sqrt(Math.pow(lados[1], 2) - Math.pow((lados[0] / 2), 2));
                    }
                }
            } else {
                x = new Triangulo();
                base = lados[0];
                altura = lados[1];
            }
            System.out.println("El area el triangulo es: " + x.area(base, altura));
            System.out.println("El perimetro el triangulo es: " + x.perimetro(lados));
        }
        //======================================Triangulo=========================================================

        //======================================cuadrilatero=========================================================
        if (numLados == 4) {
            double base, altura;
            double[] lados = new double[2];
            System.out.println("Ingrese la base del cuadrilatero");
            base = S.nextInt();
            System.out.println("Ingrese la altura del cuadrilatero");
            altura = S.nextInt();
            lados[0] = 2 * base;
            lados[1] = 2 * altura;

            if (base == altura) {
                x = new Cuadrado();
                System.out.println("El area el Cuadrado es:" + x.area(base, altura));
                System.out.println("El perimetro el Cuadrado es:" + x.perimetro(lados));
            } else {
                x = new Rectangulo();
                System.out.println("El area el Rectangulo es:" + x.area(base, altura));
                System.out.println("El perimetro el Rectangulo es:" + x.perimetro(lados));
            }
        }
        //======================================cuadrilatero=========================================================

        //======================================pentagono=========================================================
        if (numLados == 5) {
            x = new Pentagono();
            double lado, apotema;
            double[] lados = new double[1];
            System.out.println("Ingrese un lado del pentagono");
            lado = S.nextInt();
            apotema = lado / (2 * Math.tan(Math.toRadians(360 / (2 * 5))));

            System.out.println("El area el pentagono es: " + Math.round(x.area(lado, apotema)));
            lados[0] = 5 * lado;
            System.out.println("El perimetro el pentagono es:" + Math.round(x.perimetro(lados)));
        }
        //======================================pentagono=========================================================

        //======================================Hexagono=========================================================
        if (numLados == 6) {
            x = new Hexagono();
            double lado, apotema;
            double[] lados = new double[1];
            System.out.println("Ingrese un lado del Hexagono");
            lado = S.nextInt();
            apotema = lado / (2 * Math.tan(Math.toRadians(360 / (2 * 6))));

            System.out.println("El area el Hexagono es:" + Math.round(x.area(lado, apotema)));
            lados[0] = 6 * lado;
            System.out.println("El perimetro el Hexagono es:" + Math.round(x.perimetro(lados)));
        }
        //======================================Hexagono=========================================================

        //======================================Octagono=========================================================
        if (numLados == 8) {
            x = new Octagono();
            double lado, apotema;
            double[] lados = new double[1];
            System.out.println("Ingrese un lado del Octagono");
            lado = S.nextInt();
            apotema = lado / (2 * Math.tan(Math.toRadians(22.5)));

            System.out.println("El area el Octagono es:" + Math.round(x.area(lado, apotema)));
            lados[0] = 8 * lado;
            System.out.println("El perimetro el Octagono es:" + Math.round(x.perimetro(lados)));
        }
        //======================================Octagono=========================================================
    }
}

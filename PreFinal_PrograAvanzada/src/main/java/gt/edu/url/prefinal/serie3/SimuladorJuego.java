/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gt.edu.url.prefinal.serie3;

import java.util.Scanner;
import gt.edu.url.prefinal.zdatastructures.LinkedPositionalList;
import gt.edu.url.prefinal.zdatastructures.Position;

/**
 *
 * @author Laptop
 */
public class SimuladorJuego {

    LinkedPositionalList<Carta> Mano = new LinkedPositionalList<>();
    Scanner S = new Scanner(System.in);

    public void Jugar() {
        boolean jugar = true;
        int valor;
        Carta x;
        int choosednum;
        while (jugar == true) {

            System.out.println("presione 1 si desea agregar cartas a su mano, 2 si desea jugar");
            choosednum = S.nextInt();
            if (choosednum == 1 || choosednum == 2) {

                if (choosednum == 1) {//si decide agregar cartas

                    System.out.println("ingrese el valor de la carta");
                    valor = S.nextInt();
                    System.out.println("ingrese 1 si es de corazones\n"
                            + " 2 si es de diamantes\n"
                            + " 3 si es de espadas\n"
                            + " 4 si es de treboles\n");
                    choosednum = S.nextInt();
                    if (choosednum == 1) {
                        this.agregarCarta(valor, x = new Corazones());
                    }
                    if (choosednum == 2) {
                        this.agregarCarta(valor, x = new Diamantes());
                    }
                    if (choosednum == 3) {
                        this.agregarCarta(valor, x = new Espadas());
                    }
                    if (choosednum == 4) {
                        this.agregarCarta(valor, x = new Treboles());
                    }

                } else {//Si decide jugar

                    if (Mano.size() > 0) {
                        System.out.println("ingrese 1 si es de corazones\n"
                                + " 2 si es de diamantes\n"
                                + " 3 si es de espadas\n"
                                + " 4 si es de treboles\n");
                        choosednum = S.nextInt();
                        if (choosednum == 1) {
                            this.Jugar(x = new Corazones());
                        }
                        if (choosednum == 2) {
                            this.Jugar(x = new Diamantes());
                        }
                        if (choosednum == 3) {
                            this.Jugar(x = new Espadas());
                        }
                        if (choosednum == 4) {
                            this.Jugar(x = new Treboles());
                        }
                    } else {
                        System.out.println("Usted no tiene cartas");
                    }

                }

            } else {

                System.out.println("Ingreso un numero invalido");

            }

            System.out.println("Desea seguir jugando 1 = si, 2 = no");
            choosednum = S.nextInt();
            if (choosednum == 2) {
                jugar = false;
            }
        }
    }

    public void agregarCarta(int valor, Carta newCarta) {
        newCarta.setValor(valor);
        Mano.addLast(newCarta);
    }

    public void Jugar(Carta lastCarta) {
        Position choosedCard = null;
        Position temp = Mano.first();
        for (int i = 0; i < Mano.size(); i++) {
            if (lastCarta.getClass() == temp.getElement().getClass()) {
                choosedCard = temp;
            }
            temp = Mano.after(temp);
        }
        if (choosedCard != null) {
            String tp = this.getCname(choosedCard);
            System.out.println("La carta eliminada es: " + Mano.remove(choosedCard).getValor() + " de " + tp);
        } else {
            choosedCard = Mano.first();
            for (int i = 0; i < (int) (Math.random() * Mano.size()); i++) {
                choosedCard = Mano.after(choosedCard);
            }
            String tp = this.getCname(choosedCard);
            System.out.println("La carta eliminada es: " + Mano.remove(choosedCard).getValor() + " de " + tp);
        }
    }

    public String getCname(Position X) {
        Carta C = new Corazones();
        Carta D = new Diamantes();
        Carta E = new Espadas();
        if (C.getClass() == X.getElement().getClass()) {
            return "Corazones";
        }
        if (D.getClass() == X.getElement().getClass()) {
            return "Diamantes";
        }
        if (E.getClass() == X.getElement().getClass()) {
            return "Espadas";
        }
        return "Treboles1";
    }
}

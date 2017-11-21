/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gt.edu.url.prefinal.serie1;

/**
 *
 * @author Laptop
 */
public class Cesar {

    /*
     el cual permite cifrar una frase aleatoria utilizando el alfabeto en idioma español
     distinguiendo mayúsculas de minúsculas
     */
    public String cifrarCesarEspañol(String frase, int distancia) {

        String newString = "";

        for (int i = 0; i < frase.length(); i++) {
            char c = (char) (frase.charAt(i));

            if (c == ' ') {
                newString += ' ';
            } else {
                if (c > 'a') {
                    if (c == 'z') {
                        newString += (char) (('a' - 1) + distancia);
                    } else {
                        newString += (char) (frase.charAt(i) + distancia);
                    }
                } else {
                    if (c == 'Z') {
                        newString += (char) (('A' - 1) + distancia);
                    } else {
                        newString += (char) (frase.charAt(i) + distancia);
                    }
                }
            }
        }
        return newString;
    }
}

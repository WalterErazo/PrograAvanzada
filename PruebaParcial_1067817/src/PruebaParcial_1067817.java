/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Andres Pineda
 */
public class PruebaParcial_1067817 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        PositionalList <String> myList = new LinkedPositionalList <>();
        Position <String> p0,p1,p2,p3,p4;

        p0 = myList.addFirst("g");
        p1 = myList.addAfter(p0,"f");
        p2 = myList.addAfter(p1,"b");
        p2 = myList.addAfter(p2,"c");
        p2 = myList.addAfter(p2,"d");
        p3 = p2;
        p4 = myList.addAfter(p3,"e");
        
        
        
        
        System.out.println("-------------Punteros------------");
        System.out.println(p1.getElement());
        System.out.println(p2.getElement());
        System.out.println(p3.getElement());
        System.out.println("-------------Datos------------");
        
        String p= null;
        do{
            try{
                Position<String> tempPosition = myList.first();
                p = myList.remove(tempPosition);
                System.out.println(p);
            }catch(Exception e){
                
            }
        }while(p != null);
    }    
}
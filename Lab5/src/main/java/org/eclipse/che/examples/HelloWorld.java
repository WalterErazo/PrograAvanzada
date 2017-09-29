package org.eclipse.che.examples;

public class HelloWorld {
    public static void main(String... argvs) {
        
        SinglyLinkedList A = new SinglyLinkedList();
        
        A.addFirst("GUA");
        A.addLast("Japon");
        A.addLast("China");
        A.addLast("Italia");
        A.addLast("Peru");
        A.addLast("España");
        A.addLast("Siria");
        A.addLast("Corea del Norte :3");
        A.addLast("Corea del sur");
        A.addLast("India");
        A.addLast("Japon otra vez");
        
        String val = A.removeFirst();
        while(val != null){
        System.out.println(val);
        val = A.removeFirst();
    }
        
    }

}
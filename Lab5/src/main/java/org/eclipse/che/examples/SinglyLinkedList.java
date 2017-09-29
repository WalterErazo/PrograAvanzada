package org.eclipse.che.examples;

public class SinglyLinkedList {
    
        private static class Node{
        public String propiedad;
        public Node next;
        
        public Node(String a, Node n){
            this.propiedad = a;
            this.next = n;
        }       
        
        private String getpropiedad(){
            return this.propiedad;    
        }
        private void setpropiedad(String propiedad){
            this.propiedad=propiedad;    
        }
        private Node getnext(){
            return this.next;    
        }
        private void setNext(Node next){
            this.next= next;
        }
        
    }
    
    private Node head = null;
    private Node tail = null;
    private int size = 0;
    
    
    public int size(){return size;}
    public boolean isEmpty(){
        return size == 0;
    }
    
    public String first(){
        if (isEmpty()) return null;
        return head.getpropiedad();
    }
    
        public String last(){
        if (isEmpty()) return null;
        return tail.getpropiedad();
    }
    
    public void addFirst(String propiedad){
        head = new Node(propiedad, null);
        if (size == 0){
            tail = head;
        }
        size++;
    }
    
    public void addLast(String propiedad){
        Node newest = new Node(propiedad, null);
        if (isEmpty()){
            head = newest;
        }

        else{
            tail.setNext(newest);
        }
        tail = newest;
        size++;
    }
    
    
    public String removeFirst(){
        if (isEmpty()) return null;
        String res = head .getpropiedad();
        head = head.getnext();
        size--;
        if (size == 0)
            tail = null;
        return res;
        
    }    
}
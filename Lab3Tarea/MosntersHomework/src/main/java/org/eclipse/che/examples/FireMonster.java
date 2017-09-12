package org.eclipse.che.examples;

public class FireMonster implements Monster{
        private String name = "";
    private String attack = "";
    
    public FireMonster(String name, String attack){
        this.name = name;
        this.attack = attack;
    }
    
    public String name(){
        return name;
    }
    
    public String attack(){
        return attack;
    } 
}

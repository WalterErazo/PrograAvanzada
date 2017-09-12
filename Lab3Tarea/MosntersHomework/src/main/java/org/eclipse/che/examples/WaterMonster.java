package org.eclipse.che.examples;

public class  WaterMonster implements Monster{
    private String name = "";
    private String attack = "";
    
    public WaterMonster(String name, String attack){
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

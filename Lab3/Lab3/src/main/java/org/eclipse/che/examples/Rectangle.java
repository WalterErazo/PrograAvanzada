package org.eclipse.che.examples;

public class Rectangle implements Shape{
    
    private double with;
    private double length;
    
    public Rectangle(double with, double length){
        this.with = with;
        this.length = length;
    }
    
    public double getArea(){
        return with*length;
    }
    
    public String toString(){
        return "Rectangle[ with " + this. with
                +" length " + this.length
                +" area " + this.getArea();
    }
    
}

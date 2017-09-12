package org.eclipse.che.examples;

public class Triangle implements Shape{
    
    private double base;
    private double height;
    
    public Triangle(double base, double height){
        this.base = base;
        this.height = height;
        
    }
    
    public double getArea(){
        return ((base*height)/2);
    }
    
    public String toString(){
        return "Triangle[ base " + this. base
                +" height " + this.height
                +" area " + this.getArea();
    }
}

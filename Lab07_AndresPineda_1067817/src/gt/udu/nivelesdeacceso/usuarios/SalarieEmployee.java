/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package gt.udu.nivelesdeacceso.usuarios;

/**
 *
 * @author Laptop
 */
public abstract class SalarieEmployee extends Employee{
    
    int anualSalary;
    /**
     * constructor
     */
    public SalarieEmployee(){
        name = "Victor";
        sethireYear(1999);
    }
    /**
     * 
     * @return el salario mensual
     */
    protected double MonthlyPay(){
        return 100.00;
    }    
}

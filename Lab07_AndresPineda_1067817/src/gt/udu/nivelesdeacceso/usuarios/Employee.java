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
public abstract class Employee {
    
    public String name;
    private int hireYear;
    protected abstract double MonthlyPay();
    protected abstract double AnnualPay();
    
    
    /**
     * fija el año en que se contrato la persona
     * @param hy recibe el año en que se contrato
     */
    public void sethireYear(int hy){
        this.hireYear = hy;
    }
    /**
     * 
     * @return retorna el año de contratacion
     */
    public int gethireYear(){
        return this.hireYear;
    }
}

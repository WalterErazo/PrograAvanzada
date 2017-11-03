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
public abstract class HourlyEmployee extends Employee{
    
    protected int ourperweek;
    protected double hourlyWage;
    
    /**
     * 
     * @return retorna el salario que se paga en un mes
     */
    protected double MonthlyPay(){
        return (1.00 * ourperweek);
    }    
    
    /**
     * fija las horas que trabaja un empleado
     * @param hrw recibe las horas que trabaja la persona
     */
    protected void getHW(int hrw){
            this.ourperweek = hrw;
    }
}

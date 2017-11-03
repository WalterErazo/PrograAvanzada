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
public class FullTime extends HourlyEmployee{
    
    /**
     * Retorna el salario anual del FullTime
     * @return 
     */
    public double AnnualPay(){
        this.getHW(40);
        return this.MonthlyPay()*12;
    }
}

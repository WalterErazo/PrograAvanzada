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
public class Staff extends SalarieEmployee{
        /**
     * Retorna el salario anual del Staff
     * @return 
     */
    public double AnnualPay(){
        return this.MonthlyPay()*12;
    }
}

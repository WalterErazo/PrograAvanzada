/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import gt.udu.nivelesdeacceso.usuarios.Manager;
import gt.udu.nivelesdeacceso.usuarios.Staff;
import gt.udu.nivelesdeacceso.usuarios.PartTime;
import gt.udu.nivelesdeacceso.usuarios.FullTime;
/**
 *
 * @author Laptop
 */
public class Lab07_AndresPineda_1067817 {
    public static void main(String[] args) {
        Manager m = new Manager();
        Staff s = new Staff();
        PartTime p = new PartTime();
        FullTime f = new FullTime();
        
        System.out.println("manager: " + m.AnnualPay());
        System.out.println("Staff: " + s.AnnualPay());
        System.out.println("PartTime: " + p.AnnualPay());
        System.out.println("FullTime: " + f.AnnualPay());
        
    }
    
}

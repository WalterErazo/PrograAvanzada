import java.util.Scanner;
import Serie1.Chudnovsky;
import Serie1.Decimales;
import Serie2.Reportero;
import Serie2.Partido;

/**
 * 
 * @author Andres Pineda
 * v. 0.0.1
 */
public class Main {

	public static void main(String[] args) {
		
		Scanner ReadLine = new Scanner (System.in);
		Chudnovsky Pi;
		
		
		/*
		 * Serie #1
		 */
		Pi = new Decimales();
		int k;
		System.out.println("Ingrese el valor de K");
		k = ReadLine.nextInt();
		System.out.println(Pi.Csky(k));
		
		
		/*
		 * Serie #2
		 */
		int m, n, Rwinner;	
		Partido Tenis = new Partido();
		
		for(int x= 0; x < 10; ) {
			
			System.out.println("Ingrese el valor de m");
			m = ReadLine.nextInt();
			Tenis.getm(m);
			System.out.println("Ingrese el valor de n");
			n = ReadLine.nextInt();
			Tenis.getn(n);
			System.out.println(Tenis.calcularGanador(x));
			System.out.println("Enter a number to remember the winner of that game");
		    Rwinner = ReadLine.nextInt();
		    System.out.println(Tenis.recordarGanador(Rwinner));
			if (Tenis.end == true){
				x++;
			}
		}
		System.out.println(Tenis.calcularCampeon());
		
		
		/*
		 * Serie #3
		 */
		
		
	}
}

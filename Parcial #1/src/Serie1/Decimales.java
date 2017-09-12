package Serie1;

/**
 * 
 * 
 * author: Andres Pineda
 * 
 */
public class Decimales implements Chudnovsky{

	private double constx = 545140134;
	private double consty = 13591409;
	private long constz = -262537412640768000L;
	
	public double factorial(double num) {
		if (num == 0){
			return 1;
		}
		else {
			return num*factorial(num-1);
		}
	}

	public double Csky(double k) {
		if (k < 0) {
			return 0;
		}
		else {
			return ((factorial(6*k))*(constx*k + consty) )/ (factorial(3 * k) * (Math.pow(factorial(k), 3)) * Math.pow(constz,k )) + Csky((k - 1));
		}
	}

	
}

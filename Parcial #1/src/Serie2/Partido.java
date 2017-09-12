package Serie2;

public class Partido implements Reportero{
	
	int m, n;
	public boolean end = false;
	String juegos[] = new String [10];
	
	public void getm(int m) {
		this.m = m;
	}
	
	public void getn(int n) {
		this.n = n;
	}
		
	
	public String calcularGanador(int game) {
		if (m == 6 && n <= 4 || m == 7 && n == 5 || m == 7 && n == 6) {
			end = true;
			juegos[game] = "M";
			return "The player M won";	
		}
		else if (n == 6 && m <= 4 || n == 7 && m == 5 || m == 7 && n == 6) {
			end = true;
			juegos[game] = "N";
			return "The player N won";
		}
		else if (((m == 7 || n ==7) && (m > 5 || n > 5)) || (m > 7 || n > 7) || (m < 0 || n < 0)){
			end = true;
			return "Invalid results";
		}
		else {
			end = false;
			return "The mach is still in progress";
		}
	}


	public String calcularCampeon() {
		int WinsM = 0;
		int WinsN = 0;
		for(int x= 0; x < 10; x++) {
			if (juegos[x] == "M") {
				WinsM++;
			}
			else {
				WinsN++;
			}
		}
		if (WinsM > WinsN) {
			return "El campeon es M";
		}
		else {
			return "El campeon es N";
		}	
	}
	
	public String recordarGanador(int juego) {
		if (juegos[juego] != null) {
			return juegos[juego];
		}
		else {
			return "That game does not have a winner";
		}
	}
}

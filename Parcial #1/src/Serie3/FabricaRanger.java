package Serie3;

public interface FabricaRanger {
    
	String nombre = "";
	String elemento = "";
	int edad = 0;
	String color = "";
	
	boolean aginatarse = true;
	boolean caminarLento = true;
	boolean golpear = true;
	
	
    public void hacerAlgo();
    
    public boolean apilar(Monstruo monstruo);
    public boolean desapilar(Monstruo monstruo);
    public boolean encolar(Monstruo monstruo);
    public boolean desencolar(Monstruo monstruo);
    public Monstruo fabricar(String elemento);
}

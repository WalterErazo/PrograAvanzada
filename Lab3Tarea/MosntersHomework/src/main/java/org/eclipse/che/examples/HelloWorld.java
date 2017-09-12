package org.eclipse.che.examples;

public class HelloWorld {
    public static void main(String... argvs) {
        Monster Kyogre, Groudon, Graveler;
        
        Kyogre = new WaterMonster("Kyogre", "Hydro pump");
        System.out.println(Kyogre.name() + " used " + Kyogre.attack() + "It's super effective");
        
        Groudon = new FireMonster("Groudon", "Flamethrower");
        System.out.println(Groudon.name() + " used " + Groudon.attack() + "It's super effective");
        
        Graveler = new StoneMonster("Graveler", "earthquake");
        System.out.println(Graveler.name() + " used " + Graveler.attack() + "It's super effective");
    }
}
package lab8_graphviz_1067817;

import java.io.IOException;

public class NewMain {

    public static void main(String[] args) throws IOException{
        FileLoader fl = new FileLoader();
        fl.loadFileWithJava8();
        
       DemoGraphviz dg = new DemoGraphviz();
       dg.createDemoFromDot();
    }
    
}

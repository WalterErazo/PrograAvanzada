// Simple Hello World
 
#include <iostream>
 int Sumar(int, int);
 int Restar(int, int);
 int Multiplicar(int, int);
 int Dividir(int, int);
 
  //------------------------------Punteros-----------------------------------------------------
  void Sumapunteros(int, int, int*);
  void Restapunteros(int, int, int*);
  void Multpunteros(int, int, int*);
  void Divpunteros(int, int, int*);
  
  
  int main()
  {
  std::cout << "Mira mama, estoy programando en C++ xdxdxd" << std::endl;
  double Resultado = Sumar(5, 7);
  std::cout << Resultado << std::endl;
  
  Resultado = Restar(10, 7);
  std::cout << Resultado << std::endl;
  
  Resultado = Multiplicar(5, 7);
  std::cout << Resultado << std::endl;
  
  Resultado = Dividir(15, 5);
  std::cout << Resultado << std::endl;
   //------------------------------Punteros-----------------------------------------------------
  
  //-----suma----
  int punteroAmasB = -1;
  std::cout << "Puntero antes del cambio " << punteroAmasB << std::endl;
  
  Sumapunteros(5, 15, &punteroAmasB);
  std::cout << "Puntero despues del cambio " << punteroAmasB<< std::endl;
  
  
    //-----Resta----
  int punteroAmenosB = -1;
  std::cout << "Puntero antes del cambio " << punteroAmenosB << std::endl;
  
  Restapunteros(5, 15, &punteroAmenosB);
  std::cout << "Puntero despues del cambio " << punteroAmenosB<< std::endl;
  
  
    //-----Multi----
  int punteroAmultiB = -1;
  std::cout << "Puntero antes del cambio " << punteroAmultiB << std::endl;
  
  Multpunteros(5, 15, &punteroAmultiB);
  std::cout << "Puntero despues del cambio " << punteroAmultiB<< std::endl;
  
  
    //-----Div----
  int punteroAdivB = -1;
  std::cout << "Puntero antes del cambio " << punteroAdivB << std::endl;
  
  Divpunteros(5, 15, &punteroAdivB);
  std::cout << "Puntero despues del cambio " << punteroAdivB<< std::endl;
    
  return 0;
}


int Sumar(int a , int b){
     return a+b;
 }
 
 int Restar(int a , int b){
     return a-b;
 }
 
 int Multiplicar(int a , int b){
     return a*b;
 }
 
 int Dividir(int a , int b){
     return a/b;
 }
 
 //------------------------------Punteros-----------------------------------------------------
  void Sumapunteros(int a, int b, int* punteroAmasB){
     *punteroAmasB = a+b;
  }
  void Restapunteros(int a, int b, int* punteroAmenosB){
      *punteroAmenosB = a-b;
  }
  void Multpunteros(int a, int b, int* punteroAporB){
      *punteroAporB = a*b;
  }
  void Divpunteros(int a, int b, int* punteroAentreB){
      *punteroAentreB = a/b;
  }

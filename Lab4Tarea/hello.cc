#include <iostream>
using namespace std;

 
void tablaN(int);
void tablaTarea(int);
void buscar();
 
int main()
{
  int num = 7;
  cout << "Tabla de multiplicar del 7:" << endl;
  tablaN(num);
  
  //Tarea------------------------------------------------------------
  
  int numTarea = 0;
  cout << "Ingrese el tamaño del arreglo" << endl;
  cin >> numTarea;
  tablaTarea(numTarea);  
  
  
  return 0;
}

void tablaN(int N)
{
    int tabla [10];
    for (int i = 0; i < 10; i++)
    {
        tabla[i] = (i+1)*N;
    }
    
    for (int i = 0; i< 10; i++)
    {
        cout << i+1 << " * " << N << " = " << tabla[i] << endl;
    }
}

//Tarea--------------------------------------------------------------
void tablaTarea(int N)
{
    int tabla [N];
    int suma = 0;
    for (int i = 0; i < N; i++)
    {
        cout <<"Ingrese el #" << (i+1) << " del arreglo" <<endl;
        cin >> tabla[i];
    }
    
    //numeros ingresados
    cout <<"Los numeros ingresados son:" <<endl;
    for (int i = 0; i< N; i++)
    {
        cout << tabla[i] << endl;
    }
    
    
    //suma del arreglo
    for (int i = 0; i< N; i++)
    {
        suma += tabla[i];
    }
    cout<<"La suma del arreglo es: "<<suma<<endl;
    suma = 0;
    
    //suma pares del arreglo
    for (int i = 0; i< N; i += 2)
    {
        suma += tabla[i];
    }
    cout<<"La suma de las posiciones pares del arreglo es: "<<suma<<endl;
    suma = 0;
    
    //suma impares del arreglo
    for (int i = 1; i < N; i += 2)
    {
        suma += tabla[i];
    }
    cout<<"La suma de las posiciones impares del arreglo es: "<<suma<<endl;
    suma = 0;
    
    //longitud del arreglo
    cout <<"La longitud del arreglo es: "<< N <<endl;
    
    //buscar un numero
    bool buscar = true;
    int p = 0;
    while (buscar == true)
    {
        cout<<"Ingrese la posicion que desea mostrar tomando en cuenta que 0 es igual a la primera posicion del arreglo" << endl;
        cin >> p;
        cout<< tabla[p]<<endl;;
        cout<< "Desea buscar otro numero 1 = si, 0 = no"<<endl;
        cin >> p;
        if (p == 1)
        {
            buscar = true;
        }
        else
        {
            buscar = false;
        }
    }
}
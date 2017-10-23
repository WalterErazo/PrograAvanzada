//============================================================================
// Name        : ReposicionDePrimerParcial.cpp
// Author      : Andres Pineda
// Version     :
// Copyright   : Your copyright notice
// Description : Hello World in C++, Ansi-style
//============================================================================
#include <iostream>                     //Ya
#include <cstdlib>                      //Ya
#include "ListaEnlazada.h"              //Ya
#include "ListaDoblementeEnlazada.h"    //Ya
#include "ListaCircularEnlazada.h"      //Ya
#include "Stack.h"                      //Ya
#include "Queue.h"                      //Ya
#include "P2.h"                         //Ya
//#include "P3.h"                       //Nel
//#include "P4.h"                       //Nel
//#include "P5.h"                       //Nel

using namespace std;

int main() {
	//Problema2---------------------------------------------------------------------------------------------------------------------------------------------------------------
	cout<<"Problema #2"<<endl;
	Stack P;
	int x, a, b;
		cout<<"Introduzca 5 numeros a continuacion:"<<endl;
		cout<<"1"<<endl;
		cin>>x;
		P.push(x);
		cout<<"2"<<endl;
		cin>>x;
		P.push(x);
		cout<<"3"<<endl;
		cin>>x;
		P.push(x);
		cout<<"4"<<endl;
		cin>>x;
		P.push(x);
		cout<<"5"<<endl;
		cin>>x;
		P.push(x);

		cout<<"Ingrese el numero viejo"<<endl;
		cout<<"1"<<endl;
		cin>>a;

		cout<<"Ingrese el numero nuevo"<<endl;
		cout<<"1"<<endl;
		cin>>b;
	P2 D;
	D.replace(P, a, b);

	//Problema3--------------------------------------------------------------------------------------------------------------------------------------------------------------

	//Problema3--------------------------------------------------------------------------------------------------------------------------------------------------------------


	/*//Problema4--------------------------------------------------------------------------------------------------------------------------------------------------------------
	ListaEnlazada L1;
	ListaDoblementeEnlazada L2;


	L1.addNode(1);
	L1.addNode(2);
	L1.addNode(3);
	L1.addNode(4);
	L1.addNode(5);

	L2.addNode(5);
	L2.addNode(4);
	L2.addNode(3);
	L2.addNode(2);
	L2.addNode(1);

	//l2.compare(l1, l2);*/
	//Problema4--------------------------------------------------------------------------------------------------------------------------------------------------------------


	//Problema5--------------------------------------------------------------------------------------------------------------------------------------------------------------

	//Problema5--------------------------------------------------------------------------------------------------------------------------------------------------------------

}

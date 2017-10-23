//============================================================================
// Name        : ReposicionDePrimerParcial.cpp
// Author      : Andres Pineda
// Version     :
// Copyright   : Your copyright notice
// Description : Hello World in C++, Ansi-style
//============================================================================
#include <iostream>
#include <cstdlib>
#include "ListaEnlazada.h"
#include "ListaDoblementeEnlazada.h"
#include "ListaCircularEnlazada.h"
#include "Stack.h"
//#include "StaticPila.h"
//#include "Cola.h"
//#include "StaticCola.h"
//#include "P2.h"
//#include "P3.h"
//#include "P4.h"
//#include "P5.h"

using namespace std;

int main() {

	Stack pill;

	cout<<pill.isEmpty()<<endl;
	pill.push(1);
	pill.push(2);
	pill.push(3);
	pill.push(4);
	pill.push(5);
	pill.push(6);
	cout<<pill.top()<<endl;
	cout<<pill.isEmpty()<<endl;
	pill.printStack();

	pill.pop();
	pill.pop();
	pill.pop();
	pill.printStack();
	cout<<pill.top()<<endl;
}

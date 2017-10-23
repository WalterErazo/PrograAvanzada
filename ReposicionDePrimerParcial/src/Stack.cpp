/*
 * Stack.cpp
 *
 *  Created on: 22/10/2017
 *      Author: Laptop
 */
#include <iostream>
#include "Stack.h"
using namespace std;

Stack::Stack() {
	stackPtr = NULL;
}

int Stack::size(){
	return Size;
}
bool Stack::isEmpty(){
	return stackPtr == NULL;
}
int Stack::top(){
	return stackPtr->data;
}
void Stack::push(int Data){
	CnodePtr nn = new node();
	nn->data = Data;
	if(stackPtr == NULL){
		stackPtr = nn;
		stackPtr->prev = NULL;
	}
	else{
		nn->prev = stackPtr;
		stackPtr = nn;
	}
	Size++;
}
void Stack::pop(){
	CnodePtr oldnode;
	oldnode = stackPtr;
	stackPtr = stackPtr->prev;
	delete oldnode;
	Size--;
}
void Stack::printStack(){
	CnodePtr nn = stackPtr;
	while (nn != NULL){
		cout<<nn->data<<endl;
		nn = nn->prev;
	}
	nn = NULL;
}

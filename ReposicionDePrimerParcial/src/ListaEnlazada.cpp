/*
 * ListaEnlazada.cpp
 *
 *  Created on: 21/10/2017
 *      Author: Laptop
 */
#include <iostream>
#include <cstdlib>
#include "ListaEnlazada.h"
using namespace std;


ListaEnlazada::ListaEnlazada(){
	head = NULL;
	curr = NULL;
	temp = NULL;
}

void ListaEnlazada::addNode(int addData){
	nodePtr n = new node;
	n->data = addData;
	n->next = NULL;

	if (head != NULL){
		curr = head;
		while (curr->next != NULL){
			curr = curr->next;
		}
		curr->next = n;
	}
	else{
		head = n;
	}
}

void ListaEnlazada::deleteNode(int delData){
	nodePtr delPtr = NULL;
	temp = head;
	curr = head;
	while ((curr != NULL) && (curr->data != delData)){
		temp = curr;
		curr = curr->next;
	}
	if (curr == NULL){
		cout<< delData << " no estaba en la lista" << endl;
	}
	else{
		delPtr = curr;
		curr = curr->next;
		temp->next = curr;
		if (head == delPtr){
			head = head->next;
			temp = NULL;
		}
		cout<< delData << " fue eliminado exitosamente, la lista resultante es: " << endl;
		delete delPtr;
	}
}

void ListaEnlazada::printList(){
	curr = head;
	while(curr != NULL){
		cout<<curr->data<< endl;
		curr = curr->next;
	}
}

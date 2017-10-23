/*
 * ListaDoblementeEnlazada.cpp
 *
 *  Created on: 22/10/2017
 *      Author: Laptop
 */
#include <iostream>
#include <cstdlib>
#include "ListaEnlazada.h"
#include "ListaDoblementeEnlazada.h"
using namespace std;


ListaDoblementeEnlazada::ListaDoblementeEnlazada(){
	head = NULL;
	tail = NULL;
	curr = NULL;
}


void ListaDoblementeEnlazada::addNode(int addData){
	dnodePtr n = new node;
	n->data = addData;
	n->next = NULL;
	n->prev = NULL;

	if (head != NULL){
		curr = head;
		while (curr->next != NULL){
			curr = curr->next;
		}
		curr->next = n;
		n->prev = curr;
		tail = n;
	}
	else{//this is if the list is empty;
		head = n;
		tail = head;
	}
}

void ListaDoblementeEnlazada::deleteNode(int delData){
	curr = head;
	while ((curr != NULL) && (curr->data != delData)){
		curr = curr->next;
	}
	if (curr == NULL){
		cout<< delData << " no estaba en la lista" << endl;
	}
	else{
		if (curr->prev == NULL){
			head = head->next;
			head->prev = NULL;
		}
		if (curr->next == NULL){
			tail = tail->prev;
			tail->next = NULL;
		}
		if ((curr->next != NULL)&&(curr->prev != NULL)){
			curr->prev->next = curr->next;//Modify the pointer of the prev node that points the next node
			curr->next->prev = curr->prev;//Modify the pointer of the next node that points the prev node
			curr = NULL;
		}
		cout<< delData << " fue eliminado exitosamente, la lista resultante es: " << endl;
	}
}

void ListaDoblementeEnlazada::printList(){
	curr = head;
	while(curr != NULL){
		cout<<curr->data<< endl;
		curr = curr->next;
	}
}

/*
dnodePtr ListaDoblementeEnlazada::getHead(){
	return head;
}


dnodePtr ListaDoblementeEnlazada::getTail(){
	return tail;
}

bool ListaDoblementeEnlazada::compare(ListaEnlazada L1, ListaDoblementeEnlazada L2){
	bool estaContenida = true;
	nodePtr Nl1 = L1.getHead();
	dnodePtr Nl2 = L2.getHead();

	while (Nl1 != NULL && Nl2 != NULL){
		if (Nl1->data == Nl2->data){
			estaContenida = true;
			Nl1 = Nl1->next;
			Nl2 = Nl2->next;
		}
		else{
			return false;
		}



	}



}
*/

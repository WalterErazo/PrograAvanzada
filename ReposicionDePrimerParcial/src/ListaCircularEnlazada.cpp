/*
 * ListaCircularEnlazada.cpp
 *
 *  Created on: 22/10/2017
 *      Author: Laptop
 */
#include <iostream>
#include <cstdlib>
#include "ListaCircularEnlazada.h"
using namespace std;


ListaCircularEnlazada::ListaCircularEnlazada(){
	head = NULL;
	tail = NULL;
	curr = NULL;
}


void ListaCircularEnlazada::addNode(int addData){
	cnodePtr n = new node;
	n->data = addData;
	n->next = NULL;
	n->prev = NULL;

	if (head != NULL){
		curr = head;
		head->prev = NULL;
		tail->next = NULL;
		while (curr->next != NULL){
			curr = curr->next;
		}
		curr->next = n;
		tail = n;
		tail->next = head;
		head->prev = tail;
	}
	else{//this is if the list is empty;
		head = n;
		tail = head;
		head->prev = tail;
		tail->next = head;
	}
}

void ListaCircularEnlazada::deleteNode(int delData){
	cnodePtr delPtr = NULL;
	cnodePtr delPtr2 = NULL;
	delPtr = head;
	curr = head;
	head->prev = NULL;
	tail->next = NULL;
	while ((curr != NULL) && (curr->data != delData)){
		delPtr = curr;
		curr = curr->next;
	}
	if (curr == NULL){
		cout<< delData << " no estaba en la lista" << endl;
	}
	else{
		delPtr2 = curr;
		curr = curr->next;
		delPtr->next = curr;
		if (head == delPtr2 || tail == delPtr2){
			if (head == delPtr2 && tail == delPtr2){
				head = NULL;
				tail = NULL;
				curr = NULL;
			}
			if (head == delPtr2){
				head = head->next;
				head->prev = tail;
				tail->next = head;
			}
			if (tail == delPtr2){
				tail = delPtr;
				head->prev = tail;
				tail->next = head;
			}
		}
		delPtr = NULL;
		delPtr2 = NULL;
		head->prev = tail;
		tail->next = head;
		cout<< delData << " fue eliminado exitosamente, la lista resultante es: " << endl;
	}
}

void ListaCircularEnlazada::printList(){
	curr = head;
	cout<<curr->data<< endl;
	while(curr != tail){
		cout<<curr->next->data<< endl;
		curr = curr->next;
	}
}


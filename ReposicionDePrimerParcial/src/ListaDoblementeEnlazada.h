/*
 * ListaDoblementeEnlazada.h
 *
 *  Created on: 22/10/2017
 *      Author: Laptop
 */
#include "ListaEnlazada.h"
#ifndef LISTADOBLEMENTEENLAZADA_H_
#define LISTADOBLEMENTEENLAZADA_H_

class ListaDoblementeEnlazada {
private:
typedef struct node{
	int data;
	node* prev;
	node* next;
}* dnodePtr;

dnodePtr head;
dnodePtr tail;
dnodePtr curr;

public:
	ListaDoblementeEnlazada();
	void addNode(int addData);
	void deleteNode(int delData);
	void printList();
	bool compare(ListaEnlazada L1, ListaDoblementeEnlazada L2);

	dnodePtr getHead();
	dnodePtr getTail();
};

#endif /* LISTADOBLEMENTEENLAZADA_H_ */

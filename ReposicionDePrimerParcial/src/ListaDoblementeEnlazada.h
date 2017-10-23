/*
 * ListaDoblementeEnlazada.h
 *
 *  Created on: 22/10/2017
 *      Author: Laptop
 */

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
};

#endif /* LISTADOBLEMENTEENLAZADA_H_ */

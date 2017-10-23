/*
 * ListaCircularEnlazada.h
 *
 *  Created on: 22/10/2017
 *      Author: Laptop
 */

#ifndef LISTACIRCULARENLAZADA_H_
#define LISTACIRCULARENLAZADA_H_

class ListaCircularEnlazada {
	private:
	typedef struct node{
		int data;
		node* next;
		node* prev;
	}* cnodePtr;

	cnodePtr head;
	cnodePtr curr;
	cnodePtr tail;

	public:
	ListaCircularEnlazada();
	void addNode(int addData);
	void deleteNode(int delData);
	void printList();
};
#endif /* LISTACIRCULARENLAZADA_H_ */

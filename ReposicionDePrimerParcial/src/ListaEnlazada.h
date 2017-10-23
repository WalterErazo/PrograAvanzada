/*
 * ListaEnlazada.h
 *
 *  Created on: 21/10/2017
 *      Author: Laptop
 */
#ifndef LISTAENLAZADA_H_
#define LISTAENLAZADA_H_

class ListaEnlazada
{
private:
typedef struct node{
	int data;
	node* next;
}* nodePtr;

nodePtr head;
nodePtr curr;
nodePtr temp;

public:
ListaEnlazada();
void addNode(int addData);
void deleteNode(int delData);
void printList();
};
#endif /* LISTAENLAZADA_H_ */

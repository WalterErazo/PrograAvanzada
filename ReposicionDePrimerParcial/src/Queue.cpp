/*
 * Queue.cpp
 *
 *  Created on: 22/10/2017
 *      Author: Laptop
 */
#include <iostream>
#include <cstdlib>
#include "Queue.h"
using namespace std;


Queue::Queue(){
	head = NULL;
	tail = NULL;
	curr = NULL;
}


void Queue::push(int addData){
	QnodePtr n = new node;
	n->data = addData;
	n->next = NULL;

	if (head != NULL){
		curr = head;
		while (curr->next != NULL){
			curr = curr->next;
		}
		curr->next = n;
		tail = n;
	}
	else{
		head = n;
		tail = n;
	}
	Size++;
}

void Queue::pop(){
	QnodePtr temp = head;
	if (head != tail){
		head = head->next;
		delete temp;
	}
	else{
		head = NULL;
		tail = NULL;
		delete temp;
	}
	Size--;
}

void Queue::printQueue(){
	curr = head;
	while(curr != NULL){
		cout<<curr->data<< endl;
		curr = curr->next;
	}
}

int Queue::first(){
	return head->data;
}

bool Queue::isEmpty(){
	return head == NULL;
}

int Queue::size(){
	return Size;
}

/*
 * Stack.h
 *
 *  Created on: 22/10/2017
 *      Author: Laptop
 */
#include <iostream>
#ifndef STACK_H_
#define STACK_H_

class Stack{
private:

	typedef struct node{
		int data;
		node* prev;
	}* CnodePtr;
	CnodePtr stackPtr;
	int Size = 0;

public:
	Stack();
	int size();
	bool isEmpty();
	int top();
	void push(int data);
	void pop();
	void printStack();
	void Replace(int a, int b);
};

#endif /* STACK_H_ */

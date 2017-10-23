/*
 * Queue.h
 *
 *  Created on: 22/10/2017
 *      Author: Laptop
 */

#ifndef QUEUE_H_
#define QUEUE_H_

class Queue{
private:
typedef struct node{
	int data;
	node* next;
}* QnodePtr;
QnodePtr head;
QnodePtr tail;
QnodePtr curr;
int Size = 0;

public:
Queue();
void push(int addData);
void pop();
void printQueue();
int first();
bool isEmpty();
int size();
};
#endif /* QUEUE_H_ */

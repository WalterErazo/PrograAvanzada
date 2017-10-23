/*
 * P2.h
 *
 *  Created on: 22/10/2017
 *      Author: Laptop
 */
#include "Stack.h"
#ifndef P2_H_
#define P2_H_

class P2 {
private:
	int n1;
	int n2;
	Stack pill;
public:
	P2();
	void replace(Stack P, int a, int b);
};

#endif /* P2_H_ */

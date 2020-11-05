// Quadratic Formula.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include "QuadEq.h"

using namespace std;

int main()
{
	QuadEq Eq1(2, 3, 1);
	QuadEq Eq2;

	Eq2.setA(1);
	Eq2.setB(3);
	Eq2.setC(0);

	double result1 = Eq1.getRoot1();
	double result2 = Eq1.getRoot2();

	double result3 = Eq2.getRoot1();
	double result4 = Eq2.getRoot2();

	cout << "The roots for Eq1 are: " << result1 << ", " << result2 << endl;
	cout << "The roots for Eq2 are: " << result3 << ", " << result4 << endl;
	return 0;
}
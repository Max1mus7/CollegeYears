// C++ Debugging.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <algorithm>
using namespace std;

int main()
{
	cout << "Hello World!\n";
	cout << "This is a program that takes two numbers from users and performs basic math on them.\nPlease input your first number:\n";
	double a, b;
	string input;
	cin >> a;
	cout << "Please input your second number:\n";
	cin >> b;
	int loop = 0;
	cout << "What operation would you like to perform on the numbers?(Addition, subtraction, etc.)\n";
	while (loop == 0)
	{
		cin >> input;
		transform(input.begin(), input.end(), input.begin(), ::tolower);
		if (input.compare("addition") == 0 || input.compare("add") == 0)
		{
			cout << a + b;
			break;
		}
		if (input.compare("subtraction") == 0 || input.compare("subtract") == 0)
		{
			cout << a - b;
			break;
		}
		if (input.compare("multiplication") == 0 || input.compare("multiply") == 0)
		{
			cout << a * b;
			break;
		}
		if (input.compare("division") == 0 || input.compare("divide") == 0)
		{
			cout << a / b;
			break;
		}
		cout << "You have input an invalid operation or this program does not support the operation you tried. Please input another: \n";
	}
}
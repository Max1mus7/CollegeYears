#include <iostream>
#include <string>

using namespace std;

class QuadEq
{
public:
	double a, b, c;

	QuadEq()
	{
		a = 2;
		b = 2;
		c = 2;
	}

	QuadEq(double a, double b, double c)
	{
		this->a = a;
		this->b = b;
		this->c = c;
	}

	double getRoot1()
	{
		double r1 = ((-b + sqrt((b * b) - (4.0 * a * c))) / (2.0 * a));
		return r1;
	}

	double getRoot2()
	{
		double r2 = ((-b - sqrt((b * b) - (4.0 * a * c))) / (2.0 * a));
		return r2;
	}

	void setA(double newA)
	{
		a = newA;
	}

	void setB(double newB)
	{
		b = newB;
	}
	void setC(double newC)
	{
		c = newC;
	}
};

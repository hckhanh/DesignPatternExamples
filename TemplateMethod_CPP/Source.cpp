#include <stdio.h>


class Base
{
	void a()
	{
		printf("a ");
	}

	void c()
	{
		printf("c");
	}

	// Placeholders
	virtual void ph1() = 0;
	virtual void ph2() = 0;

public:
	void excute()
	{
		a();
		ph1();
		c();
		ph2();
	}
};

class One : public Base
{
	void ph1()
	{
		printf("b ");
	}

	void ph2()
	{
		printf("d ");
	}

};

class Two : public Base
{
	void ph1()
	{
		printf("a++ ");
	}
	void ph2()
	{
		printf("b++ ");
	}
};

class Three : public Base
{
	void ph1()
	{
		// May be more...
	}
	void ph2()
	{
		// May be more...
	}
};



void main()
{
	Base *array [] = { &One(), &Two(), &Three() };

	for (int i = 0; i < 2; i++)
	{
		array[i]->excute();
		printf("\n");
	}
}
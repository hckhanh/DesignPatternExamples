#ifndef FOOD_CPP
#define FOOD_CPP

#include <string.h>

class Food
{
	char name[50];
	float price;
public:
	Food(char* name, float price) : price(price)
	{
		strcpy_s(this->name, name);
	}

	char* getName()
	{
		return name;
	}

	float getPrice()
	{
		return price;
	}
};

#endif
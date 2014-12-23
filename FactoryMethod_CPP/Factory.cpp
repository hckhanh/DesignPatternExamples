#ifndef FOOD_FACTORY_CPP
#define FOOD_FACTORY_CPP

#include "Food.cpp"
#include <list>
using namespace std;

class Factory
{
public:
	virtual Food* produce() const = 0;

	virtual bool hasFood(char* name) = 0;

	virtual list<Food*>* getPrototypes() = 0;
};

#endif
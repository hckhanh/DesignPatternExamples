#ifndef BAKERY_FACTORY_CPP
#define BAKERY_FACTORY_CPP

#include "Factory.cpp"
#include "Cake.cpp"
#include <string.h>

class CakeFactory : public Factory
{
public:
	virtual Food* produce() const
	{
		return (Food*)new Cake("Donuts", 8.99f);
	}

	virtual bool hasFood(char* name)
	{
		return !_stricmp(name, "Donuts");
	}

	virtual list<Food*>* getPrototypes()
	{
		auto foods = new list<Food*>();
		foods->push_back(new Food("Donuts", 8.99f));
		return foods;
	}
};

#endif
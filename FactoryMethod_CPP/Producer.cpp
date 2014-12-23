#ifndef PRODUCER_CPP
#define PRODUCER_CPP

#include "Food.cpp"
#include "Factory.cpp"
#include <list>
using namespace std;

class Producer
{
protected:
	Factory* factory;

public:
	virtual Food* produce() const = 0;

	virtual list<Food*>* getPrototypes() = 0;

	bool hasFood(char* name)
	{
		return factory->hasFood(name);
	}

	~Producer()
	{
		delete factory;
	}
};

#endif
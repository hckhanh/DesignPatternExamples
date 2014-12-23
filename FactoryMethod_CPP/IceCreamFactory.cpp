#ifndef ICE_CREAM_FACTORY_CPP
#define ICE_CREAM_FACTORY_CPP

#include "Factory.cpp"
#include "IceCream.cpp"
#include <string.h>

class IceCreamFactory : public Factory
{
public:
	virtual Food* produce() const
	{
		return (Food*)new IceCream("Wall", 0.84f);
	}

	virtual bool hasFood(char* name)
	{
		return !_stricmp(name, "Wall");
	}

	virtual list<Food*>* getPrototypes()
	{
		auto foods = new list<Food*>();
		foods->push_back(new Food("Wall", 0.84f));
		return foods;
	}
};

#endif
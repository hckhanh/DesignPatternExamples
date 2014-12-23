#ifndef BAKERY_STORE_CPP
#define BAKERY_STORE_CPP

#include "CakeProducer.cpp"
#include "IceCreamProducer.cpp"
#include <list>
using namespace std;

class BakeryStore
{
	Producer** producers;
	int nProducer;

public:
	BakeryStore()
	{
		nProducer = 2;
		producers = new Producer*[nProducer];
		producers[0] = new CakeProducer();
		producers[1] = new IceCreamProducer();
	}

	Food* Sell(char* name)
	{
		return produce(name);
	}

	list<Food*>* initMenu()
	{
		auto menuItem = new list<Food*>();
		for (int i = 0; i < nProducer; i++)
		{
			auto foodList = producers[i]->getPrototypes();
			menuItem->merge(*foodList);
			delete foodList;
		}
		return menuItem;
	}

	~BakeryStore()
	{
		for (int i = 0; i < nProducer; i++)
			delete producers[i];
		delete [] producers;
	}

private:
	Food* produce(char* name)
	{
		for (int i = 0; i < nProducer; i++)
		{
			if (producers[i]->hasFood(name))
				return producers[i]->produce();
		}
		return nullptr;
	}
};

#endif
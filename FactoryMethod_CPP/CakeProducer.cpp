#ifndef CAKE_PRODUCER_CPP
#define CAKE_PRODUCER_CPP

#include "Producer.cpp"
#include "CakeFactory.cpp"

class CakeProducer : public Producer
{
public:
	CakeProducer()
	{
		factory = new CakeFactory();
	}

	virtual Food* produce() const
	{
		return factory->produce();
	}

	virtual list<Food*>* getPrototypes()
	{
		return factory->getPrototypes();
	}
};

#endif
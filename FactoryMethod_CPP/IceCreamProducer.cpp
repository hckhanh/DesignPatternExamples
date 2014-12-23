#ifndef ICE_CREAM_PRODUCER_CPP
#define ICE_CREAM_PRODUCER_CPP

#include "Producer.cpp"
#include "IceCreamFactory.cpp"

class IceCreamProducer : public Producer
{
public:
	IceCreamProducer()
	{
		factory = new IceCreamFactory();
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
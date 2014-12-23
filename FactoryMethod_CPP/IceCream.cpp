#ifndef ICE_CREAM_CPP
#define ICE_CREAM_CPP

#include "Food.cpp"

class IceCream : public Food
{
public:
	IceCream(char* name, float price) : Food(name, price) { }
};

#endif
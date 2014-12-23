#ifndef CAKE_CPP
#define CAKE_CPP

#include "Food.cpp"

class Cake : public Food
{
public:
	Cake(char* name, float price) : Food(name, price) { }
};

#endif
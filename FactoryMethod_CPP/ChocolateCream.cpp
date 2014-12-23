#include "IceCream.cpp"

class ChocolateCream : public IceCream
{
public:
	ChocolateCream(char* name, float price) : IceCream(name, price) { }
};
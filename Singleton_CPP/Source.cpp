#include <iostream>
using namespace std;

class GlobalClass
{
	static GlobalClass* instance;
	int m;
	GlobalClass() {}
public:
	static GlobalClass* GetInstance()
	{
		if (!instance) // Lazy Initialization
			instance = new GlobalClass;
		return instance;
	}
};

GlobalClass* GlobalClass::instance;

void main()
{
	GlobalClass* instance1 = GlobalClass::GetInstance();
	GlobalClass* instance2 = GlobalClass::GetInstance();

	if (instance1 == instance2)
	{
		cout << "Two objs are the same." << endl;
		delete instance1;
		instance1 = instance2 = NULL;
	}
}
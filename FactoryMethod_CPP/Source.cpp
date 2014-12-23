#include "BakeryStore.cpp"
#include <iostream>
using namespace std;

void printMenu(BakeryStore* store);

void main()
{
	cout << "Bakery Store" << endl << endl;
	cout << "Menu:" << endl;
	
	BakeryStore* store = new BakeryStore();
	printMenu(store);
	
	cout << "Enter name of your food: ";
	char name[50];
	cin >> name;

	Food* food = store->Sell(name);
	if (food)
	{
		cout << endl << "Your food:" << endl;
		cout << "Name: " << food->getName() << endl;
		cout << "Price: $" << food->getPrice() << endl;
	}
	else
	{
		cout << endl << "Sorry! We don't have any food like the name you say." << endl;
	}

	cout << endl << "Goodbye and see you later! Thank you :D" << endl;

	delete store;
	if (food)
		delete food;
}

void printMenu(BakeryStore* store)
{
	auto foodList = store->initMenu();
	int key = 1;
	while (!foodList->empty())
	{
		auto food = foodList->front();
		cout << key++ << ". " << food->getName() << endl;
		foodList->pop_front();
		delete food;
	}
}
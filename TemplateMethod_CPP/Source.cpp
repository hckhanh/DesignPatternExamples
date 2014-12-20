#include "Base.cpp"
#include "SortTemplateMethod.cpp"

void printArray(int* a, int size);

int main()
{
	Base *array [] =
	{
		&One(), &Two()
	};
	for (int i = 0; i < 2; i++)
	{
		array[i]->execute();
		cout << '\n';
	}

	int a [] = {9, 1, 9, 2, 5, 4, -1, 9, 100, 11, 1, 0};
	SortTemplateMethod *sortArray [] = { &SortAscending(), &SortDescending() };

	sortArray[0]->sort(a, 12);
	printArray(a, 12);
	
	cout << endl;
	
	sortArray[1]->sort(a, 12);
	printArray(a, 12);
}

void printArray(int* a, int size)
{
	for (int i = 0; i < size; i++)
	{
		cout << a[i] << " ";
	}
}
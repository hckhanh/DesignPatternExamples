#include <iostream>
using namespace std;

class SortTemplateMethod
{
public:
	void sort(int* a, int n)
	{
		for (int i = 0; i < n - 1; i++)
		{
			for (int j = i + 1; j < n; j++)
			{
				if (isOrdered(a[i], a[j]))
				{
					swap(a[i], a[j]);
				}
			}
		}
	}

private:
	virtual bool isOrdered(int a, int b) = 0;
};

class SortAscending : public SortTemplateMethod
{
	bool isOrdered(int a, int b)
	{
		return a < b;
	}
};

class SortDescending : public SortTemplateMethod
{
	bool isOrdered(int a, int b)
	{
		return a > b;
	}
};
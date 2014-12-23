#include <list>
using namespace std;

class A
{
public:
	
};

void main()
{
	list<A*> a;// = new list<A>();
	A* aa;
	a.push_back(aa);


	list<A*> b;// = new list<A>();
	A* bb;
	b.push_back(bb);

	a.merge(b);

}
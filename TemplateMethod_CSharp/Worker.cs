using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_CSharp
{
    abstract class Worker
    {
        public void DailyRoutine()
        {
            getUp();
            eatBreakFast();
            goToWork();
            work();
            goHome();
            eatDinner();
            relax();
            sleep();
        }

        protected virtual void sleep()
        {
            Console.WriteLine("sleep");
        }

        protected virtual  void relax()
        {
            Console.WriteLine("relax");
        }

        protected virtual  void eatDinner()
        {
            Console.WriteLine("eatDinner");
        }

        protected virtual  void goHome()
        {
            Console.WriteLine("goHome");
        }

        protected virtual  void work()
        {
            Console.WriteLine("work");
        }

        protected virtual  void goToWork()
        {
            Console.WriteLine("goToWork");
        }

        protected virtual  void eatBreakFast()
        {
            Console.WriteLine("eatBreakFast");
        }

        protected virtual  void getUp()
        {
            Console.WriteLine("getUp");
        }
    }
}

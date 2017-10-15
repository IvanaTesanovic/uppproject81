using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace UppProject81
{

    class Program
    {
        static void Main(string[] args)
        {
            Activity testing = new UppProcess();
            WorkflowInvoker.Invoke(testing);

            Console.ReadLine();
        }
    }
}

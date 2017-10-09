using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using Activities.Model;

namespace UppProject81
{

    class Program
    {
        static void Main(string[] args)
        {
            //Activity process = new UppProcess();
            //WorkflowInvoker.Invoke(process);

            Activity testing = new DocumentationAndReportActivity();
            WorkflowInvoker.Invoke(testing);

            Console.ReadLine();
        }
    }
}

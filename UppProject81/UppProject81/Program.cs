using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using Microsoft.Activities.Extensions.Tracking;

namespace UppProject81
{
    public class Program
    {
        static void Main(string[] args)
        {
            Activity testing = new Process81();

            WorkflowApplication app = new WorkflowApplication(testing);
            var tracker = new StateMachineStateTracker(app.WorkflowDefinition);
            app.Extensions.Add(tracker);



            //WorkflowInvoker.Invoke(app);
            app.Run();

            Console.WriteLine(tracker.CurrentState);

            Console.ReadLine();
        }
    }
}

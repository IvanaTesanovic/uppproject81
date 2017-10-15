using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace Activities.Custom
{
    public sealed class DokumentacijaActivity : CodeActivity
    {
        public OutArgument<bool> PodnesenaDokumentacija { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            PodnesenaDokumentacija.Set(context, true);
        }
    }
}

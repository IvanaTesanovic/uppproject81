using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace Activities.Custom
{
    public sealed class DocumentationActivity : CodeActivity
    {
        public OutArgument<bool> IsDocumentationFiled { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            //context.SetValue(IsDocumentationFiled, false);
            IsDocumentationFiled.Set(context, true);
        }
    }
}

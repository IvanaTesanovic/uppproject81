using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Custom
{
    public class OdobravanjeIzvestajaNNVece : CodeActivity
    {
        public OutArgument<bool> OdobrenIzvestajNNVece { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            OdobrenIzvestajNNVece.Set(context, true);
        }
    }
}

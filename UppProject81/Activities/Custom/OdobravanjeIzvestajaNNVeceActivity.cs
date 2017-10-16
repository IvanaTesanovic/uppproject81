using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Custom
{
    public class OdobravanjeIzvestajaNNVeceActivity : CodeActivity
    {
        public OutArgument<string> OdobrenIzvestajNNVece { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            OdobrenIzvestajNNVece.Set(context, "Da");
        }
    }
}

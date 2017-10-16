using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Custom
{
    public class RazmatranjeIzvestajaOOceniActivity : CodeActivity
    {
        public OutArgument<string> IzvestajUsvojen { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            IzvestajUsvojen.Set(context, "Da");
        }
    }
}

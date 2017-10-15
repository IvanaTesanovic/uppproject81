using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Custom
{
    public class OdobravanjeIzvestajaUniverzitet : CodeActivity
    {
        public OutArgument<bool> OdobrenIzvestajUniverzitet { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            OdobrenIzvestajUniverzitet.Set(context, false);
        }
    }
}

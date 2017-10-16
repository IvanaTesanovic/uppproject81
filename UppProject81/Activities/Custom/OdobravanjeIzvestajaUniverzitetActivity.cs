using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Custom
{
    public class OdobravanjeIzvestajaUniverzitetActivity : CodeActivity
    {
        public OutArgument<string> OdobrenIzvestajUniverzitet { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            OdobrenIzvestajUniverzitet.Set(context, "Ne");
        }
    }
}

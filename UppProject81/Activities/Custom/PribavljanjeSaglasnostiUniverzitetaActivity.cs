using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Custom
{
    public class PribavljanjeSaglasnostiUniverzitetaActivity : CodeActivity
    {
        public OutArgument<string> SaglasanUniverzitet { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            SaglasanUniverzitet.Set(context, "Da");
        }
    }
}

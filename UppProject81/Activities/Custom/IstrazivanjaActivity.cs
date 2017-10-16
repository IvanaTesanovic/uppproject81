using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Custom
{
    public class IstrazivanjaActivity : CodeActivity
    {
        public OutArgument<string> PotrebnoProduzenjeRokaZaIstrazivanja { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            //doktorant ovde odlucuje da li mu treba produzenje roka za istrazivanja
            PotrebnoProduzenjeRokaZaIstrazivanja.Set(context, "Da");
        }
    }
}

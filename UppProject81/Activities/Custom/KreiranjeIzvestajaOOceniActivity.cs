using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Custom
{
    public class KreiranjeIzvestajaOOceniActivity : CodeActivity
    {
        public OutArgument<int> OcenaDoktorata { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            OcenaDoktorata.Set(context, 6);
        }
    }
}

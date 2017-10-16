using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Custom
{
    public class OdobravanjeDodatnihIstrazivanjaActivity : CodeActivity
    {
        public OutArgument<string> OdobrenaDodatnaIstrazivanja { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            OdobrenaDodatnaIstrazivanja.Set(context, "Ne");
        }
    }
}

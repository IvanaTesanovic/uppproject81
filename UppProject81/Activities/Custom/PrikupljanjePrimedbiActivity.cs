using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Custom
{
    public class PrikupljanjePrimedbiActivity : CodeActivity
    {
        public OutArgument<bool> PrihvacenePrimedbe { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            PrihvacenePrimedbe.Set(context, true);
        }
    }
}

using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Custom
{
    public class OdlucivanjeOOdbraniActivity : CodeActivity
    {
        public OutArgument<bool> OdlozenaOdbrana { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            OdlozenaOdbrana.Set(context, false);
        }
    }
}

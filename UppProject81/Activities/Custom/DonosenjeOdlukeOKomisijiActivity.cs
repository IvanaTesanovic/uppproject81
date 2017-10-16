using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Custom
{
    public class DonosenjeOdlukeOKomisijiActivity : CodeActivity
    {
        public OutArgument<string> OdobrenaKomisija { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            OdobrenaKomisija.Set(context, "Ne");
        }
    }
}

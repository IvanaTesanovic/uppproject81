using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Custom
{
    public class UklanjanjeNedostatakaActivity : CodeActivity
    {
        public OutArgument<bool> MoguceUklanjanjeNedostataka { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            MoguceUklanjanjeNedostataka.Set(context, false);
        }
    }
}

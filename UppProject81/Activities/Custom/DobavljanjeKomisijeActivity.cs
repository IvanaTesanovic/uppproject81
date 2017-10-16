using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Custom
{
    public class DobavljanjeKomisijeActivity : CodeActivity
    {
        public OutArgument<string> MentorSprecen { get; set; }
        public OutArgument<int> BrojSprecenihClanovaKomisije { get; set; }
        public OutArgument<string> PotrebnaIzmenaKomisije { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            PotrebnaIzmenaKomisije.Set(context, "Ne");
            MentorSprecen.Set(context, "Ne");
            BrojSprecenihClanovaKomisije.Set(context, 2);
        }
    }
}

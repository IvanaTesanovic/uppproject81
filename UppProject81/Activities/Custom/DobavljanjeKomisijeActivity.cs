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
        public OutArgument<bool> MentorSprecen { get; set; }
        public OutArgument<int> BrojSprecenihClanovaKomisije { get; set; }
        public OutArgument<bool> PotrebnaIzmenaKomisije { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            PotrebnaIzmenaKomisije.Set(context, false);
            //ako je potrebna izmena komisije?
            MentorSprecen.Set(context, false);
            BrojSprecenihClanovaKomisije.Set(context, 2);
        }
    }
}

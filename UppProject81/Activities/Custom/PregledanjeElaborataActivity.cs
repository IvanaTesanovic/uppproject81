using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Custom
{
    public class PregledanjeElaborataActivity : CodeActivity
    {
        public OutArgument<string> PotrebnaDopunaIstrazivanja { get; set; }
        public OutArgument<string> ZavrsenElaborat { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            //na formi mozda tipa da stavimo da li je potrebna dopuna istrazivanja
            //ako jeste, automatski stavimo da elaborat nije zavrsen i da je odobrena dopuna
            //ako nije potrebna dopuna, mozemo naknado da pitamo da li se obustavlja doktorat, odn da li je zavrsen elaborat ili ne

            PotrebnaDopunaIstrazivanja.Set(context, "Da");
            ZavrsenElaborat.Set(context, "Ne");
        }
    }
}

using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppApplication.Helpers;

namespace Activities.Custom
{
    public class JavljanjeNNVecuOObustavljanju : CodeActivity
    {
        protected override void Execute(CodeActivityContext context)
        {
            EmailHelper emailHelper = new EmailHelper();
            emailHelper.SendEmail("Obustavljanje doktorata", "Doktorat je obustavljen usled lose ocene kod pregledanja Elaborata", "mentor@gmail.com", "nnvece@gmail.com");
        }
    }
}

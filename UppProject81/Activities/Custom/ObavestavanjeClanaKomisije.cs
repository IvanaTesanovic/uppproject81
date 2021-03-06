﻿using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppApplication.Helpers;

namespace Activities.Custom
{
    public class ObavestavanjeClanaKomisije : CodeActivity
    {
        public InArgument<string> Imejl { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            EmailHelper emailHelper = new EmailHelper();
            emailHelper.SendEmail("Poziv za Komisiju za ocenu", "Postovani, pozvani ste da budete deo Komisije za ocenu za odbranu doktorske disertacije.", "mentor@gmail.com", Imejl.Get(context));
        }
    }
}

using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppApplication.Forms;

namespace Activities.Custom
{
    public class UklanjanjeNedostatakaActivity : CodeActivity
    {
        private CodeActivityContext ActContext;
        private YesNoForm form;

        public OutArgument<string> MoguceUklanjanjeNedostataka { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            ActContext = context;
            form = new YesNoForm();
            form.btnYes.Click += new EventHandler(ClickBtnYes);
            form.btnNo.Click += new EventHandler(ClickBtnNo);
            form.labelQuestion.Text = "Da li je moguce ukloniti nedostatke?";
            form.ShowDialog();
        }

        private void ClickBtnYes(object sender, EventArgs a)
        {
            ClickIt("Da");
        }

        private void ClickBtnNo(object sender, EventArgs a)
        {
            ClickIt("Ne");
        }

        private void ClickIt(string value)
        {
            MoguceUklanjanjeNedostataka.Set(ActContext, value);
            form.Close();
        }
    }
}

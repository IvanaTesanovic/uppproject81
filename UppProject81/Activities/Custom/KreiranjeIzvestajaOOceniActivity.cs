using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppApplication.Forms;

namespace Activities.Custom
{
    public class KreiranjeIzvestajaOOceniActivity : CodeActivity
    {
        private CodeActivityContext ActContext;
        private TextboxForm form;

        public OutArgument<int> OcenaDoktorata { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            ActContext = context;
            form = new TextboxForm();
            form.label1.Text = "Ocena Doktorata:";
            form.btnOk.Click += new EventHandler(ClickBtn);
            form.ShowDialog();
        }

        private void ClickBtn(object sender, EventArgs a)
        {
            ClickIt();
        }

        private void ClickIt()
        {
            OcenaDoktorata.Set(ActContext, int.Parse(form.textBox1.Text));
            form.Close();
        }
    }
}

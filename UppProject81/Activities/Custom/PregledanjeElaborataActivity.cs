using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppApplication.Forms;

namespace Activities.Custom
{
    public class PregledanjeElaborataActivity : CodeActivity
    {
        private CodeActivityContext ActContext;
        private ShowHideForm form;

        public OutArgument<string> PotrebnaDopunaIstrazivanja { get; set; }
        public OutArgument<string> ZavrsenElaborat { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            ActContext = context;
            form = new ShowHideForm();
            form.button1.Click += new EventHandler(ClickBtn1);
            form.button2.Click += new EventHandler(ClickBtn2);
            form.button2.Visible = false;
            form.checkBox2.Visible = false;
            form.label2.Visible = false;
            form.ShowDialog();
        }

        private void ClickBtn1(object sender, EventArgs a)
        {
            if (form.checkBox1.Checked)
            {
                PotrebnaDopunaIstrazivanja.Set(ActContext, "Da");
                ZavrsenElaborat.Set(ActContext, "Ne");
                form.Close();
            }
            else
            {
                form.button2.Visible = true;
                form.checkBox2.Visible = true;
                form.label2.Visible = true;
            }
        }

        private void ClickBtn2(object sender, EventArgs a)
        {
            PotrebnaDopunaIstrazivanja.Set(ActContext, "Ne");
            ZavrsenElaborat.Set(ActContext, form.checkBox2.Checked ? "Da" : "Ne");
            form.Close();
        }
    }
}

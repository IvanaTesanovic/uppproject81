using System;
using System.Activities;
using UppApplication.Forms;

namespace Activities.Custom
{
    public class DobavljanjeKomisijeActivity : CodeActivity
    {
        private CodeActivityContext ActContext;
        private ReportForm form;

        public OutArgument<string> MentorSprecen { get; set; }
        public OutArgument<int> BrojSprecenihClanovaKomisije { get; set; }
        public OutArgument<string> PotrebnaIzmenaKomisije { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            //prvo pitam da li je potrebna izmena komisije pa ako nije, tek onda ova druga dva (setujem na "" i 0)
            ActContext = context;
            form = new ReportForm();
            form.button1.Click += new EventHandler(ClickBtnYes);
            form.button2.Click += new EventHandler(ClickBtnNo);
            form.button3.Click += new EventHandler(Submit);
            SetVisibility(false);
            form.ShowDialog();
        }

        private void ClickBtnYes(object sender, EventArgs a)
        {
            ClickIt("Da");
            MentorSprecen.Set(ActContext, "");
            BrojSprecenihClanovaKomisije.Set(ActContext, -1);
            form.Close();
        }

        private void ClickBtnNo(object sender, EventArgs a)
        {
            ClickIt("Ne");
            SetVisibility(true);
        }

        private void ClickIt(string value)
        {
            PotrebnaIzmenaKomisije.Set(ActContext, value);
        }

        private void Submit(object sender, EventArgs a)
        {
            MentorSprecen.Set(ActContext, form.checkBox1.Checked ? "Da" : "Ne");
            BrojSprecenihClanovaKomisije.Set(ActContext, string.IsNullOrEmpty(form.textBox1.Text) ? 0 : int.Parse(form.textBox1.Text));
            form.Close();
        }

        private void SetVisibility(bool isVisible)
        {
            form.label2.Visible = isVisible;
            form.label3.Visible = isVisible;
            form.checkBox1.Visible = isVisible;
            form.textBox1.Visible = isVisible;
            form.button3.Visible = isVisible;
        }
    }
}
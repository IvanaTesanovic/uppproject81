using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Windows.Forms;
using UppApplication.Forms;

namespace Activities.Custom
{
    public sealed class DokumentacijaActivity : CodeActivity
    {
        private CodeActivityContext ActContext;
        private DocumentationForm form;

        public OutArgument<string> PodnesenaDokumentacija { get; set; }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override void Execute(CodeActivityContext context)
        {
            ActContext = context;
            form = new DocumentationForm();
            form.ShowDialog();
            form.okButton.Click += new EventHandler(ClickBtn);
        }

        private void ClickBtn(object sender, EventArgs a)
        {
            ClickIt();
        }

        private void ClickIt()
        {
            PodnesenaDokumentacija.Set(ActContext, form.cboxDocSubmitted.Checked ? "Da" : "Ne");
            form.Close();
        }
    }
}

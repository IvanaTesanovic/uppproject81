using Data.DataProviders;
using Data.Entities;
using System;
using System.Activities;
using System.Collections.Generic;
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
            form.okButton.Click += new EventHandler(ClickBtn);
            form.ShowDialog();

            var chief = GetDepartmentChief(form.textBox1.Text);
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

        private User GetDepartmentChief(string departmentName)
        {
            Department department = new DepartmentDataProvider().GetByName(departmentName);
            List<User> users = new UserDataProvider().GetUserByRole("Sef");
            User chief = new User();

            foreach (var user in users)
            {
                if (user.DepartmentId == department.Id)
                {
                    chief = user;
                    break;
                }
            }

            return chief;
        }
    }
}
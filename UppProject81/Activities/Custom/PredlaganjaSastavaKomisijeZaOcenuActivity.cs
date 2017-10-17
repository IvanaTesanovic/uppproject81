using Data.Entities;
using System;
using System.Activities;
using System.Collections.Generic;
using UppApplication.Forms;

namespace Activities.Custom
{
    public class PredlaganjaSastavaKomisijeZaOcenuActivity : CodeActivity
    {
        private CodeActivityContext ActContext;
        private MembersForm form;
        private List<Member> Members = new List<Member>();

        public OutArgument<Member[]> KomisijaZaOcenu { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            ActContext = context;
            form = new MembersForm();

            form.okButton.Click += new EventHandler(ClickBtn);
            form.ShowDialog();
        }

        private void ClickBtn(object sender, EventArgs a)
        {
            ClickIt();
        }

        private void ClickIt()
        {
            Members.Clear();
            InitializeMembers();
            KomisijaZaOcenu.Set(ActContext, Members.ToArray());
            form.Close();
        }

        private void InitializeMembers()
        {
            var ime1 = form.textBox1.Text;
            var imejl1 = form.textBox2.Text;

            var ime2 = form.textBox4.Text;
            var imejl2 = form.textBox3.Text;

            var ime3 = form.textBox6.Text;
            var imejl3 = form.textBox5.Text;

            var ime4 = form.textBox8.Text;
            var imejl4 = form.textBox7.Text;

            var ime5 = form.textBox10.Text;
            var imejl5 = form.textBox9.Text;

            AddMember(ime1, imejl1);
            AddMember(ime2, imejl2);
            AddMember(ime3, imejl3);
            AddMember(ime4, imejl4);
            AddMember(ime5, imejl5);
        }

        private void AddMember(string name, string email)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email))
            {
                Member member = new Member
                {
                    Name = name,
                    Email = email
                };

                Members.Add(member);
            }
        }
    }
}
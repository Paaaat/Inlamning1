using Inlamning1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Inlamning1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Personer> listPersoner = new List<Personer>();
        private Personer Contact = new Personer();

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new PersonerContext())
            {
                Fill();
                Info();
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            using (var context = new PersonerContext())
            {
                Random rnd = new Random();
                int i = rnd.Next(1, 100000);
                Personer newPerson = new Models.Personer { Namn = txtNamn.Text + "                                                    " + i, Gatuadress = txtGatuadress.Text, Postnummer = txtPostnummer.Text, Postort = txtPostort.Text, Telefon = txtTelefon.Text, Epost = txtEpost.Text, Födelsedag = txtFödelsedag.Text };
                context.Folk.Add(newPerson);
                context.SaveChanges();
            }

            Fill();
        }

        private void Fill()
        {
            using (var context = new PersonerContext())
            {
                var Person = context.Folk.Select(s => s);
                lstPersoner.Items.Clear();
                foreach (var item in Person)
                {
                    listPersoner.Add(item);
                    lstPersoner.Items.Add(item.Namn);
                }
            }
        }

        private void Sok()
        {
            var itemList = lstPersoner.Items.Cast<string>().ToList();
            if (itemList.Count > 0)
            {
                lstPersoner.Items.Clear();
                lstPersoner.Items.AddRange(
                    itemList.Where(i => i.Contains(txtSok.Text)).ToArray());
            }
            if (txtSok.Text == "")
            {
                Fill();
            }
        }

        private void txtSok_TextChanged(object sender, EventArgs e)
        {
            Sok();
        }

        private void lstPersoner_SelectedIndexChanged(object sender, EventArgs e)
        {
            Info();
        }

        private void Info()
        {
            using (var cmd = new PersonerContext())
            {
                string SelectedName = lstPersoner.GetItemText(lstPersoner.SelectedItem);
                Contact = cmd.Folk.Where(c => c.Namn == SelectedName).FirstOrDefault<Personer>();
            }
            if (Contact != null)
            {
                Dataview.Rows[0].Cells[0].Value = Contact.PersonerId;
                Dataview.Rows[0].Cells[1].Value = Contact.Namn;
                Dataview.Rows[0].Cells[2].Value = Contact.Gatuadress;
                Dataview.Rows[0].Cells[3].Value = Contact.Postnummer;
                Dataview.Rows[0].Cells[4].Value = Contact.Postort;
                Dataview.Rows[0].Cells[5].Value = Contact.Telefon;
                Dataview.Rows[0].Cells[6].Value = Contact.Epost;
                Dataview.Rows[0].Cells[7].Value = Contact.Födelsedag;

                txtNamn.Text = Contact.Namn;
                txtGatuadress.Text = Contact.Gatuadress;
                txtPostnummer.Text = Contact.Postnummer;
                txtPostort.Text = Contact.Postort;
                txtTelefon.Text = Contact.Telefon;
                txtEpost.Text = Contact.Epost;
                txtFödelsedag.Text = Contact.Födelsedag;
            }
        }

        private void Edit()
        {
            using (var cmd = new PersonerContext())
            {
                string SelectedName = lstPersoner.GetItemText(lstPersoner.SelectedItem);

                Contact = cmd.Folk.Where(c => c.Namn == SelectedName).FirstOrDefault<Personer>();
            }
            if (Contact != null)
            {
                Contact.Namn = txtNamn.Text;
                Contact.Gatuadress = txtGatuadress.Text;
                Contact.Postnummer = txtPostnummer.Text;
                Contact.Postort = txtPostort.Text;
                Contact.Telefon = txtTelefon.Text;
                Contact.Epost = txtEpost.Text;
                Contact.Födelsedag = txtFödelsedag.Text;

                using (var e = new PersonerContext())
                {
                    e.Entry(Contact).State = System.Data.Entity.EntityState.Modified;
                    e.SaveChanges();
                    Fill();
                    Info();
                }
            }
        }

        private void cmdUppdatera_Click(object sender, EventArgs e)
        {
            Edit();
            if (lstPersoner.Items.Count > 0)
            {
                int index = lstPersoner.FindString(txtNamn.Text);
                if (index != -1)
                    lstPersoner.SetSelected(index, true);
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            string SelectedName = lstPersoner.GetItemText(lstPersoner.SelectedItem);
            Personer tabort;

            using (var ctx = new PersonerContext())
            {
                tabort = ctx.Folk.Where(c => c.Namn == SelectedName).FirstOrDefault<Personer>();
            }

            using (var newContext = new PersonerContext())
            {
                newContext.Entry(tabort).State = System.Data.Entity.EntityState.Deleted;

                newContext.SaveChanges();
            }
            Fill();
            Info();
            Dataview.Rows.Clear();
            txtNamn.Text = "";
            txtGatuadress.Text = "";
            txtPostnummer.Text = "";
            txtPostort.Text = "";
            txtTelefon.Text = "";
            txtEpost.Text = "";
            txtFödelsedag.Text = "";
        }
    }
}
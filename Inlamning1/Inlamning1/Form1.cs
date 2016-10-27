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
        private Personer selectedPerson = new Personer();

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new PersonerContext())
            {
                Fill();
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            using (var context = new PersonerContext())
            {
                Personer newPerson = new Models.Personer { Namn = txtNamn.Text, Gatuadress = txtGatuadress.Text, Postnummer = txtPostnummer.Text, Postort = txtPostort.Text, Telefon = txtTelefon.Text, Epost = txtEpost.Text, Födelsedag = txtFödelsedag.Text };
                context.Folk.Add(newPerson);
                context.SaveChanges();
            }
            listPersoner.Clear();
            lstPersoner.Items.Clear();            
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
            if (!string.IsNullOrEmpty(txtSok.Text))
            {
                using (var context = new PersonerContext())
                {
                    listPersoner = context.Folk.Where(c => c.Namn.ToLower().Contains(txtSok.Text.ToLower())).ToList();
                    lstPersoner.Items.Clear();
                    foreach (var item in listPersoner)
                    {
                        lstPersoner.Items.Add(item);
                    }
                }
            }
            else
                txtSok.Text = "";
        }

        private void txtSok_TextChanged(object sender, EventArgs e)
        {
            Sok();
        }

        private void lstPersoner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPersoner.SelectedItem != null)
            {
                Dataview.Rows[0].Cells[0].Value = listPersoner[lstPersoner.SelectedIndex].PersonerId;
                Dataview.Rows[0].Cells[1].Value = listPersoner[lstPersoner.SelectedIndex].Namn;
                Dataview.Rows[0].Cells[2].Value = listPersoner[lstPersoner.SelectedIndex].Gatuadress;
                Dataview.Rows[0].Cells[3].Value = listPersoner[lstPersoner.SelectedIndex].Postnummer;
                Dataview.Rows[0].Cells[4].Value = listPersoner[lstPersoner.SelectedIndex].Postort;
                Dataview.Rows[0].Cells[5].Value = listPersoner[lstPersoner.SelectedIndex].Telefon;
                Dataview.Rows[0].Cells[6].Value = listPersoner[lstPersoner.SelectedIndex].Epost;
                Dataview.Rows[0].Cells[7].Value = listPersoner[lstPersoner.SelectedIndex].Födelsedag;

                txtNamn.Text = listPersoner[lstPersoner.SelectedIndex].Namn;
                txtGatuadress.Text = listPersoner[lstPersoner.SelectedIndex].Gatuadress;
                txtPostnummer.Text = listPersoner[lstPersoner.SelectedIndex].Postnummer;
                txtPostort.Text = listPersoner[lstPersoner.SelectedIndex].Postort;
                txtTelefon.Text = listPersoner[lstPersoner.SelectedIndex].Telefon;
                txtEpost.Text = listPersoner[lstPersoner.SelectedIndex].Epost;
                txtFödelsedag.Text = listPersoner[lstPersoner.SelectedIndex].Födelsedag;
            }
        }

        private void cmdUppdatera_Click(object sender, EventArgs e)
        {
            if (lstPersoner.SelectedItem != null)
            {
                Personer SelectedName = listPersoner[lstPersoner.SelectedIndex];
                SelectedName.Namn = txtNamn.Text;
                SelectedName.Gatuadress = txtGatuadress.Text;
                SelectedName.Postnummer = txtPostnummer.Text;
                SelectedName.Postort = txtPostort.Text;
                SelectedName.Telefon = txtTelefon.Text;
                SelectedName.Epost = txtEpost.Text;
                SelectedName.Födelsedag = txtFödelsedag.Text;

                using (var f = new PersonerContext())
                {
                    f.Entry(SelectedName).State = System.Data.Entity.EntityState.Modified;
                    f.SaveChanges();
                }
            }
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            txtSok.Text = "";
            Personer SelectedName = listPersoner[lstPersoner.SelectedIndex];
            using (var newContext = new PersonerContext())
            {
                newContext.Entry(SelectedName).State = System.Data.Entity.EntityState.Deleted;

                newContext.SaveChanges();
            }
            listPersoner.Clear();
            lstPersoner.Items.Clear();
            Fill();
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
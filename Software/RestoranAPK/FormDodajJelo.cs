﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funkcionalnost_prijave
{
    public partial class FormDodajJelo : Form
    {
        public User LogiraniKorisnik { get; set; }
        public List<string> ListaVrstaJela { get; set; }
        public FormDodajJelo(User korisnik)
        {
            InitializeComponent();
            LogiraniKorisnik = korisnik;
        }

        

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDodajJelo_Load(object sender, EventArgs e)
        {
            comboBoxVrstaJela.DataSource = DohvatiVrsteJela();
        }

        private object DohvatiVrsteJela()
        {
            using (var context = new EntitiesOrder())
            {
                ListaVrstaJela = new List<string>();
                foreach (var item in context.ProductTypes)
                {
                    ListaVrstaJela.Add(item.VrstaJela);
                }
                return ListaVrstaJela;
            }
        }

        private void FormDodajJelo_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Pomoc();
        }
        private void Pomoc()
        {
            string help = Path.Combine(new Uri(Path.GetDirectoryName
           (System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath, "help.chm");
            helpProvider1.HelpNamespace = help;
            Help.ShowHelp(this, help, HelpNavigator.KeywordIndex, "Naslovnica");
        }

       

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            using (var context = new EntitiesBills())
            {
                int id = 0;
                foreach (var item in context.Meals)
                {
                    if (id < item.IDJela)
                    {
                        id = item.IDJela;
                    }
                }
                id = id + 1;
                Meal novoJelo = new Meal
                {
                    IDJela = id,
                    Naziv = textBoxNaziv.Text,
                    Opis = richTextBoxOpis.Text,
                    Cijena = textBoxCijena.Text,
                    Restoran = (int)LogiraniKorisnik.Restaurant,
                    Vrsta = comboBoxVrstaJela.Text
                };
                context.Meals.Add(novoJelo);
                context.SaveChanges();
            }
            Close();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

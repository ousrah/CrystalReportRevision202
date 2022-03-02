using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrystalReportRevision202
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyLibrary.imprimer(new lstProduits());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string chemain = Application.StartupPath + @"\photos\";
            string filtre = "{produit.designation_produit} like '*" + textBox1.Text + "*'";
            MyLibrary.imprimer(new ficherProduit(), filtre, chemain);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyLibrary.imprimer(new etiquettes());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyLibrary.imprimer(new PrdParCat());
        }

        private void button5_Click(object sender, EventArgs e)
        {

            MyLibrary.imprimer(new CrystalReport1());
        }

        private void button6_Click(object sender, EventArgs e)
        {
        
            string filtre = "{commande.id_commande} = " + textBox2.Text ;
            MyLibrary.imprimer(new facture(), filtre);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MyLibrary.imprimer(new facture());
        }
    }
}

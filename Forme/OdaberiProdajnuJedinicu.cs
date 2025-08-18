using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class OdaberiProdajnuJedinicu : Form
    {
        public OdaberiProdajnuJedinicu()
        {
            InitializeComponent();
        }

        private void ProdajnaJedinica_Click(object sender, EventArgs e)
        {
            ProdajnaJedinicaForm form = new ProdajnaJedinicaForm();
            form.ShowDialog();

        }

        private void ApotekaSaLab_Click(object sender, EventArgs e)
        {
            ApotekaSaLabForm form = new ApotekaSaLabForm();
            form.ShowDialog();
        }

        private void StandardnaApoteka_Click(object sender, EventArgs e)
        {
            StandardnaApotekaForm form = new StandardnaApotekaForm();
            form.ShowDialog();
        }

        private void SpecijalizovanaApoteka_Click(object sender, EventArgs e)
        {
            SpecijalizovanaApotekaForm form = new SpecijalizovanaApotekaForm();
            form.ShowDialog();
        }

        private void OdaberiProdajnuJedinicu_Load(object sender, EventArgs e)
        {

        }
    }
}

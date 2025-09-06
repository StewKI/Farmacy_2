using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacy.Forme;

namespace Farmacy
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

        private void PocetnaStranica_Load(object sender, EventArgs e)
        {

        }

        private void btnProdajneJedinice_Click(object sender, EventArgs e)
        {
            ProdajnaJedinicaAdminForm form = new ProdajnaJedinicaAdminForm();
            form.ShowDialog();
        }

        private void btnDistributeri_Click(object sender, EventArgs e)
        {
            DistributerAdminForm form = new DistributerAdminForm();
            form.ShowDialog();
        }

        private void btnProizvodjaci_Click(object sender, EventArgs e)
        {
            ProizvodjacAdminForm form = new ProizvodjacAdminForm();
            form.ShowDialog();
        }

        private void btnLekovi_Click(object sender, EventArgs e)
        {
            LekAdminForm form = new LekAdminForm();
            form.ShowDialog();
        }
    }
}

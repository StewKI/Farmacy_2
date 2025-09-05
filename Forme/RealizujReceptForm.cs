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
    public partial class RealizujReceptForm : Form
    {
        ProdajnaJedinicaBasic p;
        public RealizujReceptForm(ProdajnaJedinicaBasic p)
        {
            InitializeComponent();
            this.p = p;
            load1();
        }

        public void load1()
        {
            txtFarmaceut.Text = p.OdgovorniFarmaceutMbr.ToString();
            txtProdajnaJedinica.Text = p.Id.ToString();
        }

        private void RealizujReceptForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            string id = (txtRecept.Text);
            DateTime d=dtpDatum.Value;

            DTOManagerIsporukeZalihe.RealizujRecept(id, p, d);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

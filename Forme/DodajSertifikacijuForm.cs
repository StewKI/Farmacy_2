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
    public partial class DodajSertifikacijuForm : Form
    {
        TehnicarBasic t;

        public DodajSertifikacijuForm(TehnicarBasic t)
        {
            InitializeComponent();
            this.t = t;

        }

        private void lblPrezime_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveS();

        }

        private void SaveS()
        {
            TehnicarSertifikacijaBasic ts = new TehnicarSertifikacijaBasic();
            ts.Datum = dtpDatumS.Value;
            ts.Naziv = txtNaziv.Text;
            t.Sertifikacije.Add(ts);
        }

        private void DodajSertifikacijuForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

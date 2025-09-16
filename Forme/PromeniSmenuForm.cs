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
    public partial class PromeniSmenuForm : Form
    {
        long mbr;
        public PromeniSmenuForm(long mbr)
        {
            InitializeComponent();
            this.mbr = mbr;
            var items = new[]
                                {
                                    new { Text = "Prva",  Value = 1 },
                                    new { Text = "Druga", Value = 2 },
                                    new { Text = "Treća", Value = 3 }
                                }.ToList();

            cmbSmena.DisplayMember = "Text";

            cmbSmena.ValueMember = "Value";
            cmbSmena.DataSource = items;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sacuvaj();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void sacuvaj()
        {
            int smena = (int)cmbSmena.SelectedValue;
            DateTime d = dtpDatum.Value;




            DTOManagerZaposleni.IzmeniSmenu(mbr, d, smena);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

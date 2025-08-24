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
    public partial class OdaberiZaposlenogForm : Form
    {
        public OdaberiZaposlenogForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FarmaceutForm form = new FarmaceutForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZaposleniForm fomra = new ZaposleniForm();
            fomra.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenadzerForm form = new MenadzerForm();
            form.ShowDialog();
        }

        private void OdaberiZaposlenogForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TehnicarForm form = new TehnicarForm();
            form.ShowDialog();
        }
    }
}

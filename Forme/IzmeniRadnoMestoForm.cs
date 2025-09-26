using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Farmacy.Forme
{
    public partial class IzmeniRadnoMestoForm : Form
    {
        RasporedRadaBasic r;
        public IzmeniRadnoMestoForm(RasporedRadaBasic r1)
        {
            InitializeComponent();
            this.r = r1;

            ucitaj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long idP = (long)cmbNovoR.SelectedValue;
            int smena=(int)cmbSmena.SelectedValue;
            DTOManagerZaposleni.IzmeniRadnoMesto(r.IdZaposlenog, idP, smena);
            DialogResult = DialogResult.OK;
            Close();
        }

        public void ucitaj()
        {
            var p = DTOManagerProdajneJedinice.VratiProdajnuJedinicu(r.ProdajnaJedinicaId);
            var naziv = p.Naziv;

            txtMbr.Text = r.IdZaposlenog.ToString();
            txtRadnoMesto.Text = naziv;

            IList<ProdajnaJedinicaBasic> lista = DTOManagerProdajneJedinice.VratiSveProdajneJedinice() ?? new List<ProdajnaJedinicaBasic>();
            var nazivi = lista
                            .Where(l => l.Naziv != naziv)
                            .Select(l => new { Text = l.Naziv, Value = l.Id })
                            .ToList();
            cmbNovoR.DataSource = nazivi;
            cmbNovoR.DisplayMember = "Text";
            cmbNovoR.ValueMember = "Value";
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
        private void IzmeniRadnoMestoForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

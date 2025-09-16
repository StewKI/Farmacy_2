using System;
using System.Windows.Forms;
using Farmacy;

namespace Farmacy.Forme
{
    public partial class MenadzerApotekaForm : Form
    {
        private MenadzerApotekaBasic menadzerApoteka;
        long idApoteke = 0;
        public MenadzerApotekaForm()
        {
            InitializeComponent();
            menadzerApoteka = new MenadzerApotekaBasic();
            LoadMenadzerApotekaData();
        }

        public MenadzerApotekaForm(MenadzerApotekaBasic menadzerApoteka)
        {
            InitializeComponent();
            this.menadzerApoteka = menadzerApoteka;
            LoadMenadzerApotekaData();
        }

        public MenadzerApotekaForm(long id)
        {
            InitializeComponent();
            menadzerApoteka = new MenadzerApotekaBasic();
            idApoteke = id;
            LoadMenadzerApotekaData();
        }

        private void LoadMenadzerApotekaData()
        {
            IList<MenadzerBasic> lista = DTOManagerProdajneJedinice.VratiSveMenadzereUSistemu() ?? new List<MenadzerBasic>();
            var nazivi = lista.Select(l => new { Text = l.Ime, Value = l.MBr }).ToList();
       
        
            comboBox1.DataSource = nazivi;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
           

            //if (menadzerApoteka.ProdajnaJedinica != null)
            //    txtProdajnaJedinicaId.Text = menadzerApoteka.ProdajnaJedinica.Id.ToString();

            txtProdajnaJedinicaId.Text = idApoteke.ToString();
            

            if (menadzerApoteka.Do.HasValue)
                dtpDo.Value = menadzerApoteka.Do.Value;
            else
                chkDo.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                SaveMenadzerApoteka();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkDo_CheckedChanged(object sender, EventArgs e)
        {
            dtpDo.Enabled = !chkDo.Checked;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("ID menadžera je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProdajnaJedinicaId.Text))
            {
                MessageBox.Show("ID prodajne jedinice je obavezan!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dtpOd.Value >= dtpDo.Value && !chkDo.Checked)
            {
                MessageBox.Show("Datum 'Od' mora biti pre datuma 'Do'!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void SaveMenadzerApoteka()
        {
            // Napomena: Referentne entitete (Menadzer, ProdajnaJedinica) treba postaviti spolja
            // jer ova forma samo prikazuje ID-ove
            menadzerApoteka.Od = dtpOd.Value;
            menadzerApoteka.Do = chkDo.Checked ? null : dtpDo.Value;
            menadzerApoteka.ProdajnaJedinicaId =idApoteke;
            menadzerApoteka.MBrMenadzera = (long)comboBox1.SelectedValue;
            DTOManagerProdajneJedinice.DodeliMenadzeraApoteci(menadzerApoteka);
        }

        public MenadzerApotekaBasic GetMenadzerApoteka()
        {
            return menadzerApoteka;
        }

        private void MenadzerApotekaForm_Load(object sender, EventArgs e)
        {

        }
    }
}

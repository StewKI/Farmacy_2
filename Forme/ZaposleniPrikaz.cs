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

    public partial class ZaposleniPrikaz : Form
    {
        public ZaposleniPrikaz()
        {
            InitializeComponent();
            this.Load += ZaposleniPrikaz_Load;
        }

        private void ZaposleniPrikaz_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        int brojZaposlenih = 0;
        public void popuniPodacima()
        {
            this.brojZaposlenih = 0;

            try
            {
                // 1) Učitaj podatke
                IList<ZaposleniBasic> lista = DTOManagerZaposleni.VratiSveZaposlene() ?? new List<ZaposleniBasic>();

                // 2) Mapiraj kolone (ako već nisu mapirane)
                dgvZaposleni.AutoGenerateColumns = false;
                if (colMbr != null) colMbr.DataPropertyName = "MBr";         // pazi na veliko B ako je tako u DTO-u
                if (colIme != null) colIme.DataPropertyName = "Ime";
                if (colPrezime != null) colPrezime.DataPropertyName = "Prezime";

                // 3) Veži podatke
                dgvZaposleni.DataSource = false;   // osveži binding
                dgvZaposleni.DataSource = lista;

                // 4) Upis u textbox „Ukupan broj zaposlenih“
                txbBrojZaposlenih.Text = lista.Count.ToString();

                if (dgvZaposleni.Columns.Count == 0)
                {
                    dgvZaposleni.AutoGenerateColumns = false;
                    dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colMbr",
                        HeaderText = "MBr",
                        DataPropertyName = "MBr",
                        Width = 90
                    });
                    dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colIme",
                        HeaderText = "Ime",
                        DataPropertyName = "Ime",
                        Width = 140
                    });
                    dgvZaposleni.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colPrezime",
                        HeaderText = "Prezime",
                        DataPropertyName = "Prezime",
                        Width = 160
                    });
                    //dgvZaposleni.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju zaposlenih:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void ZaposleniPrikaz_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvZaposleni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnObrisiZaposlenog_Click(object sender, EventArgs e)
        {

        }
    }
}

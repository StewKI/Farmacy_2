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
    public partial class OdaberiMenadzeraForm1 : Form
    {
        long id;
        public OdaberiMenadzeraForm1(long id)
        {
            InitializeComponent();
            this.id = id;
            popuniMenadzere();
        }

        private void OdaberiMenadzeraForm1_Load(object sender, EventArgs e)
        {

        }

        public void popuniMenadzere()
        {
            try
            {
                // 1) Učitaj podatke
                IList<MenadzerBasic> lista = DTOManagerProdajneJedinice.VratiMenadzereZaApoteku(id) ?? new List<MenadzerBasic>();
                dgvMenadzeri.RowHeadersVisible = false;
                // 2) Mapiraj kolone (ako već nisu mapirane)
                dgvMenadzeri.AutoGenerateColumns = false;
                if (colMbr != null) colMbr.DataPropertyName = "MBr";
                if (colIme != null) colIme.DataPropertyName = "Ime";
                if (colPrezime != null) colIme.DataPropertyName = "Prezime";


                // 3) Veži podatke
                dgvMenadzeri.DataSource = false;   // osveži binding
                dgvMenadzeri.DataSource = lista;




                if (dgvMenadzeri.Columns.Count == 0)
                {
                    dgvMenadzeri.AutoGenerateColumns = false;
                    dgvMenadzeri.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colMbr",
                        HeaderText = "MBr",
                        DataPropertyName = "MBr",
                        Width = 90
                    });
                    dgvMenadzeri.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colIme",
                        HeaderText = "Ime",
                        DataPropertyName = "Ime",
                        Width = 140
                    });
                    dgvMenadzeri.Columns.Add(new DataGridViewTextBoxColumn
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

        private void button1_Click(object sender, EventArgs e)
        {
            long mbr = 0;
            if (dgvMenadzeri.SelectedRows.Count > 0)
            {
                mbr = Convert.ToInt64(dgvMenadzeri.CurrentRow.Cells[0].Value);
                MessageBox.Show("Selektovan MBr: " + mbr);

            }
            else
            {
                MessageBox.Show("Morate izabrati radnika prvo!");
                return;
            }
            DTOManagerProdajneJedinice.UkloniMenadzeraSaApoteke(id,mbr);
            popuniMenadzere();
        }
    }
}

using Farmacy.Entiteti;
using Farmacy_2.Forme;
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
    public partial class ZaposleniAdminForm : Form
    {
        public int brojZaposlenih = 0;

        public ZaposleniAdminForm()
        {

            InitializeComponent();
            this.Load += ZaposleniPrikazForm_Load;

        }

        private void ZaposleniPrikazForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {


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

        private void groupBoxZaposleni_Enter(object sender, EventArgs e)
        {

        }



        private void btnObrisiZaposlenog_Click(object sender, EventArgs e)
        {
            long mbr = 0;
            if (dgvZaposleni.SelectedRows.Count > 0)
            {
                mbr = Convert.ToInt64(dgvZaposleni.CurrentRow.Cells[0].Value);
                MessageBox.Show("Selektovan MBr: " + mbr);

            }
            else
            {
                MessageBox.Show("Morate izabrati radnika prvo!");
                return;
            }
            DTOManagerZaposleni.ObrisiZaposlenog(mbr);
            popuniPodacima();

        }
        private void btnIzmeniZaposlenog_Click(object sender, EventArgs e)
        {
            if (dgvZaposleni.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati zaposlenog!");
                return;
            }
            long mbr = 0;
            if (dgvZaposleni.SelectedRows.Count > 0)
            {
                mbr = Convert.ToInt64(dgvZaposleni.CurrentRow.Cells[0].Value);
                MessageBox.Show("Selektovan MBr: " + mbr);

            }
            else
            {
                MessageBox.Show("Morate izabrati radnika prvo!");
                return;
            }


            var z = DTOManagerZaposleni.VratiZaposlenog(mbr);
            IzmeniZaposlenogForm form=new IzmeniZaposlenogForm(mbr, 0); // Default prodajnaJedinicaId = 0
            form.ShowDialog();


            popuniPodacima();
        }
        private void btnDodajNovog_Click(object sender, EventArgs e)
        {


            OdaberiZaposlenogForm form = new OdaberiZaposlenogForm();
            form.ShowDialog();
            popuniPodacima();
        }

        private void ZaposleniAdminForm_Load(object sender, EventArgs e)
        {

        }

        public void updatePodatke<T>(IList<T> lista1)
        {
            try
            {

                // 2) Mapiraj kolone (ako već nisu mapirane)
                dgvZaposleni.AutoGenerateColumns = false;
                if (colMbr != null) colMbr.DataPropertyName = "MBr";         // pazi na veliko B ako je tako u DTO-u
                if (colIme != null) colIme.DataPropertyName = "Ime";
                if (colPrezime != null) colPrezime.DataPropertyName = "Prezime";

                // 3) Veži podatke
                dgvZaposleni.DataSource = false;   // osveži binding
                dgvZaposleni.DataSource = lista1;




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



        private void brnPrikaziFarmaceute_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Učitaj podatke
                IList<ZaposleniBasic> lista = DTOManagerZaposleni.VratiSveZaposlene() ?? new List<ZaposleniBasic>();
                IList<FarmaceutBasic> lista1 = new List<FarmaceutBasic>();
                foreach (var l in lista)
                {
                    var m = DTOManagerZaposleni.VratiZaposlenog(l.MBr);
                    if (m is FarmaceutBasic f)
                        lista1.Add(f);
                }
                updatePodatke(lista1);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju zaposlenih:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void brnPrikaziTehnicare_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Učitaj podatke
                IList<ZaposleniBasic> lista = DTOManagerZaposleni.VratiSveZaposlene() ?? new List<ZaposleniBasic>();
                IList<TehnicarBasic> lista1 = new List<TehnicarBasic>();
                foreach (var l in lista)
                {
                    var m = DTOManagerZaposleni.VratiZaposlenog(l.MBr);
                    if (m is TehnicarBasic t)
                        lista1.Add(t);
                }
                updatePodatke(lista1);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju zaposlenih:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrikaziMenadzere_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Učitaj podatke
                IList<ZaposleniBasic> lista = DTOManagerZaposleni.VratiSveZaposlene() ?? new List<ZaposleniBasic>();
                IList<MenadzerBasic> lista1 = new List<MenadzerBasic>();
                foreach (var l in lista)
                {
                    var m = DTOManagerZaposleni.VratiZaposlenog(l.MBr);
                    if (m is MenadzerBasic m1)
                        lista1.Add(m1);
                }
                updatePodatke(lista1);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju zaposlenih:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

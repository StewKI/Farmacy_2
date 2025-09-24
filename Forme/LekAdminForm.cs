using Farmacy.Entiteti;
using Farmacy_2.Forme;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class LekAdminForm : Form
    {
        public int brojLekova = 0;

        public LekAdminForm()
        {
            InitializeComponent();
            this.Load += LekAdminForm_Load;
            SetupButtonEffects();
        }

        private void LekAdminForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaLek();
        }

        public void popuniPodacimaLek()
        {
            try
            {
                IList<LekBasic> lista = DTOManagerLek.VratiSveLekove() ?? new List<LekBasic>();

                dgvLekovi.AutoGenerateColumns = false;
                dgvLekovi.RowHeadersVisible = false;
                dgvLekovi.DataSource = null;
                dgvLekovi.DataSource = lista;

                brojLekova = lista.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju lekova:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnObrisiLek_Click(object sender, EventArgs e)
        {
            if (dgvLekovi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati lek prvo!");
                return;
            }

            long id = Convert.ToInt64(dgvLekovi.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show($"Da li ste sigurni da želite da obrišete lek sa ID: {id}?",
                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DTOManagerLek.ObrisiLek(id);
                popuniPodacimaLek();
            }
        }

        private void btnIzmeniLek_Click(object sender, EventArgs e)
        {
            if (dgvLekovi.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati lek!");
                return;
            }

            long id = Convert.ToInt64(dgvLekovi.CurrentRow.Cells[0].Value);
            var selektovaniLek = DTOManagerLek.VratiLek(id);

            if (selektovaniLek != null)
            {
                LekEditForm form = new LekEditForm(selektovaniLek);
                form.ShowDialog();
                popuniPodacimaLek();
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju podataka o leku!");
            }


        }

        private void btnDodajNoviLek_Click(object sender, EventArgs e)
        {
            LekForm form = new LekForm();
            form.ShowDialog();
            popuniPodacimaLek();
        }

        // --- Dugmad za povezane forme ---

        private void btnDistributeri_Click(object sender, EventArgs e)
        {
            DistributerForm form = new DistributerForm();
            form.ShowDialog();
        }

        private void btnSekundarneKategorije_Click(object sender, EventArgs e)
        {
            if (dgvLekovi.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati lek prvo!");
                return;
            }

            long id = Convert.ToInt64(dgvLekovi.CurrentRow.Cells[0].Value);
            var selektovaniLek = DTOManagerLek.VratiLekEntitet(id);

            if (selektovaniLek != null)
            {
                LekSekundarna lekSekundarna = new LekSekundarna
                {
                    Lek = selektovaniLek
                };

                LekSekundarnaForm form = new LekSekundarnaForm(lekSekundarna);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju leka!");
            }
        }

        private void btnOblik_Click(object sender, EventArgs e)
        {
            OblikForm form = new OblikForm();
            form.ShowDialog();
        }

        private void btnPakovanje_Click(object sender, EventArgs e)
        {
            PakovanjeForm form = new PakovanjeForm();
            form.ShowDialog();
        }

        private void btnPrimarnaGrupa_Click(object sender, EventArgs e)
        {
            PrimarnaGrupaForm form = new PrimarnaGrupaForm();
            form.ShowDialog();
        }

        private void btnProizvodjac_Click(object sender, EventArgs e)
        {
            ProizvodjacForm form = new ProizvodjacForm();
            form.ShowDialog();
        }

        private void btnRecept_Click(object sender, EventArgs e)
        {
            ReceptForm form = new ReceptForm();
            form.ShowDialog();
        }

        private void btnSekundarnaGrupa_Click(object sender, EventArgs e)
        {
            SekundarnaGrupaForm form = new SekundarnaGrupaForm();
            form.ShowDialog();
        }

        private void dgvLekovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void SetupButtonEffects()
        {
            // Dodaj hover efekte za dugmad
            foreach (Control control in panelButtons.Controls)
            {
                if (control is Button button)
                {
                    button.MouseEnter += Button_MouseEnter;
                    button.MouseLeave += Button_MouseLeave;
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Sačuvaj originalnu boju
                button.Tag = button.BackColor;
                
                // Promeni boju na hover
                if (button == btnDodajNoviLek)
                {
                    button.BackColor = Color.FromArgb(155, 89, 182); // Tamnija ljubičasta
                }
                else if (button == btnIzmeniLek)
                {
                    button.BackColor = Color.FromArgb(52, 152, 219); // Tamnija plava
                }
                else if (button == btnObrisiLek)
                {
                    button.BackColor = Color.FromArgb(231, 76, 60); // Tamnija crvena
                }
                else if (button == btnPrimarnaGrupa)
                {
                    button.BackColor = Color.FromArgb(230, 126, 34); // Tamnija narandžasta
                }
                else if (button == btnOblik)
                {
                    button.BackColor = Color.FromArgb(46, 204, 113); // Tamnija zelena
                }
                else if (button == btnSekundarnaGrupa)
                {
                    button.BackColor = Color.FromArgb(241, 196, 15); // Tamnija žuta
                }
                else if (button == btnRecept)
                {
                    button.BackColor = Color.FromArgb(142, 68, 173); // Tamnija ljubičasta
                }
                
                button.Cursor = Cursors.Hand;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Color originalColor)
            {
                // Vrati originalnu boju
                button.BackColor = originalColor;
                button.Cursor = Cursors.Default;
            }
        }
    }
}

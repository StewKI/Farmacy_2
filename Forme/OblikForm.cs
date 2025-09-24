using Farmacy.Entiteti;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class OblikForm : Form
    {
        public OblikForm()
        {
            InitializeComponent();
            this.Load += OblikForm_Load;
            SetupButtonEffects();
        }

        private void OblikForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaOblike();
        }

        public void popuniPodacimaOblike()
        {
            try
            {
                IList<Oblik> lista = DTOManagerLek.VratiSveOblikeLekova() ?? new List<Oblik>();

                dgvOblik.AutoGenerateColumns = false;
                if (colId != null) colId.DataPropertyName = "Id";
                if (colNaziv != null) colNaziv.DataPropertyName = "Naziv";
                dgvOblik.RowHeadersVisible = false;
                dgvOblik.DataSource = false;
                dgvOblik.DataSource = lista;

                if (dgvOblik.Columns.Count == 0)
                {
                    dgvOblik.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colId",
                        HeaderText = "ID",
                        DataPropertyName = "Id",
                        Width = 60
                    });
                    dgvOblik.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colNaziv",
                        HeaderText = "Naziv",
                        DataPropertyName = "Naziv",
                        Width = 300
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju oblika:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNoviOblik_Click(object sender, EventArgs e)
        {
            NoviOblikForm form = new NoviOblikForm();
            form.ShowDialog();
            popuniPodacimaOblike();
        }

        private void btnObrisiOblik_Click(object sender, EventArgs e)
        {
            if (dgvOblik.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati oblik prvo!");
                return;
            }

            long id = Convert.ToInt64(dgvOblik.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show($"Da li ste sigurni da želite da obrišete oblik sa ID: {id}?",
                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DTOManagerLek.ObrisiOblik(id);
                    popuniPodacimaOblike();
                    MessageBox.Show("Oblik je uspešno obrisan!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri brisanju oblika:\n" + ex.Message, "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIzmeniOblik_Click(object sender, EventArgs e)
        {
            if (dgvOblik.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati oblik!");
                return;
            }

            long id = Convert.ToInt64(dgvOblik.CurrentRow.Cells[0].Value);
            var selektovaniOblik = DTOManagerLek.VratiOblikBasic(id);

            if (selektovaniOblik != null)
            {
                IzmeniOblikForm form = new IzmeniOblikForm(selektovaniOblik);
                form.ShowDialog();
                popuniPodacimaOblike();
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju podataka o obliku!");
            }
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
                if (button == btnNoviOblik)
                {
                    button.BackColor = Color.FromArgb(46, 204, 113); // Tamnija zelena
                }
                else if (button == btnObrisiOblik)
                {
                    button.BackColor = Color.FromArgb(231, 76, 60); // Tamnija crvena
                }
                else if (button == btnIzmeniOblik)
                {
                    button.BackColor = Color.FromArgb(52, 152, 219); // Tamnija plava
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
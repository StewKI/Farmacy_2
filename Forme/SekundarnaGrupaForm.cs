using Farmacy.Entiteti;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class SekundarnaGrupaForm : Form
    {
        public SekundarnaGrupaForm()
        {
            InitializeComponent();
            this.Load += SekundarnaGrupaForm_Load;
            SetupButtonEffects();
        }

        private void SekundarnaGrupaForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaSekundarneGrupe();
        }

        public void popuniPodacimaSekundarneGrupe()
        {
            try
            {
                IList<SekundarnaKategorijaBasic> lista = DTOManagerIsporukeZalihe.VratiSveSekundarneKategorije() ?? new List<SekundarnaKategorijaBasic>();

                dgvSekundarneGrupe.AutoGenerateColumns = false;
                if (colId != null) colId.DataPropertyName = "Id";
                if (colNaziv != null) colNaziv.DataPropertyName = "Naziv";
                dgvSekundarneGrupe.RowHeadersVisible = false;
                dgvSekundarneGrupe.DataSource = false;
                dgvSekundarneGrupe.DataSource = lista;

                if (dgvSekundarneGrupe.Columns.Count == 0)
                {
                    dgvSekundarneGrupe.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colId",
                        HeaderText = "ID",
                        DataPropertyName = "Id",
                        Width = 60
                    });
                    dgvSekundarneGrupe.Columns.Add(new DataGridViewTextBoxColumn
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
                MessageBox.Show("Greška pri učitavanju sekundarnih grupa:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovaSekundarnaGrupa_Click(object sender, EventArgs e)
        {
            NovaSekundarnaGrupaForm form = new NovaSekundarnaGrupaForm();
            form.ShowDialog();
            popuniPodacimaSekundarneGrupe();
        }

        private void btnObrisiSekundarnuGrupu_Click(object sender, EventArgs e)
        {
            if (dgvSekundarneGrupe.SelectedRows.Count == 0)
            {
                MessageBox.Show("Morate izabrati sekundarnu grupu prvo!");
                return;
            }

            long id = Convert.ToInt64(dgvSekundarneGrupe.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show($"Da li ste sigurni da želite da obrišete sekundarnu grupu sa ID: {id}?",
                "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DTOManagerIsporukeZalihe.ObrisiSekundarnuGrupu(id);
                    popuniPodacimaSekundarneGrupe();
                    MessageBox.Show("Sekundarna grupa je uspešno obrisana!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greška pri brisanju sekundarne grupe:\n" + ex.Message, "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIzmeniSekundarnuGrupu_Click(object sender, EventArgs e)
        {
            if (dgvSekundarneGrupe.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati sekundarnu grupu!");
                return;
            }

            long id = Convert.ToInt64(dgvSekundarneGrupe.CurrentRow.Cells[0].Value);
            var selektovanaGrupa = DTOManagerIsporukeZalihe.VratiSekundarnuGrupu(id);

            if (selektovanaGrupa != null)
            {
                IzmeniSekundarnuGrupuForm form = new IzmeniSekundarnuGrupuForm(selektovanaGrupa);
                form.ShowDialog();
                popuniPodacimaSekundarneGrupe();
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju podataka o sekundarnoj grupi!");
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
                if (button == btnNovaSekundarnaGrupa)
                {
                    button.BackColor = Color.FromArgb(46, 204, 113); // Tamnija zelena
                }
                else if (button == btnObrisiSekundarnuGrupu)
                {
                    button.BackColor = Color.FromArgb(231, 76, 60); // Tamnija crvena
                }
                else if (button == btnIzmeniSekundarnuGrupu)
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
using Farmacy.Entiteti;
using Farmacy_2.Forme;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class ZaliheAdminForm : Form
    {
        public int brojZaliha = 0;

        public ZaliheAdminForm()
        {
            InitializeComponent();
            this.Load += ZaliheAdminForm_Load;
            SetupButtonEffects();
        }

        private void ZaliheAdminForm_Load(object sender, EventArgs e)
        {
            popuniPodacimaZalihe();
        }

        public void popuniPodacimaZalihe()
        {
            try
            {
                IList<ZalihaBasic> lista = DTOManagerIsporukeZalihe.VratiSveZalihe() ?? new List<ZalihaBasic>();

                dgvZalihe.AutoGenerateColumns = false;
                if (colProdajnaJedinicaId != null) colProdajnaJedinicaId.DataPropertyName = "ProdajnaJedinicaId";
                if (colPakovanjeId != null) colPakovanjeId.DataPropertyName = "PakovanjeId";
                if (colKolicina != null) colKolicina.DataPropertyName = "Kolicina";
                if (colDatumPoslednjeIsporuke != null) colDatumPoslednjeIsporuke.DataPropertyName = "DatumPoslednjeIsporuke";
                if (colOdgovorniMagacionerMbr != null) colOdgovorniMagacionerMbr.DataPropertyName = "OdgovorniMagacionerId";
                dgvZalihe.RowHeadersVisible = false;
                dgvZalihe.DataSource = false;
                dgvZalihe.DataSource = lista;

                if (dgvZalihe.Columns.Count == 0)
                {
                    dgvZalihe.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colProdajnaJedinicaId",
                        HeaderText = "Prodajna Jedinica ID",
                        DataPropertyName = "ProdajnaJedinicaId",
                        Width = 150
                    });
                    dgvZalihe.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colPakovanjeId",
                        HeaderText = "Pakovanje ID",
                        DataPropertyName = "PakovanjeId",
                        Width = 120
                    });
                    dgvZalihe.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colKolicina",
                        HeaderText = "Količina",
                        DataPropertyName = "Kolicina",
                        Width = 100
                    });
                    dgvZalihe.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colDatumPoslednjeIsporuke",
                        HeaderText = "Datum poslednje isporuke",
                        DataPropertyName = "DatumPoslednjeIsporuke",
                        Width = 180
                    });
                    dgvZalihe.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = "colOdgovorniMagacionerId",
                        HeaderText = "Magacioner Id",
                        DataPropertyName = "OdgovorniMagacionerId",
                        Width = 150
                    });
                }

                brojZaliha = lista.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri učitavanju zaliha:\n" + ex.Message, "Greška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIzmeniZalihu_Click(object sender, EventArgs e)
        {
            if (dgvZalihe.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati zalihe!");
                return;
            }

            long prodajnaJedinicaId = Convert.ToInt64(dgvZalihe.CurrentRow.Cells[0].Value);
            long pakovanjeId = Convert.ToInt64(dgvZalihe.CurrentRow.Cells[1].Value);
            var selektovanaZaliha = DTOManagerIsporukeZalihe.VratiZalihu(prodajnaJedinicaId, pakovanjeId);

            if (selektovanaZaliha != null)
            {
                ZalihaEditForm form = new ZalihaEditForm(selektovanaZaliha);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    popuniPodacimaZalihe();
                }
            }
            else
            {
                MessageBox.Show("Greška pri učitavanju podataka o zalihe!");
            }
        }

        private void btnDodajNovuZalihu_Click(object sender, EventArgs e)
        {
            ZalihaForm form = new ZalihaForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                popuniPodacimaZalihe();
            }
        }

        private void btnObrisiZalihu_Click(object sender, EventArgs e)
        {
            if (dgvZalihe.CurrentRow == null)
            {
                MessageBox.Show("Morate selektovati zalihe!");
                return;
            }

            long prodajnaJedinicaId = Convert.ToInt64(dgvZalihe.CurrentRow.Cells[0].Value);
            long pakovanjeId = Convert.ToInt64(dgvZalihe.CurrentRow.Cells[1].Value);

            var result = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete selektovane zalihe?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    DTOManagerIsporukeZalihe.ObrisiZalihu(prodajnaJedinicaId, pakovanjeId);
                    MessageBox.Show("Zalihe su uspešno obrisane!", "Uspešno", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    popuniPodacimaZalihe();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška pri brisanju zaliha:\n{ex.Message}", "Greška",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvZalihe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Može se dodati dodatna logika ako je potrebna
        }

        private void SetupButtonEffects()
        {
            // Add hover effects to all buttons
            btnDodajNovuZalihu.MouseEnter += Button_MouseEnter;
            btnDodajNovuZalihu.MouseLeave += Button_MouseLeave;
            btnIzmeniZalihu.MouseEnter += Button_MouseEnter;
            btnIzmeniZalihu.MouseLeave += Button_MouseLeave;
            btnObrisiZalihu.MouseEnter += Button_MouseEnter;
            btnObrisiZalihu.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Store original color and make button lighter
                button.BackColor = Color.FromArgb(
                    Math.Min(255, button.BackColor.R + 30),
                    Math.Min(255, button.BackColor.G + 30),
                    Math.Min(255, button.BackColor.B + 30)
                );
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Restore original color
                if (button == btnDodajNovuZalihu)
                    button.BackColor = Color.FromArgb(40, 167, 69);
                else if (button == btnIzmeniZalihu)
                    button.BackColor = Color.FromArgb(0, 123, 255);
                else if (button == btnObrisiZalihu)
                    button.BackColor = Color.FromArgb(220, 53, 69);
            }
        }
    }
}

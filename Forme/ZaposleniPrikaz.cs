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
            SetupButtonEffects();
        }

        private void ZaposleniPrikaz_Load(object sender, EventArgs e)
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
                // Column mapping removed - using AutoGenerateColumns

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

        private void SetupButtonEffects()
        {
            // Add hover effects to all buttons
            btnObrisiZaposlenog.MouseEnter += Button_MouseEnter;
            btnObrisiZaposlenog.MouseLeave += Button_MouseLeave;
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
                if (button == btnObrisiZaposlenog)
                    button.BackColor = Color.FromArgb(231, 76, 60);
            }
        }

        private void groupBoxZaposleni_Enter(object sender, EventArgs e)
        {

        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}

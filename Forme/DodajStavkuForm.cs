using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public partial class DodajStavkuForm : Form
    {
        private readonly long prodajnaJedinicaId;
        private ProdajaStavkaBasic stavka;

        private ComboBox cmbPakovanje;
        private NumericUpDown numKolicina;
        private NumericUpDown numCena;
        private NumericUpDown numKontrolisanaKol;
        private NumericUpDown numProcenatParticip;
        private TextBox txtNeophodanIzvestaj;

        public DodajStavkuForm(long prodajnaJedinicaId)
        {
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            stavka = new ProdajaStavkaBasic();
            InitializeComponents();
        }

        public DodajStavkuForm(long prodajnaJedinicaId, ProdajaStavkaBasic stavka) : this(prodajnaJedinicaId)
        {
            this.stavka = stavka;
            UcitajPodatke();
        }

        private void InitializeComponents()
        {
            Text = "Dodaj stavku";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(500, 400);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            // Pakovanje
            var lblPakovanje = new Label 
            { 
                Text = "Pakovanje:", 
                AutoSize = true, 
                Location = new Point(20, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            cmbPakovanje = new ComboBox 
            { 
                Location = new Point(20, 45), 
                Width = 440, 
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 9)
            };

            // Količina
            var lblKolicina = new Label 
            { 
                Text = "Količina:", 
                AutoSize = true, 
                Location = new Point(20, 85),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            numKolicina = new NumericUpDown 
            { 
                Location = new Point(20, 110), 
                Width = 120, 
                Minimum = 1, 
                Maximum = 100000, 
                Value = 1,
                Font = new Font("Segoe UI", 9)
            };

            // Cena
            var lblCena = new Label 
            { 
                Text = "Cena:", 
                AutoSize = true, 
                Location = new Point(160, 85),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            numCena = new NumericUpDown 
            { 
                Location = new Point(160, 110), 
                Width = 120, 
                DecimalPlaces = 2, 
                Minimum = 0, 
                Maximum = 1000000,
                Font = new Font("Segoe UI", 9)
            };

            // Kontrolisana količina
            var lblKontrolisana = new Label 
            { 
                Text = "Kontrolisana kol:", 
                AutoSize = true, 
                Location = new Point(300, 85),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            numKontrolisanaKol = new NumericUpDown 
            { 
                Location = new Point(300, 110), 
                Width = 120, 
                Minimum = 0, 
                Maximum = 100000,
                Font = new Font("Segoe UI", 9)
            };

            // Procenat participacije
            var lblProcenat = new Label 
            { 
                Text = "% participacije:", 
                AutoSize = true, 
                Location = new Point(20, 150),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            numProcenatParticip = new NumericUpDown 
            { 
                Location = new Point(20, 175), 
                Width = 120, 
                DecimalPlaces = 2, 
                Minimum = 0, 
                Maximum = 100,
                Font = new Font("Segoe UI", 9)
            };

            // Neophodan izveštaj
            var lblIzvestaj = new Label 
            { 
                Text = "Neophodan izveštaj (Y/N):", 
                AutoSize = true, 
                Location = new Point(160, 150),
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
            txtNeophodanIzvestaj = new TextBox 
            { 
                Location = new Point(160, 175), 
                Width = 60,
                Font = new Font("Segoe UI", 9)
            };

            // Buttons
            var btnOK = new Button 
            { 
                Text = "OK", 
                Location = new Point(300, 250), 
                Size = new Size(80, 35),
                BackColor = Color.FromArgb(33, 136, 56),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                DialogResult = DialogResult.OK
            };
            var btnCancel = new Button 
            { 
                Text = "Otkaži", 
                Location = new Point(390, 250), 
                Size = new Size(80, 35),
                BackColor = Color.FromArgb(200, 35, 51),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                DialogResult = DialogResult.Cancel
            };

            btnOK.Click += BtnOK_Click;

            Controls.Add(lblPakovanje);
            Controls.Add(cmbPakovanje);
            Controls.Add(lblKolicina);
            Controls.Add(numKolicina);
            Controls.Add(lblCena);
            Controls.Add(numCena);
            Controls.Add(lblKontrolisana);
            Controls.Add(numKontrolisanaKol);
            Controls.Add(lblProcenat);
            Controls.Add(numProcenatParticip);
            Controls.Add(lblIzvestaj);
            Controls.Add(txtNeophodanIzvestaj);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);

            UcitajPakovanja();
        }

        private void UcitajPakovanja()
        {
            try
            {
                // Učitaj samo pakovanja koja su na zalihama za ovu prodajnu jedinicu
                var pakovanja = DTOManagerProdaja.VratiPakovanjaSaZalihe(prodajnaJedinicaId);
                cmbPakovanje.DataSource = pakovanja;
                cmbPakovanje.DisplayMember = "PrikazniNaziv";
                cmbPakovanje.ValueMember = "Id";
                cmbPakovanje.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju pakovanja: {ex.Message}", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UcitajPodatke()
        {
            if (stavka != null)
            {
                cmbPakovanje.SelectedValue = stavka.PakovanjeId;
                numKolicina.Value = stavka.Kolicina;
                numCena.Value = stavka.Cena ?? 0;
                numKontrolisanaKol.Value = stavka.KontrolisanaKol ?? 0;
                numProcenatParticip.Value = stavka.ProcenatParticip ?? 0;
                txtNeophodanIzvestaj.Text = stavka.NeophodanIzvestaj ?? "";
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (cmbPakovanje.SelectedValue == null)
            {
                MessageBox.Show("Morate selektovati pakovanje!", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPakovanje.Focus();
                return;
            }

            if (numKolicina.Value <= 0)
            {
                MessageBox.Show("Količina mora biti veća od 0!", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numKolicina.Focus();
                return;
            }

            var selektovanoPakovanje = (PakovanjeBasic)cmbPakovanje.SelectedItem;
            stavka.PakovanjeId = (long)cmbPakovanje.SelectedValue;
            stavka.PakovanjeNaziv = selektovanoPakovanje.PrikazniNaziv;
            stavka.Kolicina = (int)numKolicina.Value;
            stavka.Cena = numCena.Value > 0 ? numCena.Value : null;
            stavka.KontrolisanaKol = numKontrolisanaKol.Value > 0 ? (int)numKontrolisanaKol.Value : null;
            stavka.ProcenatParticip = numProcenatParticip.Value > 0 ? numProcenatParticip.Value : null;
            stavka.NeophodanIzvestaj = string.IsNullOrWhiteSpace(txtNeophodanIzvestaj.Text) ? null : txtNeophodanIzvestaj.Text.Trim().ToUpper();
        }

        public ProdajaStavkaBasic GetStavka()
        {
            return stavka;
        }
    }
}

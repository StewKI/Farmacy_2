using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Farmacy.Forme
{
    public class NovaProdajaForm : Form
    {
        private readonly long prodajnaJedinicaId;

        private DateTimePicker dtpDatumVreme;
        private ComboBox cmbBlagajnik;
        private CheckBox chkNaRecept;
        private ComboBox cmbRecept;

        private DataGridView dgvStavke;
        private Button btnDodajStavku;
        private Button btnUkloniStavku;
        private Button btnSacuvaj;
        private Button btnOdustani;

        private BindingSource stavkeSource;

        public NovaProdajaForm(long prodajnaJedinicaId)
        {
            this.prodajnaJedinicaId = prodajnaJedinicaId;
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            Text = "Nova prodaja";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(900, 600);

            var lblDatum = new Label { Text = "Datum/Vreme:", AutoSize = true, Location = new Point(20, 20) };
            dtpDatumVreme = new DateTimePicker { Location = new Point(130, 16), Width = 200, Value = DateTime.Now };

            var lblBlagajnik = new Label { Text = "Blagajnik:", AutoSize = true, Location = new Point(360, 20) };
            cmbBlagajnik = new ComboBox { Location = new Point(470, 16), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };

            chkNaRecept = new CheckBox { Text = "Na recept", Location = new Point(20, 55), AutoSize = true };
            chkNaRecept.CheckedChanged += (s, e) => cmbRecept.Enabled = chkNaRecept.Checked;

            var lblRecept = new Label { Text = "Recept:", AutoSize = true, Location = new Point(150, 55) };
            cmbRecept = new ComboBox { Location = new Point(200, 52), Width = 300, DropDownStyle = ComboBoxStyle.DropDownList, Enabled = false };

            dgvStavke = new DataGridView
            {
                Location = new Point(20, 90),
                Size = new Size(840, 380),
                AutoGenerateColumns = false,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };

            stavkeSource = new BindingSource();
            stavkeSource.DataSource = new List<ProdajaStavkaBasic>();
            dgvStavke.DataSource = stavkeSource;

            dgvStavke.Columns.Add(new DataGridViewTextBoxColumn { Name = "PakovanjeNaziv", HeaderText = "Pakovanje", DataPropertyName = "PakovanjeNaziv", Width = 200 });
            dgvStavke.Columns.Add(new DataGridViewTextBoxColumn { Name = "Kolicina", HeaderText = "Količina", DataPropertyName = "Kolicina", Width = 80 });
            dgvStavke.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cena", HeaderText = "Cena", DataPropertyName = "Cena", Width = 90 });
            dgvStavke.Columns.Add(new DataGridViewTextBoxColumn { Name = "ReceptSerijskiBroj", HeaderText = "Recept # (stavka)", DataPropertyName = "ReceptSerijskiBroj", Width = 140 });
            dgvStavke.Columns.Add(new DataGridViewTextBoxColumn { Name = "KontrolisanaKol", HeaderText = "Kontrolisana", DataPropertyName = "KontrolisanaKol", Width = 110 });
            dgvStavke.Columns.Add(new DataGridViewTextBoxColumn { Name = "ProcenatParticip", HeaderText = "% particip.", DataPropertyName = "ProcenatParticip", Width = 110 });
            dgvStavke.Columns.Add(new DataGridViewTextBoxColumn { Name = "NeophodanIzvestaj", HeaderText = "Izveštaj (Y/N)", DataPropertyName = "NeophodanIzvestaj", Width = 110 });

            btnDodajStavku = new Button { Text = "Dodaj stavku", Location = new Point(20, 490), Size = new Size(120, 32) };
            btnUkloniStavku = new Button { Text = "Ukloni stavku", Location = new Point(150, 490), Size = new Size(120, 32) };
            btnSacuvaj = new Button { Text = "Sačuvaj", Location = new Point(680, 490), Size = new Size(180, 32), BackColor = Color.FromArgb(33, 136, 56), ForeColor = Color.White };
            btnOdustani = new Button { Text = "Odustani", Location = new Point(480, 490), Size = new Size(180, 32), BackColor = Color.FromArgb(200, 35, 51), ForeColor = Color.White };

            btnDodajStavku.Click += BtnDodajStavku_Click;
            btnUkloniStavku.Click += BtnUkloniStavku_Click;
            btnSacuvaj.Click += BtnSacuvaj_Click;
            btnOdustani.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };

            UcitajPodatke();

            Controls.Add(lblDatum);
            Controls.Add(dtpDatumVreme);
            Controls.Add(lblBlagajnik);
            Controls.Add(cmbBlagajnik);
            Controls.Add(chkNaRecept);
            Controls.Add(lblRecept);
            Controls.Add(cmbRecept);
            Controls.Add(dgvStavke);
            Controls.Add(btnDodajStavku);
            Controls.Add(btnUkloniStavku);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnOdustani);
        }

        private void UcitajPodatke()
        {
            try
            {
                // Učitaj blagajnike
                var blagajnici = DTOManagerProdaja.VratiSveBlagajnike();
                cmbBlagajnik.DataSource = blagajnici;
                cmbBlagajnik.DisplayMember = "Ime";
                cmbBlagajnik.ValueMember = "MBr";
                cmbBlagajnik.SelectedIndex = -1;

                // Učitaj recepte
                var recepti = DTOManagerProdaja.VratiSveRecepte();
                cmbRecept.DataSource = recepti;
                cmbRecept.DisplayMember = "PrikazniNaziv";
                cmbRecept.ValueMember = "SerijskiBroj";
                cmbRecept.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri učitavanju podataka: {ex.Message}", "Greška", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDodajStavku_Click(object? sender, EventArgs e)
        {
            using (var dialog = new DodajStavkuForm(prodajnaJedinicaId))
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    var lista = (List<ProdajaStavkaBasic>)stavkeSource.DataSource;
                    lista.Add(dialog.GetStavka());
                    stavkeSource.ResetBindings(false);
                }
            }
        }

        private void BtnUkloniStavku_Click(object? sender, EventArgs e)
        {
            if (dgvStavke.CurrentRow == null) return;
            var lista = (List<ProdajaStavkaBasic>)stavkeSource.DataSource;
            var item = dgvStavke.CurrentRow.DataBoundItem as ProdajaStavkaBasic;
            if (item != null)
            {
                lista.Remove(item);
                stavkeSource.ResetBindings(false);
            }
        }

        private void BtnSacuvaj_Click(object? sender, EventArgs e)
        {
            try
            {
                var lista = ((List<ProdajaStavkaBasic>)stavkeSource.DataSource).ToList();
                if (lista.Count == 0)
                {
                    MessageBox.Show("Dodajte bar jednu stavku.");
                    return;
                }

                long? blagMbr = null;
                if (cmbBlagajnik.SelectedValue != null)
                {
                    blagMbr = (long)cmbBlagajnik.SelectedValue;
                }

                var header = new ProdajaBasic
                {
                    ProdajnaJedinicaId = prodajnaJedinicaId,
                    DatumVreme = dtpDatumVreme.Value,
                    BlagajnikMbr = blagMbr
                };

                if (chkNaRecept.Checked)
                {
                    if (cmbRecept.SelectedValue == null)
                    {
                        MessageBox.Show("Morate selektovati recept ili isključite opciju 'Na recept'.");
                        return;
                    }
                    var receptSerijski = cmbRecept.SelectedValue.ToString();
                    var id = DTOManagerProdaja.KreirajProdajuNaRecept(header, receptSerijski, lista);
                    MessageBox.Show($"Prodaja (na recept) sa ID={id} je uspešno kreirana.");
                }
                else
                {
                    var id = DTOManagerProdaja.KreirajProdaju(header, lista);
                    MessageBox.Show($"Prodaja sa ID={id} je uspešno kreirana.");
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
    }
}



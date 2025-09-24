using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Farmacy.Forme;

namespace Farmacy
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

        private void PocetnaStranica_Load(object sender, EventArgs e)
        {
            // Dodaj hover efekte za dugmad
            SetupButtonEffects();
        }

        private void SetupButtonEffects()
        {
            // Dodaj hover efekte za sva dugmad
            foreach (Control control in panelMain.Controls)
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
                // Svetlija verzija boje za hover efekat
                Color originalColor = button.BackColor;
                Color hoverColor = Color.FromArgb(
                    Math.Min(255, originalColor.R + 30),
                    Math.Min(255, originalColor.G + 30),
                    Math.Min(255, originalColor.B + 30)
                );
                button.BackColor = hoverColor;
                button.Cursor = Cursors.Hand;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Vrati originalnu boju
                switch (button.Name)
                {
                    case "btnProdajneJedinice":
                        button.BackColor = Color.FromArgb(52, 152, 219);
                        break;
                    case "btnDistributeri":
                        button.BackColor = Color.FromArgb(46, 204, 113);
                        break;
                    case "btnProizvodjaci":
                        button.BackColor = Color.FromArgb(155, 89, 182);
                        break;
                    case "btnLekovi":
                        button.BackColor = Color.FromArgb(230, 126, 34);
                        break;
                    case "btnZaposleni":
                        button.BackColor = Color.FromArgb(231, 76, 60);
                        break;
                }
                button.Cursor = Cursors.Default;
            }
        }

        private void btnProdajneJedinice_Click(object sender, EventArgs e)
        {
            ProdajnaJedinicaAdminForm form = new ProdajnaJedinicaAdminForm();
            form.ShowDialog();
        }

        private void btnDistributeri_Click(object sender, EventArgs e)
        {
            DistributerAdminForm form = new DistributerAdminForm();
            form.ShowDialog();
        }

        private void btnProizvodjaci_Click(object sender, EventArgs e)
        {
            ProizvodjacAdminForm form = new ProizvodjacAdminForm();
            form.ShowDialog();
        }

        private void btnLekovi_Click(object sender, EventArgs e)
        {
            LekAdminForm form = new LekAdminForm();
            form.ShowDialog();
        }

        private void zaposleniBtn_Click(object sender, EventArgs e)
        {
            ZaposleniAdminForm form = new ZaposleniAdminForm();
            form.ShowDialog();
        }
    }
}

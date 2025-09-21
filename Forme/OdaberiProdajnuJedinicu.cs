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
    public partial class OdaberiProdajnuJedinicu : Form
    {
        public OdaberiProdajnuJedinicu()
        {
            InitializeComponent();
            SetupButtonEffects();
        }

        private void ProdajnaJedinica_Click(object sender, EventArgs e)
        {
            ProdajnaJedinicaForm form = new ProdajnaJedinicaForm();
            form.ShowDialog();

        }

        private void ApotekaSaLab_Click(object sender, EventArgs e)
        {
            ApotekaSaLabForm form = new ApotekaSaLabForm();
            form.ShowDialog();
        }

        private void StandardnaApoteka_Click(object sender, EventArgs e)
        {
            StandardnaApotekaForm form = new StandardnaApotekaForm();
            form.ShowDialog();
        }

        private void SpecijalizovanaApoteka_Click(object sender, EventArgs e)
        {
            SpecijalizovanaApotekaForm form = new SpecijalizovanaApotekaForm();
            form.ShowDialog();
        }

        private void OdaberiProdajnuJedinicu_Load(object sender, EventArgs e)
        {

        }

        private void SetupButtonEffects()
        {
            // Dodaj hover efekte za sva dugmad
            button1.MouseEnter += Button_MouseEnter;
            button1.MouseLeave += Button_MouseLeave;
            button2.MouseEnter += Button_MouseEnter;
            button2.MouseLeave += Button_MouseLeave;
            button3.MouseEnter += Button_MouseEnter;
            button3.MouseLeave += Button_MouseLeave;
            button4.MouseEnter += Button_MouseEnter;
            button4.MouseLeave += Button_MouseLeave;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // Sačuvaj originalnu boju samo ako nije već sačuvana
                if (button.Tag == null)
                {
                    button.Tag = button.BackColor;
                }
                
                // Promeni boju na hover
                if (button == button1)
                {
                    button.BackColor = Color.FromArgb(41, 128, 185); // Tamnija plava
                }
                else if (button == button2)
                {
                    button.BackColor = Color.FromArgb(39, 174, 96); // Tamnija zelena
                }
                else if (button == button3)
                {
                    button.BackColor = Color.FromArgb(142, 68, 173); // Tamnija ljubičasta
                }
                else if (button == button4)
                {
                    button.BackColor = Color.FromArgb(192, 57, 43); // Tamnija crvena
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

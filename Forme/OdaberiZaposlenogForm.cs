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
    public partial class OdaberiZaposlenogForm : Form
    {
        public OdaberiZaposlenogForm()
        {
            InitializeComponent();
            SetupButtonEffects();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FarmaceutForm form = new FarmaceutForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZaposleniForm fomra = new ZaposleniForm();
            fomra.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenadzerForm form = new MenadzerForm();
            form.ShowDialog();
        }

        private void OdaberiZaposlenogForm_Load(object sender, EventArgs e)
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
                if (button == button1) // Zaposleni - plava
                {
                    button.BackColor = Color.FromArgb(41, 128, 185);
                }
                else if (button == button2) // Farmaceut - zelena
                {
                    button.BackColor = Color.FromArgb(39, 174, 96);
                }
                else if (button == button3) // Menadžer - ljubičasta
                {
                    button.BackColor = Color.FromArgb(142, 68, 173);
                }
                else if (button == button4) // Tehničar - crvena
                {
                    button.BackColor = Color.FromArgb(192, 57, 43);
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

        private void button4_Click(object sender, EventArgs e)
        {
            TehnicarForm form = new TehnicarForm();
            form.ShowDialog();
        }
    }
}

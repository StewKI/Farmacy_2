using Farmacy_2.Forme;
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
    public partial class IzmeniZaposlenogForm : Form
    {
        long mbr;
        public IzmeniZaposlenogForm(long mbr1)
        {
            InitializeComponent();
            mbr = mbr1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selektovaniZaposleni = DTOManagerZaposleni.VratiZaposlenog(mbr);
            if (selektovaniZaposleni is FarmaceutBasic faramaceut)
            {
                FarmaceutEditForm form = new FarmaceutEditForm(faramaceut);
                form.ShowDialog();
            }
            else if (selektovaniZaposleni is TehnicarBasic tehnicar)
            {
                TehnicarEditForm form = new TehnicarEditForm(tehnicar);
                form.ShowDialog();

            }
            else if (selektovaniZaposleni is MenadzerBasic menadzer)
            {
                MenadzerEditForm form = new MenadzerEditForm(menadzer);
                form.ShowDialog();
            }
            else
            {

                //// Pozovi formu za editovanje i prosledi zaposlenog

                ZaposleniEditForm form = new ZaposleniEditForm(selektovaniZaposleni);
                form.ShowDialog();

                //// Nakon zatvaranja forme, možeš refreshovati grid
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var r = DTOManagerZaposleni.VratiRasporedRada(mbr);

            IzmeniRadnoMestoForm form = new IzmeniRadnoMestoForm(r);
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {


            PromeniSmenuForm form = new PromeniSmenuForm(mbr);
            form.ShowDialog();
        }
    }
}

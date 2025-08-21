using Farmacy.Forme;
using NHibernate;

namespace Farmacy
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                using ISession s = DataLayer.GetSession();
                var ok = s.CreateSQLQuery("select 'NH OK' from dual").UniqueResult<string>();
                MessageBox.Show("NHibernate konekcija radi: " + ok, "OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "NH init error");
            }

            // pokreni glavni prozor (po želji)
            // Application.Run(new MainForm());
            //Application.Run(new PocetnaStranica());
            Application.Run(new ProdajnaJedinicaAdminForm());
            //Application.Run(new ZaposleniAdminForm());
            //Application.Run(new LekAdminForm());
        }
    }
}
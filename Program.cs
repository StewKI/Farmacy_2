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
                // Resetuj session factory da se primeni nova konfiguracija
                DataLayer.ResetSessionFactory();
                
                using ISession s = DataLayer.GetSession();
                var ok = s.CreateSQLQuery("select 'NH OK' from dual").UniqueResult<string>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "NH init error");
            }

            // pokreni glavni prozor (po �elji)
            Application.Run(new PocetnaStranica());
        }
    }
}
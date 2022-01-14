using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OduncKitapASPNETMVCWebSolution_BLL.Managers
{
    public class KitapManager
    {
        //Global alan
        OduncKitapDBEntities dbcontext = new OduncKitapDBEntities();
        public List<Kitaplar> TumAktifKitaplariGetir()
        {
            try
            {
                List<Kitaplar> kitaplar = new List<Kitaplar>();
                kitaplar = dbcontext.Kitaplar.Where(x => !x.SilindiMi && x.StokAdeti > 0).OrderByDescending(x=> x.Id).ToList();
                return kitaplar;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool YeniKitapEkle(Kitaplar yeniKitap)
        {
            try
            {
                dbcontext.Kitaplar.Add(yeniKitap);
                dbcontext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

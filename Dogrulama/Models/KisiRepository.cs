using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dogrulama.Models
{
    public class KisiRepository : IKisiRepository
    {

        private Context db = new Context();
        

        public bool Check(Kisi kisi, string Tc)
        {
           tckimlikno1.KPSPublic kps =new tckimlikno1.KPSPublic();

            return kps.TCKimlikNoDogrula(long.Parse(Tc), kisi.İsim.ToUpper(), kisi.Soyisim.ToUpper(), kisi.Dogumyılı.Year);
        }

        public void CreatUser(Kisi kisi)
        {
            db.Kisiler.Add(kisi);
            db.SaveChanges();
        }

        public void CreateTcHash(string tc, out byte[] tchash, out byte[] tcsalt)
        {
            var hmac =new System.Security.Cryptography.HMACSHA512();
            tcsalt = hmac.Key;

            tchash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(tc));
        }
    }

   
       
    }

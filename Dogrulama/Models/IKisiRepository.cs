using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogrulama.Models
{
   public interface IKisiRepository
    {
        void CreatUser(Kisi kisi);
        bool Check(Kisi kisi,string Tc);
        void CreateTcHash(string tc, out byte[] tchash, out byte[] tcsalt);
    }
}

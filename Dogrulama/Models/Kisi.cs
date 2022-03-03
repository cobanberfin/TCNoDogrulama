using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dogrulama.Models
{
    public class Kisi
    {
        public int Id { get; set; }
        [StringLength (20) ]
        public string İsim { get; set; }
        [StringLength(20)]
        public string Soyisim { get; set; }
        public DateTime Dogumyılı { get; set; }
        [Required]
        public byte[] tchash { get; set; }
        [Required]

        public byte[] tcsalt{ get; set; }
    }
}
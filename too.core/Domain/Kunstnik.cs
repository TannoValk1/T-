using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace too.Core.Domain
{
    public class Kunstnik
    {
        [Key]
        public int KunstnikId { get; set; }
        public string KunstnikuNimi { get; set; }
        public int Vanus {  get; set; }
        public string KunstiTyyp {  get; set; }
    }
}

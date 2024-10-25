using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace too.Core.Domain
{
    public class KunstiOmanik
    {
        [Key]
        public string OmanikuNimi { get; set; }
        public int KunstiOmanikuVanus { get; set; }

    }
}

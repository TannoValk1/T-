using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace too.Core.Domain
{
    public class Kunstiteosed
    {
        [Key]
        public int KunstiteoseID { get; set; }
        public string TeoseNimi { get; set; }
        public int MaalimiseAasta { get; set; }
        public string Kunstnik { get; set; }
    }
}

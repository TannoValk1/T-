using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace too.Core.Domain
{
    public class Kunstityyp
    {
        [Key]
        public string skulptuur { get; set; }
        public string maal {  get; set; }
    }
}

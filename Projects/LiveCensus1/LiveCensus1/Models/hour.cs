using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LiveCensus.Models
{
    [Table("LCEN_HOUR")]
    public class hour
    {
        public int id { get; set; }

        public string HrNum { get; set; }

        public string HrDisp { get; set; }

        public string shift { get; set; }
    }
}

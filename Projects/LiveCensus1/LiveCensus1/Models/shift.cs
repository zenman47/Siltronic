using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LiveCensus.Models
{
    [Table("LCEN_SHIFT")]
    public class shift
    {
        public int id { get; set; }

        public string ShiftNum { get; set; }

        public string ShiftDisp { get; set; }
    }
}

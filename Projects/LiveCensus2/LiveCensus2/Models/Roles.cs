namespace LiveCensus2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("APP_OWNER.LCEN_ROLES")]
    public partial class Roles
    {
        public Roles()
        {
            LCEN_USERS = new HashSet<Users>();
        }

        [Key]
        public decimal ROLE_ID { get; set; }

        [StringLength(40)]
        public string DESCR { get; set; }

        public virtual ICollection<Users> LCEN_USERS { get; set; }
    }
}

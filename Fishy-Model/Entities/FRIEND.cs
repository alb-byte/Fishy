namespace Fishy_Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FRIENDS")]
    public partial class FRIEND
    {
        public int ID { get; set; }

        public int? ID1 { get; set; }

        public int? ID2 { get; set; }

        public virtual USER USER { get; set; }

        public virtual USER USER1 { get; set; }
    }
}

namespace Fishy_Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMENTS")]
    public partial class COMMENT
    {
        public int ID { get; set; }

        public int? PHOTO { get; set; }

        public int? SENDER { get; set; }

        [Required]
        [StringLength(100)]
        public string CONTENT { get; set; }

        public virtual PHOTO Photo1 { get; set; }

        public virtual USER USER { get; set; }
    }
}

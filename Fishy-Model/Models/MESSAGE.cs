namespace Fishy_Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MESSAGES")]
    public partial class MESSAGE
    {
        public int ID { get; set; }

        public int? SENDER { get; set; }

        public int? HANDLER { get; set; }

        public int? DIALOG { get; set; }

        [Required]
        [StringLength(200)]
        public string CONTENT { get; set; }

        public DateTime TIME { get; set; }

        public virtual DIALOG DIALOG1 { get; set; }

        public virtual USER USER { get; set; }

        public virtual USER USER1 { get; set; }
    }
}

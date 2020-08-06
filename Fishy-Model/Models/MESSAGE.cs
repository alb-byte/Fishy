using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fishy_Model.Models
{
    [Table("MESSAGES")]
    public partial class MESSAGE
    {
        public int ID { get; set; }

        public int? SENDER { get; set; }

        public int? DIALOG { get; set; }

        [Required]
        [StringLength(200)]
        public string CONTENT { get; set; }

        public DateTime TIME { get; set; }

        public virtual DIALOG DIALOG1 { get; set; }

        public virtual USER USER { get; set; }
    }
}

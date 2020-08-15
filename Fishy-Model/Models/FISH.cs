namespace Fishy_Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FISHES")]
    public partial class FISH
    {
        public int ID { get; set; }

        [Required]
        [StringLength(15)]
        public string NAME { get; set; }

        [Required]
        [StringLength(60)]
        public string IMG { get; set; }

        [Required]
        [StringLength(500)]
        public string DESCRIPTION { get; set; }
    }
}

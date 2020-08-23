namespace Fishy_Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NEWS
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string TITLE { get; set; }

        [Required]
        [StringLength(60)]
        public string IMG { get; set; }

        [Required]
        [StringLength(500)]
        public string CONTENT { get; set; }

        public DateTime TIME { get; set; }
    }
}

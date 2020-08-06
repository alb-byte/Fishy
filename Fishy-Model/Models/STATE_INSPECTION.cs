using System.ComponentModel.DataAnnotations;

namespace Fishy_Model.Models
{
    public partial class STATE_INSPECTION
    {
        public int ID { get; set; }

        [Required]
        [StringLength(40)]
        public string REGION { get; set; }

        [Required]
        [StringLength(200)]
        public string ADDRESS { get; set; }

        [Required]
        [StringLength(15)]
        public string PHONE { get; set; }
    }
}

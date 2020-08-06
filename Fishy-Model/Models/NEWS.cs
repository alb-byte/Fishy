using System.ComponentModel.DataAnnotations;

namespace Fishy_Model.Models
{
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
    }
}

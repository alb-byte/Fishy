namespace Fishy_Model.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ALBUMS")]
    public partial class ALBUM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALBUM()
        {
            PHOTOS = new HashSet<PHOTO>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string NAME { get; set; }

        public int? OWNER { get; set; }

        public virtual USER USER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHOTO> PHOTOS { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fishy_Model.Models
{
    [Table("PHOTOS")]
    public partial class PHOTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHOTO()
        {
            COMMENTS = new HashSet<COMMENT>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(60)]
        public string PATH { get; set; }

        public int? ALBUM { get; set; }

        public virtual ALBUM ALBUM1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENT> COMMENTS { get; set; }
    }
}

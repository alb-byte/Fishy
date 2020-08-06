using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fishy_Model.Models
{
    [Table("DIALOGS")]
    public partial class DIALOG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIALOG()
        {
            MESSAGES = new HashSet<MESSAGE>();
        }

        public int ID { get; set; }

        public int? USER1 { get; set; }

        public int? USER2 { get; set; }

        public virtual USER USER { get; set; }

        public virtual USER USER3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MESSAGE> MESSAGES { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace Fishy_Model.Models
{
    [Table("FRIENDS")]
    public partial class FRIEND
    {
        public int ID { get; set; }

        public int? ID1 { get; set; }

        public int? ID2 { get; set; }

        public virtual USER USER { get; set; }

        public virtual USER USER1 { get; set; }
    }
}

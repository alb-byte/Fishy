namespace Fishy_Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Serializable]
    [Table("USERS")]
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            ALBUMS = new HashSet<ALBUM>();
            COMMENTS = new HashSet<COMMENT>();
            DIALOGS = new HashSet<DIALOG>();
            DIALOGS1 = new HashSet<DIALOG>();
            FRIENDS = new HashSet<FRIEND>();
            FRIENDS1 = new HashSet<FRIEND>();
            MESSAGES = new HashSet<MESSAGE>();
            MESSAGES1 = new HashSet<MESSAGE>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(15)]
        public string FIRSTNAME { get; set; }

        [Required]
        [StringLength(15)]
        public string LASTNAME { get; set; }

        public int? AGE { get; set; }

        [Required]
        [StringLength(40)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(100)]
        public string PASS { get; set; }

        [StringLength(25)]
        public string CITY { get; set; }

        [StringLength(500)]
        public string INFO { get; set; }

        [StringLength(60)]
        public string IMG { get; set; }

        public bool ADMIN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALBUM> ALBUMS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENT> COMMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIALOG> DIALOGS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIALOG> DIALOGS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FRIEND> FRIENDS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FRIEND> FRIENDS1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MESSAGE> MESSAGES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MESSAGE> MESSAGES1 { get; set; }
    }
}

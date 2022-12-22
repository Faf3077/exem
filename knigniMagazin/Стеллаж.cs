namespace knigniMagazin
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Стеллаж
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Стеллаж()
        {
            Книги = new HashSet<Книги>();
        }

        [Key]
        public int IDСтеллажа { get; set; }

        [Required]
        [StringLength(50)]
        public string НазваниеСтеллажа { get; set; }

        public int НомерПолки { get; set; }

        public int КолвоКниг { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Книги> Книги { get; set; }
    }
}

namespace knigniMagazin
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Книги
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Книги()
        {
            Автор = new HashSet<Автор>();
            Продажи = new HashSet<Продажи>();
        }

        [Key]
        public int IDКниги { get; set; }

        public int IDИздательства { get; set; }

        public int IDЖанра { get; set; }

        public int IDСтеллажа { get; set; }

        [Required]
        [StringLength(50)]
        public string Наименование { get; set; }

        public int Артикул { get; set; }

        [Required]
        [StringLength(10)]
        public string ВозрастныеОграничения { get; set; }

        [Required]
        [StringLength(10)]
        public string КоличествоСтраниц { get; set; }

        public decimal Цена { get; set; }

        [Required]
        [StringLength(100)]
        public string Описание { get; set; }

        [Required]
        [StringLength(50)]
        public string ОбложкаКниги { get; set; }

        public virtual Жанр Жанр { get; set; }

        public virtual Издательство Издательство { get; set; }

        public virtual Стеллаж Стеллаж { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Автор> Автор { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Продажи> Продажи { get; set; }
    }
}

namespace knigniMagazin
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Отчет
    {
        [Key]
        public int IDОтчета { get; set; }

        public int IDПродажи { get; set; }

        [Column(TypeName = "date")]
        public DateTime ДатаОтчета { get; set; }

        public decimal ИтогЗаМесяц { get; set; }

        [Required]
        [StringLength(50)]
        public string НомерОтчета { get; set; }

        public virtual Продажи Продажи { get; set; }
    }
}

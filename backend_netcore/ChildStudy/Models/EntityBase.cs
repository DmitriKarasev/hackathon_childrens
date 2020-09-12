using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChildStudy.Models
{
    public class EntityBase 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}", ApplyFormatInEditMode = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Дата и время добавления")]
        public DateTime InsertedOn { get; set; }

        [Display(Name = "Кем добавлено")]
        public int InsertedBy { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm:ss}", ApplyFormatInEditMode = true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Дата и время изменения")]
        public DateTime UpdatedOn { get; set; }

        [Display(Name = "Кем изменено")]
        public int UpdatedBy { get; set; }
    }
}

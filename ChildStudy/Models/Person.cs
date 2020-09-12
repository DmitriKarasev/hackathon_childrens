using System;
using System.ComponentModel.DataAnnotations;

namespace ChildStudy.Models
{
    public class User : EntityBase
    {
        /// <summary>
        /// Имя 
        /// </summary>
        [Required]
        [StringLength(150)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата рождения")]
        public DateTime BornDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChildStudy.Models
{
    /// <summary>
    /// Расписание занятий
    /// </summary>
    public class Timetable : EntityBase
    {
        /// <summary>
        /// Урок
        /// </summary> 
        public Lesson Lesson { get; set; }

        /// <summary>
        /// Дата и время занятия
        /// </summary>
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата и время занятия")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Записавшиеся на занятие
        /// </summary>
        public List<Student> Registered { get; set; }

    }
}

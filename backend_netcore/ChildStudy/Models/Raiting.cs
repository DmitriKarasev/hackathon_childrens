namespace ChildStudy.Models
{
    /// <summary>
    /// Рейтинг
    /// </summary> 
    public class Raiting : EntityBase
    {
        /// <summary>
        /// Занятие
        /// </summary> 
        public Timetable Timetable { get; set; }

        /// <summary>
        /// Оценка от учителя
        /// </summary>
        public int TeacherGrade { get; set; }

        /// <summary>
        /// Оценка от студента
        /// </summary>  
        public int StudentGrade { get; set; }
    }
}

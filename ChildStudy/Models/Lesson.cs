namespace ChildStudy.Models
{
    public class Lesson : EntityBase
    {
        /// <summary>
        /// Факультет
        /// </summary>
        public Faculty Faculty { get; set; }

        /// <summary>
        /// Тема
        /// </summary>
        public string Theme { get; set; } 

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Преподаватель
        /// </summary>
        public Teacher Teacher { get; set; }

        /// <summary>
        /// Вместимость занятия
        /// </summary>
        public int Сapacity { get; set; } 

        /// <summary>
        /// Получаема энергия
        /// </summary>
        public int Volume { get; set; }
    }
}

namespace ChildStudy.Models
{
    public class Teacher : EntityBase
    {
        /// <summary>
        /// Пользователь системы
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Пользователь системы
        /// </summary>
        public string Name { get; set; }
    }
}

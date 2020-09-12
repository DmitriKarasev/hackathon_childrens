using System.Collections.Generic;

namespace ChildStudy.Models
{
    public class Student : EntityBase
    { 
        /// <summary>
        /// Пользователь системы
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Рейтинг
        /// </summary>  
        public List<Raiting> Raitings { get; set; }
    }
}

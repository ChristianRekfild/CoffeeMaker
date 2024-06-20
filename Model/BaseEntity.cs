using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Model
{
    /// <summary>
    /// Базовая сущность для всех остальных сущностей
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Создано
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Обновлено
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Кем создано
        /// </summary>
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Кто обновил данные
        /// </summary>
        public Guid UpdatedBy { get; set; }

        /// <summary>
        /// Удалено. True - удалено, false - нет (все хорошо, можно пользоваться!)
        /// </summary>
        public bool Deleted { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Model
{
    /// <summary>
    /// Ресурсы кофемата
    /// </summary>
    public class Resources : BaseEntity
    {
        [StringLength(100)]
        /// <summary>
        /// Имя ресурса
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Осталось
        /// </summary>
        // decimal использован для точности. Вдруг потом будут использованы ресурсы, где это потребуется?
        public decimal Remain { get; set; }

    }

}

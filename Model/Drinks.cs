using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker.Model
{
    public class Drinks
    {
        [StringLength(100)]
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        [StringLength(300)]
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
    }
}

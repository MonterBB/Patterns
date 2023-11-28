using Patterns.AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Blacksmith
{
    /// <summary>
    /// Определяет методы кузницы.
    /// </summary>
    public abstract class Blacksmith
    {
        /// <summary>
        /// Создать нагрудную броню.
        /// </summary>
        /// <returns>Нагрудная броня.</returns>
        public abstract ChestArmor CreateChestArmor();

        /// <summary>
        /// Создать ножную броню.
        /// </summary>
        /// <returns>Ножная броня.</returns>
        public abstract LegArmor CreateLegArmor();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Product.VikingArmor
{
    /// <summary>
    /// Нагрудная броня викингов.
    /// </summary>
    public class VikingChestArmor : ChestArmor
    {
        /// <summary>
        /// Создаёт экземпляр нагрудной брони викингов.
        /// </summary>
        public VikingChestArmor()
        {
            Name = "Нагрудная броня викинга";
        }

        /// <summary>
        /// Защищает грудь.
        /// </summary>
        public override void DefenseChest()
        {
            Console.WriteLine("Сильно защищает грудь");
        }
    }
}

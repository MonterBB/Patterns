using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patterns.AbstractFactory.Product.ChineseArmor
{
    /// <summary>
    /// Нагрудная броня китайцев.
    /// </summary>
    public class ChineseChestArmor: ChestArmor
    {
        /// <summary>
        /// Создаёт экземпляр нагрудной брони китайцев.
        /// </summary>
        public ChineseChestArmor()
        {
            Name = "Нагрудная броня китайца";
        }

        /// <summary>
        /// Защищает грудь.
        /// </summary>
        public override void DefenseChest()
        {
            Console.WriteLine("Слабо защищает грудь");
        }
    }
}

using Patterns.AbstractFactory.Product.VikingArmor;
using Patterns.AbstractFactory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.AbstractFactory.Product.ChineseArmor;

namespace Patterns.AbstractFactory.Blacksmith
{
    /// <summary>
    /// Кузница китайцев.
    /// </summary>
    public class ChineseBlacksmith: Blacksmith
    {
        /// <summary>
        /// Создаёт нагрудную броню китайцев.
        /// </summary>
        /// <returns>Нагрудная броня китайцев</returns>
        public override ChestArmor CreateChestArmor()
        {
            return new ChineseChestArmor();
        }

        /// <summary>
        /// Создаёт ножную броню китайцев.
        /// </summary>
        /// <returns>Ножная броня китайцев.</returns>
        public override LegArmor CreateLegArmor()
        {
            return new ChineseLegArmor();
        }
    }
}

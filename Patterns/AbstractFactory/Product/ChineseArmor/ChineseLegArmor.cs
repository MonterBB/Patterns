using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patterns.AbstractFactory.Product.ChineseArmor
{
    /// <summary>
    /// Ножная броня китайцев.
    /// </summary>
    public class ChineseLegArmor: LegArmor
    {
        /// <summary>
        /// Создаёт экземпляр ножной брони китайцев.
        /// </summary>
        public ChineseLegArmor()
        {
            Name = "Ножная броня китайца";
        }

        /// <summary>
        /// Защищает ноги.
        /// </summary>
        public override void DefenseLeg()
        {
            Console.WriteLine("Слабо защищает ноги");
        }
    }
}

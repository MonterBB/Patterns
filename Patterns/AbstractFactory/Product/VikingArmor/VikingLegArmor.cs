using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patterns.AbstractFactory.Product.VikingArmor
{
    /// <summary>
    /// Ножная броня викингов.
    /// </summary>
    public class VikingLegArmor: LegArmor
    {
        /// <summary>
        /// Создаёт экземпляр ножной брони викингов.
        /// </summary>
        public VikingLegArmor()
        {
            Name = "Ножная броня викинга";
        }

        /// <summary>
        /// Защищает ноги.
        /// </summary>
        public override void DefenseLeg()
        {
            Console.WriteLine("Сильно защищает ноги");
        }
    }
}

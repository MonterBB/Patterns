using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Product
{
    /// <summary>
    /// Ножная броня.
    /// </summary>
    public abstract class LegArmor : IArmor
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Защитить ноги.
        /// </summary>
        public abstract void DefenseLeg();
    }
}

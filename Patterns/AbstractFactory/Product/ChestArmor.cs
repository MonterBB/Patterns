using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Product
{
    /// <summary>
    /// Нагрудная броня.
    /// </summary>
    public abstract class ChestArmor : IArmor
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Защитить грудь.
        /// </summary>
        public abstract void DefenseChest();
    }
}

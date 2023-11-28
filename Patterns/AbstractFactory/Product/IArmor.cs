using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory.Product
{
    /// <summary>
    /// Определяет свойства брони.
    /// </summary>
    public interface IArmor
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }
    }
}

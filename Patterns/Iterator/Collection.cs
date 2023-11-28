using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator
{
    /// <summary>
    /// Коллекция.
    /// </summary>
    public interface Collection
    {
        /// <summary>
        /// Создание итератора человеков.
        /// </summary>
        /// <returns>Итератор человеков.</returns>
        public Iterator GetHumanIterator();
    }
}

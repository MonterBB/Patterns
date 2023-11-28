using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator
{
    /// <summary>
    /// Интерфейс, содержащий набор методов итерации.
    /// </summary>
    public interface Iterator
    {
        /// <summary>
        /// Проверяет, существует ли следующий элемент.
        /// </summary>
        /// <returns>
        /// true - если существует;
        /// false - не существует.
        /// </returns>
        public bool HasNext();

        /// <summary>
        /// Возвращает следующий элемент.
        /// </summary>
        /// <returns>Следующий элемент коллекции.</returns>
        public object MoveNext();
    }
}

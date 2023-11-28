using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method
{
    /// <summary>
    /// Интерфейс яндекс станции.
    /// </summary>
    public interface IYandexStation
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Получение цены.
        /// </summary>
        /// <returns>Цена.</returns>
        public decimal GetPrice();
    }
}

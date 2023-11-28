using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method
{
    /// <summary>
    /// Яндекс Станция Макс
    /// </summary>
    public class MaxStation: IYandexStation
    {
        /// <summary>
        /// Название.
        /// </summary>
        private string _name;

        /// <summary>
        /// Цена.
        /// </summary>
        private decimal _price;

        /// <summary>
        /// Название.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Создаёт экземпляр яндекс станции макс.
        /// </summary>
        /// <param name="price">Цена.</param>
        public MaxStation(decimal price)
        {
            _name = "Яндекс Станция Макс";
            _price = price;
        }

        /// <summary>
        /// Получить цену.
        /// </summary>
        /// <returns>Цена.</returns>
        public decimal GetPrice()
        {
            return _price * 4;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method.Factory
{
    /// <summary>
    /// Фабрика яндекс станций макс.
    /// </summary>
    public class MaxStationFactory: StationFactory
    {
        /// <summary>
        /// Цена.
        /// </summary>
        private decimal _price;

        /// <summary>
        /// Создаёт экземпляр фабрики.
        /// </summary>
        /// <param name="price">Цена.</param>
        public MaxStationFactory(decimal price)
        {
            _price = price;
        }

        /// <summary>
        /// Получить яндекс станцию макс.
        /// </summary>
        /// <returns>Яндекс станция макс.</returns>
        public override IYandexStation GetYandexStation()
        {
            return new MaxStation(this._price);
        }
    }
}

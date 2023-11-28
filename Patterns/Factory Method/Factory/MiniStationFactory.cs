using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method
{
    /// <summary>
    /// Фабрика яндекс станций мини.
    /// </summary>
    public class MiniStationFactory: StationFactory
    {
        /// <summary>
        /// Цена.
        /// </summary>
        private decimal _price;

        /// <summary>
        /// Создаёт экземпляр фабрики.
        /// </summary>
        /// <param name="price">Цена.</param>
        public MiniStationFactory(decimal price)
        {
            _price = price;
        }

        /// <summary>
        /// Получить яндекс станцию мини.
        /// </summary>
        /// <returns>Яндекс станция мини.</returns>
        public override IYandexStation GetYandexStation() 
        {
            return new MiniStation(this._price);
        }
    }
}

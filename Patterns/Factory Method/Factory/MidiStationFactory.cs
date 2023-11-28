using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method.Factory
{
    /// <summary>
    /// Фабрика яндекс станций миди.
    /// </summary>
    public class MidiStationFactory: StationFactory
    {
        /// <summary>
        /// Цена.
        /// </summary>
        private decimal _price;

        /// <summary>
        /// Создаёт экземпляр фабрики.
        /// </summary>
        /// <param name="price">Цена.</param>
        public MidiStationFactory(decimal price)
        {
            _price = price;
        }

        /// <summary>
        /// Получить яндекс станцию миди.
        /// </summary>
        /// <returns>Яндекс станция миди.</returns>
        public override IYandexStation GetYandexStation()
        {
            return new MidiStation(this._price);
        }
    }
}

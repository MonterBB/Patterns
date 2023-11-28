using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Factory_Method.Factory
{
    /// <summary>
    /// Класс управления фабричными методами.
    /// </summary>
    public static class YandexStationFactory
    {
        /// <summary>
        /// Выбор фабричного метода.
        /// </summary>
        /// <param name="stationType">Тип станции.</param>
        /// <returns>Фабрика яндекс станций.</returns>
        public static StationFactory GetFactory(string stationType)
        {
            decimal basePrice = 10000;

            switch (stationType)
            {
                case "Мини":
                    return new MiniStationFactory(basePrice);

                case "Миди":
                    return new MidiStationFactory(basePrice);

                case "Макс":
                    return new MaxStationFactory(basePrice);

                default:
                    return null;
            }
        }
    }
}

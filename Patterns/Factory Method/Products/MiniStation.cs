namespace Patterns.Factory_Method
{
    /// <summary>
    /// Яндекс Станция Мини
    /// </summary>
    public class MiniStation : IYandexStation
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
        /// Создаёт экземпляр яндекс станции миди.
        /// </summary>
        /// <param name="price">Цена.</param>
        public MiniStation(decimal price)
        {
            _name = "Яндекс Станция Мини";
            _price = price;
        }

        /// <summary>
        /// Получить цену.
        /// </summary>
        /// <returns>Цена.</returns>
        public decimal GetPrice()
        {
            return _price;
        }
    }
}

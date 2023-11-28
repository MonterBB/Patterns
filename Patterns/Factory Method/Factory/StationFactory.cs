namespace Patterns.Factory_Method
{
    /// <summary>
    /// Абстрактный класс, определяет фабричный метод.
    /// </summary>
    public abstract class StationFactory
    {
        /// <summary>
        /// Получить яндекс станцию.
        /// </summary>
        /// <returns>Яндекс станция.</returns>
        public abstract IYandexStation GetYandexStation();
    }
}

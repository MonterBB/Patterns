using Patterns.Singleton;

namespace Patterns.Iterator
{
    /// <summary>
    /// Люди.
    /// </summary>
    public class Humans : Collection
    {
        /// <summary>
        /// Имя людей.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список людей.
        /// </summary>
        private Human[] HumanList;

        /// <summary>
        /// Создаёт экземпляр людей.
        /// </summary>
        /// <param name="name">Имя людей.</param>
        /// <param name="humans">Список людей.</param>
        public Humans(string name, Human[] humans)
        {
            Name = name;
            HumanList = humans;
        }

        /// <summary>
        /// Создаёт итератор человеков.
        /// </summary>
        /// <returns>Итератор человеков.</returns>
        public Iterator GetHumanIterator()
        {
            return new HumansIterator(HumanList);
        }

        /// <summary>
        /// Реализация итератора человеков.
        /// </summary>
        private class HumansIterator : Iterator
        {
            /// <summary>
            /// Список людей.
            /// </summary>
            private Human[] Humans;

            /// <summary>
            /// Текущий индекс.
            /// </summary>
            private int index;

            /// <summary>
            /// Инициализирует экземпляр итератора человеков.
            /// </summary>
            /// <param name="humans">Список людей.</param>
            public HumansIterator(Human[] humans)
            {
                Humans = humans;
            }

            /// <summary>
            /// Проверяет, существует ли следующий элемент.
            /// </summary>
            /// <returns>
            /// true - если существует;
            /// false - не существует.
            /// </returns>
            public bool HasNext()
            {
                if (index < Humans.Length)
                {
                    return true;
                }

                return false;
            }

            /// <summary>
            /// Возвращает следующий элемент.
            /// </summary>
            /// <returns>Следующий элемент коллекции.</returns>
            public object MoveNext()
            {
                Console.WriteLine("Тут можно чё-то наделать");
                return Humans[index++];
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    /// <summary>
    /// Релизация паттерна Singleton.
    /// Бог.
    /// </summary>
    public class God
    {
        /// <summary>
        /// Бог.
        /// </summary>
        private static God _god { get; set; }

        /// <summary>
        /// Имя бога.
        /// </summary>
        public string Name;

        /// <summary>
        /// Приватный конструктор.
        /// </summary>
        /// <param name="name"></param>
        private God(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Создаёт экземпляр бога и контролирует чтобы он был единственным.
        /// </summary>
        /// <param name="name">Имя бога.</param>
        /// <returns>Экземпляр бога.</returns>
        public static God GetGod(string name)
        {
            if (_god == null)
            {
                _god = new God(name);
            }

            return _god;
        }

        /// <summary>
        /// Переопеделение метода ToString.
        /// </summary>
        /// <returns>Строка с основными параметрами бога.</returns>
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

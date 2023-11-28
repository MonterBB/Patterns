using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    /// <summary>
    /// Человек.
    /// </summary>
    public class Human
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Бог внутри.
        /// </summary>
        public God God { get; set; }

        /// <summary>
        /// Создаёт экземпляр человека.
        /// </summary>
        /// <param name="name">Имя человека.</param>
        /// <param name="godName">Имя бога.</param>
        public Human(string name, string godName)
        {
            Name = name;
            God = God.GetGod(godName);
        }

        /// <summary>
        /// Переопеделение метода ToString.
        /// </summary>
        /// <returns>Строка с основными параметрами человека.</returns>
        public override string ToString()
        {
            return $"Имя человека: {Name}"
                + Environment.NewLine
                + $"Бог: {God.ToString()}";
        }
    }
}

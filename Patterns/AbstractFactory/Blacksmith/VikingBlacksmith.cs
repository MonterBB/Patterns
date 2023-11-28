using Patterns.AbstractFactory.Product;
using Patterns.AbstractFactory.Product.VikingArmor;

namespace Patterns.AbstractFactory.Blacksmith
{
    /// <summary>
    /// Кузница викингов.
    /// </summary>
    public class VikingBlacksmith : Blacksmith
    {
        /// <summary>
        /// Создаёт нагрудную броню викингов.
        /// </summary>
        /// <returns>Нагрудная броня викингов.</returns>
        public override ChestArmor CreateChestArmor()
        {
            return new VikingChestArmor();
        }

        /// <summary>
        /// Создаёт ножную броню викингов.
        /// </summary>
        /// <returns>Ножная броня викингов.</returns>
        public override LegArmor CreateLegArmor()
        {
            return new VikingLegArmor();
        }
    }
}

using Patterns.Singleton;
using Patterns.Iterator;
using Patterns.Factory_Method;
using System.Runtime.CompilerServices;
using Patterns.Factory_Method.Factory;
using Patterns.AbstractFactory.Blacksmith;

// SINGLETON

Console.WriteLine("---------------SINGLETON:");

var human1 = new Human("Человек", "Бог един");

Console.WriteLine(human1.God.Name);

human1.God = God.GetGod("Перун");

Console.WriteLine(human1.God.Name);

// ITERATOR

Console.WriteLine();
Console.WriteLine("---------------ITERATOR:");

var human2 = new Human("Человек2", human1.God.Name);

var carShowroom = new Humans("Человеки", new Human[] { human1, human2 });

var carIterator = carShowroom.GetHumanIterator();

Console.WriteLine(carShowroom.Name);

while(carIterator.HasNext())
{
    Console.WriteLine();
    Console.WriteLine(carIterator.MoveNext().ToString());
}

// FACTORY METHOD

Console.WriteLine();
Console.WriteLine("---------------FACTORY METHOD:");

string[] stationTypes = new string[] { "Мини", "Миди", "Макс" };

Random random = new Random();

// Factory method удобно использовать когда заранее не известно какой именно объект нужен.
var stationFactory = YandexStationFactory.GetFactory(stationTypes[random.Next(0, 3)]);

var station = stationFactory.GetYandexStation();

Console.WriteLine($"Название: {station.Name}; Цена: {station.GetPrice()}");

// ABSTRACT FACTORY
// Можно удобно переключаться между фабриками.

Console.WriteLine();
Console.WriteLine("---------------ABSTRACT FACTORY:");

object[] blacksmiths = new object[] {new ChineseBlacksmith(), new VikingBlacksmith()};

Blacksmith currentBlacksmith = (Blacksmith)blacksmiths[random.Next(0, 2)];

var chestArmor = currentBlacksmith.CreateChestArmor();
var legArmor = currentBlacksmith.CreateLegArmor();

chestArmor.DefenseChest();
legArmor.DefenseLeg();

Console.WriteLine();

for (var i = 0; i < 5; i++)
{
    currentBlacksmith = (Blacksmith)blacksmiths[random.Next(0, 2)];

    chestArmor = currentBlacksmith.CreateChestArmor();
    legArmor = currentBlacksmith.CreateLegArmor();

    chestArmor.DefenseChest();
    legArmor.DefenseLeg();

    Console.WriteLine();
}
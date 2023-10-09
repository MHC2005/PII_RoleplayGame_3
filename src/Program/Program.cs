using System;
using RoleplayGame;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Wizard emi = new Wizard("Emilia");
            Wizard maru = new Wizard("Maru");
            Dwarf mateito = new Dwarf("Mateo");
            Knight franco = new Knight("Franco");

            emi.AddItem(book);
            maru.AddItem(book);

            Console.WriteLine($"Mateito has ❤️ {mateito.Health}");
            Console.WriteLine($"Emi attacks Mateito with ⚔️ {emi.AttackValue}");

            mateito.ReceiveAttack(emi.AttackValue);

            Console.WriteLine($"Mateito has ❤️ {mateito.Health}");

            mateito.Cure();

            Console.WriteLine($"Someone cured Gimli. Gimli now has ❤️ {mateito.Health}");

            Enemy lotso = new Enemy("Lotso", 4);
            Enemy sauron = new Enemy("Sauron", 1);
            Enemy ursula = new Enemy("Ursula", 2);
            Enemy yzma = new Enemy("Yzma", 2);

            List<Enemy> enemies = new List<Enemy>();
            enemies.Add(lotso);
            enemies.Add(sauron);
            enemies.Add(ursula);
            enemies.Add(yzma);

            List<Hero> heroes = new List<Hero>();
            heroes.Add(emi);
            heroes.Add(maru);
            heroes.Add(mateito);
            heroes.Add(franco);


            Encounter encounter = new Encounter(heroes, enemies); // Crear una instancia de Encounter y realizar el encuentro
            encounter.DoEncounter();
        }
    }
}

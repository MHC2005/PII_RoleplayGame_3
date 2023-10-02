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
            Dwarf franco = new Dwarf("Franco");

            List<ICharacter> heroes = new List<ICharacter>();
            heroes.Add(emi);
            heroes.Add(maru);
            heroes.Add(mateito);
            heroes.Add(franco);

            emi.AddItem(book);
            maru.AddItem(book);
            
            Console.WriteLine($"Mateo has ❤️  {mateito.Health}"); //el valor de salud de mateo
            Console.WriteLine($"Franco has ❤️  {franco.Health}"); //el valor de salud de franco
            Console.WriteLine($"Maru has ❤️  {maru.Health}"); //valor de salud de maru
            Console.WriteLine($"Emilia has ❤️  {emi.Health}"); //valor de salud de emi

            Enemy lotso = new Enemy("Lotso", 100);
            Enemy sauron = new Enemy("Sauron", 120);
            Enemy ursula = new Enemy("Ursula", 180);
            Enemy yzma = new Enemy("Yzma", 200);

            List<ICharacter> enemies = new List<ICharacter>();
            enemies.Add(lotso);
            enemies.Add(sauron);
            enemies.Add(ursula);
            enemies.Add(yzma);

            Console.WriteLine($"Lotso's VP is {lotso.VP}"); // Imprimo el VP de Lotso
            Console.WriteLine($"Sauron's VP is {sauron.VP}"); // Imprimo el VP de Sauron
            Console.WriteLine($"Ursula's VP is {ursula.VP}"); // Imprimo el VP de Ursula
            Console.WriteLine($"Yzma's VP is {yzma.VP}"); // Imprimo el VP de Yzma

            Encounter encounter = new Encounter(heroes, enemies); // Crear una instancia de Encounter y realizar el encuentro
            encounter.DoEncounter();

            mateito.Cure();

            Console.WriteLine($"Someone cured Mathew. Mathew now has ❤️  {mateito.Health}");

            Console.WriteLine($"Mateo has ❤️  {mateito.Health}"); //el valor de salud de mateo
            Console.WriteLine($"Franco has ❤️  {franco.Health}"); //el valor de salud de franco
            Console.WriteLine($"Maru has ❤️  {maru.Health}"); //valor de salud de maru
            Console.WriteLine($"Emilia has ❤️  {emi.Health}"); //valor de salud de emi
        }
    }
}

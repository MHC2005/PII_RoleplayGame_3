using System;
using RoleplayGame;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero1 = new Hero("Hero1", 0);
            Hero hero2 = new Hero("Hero2", 0);

            // Crear instancias de enemigos
            Enemy enemy1 = new Enemy("Enemy1", 10);
            Enemy enemy2 = new Enemy("Enemy2", 15);

             // Crear listas de héroes y enemigos
            List<ICharacter> heroes = new List<ICharacter> { hero1, hero2 };
            List<ICharacter> enemies = new List<ICharacter> { enemy1, enemy2 };

            // Crear una instancia de Encounter pasando las listas de héroes y enemigos
            Encounter encounter = new Encounter(heroes, enemies);

            // Llamar a DoEncounter() para ejecutar el encuentro
            encounter.DoEncounter();

            // Imprimir los valores de VP después del encuentro
            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Name}'s VP is {hero.VP}");
            }
            foreach (var enemy in enemies)
            {
                Console.WriteLine($"{enemy.Name}'s VP is {enemy.VP}");
            }

        }
    }
}
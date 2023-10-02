using System;
using System.Collections.Generic;
using System.Linq;

namespace RoleplayGame
{
    public class Encounter
    {
        private List<ICharacter> heroes; // Declaro una lista privada de ICharacter para almacenar héroes
        private List<ICharacter> enemies; // Declaro una lista privada de ICharacter para almacenar enemigos

        public Encounter(List<ICharacter> heroes, List<ICharacter> enemies)
        {
            this.heroes = heroes;   // Inicializo la lista de héroes con la lista pasada como argumento al constructor

            this.enemies = enemies; // Inicializo la lista de enemies con la lista pasada como argumento al constructor
        }

      
        public void DoEncounter()
        {
            while (heroes.Count > 0 && enemies.Count > 0) //creo un bucle en el que hay heroes y enemigos vivios
            {
                // Los enemigos atacan primero
                foreach (var enemy in enemies)
                {
                    if (heroes.Count > 0)   //Count es una propiedad que devuelve el número de elementos contenidos en la lista heroes
                    {
                        var targetHero = heroes[0]; // Selecciona al primer héroe en la lista de héroes
                        enemy.ReceiveAttack(targetHero.AttackValue); // el enemigo attack al hero en la posicion 0 de la lista 
                        Console.WriteLine($"{enemy.Name} ataca a {targetHero.Name}.");
                        if (targetHero.Health <= 0) // chequea que el hero no tenga vida
                        {
                            heroes.Remove(targetHero); // saca al hero muerto de la lista
                            Console.WriteLine($"{targetHero.Name} fue asesinado por {enemy.Name}.");
                            if (targetHero.VP >= 5) // Verifica si el hero gano 5 o más VP
                            {
                                targetHero.Cure(); //cura al hero que gano 5 o mas VP
                                Console.WriteLine($"{targetHero.Name} se ha curado.");
                            }
                        }
                    }
                }

                    
                // Los héroes atacan a los enemigos
                var enemiesList = enemies.ToList();
                foreach (var hero in heroes)
                {
                    foreach (var enemy in enemiesList) // se itera sobre cada elemento en la lista enemiesList.
                    {
                        // El héroe ataca al enemigo
                        enemy.ReceiveAttack(hero.AttackValue);
                        Console.WriteLine($"{hero.Name} ataca a {enemy.Name}.");

                        if (enemy.Health <= 0)
                        {
                            // Incrementamos los VP solo para héroes
                            foreach (var h in heroes)
                            {
                                if (h is Hero)
                                {
                                    var heroCharacter = h as Hero;
                                    heroCharacter.VP += enemy.VP;
                                }
                            }

                            // Eliminamos al enemigo derrotado de la lista
                            enemies.Remove(enemy);
                            Console.WriteLine($"{enemy.Name} ha sido derrotado por {hero.Name}.");
                        }
                    }
                }
            }

            Console.WriteLine("El encuentro ha terminado.");
        }
    }
}
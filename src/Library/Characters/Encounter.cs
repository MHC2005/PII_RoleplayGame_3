using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace RoleplayGame
{
    public class Encounter
    {
        public List<Hero> heroes;

        public List<Enemy> enemigos;

        public Encounter(List<Hero> heroes, List<Enemy> enemigos)
        {

            this.heroes = heroes;
            this.enemigos = enemigos;

        }

        public void DoEncounter()
        {

            while (heroes.Count > 0 && enemigos.Count > 0)
            {

                //enemigos atacan primero
                if (heroes.Count == 1)
                {      //solo hay un heroe

                    int target = 0;         //heroe que van a atacar
                    int ene = 0;
                    while (heroes.Count == 1 && ene < enemigos.Count )
                    {     //cada enemigo ataca al heroe

                        heroes[target].ReceiveAttack(enemigos[ene].AttackValue);  //ataque al heroe
                        Console.WriteLine($"{enemigos[ene].Name} ataca a {heroes[target].Name}.");
                        if (heroes[target].Health <= 0)
                        {

                            Console.WriteLine($"{heroes[target].Name} fue asesinado por {enemigos[ene].Name}.");
                            heroes.Remove(heroes[target]);
                        
                        }
                        ene += 1;

                    }

                }
                else
                {
                    if (heroes.Count < enemigos.Count)
                    {
                        int target = 0;

                        foreach (Enemy ene in enemigos)
                        {
                            heroes[target].ReceiveAttack(ene.AttackValue);  //ataque al heroe
                            Console.WriteLine($"{ene.Name} ataca a {heroes[target].Name}.");
                            if (heroes[target].Health <= 0)
                            {

                                
                                Console.WriteLine($"{heroes[target].Name} fue asesinado por {ene.Name}.");
                                heroes.Remove(heroes[target]);


                            }
                            target += 1;

                            if (target >= heroes.Count)
                            {
                                target = 0;
                            }

                        }
                    }
                    else
                    {
                        int target = 0;

                        foreach (Enemy ene in enemigos)
                        {
                            heroes[target].ReceiveAttack(ene.AttackValue);  //ataque al heroe
                            Console.WriteLine($"{ene.Name} ataca a {heroes[target].Name}.");
                            if (heroes[target].Health <= 0)
                            {

                                heroes.Remove(heroes[target]);
                                Console.WriteLine($"{heroes[target].Name} fue asesinado por {ene.Name}.");


                            }
                            target += 1;

                        }

                    }
                }

                //atacan los heroes
                foreach (Hero her in heroes)
                {
                    for( int i = 0; i < enemigos.Count ; i++)
                    {
                        enemigos[i].ReceiveAttack(her.AttackValue);
                        Console.WriteLine($"{her.Name} ataca a {enemigos[i].Name}.");

                        if (enemigos[i].Health <= 0)
                        {

                            
                            her.VP += enemigos[i].VP;
                            Console.WriteLine($"{enemigos[i].Name} ha sido derrotado por {her.Name}.");
                            if (her.VP >= 5)
                            {
                                her.Cure(); //cura al hero que gano 5 o mas VP
                                Console.WriteLine($"{her.Name} se ha curado.");
                            }
                            enemigos.Remove(enemigos[i]);

                        }
                    }
                }



            }
            if (heroes.Count < enemigos.Count)
            {
                Console.WriteLine("El encuentro ha finalizado. Los enemigos ganan");
            }
            else
            {
                Console.WriteLine("El encuentro ha finalizado. Los heroes ganan");
            }

        }

    }
}
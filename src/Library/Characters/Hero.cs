using System;
using System.Collections.Generic;
namespace RoleplayGame
{
    public class Hero : ICharacter
    {
        private int health = 100;

        private List<IItem> items = new List<IItem>();

        public Hero(string name, int vp)
        {
            this.Name = name;
            this.VP = vp;
            
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }

        public string Name { get; set; }

        public int VP { get; set; }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

      
        public void ReceiveAttack(int power)
        {
            int remainingPower = power;

            foreach (IItem item in this.items)
            {
<<<<<<< HEAD
                if (item is IDefenseItem)
                {
                    int defenseValue = (item as IDefenseItem).DefenseValue;

                    if (defenseValue >= remainingPower)
                    {
                        // El item puede absorber todo el poder del ataque
                        (item as IDefenseItem).ReduceDefense(remainingPower);
                        return; // Salir del bucle porque el ataque ha sido completamente bloqueado.
                    }
                    else
                    {
                        // El item solo puede absorber parte del poder del ataque
                        (item as IDefenseItem).ReduceDefense(defenseValue);
                        remainingPower -= defenseValue;
                    }
                }
=======
                this.Health -= power - this.DefenseValue;
>>>>>>> 3147cd69d664ffa33e50e55de76368448bb8c557
            }

            // Si llegamos aquí, significa que el ataque restante ha superado la defensa de todos los elementos defensivos,
            // y afecta directamente a la salud del personaje.
            this.Health -= remainingPower;
        }



        public void Cure()
        {
            this.Health = 100;
        }

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }
    }
}
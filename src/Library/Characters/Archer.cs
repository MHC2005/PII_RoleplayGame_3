using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer: Hero
    {

        public Archer(string name) : base(name, 0) // Aca llamo al constructor base con 0 VP
        {
            this.Name = name;
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }
    }
}
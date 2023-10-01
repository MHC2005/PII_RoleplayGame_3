using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard : Hero
    {

        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

        public Wizard(string name) : base(name,0)
        {
            this.AddItem(new Staff());
        }
        public void AddItem(IMagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        public void RemoveItem(IMagicalItem item)
        {
            this.magicalItems.Remove(item);
        }
    }
}
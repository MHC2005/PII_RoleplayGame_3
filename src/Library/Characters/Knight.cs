using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight : Hero, IDefenseItem // Implementa la interfaz IDefenseItem
    {
        public Knight(string name) : base(name, 0)
        {
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }

        // Implementa el método ReduceDefense de la interfaz IDefenseItem
        public void ReduceDefense(int amount)
        {
            // Implementa aquí la lógica específica de reducción de defensa para el Knight, si es necesario.
            // Puedes usar este método para ajustar la defensa del Knight cuando reciba un ataque.
        }
    }
}
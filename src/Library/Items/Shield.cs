namespace RoleplayGame
{
    public class Shield: IDefenseItem
    {    
    public int DefenseValue { get; private set; }

        public Shield()
        {
            this.DefenseValue = 20; // Establece el valor de defensa inicial del escudo.
        }

        public void ReduceDefense(int amount)
        {
            this.DefenseValue -= amount;
            if (this.DefenseValue < 0)
            {
                this.DefenseValue = 0;
            }
        }    
    }
}


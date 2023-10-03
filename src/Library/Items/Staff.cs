namespace RoleplayGame
{
    public class Staff : IAttackItem, IDefenseItem
    {
        public int AttackValue
        {
            get
            {
                return 100;
            }
        }

        public int DefenseValue
        {
            get
            {
                return 100;
            }
        }

        public void ReduceDefense(int amount)
        {
            // Implementa la reducción de defensa aquí, si es necesario.
            // Puedes elegir no hacer nada si el Staff no debe reducir su defensa.
        }
    }
}



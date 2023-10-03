namespace RoleplayGame
{
    
        public class Armor : IDefenseItem
        {
            private int currentDefense;

            public int DefenseValue
            {
                get
                {
                    return currentDefense;
                }
            }

            public Armor(int initialDefenseValue)
            {
                currentDefense = initialDefenseValue;
            }

            public void ReduceDefense(int amount)
            {
                currentDefense -= amount;
                if (currentDefense < 0)
                {
                    currentDefense = 0;
                }
            }
        }
}
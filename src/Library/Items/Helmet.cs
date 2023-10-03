namespace RoleplayGame{
    public class Helmet : IDefenseItem
    {
        private int defenseValue;

        public int DefenseValue
        {
            get { return defenseValue; }
            set
            {
                // Validar que el valor de defensa no sea negativo
                defenseValue = value < 0 ? 0 : value;
            }
        }

        public Helmet(int initialDefenseValue)
        {
            // Asignar el valor de defensa inicial, asegurándote de que no sea negativo
            DefenseValue = initialDefenseValue;
        }

        public void ReduceDefense(int amount)
        {
            // Implementa la reducción de defensa aquí, si es necesario.
            // Puedes elegir no hacer nada si el casco no debe reducir su defensa.
            // Por ejemplo, podrías tener una lógica que reduzca la defensa del casco
            // en función de la cantidad recibida como parámetro.
            DefenseValue -= amount;
            if (DefenseValue < 0)
            {
                DefenseValue = 0;
            }
        }
    }
}
namespace RoleplayGame
{
    public interface IDefenseItem
    {
        int DefenseValue { get; set; }
        void ReduceDefense(int amount);
    }
}
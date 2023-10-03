namespace RoleplayGame
{
    public interface IDefenseItem
    {
        int DefenseValue { get; }
        void ReduceDefense(int amount);
    }
}
namespace Laitis.Contracts.Enums
{
    /// <summary>
    /// Comparison operators For IfVariableValue actions
    /// <seealso cref="ActionType.IfVariableValue"/>
    /// </summary>
    public enum VariableOperator
    {
        Exists = 0,
        Equals = 1,
        NotEquals = 2,
        Bigger = 3,
        Smaller = 4,
        BiggerOrEquals = 5,
        SmallerOrEquals = 6,
    }
}
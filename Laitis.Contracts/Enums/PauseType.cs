namespace Laitis.Contracts.Enums
{
    /// <summary>
    /// Used for Laitis Pause Actions
    /// 
    /// <seealso cref="ActionType.Pause"/>
    /// </summary>
    public enum PauseType
    {
        /// <summary>
        /// Pause for specific amount of milliseconds
        /// </summary>
        Time = 0,

        /// <summary>
        /// Pause until any Laitis audio playing ended
        /// </summary>
        AudioEnd = 1,
    }
}

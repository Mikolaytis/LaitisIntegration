namespace Laitis.Contracts.Enums
{
    /// <summary>
    /// Mouse move type for Mouse Move Action
    /// <seealso cref="ActionType.MouseMove"/>
    /// </summary>
    public enum MouseMoveType
    {
        /// <summary>
        /// Move mouse to point on screen
        /// </summary>
        Point = 0,

        /// <summary>
        /// Move mouse relatively current position
        /// </summary>
        Relative = 1
    }
}
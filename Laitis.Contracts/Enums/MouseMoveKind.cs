namespace Laitis.Contracts.Enums
{
    /// <summary>
    /// Mouse move kind for Mouse Move Action
    /// <seealso cref="ActionType.MouseMove"/>
    /// </summary>
    public enum MouseMoveKind
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
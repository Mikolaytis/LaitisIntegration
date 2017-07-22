namespace Laitis.Contracts.Enums
{
    /// <summary>
    /// Keyboard button click types for Hotkeys action
    /// <seealso cref="ActionType.Hotkeys"/>
    /// </summary>
    public enum ButtonAction
    {
        /// <summary>
        /// Momentum press and release of a button
        /// </summary>
        Click = 0,

        /// <summary>
        /// Just a press of button
        /// </summary>
        Press = 1,

        /// <summary>
        /// Just a release of button
        /// </summary>
        Release = 2,

        /// <summary>
        /// Long press and release of a button
        /// around 100 ms
        /// </summary>
        LongClick = 3
    }
}
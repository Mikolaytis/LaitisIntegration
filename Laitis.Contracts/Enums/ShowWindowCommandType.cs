namespace Laitis.Contracts.Enums
{
    /// <summary>
    /// Show Window Action have some different commands
    /// <seealso cref="ActionType.ShowWindow"/>
    /// </summary>
    public enum ShowWindowCommandType
    {
        /// <summary>
        /// Show window if it minimized
        /// </summary>
        Show = 0,

        /// <summary>
        /// Maximize window to full screen
        /// </summary>
        Maximize = 1,

        /// <summary>
        /// Minimize window into taskbar
        /// </summary>
        Minimize = 2,

        /// <summary>
        /// Hide window from screen
        /// </summary>
        Hide = 3
    }
}
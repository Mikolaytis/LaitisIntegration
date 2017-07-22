namespace Laitis.Contracts.Enums
{
    /// <summary>
    /// Used in Web Browser Navigation
    /// <seealso cref="ActionType.WebPageNavigate"/>
    /// </summary>
    public enum WebPageNavigateAction
    {
        /// <summary>
        /// Set index/position of navigation caret
        /// </summary>
        SetIndex = 0,

        /// <summary>
        /// Increase index/position of navigation caret
        /// </summary>
        AddIndex = 1,

        /// <summary>
        /// Decrease index/position of navigation caret
        /// </summary>
        SubstractIndex = 2
    }
}
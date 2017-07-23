using Laitis.Contracts.Enums;

namespace Laitis.Contracts
{
    /// <summary>
    /// Command Action is part of Laitis Command
    /// </summary>
    public class CommandAction
    {
        /// <summary>
        /// Type of Action
        /// Every action type has own parameters
        /// <seealso cref="ActionType"/>
        /// </summary>
        public ActionType T { get; set; }

        /// <summary>
        /// Array of Action parameters
        /// Parameters count depends on Action Type
        /// Any parameter type is converted to string tp simplify serialization 
        /// </summary>
        public string[] P { get; set; }
    }
}

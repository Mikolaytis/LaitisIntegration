using Laitis.Contracts.Enums;

namespace Laitis.Contracts
{
    /// <summary>
    /// Contract that describes Request to Laitis application
    /// </summary>
    public class ApiRequest
    {
        /// <summary>
        /// Type of Api Request
        /// Other depends on that property
        /// <seealso cref="ApiRequestType"/>
        /// </summary>
        public ApiRequestType T { get; set; }

        /// <summary>
        /// Array of command actions for ApiRequestType.SendActions
        /// Leave it null for other api request types
        /// <seealso cref="CommandAction"/>
        /// </summary>
        public CommandAction[] A { get; set; }

        /// <summary>
        /// string parameter for requests
        /// </summary>
        public string V { get; set; }
    }
}

using System.Runtime.Serialization;

namespace Laitis.Contracts
{
    /// <summary>
    /// Contract that describes Request to Laitis application
    /// </summary>
    [DataContract]
    public class ApiRequest
    {
        /// <summary>
        /// Type of Api Request
        /// Other depends on that property
        /// <seealso cref="ApiRequestType"/>
        /// </summary>
        [DataMember(Name = "M")]
        public ApiRequestType ApiRequestType { get; set; }

        /// <summary>
        /// Array of command actions for ApiRequestType.SendActions
        /// Leave it null for other api request types
        /// <seealso cref="CommandAction"/>
        /// </summary>
        [DataMember(Name = "A")]
        public CommandAction[] Actions { get; set; }

        /// <summary>
        /// string parameter for ApiRequestType.SendVoiceCommand
        /// Leave it null for other api request types
        /// </summary>
        [DataMember(Name = "P")]
        public string Parameter { get; set; }
    }
}

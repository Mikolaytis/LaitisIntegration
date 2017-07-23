namespace Laitis.Contracts
{
    /// <summary>
    /// Api request type for Api Request
    /// </summary>
    public enum ApiRequestType
    {
        /// <summary>
        /// Send voice command to Laitis like it was sayed by a human into microphone
        /// It can activate VoiceCommand, or any functional in laitis
        /// </summary>
        SendVoiceCommand = 0,

        /// <summary>
        /// Send Actions to Laitis to perform them by Laitis.
        /// Actions is a part of VoiceCommand in Laitis.
        /// <seealso cref="CommandAction"/>
        /// </summary>
        SendActions = 1
    }
}

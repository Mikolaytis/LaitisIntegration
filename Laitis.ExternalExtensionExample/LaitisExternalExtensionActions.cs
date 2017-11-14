using Laitis.Contracts;
using Laitis.Contracts.Enums;

namespace Laitis.ExternalExtensionExample
{
    /// <summary>
    /// Just a class with actions that are invoked by UI.
    /// Actions are sended to laitis using LaitisCommunicator
    /// <seealso cref="LaitisCommunicator"/>
    /// </summary>
    public static class LaitisExternalExtensionActions
    {
        /// <summary>
        /// Send Hello string like it was said by a human into microphone
        /// </summary>
        public static void SendHelloVoiceCommand()
        {
            new LaitisCommunicator().SendRequest(new ApiRequest
            {
                R/*equest*/ = ApiRequestType.SendVoiceCommand,
                P/*arameter*/ = "Hello"
            });
        }

        /// <summary>
        /// Send Action to Laitis to pronounce extension information
        /// </summary>
        public static void SendSayInfoAction()
        {
            new LaitisCommunicator().SendRequest(new ApiRequest
            {
                R/*equest*/ = ApiRequestType.SendActions,
                A/*ctions*/ = new[]
                {
                    new CommandAction
                    {
                        T/*ype*/ = ActionType.Say,
                        P/*arameters*/ = new []
                        {
                            "This is message from external extension"
                        }
                    }
                }
            });
        }
    }
}

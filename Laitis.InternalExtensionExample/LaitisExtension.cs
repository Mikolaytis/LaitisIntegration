using System;
using System.Threading;
using Laitis.Contracts;
using Laitis.Contracts.Enums;

namespace Laitis.InternalExtensionExample //Namespace should be equal to DLL file name without extension
{
    /// <summary>
    /// Laitis Internal Extension
    /// 
    /// Requirements:
    /// .Net Framework 4.5
    /// Laitis.Contracts project reference
    /// Costura.Fody reference to get one extension dll after compilation
    /// 
    /// 
    /// After compile in release configuration with Costura.Fody copy result DLL file into AppData/Local/Laitis/Extensions
    /// </summary>
    public static class LaitisExtension // Main Class should be named LaitisExtension
    {
        /// <summary>
        /// Main function of extension like main() in any other program
        /// </summary>
        /// <param name="sendApiRequestAction">Invoke that action to send requests to laitis from your extension</param>
        public static void Run(Action<object> sendApiRequestAction)
        {
            //Send Hello string like it was said by a human into microphone
            sendApiRequestAction(new ApiRequest
            {
                R/*equest*/ = ApiRequestType.SendVoiceCommand,
                P/*arameter*/ = "Привет"
            });
            
            Thread.Sleep(2000);

            //Send Action to Laitis to pronounce extension information
            sendApiRequestAction(new ApiRequest
            {
                R/*equest*/ = ApiRequestType.SendActions,
                A/*ctions*/ = new[]
                {
                    new CommandAction
                    {
                        T/*ype*/ = ActionType.Say,
                        P/*arameters*/ = new []
                        {
                            "Это тестовое ресширение"
                        }
                    }
                }
            });
        }
    }
}

using System;
using System.Threading;
using Laitis.Contracts;

namespace Laitis.InternalExtensionExample
{
    public static class LaitisExtension
    {
        public static void Run(
            Action<object> sendApiRequestAction)
        {
            sendApiRequestAction(new ApiRequest
            {
                ApiRequestType = ApiRequestType.SendVoiceCommand,
                Parameter = "Привет"
            });
            Thread.Sleep(20000);
        }
    }
}

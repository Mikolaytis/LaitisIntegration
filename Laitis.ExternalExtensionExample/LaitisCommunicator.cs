using System.IO;
using System.IO.Pipes;
using Laitis.Contracts;
using Newtonsoft.Json;

namespace Laitis.ExternalExtensionExample
{
    /// <summary>
    /// Laitis extensions can communicate with Laitis over Named Pipes
    /// https://msdn.microsoft.com/ru-ru/library/windows/desktop/aa365590(v=vs.85).aspx
    /// </summary>
    public class LaitisCommunicator
    {
        /// <summary>
        /// It's name of Laitis single named pipe for external extensions
        /// </summary>
        public const string LaitisExternalExtensionPipeName = "LaitisPublicApiService";

        /// <summary>
        /// That method converts ApiRequest contract into JSON and calls SendRequest string method to send serialized json to Laitis
        /// http://www.json.org/
        /// </summary>
        /// <param name="request">ApiRequest contract. Laitis processing only messages of that contract serialized into JSON</param>
        public void SendRequest(ApiRequest request)
        {
            var requestString = JsonConvert.SerializeObject(request);
            SendRequest(requestString);
        }

        /// <summary>
        /// That method sends serialized ApiRequest string to Laitis over Named Pipe.
        /// In .Net exists class NamedPipeClientStream that simplifies work with net pipes.
        /// In another programming languages can be another options to use Named Pipes.
        /// 
        /// You need to close connection to Laitis Named Pipe right after request, 
        /// so other external extensions will have an opportunity to send requests to Laitis.
        /// </summary>
        /// <param name="requestString"></param>
        public void SendRequest(string requestString)
        {
            using (var client = new NamedPipeClientStream(LaitisExternalExtensionPipeName))
            {
                client.Connect();
                using (var writer = new StreamWriter(client))
                {
                    writer.WriteLine(requestString);
                }
            }
        }
    }
}

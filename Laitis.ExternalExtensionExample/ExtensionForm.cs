using System;
using System.IO;
using System.IO.Pipes;
using System.Windows.Forms;
using Laitis.Contracts;
using Laitis.Contracts.Enums;
using Newtonsoft.Json;

namespace Laitis.ExternalExtensionExample
{
    public partial class ExtensionForm : Form
    {
        public ExtensionForm()
        {
            InitializeComponent();
        }

        private void OnSendHelloClick(object sender, EventArgs e)
        {
            var request = JsonConvert.SerializeObject(new ApiRequest
            {
                R = ApiRequestType.SendVoiceCommand,
                P = "Привет"
            });
            SendApiRequestToLaitis(request);
        }

        private void OnSendActionButtonClick(object sender, EventArgs e)
        {
            var request = JsonConvert.SerializeObject(new ApiRequest
            {
                R = ApiRequestType.SendActions,
                A = new[]
                {
                    new CommandAction
                    {
                        T = ActionType.Say,
                        P = new [] { "Действие" }
                    }
                }
            });
            SendApiRequestToLaitis(request);
        }

        private void SendApiRequestToLaitis(string request)
        {
            using (var client = new NamedPipeClientStream("LaitisPublicApiService"))
            {
                client.Connect();
                using (var writer = new StreamWriter(client))
                {
                    writer.WriteLine(request);
                }
            }
        }
    }
}

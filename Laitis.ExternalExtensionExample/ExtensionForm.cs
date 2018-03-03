using System;
using System.Windows.Forms;

namespace Laitis.ExternalExtensionExample
{
    /// <summary>
    /// Just an UI that have two buttons with click handlers that invoke send operation.
    /// Send operation sends requests to laitis using static class LaitisExternalExtensionActions
    /// Classes are separated because your extension can be created without UI.
    /// <seealso cref="LaitisExternalExtensionActions"/>
    /// </summary>
    public partial class ExtensionForm : Form
    {
        public ExtensionForm()
        {
            InitializeComponent();
        }

        private void OnSendHelloClick(object sender, EventArgs e)
        {
            LaitisExternalExtensionActions.SendHelloPhrase();
        }

        private void OnSendActionButtonClick(object sender, EventArgs e)
        {
            LaitisExternalExtensionActions.SendSayInfoAction();
        }
    }
}

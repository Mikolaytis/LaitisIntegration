namespace Laitis.ExternalExtensionExample
{
    partial class ExtensionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendHelloButton = new System.Windows.Forms.Button();
            this.SendActionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendHelloButton
            // 
            this.SendHelloButton.Location = new System.Drawing.Point(33, 31);
            this.SendHelloButton.Name = "SendHelloButton";
            this.SendHelloButton.Size = new System.Drawing.Size(120, 73);
            this.SendHelloButton.TabIndex = 0;
            this.SendHelloButton.Text = "Send Hello";
            this.SendHelloButton.UseVisualStyleBackColor = true;
            this.SendHelloButton.Click += new System.EventHandler(this.OnSendHelloClick);
            // 
            // SendActionButton
            // 
            this.SendActionButton.Location = new System.Drawing.Point(294, 31);
            this.SendActionButton.Name = "SendActionButton";
            this.SendActionButton.Size = new System.Drawing.Size(120, 73);
            this.SendActionButton.TabIndex = 1;
            this.SendActionButton.Text = "Send Action";
            this.SendActionButton.UseVisualStyleBackColor = true;
            this.SendActionButton.Click += new System.EventHandler(this.OnSendActionButtonClick);
            // 
            // LaitisBasicExtensionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 132);
            this.Controls.Add(this.SendActionButton);
            this.Controls.Add(this.SendHelloButton);
            this.Name = "LaitisBasicExtensionForm";
            this.Text = "LaitisBasicExtensionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SendHelloButton;
        private System.Windows.Forms.Button SendActionButton;
    }
}


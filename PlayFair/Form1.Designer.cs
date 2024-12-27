namespace PlayFair
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private TextBox txtKey;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Label lbKey;
        private Label lbInput;
        private Label lbOutput;
        private CheckBox ckPlayfair;
        private CheckBox ckRSA;
        private TextBox txtPublicKey;
        private TextBox txtPrivateKey;
        private Label lbPublicKey;
        private Label lbPrivateKey;
        private Button btn_GenerateKey;
    }
}

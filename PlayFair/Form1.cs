using System;
using System.Linq;
namespace PlayFair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //ckPlayfair.CheckedChanged += CkPlayfair_CheckedChanged;
            //ckRSA.CheckedChanged += CkRSA_CheckedChanged;
            this.btn_GenerateKey.Click += new System.EventHandler(this.btn_GenerateKey_Click);

        }

        private void InitializeComponent()
        {
            txtKey = new TextBox();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            lbKey = new Label();
            lbInput = new Label();
            lbOutput = new Label();
            ckPlayfair = new CheckBox();
            ckRSA = new CheckBox();
            txtPublicKey = new TextBox();
            txtPrivateKey = new TextBox();
            lbPublicKey = new Label();
            lbPrivateKey = new Label();
            btn_GenerateKey = new Button();
            SuspendLayout();
            // 
            // txtKey
            // 
            txtKey.Location = new Point(72, 73);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(125, 27);
            txtKey.TabIndex = 0;
            txtKey.Visible = false;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(72, 178);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(125, 27);
            txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(535, 126);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(125, 27);
            txtOutput.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(335, 98);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(94, 29);
            btnEncrypt.TabIndex = 3;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(335, 154);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(94, 29);
            btnDecrypt.TabIndex = 4;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // lbKey
            // 
            lbKey.AutoSize = true;
            lbKey.Location = new Point(120, 50);
            lbKey.Name = "lbKey";
            lbKey.Size = new Size(33, 20);
            lbKey.TabIndex = 5;
            lbKey.Text = "Key";
            lbKey.Visible = false;
            lbKey.Click += lbKey_Click;
            // 
            // lbInput
            // 
            lbInput.AutoSize = true;
            lbInput.Location = new Point(120, 154);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(43, 20);
            lbInput.TabIndex = 6;
            lbInput.Text = "Input";
            // 
            // lbOutput
            // 
            lbOutput.AutoSize = true;
            lbOutput.Location = new Point(569, 103);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(55, 20);
            lbOutput.TabIndex = 7;
            lbOutput.Text = "Output";
            // 
            // ckPlayfair
            // 
            ckPlayfair.AutoSize = true;
            ckPlayfair.Location = new Point(177, 266);
            ckPlayfair.Name = "ckPlayfair";
            ckPlayfair.Size = new Size(80, 24);
            ckPlayfair.TabIndex = 8;
            ckPlayfair.Text = "Playfair";
            ckPlayfair.UseVisualStyleBackColor = true;
            ckPlayfair.CheckedChanged += ckPlayfair_CheckedChanged;
            // 
            // ckRSA
            // 
            ckRSA.AutoSize = true;
            ckRSA.Location = new Point(394, 266);
            ckRSA.Name = "ckRSA";
            ckRSA.Size = new Size(58, 24);
            ckRSA.TabIndex = 9;
            ckRSA.Text = "RSA";
            ckRSA.UseVisualStyleBackColor = true;
            ckRSA.CheckedChanged += ckRSA_CheckedChanged;
            // 
            // txtPublicKey
            // 
            txtPublicKey.Location = new Point(72, 40);
            txtPublicKey.Name = "txtPublicKey";
            txtPublicKey.Size = new Size(125, 27);
            txtPublicKey.TabIndex = 10;
            txtPublicKey.Visible = false;
            // 
            // txtPrivateKey
            // 
            txtPrivateKey.Location = new Point(72, 106);
            txtPrivateKey.Name = "txtPrivateKey";
            txtPrivateKey.Size = new Size(125, 27);
            txtPrivateKey.TabIndex = 11;
            txtPrivateKey.Visible = false;
            // 
            // lbPublicKey
            // 
            lbPublicKey.AutoSize = true;
            lbPublicKey.Location = new Point(101, 17);
            lbPublicKey.Name = "lbPublicKey";
            lbPublicKey.Size = new Size(77, 20);
            lbPublicKey.TabIndex = 12;
            lbPublicKey.Text = "Public Key";
            lbPublicKey.Visible = false;
            // 
            // lbPrivateKey
            // 
            lbPrivateKey.AutoSize = true;
            lbPrivateKey.Location = new Point(99, 83);
            lbPrivateKey.Name = "lbPrivateKey";
            lbPrivateKey.Size = new Size(82, 20);
            lbPrivateKey.TabIndex = 14;
            lbPrivateKey.Text = "Private Key";
            lbPrivateKey.Visible = false;
            // 
            // btn_GenerateKey
            // 
            btn_GenerateKey.Location = new Point(310, 50);
            btn_GenerateKey.Name = "btn_GenerateKey";
            btn_GenerateKey.Size = new Size(152, 29);
            btn_GenerateKey.TabIndex = 15;
            btn_GenerateKey.Text = "Generate Key";
            btn_GenerateKey.UseVisualStyleBackColor = true;
            btn_GenerateKey.Visible = false;
            btn_GenerateKey.Click += btn_GenerateKey_Click;
            // 
            // Form1
            // 
            BackColor = Color.Gainsboro;
            ClientSize = new Size(739, 313);
            Controls.Add(btn_GenerateKey);
            Controls.Add(lbPrivateKey);
            Controls.Add(lbPublicKey);
            Controls.Add(txtPrivateKey);
            Controls.Add(txtPublicKey);
            Controls.Add(ckRSA);
            Controls.Add(ckPlayfair);
            Controls.Add(lbOutput);
            Controls.Add(lbInput);
            Controls.Add(lbKey);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(txtKey);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void lbKey_Click(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (ckPlayfair.Checked && !ckRSA.Checked)
            {
                var cipher = new PlayFairCipher();
                cipher.GenerateMatrix(txtKey.Text);
                txtOutput.Text = cipher.Encrypt(txtInput.Text);
            }
            else if (!ckPlayfair.Checked && ckRSA.Checked)
            {
                if (string.IsNullOrEmpty(txtPublicKey.Text))
                {
                    MessageBox.Show("Please enter a public key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var rsaCipher = new RSACipherClass();
                string encryptedMessage = rsaCipher.EncryptWithPublicKey(txtInput.Text, txtPublicKey.Text);
                txtOutput.Text = encryptedMessage;
            }
            else
            {
                MessageBox.Show("Please select only one method: Playfair or RSA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (ckPlayfair.Checked && !ckRSA.Checked)
            {
                var cipher = new PlayFairCipher();
                cipher.GenerateMatrix(txtKey.Text);
                txtOutput.Text = cipher.Decrypt(txtInput.Text);
            }
            else if (!ckPlayfair.Checked && ckRSA.Checked)
            {
                if (string.IsNullOrEmpty(txtPrivateKey.Text))
                {
                    MessageBox.Show("Please enter a private key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var rsaCipher = new RSACipherClass();
                string decryptedMessage = rsaCipher.DecryptWithPrivateKey(txtInput.Text, txtPrivateKey.Text);
                txtOutput.Text = decryptedMessage;
            }
            else
            {
                MessageBox.Show("Please select only one method: Playfair or RSA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ckPlayfair_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPlayfair.Checked)
            {
                ckRSA.Checked = false;
            }
            if (ckPlayfair.Checked && !ckRSA.Checked)
            {
                lbKey.Visible = true;
                txtKey.Visible = true;
                lbPublicKey.Visible = false;
                txtPublicKey.Visible = false;
                lbPrivateKey.Visible = false;
                txtPrivateKey.Visible = false;
                btn_GenerateKey.Visible = false;
            }
            else
            {
                lbKey.Visible = false;
                txtKey.Visible = false;
                lbPublicKey.Visible = true;
                txtPublicKey.Visible = true;
                lbPrivateKey.Visible = true;
                txtPrivateKey.Visible = true;
                btn_GenerateKey.Visible = true;
            }
        }

        private void ckRSA_CheckedChanged(object sender, EventArgs e)
        {
            if (ckRSA.Checked)
            {
                ckPlayfair.Checked = false;
            }
            if (ckRSA.Checked && !ckPlayfair.Checked)
            {
                lbKey.Visible = false;
                txtKey.Visible = false;
                lbPublicKey.Visible = true;
                txtPublicKey.Visible = true;
                lbPrivateKey.Visible = true;
                txtPrivateKey.Visible = true;
                btn_GenerateKey.Visible = true;
            }
            else
            {
                lbKey.Visible = true;
                txtKey.Visible = true;
                lbPublicKey.Visible = false;
                txtPublicKey.Visible = false;
                lbPrivateKey.Visible = false;
                txtPrivateKey.Visible = false;
                btn_GenerateKey.Visible = false;
            }
        }

        private void btn_GenerateKey_Click(object sender, EventArgs e)
        {
            var rsaCipher = new RSACipherClass();
            rsaCipher.GenerateKeys();

            string publicKey = rsaCipher.ExportPublicKey();
            string privateKey = rsaCipher.ExportPrivateKey();

            txtPublicKey.Text = publicKey;
            txtPrivateKey.Text = privateKey;

            lbPublicKey.Visible = true;
            txtPublicKey.Visible = true;
            lbPrivateKey.Visible = true;
            txtPrivateKey.Visible = true;
        }
    }
}

namespace MainGui
{
    partial class GUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AESDecButton = new System.Windows.Forms.Button();
            this.selectedAESDecKey = new System.Windows.Forms.Label();
            this.selectedAESDecFile = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openAESDecKeyButton = new System.Windows.Forms.Button();
            this.openAESDecFileButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AESEncButton = new System.Windows.Forms.Button();
            this.selectedAESEncKey = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openAESEncKeyButton = new System.Windows.Forms.Button();
            this.selectedAESEncFile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openAESEncFileButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectAESKeySize = new System.Windows.Forms.ComboBox();
            this.generateAESKeyButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.RSADecButton = new System.Windows.Forms.Button();
            this.selectedRSADecKey = new System.Windows.Forms.Label();
            this.selectedRSADecFile = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.openRSADecKeyButton = new System.Windows.Forms.Button();
            this.openRSADecFileButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RSAEncButton = new System.Windows.Forms.Button();
            this.selectedRSAEncKey = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openRSAEncKeyButton = new System.Windows.Forms.Button();
            this.selectedRSAEncFile = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openRSAEncFileButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.selectRSAKeySize = new System.Windows.Forms.ComboBox();
            this.generateRSAKeysButton = new System.Windows.Forms.Button();
            this.tabpage3 = new System.Windows.Forms.TabPage();
            this.outputtextbox = new System.Windows.Forms.TextBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PlainTextOutput = new System.Windows.Forms.TextBox();
            this.DecButton = new System.Windows.Forms.Button();
            this.EncButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.CipherText = new System.Windows.Forms.TextBox();
            this.PlainTextInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.saveAESKeyDialog = new System.Windows.Forms.SaveFileDialog();
            this.openAESEncFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openAESEncKeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveAESEncFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openAESDecFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openAESDecKeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveAESDecFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveRSAKeysDialog = new System.Windows.Forms.SaveFileDialog();
            this.openRSAEncFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openRSAEncKeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveRSAEncFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openRSADecFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openRSADecKeyDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveRSADecFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabpage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabpage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(410, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(402, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "AES Cryptography";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AESDecButton);
            this.groupBox3.Controls.Add(this.selectedAESDecKey);
            this.groupBox3.Controls.Add(this.selectedAESDecFile);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.openAESDecKeyButton);
            this.groupBox3.Controls.Add(this.openAESDecFileButton);
            this.groupBox3.Location = new System.Drawing.Point(6, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 165);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Decoding";
            // 
            // AESDecButton
            // 
            this.AESDecButton.Location = new System.Drawing.Point(155, 131);
            this.AESDecButton.Name = "AESDecButton";
            this.AESDecButton.Size = new System.Drawing.Size(75, 23);
            this.AESDecButton.TabIndex = 8;
            this.AESDecButton.Text = "Decipher";
            this.AESDecButton.UseVisualStyleBackColor = true;
            this.AESDecButton.Click += new System.EventHandler(this.AESDecButton_Click);
            // 
            // selectedAESDecKey
            // 
            this.selectedAESDecKey.Location = new System.Drawing.Point(177, 82);
            this.selectedAESDecKey.Name = "selectedAESDecKey";
            this.selectedAESDecKey.Size = new System.Drawing.Size(197, 35);
            this.selectedAESDecKey.TabIndex = 7;
            this.selectedAESDecKey.Text = "n/a";
            // 
            // selectedAESDecFile
            // 
            this.selectedAESDecFile.Location = new System.Drawing.Point(177, 25);
            this.selectedAESDecFile.Name = "selectedAESDecFile";
            this.selectedAESDecFile.Size = new System.Drawing.Size(197, 35);
            this.selectedAESDecFile.TabIndex = 7;
            this.selectedAESDecFile.Text = "n/a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Selected key:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selected file:";
            // 
            // openAESDecKeyButton
            // 
            this.openAESDecKeyButton.Location = new System.Drawing.Point(7, 77);
            this.openAESDecKeyButton.Name = "openAESDecKeyButton";
            this.openAESDecKeyButton.Size = new System.Drawing.Size(75, 23);
            this.openAESDecKeyButton.TabIndex = 1;
            this.openAESDecKeyButton.Text = "Key";
            this.openAESDecKeyButton.UseVisualStyleBackColor = true;
            this.openAESDecKeyButton.Click += new System.EventHandler(this.openAESDecKeyButton_Click);
            // 
            // openAESDecFileButton
            // 
            this.openAESDecFileButton.Location = new System.Drawing.Point(7, 20);
            this.openAESDecFileButton.Name = "openAESDecFileButton";
            this.openAESDecFileButton.Size = new System.Drawing.Size(75, 23);
            this.openAESDecFileButton.TabIndex = 0;
            this.openAESDecFileButton.Text = "File";
            this.openAESDecFileButton.UseVisualStyleBackColor = true;
            this.openAESDecFileButton.Click += new System.EventHandler(this.openAESDecFileButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AESEncButton);
            this.groupBox2.Controls.Add(this.selectedAESEncKey);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.openAESEncKeyButton);
            this.groupBox2.Controls.Add(this.selectedAESEncFile);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.openAESEncFileButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 164);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encryption";
            // 
            // AESEncButton
            // 
            this.AESEncButton.Location = new System.Drawing.Point(158, 128);
            this.AESEncButton.Name = "AESEncButton";
            this.AESEncButton.Size = new System.Drawing.Size(75, 23);
            this.AESEncButton.TabIndex = 6;
            this.AESEncButton.Text = "Encrypt";
            this.AESEncButton.UseVisualStyleBackColor = true;
            this.AESEncButton.Click += new System.EventHandler(this.AESEncButton_Click);
            // 
            // selectedAESEncKey
            // 
            this.selectedAESEncKey.Location = new System.Drawing.Point(183, 77);
            this.selectedAESEncKey.Name = "selectedAESEncKey";
            this.selectedAESEncKey.Size = new System.Drawing.Size(197, 35);
            this.selectedAESEncKey.TabIndex = 5;
            this.selectedAESEncKey.Text = "n/a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected key:";
            // 
            // openAESEncKeyButton
            // 
            this.openAESEncKeyButton.Location = new System.Drawing.Point(6, 72);
            this.openAESEncKeyButton.Name = "openAESEncKeyButton";
            this.openAESEncKeyButton.Size = new System.Drawing.Size(75, 23);
            this.openAESEncKeyButton.TabIndex = 3;
            this.openAESEncKeyButton.Text = "Key";
            this.openAESEncKeyButton.UseVisualStyleBackColor = true;
            this.openAESEncKeyButton.Click += new System.EventHandler(this.openAESEncKeyButton_Click);
            // 
            // selectedAESEncFile
            // 
            this.selectedAESEncFile.Location = new System.Drawing.Point(183, 26);
            this.selectedAESEncFile.Name = "selectedAESEncFile";
            this.selectedAESEncFile.Size = new System.Drawing.Size(197, 35);
            this.selectedAESEncFile.TabIndex = 2;
            this.selectedAESEncFile.Text = "n/a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected file:";
            // 
            // openAESEncFileButton
            // 
            this.openAESEncFileButton.Location = new System.Drawing.Point(6, 21);
            this.openAESEncFileButton.Name = "openAESEncFileButton";
            this.openAESEncFileButton.Size = new System.Drawing.Size(75, 23);
            this.openAESEncFileButton.TabIndex = 0;
            this.openAESEncFileButton.Text = "File";
            this.openAESEncFileButton.UseVisualStyleBackColor = true;
            this.openAESEncFileButton.Click += new System.EventHandler(this.openAESEncFileButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectAESKeySize);
            this.groupBox1.Controls.Add(this.generateAESKeyButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key generation";
            // 
            // selectAESKeySize
            // 
            this.selectAESKeySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectAESKeySize.FormattingEnabled = true;
            this.selectAESKeySize.ItemHeight = 13;
            this.selectAESKeySize.Items.AddRange(new object[] {
            "128",
            "192",
            "256"});
            this.selectAESKeySize.Location = new System.Drawing.Point(6, 19);
            this.selectAESKeySize.Name = "selectAESKeySize";
            this.selectAESKeySize.Size = new System.Drawing.Size(45, 21);
            this.selectAESKeySize.TabIndex = 1;
            this.selectAESKeySize.SelectedIndexChanged += new System.EventHandler(this.selectAESKeySize_SelectedIndexChanged);
            // 
            // generateAESKeyButton
            // 
            this.generateAESKeyButton.Location = new System.Drawing.Point(62, 18);
            this.generateAESKeyButton.Name = "generateAESKeyButton";
            this.generateAESKeyButton.Size = new System.Drawing.Size(91, 23);
            this.generateAESKeyButton.TabIndex = 0;
            this.generateAESKeyButton.Text = "Save the key";
            this.generateAESKeyButton.UseVisualStyleBackColor = true;
            this.generateAESKeyButton.Click += new System.EventHandler(this.generateAESKeyButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(402, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RSA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "RSA Cryptography";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.RSADecButton);
            this.groupBox6.Controls.Add(this.selectedRSADecKey);
            this.groupBox6.Controls.Add(this.selectedRSADecFile);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.openRSADecKeyButton);
            this.groupBox6.Controls.Add(this.openRSADecFileButton);
            this.groupBox6.Location = new System.Drawing.Point(6, 279);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(390, 165);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Decryption with a private key";
            // 
            // RSADecButton
            // 
            this.RSADecButton.Location = new System.Drawing.Point(155, 131);
            this.RSADecButton.Name = "RSADecButton";
            this.RSADecButton.Size = new System.Drawing.Size(75, 23);
            this.RSADecButton.TabIndex = 8;
            this.RSADecButton.Text = "Decipher";
            this.RSADecButton.UseVisualStyleBackColor = true;
            this.RSADecButton.Click += new System.EventHandler(this.RSADecButton_Click);
            // 
            // selectedRSADecKey
            // 
            this.selectedRSADecKey.Location = new System.Drawing.Point(177, 82);
            this.selectedRSADecKey.Name = "selectedRSADecKey";
            this.selectedRSADecKey.Size = new System.Drawing.Size(197, 35);
            this.selectedRSADecKey.TabIndex = 7;
            this.selectedRSADecKey.Text = "n/a";
            // 
            // selectedRSADecFile
            // 
            this.selectedRSADecFile.Location = new System.Drawing.Point(177, 25);
            this.selectedRSADecFile.Name = "selectedRSADecFile";
            this.selectedRSADecFile.Size = new System.Drawing.Size(197, 35);
            this.selectedRSADecFile.TabIndex = 7;
            this.selectedRSADecFile.Text = "n/a";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Selected key:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Selected file:";
            // 
            // openRSADecKeyButton
            // 
            this.openRSADecKeyButton.Location = new System.Drawing.Point(7, 77);
            this.openRSADecKeyButton.Name = "openRSADecKeyButton";
            this.openRSADecKeyButton.Size = new System.Drawing.Size(75, 23);
            this.openRSADecKeyButton.TabIndex = 1;
            this.openRSADecKeyButton.Text = "Key";
            this.openRSADecKeyButton.UseVisualStyleBackColor = true;
            this.openRSADecKeyButton.Click += new System.EventHandler(this.openRSADecKeyButton_Click);
            // 
            // openRSADecFileButton
            // 
            this.openRSADecFileButton.Location = new System.Drawing.Point(7, 20);
            this.openRSADecFileButton.Name = "openRSADecFileButton";
            this.openRSADecFileButton.Size = new System.Drawing.Size(75, 23);
            this.openRSADecFileButton.TabIndex = 0;
            this.openRSADecFileButton.Text = "File";
            this.openRSADecFileButton.UseVisualStyleBackColor = true;
            this.openRSADecFileButton.Click += new System.EventHandler(this.openRSADecFileButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RSAEncButton);
            this.groupBox5.Controls.Add(this.selectedRSAEncKey);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.openRSAEncKeyButton);
            this.groupBox5.Controls.Add(this.selectedRSAEncFile);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.openRSAEncFileButton);
            this.groupBox5.Location = new System.Drawing.Point(6, 108);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(390, 164);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Public key encryption";
            // 
            // RSAEncButton
            // 
            this.RSAEncButton.Location = new System.Drawing.Point(158, 128);
            this.RSAEncButton.Name = "RSAEncButton";
            this.RSAEncButton.Size = new System.Drawing.Size(75, 23);
            this.RSAEncButton.TabIndex = 6;
            this.RSAEncButton.Text = "Encrypt";
            this.RSAEncButton.UseVisualStyleBackColor = true;
            this.RSAEncButton.Click += new System.EventHandler(this.RSAEncButton_Click);
            // 
            // selectedRSAEncKey
            // 
            this.selectedRSAEncKey.Location = new System.Drawing.Point(183, 77);
            this.selectedRSAEncKey.Name = "selectedRSAEncKey";
            this.selectedRSAEncKey.Size = new System.Drawing.Size(197, 35);
            this.selectedRSAEncKey.TabIndex = 5;
            this.selectedRSAEncKey.Text = "n/a";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Selected key:";
            // 
            // openRSAEncKeyButton
            // 
            this.openRSAEncKeyButton.Location = new System.Drawing.Point(6, 72);
            this.openRSAEncKeyButton.Name = "openRSAEncKeyButton";
            this.openRSAEncKeyButton.Size = new System.Drawing.Size(75, 23);
            this.openRSAEncKeyButton.TabIndex = 3;
            this.openRSAEncKeyButton.Text = "Key";
            this.openRSAEncKeyButton.UseVisualStyleBackColor = true;
            this.openRSAEncKeyButton.Click += new System.EventHandler(this.openRSAEncKeyButton_Click);
            // 
            // selectedRSAEncFile
            // 
            this.selectedRSAEncFile.Location = new System.Drawing.Point(183, 26);
            this.selectedRSAEncFile.Name = "selectedRSAEncFile";
            this.selectedRSAEncFile.Size = new System.Drawing.Size(197, 35);
            this.selectedRSAEncFile.TabIndex = 2;
            this.selectedRSAEncFile.Text = "n/a";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Selected file:";
            // 
            // openRSAEncFileButton
            // 
            this.openRSAEncFileButton.Location = new System.Drawing.Point(6, 21);
            this.openRSAEncFileButton.Name = "openRSAEncFileButton";
            this.openRSAEncFileButton.Size = new System.Drawing.Size(75, 23);
            this.openRSAEncFileButton.TabIndex = 0;
            this.openRSAEncFileButton.Text = "File";
            this.openRSAEncFileButton.UseVisualStyleBackColor = true;
            this.openRSAEncFileButton.Click += new System.EventHandler(this.openRSAEncFileButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.selectRSAKeySize);
            this.groupBox4.Controls.Add(this.generateRSAKeysButton);
            this.groupBox4.Location = new System.Drawing.Point(6, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 56);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Key generation";
            // 
            // selectRSAKeySize
            // 
            this.selectRSAKeySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectRSAKeySize.FormattingEnabled = true;
            this.selectRSAKeySize.ItemHeight = 13;
            this.selectRSAKeySize.Items.AddRange(new object[] {
            "1024",
            "2048"});
            this.selectRSAKeySize.Location = new System.Drawing.Point(6, 19);
            this.selectRSAKeySize.Name = "selectRSAKeySize";
            this.selectRSAKeySize.Size = new System.Drawing.Size(50, 21);
            this.selectRSAKeySize.TabIndex = 1;
            this.selectRSAKeySize.SelectedIndexChanged += new System.EventHandler(this.selectRSAKeySize_SelectedIndexChanged);
            // 
            // generateRSAKeysButton
            // 
            this.generateRSAKeysButton.Location = new System.Drawing.Point(62, 18);
            this.generateRSAKeysButton.Name = "generateRSAKeysButton";
            this.generateRSAKeysButton.Size = new System.Drawing.Size(91, 23);
            this.generateRSAKeysButton.TabIndex = 0;
            this.generateRSAKeysButton.Text = "Save the key";
            this.generateRSAKeysButton.UseVisualStyleBackColor = true;
            this.generateRSAKeysButton.Click += new System.EventHandler(this.generateRSAKeysButton_Click);
            // 
            // tabpage3
            // 
            this.tabpage3.Controls.Add(this.outputtextbox);
            this.tabpage3.Controls.Add(this.DecryptButton);
            this.tabpage3.Controls.Add(this.EncryptButton);
            this.tabpage3.Controls.Add(this.label17);
            this.tabpage3.Controls.Add(this.label16);
            this.tabpage3.Controls.Add(this.label15);
            this.tabpage3.Controls.Add(this.label14);
            this.tabpage3.Controls.Add(this.textBoxPassword);
            this.tabpage3.Controls.Add(this.richTextBox1);
            this.tabpage3.Controls.Add(this.label13);
            this.tabpage3.Controls.Add(this.PlainTextOutput);
            this.tabpage3.Controls.Add(this.DecButton);
            this.tabpage3.Controls.Add(this.EncButton);
            this.tabpage3.Controls.Add(this.label12);
            this.tabpage3.Controls.Add(this.CipherText);
            this.tabpage3.Controls.Add(this.PlainTextInput);
            this.tabpage3.Controls.Add(this.label11);
            this.tabpage3.Location = new System.Drawing.Point(4, 22);
            this.tabpage3.Name = "tabpage3";
            this.tabpage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage3.Size = new System.Drawing.Size(402, 457);
            this.tabpage3.TabIndex = 2;
            this.tabpage3.Text = "Text";
            this.tabpage3.UseVisualStyleBackColor = true;
            // 
            // outputtextbox
            // 
            this.outputtextbox.Location = new System.Drawing.Point(67, 379);
            this.outputtextbox.Multiline = true;
            this.outputtextbox.Name = "outputtextbox";
            this.outputtextbox.Size = new System.Drawing.Size(299, 64);
            this.outputtextbox.TabIndex = 16;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(212, 350);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(154, 23);
            this.DecryptButton.TabIndex = 15;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(67, 349);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(139, 24);
            this.EncryptButton.TabIndex = 14;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 326);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Key";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 290);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Text";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(184, 249);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 29);
            this.label15.TabIndex = 11;
            this.label15.Text = "AES";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(183, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 29);
            this.label14.TabIndex = 10;
            this.label14.Text = "RSA";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(67, 323);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(299, 20);
            this.textBoxPassword.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(67, 278);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(299, 39);
            this.richTextBox1.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Text";
            // 
            // PlainTextOutput
            // 
            this.PlainTextOutput.Location = new System.Drawing.Point(67, 190);
            this.PlainTextOutput.Multiline = true;
            this.PlainTextOutput.Name = "PlainTextOutput";
            this.PlainTextOutput.Size = new System.Drawing.Size(299, 56);
            this.PlainTextOutput.TabIndex = 6;
            // 
            // DecButton
            // 
            this.DecButton.Location = new System.Drawing.Point(212, 161);
            this.DecButton.Name = "DecButton";
            this.DecButton.Size = new System.Drawing.Size(154, 23);
            this.DecButton.TabIndex = 5;
            this.DecButton.Text = "Decrypt";
            this.DecButton.UseVisualStyleBackColor = true;
            this.DecButton.Click += new System.EventHandler(this.DecButton_Click);
            // 
            // EncButton
            // 
            this.EncButton.Location = new System.Drawing.Point(67, 86);
            this.EncButton.Name = "EncButton";
            this.EncButton.Size = new System.Drawing.Size(139, 24);
            this.EncButton.TabIndex = 4;
            this.EncButton.Text = "Encrypt";
            this.EncButton.UseVisualStyleBackColor = true;
            this.EncButton.Click += new System.EventHandler(this.EncButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Encrypted";
            // 
            // CipherText
            // 
            this.CipherText.Location = new System.Drawing.Point(67, 116);
            this.CipherText.Multiline = true;
            this.CipherText.Name = "CipherText";
            this.CipherText.Size = new System.Drawing.Size(299, 39);
            this.CipherText.TabIndex = 2;
            // 
            // PlainTextInput
            // 
            this.PlainTextInput.Location = new System.Drawing.Point(67, 32);
            this.PlainTextInput.Multiline = true;
            this.PlainTextInput.Name = "PlainTextInput";
            this.PlainTextInput.Size = new System.Drawing.Size(299, 48);
            this.PlainTextInput.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Text";
            // 
            // saveAESKeyDialog
            // 
            this.saveAESKeyDialog.Filter = "All files|*.*";
            this.saveAESKeyDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveAESKeyDialog_FileOk);
            // 
            // openAESEncFileDialog
            // 
            this.openAESEncFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openAESEncFileDialog_FileOk);
            // 
            // openAESEncKeyDialog
            // 
            this.openAESEncKeyDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openAESEncKeyDialog_FileOk);
            // 
            // saveAESEncFileDialog
            // 
            this.saveAESEncFileDialog.Filter = "All files|*.*";
            this.saveAESEncFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveAESEncFileDialog_FileOk);
            // 
            // openAESDecFileDialog
            // 
            this.openAESDecFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openAESDecFileDialog_FileOk);
            // 
            // openAESDecKeyDialog
            // 
            this.openAESDecKeyDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openAESDecKeyDialog_FileOk);
            // 
            // saveAESDecFileDialog
            // 
            this.saveAESDecFileDialog.Filter = "All files|*.*";
            this.saveAESDecFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveAESDecFileDialog_FileOk);
            // 
            // saveRSAKeysDialog
            // 
            this.saveRSAKeysDialog.Filter = "All files|*.*";
            this.saveRSAKeysDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveRSAKeysDialog_FileOk);
            // 
            // openRSAEncFileDialog
            // 
            this.openRSAEncFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openRSAEncFileDialog_FileOk);
            // 
            // openRSAEncKeyDialog
            // 
            this.openRSAEncKeyDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openRSAEncKeyDialog_FileOk);
            // 
            // saveRSAEncFileDialog
            // 
            this.saveRSAEncFileDialog.Filter = "All files|*.*";
            this.saveRSAEncFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveRSAEncFileDialog_FileOk);
            // 
            // openRSADecFileDialog
            // 
            this.openRSADecFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openRSADecFileDialog_FileOk);
            // 
            // openRSADecKeyDialog
            // 
            this.openRSADecKeyDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openRSADecKeyDialog_FileOk);
            // 
            // saveRSADecFileDialog
            // 
            this.saveRSADecFileDialog.Filter = "All files|*.*";
            this.saveRSADecFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveRSADecFileDialog_FileOk);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 507);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptography";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabpage3.ResumeLayout(false);
            this.tabpage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button generateAESKeyButton;
        private System.Windows.Forms.SaveFileDialog saveAESKeyDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox selectAESKeySize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button openAESEncFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectedAESEncFile;
        private System.Windows.Forms.OpenFileDialog openAESEncFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openAESEncKeyButton;
        private System.Windows.Forms.OpenFileDialog openAESEncKeyDialog;
        private System.Windows.Forms.Label selectedAESEncKey;
        private System.Windows.Forms.Button AESEncButton;
        private System.Windows.Forms.SaveFileDialog saveAESEncFileDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label selectedAESDecKey;
        private System.Windows.Forms.Label selectedAESDecFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openAESDecKeyButton;
        private System.Windows.Forms.Button openAESDecFileButton;
        private System.Windows.Forms.Button AESDecButton;
        private System.Windows.Forms.OpenFileDialog openAESDecFileDialog;
        private System.Windows.Forms.OpenFileDialog openAESDecKeyDialog;
        private System.Windows.Forms.SaveFileDialog saveAESDecFileDialog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox selectRSAKeySize;
        private System.Windows.Forms.Button generateRSAKeysButton;
        private System.Windows.Forms.SaveFileDialog saveRSAKeysDialog;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button RSAEncButton;
        private System.Windows.Forms.Label selectedRSAEncKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button openRSAEncKeyButton;
        private System.Windows.Forms.Label selectedRSAEncFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button openRSAEncFileButton;
        private System.Windows.Forms.OpenFileDialog openRSAEncFileDialog;
        private System.Windows.Forms.OpenFileDialog openRSAEncKeyDialog;
        private System.Windows.Forms.SaveFileDialog saveRSAEncFileDialog;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button RSADecButton;
        private System.Windows.Forms.Label selectedRSADecKey;
        private System.Windows.Forms.Label selectedRSADecFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button openRSADecKeyButton;
        private System.Windows.Forms.Button openRSADecFileButton;
        private System.Windows.Forms.OpenFileDialog openRSADecFileDialog;
        private System.Windows.Forms.OpenFileDialog openRSADecKeyDialog;
        private System.Windows.Forms.SaveFileDialog saveRSADecFileDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabpage3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PlainTextOutput;
        private System.Windows.Forms.Button DecButton;
        private System.Windows.Forms.Button EncButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CipherText;
        private System.Windows.Forms.TextBox PlainTextInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox outputtextbox;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox richTextBox1;
    }
}


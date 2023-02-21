using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Org.BouncyCastle.Crypto;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
using RsaAes;

namespace MainGui
{
    public partial class GUI : Form
    {
        #region AES Fields
        //Variable Declaration for AES
        private bool AESKeySizeFirstChange = true;

        private int AESKeySize = 128;

        private byte[] AESEncFileBytes = null;
        private byte[] AESEncKey = null;

        private byte[] AESDecFileBytes = null;
        private byte[] AESDecKey = null;

       

        #endregion

        #region RSA Fields
        //Variable Declaration for RSA
        private bool RSAKeySizeFirstChange = true;
        String keyStore = "";
        private int RSAKeySize = 1024;

        private byte[] RSAEncFileBytes = null;
        private AsymmetricKeyParameter RSAEncKey = null;

        private byte[] RSADecFileBytes = null;
        private AsymmetricKeyParameter RSADecKey = null;

        #endregion
        //Variable Declaration for Key Derivation
        string passwordInput;

        private readonly int _numberOfIterations = 2;
          Dictionary<string, PasswordPackage> _passwordStore = new Dictionary<string, PasswordPackage>();
        public GUI()
        {
            InitializeComponent();
            selectAESKeySize.SelectedIndex = 0;
            selectRSAKeySize.SelectedIndex = 0;
        }
        

        #region AES Tab

         

        //Store Password Method for Key Derivation
        public void StorePassword(string userName, string password)
        {
            var salt = GenerateSalt();
            plaintext = ByteConverter.GetBytes(password);
            encryptedtext = Encryption(plaintext, RSA.ExportParameters(false), false);
           


            var rfc2898 = new Rfc2898DeriveBytes(password, salt, _numberOfIterations);
            var passwordPackage = new PasswordPackage {
                salt = salt,
                Password = rfc2898.GetBytes(32),
                password2 = encryptedtext
            };
            _passwordStore.Add(userName, passwordPackage);



        }
        //Button Method for Key Generation
        private void generateAESKeyButton_Click(object sender, EventArgs e)
        {

            passwordInput = "";
            ShowInputDialogBox(ref passwordInput, "Please enter your password for File encryption", "Enter Password", 300, 200);

            StorePassword("admin", passwordInput);

            //Print the input provided by the user
            Console.WriteLine(passwordInput);
          




            saveAESKeyDialog.ShowDialog();
            
        }

        //Authentication Method for Key Derivation
        public bool AuthenticateUser(string username, string password)
        {
            var passwordPackage = _passwordStore[username];
            var rfc2898 = new Rfc2898DeriveBytes(password, passwordPackage.salt, _numberOfIterations);

            var passwordtoCheck = Encoding.Default.GetString(rfc2898.GetBytes(32));
            var storedPassword = Encoding.Default.GetString(passwordPackage.Password);
            return passwordtoCheck == storedPassword;
        
        
        }

        //Generate Salt Method for Key Derivation
        private static byte[] GenerateSalt() {
            var salt = new byte[32];
            var randomProvider = new RNGCryptoServiceProvider();
            randomProvider.GetBytes(salt);
            return salt;
        
        }
        //Generate UI Method for Key Derivation Password Input
        private static DialogResult ShowInputDialogBox(ref string input, string prompt, string title, int width = 100, int height = 200)
        {
            //This function creates the custom input dialog box by individually creating the different window elements and adding them to the dialog box

            //Specify the size of the window using the parameters passed
            Size size = new Size(width, height);
            //Create a new form using a System.Windows Form
            Form inputBox = new Form();

            inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;

            //Set the window title using the parameter passed
            inputBox.Text = title;

            //Create a new label to hold the prompt
            Label label = new Label();
            label.Text = prompt;
            label.Location = new Point(5, 5);
            label.Width = size.Width - 10;
            inputBox.Controls.Add(label);

            //Create a textbox to accept the user's input
            TextBox textBox = new TextBox();
            textBox.UseSystemPasswordChar = true;
            textBox.Size = new Size(size.Width - 10, 23);
            textBox.Location = new Point(5, label.Location.Y + 20);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            //Create an OK Button 
            Button okButton = new Button();
            okButton.DialogResult = DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new Point(size.Width - 80 - 80, size.Height - 30);
            inputBox.Controls.Add(okButton);

            //Create a Cancel Button
            Button cancelButton = new Button();
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new Point(size.Width - 80, size.Height - 30);
            inputBox.Controls.Add(cancelButton);

            //Set the input box's buttons to the created OK and Cancel Buttons respectively so the window appropriately behaves with the button clicks
            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            //Show the window dialog box 
            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;

            //After input has been submitted, return the input value
            return result;
        }
        //Save Method for AES Key
        private void saveAESKeyDialog_FileOk(object sender, CancelEventArgs e)
        {
            byte[] AESKey = Crypto.GenerateAESKey(AESKeySize);
            string FilePath = saveAESKeyDialog.FileName;
            TextWriter tw = new StreamWriter(FilePath);
            tw.WriteLine(Convert.ToBase64String(AESKey));
            tw.Close();
        }

        //Size of Key Method for AES Key
        private void selectAESKeySize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AESKeySizeFirstChange)
            {
                AESKeySizeFirstChange = false;
            }
            else
            {
                string SelectedKeySize = selectAESKeySize.SelectedItem.ToString();
                AESKeySize = Convert.ToInt32(SelectedKeySize);
            }
        }

        //Upload AES Encryption Method for AES Key
        private void openAESEncFileButton_Click(object sender, EventArgs e)
        {
            openAESEncFileDialog.ShowDialog();
        }

        //Method to Open AES Encryption File
        private void openAESEncFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string FilePath = openAESEncFileDialog.FileName;
            selectedAESEncFile.Text = FilePath;
            AESEncFileBytes = Util.ReadFile(FilePath);
        }
        //Method to Open AES Encryption Key
        private void openAESEncKeyButton_Click(object sender, EventArgs e)
        {
            openAESEncKeyDialog.ShowDialog();
        }

        private void openAESEncKeyDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string FilePath = openAESEncKeyDialog.FileName;
                TextReader tr = new StreamReader(FilePath);
                string key = tr.ReadLine();
                tr.Close();
                AESEncKey = Convert.FromBase64String(key);
                selectedAESEncKey.Text = FilePath;
            }
            catch (FormatException)
            {
                MessageBox.Show("Upload the correct one for encryption", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Method call to  AES Encryption File
        private void AESEncButton_Click(object sender, EventArgs e)
        {
            if (AESEncFileBytes != null)
            {
                if (AESEncKey != null)
                {
                    saveAESEncFileDialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Upload the encryption key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Upload the encryption file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveAESEncFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string FilePath = saveAESEncFileDialog.FileName;
            byte[] CiptherText = Crypto.EncryptAES(AESEncFileBytes, AESEncKey);
            File.WriteAllBytes(FilePath, CiptherText);
            MessageBox.Show("The file was successfully encrypted.", "Encryption successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Method to Open AES File for Decryption
        private void openAESDecFileButton_Click(object sender, EventArgs e)
        {
            openAESDecFileDialog.ShowDialog();
        }

        private void openAESDecFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string FilePath = openAESDecFileDialog.FileName;
            selectedAESDecFile.Text = FilePath;
            AESDecFileBytes = Util.ReadFile(FilePath);
        }
        //Method to Open AES File for Decryption
        private void openAESDecKeyButton_Click(object sender, EventArgs e)
        {
            openAESDecKeyDialog.ShowDialog();
        }

        private void openAESDecKeyDialog_FileOk(object sender, CancelEventArgs e)
        {
            string FilePath = openAESDecKeyDialog.FileName;
            TextReader tr = new StreamReader(FilePath);
            string key = tr.ReadLine();
            tr.Close();
            AESDecKey = Convert.FromBase64String(key);
            selectedAESDecKey.Text = FilePath;
        }
        //Method to Decrypt AES File And Save it
        private void AESDecButton_Click(object sender, EventArgs e)
        {
            passwordInput = "";
            ShowInputDialogBox(ref passwordInput, "Please enter your password for File decryption", "Enter Password", 300, 200);
            if (AuthenticateUser("admin", passwordInput) != true)
            {
                MessageBox.Show("Password Doesn't Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                if (AESDecFileBytes != null)
                {
                    if (AESDecKey != null)
                    {
                        saveAESDecFileDialog.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Upload the decryption key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Upload the decryption file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void saveAESDecFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string FilePath = saveAESDecFileDialog.FileName;
            byte[] PlainText = Crypto.DecryptAES(AESDecFileBytes, AESDecKey);
            if (PlainText != null)
            {
                File.WriteAllBytes(FilePath, PlainText);
                MessageBox.Show("The file was successfully decrypted.", "Decryption successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You used the wrong key;.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        //Method call to Save Rsa Key
        private void generateRSAKeysButton_Click(object sender, EventArgs e)
        {
            passwordInput = "";
            ShowInputDialogBox(ref passwordInput, "Please enter your password for File encryption", "Enter Password", 300, 200);

            StorePassword("admin", passwordInput);
            //Print the input provided by the user
            Console.WriteLine(passwordInput);



            saveRSAKeysDialog.ShowDialog();
        }

        private void saveRSAKeysDialog_FileOk(object sender, CancelEventArgs e)
        {
            string FilePath = saveRSAKeysDialog.FileName;
            Util.WriteRSAKeys(Crypto.GenerateRSAKeys(RSAKeySize), FilePath);
        }
        //Method to Select RSa Key Size
        private void selectRSAKeySize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RSAKeySizeFirstChange)
            {
                RSAKeySizeFirstChange = false;
            }
            else
            {
                string SelectedKeySize = selectRSAKeySize.SelectedItem.ToString();
                RSAKeySize = Convert.ToInt32(SelectedKeySize);
            }
        }
        //Method call to Upload a File for RSA Encryption
        private void openRSAEncFileButton_Click(object sender, EventArgs e)
        {
            openRSAEncFileDialog.ShowDialog();
        }

        private void openRSAEncFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string FilePath = openRSAEncFileDialog.FileName;
            selectedRSAEncFile.Text = FilePath;
            RSAEncFileBytes = Util.ReadFile(FilePath);
        }
        //Method call to Upload a Key for RSA Encryption
        private void openRSAEncKeyButton_Click(object sender, EventArgs e)
        {
            openRSAEncKeyDialog.ShowDialog();
        }

        private void openRSAEncKeyDialog_FileOk(object sender, CancelEventArgs e)
        {
            string FilePath = openRSAEncKeyDialog.FileName;
            if (Path.GetFileNameWithoutExtension(FilePath).Contains("_public"))
            {
                RSAEncKey = Util.ReadRSAPublicKey(FilePath);
                if (RSAEncKey != null)
                {
                    selectedRSAEncKey.Text = FilePath;
                }
                else
                {
                    MessageBox.Show("Select the public key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select the public key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Method call to Encrypt a File in RSA 
        private void RSAEncButton_Click(object sender, EventArgs e)
        {
            if (RSAEncFileBytes != null)
            {
                if (RSAEncKey != null)
                {
                    saveRSAEncFileDialog.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Upload the encryption key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Upload the encryption file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveRSAEncFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string FilePath = saveRSAEncFileDialog.FileName;
            byte[] CipherText = Crypto.EncryptRSA(RSAEncFileBytes, RSAEncKey);
            File.WriteAllBytes(FilePath, CipherText);
            MessageBox.Show("The file was successfully encrypted.", "Encryption successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Method call to Upload a File for RSA Decryption
        private void openRSADecFileButton_Click(object sender, EventArgs e)
        {
            openRSADecFileDialog.ShowDialog();
        }

        private void openRSADecFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string FilePath = openRSADecFileDialog.FileName;
            selectedRSADecFile.Text = FilePath;
            RSADecFileBytes = Util.ReadFile(FilePath);
        }
        //Method call to Upload a Key for RSA Decryption
        private void openRSADecKeyButton_Click(object sender, EventArgs e)
        {
            openRSADecKeyDialog.ShowDialog();
        }

        private void openRSADecKeyDialog_FileOk(object sender, CancelEventArgs e)
        {
            string FilePath = openRSADecKeyDialog.FileName;
            if (Path.GetFileNameWithoutExtension(FilePath).Contains("_private"))
            {
                RSADecKey = Util.ReadRSAPrivateKey(FilePath);
                if (RSADecKey != null)
                {
                    selectedRSADecKey.Text = FilePath;
                }
                else
                {
                    MessageBox.Show("Select the private key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select the private key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Method call to Decrypt a  File from RSA
        private void RSADecButton_Click(object sender, EventArgs e)
        {
            passwordInput = "";
            ShowInputDialogBox(ref passwordInput, "Please enter your password for File decryption", "Enter Password", 300, 200);
            if (AuthenticateUser("admin", passwordInput) != true)
            {
                MessageBox.Show("Password Doesn't Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {


                if (RSADecFileBytes != null)
                {
                    if (RSADecKey != null)
                    {
                        saveRSADecFileDialog.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Upload Decryption Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Upload the decryption file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveRSADecFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string FilePath = saveRSADecFileDialog.FileName;
            byte[] PlainText = Crypto.DecryptRSA(RSADecFileBytes, RSADecKey);
            File.WriteAllBytes(FilePath, PlainText);
            MessageBox.Show("The file was successfully decrypted.", "Decryption successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] plaintext;
        byte[] encryptedtext;

        //Encrypt Button
        private void EncButton_Click(object sender, EventArgs e)
        {
            plaintext = ByteConverter.GetBytes(PlainTextInput.Text);
            encryptedtext = Encryption(plaintext, RSA.ExportParameters(false), false);
            CipherText.Text = ByteConverter.GetString(encryptedtext);
        }
        //Decrypt Button
        private void DecButton_Click(object sender, EventArgs e)
        {
            byte[] decryptedtext = Decryption(encryptedtext, RSA.ExportParameters(true), false);
            PlainTextOutput.Text = ByteConverter.GetString(decryptedtext);
        }
        //Method for Encryption
        static public byte[] Encryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey); encryptedData = RSA.Encrypt(Data, DoOAEPPadding);
                } return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        //Method for Decryption
        static public byte[] Decryption(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decryptedData = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        private byte[] IV = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};
        private int BlockSize = 128;


        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "") MessageBox.Show("Please Enter key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                byte[] bytes = Encoding.Unicode.GetBytes(richTextBox1.Text);
                //Encrypt
                SymmetricAlgorithm crypt = Aes.Create();
                HashAlgorithm hash = MD5.Create();
                crypt.BlockSize = BlockSize;
                crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(textBoxPassword.Text));
                crypt.IV = IV;

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, crypt.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(bytes, 0, bytes.Length);
                    }

                    outputtextbox.Text = Convert.ToBase64String(memoryStream.ToArray());
                    keyStore = textBoxPassword.Text;
                }
                textBoxPassword.Text = "";
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "") MessageBox.Show("Please Enter key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBoxPassword.Text != keyStore) MessageBox.Show("Incorrect Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //Decrypt
                byte[] bytes = Convert.FromBase64String(outputtextbox.Text);
                SymmetricAlgorithm crypt = Aes.Create();
                HashAlgorithm hash = MD5.Create();
                crypt.Key = hash.ComputeHash(Encoding.Unicode.GetBytes(textBoxPassword.Text));
                crypt.IV = IV;

                using (MemoryStream memoryStream = new MemoryStream(bytes))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, crypt.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        byte[] decryptedBytes = new byte[bytes.Length];
                        cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
                        outputtextbox.Text = Encoding.Unicode.GetString(decryptedBytes);
                    }
                }
                keyStore = "";
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void PlainTextInput_TextChanged(object sender, EventArgs e)
        {

        }
        public string forgetpassword(string username)
        {
            var passwordPackage = _passwordStore[username];

            byte[] decryptedtext = Decryption(passwordPackage.password2, RSA.ExportParameters(true), false);
            var paswordDecrypt = ByteConverter.GetString(decryptedtext);
         
            return paswordDecrypt;


        }

        

        private void extractPassword_Click(object sender, EventArgs e)
        {
            
            if(_passwordStore.Count>0)
            passwordTb.Text = forgetpassword(userNameTb.Text);
            else
            MessageBox.Show("No Password is Saved yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

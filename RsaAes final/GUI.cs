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

namespace MainGui
{
    public partial class GUI : Form
    {
        #region AES Fields

        private bool AESKeySizeFirstChange = true;

        private int AESKeySize = 128;

        private byte[] AESEncFileBytes = null;
        private byte[] AESEncKey = null;

        private byte[] AESDecFileBytes = null;
        private byte[] AESDecKey = null;

        #endregion

        #region RSA Fields

        private bool RSAKeySizeFirstChange = true;

        private int RSAKeySize = 1024;

        private byte[] RSAEncFileBytes = null;
        private AsymmetricKeyParameter RSAEncKey = null;

        private byte[] RSADecFileBytes = null;
        private AsymmetricKeyParameter RSADecKey = null;

        #endregion

        public GUI()
        {
            InitializeComponent();
            selectAESKeySize.SelectedIndex = 0;
            selectRSAKeySize.SelectedIndex = 0;
        }

        #region AES Tab

        private void generateAESKeyButton_Click(object sender, EventArgs e)
        {
            saveAESKeyDialog.ShowDialog();
        }

        private void saveAESKeyDialog_FileOk(object sender, CancelEventArgs e)
        {
            byte[] AESKey = Crypto.GenerateAESKey(AESKeySize);
            string FilePath = saveAESKeyDialog.FileName;
            TextWriter tw = new StreamWriter(FilePath);
            tw.WriteLine(Convert.ToBase64String(AESKey));
            tw.Close();
        }

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

        private void openAESEncFileButton_Click(object sender, EventArgs e)
        {
            openAESEncFileDialog.ShowDialog();
        }

        private void openAESEncFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string FilePath = openAESEncFileDialog.FileName;
            selectedAESEncFile.Text = FilePath;
            AESEncFileBytes = Util.ReadFile(FilePath);
        }

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

        private void AESDecButton_Click(object sender, EventArgs e)
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

        private void generateRSAKeysButton_Click(object sender, EventArgs e)
        {
            saveRSAKeysDialog.ShowDialog();
        }

        private void saveRSAKeysDialog_FileOk(object sender, CancelEventArgs e)
        {
            string FilePath = saveRSAKeysDialog.FileName;
            Util.WriteRSAKeys(Crypto.GenerateRSAKeys(RSAKeySize), FilePath);
        }

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

        private void RSADecButton_Click(object sender, EventArgs e)
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
            if (textBoxPassword.Text == "") return;
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
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "") return;
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
        }
    }
}

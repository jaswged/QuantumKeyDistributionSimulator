using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantumGedamkeDistribution
    {
    public partial class frmEncryption : Form
        {
        public string bits;
        public string byteFromBits; // loop through bits to make a byte for manual path
        public frmEncryption()
           { 
            InitializeComponent();
            }

        private void btnEncrypt_Click(object sender, EventArgs e)
            {
            txtEncrypted.Text = EncryptOrDecryptShort(txtInput.Text, bits);
                //encryptData(txtInput.Text, bits);
            }

        private string encryptData(string p, string bits)
            {   // Need to implement.
            //  http://www.codeproject.com/Articles/5719/Simple-encrypting-and-decrypting-data-in-C
            throw new NotImplementedException();
            }

        private void frmEncryption_Load(object sender, EventArgs e)
            {
                lblBits.Text = bits;
            }

        string EncryptOrDecrypt(string text, string key)
            {   // from stackoverflow
            var result = new StringBuilder();

            for (int c = 0; c < text.Length; c++)
                {
                // take next character from string
                char character = text[c];

                // cast to a uint
                uint charCode = (uint)character;

                // figure out which character to take from the key
                int keyPosition = c % key.Length; // use modulo to "wrap round"

                // take the key character
                char keyChar = key[keyPosition];

                // cast it to a uint also
                uint keyCode = (uint)keyChar;

                // perform XOR on the two character codes
                uint combinedCode = charCode ^ keyCode;

                // cast back to a char
                char combinedChar = (char)combinedCode;

                // add to the result
                result.Append(combinedChar);
                }

            return result.ToString();
            }
        string EncryptOrDecryptShort(string text, string key)
            {
            var result = new StringBuilder();

            for (int c = 0; c < text.Length; c++)
                result.Append((char)((uint)text[c] ^ (uint)key[c % key.Length]));

            return result.ToString();
            }

        #region other Code possiblities
        class CEncryption
            {
            public static string Encrypt(string strIn, string strKey)
                {
                string sbOut = String.Empty;
                for (int i = 0; i < strIn.Length; i++)
                    {
                    sbOut += String.Format("{0:00}", strIn[i] ^ strKey[i % strKey.Length]);
                    }

                return sbOut;
                }

            public static string Decrypt(string strIn, string strKey)
                {
                string sbOut = String.Empty;
                for (int i = 0; i < strIn.Length; i += 2)
                    {
                    byte code = Convert.ToByte(strIn.Substring(i, 2));
                    sbOut += (char)(code ^ strKey[(i / 2) % strKey.Length]);
                    }

                return sbOut;
                }
            }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
            {
            this.Close();
            }
        }
    }
